--Incrementar las fallas que tiene un usuario
CREATE PROCEDURE RANDOM.IncrementarFallas
       @userId bigint
AS
BEGIN 
      UPDATE RANDOM.Usuario
      SET 
             fallas    = fallas+1
      FROM   RANDOM.Usuario
      WHERE  
      id_usuario    = @userId                   

END
GO

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

--Registro de un proveedor
create procedure RANDOM.RegistrarProveedor @username nvarchar(255), @password nvarchar(255), @razon_social nvarchar(255), @mail nvarchar(100), @telefono numeric (18,0), @direccion nvarchar(255), @cod_postal numeric(18,0), @id_ciudad bigint, @cuit nvarchar(20), @id_rubro bigint, @contacto_nombre nvarchar(100)
as
begin transaction
	if exists (select username from RANDOM.Usuario where @username = username)
	begin
		rollback
		raiserror('El nombre de usuario ya existe', 16, 1)
	end	
	else
	begin
		if exists (select razon_social from RANDOM.Proveedor where razon_social = @razon_social)
		begin
			rollback
			raiserror('La razon social ya esta registrada para otro proveedor', 16, 1)
		end	
		else
		begin
			if exists (select cuit from RANDOM.Proveedor where cuit = @cuit)
			begin
				rollback
				raiserror('El CUIT ya esta registrado para otro proveedor', 16, 1)
			end
			else
			begin
				if exists (select telefono from RANDOM.Proveedor where telefono = @telefono)
				begin
					rollback
					raiserror('El telefono ya esta registrado para otro proveedor', 16, 1)
				end
				else
				begin
					if exists (select mail from RANDOM.Proveedor where mail = @mail)
					begin
						rollback
						raiserror('El mail ya está registrado para otro proveedor', 16, 1)
					end
				end
			end
		end	
	end

	insert into RANDOM.Usuario(username, password, id_rol, dni_cuit, tipo, estado, fallas)
	values(@username, @password, (select id_rol from RANDOM.rol where descripcion = 'Proveedor'), @cuit, 'Proveedor', 1, 0)
	insert into RANDOM.Proveedor(id_usuario, razon_social, mail, telefono, direccion, cod_postal, id_ciudad, cuit, id_rubro, contacto_nombre)
	values((select id_usuario from RANDOM.Usuario where username = @username), @razon_social, @mail, @telefono, @direccion, @cod_postal, @id_ciudad, @cuit, @id_rubro, @contacto_nombre)
commit
go


--Habilitar usuario
create procedure RANDOM.HabilitarUsuario @username nvarchar(255)
as
begin
	update RANDOM.Usuario
	set estado = 1 where @username = username
end
go

--Deshabilitar usuario
create procedure RANDOM.DeshabilitarUsuario @username nvarchar(255)
as
begin
	update RANDOM.Usuario
	set estado = 0 where @username = username
end
go


--Agregar un rol
create procedure RANDOM.AgregarRol @descripcion nvarchar(50)
as
begin transaction
	if exists (select descripcion from RANDOM.Rol where @descripcion = descripcion)
	begin
		rollback
		raiserror('El nombre de rol ya existe', 16, 1)
	end	

	insert into RANDOM.Rol(descripcion, estado)
	values(@descripcion, 1)
commit
go


--Agregar funcionalidades por rol
create procedure RANDOM.AgregarFuncionalidadPorRol @id_funcionalidad bigint, @id_rol bigint
as
begin
	insert into RANDOM.Funcionalidad_x_Rol(id_rol, id_funcionalidad)
	values(@id_rol, @id_funcionalidad)
end
go


--Quitar funcionalidades por rol
create procedure RANDOM.QuitarFuncionalidadPorRol @id_funcionalidad bigint, @id_rol bigint
as
begin
	delete from RANDOM.Funcionalidad_x_Rol
	where id_rol = @id_rol and id_funcionalidad = @id_funcionalidad
end
go


--Habilitar rol
create procedure RANDOM.HabilitarRol @nombre_rol nvarchar(50)
as
begin
	update RANDOM.Rol
	set estado = 1 where @nombre_rol = descripcion
end
go

--Deshabilitar rol
create procedure RANDOM.DeshabilitarRol @nombre_rol nvarchar(50)
as
begin
	update RANDOM.Rol
	set estado = 0 where @nombre_rol = descripcion
end
go

