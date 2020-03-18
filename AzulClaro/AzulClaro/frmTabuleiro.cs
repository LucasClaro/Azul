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
            lblCabecalho.Text = "Partida: " + partida.Nome;
            DesenharFabricas();///////////////

        }

        public void DesenharFabricas()
        {
            string txt;

            txt = Jogo.LerFabricas(jogador.Id, jogador.Senha);

            if (txt.Substring(0, 4) == "ERRO")
            {
                this.erro = txt.Substring(5);
                Close();
                
            }

            textBox1.Text = txt;

            //partida.preencherFabricas(txt);//Preenche as fábricas do obj partida
            //561F58

        }
    }
}
