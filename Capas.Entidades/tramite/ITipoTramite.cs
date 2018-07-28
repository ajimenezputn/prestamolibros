using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.usuario;
using Capas.Entidades.libro;

namespace Capas.Entidades.tramite
{
   public interface ITipoTramite
    {  
     
      int NumeroLinea { set; get; }
      Libro Libro { set; get; } 
      DateTime FechaPrestamo { get; }
      DateTime FechaDevolucion { get; set; }

    }
}
