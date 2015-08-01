using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodeCofe.Criptografia.Servicio.Manejadores
{
    /// <summary>
    /// Clase maneja claves por DESCryptoServiceProvider.
    /// </summary>
    public class ManejadorClavesPorDES
    {
        /// <summary>
        /// Método genera claves automaticamente.
        /// </summary>
        /// <returns>
        /// Mensajes de impresión.
        /// </returns>
        public static string GenerarClavesAutomaticamente()
        {
            // Declara mensajes de impresión.
            string vMsgImpresion = string.Empty;

            // Crea instancia de DESCryptoServiceProvider. 
            // Crear claves simétricas automáticamente.
            DESCryptoServiceProvider vServicioCriptograficoDES = new DESCryptoServiceProvider();

            // Genera claves.
            vServicioCriptograficoDES.GenerateIV();
            vServicioCriptograficoDES.GenerateKey();

            // Asigna las claves generadas a variables.
            byte[] vClaveIV = vServicioCriptograficoDES.IV;
            byte[] vClaveKey = vServicioCriptograficoDES.Key;

            // Asigna mensajes.
            vMsgImpresion += "GENERACION AUTOMATICA (DES): La longitud de la clave (KeySize) es de " + vServicioCriptograficoDES.KeySize + " bytes. \n ";
            vMsgImpresion += "GENERACION AUTOMATICA (DES): La longitud de la clave es de " + vClaveKey.Length + " bytes \n ";
            
            // Retorna mensaje.
            return vMsgImpresion;
        }

        /// <summary>
        /// Método genera claves manualmente.
        /// </summary>
        /// <param name="pClave">Cadena de clave.</param>
        /// <returns>
        /// Mensajes de impresión.
        /// </returns>
        public static string GenerarClavesManualmente(string pClave)
        {
            // Declara mensajes de impresión.
            string vMsgImpresion = string.Empty;

            // Crear la clave manualmente a partir de una cadena de texto
            DESCryptoServiceProvider vServicioCriptograficoDES = new DESCryptoServiceProvider();

            // Asigna a variable la longitud de las claves.
            int vLonmgitudClaves = vServicioCriptograficoDES.KeySize;

            // Establecer la clave secreta.
            // La longitud de la cadena debe ser de al menos (bits/8) bytes.
            int vLongitudAceptableCadena = vLonmgitudClaves / 8;

            // Verfifica si longitud de pClave es menor a vLongitudAceptableCadena.
            if (pClave.Length < vLongitudAceptableCadena)
            {
                // Comprime longitud de cadena de pClave.
                pClave += new string('F', vLongitudAceptableCadena - pClave.Length);
            }

            // Convierte la cadena 'pClave' a array de bytes.
            vServicioCriptograficoDES.Key = Encoding.Default.GetBytes(pClave.Substring(0, vLongitudAceptableCadena));
            vServicioCriptograficoDES.IV = Encoding.Default.GetBytes(pClave.Substring(0, vLongitudAceptableCadena));

            // Asigna las claves generadas.
            byte[] vClaveIV = vServicioCriptograficoDES.IV;
            byte[] vClaveKey = vServicioCriptograficoDES.Key;

            // Asigna mensajes.
            vMsgImpresion += "GENERACION MANUAL (DES): La longitud de la clave (KeySize) es de " + vServicioCriptograficoDES.KeySize + " bytes. \n ";
            vMsgImpresion += "GENERACION MANUAL (DES): La longitud de la clave es de " + vClaveKey.Length + " bytes \n ";

            // Retorna mensaje.
            return vMsgImpresion;
        }
       
    }
}
