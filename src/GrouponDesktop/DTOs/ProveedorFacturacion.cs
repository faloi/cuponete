using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.DTOs
{
    public class ProveedorFacturacion
    {
        public string codigo_compra { get; set; }
        public DateTime fecha_canje { get; set; }
        public decimal precio_real { get; set; }
        public string id_proveedor { get; set; }

        public DateTime fecha { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }

        public ProveedorFacturacion()
        {
            this.fecha = this.fecha_inicio = this.fecha_fin = DateTime.Now;
        }
    }
}
