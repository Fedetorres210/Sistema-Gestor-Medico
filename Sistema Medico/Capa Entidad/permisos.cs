using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class permisos
    {
        public int id_permiso { get; set; }
        public rol id_rol { get; set; }
        public string nombre { get; set; }
    }
}
