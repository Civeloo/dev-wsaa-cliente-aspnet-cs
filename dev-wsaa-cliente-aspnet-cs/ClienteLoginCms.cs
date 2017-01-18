using System;
using System.Diagnostics;
using System.Security;

namespace dev_wsaa_cliente_aspnet_cs
{
    /// <summary>
    /// Clase principal
    /// </summary>
    /// <remarks></remarks>
    //class ProgramaPrincipal
    public class ClienteLoginCms
    {
        // Valores por defecto, globales en esta clase
        const string DEFAULT_URLWSAAWSDL = "https://wsaahomo.afip.gov.ar/ws/services/LoginCms?WSDL";
        const string DEFAULT_SERVICIO = "wsfe";
        const string DEFAULT_CERTSIGNER = "c:\\MiCertificadoConClavePrivada.pfx";
        const string DEFAULT_PASSWORDSECURE = "";
        const string DEFAULT_PROXY = null;
        const string DEFAULT_PROXY_USER = null;
        const string DEFAULT_PROXY_PASSWORD = null;
        const bool DEFAULT_VERBOSE = true;

        /// <summary>
        /// Funcion Main (consola)
        /// </summary>
        /// <param name="args">Argumentos de linea de comandos</param>
        /// <returns>0 si terminó bien, valores negativos si hubieron errores</returns>
        /// <remarks></remarks>
        //public static int Main(string[] args)
        //{
        //const string ID_FNC = "[Main]";

        //string strUrlWsaaWsdl = DEFAULT_URLWSAAWSDL;
        //string strIdServicioNegocio = DEFAULT_SERVICIO;
        //string strRutaCertSigner = DEFAULT_CERTSIGNER;
        //SecureString strPasswordSecureString = new SecureString();
        ////Convert string to securestring
        //foreach (char c in DEFAULT_PASSWORDSECURE)
        //    strPasswordSecureString.AppendChar(c);
        //strPasswordSecureString.MakeReadOnly();
        ////
        //string strProxy = DEFAULT_PROXY;
        //string strProxyUser = DEFAULT_PROXY_USER;
        //string strProxyPassword = DEFAULT_PROXY_PASSWORD;
        //bool blnVerboseMode = DEFAULT_VERBOSE;

        //MostrarVersion();

        ///*if (args.Length == 0)
        //{
        //    ExplicarUso();
        //    return -1;
        //}*/

        //// Analizo argumentos de linea de comandos
        //for (int i = 0; i <= args.Length - 1; i++)
        //{
        //    string argumento;
        //    argumento = args[i];

        //    if (String.Compare(argumento, "-w", true) == 0)
        //    {
        //        if (args.Length < (i + 2))
        //        {
        //            Debug.WriteLine("Error: no se especificó la URL del WSDL del WSAA");
        //            return -1;
        //        }
        //        else
        //        {
        //            strUrlWsaaWsdl = args[i + 1];
        //            i = i + 1;
        //        }
        //    }

        //    else if (String.Compare(argumento, "-s", true) == 0)
        //    {
        //        if (args.Length < (i + 2))
        //        {
        //            Debug.WriteLine("Error: no se especificó el ID del servicio de negocio");
        //            return -1;
        //        }
        //        else
        //        {
        //            strIdServicioNegocio = args[i + 1];
        //            i = i + 1;
        //        }
        //    }

        //    else if (String.Compare(argumento, "-c", true) == 0)
        //    {
        //        if (args.Length < (i + 2))
        //        {
        //            Debug.WriteLine("Error: no se especificó ruta del certificado firmante");
        //            return -1;
        //        }
        //        else
        //        {
        //            strRutaCertSigner = args[i + 1];
        //            i = i + 1;
        //        }
        //    }

        //    else if (String.Compare(argumento, "-p", true) == 0)
        //    {
        //        if (args.Length < (i + 2))
        //        {
        //            Debug.WriteLine("Error: no se especificó password del certificado firmante");
        //            return -1;
        //        }
        //        else
        //        {
        //            foreach (char c in args[i + 1]) strPasswordSecureString.AppendChar(c);
        //            strPasswordSecureString.MakeReadOnly();
        //            i = i + 1;
        //        }
        //    }

        //    else if (String.Compare(argumento, "-x", true) == 0)
        //    {
        //        if (args.Length < (i + 2))
        //        {
        //            Debug.WriteLine("Error: no se especificó IP:port del proxy");
        //            return -1;
        //        }
        //        else
        //        {
        //            strProxy = args[i + 1];
        //            i = i + 1;
        //        }
        //    }

        //    else if (String.Compare(argumento, "-y", true) == 0)
        //    {
        //        if (args.Length < (i + 2))
        //        {
        //            Debug.WriteLine("Error: no se especificó usuario del proxy");
        //            return -1;
        //        }
        //        else
        //        {
        //            strProxyUser = args[i + 1];
        //            i = i + 1;
        //        }
        //    }

        //    else if (String.Compare(argumento, "-z", true) == 0)
        //    {
        //        if (args.Length < (i + 2))
        //        {
        //            Debug.WriteLine("Error: no se especificó password del proxy");
        //            return -1;
        //        }
        //        else
        //        {
        //            strProxyPassword = args[i + 1];
        //            i = i + 1;
        //        }
        //    }

        //    else if (String.Compare(argumento, "-v", true) == 0)
        //    {
        //        if (args.Length < (i + 2))
        //        {
        //            Debug.WriteLine("Error: no se especificó modo: on|off");
        //            return -1;
        //        }
        //        else
        //        {
        //            blnVerboseMode = (String.Compare(args[i + 1], "on", true) == 0 ? true : false);
        //            i = i + 1;
        //        }
        //    }

        //    else if (String.Compare(argumento, "-?", true) == 0)
        //    {
        //        ExplicarUso();
        //        return 0;
        //    }

        //    else
        //    {
        //        System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
        //        FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);

        //        Debug.WriteLine("Error: argumento desconocido: {0}", argumento);
        //        Debug.WriteLine("Para obtener ayuda: {0} -?", fvi.ProductName);
        //        return -2;
        //    }
        //}
        //}
        // Argumentos OK, entonces procesar normalmente...
        public static void process()
        {
            const string ID_FNC = "[Main]";

            string strUrlWsaaWsdl = DEFAULT_URLWSAAWSDL;
            string strIdServicioNegocio = DEFAULT_SERVICIO;
            string strRutaCertSigner = DEFAULT_CERTSIGNER;
            SecureString strPasswordSecureString = new SecureString();
            //Convert string to securestring
            foreach (char c in DEFAULT_PASSWORDSECURE)
                strPasswordSecureString.AppendChar(c);
            strPasswordSecureString.MakeReadOnly();
            //
            string strProxy = DEFAULT_PROXY;
            string strProxyUser = DEFAULT_PROXY_USER;
            string strProxyPassword = DEFAULT_PROXY_PASSWORD;
            bool blnVerboseMode = DEFAULT_VERBOSE;
            //
            LoginTicket objTicketRespuesta = null;
            string strTicketRespuesta = null;

            try
            {
                if (blnVerboseMode)
                {
                    Debug.WriteLine(ID_FNC + "***Servicio a acceder: {0}", strIdServicioNegocio);
                    Debug.WriteLine(ID_FNC + "***URL del WSAA: {0}", strUrlWsaaWsdl);
                    Debug.WriteLine(ID_FNC + "***Ruta del certificado: {0}", strRutaCertSigner);
                    Debug.WriteLine(ID_FNC + "***Modo verbose: {0}", blnVerboseMode);
                }
                objTicketRespuesta = new LoginTicket();
                if (blnVerboseMode) Debug.WriteLine(ID_FNC + "***Accediendo a {0}", strUrlWsaaWsdl);
                strTicketRespuesta = objTicketRespuesta.ObtenerLoginTicketResponse(strIdServicioNegocio, strUrlWsaaWsdl, strRutaCertSigner, strPasswordSecureString, strProxy, strProxyUser, strProxyPassword, blnVerboseMode);
            }
            catch (Exception excepcionAlObtenerTicket)
            {
                Debug.WriteLine(ID_FNC + "***EXCEPCION AL OBTENER TICKET: " + excepcionAlObtenerTicket.Message);
                //return -10;
            }
            //return 0;
        }

        /// <summary>
        /// Explica el uso del comando
        /// </summary>
        /// <remarks></remarks>
        public static void ExplicarUso()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);

            Debug.WriteLine("");
            Debug.WriteLine("Uso: {0} [opciones]...", fvi.ProductName);
            Debug.WriteLine("");
            Debug.WriteLine("opciones:");
            Debug.WriteLine("");
            Debug.WriteLine("  -s servicio      ID del servicio de negocio");
            Debug.WriteLine("                   Valor por defecto: " + DEFAULT_SERVICIO);
            Debug.WriteLine("");
            Debug.WriteLine("  -c certif        Ruta del certificado (con clave privada)");
            Debug.WriteLine("                   Valor por defecto: " + DEFAULT_CERTSIGNER);
            Debug.WriteLine("");
            Debug.WriteLine("  -p certifpwd     Password del certificado (con clave privada)");
            Debug.WriteLine("                   Valor por defecto: sin password");
            Debug.WriteLine("");
            Debug.WriteLine("  -x IP:port       IP:port del proxy");
            Debug.WriteLine("                   Valor por defecto: sin proxy");
            Debug.WriteLine("");
            Debug.WriteLine("  -y proxyusr      Usuario del proxy");
            Debug.WriteLine("                   Valor por defecto: sin usuario proxy");
            Debug.WriteLine("");
            Debug.WriteLine("  -z proxypwd      Password del proxy");
            Debug.WriteLine("                   Valor por defecto: sin password proxy");
            Debug.WriteLine("");
            Debug.WriteLine("  -w url           URL del WSDL del WSAA");
            Debug.WriteLine("                   Valor por defecto: " + DEFAULT_URLWSAAWSDL);
            Debug.WriteLine("");
            Debug.WriteLine("  -v on|off        Reportes detallados de la ejecución");
            Debug.WriteLine("");
            Debug.WriteLine("  -?               Esta ayuda");
            //Debug.Read();
        }

        public static void MostrarVersion()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);

            Debug.WriteLine("Aplicacion: {0}", fvi.ProductName);
            Debug.WriteLine("Version   : {0}", fvi.FileVersion);
        }
    }
}
