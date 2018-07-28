using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.tramite;
using System.Data.SqlClient;
using Capas.Entidades.enums;
using Capas.Entidades.libro;
using Capas.Entidades.comprobante;

namespace Capas.Datos
{
    public class TramiteDatos
    {

        public int guardarTramite(ITipoTramite tramite,int encabezado)
        {
            int linea = -1;

            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();

                string sql = "PA_TramitesInsert";
                SqlCommand comando = new SqlCommand();
                comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEncabezado", encabezado);
                comando.Parameters.AddWithValue("@idLibro", tramite.Libro.Codigo);

                if (tramite.GetType().Equals(typeof(Prestamo)))
                {
                    comando.Parameters.AddWithValue("@idTipoTramite", (int)TipoTramite.Prestamo);
                }
                else
                {
                    comando.Parameters.AddWithValue("@idTipoTramite", (int)TipoTramite.Devolucion);
                }

                comando.Parameters.AddWithValue("@fechaPrestamo", tramite.FechaPrestamo);
                comando.Parameters.AddWithValue("@fechaEntrega", tramite.FechaDevolucion);
                linea =(int)comando.ExecuteScalar();
        }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return linea;
        }
        /// <summary>
        /// construye una devolucion y lo hace con los
        /// valores del prestamo para que haya concordancia con 
        /// la fecha de prestamo
        /// </summary>
        /// <param name="libro"></param>
        /// <returns></returns>
        public Devolucion devolucion(Libro libro)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);
            Devolucion devolucion = null;
            try
            {
                con.Open();
                string sql = "PA_tramitesSelect";

                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idLibro", libro.Codigo);

                SqlDataReader reader = comando.ExecuteReader();

                
                while (reader.Read())
                {
                    devolucion = new Devolucion();
                    devolucion.FechaPrestamo =Convert.ToDateTime( reader["fechaPrestamo"].ToString());
                    devolucion.Libro = libro;
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
            return devolucion;
        }

        /// <summary>
        /// cambia el estado a true
        /// </summary>
        /// <param name="id"></param>
        public void modificarEstadoNotificacion(string id)
        {
           

                  SqlConnection con = new SqlConnection(Conexion.Cadena);
            List<Comprobante> miLista = new List<Comprobante>();


            try
            {
                con.Open();

                string sql = "PA_estadoNotificacion";
                SqlCommand comando = new SqlCommand();
                comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", id);

                comando.ExecuteNonQuery();
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }


       /// <summary>
       /// obtiene los datos para notificar a los morosos
       /// </summary>
       /// <returns></returns>
        public List< Comprobante> notificarMorosos()
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);
            List<Comprobante> miLista = new List<Comprobante>();


            try
            {
                con.Open();

                string sql = "PA_Notificar";
                SqlCommand comando = new SqlCommand();
                comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    EncabezadoComprobante enca = new EncabezadoComprobante();
                    DetalleComprobante deta = new DetalleComprobante();
                    Comprobante compro = new Comprobante();



                    enca.Estudiante = new UsuarioDatos().seleccionarUsuarioPorId(lector["idEstudiante"].ToString());
                    Libro miLibro = new Libro();
                    miLibro.Codigo = lector["libro"].ToString();
                    deta.Libro = new LibrosDatos().seleccionaLibro(miLibro);
                    deta.fechaDevolucion = (DateTime)lector["fechaEntrega"];
                    compro.enc = enca;
                    compro.det = deta;

                    miLista.Add(compro);
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


    }
}
