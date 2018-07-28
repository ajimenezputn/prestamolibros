using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.libro;
using Capas.Datos;

namespace Capas.Logica.libro
{
   public class EditorialLogica
    {

    /// <summary>
    /// inserta una editorial en la base de datos
    /// </summary>
    /// <param name="editorial"></param>
        public void insertarEditorial(Editorial editorial)
        {
            EditorialDatos datos = new EditorialDatos();
            if (datos.seleccionarEditorial(editorial) == null)
            {
                datos.insertarEditorial(editorial);
            }
            else
            {
                datos.actualizarEditorial(editorial);
            }

        }
        /// <summary>
        /// devuelve una lista con todas las editoriales
        /// </summary>
        /// <returns></returns>
        public List<Editorial> todosLasEditoriales()
        {
            EditorialDatos datos = new EditorialDatos();
            return datos.listaEditorial();
        }


        /// <summary>
        /// retorna todas las editoriales mas comodin
        /// </summary>
        /// <returns></returns>
        public List<Editorial> todosLasEditorialesFiltro()
        {
            EditorialDatos datos = new EditorialDatos();
           List<Editorial> miLista= datos.listaEditorial();
            Editorial miEditorial = new Editorial();

            miEditorial.Codigo = -1;
            miEditorial.Nombre = "Todas";

            miLista.Insert(0,miEditorial);


            return miLista;

        }
        /// <summary>
        /// devuelve a una editorial en especifico
        /// </summary>
        /// <returns></returns>
        public Editorial seleccionarEditorial(Editorial editorial)
        {
            EditorialDatos datos = new EditorialDatos();
            return datos.seleccionarEditorial(editorial);


        }

        /// <summary>
        /// elimina una editorial de la base de datos
        /// </summary>
        public void eliminarEditorial(Editorial editorial)
        {
            EditorialDatos datos = new EditorialDatos();
            datos.eliminarEditorial(editorial);

        }
    }
}
