using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class tratamiento
    {
        public int id_tratamiento { get; set; }
        public string nombre_tratamiento { get; set; }
        public diagnostico id_diagnostico { get; set; }
        public int unidad { get; set; }
        public string nombre { get; set; }
        public string tipo_tratamiento { get; set; }
        public string nivel { get; set; }

    }
}
