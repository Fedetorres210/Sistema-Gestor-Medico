using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using CapaEntidades;

namespace Capa_Negocio
{
    public  class usuario_CN
    {
        private usuario_CD objcd_usuario = new usuario_CD();

        public List<usuarios> Listar()
        {
            return objcd_usuario.Listar();

        }
    }
}
