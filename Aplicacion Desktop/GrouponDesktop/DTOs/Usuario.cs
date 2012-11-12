namespace GrouponDesktop.DTOs
{
    public class Usuario
    {
        public string username { get; set; }
        public string password { get; set; }
        public string dni_cuit { get; set; }
        public decimal fallas { get; set; }

        public bool EstaBloqueado { get { return this.fallas >= 3; } }
    }
}