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
    public partial class frmTabuleiro : Form
    {
        public string erro { get; set; }
        public Partida partida { get; set; }
        public Jogador jogador { get; set; }
        public Compra compra { get; set; }

        public frmTabuleiro(Partida partida, Jogador jogador)
        {
            this.partida = partida;
            this.jogador = jogador;
            this.Location = new Point(0, 0);
            InitializeComponent();
        }//Construtor: preenche os objetos partida e jogador

        private void frmTabuleiro_Load(object sender, EventArgs e)
        {
            lblCabecalho.Text = "Partida: " + partida.nome;

            if (verificaLogin().Equals("ERRO"))//Confere senha do jogador
            {
                this.Close();
            }
            else
            {
                //Preenche Tudo
                configurarFabricas();
                desenharCentro();                
                desenharFabricas();
                desenharTabuleiro();
            }
        }//Load do form: Verifica senha e Desenha Tudo

        /////////////////////////////////////////////////////////////

        public string verificaLogin()
        {
            string txtF;

            txtF = Jogo.LerFabricas(jogador.id, jogador.senha);

            if (txtF.Equals("")) { return "NAODEUERRO"; }
            else if (txtF.Substring(0, 4) == "ERRO")
            {
                this.erro = txtF.Substring(5);
                this.Close();
                return "ERRO";
            }
            return "NAODEUERRO";
        }//Verifica senha do Jogador

        /////////////////////////////////////////////////////////////

        public void configurarFabricas()
        {
            string txtF;

            txtF = Jogo.LerFabricas(jogador.id, jogador.senha);

            if (txtF.Equals("")) { }
            else if (txtF.Substring(0, 4) == "ERRO")
            {
                this.erro = txtF.Substring(5);
                this.Close();
                return;
            }                        

            partida.preencherFabricas(txtF);//Preenche as fábricas do obj partida
           
        }//Configura Texto das fábricas e chama preencher fabricas da partida
        public void desenharFabricas()
        {
            int i;
            int ang = 0;

            definePos(partida.qtdFabricas);

            foreach (Fabrica fab in partida.fabricas) //Para cada fabrica na aprtida
            {
                i = 0; //Qual é o azulejo, vai de 0 a 3
                ang = 0; //Qual o angulo, será usado para definir se fica em cima ou em baixo

                foreach (Azulejo azul in fab.azulejos) //Para cada azulejo da fabrica
                {
                    for (int j = 0; j < azul.quantidade; j++) //Ver a quantidade de azulejos
                    {
                        if (i % 2 == 0) // Ver se é o 1º, 2º, 3º ou 4º e coloca um angulo pra cima ou baixo;
                            ang = 90;
                        else
                            ang = 270;

                        PictureBox pcbAzul = new PictureBox(); //Azulejo
                        pcbAzul.Image = azul.image;
                        int x = fab.x - 60;                    //Pega o centro da fabrica e volta 50
                        if (i > 1) x += 52;                    //Se for o 3º e 4º azulejo, move eles pro lado
                        pcbAzul.Location = new Point(x, fab.y + 26 * Convert.ToInt32(Math.Round(Math.Sin(ang * Math.PI / 180))) - 55); //Define a posição do azulejo x -> calculado anteriomente, y -> y da fabrica + ou - sen do ang
                        i++;
                        pcbAzul.Width = 50;
                        pcbAzul.Height = 50;
                        pcbAzul.SizeMode = PictureBoxSizeMode.StretchImage;
                        pcbAzul.Name = "azul" + fab.id + "" + i;

                        pcbAzul.AccessibleName = "f" + fab.id + azul.id + azul.quantidade;//Informações para o carrinho
                        pcbAzul.Click += azulejo_Click;

                        this.Controls.Add(pcbAzul);            //Adiciona no form
                        pcbAzul.BringToFront();                //Puxa pra frente
                    }
                }
            }
        }//Chama definePos e desenha seus azulejos
        public void desenharCentro()
        {
            string txtC;
            txtC = Jogo.LerCentro(jogador.id, jogador.senha);

            if (txtC.Substring(0, 4) == "ERRO")
            {
                this.erro = txtC.Substring(5);
                Close();
                return;
            }

            partida.preencherCentro(txtC);
            //Desenhar centro controla i e j
            //Vai do canto superior esquerdo e somando +50 (altura e largura)
            //Quando atingir um certo numero no horizontal, incrementar 1 na altura e zerar horizontal e ir até acabar
            int Xcentro = 0, Ycentro = 0,qtdAzul = 0;
            Point[] points = partida.centro.organizarEmLinhas();
            int w = 0;

            foreach(Azulejo azul in partida.centro.azulejos)
            {
                for(int i = 0; i < azul.quantidade; i++)
                {
                    PictureBox pcbAzul = new PictureBox(); //Azulejo
                    pcbAzul.Image = azul.image;

                    //pcbAzul.Location = new Point(190 + 50 * Xcentro, 265 + 50 * Ycentro);
                    pcbAzul.Location = points[w++];

                    pcbAzul.Width = 50;
                    pcbAzul.Height = 50;
                    pcbAzul.SizeMode = PictureBoxSizeMode.StretchImage;
                    pcbAzul.Name = "centro" + "" + i;

                    pcbAzul.AccessibleName = "c0" + azul.id + azul.quantidade;//Informações para o carrinho
                    pcbAzul.Click += azulejo_Click;

                    this.Controls.Add(pcbAzul);            //Adiciona no form
                    pcbAzul.BringToFront();                //Puxa pra frente

                    //if (qtdAzul++ > 4)
                    //{
                    //    Xcentro = 0;
                    //    Ycentro++;
                    //    qtdAzul = 0;
                    //}
                    //else
                    //    Xcentro++;
                }
            }
        }//Configura Texto do centro, chama preencher centro e desenha seus azulejos
        public void definePos(int qtd)
        {
            int[] posX = { }; //Array dos Xs dos centros das fabricas
            int[] posY = { }; //Array dos Ys dos centros das fabricas
            switch (qtd)
            {
                case 5:
                    pcbFabricas.Image = Properties.Resources.f5; //5 fabricas
                    posX = new int[] { 345, 577, 505, 183, 113 };
                    posY = new int[] { 185, 397, 667, 667, 397 };
                    break;
                case 7:
                    pcbFabricas.Image = Properties.Resources.f7; //7 fabricas
                    posX = new int[] { 345, 555, 590, 460, 230, 103, 135 };
                    posY = new int[] { 185, 290, 505, 665, 665, 505, 290 };
                    break;
                case 9:
                    pcbFabricas.Image = Properties.Resources.f9; //9 fabricas
                    posX = new int[] { 345, 518, 592, 574, 426, 245, 122, 102, 174 };
                    posY = new int[] { 175, 223, 388, 548, 672, 672, 548, 388, 223 };
                    break;
            }

            //Define as posições    
            for (int i = 0; i < qtd; i++)
            {
                partida.fabricas[i].x = posX[i];
                partida.fabricas[i].y = posY[i];
            }
        }//Define a posição das fábricas

        /////////////////////////////////////////////////////////////

        public void atualizarAzulejos()
        {
            tirarAzulejos();

            configurarFabricas();
            desenharCentro();
            desenharFabricas();
        }//Função que tira os azulejos da tela a coloca de novo     
        public void tirarAzulejos()
        {
            List<Control> pcbs = new List<Control>(); //Lista dos PictureBoxs
            foreach (Control pcb in Controls)
            {
                if (pcb.GetType() == typeof(PictureBox)) //Vê na lista de controles quais são PictureBoxs
                {
                    pcbs.Add(pcb);
                }
            }

            pcbs.Remove(pcbs.Find(pcb => pcb.Name.Equals("pcbFabricas"))); //Remove o PictureBox do fundo (Fabricas)

            for (int i = 0; i < pcbs.Count; i++)
            {
                Controls.Remove(pcbs[i]);       //Remove do Form
                pcbs[i] = null;                 //Deixa null a PictureBox
            }
        }//Tira os PictureBoxes dos azulejos da tela e atribui null a eles (e torce para o GC fazer o resto);

        /////////////////////////////////////////////////////////////                    

        private void btnVez_Click(object sender, EventArgs e)
        {
            string txt = Jogo.VerificarVez(jogador.id, jogador.senha);
            lblVez.Text = "jogador: " + txt;
        }//Botão Vez: printa a vez
        private void Button1_Click(object sender, EventArgs e)
        {
            atualizarAzulejos();

            textBox1.Text = Jogo.LerTabuleiro(jogador.id, jogador.senha, jogador.id);
            desenharTabuleiro();
        }//Recarrega azulejos (REMOVER)
        public void Jogar()
        {
            Jogo.Jogar(jogador.id, jogador.senha, compra.tipo, compra.fabrica, compra.azulejo, compra.modelo);
            atualizarAzulejos();
            compra = null;
        }//Manda um pedido de compra
        private void azulejo_Click(object sender, EventArgs e)
        {
            compra = new Compra();//Instacia o objeto compra

            PictureBox pcb = (PictureBox)sender;//Recebe a picturebox que mandou o evento

            //Preence o objeto compra
            compra.tipo = pcb.AccessibleName.Substring(0,1);
            compra.fabrica = Convert.ToInt32(pcb.AccessibleName.Substring(1, 1));
            compra.azulejo = Convert.ToInt32(pcb.AccessibleName.Substring(2, 1));
            compra.qtd = Convert.ToInt32(pcb.AccessibleName.Substring(3, 1));

            string cor = Azulejo.LembraCor(compra.azulejo, compra.qtd > 1);//Pega a cor na função da classe azulejo, essa comparação diz se é plural ou não
            string azu = "azulejo";//Pego o plural ou o singular de Azulejos
            if (compra.qtd > 1)
                azu += "s";
            string dx;//Vê se a compra é da fábrica ou do centro
            if (compra.tipo == "f")
                dx = "da fábrica " + compra.fabrica;
            else
                dx = "do centro";

            lblCompra.Text = "Compra: " + compra.qtd + " " + azu + " " + cor + " " + dx;//Escreve a corrinho de compras na tela

        }//Clique em um azulejo das fábricas e centro: adiciona o azulejo no carrinho     
        private void btnModelo1_Click(object sender, EventArgs e)
        {
            compra.modelo = 1;
            Jogar();
        }//Botão modelo 1: Chama jogar mandando 1 como modelo
        private void btnModelo2_Click(object sender, EventArgs e)
        {
            compra.modelo = 2;
            Jogar();
        }//Botão modelo 2: Chama jogar mandando 2 como modelo
        private void btnModelo3_Click(object sender, EventArgs e)
        {
            compra.modelo = 3;
            Jogar();
        }//Botão modelo 3: Chama jogar mandando 3 como modelo
        private void btnModelo4_Click(object sender, EventArgs e)
        {
            compra.modelo = 4;
            Jogar();
        }//Botão modelo 4: Chama jogar mandando 4 como modelo
        private void btnModelo5_Click(object sender, EventArgs e)
        {
            compra.modelo = 5;
            Jogar();
        }//Botão modelo 5: Chama jogar mandando 5 como modelo

        public void desenharTabuleiro()
        {
            jogador.preencherTabuleiro(jogador.id, jogador.senha);
            //C9C4F5

            /* ======= MODELO ======= */
            //superior esquerdo 1 do modelo 1 - 1025,100
            for (int i = 0; i < jogador.tabuleiro.modelo.Length; i++)
            {
                if (jogador.tabuleiro.modelo[i] != null)
                {
                    for (int j = 0; j < jogador.tabuleiro.modelo[i].quantidade; j++)
                    {
                        PictureBox pcbAzul = new PictureBox(); //Azulejo
                        pcbAzul.Image = jogador.tabuleiro.modelo[i].image;
                        pcbAzul.Location = new Point(1025 - 50 * j, 100 + (50 * i));
                        Console.WriteLine(i + " " + jogador.tabuleiro.modelo[i].id + " x= " + (1025 - 50 * j) +" y= "+ (100 + 50 * i));
                        pcbAzul.Width = 50;
                        pcbAzul.Height = 50;
                        pcbAzul.SizeMode = PictureBoxSizeMode.StretchImage;
                        pcbAzul.Name = "modelo" + "" + i + "" + jogador.tabuleiro.modelo[i].id + "" + j;

                        this.Controls.Add(pcbAzul);            //Adiciona no form
                        pcbAzul.BringToFront();                //Puxa pra frente
                    }
                }
            }

            /* ======= PAREDE ======= */

            /* ======= CHÃO ======= */
            int c = 0;
            foreach (Azulejo azul in jogador.tabuleiro.chao)
            {
                PictureBox pcbAzul = new PictureBox(); //Azulejo
                pcbAzul.Image = azul.image;
                pcbAzul.Location = new Point(800 + 50 * c , 400);
                pcbAzul.Width = 50;
                pcbAzul.Height = 50;
                pcbAzul.SizeMode = PictureBoxSizeMode.StretchImage;
                pcbAzul.Name = "chao" + "" + c;

                this.Controls.Add(pcbAzul);            //Adiciona no form
                pcbAzul.BringToFront();                //Puxa pra frente
            }
        }
    }
}


//O porquê do cos(270) retornar -1
//https://stackoverflow.com/questions/9652695/why-does-math-cos90-math-pi-180-yield-6-123031769111-and-not-zero
//https://stackoverflow.com/questions/6082632/math-cos-math-sin-in-c-sharp
/* Define posição antigo, deixava os azulejos em cruz
           pcbAzul.Location = new Point(fab.x + 50 * Convert.ToInt32(Math.Round(Math.Cos((ang * Math.PI)/180))), fab.y + 50 * Convert.ToInt32(Math.Round(Math.Sin(ang * Math.PI / 180))) - 50);
           ang += 90;
*/
