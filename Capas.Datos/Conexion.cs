using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas.Datos
{
    class Conexion
    {
      public static  String Cadena {
            get
            {

                string nombre = "sqlServer";
                return System.Configuration.ConfigurationManager.ConnectionStrings[nombre].ConnectionString;
            }
                
               }
    }
}
