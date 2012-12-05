--Registro de un proveedor: RANDOM.RegistrarProveedor (todos los parametros son necesarios)
create procedure RANDOM.RegistrarProveedor @username nvarchar(255) output, @password nvarchar(255) output, @razon_social nvarchar(255) output, @mail nvarchar(100) output, @telefono numeric (18,0) output, @direccion nvarchar(255) output, @cod_postal numeric(18,0) output, @id_ciudad bigint output, @cuit nvarchar(20) output, @id_rubro bigint output, @contacto_nombre nvarchar(100) output
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

	insert into RANDOM.Usuario(username, password, id_rol, estado, fallas)
	values(@username, @password, 1, 1, 0)
	insert into RANDOM.Proveedor(id_usuario, razon_social, mail, telefono, direccion, cod_postal, id_ciudad, cuit, id_rubro, contacto_nombre)
	values((select id_usuario from RANDOM.Usuario where username = @username), @razon_social, @mail, @telefono, @direccion, @cod_postal, @id_ciudad, @cuit, @id_rubro, @contacto_nombre)
commit
go


--Modificacion de un proveedor: RANDOM.ModificarProveedor (todos los parametros son necesarios)
create procedure RANDOM.ModificarProveedor @id_usuario bigint output, @razon_social nvarchar(255) output, @mail nvarchar(100) output, @telefono numeric (18,0) output, @direccion nvarchar(255) output, @cod_postal numeric(18,0) output, @id_ciudad bigint output, @cuit nvarchar(20) output, @id_rubro bigint output, @contacto_nombre nvarchar(100) output
as
begin transaction
	if (exists (select razon_social from RANDOM.Proveedor where razon_social = @razon_social)) and ((select razon_social from RANDOM.Proveedor where id_usuario = @id_usuario) != @razon_social)
	begin
		rollback
		raiserror('La razon social ya esta registrada para otro proveedor', 16, 1)
	end	
	else
	begin
		if exists (select cuit from RANDOM.Proveedor where cuit = @cuit and id_usuario != @id_usuario)
		begin
			rollback
			raiserror('El CUIT ya esta registrado para otro proveedor', 16, 1)
		end
		else
		begin
			if exists (select telefono from RANDOM.Proveedor where telefono = @telefono and id_usuario != @id_usuario)
			begin
				rollback
				raiserror('El telefono ya esta registrado para otro proveedor', 16, 1)
			end
			else
			begin
				if exists (select mail from RANDOM.Proveedor where mail = @mail and id_usuario != @id_usuario)
				begin
					rollback
					raiserror('El mail ya está registrado para otro proveedor', 16, 1)
				end
			end
		end
	end	

	update RANDOM.Proveedor
	set	razon_social = @razon_social, 
	mail = @mail, 
	telefono = @telefono, 
	direccion = @direccion, 
	cod_postal = @cod_postal, 
	id_ciudad = @id_ciudad, 
	cuit = @cuit, 
	id_rubro = @id_rubro, 
	contacto_nombre = @contacto_nombre
	where id_usuario = @id_usuario
commit
go