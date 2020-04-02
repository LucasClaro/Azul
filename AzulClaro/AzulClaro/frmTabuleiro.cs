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
            for (int i = 0; i < partida.qtdFabricas; i++)
            {
                cboNumFab.Items.Add(i.ToString());
            }

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

            //35 F40397 Usuário pra entrar na partida IgorTeste

            //Desenahr azulejos aqui
            pcbFabricas.Image = Properties.Resources.f5;
            definePos(partida.qtdFabricas);
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

        //Função que tira os azulejos da tela a coloca de novo
        public void atualizarAzulejos()
        {
            tirarAzulejos();
            desenharAzulejos();
        }

        //Arruma os azulejos em quadrado em cima das fábricas
        public void desenharAzulejos()
        {
            int i;
            int ang = 0;
            foreach (Fabrica fab in partida.fabricas) //Para cada fabrica na aprtida
            {
                i = 0; //Qual é o azulejo, vai de 0 a 3
                ang = 0; //Qual o angulo, será usado para definir se fica em cima ou em baixo

                foreach (Azulejo azul in fab.azulejos) //Para cada azulejo da fabrica
                {
                    for (int j = 0; j < azul.quantidade; j++) //Ver a quantidade de azulejos
                    {
                        if(i % 2 == 0) // Ver se é o 1º, 2º, 3º ou 4º e coloca um angulo pra cima ou baixo;
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
                        pcbAzul.Name = "azul" + fab.id +""+i    ;
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
        private void pcbFabricas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Cursor.Position.X + " , " + Cursor.Position.Y);
        }

        //Posição do centro das fábricas
        //Sentido horário
        //Define X e Y das fabricas na lista
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
        }

        //Tira os PictureBoxs dos azulejos da tela e atribui null a eles;
        public void tirarAzulejos()
        {
            List<Control> pcbs = new List<Control>(); //Lista dos PictureBoxs
            foreach(Control pcb in Controls)
            {
                if(pcb.GetType() == typeof(PictureBox)) //Vê na lista de controles quais são PictureBoxs
                {
                    pcbs.Add(pcb);
                }
            }

            pcbs.Remove(pcbs.Find(pcb => pcb.Name.Equals("pcbFabricas"))); //Remove o PictureBox do fundo (Fabricas)

            for (int i = 0; i < pcbs.Count; i++)
            {
                Controls.Remove(pcbs[i]);       //Remove do Form
                pcbs[i] = null;                 //Deixa null a PictureBox (e torcer para o GC fazer o resto)
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            atualizarAzulejos();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string tipo;
            int fab = 0;
            int cor = cboCor.SelectedIndex + 1;
            int modelo = cboModelo.SelectedIndex + 1;
            if (rdbFab.Checked)
            {
                tipo = "f";
                fab = Convert.ToInt32(cboNumFab.SelectedItem);

            }
            else
            {
                tipo = "c";
            }

            Jogo.Jogar(jogador.id, jogador.senha, tipo, fab, cor, modelo);
        }

        private void btnVez_Click(object sender, EventArgs e)
        {
            string txt = Jogo.VerificarVez(jogador.id, jogador.senha);
            lblVez.Text = "jogador: " + txt;
        }
    }
}
