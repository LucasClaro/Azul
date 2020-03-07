namespace AzulClaro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListPartidas = new System.Windows.Forms.Button();
            this.cboPartidas = new System.Windows.Forms.ComboBox();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.cboStatusPartida = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.txtSenhaEntrar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.lblErroEntrarPartida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListPartidas
            // 
            this.btnListPartidas.Location = new System.Drawing.Point(12, 39);
            this.btnListPartidas.Name = "btnListPartidas";
            this.btnListPartidas.Size = new System.Drawing.Size(138, 23);
            this.btnListPartidas.TabIndex = 0;
            this.btnListPartidas.Text = "Listar Partidas";
            this.btnListPartidas.UseVisualStyleBackColor = true;
            this.btnListPartidas.Click += new System.EventHandler(this.btnListPartidas_Click);
            // 
            // cboPartidas
            // 
            this.cboPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPartidas.FormattingEnabled = true;
            this.cboPartidas.Location = new System.Drawing.Point(12, 12);
            this.cboPartidas.Name = "cboPartidas";
            this.cboPartidas.Size = new System.Drawing.Size(226, 21);
            this.cboPartidas.TabIndex = 1;
            this.cboPartidas.SelectedIndexChanged += new System.EventHandler(this.cboPartidas_SelectedIndexChanged);
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(31, 128);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(36, 20);
            this.txtIdPartida.TabIndex = 2;
            // 
            // cboStatusPartida
            // 
            this.cboStatusPartida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusPartida.FormattingEnabled = true;
            this.cboStatusPartida.Items.AddRange(new object[] {
            "Todas",
            "Abertas",
            "Encerradas"});
            this.cboStatusPartida.Location = new System.Drawing.Point(156, 39);
            this.cboStatusPartida.Name = "cboStatusPartida";
            this.cboStatusPartida.Size = new System.Drawing.Size(82, 21);
            this.cboStatusPartida.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(12, 68);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(226, 31);
            this.btnCriarPartida.TabIndex = 7;
            this.btnCriarPartida.Text = "Criar Partida...";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(12, 153);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(226, 23);
            this.btnListarJogadores.TabIndex = 10;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // lstJogadores
            // 
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.Location = new System.Drawing.Point(12, 184);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(226, 95);
            this.lstJogadores.TabIndex = 11;
            // 
            // txtSenhaEntrar
            // 
            this.txtSenhaEntrar.Location = new System.Drawing.Point(117, 128);
            this.txtSenhaEntrar.Name = "txtSenhaEntrar";
            this.txtSenhaEntrar.Size = new System.Drawing.Size(121, 20);
            this.txtSenhaEntrar.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Senha";
            // 
            // lblVersao
            // 
            this.lblVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(727, 428);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(61, 13);
            this.lblVersao.TabIndex = 14;
            this.lblVersao.Text = "Versão: 0.0";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(91, 308);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(147, 20);
            this.txtNomeJogador.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nome Jogador";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(12, 334);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(226, 31);
            this.btnEntrarPartida.TabIndex = 19;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // lblErroEntrarPartida
            // 
            this.lblErroEntrarPartida.AutoSize = true;
            this.lblErroEntrarPartida.Location = new System.Drawing.Point(12, 368);
            this.lblErroEntrarPartida.Name = "lblErroEntrarPartida";
            this.lblErroEntrarPartida.Size = new System.Drawing.Size(0, 13);
            this.lblErroEntrarPartida.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErroEntrarPartida);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.txtSenhaEntrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboStatusPartida);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.cboPartidas);
            this.Controls.Add(this.btnListPartidas);
            this.Name = "Form1";
            this.Text = "Azul Claro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListPartidas;
        private System.Windows.Forms.ComboBox cboPartidas;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.ComboBox cboStatusPartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.TextBox txtSenhaEntrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Label lblErroEntrarPartida;
    }
}

