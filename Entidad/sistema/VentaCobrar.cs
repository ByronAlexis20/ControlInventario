using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sistema
{
    public class VentaCobrar
    {
        public int IdVentaCobrar { get; set; }
        public int IdVenta { get; set; }
        public double Valor { get; set; }
        public double ValorAbonado { get; set; }
        public string Estado { get; set; }
    }
}
