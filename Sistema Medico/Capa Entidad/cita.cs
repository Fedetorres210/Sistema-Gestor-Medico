using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class cita
    {
        public int id_cita { get; set; }
        public paciente id_persona { get; set; }
        public funcionario nombre_especialidad { get; set; }
        public Centro id_centro { get; set; }
        public area id_area { get; set; }
        public string fecha_cita { get; set; }
        public string hora_cita { get; set; }
        public string observacion { get; set; }
        public string tipo_cita { get; set; }
        public string estado_cita { get; set; }
    }
}
