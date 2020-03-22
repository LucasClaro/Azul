﻿using System;
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
            cboStatusPartida.SelectedIndex = 0;//Define a opção "Todos" como padrão na combo box de status da seleção de partida

            lblVersao.Text = "Versão: " + Jogo.Versao;//Exibe a versão da dll
            ListarPartidas();//Já inicia o cliente com as partidas preenchidas
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
                if (partida != "")//Resolve o bug do elemento fantasma no fim
                {
                    existe1 = true;
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
                string txt = Jogo.ListarJogadores(partida.id);//Recebe todas as partidas filtrando pelo status
                txt = txt.Replace("\r", "");//corta o caracter /r do retorno
                string[] jogadores = txt.Split('\n');//Separa as linhas do retorno              

                foreach (string jogador in jogadores)//preenche a lista de jogadores
                {
                    if (jogador != "")//Resolve o bug do elemento fantasma no fim
                    {
                        lstJogadores.Items.Add(jogador);//Adiciona os textos na List Box

                        string[] jogadorFormatado = jogador.Split(',');//Separa cada elemento do jogador

                        Jogador j = new Jogador();//Cria os jogadores que vão ser inseridos no Objeto Partida
                        j.id = Convert.ToInt32(jogadorFormatado[0]);//Preenche os Objetos
                        j.nome = jogadorFormatado[1];
                        j.pontos = Convert.ToInt32(jogadorFormatado[2]);

                        partida.jogadores.Add(j);//Adiciona os objetos na partida                        
                    }
                }
            }
        }

        //Botão listar partidas
        private void btnListPartidas_Click(object sender, EventArgs e)
        {
            ListarPartidas();//Só chama essa função para ela poder ser acessada por outros lugares
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

            int i = cboPartidas.SelectedIndex;//Guarda o item selecionado para caso a criação seja cancelar a combo ficar no mesmo lugar

            ListarPartidas();//Atualiza a combo de partidas
           
            if(IdPartidaCriada > 0)//Não mexe na combo se a criação foi cancelada
            {
                int max = cboPartidas.Items.Count;//Descobre a quantidade de elementos na combo (pode falahar quando tiver muita gente usando)
                cboPartidas.SelectedIndex = max - 1;//Seleciona a última partida criada (se não for criada outra no mesmo instante), isso atualiza o campo de Id junto
            }
            else
            {
                cboPartidas.SelectedIndex = i;
            }
           
            txtSenhaEntrar.Text = senha;//Coloca a senha da partida criada no campo de senha para jogar
        }        

        //Alterar Combo de partidas
        private void cboPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPartidas.SelectedItem != null)//preenche o campo Id quando selecionar uma linha
            {
                string txt = cboPartidas.SelectedItem.ToString();
                string[] txt2 = txt.Split(',');
                txtIdPartida.Text = txt2[0];  
                

                partida = new Partida();//Instancia e preenche o Objeto partida
                partida.jogadores = new List<Jogador>();
                partida.id = Convert.ToInt32(txt2[0]);
                partida.nome = txt2[1];
                partida.status = txt2[3];

                ListarJogadores();//Att a lista de jogadores
            }
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

            int i = cboPartidas.SelectedIndex;//Atualiza as partidas e deixa a partida atual selecionada
            ListarPartidas();
            cboPartidas.SelectedIndex = i;
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
    }    
}