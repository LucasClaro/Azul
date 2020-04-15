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
            this.components = new System.ComponentModel.Container();
            this.lblCabecalho = new System.Windows.Forms.Label();
            this.pcbFabricas = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVez = new System.Windows.Forms.Button();
            this.lblVez = new System.Windows.Forms.Label();
            this.btnModelo1 = new System.Windows.Forms.Button();
            this.btnModelo2 = new System.Windows.Forms.Button();
            this.btnModelo3 = new System.Windows.Forms.Button();
            this.btnModelo4 = new System.Windows.Forms.Button();
            this.btnModelo5 = new System.Windows.Forms.Button();
            this.lblCompra = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(699, 567);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 341);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1026, 99);
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
            // btnModelo1
            // 
            this.btnModelo1.Location = new System.Drawing.Point(669, 70);
            this.btnModelo1.Name = "btnModelo1";
            this.btnModelo1.Size = new System.Drawing.Size(75, 23);
            this.btnModelo1.TabIndex = 14;
            this.btnModelo1.Text = "Modelo1";
            this.btnModelo1.UseVisualStyleBackColor = true;
            this.btnModelo1.Click += new System.EventHandler(this.btnModelo1_Click);
            // 
            // btnModelo2
            // 
            this.btnModelo2.Location = new System.Drawing.Point(669, 99);
            this.btnModelo2.Name = "btnModelo2";
            this.btnModelo2.Size = new System.Drawing.Size(75, 23);
            this.btnModelo2.TabIndex = 15;
            this.btnModelo2.Text = "Modelo2";
            this.btnModelo2.UseVisualStyleBackColor = true;
            this.btnModelo2.Click += new System.EventHandler(this.btnModelo2_Click);
            // 
            // btnModelo3
            // 
            this.btnModelo3.Location = new System.Drawing.Point(669, 128);
            this.btnModelo3.Name = "btnModelo3";
            this.btnModelo3.Size = new System.Drawing.Size(75, 23);
            this.btnModelo3.TabIndex = 16;
            this.btnModelo3.Text = "Modelo3";
            this.btnModelo3.UseVisualStyleBackColor = true;
            this.btnModelo3.Click += new System.EventHandler(this.btnModelo3_Click);
            // 
            // btnModelo4
            // 
            this.btnModelo4.Location = new System.Drawing.Point(669, 157);
            this.btnModelo4.Name = "btnModelo4";
            this.btnModelo4.Size = new System.Drawing.Size(75, 23);
            this.btnModelo4.TabIndex = 17;
            this.btnModelo4.Text = "Modelo4";
            this.btnModelo4.UseVisualStyleBackColor = true;
            this.btnModelo4.Click += new System.EventHandler(this.btnModelo4_Click);
            // 
            // btnModelo5
            // 
            this.btnModelo5.Location = new System.Drawing.Point(669, 186);
            this.btnModelo5.Name = "btnModelo5";
            this.btnModelo5.Size = new System.Drawing.Size(75, 23);
            this.btnModelo5.TabIndex = 18;
            this.btnModelo5.Text = "Modelo5";
            this.btnModelo5.UseVisualStyleBackColor = true;
            this.btnModelo5.Click += new System.EventHandler(this.btnModelo5_Click);
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(13, 781);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(49, 13);
            this.lblCompra.TabIndex = 19;
            this.lblCompra.Text = "Compra: ";
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(13, 811);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(32, 13);
            this.lblErro.TabIndex = 20;
            this.lblErro.Text = "Erro: ";
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Enabled = true;
            this.tmrRefresh.Interval = 7000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // frmTabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 920);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.btnModelo5);
            this.Controls.Add(this.btnModelo4);
            this.Controls.Add(this.btnModelo3);
            this.Controls.Add(this.btnModelo2);
            this.Controls.Add(this.btnModelo1);
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
        private System.Windows.Forms.Button btnModelo1;
        private System.Windows.Forms.Button btnModelo2;
        private System.Windows.Forms.Button btnModelo3;
        private System.Windows.Forms.Button btnModelo4;
        private System.Windows.Forms.Button btnModelo5;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Timer tmrRefresh;
    }
}