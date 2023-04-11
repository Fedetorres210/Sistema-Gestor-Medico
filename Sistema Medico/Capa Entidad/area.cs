using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class area
    {
        public int id_area { get; set; }
        public Centro id_centro { get; set; }
        public string descripcion { get; set; }
        public string nombre { get; set; }
    }
}
