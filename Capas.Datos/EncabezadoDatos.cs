using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades;
using System.Data.SqlClient;
using Capas.Entidades.usuario;
using Capas.Entidades.comprobante;
using System.Data.SqlClient;

namespace Capas.Datos
{
   public class EncabezadoDatos
    {

        public int guardarEncabezado(bool estado,Estudiante estudiante,Usuario funcionario)
        {
            int encabezado = -1;

            SqlConnection con = new SqlConnection(Conexion.Cadena);
            try
            {
                con.Open();
                string sql = "PA_EncComprobanteInsert";

                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idEstudiante", estudiante.Cedula);
                comando.Parameters.AddWithValue("@idFuncionario",funcionario.Cedula);
                comando.Parameters.AddWithValue("@fecha", DateTime.Now);
                comando.Parameters.AddWithValue("@enEspera", estado);

                encabezado = (int)comando.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return encabezado;

        }

        public void actualizarEncabezado(EncabezadoComprobante comprobante)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_actualizarEstado";
                SqlCommand comando = new SqlCommand(sql,con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id",comprobante.id);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                con.Close();
            }


        }

        public List<EncabezadoComprobante> todosLosEncabezadosenEspera()
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);
            List<EncabezadoComprobante> miLista = new List<EncabezadoComprobante>();
            try
            {
                con.Open();
                string sql = "PA_encabezadosEnEspera";
                SqlCommand comando = new SqlCommand(sql,con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    EncabezadoComprobante enc = new EncabezadoComprobante();
                    enc.id = (int)lector["id"];
                    enc.fecha =(DateTime)lector["fecha"];
                    enc.Estudiante = new UsuarioDatos().seleccionarUsuarioPorId(lector["idEstudiante"].ToString());
                    enc.Funcionario = new UsuarioDatos().seleccionarUsuarioPorId(lector["idFuncionario"].ToString());
                    enc.enEspera = (bool)lector["enEspera"];

                    miLista.Add(enc);
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
