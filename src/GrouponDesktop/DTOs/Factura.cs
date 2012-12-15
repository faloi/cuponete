using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.Helpers;

namespace GrouponDesktop.DTOs
{
    public class Factura
    {
        public long nro_factura { get; set; }
        public string codigo_compra { get; set; }
        public DateTime fecha_canje { get; set; }
        public decimal precio_real { get; set; }
        public long id_proveedor { get; set; }

        public DateTime fecha { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }

        public long monto_total { get; set; }

        public Factura()
        {
            this.fecha = this.fecha_inicio = this.fecha_fin = ControlBindingHelpers.FechaSistema;
        }
    }
}
