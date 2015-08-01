namespace CodeCofe.Criptografia.Cliente
{
    partial class FrmClaveDES
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
            this.btnGenerarAuto = new System.Windows.Forms.Button();
            this.btnGenerarManual = new System.Windows.Forms.Button();
            this.txtCadenaMensaje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "GENERACION CLAVES (SERVICIO DES)";
            // 
            // btnGenerarAuto
            // 
            this.btnGenerarAuto.BackColor = System.Drawing.Color.DimGray;
            this.btnGenerarAuto.ForeColor = System.Drawing.Color.White;
            this.btnGenerarAuto.Location = new System.Drawing.Point(12, 36);
            this.btnGenerarAuto.Name = "btnGenerarAuto";
            this.btnGenerarAuto.Size = new System.Drawing.Size(185, 35);
            this.btnGenerarAuto.TabIndex = 6;
            this.btnGenerarAuto.Text = "Generar Clave Automaticamente";
            this.btnGenerarAuto.UseVisualStyleBackColor = false;
            this.btnGenerarAuto.Click += new System.EventHandler(this.btnGenerarAuto_Click);
            // 
            // btnGenerarManual
            // 
            this.btnGenerarManual.BackColor = System.Drawing.Color.DimGray;
            this.btnGenerarManual.ForeColor = System.Drawing.Color.White;
            this.btnGenerarManual.Location = new System.Drawing.Point(391, 38);
            this.btnGenerarManual.Name = "btnGenerarManual";
            this.btnGenerarManual.Size = new System.Drawing.Size(196, 35);
            this.btnGenerarManual.TabIndex = 7;
            this.btnGenerarManual.Text = "Generar Clave Manualmente";
            this.btnGenerarManual.UseVisualStyleBackColor = false;
            this.btnGenerarManual.Click += new System.EventHandler(this.btnGenerarManual_Click);
            // 
            // txtCadenaMensaje
            // 
            this.txtCadenaMensaje.BackColor = System.Drawing.Color.Lavender;
            this.txtCadenaMensaje.Location = new System.Drawing.Point(465, 77);
            this.txtCadenaMensaje.Name = "txtCadenaMensaje";
            this.txtCadenaMensaje.Size = new System.Drawing.Size(122, 20);
            this.txtCadenaMensaje.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(422, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Clave:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.lblMensaje);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 252);
            this.groupBox1.TabIndex = 10;
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
            this.lblError.Location = new System.Drawing.Point(272, 107);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 11;
            // 
            // FrmClaveDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(609, 392);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCadenaMensaje);
            this.Controls.Add(this.btnGenerarManual);
            this.Controls.Add(this.btnGenerarAuto);
            this.Controls.Add(this.label1);
            this.Name = "FrmClaveDES";
            this.Text = "FrmClaveDES";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarAuto;
        private System.Windows.Forms.Button btnGenerarManual;
        private System.Windows.Forms.TextBox txtCadenaMensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblMensaje;

    }
}