using GrouponDesktop.DTOs;

namespace GrouponDesktop.Homes
{
    public class EstadisticasHome : Home
    {
        public EstadisticasHome(string connectionString) : base(connectionString)
        {
        }

        public object PorcentajeDevolucionCompras(Estadistica filter)
        {
            const string QUERY =
                @"select distinct top 5 razon_social, telefono, porcentaje_devolucion = 
			                (select count(*) from RANDOM.Cupon_Devuelto cdev1 
							 inner join RANDOM.Cupon_Comprado ccom1 on cdev1.id_compra = ccom1.id_compra 
							 inner join RANDOM.Cupon c1 on ccom1.id_cupon = c1.id_cupon
							 where c1.id_proveedor = c.id_proveedor and year(cdev1.fecha_devolucion) = {0} and floor(((month(cdev1.fecha_devolucion)) - 1) / 6) + 1 = {1}) * 100 /
			                (select count(*) from RANDOM.Cupon_Comprado ccom1 
							 inner join RANDOM.Cupon c1 on ccom1.id_cupon = c1.id_cupon 
							 where c1.id_proveedor = c.id_proveedor and year(ccom1.fecha_compra) = {0} and floor(((month(ccom1.fecha_compra)) - 1) / 6) + 1 = {1})
                from RANDOM.Cupon c
	            inner join RANDOM.Proveedor p on p.id_usuario = c.id_proveedor
                order by porcentaje_devolucion desc";

            return this.sqlRunner.Select(QUERY, filter.Anio, filter.Semestre);
        }

        public object AcreditacionGiftCards(Estadistica filter)
        {
            const string QUERY =
                @"select distinct top 5 nombre, telefono, monto_total = sum(monto), cantidad_gc = count(distinct id_gift_card) 
                from RANDOM.Gift_Card inner join RANDOM.Cliente on id_usuario = id_usuario_destino 
                where year(fecha) = {0} and floor (((month(fecha)) - 1) / 6) + 1 = {1}
                group by id_usuario, nombre, telefono
                order by cantidad_gc desc";

            return this.sqlRunner.Select(QUERY, filter.Anio, filter.Semestre);
        }
    }
}