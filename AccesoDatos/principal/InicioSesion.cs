using AccesoDatos.conexiones;
using Entidades.seguridad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.principal
{
    public class InicioSesion
    {
        ConexionBD bd = new ConexionBD();
        public Usuario validarUsuario(string usuario, string clave)
        {
            try
            {
                Usuario us = null;
                string sql = "select * from seg_usuario where usuario = '" + usuario + "' and clave = '" + clave + "' and estado = 'A'";
                if (bd.conectar() == false)
                    return null;
                DataTable dt = new DataTable();
                MySqlDataReader dr = bd.ejecutarConsultaReader(sql);
                dt.Load(dr);
                foreach (DataRow fila in dt.Rows)
                {
                    us = new Usuario();
                    us.Apellidos = fila["apellidos"].ToString();
                    us.NumeroDocumento = fila["numero_documento"].ToString();
                    us.Clave = fila["clave"].ToString();
                    us.Direccion = fila["direccion"].ToString();
                    us.Email = fila["email"].ToString();
                    us.Estado = fila["estado"].ToString();
                    us.IdTipoUsuario = int.Parse(fila["id_tipo_usuario"].ToString());
                    us.IdUsuario = int.Parse(fila["id_usuario"].ToString());
                    us.Nombres = fila["nombres"].ToString();
                    us.Telefono = fila["telefono"].ToString();
                    us.Usuario_ = fila["usuario"].ToString();
                }
                bd.desconectar();
                return us;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
