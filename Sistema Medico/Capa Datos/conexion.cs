using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Capa_Datos
{
    public class conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["conexionString"].ToString();
    }
}
