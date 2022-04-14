using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.seguridad
{
    class Configuracion
    {
        public int IdConfiguracion { get; set; }
        public double PorcentajeIVA { get; set; }
        public int CantidadDecimales { get; set; }
        public string Estado { get; set; }
    }
}
