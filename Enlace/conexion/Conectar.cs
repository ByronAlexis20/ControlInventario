using AccesoDatos.conexiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enlace.conexion
{
    public class Conectar
    {
        public Conectar(string cad)
        {
            CadenaConexion obj = new CadenaConexion(cad);
        }
    }
}
