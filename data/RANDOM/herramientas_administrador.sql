
--Publicacion de cupones: RANDOM.PublicarCupon (parametro necesario)
create procedure RANDOM.PublicarCupon @id_cupon bigint out
as
begin	
	update RANDOM.Cupon
	set publicado = 1
	where id_cupon = @id_cupon
end
go


--Facturacion de cupones: RANDOM.FacturarCupones (los parametros @monto_total y @nro_factura son solo output, para mostrarlos al administrador)
create procedure RANDOM.FacturarCupones @monto_total bigint out, @nro_factura numeric(18,0) out, @id_proveedor bigint out, @fecha datetime out, @fecha_inicio datetime out, @fecha_fin datetime out
as
begin
	set @nro_factura = (select top 1 nro_factura from RANDOM.Factura order by nro_factura desc) + 1
	
	insert into RANDOM.Factura(nro_factura, fecha, id_proveedor)
	values(@nro_factura, @fecha, @id_proveedor)
		
	declare @id_factura bigint
	set @id_factura = (select id_factura from RANDOM.Factura where nro_factura = @nro_factura)
	
	insert into RANDOM.Renglon_Factura(id_cupon_canjeado, id_factura)
	select id_canje, @id_factura
	from RANDOM.Cupon_Canjeado
	where fecha_canje between @fecha_inicio and @fecha_fin
	
	set @monto_total = (select sum(precio_real)
						from RANDOM.Renglon_Factura rf 
							 inner join RANDOM.Cupon_Canjeado ccan on ccan.id_canje = rf.id_cupon_canjeado and rf.id_factura = @id_factura
							 inner join RANDOM.Cupon_Comprado ccom on ccom.id_compra = ccan.id_compra
							 inner join RANDOM.Cupon c on ccom.id_cupon = c.id_cupon
						where rf.id_factura = @id_factura)
						
	update RANDOM.Cupon_Canjeado
	set facturado = 1
	where id_canje in (select id_cupon_canjeado from RANDOM.Renglon_Factura where id_factura = @id_factura)
	
end
go
