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
        public int idPartidaCriada { get; set; }

        public frmCriarPartida()
        {
            InitializeComponent();
        }//Construtor
        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nome = txtNomePartida.Text;//Lê nome e senha da nova partida
            string erro;//Recebe a mensagem de erro do servidor
            senha = txtSenhaPartida.Text;
            if (nome != "" && senha != "")//Cria a nova partida caso ambos estejam preenchidos
            {
                erro = Jogo.CriarPartida(nome, senha);

                if (erro.Length <= 4)
                {
                    this.idPartidaCriada = Convert.ToInt32(erro);
                    Close();
                }
                else
                {
                    lblErro.Text = erro.Substring(5);
                }
            }
            else
            {
                lblErro.Text = "Preencha ambos os campos!";
            }
        }//Botão Criar Partida: se os campos estiverem preenchidos e sem erro na criação, cria a partida e retorna o id da partida criada         
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            senha = "";
            Close();
        }//Botão Cancelar: cancela a criação e não retorna nada pra tela anterior
    }
}          
