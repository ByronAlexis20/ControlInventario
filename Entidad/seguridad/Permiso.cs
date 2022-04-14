using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.seguridad
{
    public class Permiso
    {
        public int IdPermiso { get; set; }
        public int IdMenu { get; set; }
	    public int IdTipoUsuario { get; set; }
	    public string Estado { get; set; }
    }
}
