using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Modelos;

namespace Datos
{
    public class DAORegistro
    {
        public DataTable obtenerTodas()
        {
            MySqlCommand consulta =
                new MySqlCommand(@"SELECT R.IdRegistro, R.NUMCONTROL as 'Numero de control', R.NombreAlumno as 'Nombre del alumno', R.Apellido as 'Apellido  del alumno',
                 l.NombreLibro as 'Nombre del libro', R.Fecha, R.Carrera from registro R join libro l on R.Id_Libro=L.Id");
            return Conexion.ejecutarConsulta(consulta);

        }

        public bool insertar(Registro obj)
        {
            MySqlCommand insert = new MySqlCommand(
                @"INSERT INTO registro  VALUES(null,@NUMCONTROL, @NombreAlumno, @Apellido, 
                    @Id_Libro, @Fecha, @Carrera)"
                );
            insert.Parameters.AddWithValue("@NUMCONTROL", obj.NUMCONTROL);
            insert.Parameters.AddWithValue("@NombreAlumno", obj.NombreAlumno);
            insert.Parameters.AddWithValue("@Apellido", obj.Apellido);
            insert.Parameters.AddWithValue("@Id_Libro", obj.Id_Libro);
            insert.Parameters.AddWithValue("@Fecha", obj.Fecha);
            insert.Parameters.AddWithValue("@Carrera", obj.Carrera);

            int resultado = Conexion.ejecutarSentencia(insert);
            return (resultado > 0);
        }
    }
}
