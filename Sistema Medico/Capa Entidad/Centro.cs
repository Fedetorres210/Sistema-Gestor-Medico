using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class Centro
    {
        public int id_centro { get; set; }
        public lugar id_lugar { get; set; }
        public int capacidad_maxima { get; set; }
        public string tipo_centro { get; set; }
        public string nombre { get; set; }
    }
}
