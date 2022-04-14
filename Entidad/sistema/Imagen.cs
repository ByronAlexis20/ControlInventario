using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sistema
{
    public class Imagen
    {
        public int IdImagen { get; set; }
        public int IdProducto { get; set; }
        public Byte[] Imagen_ { get; set; }
    }
}
