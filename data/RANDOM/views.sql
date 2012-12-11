/** Vista de cupones para cliente **/
create view RANDOM.Cupones_Para_Cliente
as
select cu.id_cupon, descripcion, precio_ficticio, precio_real, fec_publicacion, fec_venc_publicacion, id_cliente
from RANDOM.Cupon cu 
	 inner join RANDOM.Cupon_x_ciudad cuxc on (cuxc.id_cupon = cu.id_cupon)
	 inner join RANDOM.Cliente_x_Ciudad clxc on (clxc.id_ciudad = cuxc.id_ciudad)
where cu.publicado = 1
go


/** Vista para historial de cupones **/
create view RANDOM.Historial_Compra_Cupones
as
select id_cliente, fecha_compra, descripcion, codigo_compra, estado =
	case when exists (select 1 from RANDOM.Cupon_Canjeado ccan where ccan.id_compra = cc.id_compra) then 'Canjeado'
		 when exists (select 1 from RANDOM.Cupon_Devuelto cdev where cdev.id_compra = cc.id_compra) then 'Devuelto'
		 else 'Comprado'
	end
from RANDOM.Cupon_Comprado cc 
	 inner join RANDOM.Cupon c on cc.id_cupon = c.id_cupon
go
 
 
/** Vista para facturacion de proveedor */
create view RANDOM.Facturacion_Proveedor
as
select codigo_compra, fecha_canje, precio_real 
from RANDOM.Cupon_Canjeado ccan 
	  inner join RANDOM.Cupon_Comprado ccom on ccan.id_compra = ccom.id_compra
	  inner join RANDOM.Cupon c on c.id_cupon = ccom.id_cupon
where facturado = 0

/*
/** Vista para porcentaje de devolucion por proveedor por semestre **/
create view RANDOM.Porcentaje_Devolucion
as
select anio = year(fecha_devolucion), semestre = (month(fecha_devolucion) % 7) + 1
from RANDOM.Cupon c
	 inner join RANDOM.Cupon_Comprado ccom on c.id_cupon = ccom.id_cupon
	 inner join RANDOM.Cupon_Devuelto cdev on ccom.id_compra = cdev.id_compra
