using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades;
using System.Data.SqlClient;

namespace Capas.Datos
{
  public  class ConfiguracionDatos
    {

        public void insertarConfiguracion(Configuracion config)
        {

            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_guardarConfiguracion";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", 1);
                comando.Parameters.AddWithValue("@cantidadLibros", config.cantidadLibros);
                comando.Parameters.AddWithValue("@email", config.email);
                comando.Parameters.AddWithValue("@password", config.password);

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




        public void actualizarConfiguracion(Configuracion config)
        {

            SqlConnection con = new SqlConnection(Conexion.Cadena);

            try
            {
                con.Open();
                string sql = "PA_ActualizarConfiguracion";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id",1);


                comando.Parameters.AddWithValue("@cantidadLibros", config.cantidadLibros);
                comando.Parameters.AddWithValue("@email", config.email);
                comando.Parameters.AddWithValue("@password", config.password);

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


        public Configuracion seleccionarConfiguracion()
        {
           Configuracion config = null;
            SqlConnection con = new SqlConnection(Conexion.Cadena);
            try
            {
                con.Open();
                string sql = "PA_seleccionarConfiguracion";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", 1);


                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    config= new Configuracion();
                    config.cantidadLibros = (int)reader["cantidadLibros"];
                    config.email = reader["email"].ToString();
                    config.password = reader["password"].ToString();

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

            return config;
        }



    }
}
