using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.usuario;
using System.Data.SqlClient;

namespace Capas.Datos
{
  public  class CentroSeccionDatos
    {   

         public void guardarCentroSeccion(CentroEducativo centro,Seccion sec)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                if (centroSeccionSelect(centro, sec))
                {
                    return;
                }
                con.Open();
                string sql = "PA_CentroSeccionInsert";

                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idCentro",centro.Codigo);
                comando.Parameters.AddWithValue("@idSeccion", sec.Id);

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
         public List<Seccion> seleccionarPorCentro(CentroEducativo centro)
        {
            List<Seccion> lista = new List<Seccion>();
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_CentroSeccionSelectidCentro";
                SqlCommand comando = new SqlCommand(sql,con);

                comando.Parameters.AddWithValue("@idCentro",centro.Codigo);

                comando.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Seccion sec = new Seccion();
                    sec.Id = reader["idSeccion"].ToString();

                    lista.Add(sec);
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

            return lista;

        }
         
         public bool centroSeccionSelect(CentroEducativo centro ,Seccion sec)
        {
          
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_CentroSeccionSelect";
                SqlCommand comando = new SqlCommand(sql, con);

                comando.Parameters.AddWithValue("@idCentro", centro.Codigo);
                comando.Parameters.AddWithValue("@idSeccion", sec.Id);

                comando.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                  return true;
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

            return false;
        }
        /// <summary>
        /// Elimina la relacion entre un centro y una seccion
        /// </summary>
        /// <param name="centro"></param>
        /// <param name="sec"></param>
        public void eliminarCentroSeccion(CentroEducativo centro,Seccion sec)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
              
                con.Open();
                string sql = "PA_CentroSeccionDelete";

                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idCentro", centro.Codigo);
                comando.Parameters.AddWithValue("@idSeccion", sec.Id);

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
        /// Elimina un centro educativo y todas las secciones ligadas a este
        /// </summary>
        /// <param name="centro">se envia el centro educativo a eliminar</param>
        public void eliminarUnCentroYTodasLasSecciones(CentroEducativo centro)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {

                con.Open();
                string sql = "PA_CentroSeccionDeleteidCentro";

                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idCentro", centro.Codigo);

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

    }
}
