/** Cambia el rol de los clientes a NULL cuando se deshabilita dicho rol en la tabla rol **/
create trigger inhabilitar_rol ON RANDOM.Rol
after update
as
begin
       if exists (select 1 FROM inserted i where i.estado = 0)
               update RANDOM.Usuario
               set id_rol = case when exists (select 1 FROM inserted i, RANDOM.Usuario u where i.id_rol = u.id_rol AND i.estado = 0)
                                       then NULL
                                       end
end
go

/** Cambia el estado a 0 cuando un usuario llega a 3 fallas **/
create trigger tres_fallas ON RANDOM.Usuario
after update
as
begin
       if exists(select 1 from inserted i where i.fallas = 3)
       update RANDOM.Usuario
       set estado = case when exists(select 1 from inserted i, RANDOM.Usuario u where i.id_usuario = u.id_usuario AND u.fallas = 3) then 1
       end
end
go