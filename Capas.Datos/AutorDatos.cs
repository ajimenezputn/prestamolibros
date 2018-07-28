using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.libro;
using System.Data.SqlClient;

namespace Capas.Datos
{
   public class AutorDatos
    {
        public void insertarAutor(Autor autor)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_AutorInsert";
                SqlCommand comando = new SqlCommand(sql,con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

      
                comando.Parameters.AddWithValue("@nombre",autor.Nombre);

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

        public void actualizarAutor(Autor autor)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_AutorUpdate";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", autor.Codigo);
                comando.Parameters.AddWithValue("@nombre", autor.Nombre);

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

        public Autor seleccionarAutorid(Autor autor)
        {
            Autor miAutor = null;
            SqlConnection con = new SqlConnection(Conexion.Cadena);
            try
            {
                con.Open();
                string sql = "PA_Autorselect";
                SqlCommand comando = new SqlCommand(sql,con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id",autor.Codigo);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    miAutor = new Autor();
                    miAutor.Codigo =(int) reader["id"];
                    miAutor.Nombre = reader["nombre"].ToString();


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

            return miAutor;
        }
        public List<Autor> listaAutores()
        {
            List<Autor> miLista = new List<Autor>();

            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_AutorSelectAll";
                SqlCommand comando = new SqlCommand(sql,con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Autor miAutor = new Autor();
                    miAutor.Codigo = (int)reader["id"];
                    miAutor.Nombre = reader["nombre"].ToString();

                    miLista.Add(miAutor);
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
        public void eliminarAutor(Autor autor)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);
            try
            {
                con.Open();
                string sql = "PA_AutorDelete";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id",autor.Codigo);

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
