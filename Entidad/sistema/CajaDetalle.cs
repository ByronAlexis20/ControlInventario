using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sistema
{
    public class CajaDetalle
    {
        public int IdCajaDetalle { get; set; }
        public int IdCaja { get; set; }
        public int IdTipoMovimiento { get; set; }
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Observacion { get; set; }
        public float Valor { get; set; }
        public string Estado { get; set; }
    }
}
