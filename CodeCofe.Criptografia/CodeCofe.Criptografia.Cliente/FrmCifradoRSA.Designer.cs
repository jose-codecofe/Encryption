namespace CodeCofe.Criptografia.Cliente
{
    partial class FrmCifradoRSA
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerarClaves = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCifrarMensaje = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDescifrarMensaje = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "CIFRADO Y DESCIFRADO (SERVICIO RSA)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "1. Generar Claves en ficheros xml";
            // 
            // btnGenerarClaves
            // 
            this.btnGenerarClaves.BackColor = System.Drawing.Color.DimGray;
            this.btnGenerarClaves.ForeColor = System.Drawing.Color.White;
            this.btnGenerarClaves.Location = new System.Drawing.Point(9, 67);
            this.btnGenerarClaves.Name = "btnGenerarClaves";
            this.btnGenerarClaves.Size = new System.Drawing.Size(132, 35);
            this.btnGenerarClaves.TabIndex = 11;
            this.btnGenerarClaves.Text = "Generar Claves";
            this.btnGenerarClaves.UseVisualStyleBackColor = false;
            this.btnGenerarClaves.Click += new System.EventHandler(this.btnGenerarClaves_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "2. Cifrar mensaje";
            // 
            // btnCifrarMensaje
            // 
            this.btnCifrarMensaje.BackColor = System.Drawing.Color.DimGray;
            this.btnCifrarMensaje.ForeColor = System.Drawing.Color.White;
            this.btnCifrarMensaje.Location = new System.Drawing.Point(9, 182);
            this.btnCifrarMensaje.Name = "btnCifrarMensaje";
            this.btnCifrarMensaje.Size = new System.Drawing.Size(132, 35);
            this.btnCifrarMensaje.TabIndex = 13;
            this.btnCifrarMensaje.Text = "Cifrar Mensaje";
            this.btnCifrarMensaje.UseVisualStyleBackColor = false;
            this.btnCifrarMensaje.Click += new System.EventHandler(this.btnCifrarMensaje_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mensaje:";
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.Lavender;
            this.txtMensaje.Location = new System.Drawing.Point(58, 158);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(102, 20);
            this.txtMensaje.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "3. Descifrar mensaje encriptado";
            // 
            // btnDescifrarMensaje
            // 
            this.btnDescifrarMensaje.BackColor = System.Drawing.Color.DimGray;
            this.btnDescifrarMensaje.ForeColor = System.Drawing.Color.White;
            this.btnDescifrarMensaje.Location = new System.Drawing.Point(9, 266);
            this.btnDescifrarMensaje.Name = "btnDescifrarMensaje";
            this.btnDescifrarMensaje.Size = new System.Drawing.Size(132, 35);
            this.btnDescifrarMensaje.TabIndex = 17;
            this.btnDescifrarMensaje.Text = "Descifrar Mensaje";
            this.btnDescifrarMensaje.UseVisualStyleBackColor = false;
            this.btnDescifrarMensaje.Click += new System.EventHandler(this.btnDescifrarMensaje_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.lblMensaje);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(177, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 341);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENSAJES";
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.DimGray;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(6, 16);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(418, 320);
            this.lblMensaje.TabIndex = 1;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(9, 225);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 19;
            // 
            // FrmCifradoRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 392);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDescifrarMensaje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.btnCifrarMensaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerarClaves);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCifradoRSA";
            this.Text = "FrmCifradoRSA";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerarClaves;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCifrarMensaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDescifrarMensaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblError;

    }
}