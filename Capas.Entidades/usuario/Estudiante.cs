using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.enums;

namespace Capas.Entidades.usuario
{
    public class Estudiante : Usuario,ICentro
    {
        public CentroEducativo CentroEducativo { set; get; }
        public Seccion Seccion { set; get; }
        public override string ToString()
        {
            return "Estudiante";
        }
    }
}
