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

        public bool EstaBloqueado
        {
            get { return this.fallas >= 3; }
        }

        public void Fill(Usuario usuario)
        {
            this.id_usuario = usuario.id_usuario;
            this.username = usuario.username;
            this.password = usuario.password;
            this.id_rol = usuario.id_rol;
            this.tipo = usuario.tipo;
            this.estado = usuario.estado;
            this.dni_cuit = usuario.dni_cuit;
            this.fallas = usuario.fallas;
        }
    }
}