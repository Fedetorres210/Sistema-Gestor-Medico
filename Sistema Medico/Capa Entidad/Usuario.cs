using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public Persona oRol {get; set; }

        public Rol oRol { get; set; }

        public string correo { get; set; }

        public int telefono { get; set; }
    }
}
