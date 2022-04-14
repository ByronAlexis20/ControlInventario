using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sistema
{
    public class Caja
    {
        public int IdCaja { get; set; }
        public int IdUsuario { get; set; }
        public int IdPuntoVenta { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public float SaldoInicial { get; set; }
        public float SaldoFinal { get; set; }
        public string EstadoApertura { get; set; }
        public string Estado { get; set; }
    }
}
