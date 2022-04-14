using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sistema
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public int IdTipoDocumento { get; set; }
	    public string NumeroDocumento { get; set; }
        public string NombreComercial { get; set; }
        public string Representante { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Estado { get; set; }
        
    }
}
