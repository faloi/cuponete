using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.DTOs
{
    class Cupon_devuelto
    {
        public long id_devolucion { set; get; }
        public DateTime fecha_devolucion { set; get; }
        public long id_cliente { set; get; }
        public long id_compra { set; get; }
        public string motivo_devolucion { set; get; }
    }
}
