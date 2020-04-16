namespace AzulClaro
{
    partial class frmLobby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlBarraWindows = new System.Windows.Forms.Panel();
            this.pcbMinimizar = new System.Windows.Forms.PictureBox();
            this.pcbFechar = new System.Windows.Forms.PictureBox();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblErroIniciar = new System.Windows.Forms.Label();
            this.lblErroEntrarPartida = new System.Windows.Forms.Label();
            this.dgvPartidas = new System.Windows.Forms.DataGridView();
            this.rdbEncerradas = new System.Windows.Forms.RadioButton();
            this.rdbAbertas = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.btnListPartidas = new System.Windows.Forms.Button();
            this.txtSenhaEntrar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.tmrMsgErro = new System.Windows.Forms.Timer(this.components);
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.txtIdjogador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkBot = new System.Windows.Forms.CheckBox();
            this.pnlBarraWindows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraWindows
            // 
            this.pnlBarraWindows.BackColor = System.Drawing.Color.Transparent;
            this.pnlBarraWindows.Controls.Add(this.pcbMinimizar);
            this.pnlBarraWindows.Controls.Add(this.pcbFechar);
            this.pnlBarraWindows.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraWindows.Name = "pnlBarraWindows";
            this.pnlBarraWindows.Size = new System.Drawing.Size(479, 71);
            this.pnlBarraWindows.TabIndex = 0;
            this.pnlBarraWindows.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraWindows_MouseDown);
            this.pnlBarraWindows.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraWindows_MouseMove);
            this.pnlBarraWindows.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBarraWindows_MouseUp);
            // 
            // pcbMinimizar
            // 
            this.pcbMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.pcbMinimizar.Image = global::AzulClaro.Properties.Resources.mini;
            this.pcbMinimizar.Location = new System.Drawing.Point(412, 0);
            this.pcbMinimizar.Name = "pcbMinimizar";
            this.pcbMinimizar.Size = new System.Drawing.Size(32, 32);
            this.pcbMinimizar.TabIndex = 57;
            this.pcbMinimizar.TabStop = false;
            this.pcbMinimizar.Click += new System.EventHandler(this.pcbMinimizar_Click);
            // 
            // pcbFechar
            // 
            this.pcbFechar.BackColor = System.Drawing.Color.Transparent;
            this.pcbFechar.Image = global::AzulClaro.Properties.Resources.close;
            this.pcbFechar.Location = new System.Drawing.Point(441, 0);
            this.pcbFechar.Name = "pcbFechar";
            this.pcbFechar.Size = new System.Drawing.Size(32, 32);
            this.pcbFechar.TabIndex = 56;
            this.pcbFechar.TabStop = false;
            this.pcbFechar.Click += new System.EventHandler(this.pcbFechar_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersao.AutoSize = true;
            this.lblVersao.BackColor = System.Drawing.Color.Transparent;
            this.lblVersao.Font = new System.Drawing.Font("Oxanium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.Color.Black;
            this.lblVersao.Location = new System.Drawing.Point(12, 602);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(107, 24);
            this.lblVersao.TabIndex = 15;
            this.lblVersao.Text = "Versão: 0.0";
            // 
            // lblErroIniciar
            // 
            this.lblErroIniciar.AutoSize = true;
            this.lblErroIniciar.BackColor = System.Drawing.Color.Transparent;
            this.lblErroIniciar.Font = new System.Drawing.Font("Oxanium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErroIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.lblErroIniciar.Location = new System.Drawing.Point(236, 556);
            this.lblErroIniciar.Name = "lblErroIniciar";
            this.lblErroIniciar.Size = new System.Drawing.Size(35, 14);
            this.lblErroIniciar.TabIndex = 31;
            this.lblErroIniciar.Text = "ERRO";
            // 
            // lblErroEntrarPartida
            // 
            this.lblErroEntrarPartida.AutoSize = true;
            this.lblErroEntrarPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblErroEntrarPartida.Font = new System.Drawing.Font("Oxanium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErroEntrarPartida.Location = new System.Drawing.Point(286, 465);
            this.lblErroEntrarPartida.Name = "lblErroEntrarPartida";
            this.lblErroEntrarPartida.Size = new System.Drawing.Size(35, 14);
            this.lblErroEntrarPartida.TabIndex = 32;
            this.lblErroEntrarPartida.Text = "ERRO";
            // 
            // dgvPartidas
            // 
            this.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidas.Location = new System.Drawing.Point(12, 77);
            this.dgvPartidas.Name = "dgvPartidas";
            this.dgvPartidas.Size = new System.Drawing.Size(213, 427);
            this.dgvPartidas.TabIndex = 33;
            this.dgvPartidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartidas_CellClick);
            // 
            // rdbEncerradas
            // 
            this.rdbEncerradas.AutoSize = true;
            this.rdbEncerradas.BackColor = System.Drawing.Color.Transparent;
            this.rdbEncerradas.Font = new System.Drawing.Font("Oxanium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEncerradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.rdbEncerradas.Location = new System.Drawing.Point(144, 561);
            this.rdbEncerradas.Name = "rdbEncerradas";
            this.rdbEncerradas.Size = new System.Drawing.Size(81, 18);
            this.rdbEncerradas.TabIndex = 38;
            this.rdbEncerradas.Text = "Encerradas";
            this.rdbEncerradas.UseVisualStyleBackColor = false;
            // 
            // rdbAbertas
            // 
            this.rdbAbertas.AutoSize = true;
            this.rdbAbertas.BackColor = System.Drawing.Color.Transparent;
            this.rdbAbertas.Font = new System.Drawing.Font("Oxanium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAbertas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.rdbAbertas.Location = new System.Drawing.Point(74, 561);
            this.rdbAbertas.Name = "rdbAbertas";
            this.rdbAbertas.Size = new System.Drawing.Size(64, 18);
            this.rdbAbertas.TabIndex = 37;
            this.rdbAbertas.Text = "Abertas";
            this.rdbAbertas.UseVisualStyleBackColor = false;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.BackColor = System.Drawing.Color.Transparent;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Font = new System.Drawing.Font("Oxanium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.rdbTodos.Location = new System.Drawing.Point(12, 561);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(56, 18);
            this.rdbTodos.TabIndex = 36;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oxanium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Id";
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.BackColor = System.Drawing.Color.White;
            this.txtIdPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdPartida.Enabled = false;
            this.txtIdPartida.Font = new System.Drawing.Font("Oxanium", 9.75F);
            this.txtIdPartida.Location = new System.Drawing.Point(310, 99);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(36, 24);
            this.txtIdPartida.TabIndex = 39;
            // 
            // lstJogadores
            // 
            this.lstJogadores.Font = new System.Drawing.Font("Oxanium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 20;
            this.lstJogadores.Location = new System.Drawing.Point(289, 138);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(180, 104);
            this.lstJogadores.TabIndex = 41;
            // 
            // btnListPartidas
            // 
            this.btnListPartidas.BackColor = System.Drawing.Color.Transparent;
            this.btnListPartidas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListPartidas.Font = new System.Drawing.Font("Oxanium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListPartidas.Location = new System.Drawing.Point(0, 513);
            this.btnListPartidas.Name = "btnListPartidas";
            this.btnListPartidas.Size = new System.Drawing.Size(225, 45);
            this.btnListPartidas.TabIndex = 42;
            this.btnListPartidas.Text = "Listar Partidas";
            this.btnListPartidas.UseVisualStyleBackColor = false;
            this.btnListPartidas.Click += new System.EventHandler(this.btnListPartidas_Click);
            // 
            // txtSenhaEntrar
            // 
            this.txtSenhaEntrar.BackColor = System.Drawing.Color.White;
            this.txtSenhaEntrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaEntrar.Font = new System.Drawing.Font("Oxanium", 9.75F);
            this.txtSenhaEntrar.Location = new System.Drawing.Point(394, 99);
            this.txtSenhaEntrar.Name = "txtSenhaEntrar";
            this.txtSenhaEntrar.Size = new System.Drawing.Size(75, 24);
            this.txtSenhaEntrar.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Oxanium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Senha";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnCriarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriarPartida.Font = new System.Drawing.Font("Oxanium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPartida.ForeColor = System.Drawing.Color.Black;
            this.btnCriarPartida.Location = new System.Drawing.Point(285, 257);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(194, 46);
            this.btnCriarPartida.TabIndex = 46;
            this.btnCriarPartida.Text = "Criar Partida...";
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrarPartida.Font = new System.Drawing.Font("Oxanium", 12F);
            this.btnEntrarPartida.ForeColor = System.Drawing.Color.Black;
            this.btnEntrarPartida.Location = new System.Drawing.Point(285, 421);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(194, 42);
            this.btnEntrarPartida.TabIndex = 47;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = false;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // tmrMsgErro
            // 
            this.tmrMsgErro.Interval = 10000;
            this.tmrMsgErro.Tick += new System.EventHandler(this.tmrMsgErro_Tick);
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Oxanium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.ForeColor = System.Drawing.Color.Black;
            this.btnIniciarPartida.Location = new System.Drawing.Point(239, 573);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(240, 62);
            this.btnIniciarPartida.TabIndex = 48;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // txtIdjogador
            // 
            this.txtIdjogador.Font = new System.Drawing.Font("Oxanium", 9.75F);
            this.txtIdjogador.Location = new System.Drawing.Point(370, 484);
            this.txtIdjogador.Name = "txtIdjogador";
            this.txtIdjogador.Size = new System.Drawing.Size(95, 24);
            this.txtIdjogador.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Oxanium", 9.75F);
            this.label2.Location = new System.Drawing.Point(343, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Id";
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Font = new System.Drawing.Font("Oxanium", 9.75F);
            this.txtSenhaJogador.Location = new System.Drawing.Point(370, 513);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(95, 24);
            this.txtSenhaJogador.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Oxanium", 9.75F);
            this.label5.Location = new System.Drawing.Point(316, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Senha";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Font = new System.Drawing.Font("Oxanium", 9.75F);
            this.txtNomeJogador.Location = new System.Drawing.Point(370, 359);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(95, 24);
            this.txtNomeJogador.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Oxanium", 9.75F);
            this.label3.Location = new System.Drawing.Point(318, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Nome";
            // 
            // chkBot
            // 
            this.chkBot.AutoSize = true;
            this.chkBot.BackColor = System.Drawing.Color.Transparent;
            this.chkBot.Font = new System.Drawing.Font("Oxanium", 9.75F);
            this.chkBot.Location = new System.Drawing.Point(293, 389);
            this.chkBot.Name = "chkBot";
            this.chkBot.Size = new System.Drawing.Size(170, 20);
            this.chkBot.TabIndex = 55;
            this.chkBot.Text = "Esse jogador é um Bot?";
            this.chkBot.UseVisualStyleBackColor = false;
            // 
            // frmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::AzulClaro.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(477, 630);
            this.Controls.Add(this.chkBot);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdjogador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.txtSenhaEntrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnListPartidas);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.rdbEncerradas);
            this.Controls.Add(this.rdbAbertas);
            this.Controls.Add(this.rdbTodos);
            this.Controls.Add(this.dgvPartidas);
            this.Controls.Add(this.lblErroEntrarPartida);
            this.Controls.Add(this.lblErroIniciar);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.pnlBarraWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLobby";
            this.Text = "frmLobby";
            this.pnlBarraWindows.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraWindows;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblErroIniciar;
        private System.Windows.Forms.Label lblErroEntrarPartida;
        private System.Windows.Forms.DataGridView dgvPartidas;
        private System.Windows.Forms.RadioButton rdbEncerradas;
        private System.Windows.Forms.RadioButton rdbAbertas;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Button btnListPartidas;
        private System.Windows.Forms.TextBox txtSenhaEntrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Timer tmrMsgErro;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.TextBox txtIdjogador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkBot;
        private System.Windows.Forms.PictureBox pcbMinimizar;
        private System.Windows.Forms.PictureBox pcbFechar;
    }
}