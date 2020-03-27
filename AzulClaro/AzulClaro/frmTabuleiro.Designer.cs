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
            // frmTabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
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
    }
}