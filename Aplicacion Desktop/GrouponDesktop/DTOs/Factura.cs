using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.DTOs
{
    class Factura
    {
        public long id_factura { set; get; }
        public long nro_factura { set; get; }
        public DateTime fecha { set; get; }
        public long id_proveedor { set; get; }
    }
}
