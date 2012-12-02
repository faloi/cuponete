--Modificacion de usuario (username y password)
create procedure RANDOM.ModificarUsuario @id_usuario bigint, @username nvarchar(255), @password nvarchar(255)
as
begin transaction
	if (exists (select username from RANDOM.Usuario where @username = username)) and ((select username from RANDOM.Usuario where id_usuario = @id_usuario) != @username)
	begin
		rollback
		raiserror('El nombre de usuario ya existe', 16, 1)
	end	
				
	update RANDOM.Usuario
	set username = @username where id_usuario = @id_usuario
	update RANDOM.Usuario
	set password = @password where id_usuario = @id_usuario
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
