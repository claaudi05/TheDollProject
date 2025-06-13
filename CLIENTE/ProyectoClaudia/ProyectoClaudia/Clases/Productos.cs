using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoClaudia.Clases;

namespace ProyectoClaudia
{
    public class Productos
    {
        public int id { get; set; } 
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }
        public string marca { get; set; }
        public bool oferta { get; set; }
        public double precio_oferta { get; set; }
        public string imagen { get; set; }
        //public List<Cestas> cesta { get; set; } = new List<Cestas>();
    }
}
