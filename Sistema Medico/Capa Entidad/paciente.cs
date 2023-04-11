using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class paciente
    {
        public persona id_persona { get; set; }
        public diagnostico id_diagnostico { get; set; }
        public cita id_citas { get; set; }
        public tratamiento id_tratamiento { get; set; }
        public string tipo_sangre { get; set; }
    }
}
