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
        }

        public void DesenharFabricas()
        {
            string txt;

            txt = Jogo.LerFabricas(jogador.id, jogador.senha);

            if (txt.Substring(0, 4) == "ERRO")
            {
                this.erro = txt.Substring(5);
                Close();
                
            }

            textBox1.Text = txt;

            partida.preencherFabricas(txt);//Preenche as fábricas do obj partida

            //60 4E050C  Usuário pra entrar na partida IgorTeste

            //Desenahr azulejos aqui
            int qtdfab = partida.fabricas.Count();
            definePos(qtdfab);
            desenharAzulejos();
        }

        public void desenharAzulejos()
        {
            List<Fabrica> lista = partida.fabricas;
            int i;
            foreach (Fabrica fab in lista)
            {
                i = 0;
                foreach (Azulejo azul in fab.azulejos)
                {
                    for (int j = 0; j < azul.quantidade; j++)
                    {
                        PictureBox pcbAzul = new PictureBox();
                        pcbAzul.Image = azul.image;
                        pcbAzul.Location = new Point(fab.x - 100 + i, fab.y - 50);
                        i += 50;
                        pcbAzul.Width = 50;
                        pcbAzul.Height = 50;
                        pcbAzul.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.Controls.Add(pcbAzul);
                        pcbAzul.BringToFront();
                    }
                }
            }
        }

        private void pcbFabricas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Cursor.Position.X + " , " + Cursor.Position.Y);

            //Posição do centro das fábricas
            //Sentido horário

            //5:
            //337; 154
            //569; 365
            //497; 635
            //175; 636
            //103; 367
        }

        //Define X e Y das fabricas na lista manualmente, pensar num jeito automatizado pra fazer
        public void definePos(int qtd)
        {
            int[] posX = { 345, 577, 505, 183, 133 };
            int[] posY = { 185, 397, 667, 667, 397 };
            switch(qtd)
            {
                case 5:
                    for (int i = 0; i < qtd; i++)
                    {
                        partida.fabricas[i].x = posX[i];
                        partida.fabricas[i].y = posY[i];
                    }
                    break;
            }
        }
    }
}
