using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.tramite;
using Capas.Entidades.usuario;
using System.Net;
using System.Net.Mail;
using System.IO;
using Microsoft.Reporting.WinForms;
using Capas.Entidades.qr;
using Capas.Logica.qrLogica;
using Capas.Entidades.libro;
using Capas.Entidades;
using Capas.Datos;


namespace Capas.Logica.facade
{
    public class TramitarFacade
    {
        public Estudiante Estudiante { set; get; }
        public Usuario Funcionario { set; get; }
        public List<ITipoTramite> ListaTramites { set; get; }
        public bool enEspera { set; get; }

        public TramitarFacade()
        {
            ListaTramites = new List<ITipoTramite>();
        }

        /// <summary>
        /// agrega un tramite en la lista
        /// </summary>
        /// <param name="tramite"></param>
        /// <returns></returns>
        public string agregarTramite(ITipoTramite tramite)
        {
            if (limiteTramites())
            {
                ListaTramites.Add(tramite);
                return "agregado correctamente";
            }
            else
            {
                return "Ya se exedio el limite de prestamos por persona";
            }
          
        }
        /// <summary>
        /// calcula el limite de tramites
        /// </summary>
        /// <returns></returns>
        public bool limiteTramites()
        {
            int cont = 1;

            foreach (var item in ListaTramites)
            {
               if(item.GetType().Equals(typeof(Prestamo)))
                {
                    cont++;
                }
            }

            if (cont<=new Configuracionlogica().seleccionarConfiguracion().cantidadLibros)
            {
                return true;
            }

            return false;
        }


        /// <summary>
        /// elimina un tramite de la lista
        /// </summary>
        /// <param name="numeroLinea"></param>
        public void eliminarTramite(int numeroLinea)
        {
            ListaTramites.RemoveAll(t => t.NumeroLinea == numeroLinea);
        }

        /// <summary>
        /// asigna numero de linea a los tramites
        /// </summary>
        public void asignarLinea()
        {
            int cont = 1;
            foreach (var item in ListaTramites)
            {
                item.NumeroLinea = cont;
                cont++;
            }
        }

        /// <summary>
        /// guarda un comprobante en la base de datos
        /// </summary>
        /// <returns></returns>
        public int guardarComprobante()
        {
            comprobante.ComprobanteLogica comprobante = new Logica.comprobante.ComprobanteLogica();

            return comprobante.guardarComprobante(ListaTramites, enEspera, Estudiante, Funcionario);

        }

        /// <summary>
        /// genera un pdf con el comprobante
        /// </summary>
        /// <param name="reporte"></param>
        /// <returns></returns>
        public byte[] generarPdfComprobante(LocalReport reporte)
        {
            string mimeType, encoding, extension;

            Warning[] warnings;
            string[] streams;

            var bytes = reporte.Render("PDF",
            @"<DeviceInfo><OutputFormat>PDF</OutputFormat><HumanReadablePDF>False</HumanReadablePDF></DeviceInfo>",
            out mimeType,
            out encoding,
            out extension,
            out streams,
            out warnings);

            return bytes;
        }

        /// <summary>
        /// genera un comprobante en formato
        /// xml
        /// </summary>
        /// <returns></returns>
        public string generarXML()
        {

            return "";
        }
        /// <summary>
        /// envia un correo electronico con los comprobantes
        /// </summary>
        /// <param name="estudiante"></param>
        /// <param name="reporte"></param>
        /// <returns></returns>
        public string EnviarCorreo(Estudiante estudiante, LocalReport reporte)
        {

            Configuracion config;
            try
            {
                config = new Configuracionlogica().seleccionarConfiguracion();
            }
            catch (Exception ex)
            {
                LogHelper.WriteDebugLog("extrallendo configuracion base datos correo comprobante " + ex);
                throw;
            }



            string Emisor = config.email;
            string contrasena = config.password;
            string asunto = "Comprobantes";
            string mensaje = "Sr(a) " + estudiante.Nombre + " gracias por Usar la biblioteca Movil! adjuntamos los comprobantes de las transacciones";
            using (SmtpClient cliente = new SmtpClient("smtp.live.com", 25))
            {
                cliente.EnableSsl = true;
                cliente.Credentials = new NetworkCredential(Emisor, contrasena);
                MailMessage mensaje1 = new MailMessage(Emisor, estudiante.CorreoElectronico, asunto, mensaje);
                mensaje1.Attachments.Add(new Attachment(new MemoryStream(generarPdfComprobante(reporte)), "Comprobante.pdf"));

                try
                {
                    cliente.Send(mensaje1);
                    cliente.Timeout = 3000;

                }
                catch (Exception ex)
                {
                    LogHelper.WriteDebugLog("error enviando correo " + ex);
                    return "" + ex.Message;

                }

                return "se le a enviado un email al estudiante con los comprobantes exitosamente!";

            }
        }



        /// <summary>
        /// retorna un arreglo con codigos qr
        /// </summary>
        /// <param name="listaEstudiantes"></param>
        /// <returns></returns>
        public List<Qr> reporteQrEstudiantes(List<Estudiante> listaEstudiantes)
        {
            QrLogica logica = new QrLogica();

            foreach (var item in listaEstudiantes)
            {
                logica.agregarQr(item);
            }

            return logica.listaQrEstudiantes;
        }
        /// <summary>
        /// retorna un alista con codigos qr de libros
        /// </summary>
        /// <param name="listaLibro"></param>
        /// <returns></returns>
        public List<Qr> reporteQrLibros(List<Libro> listaLibro)
        {
            QrLogica logica = new QrLogica();

            foreach (var item in listaLibro)
            {
                logica.agregarQr(item);
            }

            return logica.listaQrLibros;
        }


        /// <summary>
        /// envia email a las personas que no han  devuelto
        /// los libros
        /// </summary>

        public void notificarMorosos()
    {
        Datos.TramiteDatos datos = new Datos.TramiteDatos();

            Configuracion config;
            try
            {
                config = new Configuracionlogica().seleccionarConfiguracion();
            }
            catch (Exception ex)
            {
                LogHelper.WriteDebugLog("error extrallendo configuracion de correo notificar morosos " + ex);
                throw;
            }



      

            foreach (var item in datos.notificarMorosos())
        {

                string Emisor = config.email;
                string contrasena = config.password;

                string asunto = "Devolucion de libro";
            string mensaje = "Sr(a) " + item.enc.Estudiante.Nombre + " gracias por Usar la biblioteca Movil! le solicitamos que por favor nos regrese el libro " + item.det.Libro.Titulo + " que debio devolverse el " + item.det.fechaDevolucion;
            using (SmtpClient cliente = new SmtpClient("smtp.live.com", 25))
            {
                cliente.EnableSsl = true;
                cliente.Credentials = new NetworkCredential(Emisor, contrasena);
                MailMessage mensaje1 = new MailMessage(Emisor, item.enc.Estudiante.CorreoElectronico, asunto, mensaje);

                try
                {
                    cliente.Send(mensaje1);
                    cliente.Timeout = 3000;

                   new TramiteDatos().modificarEstadoNotificacion(item.det.Libro.Codigo);

                }
                catch (Exception ex)
                {
                        LogHelper.WriteDebugLog("error envaindo email a moroso "+ex);
                }


            }
        }
    }


}
}

    






    

