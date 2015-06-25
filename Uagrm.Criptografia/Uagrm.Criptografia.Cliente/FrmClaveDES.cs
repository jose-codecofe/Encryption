using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uagrm.Criptografia.Servicio.Manejadores;

namespace Uagrm.Criptografia.Cliente
{
    public partial class FrmClaveDES : Form
    {
        public FrmClaveDES()
        {
            InitializeComponent();
        }

        private void btnGenerarAuto_Click(object sender, EventArgs e)
        {
            // Realiza generacion claves automaticamente por referencia desde proveedor.           
            lblMensaje.Text = ManejadorClavesPorDES.GenerarClavesAutomaticamente();
        }

        private void btnGenerarManual_Click(object sender, EventArgs e)
        {
            // Valida si txtCadenamensaje es vacio.
            if (string.IsNullOrEmpty(txtCadenaMensaje.Text))
            {
                lblError.Text = "El dato de 'Clave' es requerido para generar claves manualmente.";
            }
            else
            {
                lblError.Text = string.Empty;

                // Asigna cadena mensaje a variable.
                string vClave = txtCadenaMensaje.Text;

                // Realiza generación claves manualmente por referencia desde proveedor.
                lblMensaje.Text = ManejadorClavesPorDES.GenerarClavesManualmente(vClave);
            }
        }
    }
}
