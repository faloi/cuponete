using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.Helpers;

namespace GrouponDesktop.DTOs
{
    public class CuponParaDevolucion
    {
        public DateTime fecha_devolucion { set; get; }
        public long id_cliente { set; get; }
        public long id_cupon { set; get; }
        public long id_compra { set; get; }
        public long codigo_compra { set; get; }

    }
}
