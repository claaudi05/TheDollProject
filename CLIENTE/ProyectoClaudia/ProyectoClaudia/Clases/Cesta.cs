using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClaudia.Clases
{
    public class Cesta
    {
        public int id { get; set; }
        public Usuarios usuarios { get; set; }
        public Productos productos { get; set; }
        public int cantidad { get; set; }
    }
}
