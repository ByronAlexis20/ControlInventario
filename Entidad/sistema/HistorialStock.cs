﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sistema
{
    public class HistorialStock
    {
        public int IdHistorialStock { get; set; }
        public int IdProducto { get; set; }
	    public int Stock { get; set; }
	    public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Estado { get; set; }
    }
}
