using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Uagrm.Criptografia.Servicio.Manejador
{
    /// <summary>
    /// Clase genera firma digital por DSA.
    /// </summary>
    public class ManejadorFirmaDigitalDSA
    {
        // Constante algoritmo.
        private const string ALGORITMO = "SHA1";

        // Declaración de variables globales.
        static string vClavePublica = null;
        static byte[] vFirmaDigital = null;
        static byte[] vClaveHash = null;

        /// <summary>
        /// Método realiza firma digital.
        /// </summary>
        /// <param name="pCadenaTexto">Cadena de texto.</param>
        /// <returns>
        /// Mensajes de impresión.
        /// </returns>
        public static string RealizarFirmaDigitalPorDSA(string pCadenaTexto)
        {
            // Declara mensajes de impresión.
            string vMsgImpresion = string.Empty;

            // Instancia servicio criptografico DSA.
            DSACryptoServiceProvider vServicioCriptorDSA = new DSACryptoServiceProvider();

            // Obtiene claves privadas y publicas.
            string vClaves = vServicioCriptorDSA.ToXmlString(true);

            // Genera clave hash.
            vClaveHash = GenerarClaveSHA1(pCadenaTexto);

            // Convierte a cadena array de clave SHA1.
            string vCadenaClaveSHA1 = Convert.ToBase64String(vClaveHash);

            vMsgImpresion += "FIRMA DIGITAL - Cadena de entrada (DSA): " + pCadenaTexto + " \n ";

            vMsgImpresion += "GERERAR CLAVE SHA1 - Cadena de clave hash (DSA): " + vCadenaClaveSHA1 + " \n ";

            // Crea firma digital para la clave hash.
            vFirmaDigital = CrearFirmaDigitalDSA(vClaveHash, vClaves);

            // Convierte a cadena array de firma digital.
            string vCadenaFirmaDigital = Convert.ToBase64String(vFirmaDigital);

            vMsgImpresion += "GERERAR FIRMA DIGITAL (DSA): Se cargaron clave privada y pública a servicio criptor DSA \n ";

            vMsgImpresion += "GERERAR FIRMA DIGITAL - Cadena firma digital (DSA): " + vCadenaFirmaDigital + " \n ";

            // Obtiene clave pública.
            vClavePublica = vServicioCriptorDSA.ToXmlString(false);

            // Retorna mensaje.
            return vMsgImpresion;
        }

        /// <summary>
        /// Método compruena firma digital.
        /// </summary>
        /// <returns>
        /// Mensajes de impresión.
        /// </returns>
        public static string ComprobarFirmaDigital()
        {
            // Declara mensajes de impresión.
            string vMsgImpresion = string.Empty;

            // Asigna valores de cadena a variables para mostrarlos en impresión.
            string vFirmaDigitalTexto = Convert.ToBase64String(vFirmaDigital);
            string vClaveHashTexto = Convert.ToBase64String(vClaveHash);

            vMsgImpresion += "VERIFICACION FIRMA DIGITAL (DSA) - Firma Digital: " + vFirmaDigitalTexto + " \n ";
            vMsgImpresion += "VERIFICACION FIRMA DIGITAL (DSA) - Clave Hash: " + vClaveHashTexto + " \n ";
            vMsgImpresion += "VERIFICACION FIRMA DIGITAL (DSA) - Clave pública: " + vClavePublica + " \n ";

            // Comprobamos si los datos son correctos.
            bool vFirmaDigitalEsCorrecta = ComprobarFirmaDigitalDSA(vClavePublica, vFirmaDigital, vClaveHash);

            vMsgImpresion += "VERIFICACION FIRMA DIGITAL (DSA): Se cargo clave pública, firmadigital y clavehash  \n ";

            // Valida si verificación de firma digital es true.
            if (vFirmaDigitalEsCorrecta)
            {
                vMsgImpresion += "VERIFICACION FIRMA DIGITAL (DSA): La comprobación es correcta. \n ";
            }
            else
            {
                vMsgImpresion += "VERIFICACION FIRMA DIGITAL (DSA): La comprobación no es correcta. \n ";
            }

            // Retorna mensaje.
            return vMsgImpresion;
        }

        /// <summary>
        /// Método genera clave SHA1.
        /// </summary>
        /// <param name="pTexto">Cadena de texto.</param>
        /// <param name="pMsgImpresion">Parametro de salida por referencia Mensaje impresión.</param>
        /// <returns>
        /// Clave SHA1.
        /// </returns>
        private static byte[] GenerarClaveSHA1(string pTexto)
        {
            // Instancia clase UFT8Encoding.
            UTF8Encoding vEncodingUFT8 = new UTF8Encoding();

            // Convierte pTexto a array de bytes la clave SHA1.
            byte[] datos = vEncodingUFT8.GetBytes(pTexto);

            // Instancia servicio criptor SHA1. 
            SHA1CryptoServiceProvider vServicioCriptorSHA1 = new SHA1CryptoServiceProvider();

            // Retorna clave SHA1.
            return vServicioCriptorSHA1.ComputeHash(datos);
        }


        /// <summary>
        /// Método crea firma digital.
        /// </summary>
        /// <param name="pClaveHash">Array byte de clave hash.</param>
        /// <param name="pClavesXML">Claves xml pública y privada.</param>
        /// <returns>
        /// Firma digital.
        /// </returns>
        private static byte[] CrearFirmaDigitalDSA(byte[] pClaveHash, string pClavesXML)
        {
            // Instancia servicio criptor DSA.
            DSACryptoServiceProvider vServicioCriptorDSA = new DSACryptoServiceProvider();

            // Asignamos las claves públicas y privadas a servicio criptor.
            vServicioCriptorDSA.FromXmlString(pClavesXML);

            // Instancia por medio de servicio criptor a formateador de firma por medio de DSA.
            DSASignatureFormatter vFormateadorFirmaDSA = new DSASignatureFormatter(vServicioCriptorDSA);

            // Indica el algoritmo hash a utilizar.
            vFormateadorFirmaDSA.SetHashAlgorithm(ALGORITMO);

            // Creamos la firma digital y se retorna.
            return vFormateadorFirmaDSA.CreateSignature(pClaveHash);
        }

        /// <summary>
        /// Método verifica si firma digital es correcta.
        /// </summary>
        /// <param name="pClavePublica">Cadena clave pública.</param>
        /// <param name="pFirmaDigital">Array byte de firma digital.</param>
        /// <param name="pClaveHash">Array byte clave hash.</param>
        /// <returns>
        /// Resultado booleano de verificación.
        /// </returns>
        private static bool ComprobarFirmaDigitalDSA(string pClavePublica, byte[] pFirmaDigital, byte[] pClaveHash)
        {
            // Instancia servicio de criptación DSA.
            DSACryptoServiceProvider vServicioCriptorDSA = new DSACryptoServiceProvider();

            // Asigna clave pública a servicio criptor.
            vServicioCriptorDSA.FromXmlString(pClavePublica);

            // Instancia por medio de servicio criptor a formateador de firma por medio de DSA.
            DSASignatureDeformatter vFormateadorFirmaDSA = new DSASignatureDeformatter(vServicioCriptorDSA);

            // Indica el algoritmo hash a utilizar.
            vFormateadorFirmaDSA.SetHashAlgorithm(ALGORITMO);

            // Verifica si firma digital es correcto y asigna  resultado a una variable booleana.
            bool vFirmaEsCorrecta = vFormateadorFirmaDSA.VerifySignature(pClaveHash, pFirmaDigital);

            // Retorna resultado.
            return vFirmaEsCorrecta;
        }

    }
}
