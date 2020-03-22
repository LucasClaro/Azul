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
            this.components = new System.ComponentModel.Container();
            this.btnListPartidas = new System.Windows.Forms.Button();
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdjogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tmrMsgErro = new System.Windows.Forms.Timer(this.components);
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.chkBot = new System.Windows.Forms.CheckBox();
            this.lblErroIniciar = new System.Windows.Forms.Label();
            this.dgvPartidas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListPartidas
            // 
            this.btnListPartidas.Location = new System.Drawing.Point(243, 12);
            this.btnListPartidas.Name = "btnListPartidas";
            this.btnListPartidas.Size = new System.Drawing.Size(138, 23);
            this.btnListPartidas.TabIndex = 0;
            this.btnListPartidas.Text = "Listar Partidas";
            this.btnListPartidas.UseVisualStyleBackColor = true;
            this.btnListPartidas.Click += new System.EventHandler(this.btnListPartidas_Click);
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Enabled = false;
            this.txtIdPartida.Location = new System.Drawing.Point(265, 90);
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
            this.cboStatusPartida.Location = new System.Drawing.Point(390, 14);
            this.cboStatusPartida.Name = "cboStatusPartida";
            this.cboStatusPartida.Size = new System.Drawing.Size(82, 21);
            this.cboStatusPartida.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(243, 41);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(229, 24);
            this.btnCriarPartida.TabIndex = 7;
            this.btnCriarPartida.Text = "Criar Partida...";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(246, 115);
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
            this.lstJogadores.Location = new System.Drawing.Point(246, 146);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(226, 95);
            this.lstJogadores.TabIndex = 11;
            // 
            // txtSenhaEntrar
            // 
            this.txtSenhaEntrar.Location = new System.Drawing.Point(351, 90);
            this.txtSenhaEntrar.Name = "txtSenhaEntrar";
            this.txtSenhaEntrar.Size = new System.Drawing.Size(121, 20);
            this.txtSenhaEntrar.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Senha";
            // 
            // lblVersao
            // 
            this.lblVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(411, 524);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(61, 13);
            this.lblVersao.TabIndex = 14;
            this.lblVersao.Text = "Versão: 0.0";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(325, 277);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(147, 20);
            this.txtNomeJogador.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nome Jogador";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(246, 326);
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
            this.lblErroEntrarPartida.Location = new System.Drawing.Point(243, 360);
            this.lblErroEntrarPartida.Name = "lblErroEntrarPartida";
            this.lblErroEntrarPartida.Size = new System.Drawing.Size(38, 13);
            this.lblErroEntrarPartida.TabIndex = 20;
            this.lblErroEntrarPartida.Text = "ERRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Id Jogador";
            // 
            // txtIdjogador
            // 
            this.txtIdjogador.Location = new System.Drawing.Point(328, 402);
            this.txtIdjogador.Name = "txtIdjogador";
            this.txtIdjogador.Size = new System.Drawing.Size(53, 20);
            this.txtIdjogador.TabIndex = 22;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(328, 425);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(144, 20);
            this.txtSenhaJogador.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Senha Jogador";
            // 
            // tmrMsgErro
            // 
            this.tmrMsgErro.Interval = 10000;
            this.tmrMsgErro.Tick += new System.EventHandler(this.tmrMsgErro_Tick);
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(246, 451);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(226, 31);
            this.btnIniciarPartida.TabIndex = 25;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // chkBot
            // 
            this.chkBot.AutoSize = true;
            this.chkBot.Location = new System.Drawing.Point(246, 303);
            this.chkBot.Name = "chkBot";
            this.chkBot.Size = new System.Drawing.Size(138, 17);
            this.chkBot.TabIndex = 26;
            this.chkBot.Text = "Esse jogador é um Bot?";
            this.chkBot.UseVisualStyleBackColor = true;
            // 
            // lblErroIniciar
            // 
            this.lblErroIniciar.AutoSize = true;
            this.lblErroIniciar.Location = new System.Drawing.Point(243, 485);
            this.lblErroIniciar.Name = "lblErroIniciar";
            this.lblErroIniciar.Size = new System.Drawing.Size(38, 13);
            this.lblErroIniciar.TabIndex = 30;
            this.lblErroIniciar.Text = "ERRO";
            // 
            // dgvPartidas
            // 
            this.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidas.Location = new System.Drawing.Point(12, 12);
            this.dgvPartidas.Name = "dgvPartidas";
            this.dgvPartidas.Size = new System.Drawing.Size(225, 525);
            this.dgvPartidas.TabIndex = 31;
            this.dgvPartidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartidas_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 546);
            this.Controls.Add(this.dgvPartidas);
            this.Controls.Add(this.lblErroIniciar);
            this.Controls.Add(this.chkBot);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdjogador);
            this.Controls.Add(this.label2);
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
            this.Controls.Add(this.btnListPartidas);
            this.MaximumSize = new System.Drawing.Size(760, 585);
            this.MinimumSize = new System.Drawing.Size(260, 585);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ERRO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListPartidas;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdjogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tmrMsgErro;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.CheckBox chkBot;
        private System.Windows.Forms.Label lblErroIniciar;
        private System.Windows.Forms.DataGridView dgvPartidas;
    }
}

