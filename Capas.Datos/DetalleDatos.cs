using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.comprobante;
using Capas.Entidades.enums;
using Capas.Entidades.libro;

using System.Data.SqlClient;

namespace Capas.Datos
{
  public  class DetalleDatos
    {

        public List<DetalleComprobante> listaDetalles(int id)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);
            List<DetalleComprobante> miLista = new List<DetalleComprobante>();
            try
            {
                con.Open();
                string sql = "PA_verDetallesPorIdEnc";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id",id);

                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    DetalleComprobante det = new DetalleComprobante();
                    det.fechaDevolucion = (DateTime)lector["fechaEntrega"];
                    det.fechaPrestamo=(DateTime)lector["fechaPrestamo"];
                    Libro miLibro = new Libro();
                    miLibro.Codigo = lector["idLibro"].ToString();
                    det.Libro = new LibrosDatos().seleccionaLibro(miLibro);
                    det.tipo =(TipoTramite) Enum.Parse(typeof(TipoTramite),lector["idTipoTramite"].ToString());

                    miLista.Add(det);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }

            return miLista;
        }
    }
}
