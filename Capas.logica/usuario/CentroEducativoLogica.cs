using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.usuario;
using Capas.Datos;

namespace Capas.Logica.usuario
{
   public class CentroEducativoLogica
    {

        public void guardarCentro(CentroEducativo centro)
        {
            CentroEducativoDatos datos = new CentroEducativoDatos();
            if (datos.seleccionarCentro(centro) == null)
            {
                datos.guardarCentro(centro);
            }
            else
            {
                datos.actualizarCentro(centro);
            }
        }

        public void eliminarCentro(CentroEducativo centro)
        {
            new CentroEducativoDatos().eliminarCentro(centro);
        }
        public List<CentroEducativo> seleccionarTodosCentros()
        {
            CentroEducativoDatos datos = new CentroEducativoDatos();
            return datos.seleccionarTodos();
        }

        /// <summary>
        /// retorna todos los centros mas un comodin
        /// </summary>
        /// <returns></returns>
        public List<CentroEducativo> seleccionarTodosCentrosConComodin()
        {
            CentroEducativo miCentro = new CentroEducativo();
            miCentro.Nombre = "Todos";
            miCentro.Codigo = -1;
            CentroEducativoDatos datos = new CentroEducativoDatos();
            List<CentroEducativo>lista= datos.seleccionarTodos();
            lista.Insert(0,miCentro);

            return lista;
        }

        public CentroEducativo seleccionarCentro(CentroEducativo centro)
        {
            CentroEducativoDatos datos = new CentroEducativoDatos();
            return datos.seleccionarCentro(centro);
        }


    }
}
