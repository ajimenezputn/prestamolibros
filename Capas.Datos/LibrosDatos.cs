using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.libro;
using System.Data.SqlClient;

namespace Capas.Datos
{
   public class LibrosDatos
    {


        /// <summary>
        /// guarda un libro en la base de datos
        /// </summary>
        /// <param name="miLibro"></param>
        public void guardarLibro(Libro miLibro)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_libroInsert";
                SqlCommand comando = new SqlCommand(sql, con);

                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", miLibro.Codigo);
                comando.Parameters.AddWithValue("@titulo", miLibro.Titulo);
                comando.Parameters.AddWithValue("@idEditorial", miLibro.Editorial.Codigo);
                comando.Parameters.AddWithValue("@annoPublicacion", miLibro.fechaPublicacion);
                comando.ExecuteNonQuery();
                foreach (var item in miLibro.listaAutores)
                {
                    new DatosLibroAutor().insertarLibroAutor(miLibro, item);
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

        }

        /// <summary>
        /// actualiza un libro en la base de datos
        /// </summary>
        /// <param name="miLibro"></param>
        public void actualizarLibro(Libro miLibro)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_libroUpdate";
                SqlCommand comando = new SqlCommand(sql, con);

                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", miLibro.Codigo);
                comando.Parameters.AddWithValue("@titulo", miLibro.Titulo);
                comando.Parameters.AddWithValue("@idEditorial", miLibro.Editorial.Codigo);
                comando.Parameters.AddWithValue("@annoPublicacion", miLibro.fechaPublicacion);

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
        /// selecciona un libro de la base de datos
        /// </summary>
        /// <param name="miLibro"></param>
        /// <returns></returns>
        public Libro seleccionaLibro(Libro miLibro)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);
            Libro libro = null;
            try
            {
                con.Open();
                string sql = "PA_libroSelect";

                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", miLibro.Codigo);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    libro = new Libro();
                    libro.Codigo =reader["id"].ToString();
                    libro.Titulo = reader["Titulo"].ToString();
                    libro.fechaPublicacion =(int)reader["annoPublicacion"];

                    libro.enPrestamo =(bool)  reader["enPrestamo"];
                 
                    Editorial editorial = new Editorial();
                    editorial.Codigo = (int)reader["idEditorial"];

                    libro.Editorial = new EditorialDatos().seleccionarEditorial(editorial);

                    libro.listaAutores = new DatosLibroAutor().todosLosAutoresPorLibro(libro.Codigo.ToString());


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
            return libro;
        }
        /// <summary>
        /// seleciona un libro por medio de la id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Libro seleccionaLibro(long id)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);
            Libro libro = null;
            try
            {
                con.Open();
                string sql = "PA_libroSelect";

                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    libro = new Libro();
                    libro.Codigo = reader["id"].ToString();
                    libro.Titulo = reader["Titulo"].ToString();
                    libro.fechaPublicacion = (int)reader["annoPublicacion"];

                    libro.enPrestamo = (bool)reader["enPrestamo"];

                    Editorial editorial = new Editorial();
                    editorial.Codigo = (int)reader["idEditorial"];

                    libro.Editorial = new EditorialDatos().seleccionarEditorial(editorial);

                    libro.listaAutores = new DatosLibroAutor().todosLosAutoresPorLibro(libro.Codigo);


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
            return libro;
        }
        /// <summary>
        /// selecciona todos los libros de la base de dtos y retona una lista
        /// </summary>
        /// <returns></returns>
        public List<Libro> seleccionarTodosLibros()
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);
            List<Libro> miLista = new List<Libro>();
            try
            {
                con.Open();
                string sql = "PA_libroSelectAll";

                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;


                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Libro libro = new Libro();

                    libro.Codigo =reader["id"].ToString();
                    libro.Titulo = reader["Titulo"].ToString();
                    libro.fechaPublicacion = (int)reader["annoPublicacion"];

                    Editorial editorial = new Editorial();
                    editorial.Codigo = (int)reader["idEditorial"];

                    libro.Editorial = new EditorialDatos().seleccionarEditorial(editorial);

                    libro.listaAutores = new DatosLibroAutor().todosLosAutoresPorLibro(libro.Codigo);

                    miLista.Add(libro);
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
        /// retorna todos los libros que cumplen con el filtro
        /// </summary>
        /// <returns></returns>
        public List<Libro> seleccionarTodosLibrosFiltro(string id,string titulo,int edi,int autor)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);
            List<Libro> miLista = new List<Libro>();
            try
            {
                con.Open();
                string sql = "PA_BuscarLibroConFiltro";

                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id",id);
                comando.Parameters.AddWithValue("@titulo",titulo);
                comando.Parameters.AddWithValue("@idEditorial", edi);
                comando.Parameters.AddWithValue("@idAutor", autor);


                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Libro libro = new Libro();

                    libro.Codigo = reader["id"].ToString();
                    libro.Titulo = reader["Titulo"].ToString();
                    libro.fechaPublicacion = (int)reader["annoPublicacion"];

                    Editorial editorial = new Editorial();
                    editorial.Codigo = (int)reader["idEditorial"];

                    libro.Editorial = new EditorialDatos().seleccionarEditorial(editorial);

                    libro.listaAutores = new DatosLibroAutor().todosLosAutoresPorLibro(libro.Codigo);

                    miLista.Add(libro);
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
        /// elimina un libro de la base de datos
        /// </summary>
        /// <param name="libro"></param>
        public void eliminarLibro(Libro libro)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_libroDelete";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", libro.Codigo);
                new DatosLibroAutor().eliminarLibroAutorPoridLibro(libro);

                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
