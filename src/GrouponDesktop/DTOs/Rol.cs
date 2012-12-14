using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.DTOs
{
    public class Rol
    {
        public long id_rol { set; get; }
        public string descripcion { set; get; }
        public int estado { set; get; }
        public string descripcionEstado
        {
            get{ return (this.estado==0?"Deshabilitado":"Habilitado"); }
        }

    }
}
