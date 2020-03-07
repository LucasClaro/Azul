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
    public partial class frmCriarPartida : Form
    {
        public string senha { get; set; }

        public frmCriarPartida()
        {
            InitializeComponent();
        }

        //Botão Criar Partida
        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nome = txtNomePartida.Text;//Lê nome e senha da nova partida
            senha = txtSenhaPartida.Text;
            if (nome != "" && senha != "")//Cria a nova partida caso ambos estejam preenchidos
            {
                Jogo.CriarPartida(nome, senha);
                Close();
            }
            else
            {
                lblErro.Text = "Preencha ambos os campos!";
            }
        }

        //Botão Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            senha = "";
            Close();
        }
    }
}
