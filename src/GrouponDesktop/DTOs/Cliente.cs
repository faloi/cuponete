using System;

namespace GrouponDesktop.DTOs
{
    public class Cliente : Usuario
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

        public string direccion_completa
        {
            get
            {
                return string.Format("{0} {1} {2} {3} {4}", direccionCalle, direccionNumero, direccionPiso, direccionDto, direccionLocalidad);
            }
        }

        public Cliente()
        {
            this.fecha_nac = DateTime.Now;
        }

        public Cliente(Usuario usuario) : base(usuario) {}
    }
}
