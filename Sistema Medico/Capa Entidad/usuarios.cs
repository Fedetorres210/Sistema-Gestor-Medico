using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class usuarios
    {
        public int id_usuario { get; set; }
        public persona id_persona { get; set; }
        public int id_rol { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string clave { get; set; }
    }
}
