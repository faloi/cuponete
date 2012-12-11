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
go


/** Vista para porcentaje de devolucion por proveedor por semestre (algo hay que cambiar, asi tarda 24.33 min en mi maquina) **/
create view RANDOM.Porcentaje_Devolucion
as
select distinct id_proveedor,
	   anio = year(fecha_compra), 
	   semestre = floor (((month(fecha_compra)) - 1) / 6) + 1, 
	   porcentaje_devolucion = 
			(select count(*) from RANDOM.Cupon_Devuelto cdev1 
							 inner join RANDOM.Cupon_Comprado ccom1 on cdev1.id_compra = ccom1.id_compra 
							 inner join RANDOM.Cupon c1 on ccom1.id_cupon = c1.id_cupon
							 where c1.id_proveedor = c.id_proveedor and year(ccom1.fecha_compra) = year(ccom.fecha_compra) and floor(((month(ccom1.fecha_compra)) - 1) / 6) + 1 = floor(((month(ccom.fecha_compra)) - 1) / 6) + 1) * 100 /
			(select count(*) from RANDOM.Cupon_Comprado ccom1 
							 inner join RANDOM.Cupon c1 on ccom1.id_cupon = c1.id_cupon 
							 where c1.id_proveedor = c.id_proveedor and year(ccom1.fecha_compra) = year(ccom.fecha_compra) and floor(((month(ccom1.fecha_compra)) - 1) / 6) + 1 = floor(((month(ccom.fecha_compra)) - 1) / 6) + 1)
from RANDOM.Cupon c
	 inner join RANDOM.Cupon_Comprado ccom on c.id_cupon = ccom.id_cupon
go


/** Vista para estadistica de giftcards **/
create view RANDOM.Estadistica_Giftcards
as
select distinct id_usuario_destino,
	   anio = year(fecha), 
	   semestre = floor (((month(fecha)) - 1) / 6) + 1,
	   monto_total = (select sum(monto) 
					  from RANDOM.Gift_Card gc1 
					  where gc.id_usuario_destino = gc1.id_usuario_destino and year(gc.fecha) = year(gc1.fecha) and floor (((month(gc.fecha)) - 1) / 6) + 1 = floor (((month(gc1.fecha)) - 1) / 6) + 1)
from RANDOM.Gift_Card gc