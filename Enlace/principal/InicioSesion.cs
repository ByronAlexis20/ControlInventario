using Entidades.seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enlace.principal
{
    public class InicioSesion
    {
        public Usuario validarUsuario(string usuario, string clave)
        {
            AccesoDatos.principal.InicioSesion obj = new AccesoDatos.principal.InicioSesion();
            return obj.validarUsuario(usuario, clave);
        }
    }
}
