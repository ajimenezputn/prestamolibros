using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.usuario;
using System.Data.SqlClient;

namespace Capas.Datos
{
    public class CentroEducativoDatos
    {

        public void guardarCentro(CentroEducativo centro)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_CentroEducativoInsert";

                SqlCommand comando = new SqlCommand(sql,con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
              
                comando.Parameters.AddWithValue("@nombre", centro.Nombre);

                foreach (var item in centro.listaSeciones)
                {
                    new CentroSeccionDatos().guardarCentroSeccion(centro,item);
                }

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

        public void actualizarCentro(CentroEducativo centro)
        {
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_CentroEducativoUpdate";

                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", centro.Codigo);
                comando.Parameters.AddWithValue("@nombre", centro.Nombre);
                comando.ExecuteNonQuery();
                foreach (var item in centro.listaSeciones)
                {
                    new CentroSeccionDatos().guardarCentroSeccion(centro, item);
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

        }

        public List<CentroEducativo> seleccionarTodos()
        {
            List<CentroEducativo> listaCentros = new List<CentroEducativo>();
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_centroEducativoselectAll";
                SqlCommand comando = new SqlCommand(sql,con);

                comando.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    CentroEducativo micentro = new CentroEducativo();
                    micentro.Codigo =(int)reader["id"];
                    micentro.Nombre = reader["nombre"].ToString();
                    micentro.listaSeciones = new CentroSeccionDatos().seleccionarPorCentro(micentro);
                    //agregarlista Secciones
                    listaCentros.Add(micentro);
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

            return listaCentros;
        }

        public CentroEducativo seleccionarCentro(CentroEducativo centro)
        {
            CentroEducativo micentro = null;
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_centroEducativoselect";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.Parameters.AddWithValue("@id", centro.Codigo);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    micentro = new CentroEducativo();
                    micentro.Codigo = (int)reader["id"];
                    micentro.Nombre = reader["nombre"].ToString();
                    micentro.listaSeciones = new CentroSeccionDatos().seleccionarPorCentro(micentro);
                    //agregarlista Secciones
                    return micentro;
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

            return micentro;

        }

        public CentroEducativo seleccionarCentro(int id)
        {
            CentroEducativo micentro = null;
            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_centroEducativoselect";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.Parameters.AddWithValue("@id", id);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    micentro = new CentroEducativo();
                    micentro.Codigo = (int)reader["id"];
                    micentro.Nombre = reader["nombre"].ToString();
                    micentro.listaSeciones = new CentroSeccionDatos().seleccionarPorCentro(micentro);
                    //agregarlista Secciones
                    return micentro;
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

            return micentro;

        }

        public void eliminarCentro(CentroEducativo centro)
        {

            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {

                new CentroSeccionDatos().eliminarUnCentroYTodasLasSecciones(centro);
                con.Open();

                string sql = "PA_CentroEducativoDelete";

                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", centro.Codigo);

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
    }
}
