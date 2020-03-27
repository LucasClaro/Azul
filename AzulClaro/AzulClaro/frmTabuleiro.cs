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
    public partial class frmTabuleiro : Form
    {
        public string erro { get; set; }
        public Partida partida { get; set; }
        public Jogador jogador { get; set; }

        public frmTabuleiro(Partida partida, Jogador jogador)
        {
            this.partida = partida;
            this.jogador = jogador;
            this.Location = new Point(0, 0);
            InitializeComponent();
        }

        private void frmTabuleiro_Load(object sender, EventArgs e)
        {
            lblCabecalho.Text = "Partida: " + partida.nome;
            DesenharFabricas();///////////////
            DesenharCentro();
        }
        
        public void DesenharFabricas()
        {
            string txtF;

            txtF = Jogo.LerFabricas(jogador.id, jogador.senha);
            

            if (txtF.Substring(0, 4) == "ERRO")
            {
                this.erro = txtF.Substring(5);
                Close();                
            }                        

            partida.preencherFabricas(txtF);//Preenche as fábricas do obj partida

            //227 86A3EB  Usuário pra entrar na partida IgorTeste

            //Desenahr azulejos aqui
            int qtdfab = partida.fabricas.Count();
            pcbFabricas.Image = Properties.Resources.f5;
            definePos(qtdfab);
            desenharAzulejos();
        }

        public void DesenharCentro()
        {
            string txtC;
            txtC = Jogo.LerCentro(jogador.id, jogador.senha);

            if (txtC.Substring(0, 4) == "ERRO")
            {
                this.erro = txtC.Substring(5);
                Close();
            }

            textBox1.Text = txtC;
        }

        public void desenharAzulejos()
        {
            int i;
            int ang = 0;
            foreach (Fabrica fab in partida.fabricas)
            {
                i = 0;
                ang = 0;
                foreach (Azulejo azul in fab.azulejos)
                {
                    for (int j = 0; j < azul.quantidade; j++)
                    {
                        if(i % 2 == 0)
                        {
                            ang = 90;
                        }
                        else
                        {
                            ang = 270;
                        }
                        PictureBox pcbAzul = new PictureBox();
                        pcbAzul.Image = azul.image;
                        int x = fab.x - 60;
                        if (i > 1) x += 52;
                        pcbAzul.Location = new Point(x, fab.y + 26 * Convert.ToInt32(Math.Round(Math.Sin(ang * Math.PI / 180))) - 55);
                        i++;
                        pcbAzul.Width = 50;
                        pcbAzul.Height = 50;
                        pcbAzul.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.Controls.Add(pcbAzul);
                        pcbAzul.BringToFront();
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
        private void pcbFabricas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Cursor.Position.X + " , " + Cursor.Position.Y);
        }

        //Posição do centro das fábricas
        //Sentido horário
        //Define X e Y das fabricas na lista
        public void definePos(int qtd)
        {
            int[] posX = { };// = { 345, 577, 505, 183, 113 };
            int[] posY = { };// = { 185, 397, 667, 667, 397 };
            switch(qtd)
            {
                case 5:
                    pcbFabricas.Image = Properties.Resources.f5;
                    posX = new int[] { 345, 577, 505, 183, 113 };
                    posY = new int[] { 185, 397, 667, 667, 397 };
                    break;
                case 7:
                    pcbFabricas.Image = Properties.Resources.f7;
                    posX = new int[] { 345, 555, 590, 460, 230, 103, 135 };
                    posY = new int[] { 185, 290, 505, 665, 665, 505, 290 };
                    break;
                case 9:
                    pcbFabricas.Image = Properties.Resources.f9;
                    posX = new int[] { 345, 518, 592, 574, 426, 245, 122, 102, 174 };
                    posY = new int[] { 175, 223, 388, 548, 672, 672, 548, 388, 223 };
                    break;
            }

            for (int i = 0; i < qtd; i++)
            {
                partida.fabricas[i].x = posX[i];
                partida.fabricas[i].y = posY[i];
            }
        }
    }
}
