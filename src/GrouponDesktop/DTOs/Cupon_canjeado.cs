using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.Helpers;

namespace GrouponDesktop.DTOs
{
    public class Cupon_canjeado
    {
        public long id_canje { set; get; }
        public DateTime fecha_canje { set; get; }
        public long id_compra { set; get; }
        public long id_cliente { set; get; }
        public int facturado { set; get; }  
        public long id_proveedor { set; get; }
        public string codigo_compra { set; get; }

        public Cupon_canjeado()
        {
            this.fecha_canje = ControlBindingHelpers.FechaSistema;
        }
    }
}
