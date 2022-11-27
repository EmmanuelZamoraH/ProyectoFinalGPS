using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Registro
    {
        public string IdRegistro { get; set; }
        public string NUMCONTROL { get; set; }
        public string NombreAlumno { get; set; }
        public string Apellido { get; set; }
        public int Id_Libro { get; set; }
        public DateTime Fecha { get; set; }
        public string Carrera { get; set; }
    }
}
