using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class fichaClinica
    {
        public paciente id_persona { get; set; }
        public diagnostico id_diagnostico { get; set; }
        public tratamiento id_tratamiento { get; set; }
        public cita id_cita { get; set; }
        public string descripcion { get; set; }
        public string nivel { get; set; }
        public string unidad { get; set; }
        public string fecha { get; set; }
        public string unitipo_tratamientodad { get; set; }
    }
}
