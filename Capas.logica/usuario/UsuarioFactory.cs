using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.usuario;
using Capas.Entidades.enums;

namespace Capas.Logica.usuario
{
   public class UsuarioFactory
    { 

        /// <summary>
        /// Crea un Usuario segun el tipo,segun los parametros
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="primerApellido"></param>
        /// <param name="segundoApellido"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="genero"></param>
        /// <param name="password"></param>
        /// <param name="numeroTelefono"></param>
        /// <param name="email"></param>
        /// <param name="centro"></param>
        /// <param name="seccion"></param>
        /// <param name="tipo">enum con el tipo de usuario</param>
        /// <returns></returns>
       public Usuario crearUsuario(string cedula,string nombre,string primerApellido,string segundoApellido,
           DateTime fechaNacimiento,Genero genero,string numeroTelefono,string email,CentroEducativo centro,Seccion seccion,TipoUsuario tipo)
        {
           Usuario miUsuario=null;

            switch (tipo)
            {
                case TipoUsuario.Profesor:
                    miUsuario = new Profesor();
                    ((Profesor)miUsuario).CentroEducativo = centro;
                    break;
                case TipoUsuario.Estudiante:
                    miUsuario = new Estudiante();
                    ((Estudiante)miUsuario).CentroEducativo = centro;
                    ((Estudiante)miUsuario).Seccion = seccion;
                    break;
                case TipoUsuario.Administrador:
                    miUsuario = new Administrador();
                    break;
                default:
                    break;
            }
            miUsuario.Cedula = cedula;
            miUsuario.Nombre = nombre;
            miUsuario.primerApellido = primerApellido;
            miUsuario.SegundoApellido = segundoApellido;
            miUsuario.FechaNacimiento = fechaNacimiento;
            miUsuario.Genero = genero;
            miUsuario.Password = new UsuarioLogica().crearContrasenas();
            miUsuario.NumeroTelefono = numeroTelefono;
            miUsuario.CorreoElectronico = email;

            return miUsuario;
        }
    }
}
