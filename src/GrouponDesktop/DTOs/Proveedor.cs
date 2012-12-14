using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.DTOs
{
    public class Proveedor : Usuario
    {
        public Proveedor() {}
        public Proveedor(Usuario usuario) : base(usuario) {}


        public string razon_social { set; get; }
        public string mail { set; get; }
        public long telefono { set; get; }
        public string direccionCalle { set; get; }
        public string direccionNumero { set; get; }
        public string direccionPiso { set; get; }
        public string direccionDto { set; get; }
        public string direccionLocalidad { set; get; }
        public string direccion { set; get; }
        public int cod_postal { set; get; }
        public long id_ciudad { set; get; }
        public string cuit { set; get; }
        public long id_rubro { set; get; }
        public string contacto_nombre { set; get; }

        public string direccion_completa
        {
            get
            {
                return string.Format("{0} {1} {2} {3} {4}", direccionCalle, direccionNumero, direccionPiso, direccionDto, direccionLocalidad);
            }
        }
    }
}
