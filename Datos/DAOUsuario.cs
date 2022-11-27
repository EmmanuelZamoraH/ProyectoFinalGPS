using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using MySql.Data.MySqlClient;
using System.Data;


namespace Datos
{
    public class DAOUsuario
    {
        public bool validarUsuario(string user, string pass )
        {

            MySqlCommand consulta =
                new MySqlCommand(@"SELECT  * FROM usuarios WHERE usuario=@usuario AND 
                                   Password=@password");
            consulta.Parameters.AddWithValue("@usuario", user);
            consulta.Parameters.AddWithValue("@password", pass);
            DataTable resultado = Conexion.ejecutarConsulta(consulta);
            if (resultado != null && resultado.Rows.Count > 0) //Si coincide
            {
                
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
