using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.tramite;
using Capas.Datos;
using Capas.Entidades.usuario;
using Capas.Entidades.comprobante;

namespace Capas.Logica.comprobante
{
   public class ComprobanteLogica
    {


      public int guardarComprobante(List<ITipoTramite>listaTramites,bool estado ,Estudiante miEstudiante,Usuario miFuncionario)
        {
            EncabezadoDatos enc = new EncabezadoDatos();
            TramiteDatos tramite = new TramiteDatos();
 
            Estudiante estudiante = miEstudiante;
            Usuario funcionario = miFuncionario;

            int numeroEncabezado=enc.guardarEncabezado(estado,estudiante,funcionario);


            foreach (var item in listaTramites)
            {
             tramite.guardarTramite(item,numeroEncabezado);
            }

            return numeroEncabezado;
        }

      public List<EncabezadoComprobante> listaDeEncabezadosEspera()
        {
            EncabezadoDatos datos = new EncabezadoDatos();
            return datos.todosLosEncabezadosenEspera();

        }

        public List<DetalleComprobante> listaDetalles(int id)
        {
            DetalleDatos datos = new DetalleDatos();
            return datos.listaDetalles(id);
        }

        public void actualizarComprobante(EncabezadoComprobante comprobante)
        {
            EncabezadoDatos datos = new EncabezadoDatos();
            datos.actualizarEncabezado(comprobante);
        }
    }
}
