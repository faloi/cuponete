
--Armar un cupon: RANDOM.ArmarCupon (el parametro @id_cupon es solo output, para usarlo en RANDOM.AgregarCuponPorCiudad)
create procedure RANDOM.ArmarCupon @id_cupon bigint out, @nombre_cupon nvarchar(20) out, @id_proveedor bigint out, @descripcion nvarchar(255) out, @fec_publicacion datetime out, @fec_venc_publicacion datetime out, @fec_venc_consumo datetime out, @precio_real numeric(18,2) out, @precio_ficticio numeric(18,2) out, @cant_disp numeric(18,0) out, @max_compra_por_usuario numeric(18,0) out
as
begin  transaction
	if exists (select 1 from RANDOM.Usuario where id_usuario = @id_proveedor and estado = 0)
	begin
		rollback
		raiserror('Está deshabilitado, no puede armar ofertas', 16, 1)
		return
	end
	else
	begin
		if exists (select 1 from RANDOM.Cupon where nombre_cupon = @nombre_cupon)
		begin
			rollback
			raiserror('El nombre de cupon ya esta registrado', 16, 1)
			return	
		end
		else
		begin
			if GETDATE() > @fec_publicacion
			begin
				rollback
				raiserror('La fecha de publicacion no puede ser anterior a la actual', 16, 1)
				return
			end
			else
			begin
				if GETDATE() > @fec_venc_consumo
				begin
					rollback
					raiserror('La fecha de vencimiento de canje no puede ser anterior a la actual', 16, 1)
					return
				end
				else
				begin
					if GETDATE() > @fec_venc_publicacion
					begin
						rollback
						raiserror('La fecha de vencimiento de la oferta no puede ser anterior a la actual', 16, 1)
						return			
					end
				end
			end	
		end
	end
	
	insert into RANDOM.Cupon(nombre_cupon, descripcion, fec_publicacion, fec_venc_consumo, fec_venc_publicacion, precio_real, precio_ficticio, id_proveedor, cant_disp, max_compra_por_usuario, publicado)
	values(@nombre_cupon, @descripcion, @fec_publicacion, @fec_venc_consumo, @fec_venc_publicacion, @precio_real, @precio_ficticio, @id_proveedor, @cant_disp, @max_compra_por_usuario, 0)
	
	set @id_cupon = (select id_cupon from RANDOM.Cupon where nombre_cupon = @nombre_cupon)
commit
go


--Agregar cupon x ciudad: RANDOM.AgregarCuponPorCiudad (todos los parametros son necesarios)
create procedure RANDOM.AgregarCuponPorCiudad @id_cupon bigint output, @id_ciudad bigint output
as
begin
	insert into RANDOM.Cupon_x_Ciudad(id_cupon, id_ciudad)
	values(@id_cupon , @id_ciudad)
end
go

--Quitar cupon x ciudad: RANDOM.QuitarCuponPorCiudad (todos los parametros son necesarios)
create procedure RANDOM.QuitarCuponPorCiudad @id_cupon bigint output, @id_ciudad bigint output
as
begin
	delete from RANDOM.Cupon_x_Ciudad
	where id_cupon = @id_cupon and id_ciudad = @id_ciudad
end
go

--Registrar que un cupon fue consumido: RANDOM.RegistrarConsumo (todos los parametros son necesarios)
create procedure RANDOM.RegistrarConsumo @id_proveedor bigint out, @codigo_compra nvarchar(50) out, @fecha_canje datetime out
as
begin  transaction
	if exists (select 1 from RANDOM.Usuario where id_usuario = @id_proveedor and estado = 0)
	begin
		rollback
		raiserror('Está deshabilitado, no puede registrar un consumo', 16, 1)
		return
	end
	else
	begin
		if not exists (select 1 from RANDOM.Cupon_Comprado where codigo_compra = @codigo_compra)
		begin
			rollback
			raiserror('El codigo de cupon es erroneo', 16, 1)		
			return	
		end
		else
		begin
			if exists (select 1 from RANDOM.Cupon_Canjeado ccan inner join RANDOM.Cupon_Comprado ccom on ccom.id_compra = ccan.id_compra where ccom.codigo_compra = @codigo_compra)
			begin
				rollback
				raiserror('Ese canje ya esta registrado', 16, 1)		
				return
			end
			else
			begin
				if @fecha_canje > (select c.fec_venc_consumo from RANDOM.Cupon c inner join Cupon_Comprado cc on c.id_cupon = cc.id_cupon where cc.codigo_compra = @codigo_compra)
				begin
					rollback
					raiserror('La fecha de canje ha expirado', 16, 1)
					return
				end
				else
				begin
					if exists (select 1 from RANDOM.Cupon c inner join RANDOM.Cupon_Comprado cc on c.id_cupon = cc.id_cupon where cc.codigo_compra = @codigo_compra and c.id_proveedor != @id_proveedor)
					begin
						rollback
						raiserror('No es el proveedor de este cupon', 16, 1)
						return			
					end
				end
			end	
		end
	end
	
	insert into RANDOM.Cupon_Canjeado(fecha_canje, id_compra, id_cliente, facturado)
	select @fecha_canje, id_compra, id_cliente, 0 
	from RANDOM.Cupon_Comprado 
	where codigo_compra = @codigo_compra
commit
go