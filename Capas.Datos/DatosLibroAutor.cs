using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.libro;
using System.Data.SqlClient;

namespace Capas.Datos
{
  public  class DatosLibroAutor
    {
        public void eliminarLibroAutor(Libro miLibro,Autor miAutor)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);
            try
            {
                con.Open();
                string sql = "PA_LibroAutorDelete";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idLibro", miLibro.Codigo);
                comando.Parameters.AddWithValue("@idAutor", miAutor.Codigo);
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
        public void insertarLibroAutor(Libro miLibro,Autor miAutor)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);
            try
            {
                con.Open();
                string sql = "PA_libroAutorInsert";
                SqlCommand comando = new SqlCommand(sql,con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idLibro",miLibro.Codigo);
                comando.Parameters.AddWithValue("@idAutor", miAutor.Codigo);

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
        /// elimina de la tabla libroAutor todos los registros
        /// relacionados a este libro
        /// </summary>
        /// <param name="miLibro"></param>
        public void eliminarLibroAutorPoridLibro(Libro miLibro)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);
            try
            {
                con.Open();
                string sql = "PA_LibroAutorDeletePorLibro";
                SqlCommand comando = new SqlCommand(sql,con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idLibro",miLibro.Codigo);
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
        /// devuelve todos los autores relacionados con un libro 
        /// en especifico
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Autor> todosLosAutoresPorLibro(string id)
        {
            List<Autor> miLista = new List<Autor>();

            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();

                string sql = "PA_LibroAutorSelectAutoresPorLibro";
                SqlCommand comando = new SqlCommand(sql,con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idLibro", id);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Autor miAutor = new Autor();
                    miAutor.Codigo = (int)reader["idAutor"];
                    miAutor=  new AutorDatos().seleccionarAutorid(miAutor);

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

    }
}
