using AccesoDatos.globales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.conexiones
{
    public class CadenaConexion
    {
        public CadenaConexion(String cad)
        {
            Globals.CadenaConexion = cad;
        }
    }
}
