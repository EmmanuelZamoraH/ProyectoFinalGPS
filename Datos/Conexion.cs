using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class Conexion
    {
        static MySqlConnection conexion;

        public static bool conectar()
        {
            string parametrosConexion = "server=127.0.0.1;database=centidiomas;" +
                "uid=root;pwd=zamora";
            try
            {
                conexion = new MySqlConnection(parametrosConexion);
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        public static void desconectar()
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
                conexion.Close();
        }

        public static DataTable ejecutarConsulta(MySqlCommand consulta)
        {
            if (conectar())
            {
                try
                {
                    consulta.Connection = conexion;
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta);
                    DataTable resultado = new DataTable();
                    adaptador.Fill(resultado);
                    return resultado;
                }
                catch (MySqlException ex)
                {
                    return null;
                }
                finally
                {
                    desconectar();
                }
            }
            else
            {
                return null;
            }
        }

        public static int ejecutarSentencia(MySqlCommand sentencia)
        {
            if (conectar())
            {
                try
                {
                    sentencia.Connection = conexion;
                    return sentencia.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    return 0;
                }
                finally
                {
                    desconectar();
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
