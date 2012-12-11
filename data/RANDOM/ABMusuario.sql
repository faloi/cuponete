
--Modificacion de usuario (username y password): RANDOM.ModificarUsuario (todos los parametros son necesarios)
create procedure RANDOM.ModificarUsuario @id_usuario bigint output, @username nvarchar(255) output, @password nvarchar(255) output
as
begin transaction
	if exists (select username from RANDOM.Usuario where @username = username and id_usuario != @id_usuario)
	begin
		rollback
		raiserror('El nombre de usuario ya existe', 16, 1)
		return
	end	
				
	update RANDOM.Usuario
	set username = @username,
	password = @password 
	where id_usuario = @id_usuario
commit
go


--Habilitar usuario: RANDOM.HabilitarUsuario (parametro necesario)
create procedure RANDOM.HabilitarUsuario @id_usuario bigint output
as
begin
	update RANDOM.Usuario
	set estado = 1 
	where @id_usuario = id_usuario
end
go

--Deshabilitar usuario: RANDOM.DeshabilitarUsuario (parametro necesario)
create procedure RANDOM.DeshabilitarUsuario @id_usuario bigint output
as
begin
	update RANDOM.Usuario
	set estado = 0 
	where @id_usuario = id_usuario
end
go


--Cambiar rol: RANDOM.CambiarRol (todos los parametros son necesarios)
create procedure RANDOM.CambiarRol @id_usuario bigint out, @id_rol bigint out
as
begin transaction	
	if (select id_rol from RANDOM.Usuario where @id_usuario = id_usuario) = @id_rol
	begin
		rollback
		raiserror('El usuario tiene ese rol en la actualidad', 16, 1)
		return
	end	
	
	/*if ((select id_rol from RANDOM.Usuario where id_usuario = @id_usuario) = NULL)
	begin
		if ((exists (select 1 from RANDOM.Usuario u inner join RANDOM.Cliente c on u.id_usuario = c.id_usuario)) and @id_rol != 2 /*2 es cliente*/)
		begin
			delete from RANDOM.Cliente_x_Ciudad where id_cliente = @id_usuario
			delete from RANDOM.Cliente where id_usuario = @id_usuario
		end
		
		if ((exists (select 1 from RANDOM.Usuario u inner join RANDOM.Proveedor p on u.id_usuario = p.id_usuario)) and @id_rol != 3 /*3 es proveedor*/)
		begin
			delete from RANDOM.Proveedor where id_usuario = @id_usuario
		end
	end
	else
	begin
		if ((select id_rol from RANDOM.Usuario where id_usuario = @id_usuario) = 2 /*2 es cliente*/)
		begin
			delete from RANDOM.Cliente_x_Ciudad where id_cliente = @id_usuario
			delete from RANDOM.Cliente where id_usuario = @id_usuario
		end
		
		if ((select id_rol from RANDOM.Usuario where id_usuario = @id_usuario) = 3 /*3 es proveedor*/)
		begin
			delete from RANDOM.Proveedor where id_usuario = @id_usuario
		end
	end*/
	
	update RANDOM.Usuario
	set id_rol = @id_rol
	where id_usuario = @id_usuario
	
commit
go


--Incrementar las fallas que tiene un usuario: RANDOM.IncrementarFallas (parametro necesario)
create procedure RANDOM.IncrementarFallas @id_usuario bigint output
as
begin 
      update RANDOM.Usuario
      set fallas = fallas + 1
      from RANDOM.Usuario
      where id_usuario = @id_usuario
end
go


--Reiniciar las fallas que tiene un usuario: RANDOM.ReiniciarFallas (parametro necesario)
create procedure RANDOM.ReiniciarFallas @id_usuario bigint output
as
begin 
      update RANDOM.Usuario
      set fallas = 0
      from RANDOM.Usuario
      where id_usuario = @id_usuario
end
go
