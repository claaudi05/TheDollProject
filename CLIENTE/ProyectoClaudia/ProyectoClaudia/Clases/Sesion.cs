using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClaudia.Clases
{
    public static class Sesion
    {
        public static Usuarios UsuarioActual { get; set; } = null;
        public static bool EsInvitado => UsuarioActual == null;
    }
}
