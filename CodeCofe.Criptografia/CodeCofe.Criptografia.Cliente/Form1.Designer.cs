namespace CodeCofe.Criptografia.Cliente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNumeroAleatorio = new System.Windows.Forms.Button();
            this.btnFirmaDigital = new System.Windows.Forms.Button();
            this.btnCifrarRSA = new System.Windows.Forms.Button();
            this.btnClaveDES = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNumeroAleatorio);
            this.groupBox1.Controls.Add(this.btnFirmaDigital);
            this.groupBox1.Controls.Add(this.btnCifrarRSA);
            this.groupBox1.Controls.Add(this.btnClaveDES);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(7, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 303);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROCESOS";
            // 
            // btnNumeroAleatorio
            // 
            this.btnNumeroAleatorio.BackColor = System.Drawing.Color.Orange;
            this.btnNumeroAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumeroAleatorio.ForeColor = System.Drawing.Color.White;
            this.btnNumeroAleatorio.Location = new System.Drawing.Point(7, 197);
            this.btnNumeroAleatorio.Name = "btnNumeroAleatorio";
            this.btnNumeroAleatorio.Size = new System.Drawing.Size(115, 30);
            this.btnNumeroAleatorio.TabIndex = 6;
            this.btnNumeroAleatorio.Text = "Num. Aleatorio RNG";
            this.btnNumeroAleatorio.UseVisualStyleBackColor = false;
            this.btnNumeroAleatorio.Click += new System.EventHandler(this.btnNumeroAleatorio_Click);
            // 
            // btnFirmaDigital
            // 
            this.btnFirmaDigital.BackColor = System.Drawing.Color.Orange;
            this.btnFirmaDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirmaDigital.ForeColor = System.Drawing.Color.White;
            this.btnFirmaDigital.Location = new System.Drawing.Point(7, 142);
            this.btnFirmaDigital.Name = "btnFirmaDigital";
            this.btnFirmaDigital.Size = new System.Drawing.Size(115, 30);
            this.btnFirmaDigital.TabIndex = 5;
            this.btnFirmaDigital.Text = "Firma Digital DSA";
            this.btnFirmaDigital.UseVisualStyleBackColor = false;
            this.btnFirmaDigital.Click += new System.EventHandler(this.btnFirmaDigital_Click);
            // 
            // btnCifrarRSA
            // 
            this.btnCifrarRSA.BackColor = System.Drawing.Color.Orange;
            this.btnCifrarRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCifrarRSA.ForeColor = System.Drawing.Color.White;
            this.btnCifrarRSA.Location = new System.Drawing.Point(7, 87);
            this.btnCifrarRSA.Name = "btnCifrarRSA";
            this.btnCifrarRSA.Size = new System.Drawing.Size(115, 30);
            this.btnCifrarRSA.TabIndex = 4;
            this.btnCifrarRSA.Text = "Cifrar Descrifrar RSA";
            this.btnCifrarRSA.UseVisualStyleBackColor = false;
            this.btnCifrarRSA.Click += new System.EventHandler(this.btnCifrarRSA_Click);
            // 
            // btnClaveDES
            // 
            this.btnClaveDES.BackColor = System.Drawing.Color.Orange;
            this.btnClaveDES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClaveDES.ForeColor = System.Drawing.Color.White;
            this.btnClaveDES.Location = new System.Drawing.Point(7, 33);
            this.btnClaveDES.Name = "btnClaveDES";
            this.btnClaveDES.Size = new System.Drawing.Size(113, 30);
            this.btnClaveDES.TabIndex = 3;
            this.btnClaveDES.Text = "Clave Servicio DES";
            this.btnClaveDES.UseVisualStyleBackColor = false;
            this.btnClaveDES.Click += new System.EventHandler(this.btnClaveDES_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "SISTEMA DE CRIPTOGRAFIA";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.label2);
            this.panelContenedor.Location = new System.Drawing.Point(150, 42);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(624, 400);
            this.panelContenedor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(217, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "BIENVENIDO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CodeCofe.Criptografia.Cliente.Properties.Resources.logoCodeCofe200;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Criptografia";
            this.groupBox1.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClaveDES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnCifrarRSA;
        private System.Windows.Forms.Button btnFirmaDigital;
        private System.Windows.Forms.Button btnNumeroAleatorio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

