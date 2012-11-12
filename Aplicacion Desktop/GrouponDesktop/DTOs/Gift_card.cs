using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.DTOs
{
    class Gift_card
    {
        public long id_gift_card { set; get; }
        public DateTime fecha { set; get; }
        public decimal monto { set; get; }
        public long id_usuario_origen { set; get; }
        public long id_usuario_destino { set; get; }
    }
}
