using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.seguridad
{
    class AsignarCajero
    {
        public int IdAsignarCajero { get; set; }
        public int IdUsuario { get; set; }
        public int IdPuntoVenta { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
    }
}