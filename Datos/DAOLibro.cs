using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelos;


namespace Datos
{
    public class DAOLibro
    {
        public DataTable obtenerTodas()
        {
            MySqlCommand consulta =
                new MySqlCommand(@"SELECT * from Libro");
            return Conexion.ejecutarConsulta(consulta);

        }

        public bool insertar(Libro obj)
        {
            MySqlCommand insert = new MySqlCommand(
                @"INSERT INTO libro  VALUES(null,@NombreLibro, @NombreAutor, @Categoria)"
                );
            insert.Parameters.AddWithValue("@NombreLibro", obj.NombreLibro);
            insert.Parameters.AddWithValue("@NombreAutor", obj.NombreAutor);
            insert.Parameters.AddWithValue("@Categoria", obj.Categoria);
            int resultado = Conexion.ejecutarSentencia(insert);
            return (resultado > 0);
        }

        public bool eliminar(String NombreLibro)
        {
            MySqlCommand delete = new MySqlCommand(
                @"DELETE FROM libro
                WHERE Id=@Id"
                );
            delete.Parameters.AddWithValue("@Id", NombreLibro);

            int resultado = Conexion.ejecutarSentencia(delete);
            return (resultado > 0);
        }

        public bool actualizar(Libro obj)
        {
           
            MySqlCommand update = new MySqlCommand(
                @"UPDATE libro
                SET NombreLibro=@NombreLibro, NombreAutor=@NombreAutor, 
                Categoria=@Categoria" +
                " WHERE Id=@Id"
                );
            update.Parameters.AddWithValue("@NombreLibro", obj.NombreLibro);
            update.Parameters.AddWithValue("@NombreAutor", obj.NombreAutor);
            update.Parameters.AddWithValue("@Categoria", obj.Categoria);
            int resultado = Conexion.ejecutarSentencia(update);
            return (resultado > 0);
        }

        public Libro obtenerUno(String NombreLibro)
        {
            MySqlCommand consulta =
                new MySqlCommand(@"SELECT NombreLibro,
                        NombreAutor,
                        Categoria
                    FROM libro a
                    WHERE NombreLibro=@NombreLibro");
            consulta.Parameters.AddWithValue("@NombreLibro", NombreLibro);
            DataTable resultado = Conexion.ejecutarConsulta(consulta);
            if (resultado != null && resultado.Rows.Count > 0)
            {
                DataRow fila = resultado.Rows[0];
                //Llenar los datos en un a alumno
                Libro libro = new Libro()
                {
                    NombreLibro = NombreLibro,
                    NombreAutor = fila["NombreAutor"].ToString(),
                    Categoria = fila["Categoria"].ToString()
                    
                };
                return libro;
            }
            else
            {
                return null;
            }

        }




    }
}
