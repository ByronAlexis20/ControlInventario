using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sistema
{
    public class Precio
    {
        public int IdPrecio { get; set;  }
        public int IdProducto { get; set; }
        public int Idtarifa { get; set; }
        public double Precio_ { get; set; }
        public int RangoEscalaInicial { get; set; }
        public int RangoEscalaFinal { get; set; }
        public string Estado { get; set; }
    }
}
