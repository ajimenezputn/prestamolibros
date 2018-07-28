using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.tramite;
using Capas.Entidades.enums;
using Capas.Entidades.usuario;
using Capas.Entidades.libro;
using Capas.Datos;

namespace Capas.Logica.tramites
{
   public class FactoryTramite
    {

        public ITipoTramite crearTramite(TipoTramite tipoTramite, Libro libro,DateTime fecha)
        {
            ITipoTramite miTramite;

            if (tipoTramite.Equals(TipoTramite.Prestamo)) {
                miTramite = new Prestamo();
                miTramite.FechaDevolucion = fecha;
                miTramite.Libro = libro;
            }
            else
            {
                TramiteDatos datos = new TramiteDatos();
                miTramite = datos.devolucion(libro);
               
            
            }
      

      

            return miTramite;
        }


    }
}
