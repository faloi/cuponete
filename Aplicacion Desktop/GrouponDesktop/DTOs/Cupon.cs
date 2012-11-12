using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.DTOs
{
    class Cupon
    {
        public long id { set; get; }
        public string codigo_cupon { set; get; }
        public string descripcion { set; get; }
        public DateTime fec_publicacion { set; get; }
        public DateTime fec_venc_publicacion { set; get; }
        public DateTime fec_venc_consumo { set; get; }
        public decimal precio_real { set; get; }
        public decimal precio_ficticio { set; get; }
        public long id_proveedor { set; get; }
        public long cant_disp { set; get; }
        public long max_compra_por_usuario { set; get; }
        public int publicados { set; get; }
    }
}
