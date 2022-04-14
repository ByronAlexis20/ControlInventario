using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.seguridad
{
    class PuntoVenta
    {
        public int IdPuntoVenta { get; set; }
        public int IdEmpresa { get; set; }
        public string Descripcion { get; set; }
        public string CodigoSRI { get; set; }
        public string Estado { get; set; }
    }
}
