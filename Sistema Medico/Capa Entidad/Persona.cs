using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class persona
    {
        public int id_persona { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string fechaNacimiento { get; set; }
        public string nacionalidad { get; set; }
        public string IdLugar { get; set; }
        public string direccion { get; set; }
    }
}
