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
        public Form1()
        {
            InitializeComponent();
            cboStatusPartida.SelectedIndex = 0;//Define a opção "Todos" como padrão na combo box de status da seleção de partida

            lblVersao.Text = "Versão: " + Jogo.Versao;//Exibe a versão da dll
        }

        //Antigo código do botão listar partidas
        //Movido pra cá para ser acessado por mais lugares
        public void ListarPartidas()
        {
            bool existe1 = false;//Controla se existe pelo menos uma partida como resultado

            string status = cboStatusPartida.SelectedItem.ToString().Substring(0, 1);//Pega o primeiro caracter da combo box de status da seleção de partida
            string txt = Jogo.ListarPartidas(status);//Recebe todas as partidas filtrando pelo status

            txt = txt.Replace("\r", "");//corta o caracter /r do retorno
            string[] partidas = txt.Split('\n');//Separa as linhas do retorno

            cboPartidas.Items.Clear();//Limpa a combo box para preencher novamente
            foreach (string partida in partidas)//preenche a combo box
            {
                existe1 = true;
                if (partida != "")//Resolve o bug do elemento fantasma no fim
                {
                    cboPartidas.Items.Add(partida);
                }
            }
            if (existe1)//Seleciona a primeira partida
            {
                cboPartidas.SelectedIndex = 0;
            }
        }

        public void ListarJogadores()
        {
            lstJogadores.Items.Clear();//Limpa a combo box para preencher novamente
            if (txtIdPartida.Text != "")
            {
                int id = Convert.ToInt32(txtIdPartida.Text);//Lê id e senha da nova partida
                string txt = Jogo.ListarJogadores(id);//Recebe todas as partidas filtrando pelo status
                txt = txt.Replace("\r", "");//corta o caracter /r do retorno
                string[] jogadores = txt.Split('\n');//Separa as linhas do retorno

                foreach (string jogador in jogadores)//preenche a lista de jogadores
                {
                    if (jogador != "")//Resolve o bug do elemento fantasma no fim
                    {
                        lstJogadores.Items.Add(jogador);
                    }
                }
            }
        }

        //Botão listar partidas
        private void btnListPartidas_Click(object sender, EventArgs e)
        {
            ListarPartidas();//Só chama essa função para ela poder ser acessada por outros lugares
        }

        //Botão Criar Partida
        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            frmCriarPartida frmCriarPartida = new frmCriarPartida();//Chama o formulário de nova partida
            frmCriarPartida.ShowDialog();
            string senha = frmCriarPartida.senha;//Lê a senha criada nesse form

            ListarPartidas();//Atualiza a combo de partidas
            int max = cboPartidas.Items.Count;//Descobre a quantidade de elementos na combo (pode falahar quando tiver muita gente usando)
            cboPartidas.SelectedIndex = max - 1;//Seleciona a última partida criada (se não for criada outra no mesmo instante), isso atualiza o campo de Id junto
            txtSenhaEntrar.Text = senha;//Coloca a senha da partida criada no campo de senha para jogar
        }

        //Botão Listar Jogadores
        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            ListarJogadores();//Só chama essa função para ela poder ser acessada por outros lugares
        }

        //Alterar combo de partidas
        private void cboPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPartidas.SelectedItem != null)//preenche o campo Id quando selecionar uma linha
            {
                string txt = cboPartidas.SelectedItem.ToString();
                string[] partida = txt.Split(',');
                txtIdPartida.Text = partida[0];
            }
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            if(txtIdPartida.Text != "")//Confere se o Id está preenchido
            {
                int id = Convert.ToInt32(txtIdPartida.Text);//Lê os dados requeridos para entrar na partida
                string nome = txtNomeJogador.Text;
                string senha = txtSenhaEntrar.Text;
                if (nome != "" && senha != "")//Tenta adicionar o jogador
                {
                    Jogo.EntrarPartida(id, nome, senha);
                    lblErroEntrarPartida.Text = "";
                }
                else//Ou exibe essa mensagem de erro
                {
                    lblErroEntrarPartida.Text = "Preencha seu nome e a senha da partida";
                }
            }
            else//Ou exibe essa mensagem de erro caso o Id esteja vazio
            {
                lblErroEntrarPartida.Text = "Preencha o Id da partida";
            }
            ListarJogadores();//Atualiza os jogadores
        }
    }
}
