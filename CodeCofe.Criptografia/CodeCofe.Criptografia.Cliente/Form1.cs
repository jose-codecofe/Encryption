using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCofe.Criptografia.Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClaveDES_Click(object sender, EventArgs e)
        {
            // Instancia formulario.
            FrmClaveDES vFrmClaveDES = new FrmClaveDES();

            // Carga formulario a panel.
            CargarFormularioAPanel(vFrmClaveDES);

        }

        /// <summary>
        /// Método carga formularios hijos a panel.
        /// </summary>
        /// <param name="pFormularioHijo">Elemnto formulario.</param>
        private void CargarFormularioAPanel(Form pFormularioHijo)
        {
            // Verifica si panel contiene un elemento.
            if (this.panelContenedor.Controls.Count > 0)
                // Elimana elemento de panel.
                this.panelContenedor.Controls.RemoveAt(0);

            // Asigna parametros de formulario.
            pFormularioHijo.TopLevel = false;
            pFormularioHijo.FormBorderStyle = FormBorderStyle.None;
            pFormularioHijo.Dock = DockStyle.Fill;

            // Adiciona formulario a panel.
            this.panelContenedor.Controls.Add(pFormularioHijo);
            this.panelContenedor.Tag = pFormularioHijo;

            // Muestra formulario.
            pFormularioHijo.Show();
        }

        private void btnCifrarRSA_Click(object sender, EventArgs e)
        {
            // Instancia formulario.
            FrmCifradoRSA vFrmCifradoRSA = new FrmCifradoRSA();

            // Carga formulario a panel.
            CargarFormularioAPanel(vFrmCifradoRSA);
        }

        private void btnFirmaDigital_Click(object sender, EventArgs e)
        {
            // Instancia formulario.
            FrmFirmaDigitalDSA vFrmFirmaDigitalDSA = new FrmFirmaDigitalDSA();

            // Carga formulario a panel.
            CargarFormularioAPanel(vFrmFirmaDigitalDSA);
        }

        private void btnNumeroAleatorio_Click(object sender, EventArgs e)
        {
            // Instancia formulario.
            FrmNumeroAleatorioRNG vFrmNumeroAleatorio = new FrmNumeroAleatorioRNG();

            // Carga formulario a panel.
            CargarFormularioAPanel(vFrmNumeroAleatorio);
        }
    }
}
