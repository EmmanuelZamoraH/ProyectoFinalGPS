using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    //plain old java object (POJO)
    //plain old c# object (POCO) 
    public class Libro
    {
        public string id { get; set; }
        public string NombreLibro { get; set; }
        public string NombreAutor { get; set; }
        public string Categoria { get; set; }

    }
}
