namespace CodeCofe.Criptografia.Cliente
{
    partial class FrmNumeroAleatorioRNG
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadNumero = new System.Windows.Forms.TextBox();
            this.btnGenerarNumeros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Numero Byte a Generar:";
            // 
            // txtCantidadNumero
            // 
            this.txtCantidadNumero.BackColor = System.Drawing.Color.Lavender;
            this.txtCantidadNumero.Location = new System.Drawing.Point(146, 75);
            this.txtCantidadNumero.Name = "txtCantidadNumero";
            this.txtCantidadNumero.Size = new System.Drawing.Size(122, 20);
            this.txtCantidadNumero.TabIndex = 16;
            // 
            // btnGenerarNumeros
            // 
            this.btnGenerarNumeros.BackColor = System.Drawing.Color.DimGray;
            this.btnGenerarNumeros.ForeColor = System.Drawing.Color.White;
            this.btnGenerarNumeros.Location = new System.Drawing.Point(19, 36);
            this.btnGenerarNumeros.Name = "btnGenerarNumeros";
            this.btnGenerarNumeros.Size = new System.Drawing.Size(196, 35);
            this.btnGenerarNumeros.TabIndex = 15;
            this.btnGenerarNumeros.Text = "Generar Numeros";
            this.btnGenerarNumeros.UseVisualStyleBackColor = false;
            this.btnGenerarNumeros.Click += new System.EventHandler(this.btnGenerarNumeros_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "GENERACION NUMEROS ALEATORIOS (SERVICIO RNG)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.lblMensaje);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(22, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 252);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENSAJES";
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.DimGray;
            this.lblMensaje.Location = new System.Drawing.Point(6, 26);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(563, 223);
            this.lblMensaje.TabIndex = 1;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(293, 78);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 20;
            // 
            // FrmNumeroAleatorioRNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 392);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidadNumero);
            this.Controls.Add(this.btnGenerarNumeros);
            this.Controls.Add(this.label1);
            this.Name = "FrmNumeroAleatorioRNG";
            this.Text = "FrmNumeroAleatorioRNG";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadNumero;
        private System.Windows.Forms.Button btnGenerarNumeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblError;
    }
}