using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sistema
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public int IdProveedor { get; set; }
        public int NumeroComprobante { get; set; }
        public DateTime Fecha { get; set; }
        public float Subtotal { get; set; }
        public float Descuento { get; set; }
        public float Iva { get; set; }
        public float Total { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
    }
}
