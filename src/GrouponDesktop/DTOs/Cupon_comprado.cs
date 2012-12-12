using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.DTOs
{
    public class Cupon_comprado
    {
        public long id_compra { set; get; }
        public DateTime fecha_compra { set; get; }
        public long id_cupon { set; get; }
        public long codigo_compra { set; get; }
        public long id_cliente { set; get; }
    }
}
