using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeCofe.Criptografia.Servicio.Manejador;

namespace CodeCofe.Criptografia.Cliente
{
    public partial class FrmCifradoRSA : Form
    {
        private string vMensajeCifrado;

        public FrmCifradoRSA()
        {
            InitializeComponent();

            // Deshabilita botones.
            btnCifrarMensaje.Enabled = false;
            btnDescifrarMensaje.Enabled = false;
        }

        private void btnGenerarClaves_Click(object sender, EventArgs e)
        {
            // Genera claves publica y privada ficheros en BIN desde el proyecto de proveedor.
            lblMensaje.Text = ManejadorCifradoDescifradoPorRSA.GenerarClavesPorRSA();

            // Habilita botones.
            btnCifrarMensaje.Enabled = true;
            btnDescifrarMensaje.Enabled = true;
        }

        private void btnCifrarMensaje_Click(object sender, EventArgs e)
        {
            // Verifica si 'txtMensaje' es nulo o vacio.
            if (string.IsNullOrEmpty(txtMensaje.Text))
            {
                lblError.Text = "El dato de 'Mensaje' es requerido.";
            }
            else
            {
                lblError.Text = string.Empty;

                // Asigna texto de mensaje a variable.
                string vMensaje = txtMensaje.Text;

                // Cifra cadena de mensaje.
                lblMensaje.Text = ManejadorCifradoDescifradoPorRSA.CifrarMensajePorRSA(vMensaje, ref vMensajeCifrado);
            }
        }

        private void btnDescifrarMensaje_Click(object sender, EventArgs e)
        {
            // Descifra mensaje encriptado desde el proyecto de proveedor.
            lblMensaje.Text = ManejadorCifradoDescifradoPorRSA.DescifrarMensajePorRSA(vMensajeCifrado);
        }

    }
}
