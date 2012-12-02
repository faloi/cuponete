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