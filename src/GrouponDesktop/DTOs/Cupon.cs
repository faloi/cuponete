using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.Helpers;

namespace GrouponDesktop.DTOs
{
    public class Cupon
    {
        public long id_cupon { set; get; }
        public string codigo_cupon { set; get; }
        public string descripcion { set; get; }
        public DateTime fec_publicacion { set; get; }
        public DateTime fec_venc_publicacion { set; get; }
        public DateTime fec_venc_consumo { set; get; }
        public DateTime fecha_actual { set; get; }
        public decimal precio_real { set; get; }
        public decimal precio_ficticio { set; get; }
        public long id_proveedor { set; get; }
        public string descripcionProveedor { set; get; }
        public long cant_disp { set; get; }
        public long max_compra_por_usuario { set; get; }
        public int publicado { set; get; }

        public Cupon()
        {
            this.fec_publicacion = ControlBindingHelpers.GetFechaSistema();
            this.fec_venc_consumo = ControlBindingHelpers.GetFechaSistema();
            this.fec_venc_publicacion = ControlBindingHelpers.GetFechaSistema();
        }
    }


}
