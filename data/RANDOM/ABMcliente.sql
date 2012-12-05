
--Registro de cliente: RANDOM.RegistrarCliente (el parametro @id_usuario es solo output, para usarlo en RANDOM.AgregarClientePorCiudad)
create procedure RANDOM.RegistrarCliente @id_usuario bigint output, @username nvarchar(255) output, @password nvarchar(255) output, @nombre nvarchar(255) output, @apellido nvarchar(255) output, @dni numeric(18,0) output, @mail nvarchar(100) output, @telefono numeric (18,0) output, @direccion_completa nvarchar(255) output, @cod_postal numeric(18,0) output, @fecha_nac datetime output
as
begin transaction
	if exists (select username from RANDOM.Usuario where @username = username)
	begin
		rollback
		raiserror('El nombre de usuario ya existe', 16, 1)
		return
	end	
	else
	begin
		if exists (select dni from RANDOM.Cliente where dni = @dni)
		begin
			rollback
			raiserror('El DNI ya esta registrado para otro cliente', 16, 1)
			return
		end	
		else
		begin
			if exists (select telefono from RANDOM.Cliente where telefono = @telefono)
			begin
				rollback
				raiserror('El telefono ya esta registrado para otro cliente', 16, 1)
				return
			end
			else
			begin
				if exists (select mail from RANDOM.Cliente where mail = @mail)
				begin
				rollback
				raiserror('El mail ya está registrado para otro cliente', 16, 1)
				return
				end
			end
		end	
	end
			
	insert into RANDOM.Usuario(username, password, id_rol, estado, fallas)
	values(@username, @password, 2, 1, 0)
	insert into RANDOM.Cliente(id_usuario, nombre, apellido, dni, mail, telefono, direccion, cod_postal, fecha_nac, saldo_actual)
	values((select id_usuario from RANDOM.Usuario where username = @username), @nombre, @apellido, @dni, @mail, @telefono, @direccion_completa, @cod_postal, @fecha_nac, 10)
commit
go


--Modificacion de cliente: RANDOM.ModificarCliente (todos los parametros son necesarios)
create procedure RANDOM.ModificarCliente @id_usuario bigint output, @nombre nvarchar(255) output, @apellido nvarchar(255) output, @dni numeric(18,0) output, @mail nvarchar(100) output, @telefono numeric (18,0) output, @direccion nvarchar(255) output, @cod_postal numeric(18,0) output, @fecha_nac datetime output
as
begin transaction
	if exists (select dni from RANDOM.Cliente where dni = @dni and id_usuario != @id_usuario)
	begin
		rollback
		raiserror('El DNI ya esta registrado para otro cliente', 16, 1)
	end	
	else
	begin
		if exists (select telefono from RANDOM.Cliente where telefono = @telefono and id_usuario != @id_usuario)
		begin
			rollback
			raiserror('El telefono ya esta registrado para otro cliente', 16, 1)
		end
		else
		begin
			if exists (select mail from RANDOM.Cliente where mail = @mail and id_usuario != @id_usuario)
			begin
			rollback
			raiserror('El mail ya está registrado para otro cliente', 16, 1)
			end
		end
	end	
			
	update RANDOM.Cliente
	set nombre = @nombre,
	apellido = @apellido,
	dni = @dni,
	mail = @mail,
	telefono = @telefono,
	direccion = @direccion,
	cod_postal = @cod_postal,
	fecha_nac = @fecha_nac 
	where id_usuario = @id_usuario
commit
go


--Agregar cliente x ciudad: RANDOM.AgregarClientePorCiudad (todos los parametros son necesarios)
create procedure RANDOM.AgregarClientePorCiudad @id_cliente bigint output, @id_ciudad bigint output
as
begin
	insert into RANDOM.Cliente_x_Ciudad(id_cliente, id_ciudad)
	values(@id_cliente , @id_ciudad)
end
go

--Quitar cliente x ciudad: RANDOM.QuitarClientePorCiudad (todos los parametros son necesarios)
create procedure RANDOM.QuitarClientePorCiudad @id_cliente bigint output, @id_ciudad bigint output
as
begin
	delete from RANDOM.Cliente_x_Ciudad
	where id_cliente = @id_cliente and id_ciudad = @id_ciudad
end
go