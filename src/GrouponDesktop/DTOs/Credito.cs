using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.DTOs
{
    class Credito
    {
        public long id_credito { set; get; }
        public long id_cliente { set; get; }
        public decimal carga_credito { set; get; }
        public DateTime fecha { set; get; }
        public long id_forma_pago { set; get; }
        public long nro_tarjeta { set; get; }
        public int cod_seguridad_tarjeta { set; get; }
        public string fecha_vto_tarjeta { set; get; }
    }
}
