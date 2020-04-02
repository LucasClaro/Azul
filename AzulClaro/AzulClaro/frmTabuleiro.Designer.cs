namespace AzulClaro
{
    partial class frmTabuleiro
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
            this.lblCabecalho = new System.Windows.Forms.Label();
            this.pcbFabricas = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVez = new System.Windows.Forms.Button();
            this.lblVez = new System.Windows.Forms.Label();
            this.rdbFab = new System.Windows.Forms.RadioButton();
            this.rdbCentro = new System.Windows.Forms.RadioButton();
            this.cboNumFab = new System.Windows.Forms.ComboBox();
            this.cboCor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.btnJogar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFabricas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCabecalho
            // 
            this.lblCabecalho.AutoSize = true;
            this.lblCabecalho.Location = new System.Drawing.Point(13, 13);
            this.lblCabecalho.Name = "lblCabecalho";
            this.lblCabecalho.Size = new System.Drawing.Size(35, 13);
            this.lblCabecalho.TabIndex = 0;
            this.lblCabecalho.Text = "label1";
            // 
            // pcbFabricas
            // 
            this.pcbFabricas.Image = global::AzulClaro.Properties.Resources.f7;
            this.pcbFabricas.Location = new System.Drawing.Point(12, 70);
            this.pcbFabricas.Name = "pcbFabricas";
            this.pcbFabricas.Size = new System.Drawing.Size(650, 650);
            this.pcbFabricas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFabricas.TabIndex = 1;
            this.pcbFabricas.TabStop = false;
            this.pcbFabricas.Click += new System.EventHandler(this.pcbFabricas_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(926, 261);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 341);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(926, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnVez
            // 
            this.btnVez.Location = new System.Drawing.Point(12, 738);
            this.btnVez.Name = "btnVez";
            this.btnVez.Size = new System.Drawing.Size(75, 23);
            this.btnVez.TabIndex = 4;
            this.btnVez.Text = "Ver vez";
            this.btnVez.UseVisualStyleBackColor = true;
            this.btnVez.Click += new System.EventHandler(this.btnVez_Click);
            // 
            // lblVez
            // 
            this.lblVez.AutoSize = true;
            this.lblVez.Location = new System.Drawing.Point(93, 743);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(51, 13);
            this.lblVez.TabIndex = 5;
            this.lblVez.Text = "Jogador: ";
            // 
            // rdbFab
            // 
            this.rdbFab.AutoSize = true;
            this.rdbFab.Location = new System.Drawing.Point(16, 782);
            this.rdbFab.Name = "rdbFab";
            this.rdbFab.Size = new System.Drawing.Size(60, 17);
            this.rdbFab.TabIndex = 6;
            this.rdbFab.TabStop = true;
            this.rdbFab.Text = "Fábrica";
            this.rdbFab.UseVisualStyleBackColor = true;
            // 
            // rdbCentro
            // 
            this.rdbCentro.AutoSize = true;
            this.rdbCentro.Location = new System.Drawing.Point(16, 805);
            this.rdbCentro.Name = "rdbCentro";
            this.rdbCentro.Size = new System.Drawing.Size(56, 17);
            this.rdbCentro.TabIndex = 7;
            this.rdbCentro.TabStop = true;
            this.rdbCentro.Text = "Centro";
            this.rdbCentro.UseVisualStyleBackColor = true;
            // 
            // cboNumFab
            // 
            this.cboNumFab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumFab.FormattingEnabled = true;
            this.cboNumFab.Location = new System.Drawing.Point(82, 781);
            this.cboNumFab.Name = "cboNumFab";
            this.cboNumFab.Size = new System.Drawing.Size(84, 21);
            this.cboNumFab.TabIndex = 8;
            // 
            // cboCor
            // 
            this.cboCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCor.FormattingEnabled = true;
            this.cboCor.Items.AddRange(new object[] {
            "Azul",
            "Amarelo",
            "Vermelho",
            "Preto",
            "Branco"});
            this.cboCor.Location = new System.Drawing.Point(64, 845);
            this.cboCor.Name = "cboCor";
            this.cboCor.Size = new System.Drawing.Size(102, 21);
            this.cboCor.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 848);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 881);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Modelo:";
            // 
            // cboModelo
            // 
            this.cboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboModelo.Location = new System.Drawing.Point(64, 878);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(102, 21);
            this.cboModelo.TabIndex = 12;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(196, 845);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(236, 54);
            this.btnJogar.TabIndex = 13;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // frmTabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 920);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.cboModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCor);
            this.Controls.Add(this.cboNumFab);
            this.Controls.Add(this.rdbCentro);
            this.Controls.Add(this.rdbFab);
            this.Controls.Add(this.lblVez);
            this.Controls.Add(this.btnVez);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pcbFabricas);
            this.Controls.Add(this.lblCabecalho);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "frmTabuleiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmTabuleiro";
            this.Load += new System.EventHandler(this.frmTabuleiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFabricas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCabecalho;
        private System.Windows.Forms.PictureBox pcbFabricas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVez;
        private System.Windows.Forms.Label lblVez;
        private System.Windows.Forms.RadioButton rdbFab;
        private System.Windows.Forms.RadioButton rdbCentro;
        private System.Windows.Forms.ComboBox cboNumFab;
        private System.Windows.Forms.ComboBox cboCor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.Button btnJogar;
    }
}