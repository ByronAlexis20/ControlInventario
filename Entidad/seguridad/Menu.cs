using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.seguridad
{
    public class Menu
    {
        public int IdMenu { get; set; }
        public int IdMenuPadre { get; set; }
        public string Descripcion { get; set; }
	    public string Formulario { get; set; }
        public int Posicion { get; set; }
        public string Estado { get; set; }
    }
}
