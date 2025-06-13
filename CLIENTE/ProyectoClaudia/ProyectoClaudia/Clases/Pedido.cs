using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClaudia.Clases
{
    public class Pedido
    {

        public int id { get; set; }
        public Usuarios usuarios { get; set; }
        public DateTime fecha_pedido { get; set; }
        public bool entregado { get; set; }
        public double total { get; set; }
        public Descuento descuento { get; set; }
        public DateTime fecha_estimada { get; set; }
    }
}
