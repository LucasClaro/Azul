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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
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
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(276, 29);
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
            this.label1.Location = new System.Drawing.Point(273, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(50, 91);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(188, 20);
            this.txtNomePartida.TabIndex = 5;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(12, 140);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(226, 23);
            this.btnCriarPartida.TabIndex = 7;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(50, 114);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(188, 20);
            this.txtSenhaPartida.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboStatusPartida);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.cboPartidas);
            this.Controls.Add(this.btnListPartidas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListPartidas;
        private System.Windows.Forms.ComboBox cboPartidas;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.ComboBox cboStatusPartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaPartida;
    }
}

