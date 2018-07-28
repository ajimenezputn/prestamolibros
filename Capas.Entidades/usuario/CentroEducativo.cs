using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas.Entidades.usuario
{
    public class CentroEducativo
    { 
        public int Codigo { set; get; }
        public String Nombre { set; get; }

        public List<Seccion> listaSeciones { set; get; }

       public CentroEducativo()
        {
            listaSeciones = new List<Seccion>();
        }
    }
}
