using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas.Entidades.libro
{
    public class Editorial
    { public int Codigo { set; get; }
      public String Nombre { set; get; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
