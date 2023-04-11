using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace Capa_Datos
{
    public class usuario_CD
    {
        public List<usuarios> Listar()
        {
            List<usuarios> lista = new List<usuarios>();
            using (SqlConnection conn = new SqlConnection(conexion.cadena))
            {

                try
                {
                    string query = "select id_usuario, id_persona,id_rol,correo,telefono, clave from usuarios ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new usuarios
                            { 
                                id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                //id_persona = Convert.ToInt32(reader["id_persona"]),
                                //id_rol = Convert.ToInt32(reader["id_rol"]),
                                correo = reader["correo"].ToString(),
                                telefono = reader["telefono"].ToString(),
                                clave = reader["clave"].ToString()

                            });
                        }
                    }

                }
                catch(Exception ex) {

                    lista = new List<usuarios>();
                
                }
                
            }

            return lista;

        }



    }
}
