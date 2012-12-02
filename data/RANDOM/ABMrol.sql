
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

