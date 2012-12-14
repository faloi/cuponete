namespace GrouponDesktop.DTOs
{
    public class Estadistica
    {
        public TipoListado TipoListado { get; set; }
        public int Semestre { get; set; }
        public int Anio { get; set; }
    }

    public enum TipoListado
    {
        PorcentajeDevolucionCompras,
        AcreditacionGiftCards
    }
}