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
            InitializeComponent();
        }

        private void frmTabuleiro_Load(object sender, EventArgs e)
        {
            lblCabecalho.Text = "Partida: " + partida.nome;
            DesenharFabricas();///////////////
            pcbTeste.Location = new Point(337, 154);
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

            //Desenahr fabricas aqui

        }

        private void pcbFabricas_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(e.X);

            //Posição do centro das fábricas
            //5:
            //337; 154
            //569; 365
            //497; 635
            //175; 636
            //103; 367
        }


    }
}
