using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeCofe.Criptografia.Servicio.Manejadores;

namespace CodeCofe.Criptografia.Cliente
{
    public partial class FrmNumeroAleatorioRNG : Form
    {
        public FrmNumeroAleatorioRNG()
        {
            InitializeComponent();
        }

        private void btnGenerarNumeros_Click(object sender, EventArgs e)
        {
            // Verifica si 'txtCantidadNumero' es nulo o vacio.
            if (string.IsNullOrEmpty(txtCantidadNumero.Text))
            {
                lblError.Text = "El dato de 'Cantidad Byte a Generar' es requerido.";
            }
            else
            {
                lblError.Text = string.Empty;

                // Declara variable de cantidad.
                int vCantidadByte = 0;

                // Utiliza tryparse para comprobar el tipo de dato entero.
                bool vEsEntero = Int32.TryParse(txtCantidadNumero.Text, out vCantidadByte);

                // Verifica si dato es entero.
                if(vEsEntero)
                {
                    // Genera numeros aleatorios.
                    lblMensaje.Text = ManejadorNumeroAleatorioRNG.GenerarNumeroAleatorio(vCantidadByte);
                }else
                {
                    lblError.Text = "El dato de 'Cantidad Byte a Generar' no es de tipo entero.";
                }
            }
        }
    }
}
