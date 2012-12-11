/** Vista de cupones para cliente **/
create view RANDOM.Cupones_Para_Cliente
as
select cu.id_cupon,cu.descripcion,cu.fec_publicacion,cu.precio_ficticio, cu.precio_real,cpc.id_cliente
from RANDOM.Cupon cu 
left join RANDOM.Cupon_x_ciudad cupc on (cUpc.id_cupon = cu.id_cupon)
left join RANDOM.Cliente_x_Ciudad cpc on (cpc.id_ciudad = cupc.id_ciudad)
where cu.publicado = 1
go


/** Vista para historial de cupones **/
create view RANDOM.Historial_Compra_Cupones
as
select fecha_compra, descripcion, codigo_compra, estado =
	case when exists (select 1 from RANDOM.Cupon_Canjeado ccan where ccan.id_compra = cc.id_compra) then 'Canjeado'
		 when exists (select 1 from RANDOM.Cupon_Devuelto cdev where cdev.id_compra = cc.id_compra) then 'Devuelto'
		 else 'Comprado'
	end
 from RANDOM.Cupon_Comprado cc inner join RANDOM.Cupon c on cc.id_cupon = c.id_cupon
 go