using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.DTOs
{
    class Cliente:Usuario
    {
        public string nombre { set; get; }
        public string apellido { set; get; }
        public int dni { set; get; }
        public string mail { set; get; }
        public int telefono { set; get; }
        public string direccionCalle { set; get; }
        public string direccionNumero { set; get; }
        public string direccionPiso { set; get; }
        public string direccionDto { set; get; }
        public string direccionLocalidad { set; get; }
        public string direccion { set; get; }
        public int cod_postal { set; get; }
        public DateTime fecha_nac { set; get; }
        public int saldo_actual { set; get; }

        public Cliente()
        {
            this.fecha_nac = DateTime.Now;
        }
    }
}
