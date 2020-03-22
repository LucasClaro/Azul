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
            this.pcbTeste = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFabricas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTeste)).BeginInit();
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
            this.pcbFabricas.Image = global::AzulClaro.Properties.Resources.f5;
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
            // pcbTeste
            // 
            this.pcbTeste.Image = global::AzulClaro.Properties.Resources.a1;
            this.pcbTeste.Location = new System.Drawing.Point(822, 104);
            this.pcbTeste.Name = "pcbTeste";
            this.pcbTeste.Size = new System.Drawing.Size(100, 50);
            this.pcbTeste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTeste.TabIndex = 3;
            this.pcbTeste.TabStop = false;
            // 
            // frmTabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pcbTeste);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pcbFabricas);
            this.Controls.Add(this.lblCabecalho);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "frmTabuleiro";
            this.Text = "frmTabuleiro";
            this.Load += new System.EventHandler(this.frmTabuleiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFabricas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTeste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCabecalho;
        private System.Windows.Forms.PictureBox pcbFabricas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pcbTeste;
    }
}