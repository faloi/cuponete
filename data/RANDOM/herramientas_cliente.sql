--Registro de una carga de credito
create procedure RANDOM.CargarCredito @id_cliente bigint, @carga_credito bigint, @fecha datetime, @id_forma_pago bigint, @nro_tarjeta numeric(15,0), @cod_seguridad_tarjeta numeric(3,0), @fecha_vto_tarjeta nvarchar(5)
as
begin transaction
	insert into RANDOM.Credito(id_cliente, carga_credito, fecha,id_forma_pago, nro_tarjeta, cod_seguridad_tarjeta, fecha_vto_tarjeta)
	values(@id_cliente, @carga_credito, @fecha, @id_forma_pago, @nro_tarjeta, @cod_seguridad_tarjeta, @fecha_vto_tarjeta)
	
	update RANDOM.Cliente
	set saldo_actual = saldo_actual + @carga_credito
	where id_usuario = @id_cliente
commit
go


--Registro de una gift card
create procedure RANDOM.ComprarGiftCarg @id_usuario_origen bigint, @id_usuario_destino bigint, @fecha datetime, @monto bigint
as
begin transaction
	insert into RANDOM.Gift_Card(id_usuario_origen, id_usuario_destino, fecha, monto)
	values(@id_usuario_origen, @id_usuario_destino, @fecha, @monto)
	
	update RANDOM.Cliente
	set saldo_actual = saldo_actual + @monto
	where id_usuario = @id_usuario_destino
commit
go