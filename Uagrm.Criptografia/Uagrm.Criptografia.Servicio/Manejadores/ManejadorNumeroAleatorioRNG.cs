using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Uagrm.Criptografia.Servicio.Manejadores
{
    public class ManejadorNumeroAleatorioRNG
    {
        /// <summary>
        /// Método genera numeros aleatorios.
        /// </summary>
        /// <param name="pNumeroByteAGenerar">Número de byte a generar.</param>
        /// <returns>
        /// Mensajes de impresión.
        /// </returns>
        public static string GenerarNumeroAleatorio(int pNumeroByteAGenerar)
        {
            // Declara mensajes de impresión.
            string vMsgImpresion = string.Empty;

            // El número de bytes a generar
            byte[] vNumeroArray = new byte[pNumeroByteAGenerar];

            // Instancia servio criptor RNG.
            RNGCryptoServiceProvider vServicioCriptorRNG = new RNGCryptoServiceProvider();

            // Rellena una matriz de bytes con una secuencia aleatoria de valores sólidamente
            //     cifrada a 'vNumeroArray'.
            vServicioCriptorRNG.GetBytes(vNumeroArray);

            // Recorre array de números.
            for (int i = 0; i < vNumeroArray.Length; i++)
            {
                vMsgImpresion += " => " + vNumeroArray[i].ToString() + " ";
            }

            // Retorna mensaje.
            return vMsgImpresion;
        }       
    }
}
