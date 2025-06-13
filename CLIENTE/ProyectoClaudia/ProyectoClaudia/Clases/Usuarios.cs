using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClaudia.Clases
{
    public class Usuarios
    {
        public int id {  get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string contraseña { get; set; }
        public bool admin_usuarios { get; set; }
        public bool admin_productos { get; set; }
        public string imagen { get; set; }
       // public List<Cesta> cesta { get; set; } = new List<Cesta>();

    }
}
