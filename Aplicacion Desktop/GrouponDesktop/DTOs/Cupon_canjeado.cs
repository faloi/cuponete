using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.DTOs
{
    class Cupon_canjeado
    {
        public long id_canje { set; get; }
        public DateTime fecha_canje { set; get; }
        public long id_compra { set; get; }
        public long id_cliente { set; get; }
        public int facturado { set; get; }
    }
}
