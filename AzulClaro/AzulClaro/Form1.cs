using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzulServer;

namespace AzulClaro
{
    public partial class Form1 : Form
    {
        Partida partida;//Objeto partida. Será usado para desenhar o jogo
        Jogador jogador;//Objeto jogador. Será usado para jogar

        //NOTAS
        //Redesenhar só as coisas que foram mudadas baseadas no histórico

        //Ao criar uma partida com um nome que já existe, ele não cria nem dá erro

        //Criar as funções de jogar como public
        //Se ela for chamada pelo botão, ler os campos de txt
        //Se ela for chamada pelo Objeto, ler o próprio objeto
        
        //Se for um bot, chama a(s) funções do obj e só
        //Se for um player, ler o comando dele e chame o jogar do Form

        //Talvez a função jogar daqui (Form1) só seja usada pelo player

        //Talvez seja preciso colocar uma Check Box junto a criação de personagem para saber se é uma pessoa ou um bot

        public Form1()
        {
            InitializeComponent();

            lblVersao.Text = "Versão: " + Jogo.Versao;//Exibe a versão da dll            

            ListarPartidas();//Já inicia o cliente com as partidas preenchidas

            lblErroIniciar.Text = "";
            lblErroEntrarPartida.Text = "";

            //Configura a DataGridView
            dgvPartidas.RowHeadersVisible = false;
            dgvPartidas.ReadOnly = true;
            dgvPartidas.Columns[0].Visible = false;
            dgvPartidas.AllowUserToResizeRows = false;
            //gvwPartidas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPartidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPartidas.MultiSelect = false;
            //gvwPartidas.Columns[4].Width = 100;
            //gvwPartidas.Columns[5].Width = 75;

            dgvPartidas.Rows[0].Selected = true;//Seleciona a linha mais nova

            partida = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;
            txtIdPartida.Text = partida.id.ToString();
            ListarJogadores();
        }

        //Antigo código do botão listar partidas
        //Movido pra cá para ser acessado por mais lugares
        public void ListarPartidas()
        {
            string status = "";
            if (rdbTodos.Checked)
                status = "T";
            else if(rdbAbertas.Checked)
                status = "A";
            else
                status = "E";

            dgvPartidas.DataSource = Partida.Listarpartidas(status);
        }

        public void ListarJogadores()
        {
            partida.jogadores = new List<Jogador>();
            lstJogadores.Items.Clear();//Limpa a combo box para preencher novamente
            if (partida != null)
            {
                bool existe = false;
                string txt = Jogo.ListarJogadores(partida.id);//Recebe todas as partidas filtrando pelo status
                txt = txt.Replace("\r", "");//corta o caracter /r do retorno
                string[] jogadores = txt.Split('\n');//Separa as linhas do retorno              

                foreach (string jogador in jogadores)//preenche a lista de jogadores
                {
                    if (jogador != "")//Resolve o bug do elemento fantasma no fim
                    {
                        existe = true;
                        lstJogadores.Items.Add(jogador);//Adiciona os textos na List Box

                        string[] jogadorFormatado = jogador.Split(',');//Separa cada elemento do jogador

                        Jogador j = new Jogador();//Cria os jogadores que vão ser inseridos no Objeto Partida
                        j.id = Convert.ToInt32(jogadorFormatado[0]);//Preenche os Objetos
                        j.nome = jogadorFormatado[1];
                        j.pontos = Convert.ToInt32(jogadorFormatado[2]);

                        partida.jogadores.Add(j);//Adiciona os objetos na partida                        
                    }
                }

                if (!existe)
                {
                    lstJogadores.Items.Add("[Sem Jogadores]");
                }
            }
        }

        //Botão listar partidas
        private void btnListPartidas_Click(object sender, EventArgs e)
        {
            ListarPartidas();//Só chama essa função para ela poder ser acessada por outros lugares
            txtIdPartida.Text = "";
            txtSenhaEntrar.Text = "";
            lstJogadores.Items.Clear();
            partida = null;
        }

        //Botão Listar Jogadores
        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            ListarJogadores();//Só chama essa função para ela poder ser acessada por outros lugares
        }

        //Botão Criar Partida
        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            frmCriarPartida frmCriarPartida = new frmCriarPartida();//Chama o formulário de nova partida
            frmCriarPartida.ShowDialog();
            int IdPartidaCriada = frmCriarPartida.idPartidaCriada;//Lê o id e a senha criada nesse form    
            string senha = frmCriarPartida.senha;

            ListarPartidas();//Atualiza a combo de partidas

            if(IdPartidaCriada != 0)
            {
                txtSenhaEntrar.Text = senha;//Coloca a senha da partida criada no campo de senha para jogar
                
                dgvPartidas.Rows[dgvPartidas.Rows.Count - 1].Selected = true;//Seleciona a linha mais nova

                partida = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;
                txtIdPartida.Text = partida.id.ToString();
                ListarJogadores();
            }                
        }        

        //Clicar na DataGridView
        private void dgvPartidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            partida = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;
            txtIdPartida.Text = partida.id.ToString();
            ListarJogadores();
        }
        
        //Botão Entrar na Partida
        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            if(txtIdPartida.Text != "")//Confere se o Id está preenchido
            {
                string txt;
                string[] txtRecortado;
                int id = Convert.ToInt32(txtIdPartida.Text);//Lê os dados requeridos para entrar na partida
                string nome = txtNomeJogador.Text;
                string senha = txtSenhaEntrar.Text;
                if (nome != "" && senha != "")//Tenta adicionar o jogador
                {                    
                    txt = Jogo.EntrarPartida(id, nome, senha);//Cria o jogador e lê see Id e senha

                    if(txt.Substring(0,4) != "ERRO")//Confere se não houve erro ao entrar na Partida
                    {
                        txtRecortado = txt.Split(',');//Formata o retorno para colocar no Objeto


                        jogador = new Jogador();
                        jogador.nome = txtNomeJogador.Text;//Preenche o Objeto jogador
                        jogador.id = Convert.ToInt32(txtRecortado[0]);
                        jogador.senha = txtRecortado[1];
                        jogador.bot = chkBot.Checked;

                        txtIdjogador.Text = txtRecortado[0];//Preenche os campos da tela
                        txtSenhaJogador.Text = txtRecortado[1];

                        lblErroEntrarPartida.Text = "";//Remove a mensagem de Erro
                    }
                    else//Exibe a mensagem de erro do servidor
                    {
                        lblErroEntrarPartida.Text = txt.Substring(5);
                        tmrMsgErro.Enabled = true;
                    }
                }
                else//Ou exibe essa mensagem de erro
                {
                    lblErroEntrarPartida.Text = "Preencha seu nome e a senha da partida";
                    tmrMsgErro.Enabled = true;
                }
            }
            else//Ou exibe essa mensagem de erro caso o Id esteja vazio
            {
                lblErroEntrarPartida.Text = "Preencha o Id da partida";
                tmrMsgErro.Enabled = true;
            }
            ListarJogadores();//Atualiza os jogadores
        }

        //10 segundos com a mesma mensagem de Erro
        private void tmrMsgErro_Tick(object sender, EventArgs e)
        {
            lblErroEntrarPartida.Text = "";
            lblErroIniciar.Text = "";
            tmrMsgErro.Enabled = false;
        }

        //Botão Iniciar partida
        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            if (txtIdjogador.Text != "" && txtSenhaJogador.Text != "")
            {
                //Vê se a partida tá aberta
                if (partida.status == "A")
                {
                    string txt = Jogo.IniciarPartida(Convert.ToInt32(txtIdjogador.Text), txtSenhaJogador.Text);
                    if (txt.Length < 3)
                    {
                        partida.status = "J";
                    }
                }

                if (partida.status == "J")//Abre o Tabuleiro
                {
                    if(jogador == null)//Preenche o jogado caso ele esteja vazio para mandar para o Tabuleiro
                    {                        
                        jogador = new Jogador();
                        jogador.id = Convert.ToInt32(txtIdjogador.Text);
                        jogador.senha = txtSenhaJogador.Text;
                        jogador.nome = BuscarJogById(jogador.id);
                    }

                    frmTabuleiro tabuleiro = new frmTabuleiro(partida, jogador);
                    tabuleiro.ShowDialog();

                    lblErroIniciar.Text = tabuleiro.erro;
                    tmrMsgErro.Enabled = true;
                }
                else
                {
                    lblErroIniciar.Text = "Partida ja encerrou";
                }                    
            }
            else
            {
                lblErroIniciar.Text = "Preencha o Id e a Senha do Jogador";
                tmrMsgErro.Enabled = true;
                return;//Sai da função ao falhar em iniciar a partida;
            }
            
            jogador = null;

            ListarPartidas();
        }

        //Usado no iniciar partida
        public string BuscarJogById(int id)
        {
            foreach (Jogador jogador in partida.jogadores)
            {
                if(jogador.id == id)
                {
                    return jogador.nome;
                }
            }

            return "";
        }

        
        //Fecahr Minimizar
        private void pcbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //Mover janela
        private  Point downPoint = Point.Empty;

        private void pnlBarraWindows_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = Point.Empty;
        }

        private void pnlBarraWindows_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint != Point.Empty)
                Location = new Point(Left + e.X - downPoint.X, Top + e.Y -downPoint.Y);
        }

        private void pnlBarraWindows_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                downPoint = new Point(e.X, e.Y);
            }
        }


    }    
}