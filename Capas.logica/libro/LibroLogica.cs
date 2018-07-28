using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.libro;
using Capas.Datos;

namespace Capas.Logica.libro
{
   public class LibroLogica
    {

        /// <summary>
        /// guarda un libro en la base de datos
        /// y si ya existe lo actualiza
        /// </summary>
        /// <param name="miLibro"></param>
        public void guardar(Libro miLibro)
        { LibrosDatos datos = new LibrosDatos();
            if (datos.seleccionaLibro(miLibro)==null)
            {
                datos.guardarLibro(miLibro);
            }
            else
            {
                datos.actualizarLibro(miLibro);
            }


        }
        /// <summary>
        /// guarda la relacion entre un libro y un autor
        /// </summary>
        /// <param name="miLibro"></param>
        /// <param name="miAutor"></param>
        public void guardarLibroAutor(Libro miLibro,Autor miAutor)
        {
            DatosLibroAutor datos = new DatosLibroAutor();
            datos.insertarLibroAutor(miLibro,miAutor);

        }
        /// <summary>
        /// elimina la relacion entre un libro y un autor
        /// </summary>
        /// <param name="miLibro"></param>
        /// <param name="miAutor"></param>
        public void eliminarLibroAutor(Libro miLibro,Autor miAutor)
        {
            DatosLibroAutor datos = new DatosLibroAutor();
            datos.eliminarLibroAutor(miLibro,miAutor);

        }

        /// <summary>
        /// muestra todos los libros en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Libro> todosLosLibros()
        {
            return new LibrosDatos().seleccionarTodosLibros();
        }

        /// <summary>
        /// selecciona un libro en la base de datos
        /// </summary>
        /// <param name="miLibro"></param>
        /// <returns></returns>
        public Libro seleccionarLibro(Libro miLibro)
        {
            return new LibrosDatos().seleccionaLibro(miLibro);
        }
        /// <summary>
        /// elimina un libro de la base de datos
        /// </summary>
        /// <param name="miLibro"></param>

        public void eliminarLibro(Libro miLibro)
        {
            new LibrosDatos().eliminarLibro(miLibro);
        }

       /// <summary>
       /// muestra todos los autores por 
       /// id de libro
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        public List<Autor> todosLosAutoresPorLibro(string id)
        {
            return new DatosLibroAutor().todosLosAutoresPorLibro(id);
        }

        /// <summary>
        /// retorna todos los libros que cumplen con el filtro
        /// </summary>
        /// <param name="id"></param>
        /// <param name="titulo"></param>
        /// <param name="edi"></param>
        /// <param name="autor"></param>
        /// <returns></returns>
        public List<Libro> seleccionarTodosLibrosFiltro(string id, string titulo, int edi, int autor)
        {
            LibrosDatos datos = new LibrosDatos();
            return  datos.seleccionarTodosLibrosFiltro(id,titulo,edi,autor);
        }


    }
}
