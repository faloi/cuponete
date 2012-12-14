using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.Helpers;

namespace GrouponDesktop.DTOs
{
    public class Cupon_comprado
    {
        public long id_compra { set; get; }
        public DateTime fecha_compra { set; get; }
        public long id_cupon { set; get; }
        public string codigo_compra { set; get; }
        public long id_cliente { set; get; }
        public decimal precio_real { set; get; }
        public string estado { get; set; }
        public string descripcion { get; set; }

        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public DateTime fec_venc_consumo { set; get; }

        public Cupon_comprado()
        {
             this.FechaDesde = this.FechaHasta = ControlBindingHelpers.GetFechaSistema();
        }
    }
}
