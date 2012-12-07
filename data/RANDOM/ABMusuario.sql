
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


--Cambiar rol: RANDOM.CambiarRol (parametros necesarios. Es importante, despues del cambio a rol de proveedor o cliente, llamar al procedure registrar de dicho rol)
create procedure RANDOM.CambiarRol @id_usuario bigint out, @id_rol bigint out
as
begin transaction
	if (select id_rol from RANDOM.Usuario where @id_usuario = id_usuario) = @id_rol
	begin
		rollback
		raiserror('El usuario tiene ese rol en la actualidad', 16, 1)
		return
	end	
	
	if ((select id_rol from RANDOM.Usuario where id_usuario = @id_usuario) = 2 /*2 es cliente*/)
	begin
		delete from RANDOM.Cliente_x_Ciudad where id_cliente = @id_usuario
		delete from RANDOM.Cliente where id_usuario = @id_usuario
	end
	
	if ((select id_rol from RANDOM.Usuario where id_usuario = @id_usuario) = 3 /*3 es proveedor*/)
	begin
		delete from RANDOM.Proveedor where id_usuario = @id_usuario
	end
	
	update RANDOM.Usuario
	set id_rol = @id_rol
	where id_usuario = @id_usuario
	
commit
go


--Incrementar las fallas que tiene un usuario: RANDOM.IncrementarFallas (parametro necesario)
CREATE PROCEDURE RANDOM.IncrementarFallas @id_usuario bigint output
AS
BEGIN 
      UPDATE RANDOM.Usuario
      SET 
             fallas    = fallas+1
      FROM   RANDOM.Usuario
      WHERE  
      id_usuario    = @id_usuario                   

END
GO
