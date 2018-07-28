using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.libro;
using Capas.Datos;

namespace Capas.Logica.libro
{
   public class AutorLogica
    {  
        /// <summary>
        /// Guarda un Autor en la base de datos si ya existe lo actualiza
        /// </summary>
        /// <param name="autor"></param>
        public void insertarAutor(Autor autor)
        {
            AutorDatos datos = new AutorDatos();
            if (datos.seleccionarAutorid(autor)==null)
            {
                datos.insertarAutor(autor);
            }
            else
            {
                datos.actualizarAutor(autor);
            }
         
        }
        /// <summary>
        /// devuelve una lista con todos los autores
        /// </summary>
        /// <returns></returns>
        public List<Autor> todosLosAutores()
        {
            AutorDatos datos = new AutorDatos();
            return datos.listaAutores();
        }

        /// <summary>
        /// todos los autores mas comodin
        /// </summary>
        /// <returns></returns>
        public List<Autor> todosLosAutoresComodin()
        {
            AutorDatos datos = new AutorDatos();
            List<Autor>miLista= datos.listaAutores();
            Autor miAutor = new Autor();
            miAutor.Codigo = -1;
            miAutor.Nombre = "Todos";

            miLista.Insert(0,miAutor);

            return miLista;
        }
        /// <summary>
        /// devuelve a un autor por medio del id
        /// </summary>
        /// <returns></returns>
        public Autor seleccionarAutor(Autor autor)
        {
            AutorDatos datos = new AutorDatos();
            return datos.seleccionarAutorid(autor);


        }

        /// <summary>
        /// elimina un autor de la base de datos
        /// </summary>
        public void eliminarAutor(Autor autor)
        {
            AutorDatos datos = new AutorDatos();
            datos.eliminarAutor(autor);

        }

        public List<Autor> listaAutoresNoSelecionados(Libro miLibro)
        {  

            List<Autor> listaTodos = todosLosAutores();

            foreach (var item in miLibro.listaAutores)
            {
                listaTodos.RemoveAll(a=>a.Codigo==item.Codigo);
            }

            return listaTodos;
        }
       
            
    }
}
