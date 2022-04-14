using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sistema
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public int IdCategoriaProducto { get; set; }
	    public int IdUnidadMedidaCompra { get; set; }
        public int IdUnidadMedidaVenta { get; set; }
        public int IdMarca { get; set; }
	    public string Codigo { get; set; }
	    public string Descripcion { get; set; }
        public int Stock { get; set; }
        public int StockMaximo { get; set; }
        public int StockMinimo { get; set; }
        public float PrecioCosto { get; set; }
        public string LlevaIva { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Estado { get; set; }
    }
}
