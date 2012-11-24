using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.DTOs
{
    class Proveedor:Usuario
    {
        public string razon_social { set; get; }
        public string mail { set; get; }
        public long telefono { set; get; }
        public string direccion { set; get; }
        public int cod_postal { set; get; }
        public long id_ciudad { set; get; }
        public string cuit { set; get; }
        public long id_rubro { set; get; }
        public string contacto_nombre { set; get; }
    }
}
