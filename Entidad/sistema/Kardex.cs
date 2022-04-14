using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sistema
{
    public class Kardex
    {
        public int IdKardex { get; set; }
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }
        public int IdCompra { get; set; }
        public string TipoDocumento { get; set; }
        public string NumDocumento { get; set; }
        public string TipoTransaccion { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float Total { get; set; }
        public string Estado { get; set; }
    }
}
