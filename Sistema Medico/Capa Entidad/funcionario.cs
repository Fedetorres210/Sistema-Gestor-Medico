using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class funcionario
    {
        public persona id_persona { get; set; }
        public Centro id_centro { get; set; }
        public area id_area { get; set; }
        public string tipo_funcionario { get; set; }
        public string fecha_ingreso { get; set; }
        public string area_trabajo { get; set; }
    }
}
