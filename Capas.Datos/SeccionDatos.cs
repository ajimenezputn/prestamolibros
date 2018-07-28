using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.usuario;
using System.Data.SqlClient;

namespace Capas.Datos
{
    public class SeccionDatos
    {
    
        public void guardar(Seccion sec)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();

                string sql = "PA_SeccionesInsert";

                SqlCommand comando = new SqlCommand(sql, con);

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("id", sec.Id);

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

        public Seccion selecionarSeccion(Seccion sec)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);
            Seccion seccion=null;
            try
            {
                con.Open();

                string sql = "PA_SeccionesSelect";

                SqlCommand comando = new SqlCommand(sql, con);

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", sec.Id);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    seccion = new Seccion();
                    seccion.Id = reader["id"].ToString();
                    return seccion;
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
            return seccion;
        }

        public Seccion selecionarSeccion(string id)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);
            Seccion seccion = null;
            try
            {
                con.Open();

                string sql = "PA_SeccionesSelect";

                SqlCommand comando = new SqlCommand(sql, con);

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id",id);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    seccion = new Seccion();
                    seccion.Id = reader["id"].ToString();
                    return seccion;
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
            return seccion;
        }
    }
}
