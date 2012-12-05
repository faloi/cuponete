
--Agregar un rol: RANDOM.AgregarRol (el parametro @id_rol es solo de output, para usarlo en RANDOM.AgregarFuncionalidadPorRol)
create procedure RANDOM.AgregarRol @id_rol bigint out, @descripcion nvarchar(50) out
as
begin transaction
	if exists (select descripcion from RANDOM.Rol where @descripcion = descripcion)
	begin
		rollback
		raiserror('El nombre de rol ya existe', 16, 1)
		return
	end	

	insert into RANDOM.Rol(descripcion, estado)
	values(@descripcion, 1)
	
	set @id_rol = (select id_rol from RANDOM.Rol where descripcion = @descripcion)
commit
go


--Agregar funcionalidades por rol: RANDOM.AgregarFuncionalidadPorRol (todos los parametros necesarios)
create procedure RANDOM.AgregarFuncionalidadPorRol @id_funcionalidad bigint output, @id_rol bigint output
as
begin
	insert into RANDOM.Funcionalidad_x_Rol(id_rol, id_funcionalidad)
	values(@id_rol, @id_funcionalidad)
end
go


--Quitar funcionalidades por rol: RANDOM.QuitarFuncionalidadPorRol (todos los parametros necesarios)
create procedure RANDOM.QuitarFuncionalidadPorRol @id_funcionalidad bigint output, @id_rol bigint output
as
begin
	delete from RANDOM.Funcionalidad_x_Rol
	where id_rol = @id_rol and id_funcionalidad = @id_funcionalidad
end
go

--Cambiar nombre de rol: RANDOM.CambiarNombreRol (el parametro @id_rol es solo de output, para usarlo en RANDOM.AgregarFuncionalidadPorRol)
create procedure RANDOM.CambiarNombreRol @id_rol bigint output, @descripcion nvarchar(50) output
as
begin transaction
	if exists (select descripcion from RANDOM.Rol where @descripcion = descripcion)
	begin
		rollback
		raiserror('El nombre de rol ya existe', 16, 1)
		return
	end	

	select @id_rol = id_rol from RANDOM.Rol where descripcion = @descripcion
	
	update RANDOM.Rol
	set descripcion = @descripcion
	where id_rol = @id_rol
commit
go

--Habilitar rol: RANDOM.HabilitarRol (parametro necesario)
create procedure RANDOM.HabilitarRol @descripcion nvarchar(50) output
as
begin
	update RANDOM.Rol
	set estado = 1 where @descripcion = descripcion
end
go

--Deshabilitar rol: RANDOM.DeshabilitarRol (parametro necesario)
create procedure RANDOM.DeshabilitarRol @descripcion nvarchar(50) output
as
begin
	update RANDOM.Rol
	set estado = 0 where @descripcion = descripcion
end
go



