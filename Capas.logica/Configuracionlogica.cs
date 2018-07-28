using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades;
using Capas.Datos;

namespace Capas.Logica
{
   public class Configuracionlogica
    {

        public void guardarConfiguracion(Configuracion con)
        {
            ConfiguracionDatos datos = new ConfiguracionDatos();

            if (seleccionarConfiguracion()==null)
            {
                datos.insertarConfiguracion(con);
            }
            else
            {
                datos.actualizarConfiguracion(con);
            }


            
          
        }

        public Configuracion seleccionarConfiguracion()
        {
            ConfiguracionDatos datos = new ConfiguracionDatos();
            return  datos.seleccionarConfiguracion();

        }


    }
}
