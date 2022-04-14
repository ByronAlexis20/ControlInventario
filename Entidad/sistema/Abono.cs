using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sistema
{
    public class Abono
    {
        public int IdAbono { get; set; }
        public int IdVentaCobrar { get; set; }
        public double Valor { get; set; }
        public string Estado { get; set; }
    }
}
