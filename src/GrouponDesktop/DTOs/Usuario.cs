using System.Collections.Generic;

namespace GrouponDesktop.DTOs
{
    public class Usuario
    {
        public long id_usuario { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public long id_rol { get; set; }
        public string tipo { get; set; }
        public int estado { get; set; }
        public string dni_cuit { get; set; }
        public decimal fallas { get; set; }

        public Usuario() {}

        public Usuario(Usuario usuario)
        {
            this.dni_cuit = usuario.dni_cuit;
            this.password = usuario.password;
            this.username = usuario.username;
        }

        public bool EstaBloqueado
        {
            get { return this.fallas >= 3; }
        }

        public Dictionary<string, string> Forms
        {
            get
            {
                return new Dictionary<string, string>
                {
                   { "Iniciar sesión", "LoginView" }
                };
            }
        }
    }
}