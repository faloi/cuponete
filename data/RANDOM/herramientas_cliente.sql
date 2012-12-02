--Registro de una carga de credito
create procedure RANDOM.CargarCredito @id_cliente bigint, @carga_credito bigint, @fecha datetime, @id_forma_pago bigint, @nro_tarjeta numeric(15,0), @cod_seguridad_tarjeta numeric(3,0), @fecha_vto_tarjeta nvarchar(5)
as
begin
	insert into RANDOM.Credito(id_cliente, carga_credito, fecha,id_forma_pago, nro_tarjeta, cod_seguridad_tarjeta, fecha_vto_tarjeta)
	values(@id_cliente, @carga_credito, @fecha, @id_forma_pago, @nro_tarjeta, @cod_seguridad_tarjeta, @fecha_vto_tarjeta)
	
	update RANDOM.Cliente
	set saldo_actual = saldo_actual + @carga_credito
	where id_usuario = @id_cliente
end
go


--Registro de una compra de gift card
create procedure RANDOM.ComprarGiftCard @id_usuario_origen bigint, @id_usuario_destino bigint, @fecha datetime, @monto bigint
as
begin
	insert into RANDOM.Gift_Card(id_usuario_origen, id_usuario_destino, fecha, monto)
	values(@id_usuario_origen, @id_usuario_destino, @fecha, @monto)
	
	update RANDOM.Cliente
	set saldo_actual = saldo_actual + @monto
	where id_usuario = @id_usuario_destino
end
go


--Comprar cupon
create procedure RANDOM.ComprarCupon @id_cliente bigint, @id_cupon bigint, @fecha datetime, @codigo_compra nvarchar(50) output
as
begin transaction
	if (select cant_disp from RANDOM.Cupon where id_cupon = @id_cupon) <= 0
	begin
		rollback
		raiserror('No hay suficiente stock', 16, 1)
	end
	else
	begin
		if (select saldo_actual from RANDOM.Cliente where id_usuario = @id_cliente) < (select precio_real from RANDOM.Cupon where id_cupon = @id_cupon)
		begin
			rollback
			raiserror('No posee credito suficiente para realizar la compra', 16, 1)
		end
		else
		begin
			if (select COUNT(*) from RANDOM.Cupon_Comprado where id_cliente = @id_cliente and id_cupon = @id_cupon) >= (select max_compra_por_usuario from RANDOM.Cupon where id_cupon = @id_cupon)
			begin
				rollback
				raiserror('Ya ha comprado el maximo permitido de este cupon', 16, 1)			
			end
		end
	end	
	
	insert into RANDOM.Cupon_Comprado(fecha_compra, id_cliente, id_cupon, codigo_compra)
	values (@fecha, @id_cliente, @id_cupon, 0)
	
	update RANDOM.Cupon_Comprado
	set codigo_compra = id_compra
	where id_cupon = @id_cupon and id_cliente = @id_cliente
	
	update RANDOM.Cupon
	set cant_disp = cant_disp - 1
	
	update RANDOM.Cliente
	set saldo_actual = saldo_actual - (select precio_real from RANDOM.Cupon where id_cupon = @id_cupon)
	
	select @codigo_compra = codigo_compra from RANDOM.Cupon_Comprado where id_cupon = @id_cupon and id_cliente = @id_cliente
	
commit
go


--Pedir devolucion
create procedure RANDOM.DevolverCupon @id_cliente bigint, @id_cupon bigint, @fecha_devolucion datetime, @codigo_compra nvarchar(50)
as
begin transaction
	if (select cant_disp from RANDOM.Cupon where id_cupon = @id_cupon) <= 0
	begin
		rollback
		raiserror('No hay suficiente stock', 16, 1)
	end
	else
	begin
		if (select saldo_actual from RANDOM.Cliente where id_usuario = @id_cliente) < (select precio_real from RANDOM.Cupon where id_cupon = @id_cupon)
		begin
			rollback
			raiserror('No posee credito suficiente para realizar la compra', 16, 1)
		end
		else
		begin
			if (select COUNT(*) from RANDOM.Cupon_Comprado where id_cliente = @id_cliente and id_cupon = @id_cupon) >= (select max_compra_por_usuario from RANDOM.Cupon where id_cupon = @id_cupon)
			begin
				rollback
				raiserror('Ya ha comprado el maximo permitido de este cupon', 16, 1)			
			end
		end
	end	
	
	insert into RANDOM.Cupon_Comprado(fecha_compra, id_cliente, id_cupon, codigo_compra)
	values (@fecha, @id_cliente, @id_cupon, 0)
	
	update RANDOM.Cupon_Comprado
	set codigo_compra = id_compra
	where id_cupon = @id_cupon and id_cliente = @id_cliente
	
	update RANDOM.Cupon
	set cant_disp = cant_disp - 1
	
	update RANDOM.Cliente
	set saldo_actual = saldo_actual - (select precio_real from RANDOM.Cupon where id_cupon = @id_cupon)
	
	select @codigo_compra = codigo_compra from RANDOM.Cupon_Comprado where id_cupon = @id_cupon and id_cliente = @id_cliente
	
commit
go