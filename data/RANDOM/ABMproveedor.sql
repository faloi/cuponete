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