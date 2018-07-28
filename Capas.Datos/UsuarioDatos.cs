using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capas.Entidades.usuario;
using Capas.Entidades.enums;

namespace Capas.Datos
{
    public class UsuarioDatos
    {
        /// <summary>
        /// inserta un susario en la base de datos 
        /// </summary>
        /// <param name="user"></param>
        public void insertarUsuario(Usuario user)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_UsuariosInsert";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", user.Cedula);
                comando.Parameters.AddWithValue("@nombre", user.Nombre);
                comando.Parameters.AddWithValue("@primerApellido", user.primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", user.SegundoApellido);
                comando.Parameters.AddWithValue("@fechaNacimiento", user.FechaNacimiento);
                comando.Parameters.AddWithValue("@telefono", user.NumeroTelefono);
                comando.Parameters.AddWithValue("@email", user.CorreoElectronico);
                comando.Parameters.AddWithValue("@password", user.Password);
                comando.Parameters.AddWithValue("@idGenero",(int) user.Genero);

                if (user.GetType().Equals(typeof(Estudiante)))
                {
                    comando.Parameters.AddWithValue("@idSeccion", ((Estudiante)user).Seccion.Id);
                    comando.Parameters.AddWithValue("@idCentro", ((Estudiante)user).CentroEducativo.Codigo);
                    comando.Parameters.AddWithValue("@idTipoUsuario","est");
                }
                else
                {
                    if (user.GetType().Equals(typeof(Profesor)))
                    {
                        comando.Parameters.AddWithValue("@idCentro", ((Profesor)user).CentroEducativo.Codigo);
                        comando.Parameters.AddWithValue("@idTipoUsuario", "pro");
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@idTipoUsuario", "adm");
                    }
                }

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }


        }
        /// <summary>
        /// actualiza la contraseña de un usuario
        /// </summary>
        /// <param name="user"></param>
        public void actualizarContrasena(Usuario user)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_UsuariosUpdatePassword";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id",user.Cedula);
                comando.Parameters.AddWithValue("@password",user.Password);
                comando.Parameters.AddWithValue("@primerIngreso",user.primerIngreso);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
               

                throw;
            }
            finally
            {
                con.Close();
            }

        }

        /// <summary>
        /// actualiza un registro en la base de datos
        /// </summary>
        /// <param name="user"></param>
        public void actualizarUsuario(Usuario user)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_UsuariosUpdate";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", user.Cedula);
                comando.Parameters.AddWithValue("@nombre", user.Nombre);
                comando.Parameters.AddWithValue("@primerApellido", user.primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", user.SegundoApellido);
                comando.Parameters.AddWithValue("@fechaNacimiento", user.FechaNacimiento);
                comando.Parameters.AddWithValue("@telefono", user.NumeroTelefono);
                comando.Parameters.AddWithValue("@email", user.CorreoElectronico);
                comando.Parameters.AddWithValue("@idGenero", (int)user.Genero);

                if (user.GetType().Equals(typeof(Estudiante)))
                {
                    comando.Parameters.AddWithValue("@idSeccion", ((Estudiante)user).Seccion.Id);
                    comando.Parameters.AddWithValue("@idCentro", ((Estudiante)user).CentroEducativo.Codigo);
                    comando.Parameters.AddWithValue("@idTipoUsuario", "est");
                }
                else
                {
                    if (user.GetType().Equals(typeof(Profesor)))
                    {
                        comando.Parameters.AddWithValue("@idCentro", ((Profesor)user).CentroEducativo.Codigo);
                        comando.Parameters.AddWithValue("@idTipoUsuario", "pro");
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@idTipoUsuario", "adm");
                    }
                }

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }



        }
        /// <summary>
        /// muestra los estudiantes que cumplen con el filtro
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="primerApellido"></param>
        /// <param name="segundoApellido"></param>
        /// <param name="centro"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        public List<Usuario> listaEstudiantesConFiltro(string id,string nombre,string primerApellido,
            string segundoApellido,int centro,string seccion)
        {
            List<Usuario> miLista = new List<Usuario>();

            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_consultarEstudiantesconFitro";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id",id);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@primerApellido", primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", segundoApellido);
                comando.Parameters.AddWithValue("@centroEducativo", centro);
                comando.Parameters.AddWithValue("@seccion", seccion);



                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Usuario miUsuario;

                    miUsuario = new Estudiante();
                    ((Estudiante)miUsuario).CentroEducativo = new CentroEducativoDatos().seleccionarCentro((int)reader["idCentro"]);
                    ((Estudiante)miUsuario).Seccion = new SeccionDatos().selecionarSeccion(reader["idSeccion"].ToString());

                    miUsuario.Cedula = reader["id"].ToString();
                    miUsuario.Nombre = reader["Nombre"].ToString();
                    miUsuario.primerApellido = reader["primerApellido"].ToString();
                    miUsuario.SegundoApellido = reader["segundoApellido"].ToString();
                    miUsuario.NumeroTelefono = reader["telefono"].ToString();
                    miUsuario.CorreoElectronico = reader["email"].ToString();

                    Genero miGenero;
                    Enum.TryParse(reader["idGenero"].ToString(), out miGenero);
                    miUsuario.Genero = miGenero;
                    DateTime fecha = Convert.ToDateTime(reader["fechaNacimiento"].ToString());
                    miUsuario.FechaNacimiento = fecha;

                    miLista.Add(miUsuario);
                }
                }
                  catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }

            return miLista;



        }



        /// <summary>
        /// devuelve todos los usurios en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Usuario> listaUsuarios()
        {
            List<Usuario> miLista = new List<Usuario>();

            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_UsuariosSelectAll";
                SqlCommand comando = new SqlCommand(sql,con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Usuario miUsuario;
                    if (reader["idTipoUsuario"].Equals("est"))
                    {
                        miUsuario = new Estudiante();
                        ((Estudiante)miUsuario).CentroEducativo = new CentroEducativoDatos().seleccionarCentro((int)reader["idCentro"]);
                        ((Estudiante)miUsuario).Seccion = new SeccionDatos().selecionarSeccion(reader["idSeccion"].ToString());

                    }
                    else
                    {
                        if (reader["idTipoUsuario"].Equals("pro"))
                        {
                            miUsuario = new Profesor();
                            ((Profesor)miUsuario).CentroEducativo = new CentroEducativoDatos().seleccionarCentro((int)reader["idCentro"]);

                        }
                        else
                        {
                            miUsuario = new Administrador();
                        }

                    }

                    miUsuario.Cedula= reader["id"].ToString();
                    miUsuario.Nombre = reader["Nombre"].ToString();
                    miUsuario.primerApellido= reader["primerApellido"].ToString();
                    miUsuario.SegundoApellido= reader["segundoApellido"].ToString();
                    miUsuario.NumeroTelefono= reader["telefono"].ToString();
                    miUsuario.CorreoElectronico= reader["email"].ToString();
                   
                    Genero miGenero;
                    Enum.TryParse(reader["idGenero"].ToString(), out miGenero);
                    miUsuario.Genero = miGenero;
                    DateTime fecha = Convert.ToDateTime(reader["fechaNacimiento"].ToString());
                    miUsuario.FechaNacimiento = fecha;

                    miLista.Add(miUsuario);

                }

        }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }

            return miLista;
        }
        /// <summary>
        /// retorna a un usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Usuario seleccionarUsuarioPorId(string id)
        {
            Usuario miUsuario=null;

            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_UsuariosSelect";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id",id);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                   
                    if (reader["idTipoUsuario"].Equals("est"))
                    {
                        miUsuario = new Estudiante();
                        ((Estudiante)miUsuario).CentroEducativo = new CentroEducativoDatos().seleccionarCentro((int)reader["idCentro"]);
                        ((Estudiante)miUsuario).Seccion = new SeccionDatos().selecionarSeccion(reader["idSeccion"].ToString());

                    }
                    else
                    {
                        if (reader["idTipoUsuario"].Equals("pro"))
                        {
                            miUsuario = new Profesor();
                            ((Profesor)miUsuario).CentroEducativo = new CentroEducativoDatos().seleccionarCentro((int)reader["idCentro"]);

                        }
                        else
                        {
                            miUsuario = new Administrador();
                        }

                    }

                    miUsuario.Cedula = reader["id"].ToString();
                    miUsuario.Nombre = reader["Nombre"].ToString();
                    miUsuario.primerApellido = reader["primerApellido"].ToString();
                    miUsuario.SegundoApellido = reader["segundoApellido"].ToString();
                    miUsuario.NumeroTelefono = reader["telefono"].ToString();
                    miUsuario.CorreoElectronico = reader["email"].ToString();

                    Genero miGenero;
                    Enum.TryParse(reader["idGenero"].ToString(), out miGenero);
                    miUsuario.Genero = miGenero;
                    DateTime fecha = Convert.ToDateTime(reader["fechaNacimiento"].ToString());
                    miUsuario.FechaNacimiento = fecha;
                    miUsuario.primerIngreso =(bool)reader["primerIngreso"];

                    return miUsuario;

                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }

            return miUsuario;
        }
        /// <summary>
        /// elimina a un usuario de la base de datos
        /// </summary>
        /// <param name="id"></param>
        public void eliminarUsuario(string id)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_UsuariosDelete";
                SqlCommand comando = new SqlCommand(sql,con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id",id);

                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                con.Close();
            }



        }

        /// <summary>
        /// verifica que existe el usuario en el sistema
        /// </summary>
        /// <param name="id"></param>
        /// <param name="contra"></param>
        /// <returns></returns>
        public Usuario loginUsuario(string id,string contra)
        {
            Usuario miUsuario = null;

            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_UsuarioLogin";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@contra", contra);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    if (reader["idTipoUsuario"].Equals("est"))
                    {
                        miUsuario = new Estudiante();
                        ((Estudiante)miUsuario).CentroEducativo = new CentroEducativoDatos().seleccionarCentro((int)reader["idCentro"]);
                        ((Estudiante)miUsuario).Seccion = new SeccionDatos().selecionarSeccion(reader["idSeccion"].ToString());

                    }
                    else
                    {
                        if (reader["idTipoUsuario"].Equals("pro"))
                        {
                            miUsuario = new Profesor();
                            ((Profesor)miUsuario).CentroEducativo = new CentroEducativoDatos().seleccionarCentro((int)reader["idCentro"]);

                        }
                        else
                        {
                            miUsuario = new Administrador();
                        }

                    }

                    miUsuario.Cedula = reader["id"].ToString();
                    miUsuario.Nombre = reader["Nombre"].ToString();
                    miUsuario.primerApellido = reader["primerApellido"].ToString();
                    miUsuario.SegundoApellido = reader["segundoApellido"].ToString();
                    miUsuario.NumeroTelefono = reader["telefono"].ToString();
                    miUsuario.CorreoElectronico = reader["email"].ToString();

                    Genero miGenero;
                    Enum.TryParse(reader["idGenero"].ToString(), out miGenero);
                    miUsuario.Genero = miGenero;
                    DateTime fecha = Convert.ToDateTime(reader["fechaNacimiento"].ToString());
                    miUsuario.FechaNacimiento = fecha;
                    miUsuario.primerIngreso = (bool)reader["primerIngreso"];

                    return miUsuario;

                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }

            return miUsuario;
        }


    }
}
