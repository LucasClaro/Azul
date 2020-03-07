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
            cboStatusPartida.SelectedIndex = 0;
        }

        private void btnListPartidas_Click(object sender, EventArgs e)
        {
            bool existe1 = false;

            string status = cboStatusPartida.SelectedItem.ToString().Substring(0, 1);
            string txt = Jogo.ListarPartidas(status);

            txt = txt.Replace("\r", "");
            string[] partidas = txt.Split('\n');

            cboPartidas.Items.Clear();
            foreach (string partida in partidas)
            {
                existe1 = true;
                cboPartidas.Items.Add(partida);
            }
            if (existe1)
            {
                cboPartidas.SelectedIndex = 0;
            }
        }

        //if (cboPartidas.SelectedItem != null) 
        //    {
        //        string txt = cboPartidas.SelectedItem.ToString();
        //string[] partida = txt.Split(',');
        //txtIdPartida.Text = partida[0];
        //        txtNomePartida.Text = partida[1];

        //    }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            string nome = txtNomePartida.Text;
            string senha = txtSenhaPartida.Text;
            if (nome != "" && senha != "")
            {
                Jogo.CriarPartida(nome, senha);
            }                
        }
    }
}
