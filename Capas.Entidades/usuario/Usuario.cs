using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.enums;

namespace Capas.Entidades.usuario
{
    public abstract class Usuario
    {
       public String Cedula { set; get; }
       public String Nombre { set; get; }
       public String primerApellido { set; get; }
       public String SegundoApellido { set; get; }
       
       public DateTime FechaNacimiento { set; get; }
       public Genero Genero { set; get; }
    
       public String Password { set; get; }

       public String NumeroTelefono { set; get; }
       
       public String CorreoElectronico { set; get; }

        public bool primerIngreso { set; get; }


    }
}
