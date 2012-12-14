using GrouponDesktop.Helpers;

namespace GrouponDesktop.DTOs
{
    public class Estadistica
    {
        public TipoListado TipoListado { get; set; }
        public int Semestre { get; set; }
        public int Anio { get; set; }

        public Estadistica()
        {
            var fechaSistema = ControlBindingHelpers.FechaSistema;

            this.Semestre = fechaSistema.GetSemester();
            this.Anio = fechaSistema.Year;
        }
    }

    public enum TipoListado
    {
        PorcentajeDevolucionCompras,
        AcreditacionGiftCards
    }
}