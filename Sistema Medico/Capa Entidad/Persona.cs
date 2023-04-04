using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Persona
    {
        public int Id { get; set; }

        public string nombre { get; set; }

        public string apellido1 { get; set; }

        public string apellido2 { get; set; }

        public string fechaNacimiento { get; set; }

        public string nacionalidad { get; set; }

        public Lugar IdLugar { get; set; }

        public string direccion { get; set; }
    }
}
