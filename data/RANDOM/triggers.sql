/** Cambia el rol de los clientes a NULL cuando se deshabilita dicho rol en la tabla rol **/
create trigger RANDOM.inhabilitar_rol ON RANDOM.Rol
after update
as
begin
	if exists (select 1 from inserted where estado = 0)
	begin
	    
	    if (select estado from RANDOM.Rol where id_rol = 2 /*2 es cliente*/) = 0
		begin
			delete from RANDOM.Cliente_x_Ciudad
			delete from RANDOM.Cliente
		end
	
		if (select estado from RANDOM.Rol where id_rol = 2 /*3 es proveedor*/) = 0 
		begin
			delete from RANDOM.Proveedor
		end
	      
		update RANDOM.Usuario
		set id_rol = NULL
		where id_rol = (select id_rol from inserted)
	end           
end
go
