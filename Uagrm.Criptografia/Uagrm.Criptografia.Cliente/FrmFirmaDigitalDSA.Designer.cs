namespace Uagrm.Criptografia.Cliente
{
    partial class FrmFirmaDigitalDSA
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
            this.txtCadenaFirma = new System.Windows.Forms.TextBox();
            this.btnGenerarFirma = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnComprobarFirma = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "FIRMA DIGITAL (SERVICIO DSA)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cadena Firma:";
            // 
            // txtCadenaFirma
            // 
            this.txtCadenaFirma.BackColor = System.Drawing.Color.Lavender;
            this.txtCadenaFirma.Location = new System.Drawing.Point(103, 75);
            this.txtCadenaFirma.Name = "txtCadenaFirma";
            this.txtCadenaFirma.Size = new System.Drawing.Size(122, 20);
            this.txtCadenaFirma.TabIndex = 11;
            // 
            // btnGenerarFirma
            // 
            this.btnGenerarFirma.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerarFirma.ForeColor = System.Drawing.Color.White;
            this.btnGenerarFirma.Location = new System.Drawing.Point(25, 36);
            this.btnGenerarFirma.Name = "btnGenerarFirma";
            this.btnGenerarFirma.Size = new System.Drawing.Size(196, 35);
            this.btnGenerarFirma.TabIndex = 10;
            this.btnGenerarFirma.Text = "Generar Firma";
            this.btnGenerarFirma.UseVisualStyleBackColor = false;
            this.btnGenerarFirma.Click += new System.EventHandler(this.btnGenerarFirma_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(244, 78);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Navy;
            this.groupBox1.Controls.Add(this.lblMensaje);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(26, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 265);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENSAJES";
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(6, 16);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(563, 246);
            this.lblMensaje.TabIndex = 1;
            // 
            // btnComprobarFirma
            // 
            this.btnComprobarFirma.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnComprobarFirma.ForeColor = System.Drawing.Color.White;
            this.btnComprobarFirma.Location = new System.Drawing.Point(381, 36);
            this.btnComprobarFirma.Name = "btnComprobarFirma";
            this.btnComprobarFirma.Size = new System.Drawing.Size(196, 35);
            this.btnComprobarFirma.TabIndex = 15;
            this.btnComprobarFirma.Text = "Comprobar Firma";
            this.btnComprobarFirma.UseVisualStyleBackColor = false;
            this.btnComprobarFirma.Click += new System.EventHandler(this.btnComprobarFirma_Click);
            // 
            // FrmFirmaDigitalDSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 392);
            this.Controls.Add(this.btnComprobarFirma);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCadenaFirma);
            this.Controls.Add(this.btnGenerarFirma);
            this.Controls.Add(this.label1);
            this.Name = "FrmFirmaDigitalDSA";
            this.Text = "FrmFirmaDigitalDSA";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCadenaFirma;
        private System.Windows.Forms.Button btnGenerarFirma;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnComprobarFirma;
    }
}