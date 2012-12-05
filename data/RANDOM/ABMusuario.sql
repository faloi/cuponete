--Modificacion de usuario (username y password): RANDOM.ModificarUsuario (todos los parametros son necesarios)
create procedure RANDOM.ModificarUsuario @id_usuario bigint output, @username nvarchar(255) output, @password nvarchar(255) output
as
begin transaction
	if exists (select username from RANDOM.Usuario where @username = username and id_usuario != @id_usuario)
	begin
		rollback
		raiserror('El nombre de usuario ya existe', 16, 1)
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
