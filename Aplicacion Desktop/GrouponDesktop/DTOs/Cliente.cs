using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.DTOs
{
    class Cliente
    {
        public long id_usuario { set; get; }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public int dni { set; get; }
        public string mail { set; get; }
        public int telefono { set; get; }
        public string direccion { set; get; }
        public int cod_postal { set; get; }
        public DateTime fecha_nac { set; get; }
        public int saldo_actual { set; get; }
    }
}
