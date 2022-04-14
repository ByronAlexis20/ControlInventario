using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sistema
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public int IdTarifa { get; set; }
        public int IdFormaPago { get; set; }
        public int NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public float Subtotal { get; set; }
        public float Iva { get; set; }
        public float Descuento { get; set; }
        public float Total { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
    }
}
