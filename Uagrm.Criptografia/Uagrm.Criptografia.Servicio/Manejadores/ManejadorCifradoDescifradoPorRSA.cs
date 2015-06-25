using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Uagrm.Criptografia.Servicio.Manejador
{
    public class ManejadorCifradoDescifradoPorRSA
    {
        private const string NOMBRE_CONTENEDOR = "ContenedorRSA";

        // Declara variable global de algoritmo de cifrado RSA.
        static RSACryptoServiceProvider vServicioCriptograficoRSA;

        /// <summary>
        /// Método genera claves por 'RSACryptoServiceProvider' y crea los ficheros correspondientes.
        /// </summary>
        /// <returns>
        /// Mensajes de impresión.
        /// </returns>
        public static string GenerarClavesPorRSA()
        {
            // Declara mensajes de impresión.
            string vMsgImpresion = string.Empty;

            // Instancia 'CspParametes' con el tipo de proveedor PROV_RSA_FULL.
            CspParameters vParametrosCsp = new CspParameters(1);

            // Asigna parametros.
            vParametrosCsp.Flags = CspProviderFlags.UseDefaultKeyContainer;
            vParametrosCsp.KeyContainerName = NOMBRE_CONTENEDOR;

            // Instanciar el algoritmo de cifrado RSA
            vServicioCriptograficoRSA = new RSACryptoServiceProvider(vParametrosCsp);

            /*  GENERACION DE LLAVES */

            // Nota: El constructor de StreamWriter acepta una ruta especifica
            // para generar el xml por ejemplo D:\llave_privada.xml 
            // si solo se asigna el fichero llave_privada.xml se generar la carpeta BIN del cliente
            // ..\Uagrm.Criptografia\Uagrm.Criptografia.Cliente\bin\Debug

            // Crea el fichero llave_privada.xml e instancia la clase 'StreamWriter'.
            StreamWriter vEscritorStreamPri = new StreamWriter(@"llave_privada.xml");

            vMsgImpresion += "GENERAR CLAVE (RSA): Se genero el fichero 'llave_privada.xml'. \n ";

            // Asigna clave privada a variable.
            string vClavePrivadaXML = vServicioCriptograficoRSA.ToXmlString(true);

            // Escribe clave privada en el fichero llave_privada.xml.
            vEscritorStreamPri.Write(vClavePrivadaXML);

            vMsgImpresion += "Clave Privada XML (RSA): " + vClavePrivadaXML + " \n ";
            vMsgImpresion += "Se escribio clave privada en 'llave_privada.xml' \n ";

            // Cierra escritor stream.
            vEscritorStreamPri.Close();

            // Crea el fichero llave_publica.xml e instancia la clase 'StreamWriter'.
            StreamWriter vEscritorStreamPub = new StreamWriter(@"llave_publica.xml");

            vMsgImpresion += "GENERAR CLAVE (RSA): Se genero el fichero 'llave_publica.xml'. \n ";

            // Asigna clave publica a variable.
            string vClavePublicaXML = vServicioCriptograficoRSA.ToXmlString(false);

            // Escribe clave pública en el fichero llave_publica.xml.
            vEscritorStreamPub.Write(vClavePublicaXML);

            vMsgImpresion += "Clave Pública XML (RSA): " + vClavePublicaXML + " \n ";
            vMsgImpresion += "Se escribio clave pública en 'llave_publica.xml' \n ";

            // Cierra escritor stream.
            vEscritorStreamPub.Close();

            // Retorna mesnaje.
            return vMsgImpresion;
        }

        /// <summary>
        /// Método carga clave pública a servicio de criptografia.
        /// </summary>
        /// <returns>
        /// Clave pública en xml.
        /// </returns>
        private static string CargarClavePublicaAServicioCriptografiaRSA()
        {
            // Carga datos a memoria desde 'llave_publica.xml'.
            StreamReader vLectorStream = new StreamReader(@"llave_publica.xml");

            // Lee y asigna a variable clave pública.
            string vClavePublicaXML = vLectorStream.ReadToEnd();

            // Asigna clave pública xml a servicio criptografico RSA.
            vServicioCriptograficoRSA.FromXmlString(vClavePublicaXML);

            // Cierra lector stream.
            vLectorStream.Close();

            // Retorna clave pública xml.
            return vClavePublicaXML;
        }


        /// <summary>
        /// Método carga clave privada a servicio de criptografica.
        /// </summary>
        /// <returns>
        /// Clave privada en xml.
        /// </returns>
        private static string CargarClavePrivadaAServicioCriptograficoRSA()
        {
            // Carga datos a memoria desde 'llave_privada.xml'. 
            StreamReader vLectorStream = new StreamReader(@"llave_privada.xml");

            // Lee y asigna a variable clave privada.
            string vClavePrivadaXML = vLectorStream.ReadToEnd();

            // Asigna clave privada xml a servicio criptografico RSA.
            vServicioCriptograficoRSA.FromXmlString(vClavePrivadaXML);

            // Cierra lector stream.
            vLectorStream.Close();

            // Retorna clave privada xml.
            return vClavePrivadaXML;
        }

        /// <summary>
        /// Método cifra mensaje por servicio criptografico RSA.
        /// Nota: Solo se requiere cargar clave pública.
        /// </summary>
        /// <param name="pMensaje">Cadena mensaje.</param>
        /// <param name="pMensajeCifrado">Parametro de salida por referencia cadena de mensaje cifrado.</param>
        /// <returns>
        /// Mensaje de impresión.
        /// </returns>
        public static string CifrarMensajePorRSA(string pMensaje, ref string pMensajeCifrado)
        {
            // Declara mensajes de impresión.
            string vMsgImpresion = string.Empty;

            // Genera claves y ficheros por rsa y asigna a variable mensajes de proceso.
            //vMsgImpresion += GenerarClavesPorRSA();

            // Carga a servicio criptografico RSA y obtiene clave pública.
            string vClavePublica = CargarClavePublicaAServicioCriptografiaRSA();

            // Convierte 'vMensaje'a su representación en byte.
            byte[] vMensajeByte = System.Text.Encoding.UTF8.GetBytes(pMensaje);

            // Realiza el proceso de cifrado a 'vMensajeByte'
            byte[] vMensajeCifradoByte = vServicioCriptograficoRSA.Encrypt(vMensajeByte, false);

            // Convierte el mensaje cifrado a su representación en cadena.
            pMensajeCifrado = Convert.ToBase64String(vMensajeCifradoByte);

            vMsgImpresion += "CIFRADO (RSA) - Mensaje Original: " + pMensaje + " \n ";

            vMsgImpresion += "CIFRADO (RSA) - Se Cargo Clave Pública: " + vClavePublica + " \n ";

            vMsgImpresion += "CIFRADO (RSA) - Mensaje Cifrado: " + pMensajeCifrado + " \n ";

            // Retorna mensaje.
            return vMsgImpresion;
        }

        /// <summary>
        /// Método descifra mensaje cifrado por servicio criptografico RSA.
        /// </summary>
        /// <param name="pMensajeCifrado">Cadena mensaje cifrado.</param>
        /// <returns>
        /// Ménsaje de impresión.
        /// </returns>
        public static string DescifrarMensajePorRSA(string pMensajeCifrado)
        {
            // Declara mensajes de impresión.
            string vMsgImpresion = string.Empty;

            // Genera claves y ficheros por rsa y asigna a variable mensajes de proceso.
          //  vMsgImpresion += GenerarClavesPorRSA();

            // Carga a servicio criptografico RSA y obtiene clave privada.
            string vClavePrivada = CargarClavePrivadaAServicioCriptograficoRSA();

            // Convertir mensaje cifrado a su representación en byte.
            byte[] vMensajeCifradoByte = Convert.FromBase64String(pMensajeCifrado);

            // Descifra mensaje cifrado por RSA.
            byte[] vMensajeOriginalByte = vServicioCriptograficoRSA.Decrypt(vMensajeCifradoByte, false);

            // Convierte a cadena el mensaje descifrado.
            string vMensajeDescifrado = System.Text.Encoding.UTF8.GetString(vMensajeOriginalByte);

            vMsgImpresion += "DESCIFRADO (RSA) - Se Cargo Clave Privada: " + vClavePrivada + " \n ";

            vMsgImpresion += "DESCIFRADO (RSA) - Mensaje descifrado: " + vMensajeDescifrado + " \n ";

            // Retorna mensaje. 
            return vMsgImpresion;
        }











        //public static void pruebaRSA()
        //{
        //    RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        //    string claves = rsa.ToXmlString(true);
        //    string clavePublica = rsa.ToXmlString(false);
        //    string texto = "Hola, Mundo";
        //    // Para cifrar solo es necesario la clave pública,
        //    // aunque también podemos usar las dos claves
        //    byte[] datosEnc = cifrarRSA(texto, clavePublica);
        //    // Para descifrar necesitamos la clave pública y privada
        //    string res = descrifrarRSA(claves, datosEnc);
        //    Console.WriteLine(res);
        //}
        //public static byte[] cifrarRSA(string texto, string clavePublica)
        //{
        //    RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        //    // La clave pública usada para cifrar el texto
        //    rsa.FromXmlString(clavePublica);
        //    // Convertimos la cadena a un array de bytes
        //    byte[] datos = Encoding.Default.GetBytes(texto);
        //    // Generamos los datos encriptados y los devolvemos
        //    return rsa.Encrypt(datos, false);
        //}
        //public static string descrifrarRSA(string claves, byte[] datosCifrados)
        //{
        //    RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        //    // Las claves usadas para cifrar el texto
        //    rsa.FromXmlString(claves);
        //    // Generamos los datos desencriptados
        //    byte[] datos = rsa.Decrypt(datosCifrados, false);
        //    // Devolvemos la cadena original
        //    return Encoding.Default.GetString(datos);
        //}
    }
}
