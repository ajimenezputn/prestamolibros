using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capas.Entidades.libro;

namespace Capas.Datos
{
   public  class EditorialDatos
    {
        public void insertarEditorial(Editorial editorial)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_editorialInsert";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;


                comando.Parameters.AddWithValue("@nombre", editorial.Nombre);

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

        public void actualizarEditorial(Editorial editorial)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_editorialUpdate";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", editorial.Codigo);
                comando.Parameters.AddWithValue("@nombre", editorial.Nombre);

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

        public Editorial seleccionarEditorial(Editorial editorial)
        {
            Editorial miEdi = null;
            SqlConnection con = new SqlConnection(Conexion.Cadena);
            try
            {
                con.Open();
                string sql = "PA_editorialselect";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", editorial.Codigo);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    miEdi = new Editorial();
                    miEdi.Codigo = (int)reader["id"];
                    miEdi.Nombre = reader["nombre"].ToString();


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

            return miEdi;
        }
        public List<Editorial> listaEditorial()
        {
            List<Editorial> miLista = new List<Editorial>();

            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_EditorialSelectAll";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                   Editorial miEdi = new Editorial();
                    miEdi.Codigo = (int)reader["id"];
                   miEdi.Nombre = reader["nombre"].ToString();

                    miLista.Add(miEdi);
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
        /// /elimina a un autor de la base de datos
        /// </summary>
        public void eliminarEditorial(Editorial editorial)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);
            try
            {
                con.Open();
                string sql = "PA_EditorialDelete";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", editorial.Codigo);

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
