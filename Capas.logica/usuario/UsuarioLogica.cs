using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.usuario;
using Capas.Datos;
using System.Net;
using System.Net.Mail;
using Capas.Logica.qrLogica;
using Capas.Entidades.qr;
using Capas.Entidades;

namespace Capas.Logica.usuario
{
    public class UsuarioLogica
    {
/// <summary>
/// inserta a un usuario en la base de datos
/// </summary>
/// <param name="user"></param>
/// <returns></returns>
        public String insertarUsuario(Usuario user)
        {
            UsuarioDatos datos = new UsuarioDatos();
            if (selecionarusuario(user.Cedula) == null)
            {
                user.primerIngreso = true;
                user.Password = crearContrasenas();
                datos.insertarUsuario(user);

                return "usuario registrado correctamente ! " + EnviarCorreo(user);
            }
            else
            {
                datos.actualizarUsuario(user);

                return "usuario actualizado corectamente!";
            }


        }

        /// <summary>
        /// muestra una lista de solo estudiantes por medio de un filtro
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="primerApellido"></param>
        /// <param name="segundoApellido"></param>
        /// <param name="centro"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        public List<Usuario> listaEstudiantesConFiltro(string id,
            string nombre, string primerApellido, string segundoApellido, int centro,
            string seccion)
        {
            UsuarioDatos datos = new UsuarioDatos();
            return datos.listaEstudiantesConFiltro(id, nombre, primerApellido, segundoApellido, centro, seccion);
        }
        /// <summary>
        /// lista a todos los usuario
        /// </summary>
        /// <returns></returns>
        public List<Usuario> todosLosUsario()
        {
            UsuarioDatos datos = new UsuarioDatos();
            return datos.listaUsuarios();
        }
        /// <summary>
        /// selecciona a un usuario en especifico
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Usuario selecionarusuario(string id)
        {
            UsuarioDatos datos = new UsuarioDatos();
            return datos.seleccionarUsuarioPorId(id);

        }

        /// <summary>
        /// elimina a un usuario en especifico
        /// </summary>
        /// <param name="id"></param>
        public void eliminarUsuario(string id)
        {
            UsuarioDatos datos = new UsuarioDatos();
            datos.eliminarUsuario(id);
        }

        /// <summary>
        /// actuailiza la contraseña de un usario
        /// </summary>
        /// <param name="usuario"></param>
        public void actualizarContrasena(Usuario usuario)
        { //TODO poner un estado de primera vez a los usuario
            UsuarioDatos datos = new UsuarioDatos();
            datos.actualizarContrasena(usuario);
        }

        /// <summary>
        /// crea una contraseña temporal al usuario
        /// </summary>
        /// <returns></returns>
        public string crearContrasenas()
        {
            int longitud = 5;

            string letras = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1023456789";

            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            while (0 < longitud--)
            {
                sb.Append(letras[random.Next(letras.Length)]);
            }


            return sb.ToString();
        }

        /// <summary>
        /// envia un correo electronico con la nueva contraseña al usuario
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string EnviarCorreo(Usuario user)
        {
          
            Configuracion config;
            try
            {
             config = new Configuracionlogica().seleccionarConfiguracion();
            }
            catch (Exception ex)
            {
                LogHelper.WriteDebugLog("error extrallendo configuracion base de datos "+ex);
                throw;
            }



            string Emisor = config.email;
            string contrasena = config.password;

            string asunto = "Nueva contraseña";
            string mensaje = "Sr(a) " + user.Nombre + " gracias por Usar la biblioteca Movil! su usuario es :" + user.Cedula + " y su contraseña temporal es : " + user.Password +
             " Gracias!";
            using (SmtpClient cliente = new SmtpClient("smtp.live.com", 25))
            {
                cliente.EnableSsl = true;
                cliente.Credentials = new NetworkCredential(Emisor, contrasena);
                MailMessage mensaje1 = new MailMessage(Emisor, user.CorreoElectronico, asunto, mensaje);


                try
                {
                    cliente.Send(mensaje1);

                }
                catch (Exception ex)
                {
                    LogHelper.WriteDebugLog("erro enviando email nueva contraseña "+ex.Message);
                    return ex.Message + "! porfavor vuelva a restablecer la contraseña hasta que el usuario sea notificado";

                }

                return "se le a enviado un email al usuario con su nueva contraseña exitosamente!";

            }
        }
        /// <summary>
        /// vaida que el nombre de usuario y contraseña sea el correcto
        /// </summary>
        /// <param name="id"></param>
        /// <param name="contra"></param>
        /// <returns></returns>

              public Usuario loginUsuario(string id, string contra)
        {
            UsuarioDatos datos = new UsuarioDatos();

                return datos.loginUsuario(id,contra);

        }

        }


  
    }

