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


/*Estos dos capaz combiene hacerlos funciones para que validen que no existan datos repetidos y demas, otra opcion es validar eso desde c#, pero creo que sería mejor hacerlo aca*/
--Registro de cliente
create procedure RANDOM.RegistrarCliente @username nvchar(255), @password nvchar(255), @nombre nvchar(255), @apellidos nvchar(255), @dni numeric(18,0), @mail nvchar(100), @telefono numeric (18,0), @direccion nvchar(255), @cod_postal numeric(18,0), @fecha_nac datetime
as
begin
	insert into RANDOM.Usuario(username, password, id_rol, dni_cuit, tipo, estado, fallas)
	values(@username, @password, select id_rol from RANDOM.rol where descripcion = 'Cliente', @dni, 'Cliente', 1, 0)
	insert into RANDOM.Cliente(nombre, apellido, dni, mail, telefono, direccion, cod_postal, fecha_nac, saldo_actual)
	values(@nombre, @apellidos, @dni, @mail, @telefono, @direccion, @cod_postal, @fecha_nac, 10)
end
go

--Registro de un proveedor
create procedure RANDOM.RegistrarProveedor @username nvchar(255), @password nvchar(255), @razon_social nvchar(255), @mail nvchar(100), @telefono numeric (18,0), @direccion nvchar(255), @cod_postal numeric(18,0), @id_ciudad bigint, @cuit nvchar(20), @id_rubro bigint, @contacto_nombre nvchar(100)
as
begin
	insert into RANDOM.Usuario(username, password, id_rol, dni_cuit, tipo, estado, fallas)
	values(@username, @password, select id_rol from RANDOM.rol where descripcion = 'Proveedor', @dni, 'Proveedor', 1, 0)
	insert into RANDOM.Proveedor(razon_social, mail, telefono, direccion, cod_postal, id_ciudad, cuit, id_rubro, contacto_nombre)
	values(@razon_social, @mail, @telefono, @direccion, @cod_postal, @id_ciudad, @cuit, @id_rubro, @contacto_nombre)
end
go
/**********************************************************************************************************************************************************************************/
