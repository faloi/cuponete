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