using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.usuario;

namespace Capas.Entidades.comprobante
{
   public class EncabezadoComprobante
    {
    
        public int id { set; get; }

        public Usuario Estudiante { set; get; }

        public Usuario Funcionario { set; get; }

        public DateTime fecha { set; get; }

        public bool enEspera { set; get; }

    }
}
