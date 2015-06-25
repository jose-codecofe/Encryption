using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uagrm.Criptografia.Servicio.Manejador;

namespace Uagrm.Criptografia.Cliente
{
    public partial class FrmFirmaDigitalDSA : Form
    {
        public FrmFirmaDigitalDSA()
        {
            InitializeComponent();

            btnComprobarFirma.Enabled = false;
        }

        private void btnGenerarFirma_Click(object sender, EventArgs e)
        {
            // Verifica si cadena firma es vacio o nulo.
            if (string.IsNullOrEmpty(txtCadenaFirma.Text))
            {
                lblError.Text = "El campo 'Cadena Firma' es requerido.";
            }
            else
            {
                lblError.Text = string.Empty;
                btnComprobarFirma.Enabled = true;

                // Asigna dato de cadena firma a variable.
                string vCadenaFirma = txtCadenaFirma.Text;

                // Realiza firma digital en base a cadena firma.
                lblMensaje.Text = ManejadorFirmaDigitalDSA.RealizarFirmaDigitalPorDSA(vCadenaFirma);

            }
        }

        private void btnComprobarFirma_Click(object sender, EventArgs e)
        {
            // Realiza firma digital en base a cadena firma.
            lblMensaje.Text = ManejadorFirmaDigitalDSA.ComprobarFirmaDigital();
        }
    }
}
