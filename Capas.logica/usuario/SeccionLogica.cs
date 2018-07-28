using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.usuario;
using Capas.Datos;

namespace Capas.Logica.usuario
{
    public class SeccionLogica
    {

        public void guardar(Seccion sec)
        {
            SeccionDatos datos = new SeccionDatos();
            if (datos.selecionarSeccion(sec)==null)
            {
                datos.guardar(sec);
            }
            
        }
       
        /// <summary>
        /// Elimina la Relacion Entre un Centro y Una Seccion
        /// </summary>
        public void eliminarSecciondeUnCentro(CentroEducativo centro,Seccion sec)
        {
            new CentroSeccionDatos().eliminarCentroSeccion(centro,sec);
        }
    }
}
