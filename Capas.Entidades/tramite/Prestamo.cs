using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.libro;
using Capas.Entidades.usuario;

namespace Capas.Entidades.tramite
{
  public  class Prestamo : ITipoTramite
    {


          
           public DateTime FechaDevolucion { set; get; }

            public DateTime FechaPrestamo { set; get; }

            public Libro Libro { set; get; }

          int ITipoTramite.NumeroLinea { set; get; }

        public Prestamo()
        {
            FechaPrestamo = DateTime.Now;
        }

        }
}
