
--Publicacion de cupones: RANDOM.PublicarCupon (parametro necesario)
create procedure RANDOM.PublicarCupon @id_cupon bigint out
as
begin	
	update RANDOM.Cupon
	set publicado = 1
	where id_cupon = @id_cupon
end
go

/*
--Facruracion de cupones: RANDOM.FacturarCupones (el parametro @monto_total es solo output, para mostrarlo al administrador)
create procedure RANDOM.ArmarCupon @id_proveedor bigint out, @fecha datetime out, @fecha_inicio datetime out, @fecha_fin datetime out
as
begin  transaction
	
	insert into RANDOM.Factura(nro_factura, fecha, id_proveedor)
		
commit
go
*/