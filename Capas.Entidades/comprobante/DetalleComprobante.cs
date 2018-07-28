using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.libro;
using Capas.Entidades.enums;

namespace Capas.Entidades.comprobante
{
   public class DetalleComprobante
    {
       public Libro Libro { set; get; }
       public TipoTramite tipo {set;get;}
       
       public DateTime fechaPrestamo { set; get; }

       public DateTime fechaDevolucion { set; get; }

    }
}
