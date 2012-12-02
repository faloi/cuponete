--Registro de cliente
create procedure RANDOM.RegistrarCliente @username nvarchar(255), @password nvarchar(255), @nombre nvarchar(255), @apellidos nvarchar(255), @dni numeric(18,0), @mail nvarchar(100), @telefono numeric (18,0), @direccion nvarchar(255), @cod_postal numeric(18,0), @fecha_nac datetime
as
begin transaction
	if exists (select username from RANDOM.Usuario where @username = username)
	begin
		rollback
		raiserror('El nombre de usuario ya existe', 16, 1)
	end	
	else
	begin
		if exists (select dni from RANDOM.Cliente where dni = @dni)
		begin
			rollback
			raiserror('El DNI ya esta registrado para otro cliente', 16, 1)
		end	
		else
		begin
			if exists (select telefono from RANDOM.Cliente where telefono = @telefono)
			begin
				rollback
				raiserror('El telefono ya esta registrado para otro cliente', 16, 1)
			end
			else
			begin
				if exists (select mail from RANDOM.Cliente where mail = @mail)
				begin
				rollback
				raiserror('El mail ya está registrado para otro cliente', 16, 1)
				end
			end
		end	
	end
			
	insert into RANDOM.Usuario(username, password, id_rol, dni_cuit, tipo, estado, fallas)
	values(@username, @password, (select id_rol from RANDOM.rol where descripcion = 'Cliente'), @dni, 'Cliente', 1, 0)
	insert into RANDOM.Cliente(id_usuario, nombre, apellido, dni, mail, telefono, direccion, cod_postal, fecha_nac, saldo_actual)
	values((select id_usuario from RANDOM.Usuario where username = @username), @nombre, @apellidos, @dni, @mail, @telefono, @direccion, @cod_postal, @fecha_nac, 10)
commit
go


--Modificacion de cliente
create procedure RANDOM.ModificarCliente @id_usuario bigint, @nombre nvarchar(255), @apellidos nvarchar(255), @dni numeric(18,0), @mail nvarchar(100), @telefono numeric (18,0), @direccion nvarchar(255), @cod_postal numeric(18,0), @fecha_nac datetime
as
begin transaction
	if (exists (select dni from RANDOM.Cliente where dni = @dni)) and ((select dni from RANDOM.Cliente where id_usuario = @id_usuario) != @dni)
	begin
		rollback
		raiserror('El DNI ya esta registrado para otro cliente', 16, 1)
	end	
	else
	begin
		if (exists (select telefono from RANDOM.Cliente where telefono = @telefono)) and ((select telefono from RANDOM.Cliente where id_usuario = @id_usuario) != @telefono)
		begin
			rollback
			raiserror('El telefono ya esta registrado para otro cliente', 16, 1)
		end
		else
		begin
			if (exists (select mail from RANDOM.Cliente where mail = @mail)) and ((select mail from RANDOM.Cliente where id_usuario = @id_usuario) != @mail)
			begin
			rollback
			raiserror('El mail ya está registrado para otro cliente', 16, 1)
			end
		end
	end	
			
	update RANDOM.Cliente
	(id_usuario, nombre, apellido, dni, mail, telefono, direccion, cod_postal, fecha_nac, saldo_actual)
	values((select id_usuario from RANDOM.Usuario where username = @username), @nombre, @apellidos, @dni, @mail, @telefono, @direccion, @cod_postal, @fecha_nac, 10)
commit
go


--Agregar cliente x ciudad
create procedure RANDOM.AgregarClientePorCiudad @id_cliente bigint, @id_ciudad bigint
as
begin
	insert into RANDOM.Cliente_x_Ciudad(id_cliente, id_ciudad)
	values(@id_cliente , @id_ciudad)
end
go

--Quitar cliente x ciudad
create procedure RANDOM.QuitarClientePorCiudad @id_cliente bigint, @id_ciudad bigint
as
begin
	delete from RANDOM.Cliente_x_Ciudad
	where id_cliente = @id_cliente and id_ciudad = @id_ciudad
end
go