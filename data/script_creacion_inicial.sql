USE [GD2C2012]
GO





/***** CREAR ESQUEMA *****/
CREATE SCHEMA RANDOM AUTHORIZATION gd
GO





/***** CREAR TABLAS *****/
-- Tabla Ciudad
CREATE TABLE RANDOM.Ciudad(
	id_ciudad bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	descripcion nvarchar(255) NOT NULL)
GO

-- Tabla Funcionalidad
CREATE TABLE RANDOM.Funcionalidad(
	id_funcionalidad bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	descripcion nvarchar(255) NOT NULL)
GO

-- Tabla Forma_de_Pago
CREATE TABLE RANDOM.Forma_de_Pago(
	id_forma_pago bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	descripcion nvarchar(255) NOT NULL)
GO

-- Tabla Rubro
CREATE TABLE RANDOM.Rubro(
	id_rubro bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	desc_rubro nvarchar(100) NOT NULL)

-- Tabla Rol
CREATE TABLE RANDOM.Rol(
	id_rol bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	descripcion nvarchar(50) NOT NULL,
	estado numeric(1, 0) NOT NULL)
GO

-- Tabla Funcionalidad_x_Rol
CREATE TABLE RANDOM.Funcionalidad_x_Rol(
	id_funcionalidad bigint NOT NULL REFERENCES RANDOM.Funcionalidad(id_funcionalidad),
	id_rol bigint NOT NULL REFERENCES RANDOM.Rol(id_rol),
CONSTRAINT PK_Funcionalidad_x_Rol PRIMARY KEY CLUSTERED(id_funcionalidad, id_rol))
GO

-- Tabla Tipo_Usuario
CREATE TABLE RANDOM.Tipo_Usuario(
	id_tipo_usuario bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	descripcion nvarchar(50) NOT NULL)
GO

-- Talbla Usuario
CREATE TABLE RANDOM.Usuario(
	id_usuario bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	username nvarchar(255) UNIQUE NOT NULL,
	password nvarchar(255) NOT NULL,
	id_rol bigint REFERENCES RANDOM.Rol(id_rol),
	id_tipo_usuario bigint REFERENCES RANDOM.Tipo_Usuario(id_tipo_usuario),
	dni_cuit nvarchar(18),
	estado numeric(1, 0) NOT NULL,
	fallas numeric(1, 0) NOT NULL)
GO


 -- Tabla Proveedor
CREATE TABLE RANDOM.Proveedor(
	id_usuario bigint PRIMARY KEY NOT NULL REFERENCES RANDOM.Usuario(id_usuario),
	razon_social nvarchar(100) UNIQUE NOT NULL,
	mail nvarchar(100),
	telefono numeric(18, 0) UNIQUE NOT NULL,
	direccion nvarchar(100) NOT NULL,
	cod_postal numeric(10, 0),
	id_ciudad bigint NOT NULL REFERENCES RANDOM.Ciudad(id_ciudad),
	cuit nvarchar(20) UNIQUE NOT NULL,
	id_rubro bigint NOT NULL REFERENCES RANDOM.Rubro(id_rubro),
	contacto_nombre nvarchar(100) NULL)
GO

-- Tabla Gift_Card
CREATE TABLE RANDOM.Gift_Card(
	id_gift_card bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	fecha datetime NOT NULL,
	monto numeric(18, 2) NOT NULL,
	id_usuario_origen bigint NOT NULL REFERENCES RANDOM.Usuario(id_usuario),
	id_usuario_destino bigint NOT NULL REFERENCES RANDOM.Usuario(id_usuario))
GO

-- Tabla Cliente
CREATE TABLE RANDOM.Cliente(
	id_usuario bigint PRIMARY KEY NOT NULL REFERENCES RANDOM.Usuario(id_usuario),
	nombre nvarchar(255) NOT NULL,
	apellido nvarchar(255) NOT NULL,
	dni numeric(18, 0) NOT NULL,
	mail nvarchar(100) NOT NULL,
	telefono numeric(18, 0) UNIQUE NOT NULL,
	direccion nvarchar(255) NOT NULL,
	cod_postal numeric(18, 0) NULL,
	fecha_nac datetime NOT NULL,
	saldo_actual bigint DEFAULT 0 NOT NULL )
GO

-- Tabla Factura
CREATE TABLE RANDOM.Factura(
	id_factura bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	nro_factura numeric(18, 0) NOT NULL,
	fecha datetime NOT NULL,
	id_proveedor bigint NOT NULL REFERENCES RANDOM.Usuario(id_usuario))
GO

-- Tabla Cupon
CREATE TABLE RANDOM.Cupon(
	id_cupon bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	descripcion nvarchar(255) NOT NULL,
	fec_publicacion datetime NOT NULL,
	fec_venc_publicacion datetime NULL,
	fec_venc_consumo datetime NOT NULL,
	precio_real numeric(18, 2) NOT NULL,
	precio_ficticio numeric(18, 2) NOT NULL,
	id_proveedor bigint NOT NULL REFERENCES RANDOM.Usuario(id_usuario),
	cant_disp numeric(18, 0) NOT NULL,
	max_compra_por_usuario numeric(18, 0) DEFAULT 1 NOT NULL,
	publicado numeric(1, 0) NOT NULL)
GO

-- Tabla Credito
CREATE TABLE RANDOM.Credito(
	id_credito bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	id_cliente bigint NOT NULL REFERENCES RANDOM.Usuario(id_usuario),
	carga_credito bigint NOT NULL,
	fechA datetime NOT NULL,
	id_forma_pago bigint NOT NULL REFERENCES RANDOM.Forma_de_Pago(id_forma_pago),
	nro_tarjeta numeric(15, 0),
	cod_seguridad_tarjeta numeric(3, 0),
	fecha_vto_tarjeta nvarchar(5))
GO

-- Tabla Cliente_x_Ciudad
CREATE TABLE RANDOM.Cliente_x_Ciudad(
	id_cliente bigint NOT NULL REFERENCES RANDOM.Cliente(id_usuario),
	id_ciudad bigint NOT NULL REFERENCES RANDOM.Ciudad(id_ciudad),
CONSTRAINT PK_Cliente_x_Ciudad PRIMARY KEY CLUSTERED(id_cliente, id_ciudad))
GO

-- Tabla Cupon_x_Ciudad
CREATE TABLE RANDOM.Cupon_x_ciudad(
	id_cupon bigint NOT NULL REFERENCES RANDOM.Cupon(id_cupon),
	id_ciudad bigint NOT NULL REFERENCES RANDOM.Ciudad(id_ciudad),
CONSTRAINT PK_Cupon_x_ciudad PRIMARY KEY CLUSTERED(id_cupon, id_ciudad))
GO

-- Tabla Cupon_Comprado
CREATE TABLE RANDOM.Cupon_Comprado(
	id_compra bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	codigo_compra nvarchar(50) NOT NULL,
	fecha_compra [datetime] NOT NULL,
	id_cupon bigint NOT NULL REFERENCES RANDOM.Cupon(id_cupon),
	id_cliente bigint NOT NULL REFERENCES RANDOM.Usuario(id_usuario))
GO

-- Tabla Cupon_Canjeado
CREATE TABLE RANDOM.Cupon_Canjeado(
	id_canje bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	fecha_canje datetime NOT NULL,
	id_compra bigint NOT NULL REFERENCES RANDOM.Cupon_Comprado(id_compra),
	id_cliente bigint NOT NULL REFERENCES RANDOM.Usuario(id_usuario),
	facturado int NULL)
GO

-- Tabla Cupon_Devuelto
CREATE TABLE RANDOM.Cupon_Devuelto(
	id_devolucion bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	fecha_devolucion datetime NOT NULL,
	id_cliente bigint NOT NULL REFERENCES RANDOM.Usuario(id_usuario),
	id_compra bigint NOT NULL REFERENCES RANDOM.Cupon_Comprado(id_compra),
	codigo_compra nvarchar(50) NOT NULL,
	motivo_devolucion nvarchar(255) NOT NULL)
GO

-- Tabla Renglon_Factura
CREATE TABLE RANDOM.Renglon_Factura(
	id_cupon_canjeado bigint NOT NULL REFERENCES RANDOM.Cupon_Canjeado(id_canje),
	id_factura bigint NOT NULL REFERENCES RANDOM.Factura(id_factura),
 CONSTRAINT [PK_Renglon_Factura] PRIMARY KEY CLUSTERED (id_cupon_canjeado, id_factura))
GO



/***** MIGRACION *****/
--insert de roles
INSERT INTO RANDOM.Rol (descripcion,estado) VALUES ('Administrador',1);
INSERT INTO RANDOM.Rol (descripcion,estado) VALUES ('Cliente',1);
INSERT INTO RANDOM.Rol (descripcion,estado) VALUES ('Proveedor',1);

--insert de funcionalidades
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Cargar Crédito');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Comprar GiftCard');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Comprar Cupón');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Pedir Devolución');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Historial de Compra de Cupones');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Armar Cupón');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Registro de consumo de Cupón');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Publicar Cupón');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Facturación a Proveedor');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Listado Estadístico');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('ABM Cliente');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('ABM Proveedor');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('ABM Rol');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Modificar Usuario');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Cambiar Password');

--insert de funcionalidad_x_rol
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (15,3);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (15,2);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (15,1);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (14,1);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (13,1);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (12,1);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (11,1);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (10,1);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (9,1);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (8,1);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (7,1);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (6,1);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (5,1);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (4,1);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (3,1);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (2,1);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (1,1);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (1,2);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (2,2);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (3,2);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (4,2);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (5,2);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (6,3);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (7,3);

--insert de tipo_usuario
INSERT INTO RANDOM.Tipo_Usuario (descripcion) VALUES ('Administrador');
INSERT INTO RANDOM.Tipo_Usuario (descripcion) VALUES ('Cliente');
INSERT INTO RANDOM.Tipo_Usuario (descripcion) VALUES ('Proveedor');

--insert de usuarios clientes
INSERT INTO  RANDOM.Usuario(username,password,id_rol,id_tipo_usuario,estado,dni_cuit,fallas)
(SELECT DISTINCT ('u'+CONVERT(nvarchar,Cli_Dni)), '9b8769a4a742959a2d0298c36fb70623f2dfacda8436237df08d8dfd5b37374c',2,2,1,CONVERT(nvarchar,Cli_Dni),0
FROM gd_esquema.Maestra
WHERE Cli_Dni IS not null)

--insert de clientes
INSERT INTO RANDOM.Cliente (id_usuario,apellido,nombre,dni,mail,telefono,direccion,cod_postal,fecha_nac)(
SELECT DISTINCT us.id_usuario,Cli_Apellido,Cli_Nombre,Cli_Dni,Cli_Mail,Cli_Telefono,Cli_Direccion,0,Cli_Fecha_Nac
FROM gd_esquema.Maestra ma
LEFT JOIN RANDOM.Usuario us ON (us.dni_cuit = ma.Cli_Dni)
WHERE Cli_Dni IS NOT NULL);

--insert de rubro
INSERT INTO RANDOM.Rubro (desc_rubro) (
SELECT DISTINCT ma.Provee_Rubro 
FROM gd_esquema.Maestra ma 
WHERE ma.Provee_Rubro IS NOT NULL);

--insert de usuarios proveedor
INSERT INTO RANDOM.Usuario (username, password, dni_cuit, id_rol,id_tipo_usuario, estado, fallas)
(SELECT DISTINCT ('u'+Provee_Cuit), '9b8769a4a742959a2d0298c36fb70623f2dfacda8436237df08d8dfd5b37374c', Provee_Cuit, 3,3,1, 0  FROM gd_esquema.Maestra
WHERE Provee_RS IS NOT NULL);

--insert de ciudad
INSERT INTO RANDOM.Ciudad (descripcion)
(SELECT DISTINCT Provee_Ciudad FROM gd_esquema.Maestra
WHERE Provee_Ciudad IS NOT NULL);

INSERT INTO RANDOM.Ciudad(descripcion)
(SELECT DISTINCT Cli_Ciudad FROM gd_esquema.Maestra
WHERE Cli_Ciudad IS NOT NULL
and Cli_Ciudad NOT IN  (SELECT DISTINCT descripcion FROM RANDOM.Ciudad));

--insert de proveedores
INSERT INTO RANDOM.Proveedor (id_usuario, razon_social,mail,telefono, 
direccion,cod_postal,id_ciudad, cuit, id_rubro,contacto_nombre)
(SELECT DISTINCT usu.id_usuario,Provee_RS,'', Provee_Telefono, Provee_Dom,0, ciu.id_ciudad, ma.Provee_CUIT , rub.id_rubro,'' 
 FROM gd_esquema.Maestra ma
 LEFT JOIN RANDOM.Usuario usu ON (usu.dni_cuit = ma.Provee_CUIT)
 LEFT JOIN RANDOM.Ciudad ciu ON (ciu.descripcion = ma.Provee_Ciudad)
 LEFT JOIN RANDOM.Rubro rub ON (rub.desc_rubro = ma.Provee_Rubro)
 WHERE ma.Provee_RS IS NOT NULL);
 
--insert cupones
INSERT INTO RANDOM.Cupon (descripcion, fec_publicacion, fec_venc_consumo, fec_venc_publicacion, precio_real, precio_ficticio, id_proveedor, cant_disp, publicado)
SELECT Groupon_Descripcion descripcion, Groupon_Fecha fec_publicacion, Groupon_Fecha_Venc fec_venc_consumo, Groupon_Fecha_Venc fec_venc_publicacion, Groupon_Precio precio_real, Groupon_Precio_Ficticio precio_ficticio, prov.id_usuario id_proveedor, Groupon_Cantidad cant_disp,0 publicado
FROM gd_esquema.Maestra ma
LEFT JOIN RANDOM.Proveedor prov ON (prov.cuit = ma.Provee_CUIT)
WHERE Groupon_Descripcion IS NOT NULL
GROUP BY Groupon_Descripcion, Groupon_Fecha, Groupon_Fecha_Venc, Groupon_Precio, Groupon_Precio_Ficticio, prov.id_usuario, Groupon_Cantidad
 
--insert cliente_x_ciudad
INSERT INTO RANDOM.Cliente_x_Ciudad (id_cliente, id_ciudad)
select DISTINCT cli.id_usuario, ciu.id_ciudad  
from gd_esquema.Maestra ma
left join RANDOM.Ciudad ciu ON (ciu.descripcion = ma.Cli_Ciudad)
left join RANDOM.Cliente cli ON (cli.dni = ma.Cli_Dni)
WHERE ma.Cli_Dni is not null
order by cli.id_usuario

--insert forma_de_pago
INSERT INTO RANDOM.Forma_de_Pago(descripcion)
SELECT DISTINCT Tipo_Pago_Desc FROM gd_esquema.Maestra
WHERE Tipo_Pago_Desc IS NOT NULL

--insert cupon_x_ciudad
INSERT INTO RANDOM.Cupon_x_ciudad (id_cupon, id_ciudad)
SELECT DISTINCT cup.id_cupon, ciu.id_ciudad
FROM gd_esquema.Maestra ma
LEFT JOIN RANDOM.Proveedor prov ON (prov.razon_social = ma.Provee_RS)
LEFT JOIN RANDOM.Cupon cup ON (cup.descripcion = ma.Groupon_Descripcion AND cup.fec_publicacion = ma.Groupon_Fecha AND cup.fec_venc_consumo = ma.Groupon_Fecha_Venc
AND cup.precio_real = ma.Groupon_Precio AND cup.precio_ficticio = ma.Groupon_Precio_Ficticio AND cup.id_proveedor = prov.id_usuario 
AND cup.cant_disp = ma.Groupon_Cantidad)LEFT JOIN RANDOM.Ciudad ciu ON (ciu.descripcion = ma.Cli_Ciudad)
WHERE ma.Groupon_Fecha_Compra is not null

--insert cupon_comprado
INSERT INTO RANDOM.Cupon_Comprado (codigo_compra,fecha_compra, id_cupon, id_cliente)
SELECT ma.Groupon_Codigo,ma.Groupon_Fecha_Compra,cup.id_cupon,cli.id_usuario
FROM gd_esquema.Maestra ma
LEFT JOIN RANDOM.Cliente cli ON (cli.dni = ma.Cli_Dni)
LEFT JOIN RANDOM.Proveedor prov ON (prov.razon_social = ma.Provee_RS)
LEFT JOIN RANDOM.Cupon cup ON (cup.descripcion = ma.Groupon_Descripcion AND cup.fec_publicacion = ma.Groupon_Fecha AND cup.fec_venc_consumo = ma.Groupon_Fecha_Venc
AND cup.precio_real = ma.Groupon_Precio AND cup.precio_ficticio = ma.Groupon_Precio_Ficticio AND cup.id_proveedor = prov.id_usuario 
AND cup.cant_disp = ma.Groupon_Cantidad)
WHERE ma.Groupon_Fecha_Compra is not null AND ma.Groupon_Entregado_Fecha IS NULL AND ma.Groupon_Devolucion_Fecha IS NULL AND ma.Factura_Nro IS NULL
group by ma.Groupon_Codigo, ma.Groupon_Fecha_Compra, cup.id_cupon, cli.id_usuario;

--arreglo de los codigos de compra repetidos
WITH duplicates AS (
  SELECT ROW_NUMBER() OVER (PARTITION BY cc.codigo_compra ORDER BY codigo_compra) AS duplicate_id, *
  FROM RANDOM.Cupon_Comprado cc)

UPDATE
  duplicates
SET
  codigo_compra = codigo_compra+'/1'
WHERE
  duplicate_id > 1;

WITH duplicates AS (
  SELECT ROW_NUMBER() OVER (PARTITION BY cc.codigo_compra ORDER BY codigo_compra) AS duplicate_id, *
  FROM RANDOM.Cupon_Comprado cc)

UPDATE
  duplicates
SET
  codigo_compra = SUBSTRING(codigo_compra,0,LEN(codigo_compra)-1)+'/2'
WHERE
  duplicate_id > 1
  
--insert de credito
INSERT INTO RANDOM.Credito (id_cliente, carga_credito, fecha, id_forma_pago)
SELECT cli.id_usuario, ma.Carga_Credito, ma.Carga_Fecha, fp.id_forma_pago            
FROM gd_esquema.Maestra ma
LEFT JOIN RANDOM.Forma_de_Pago fp ON (fp.descripcion = ma.Tipo_Pago_Desc)
LEFT JOIN.RANDOM.Cliente cli ON (cli.dni = ma.Cli_Dni)
WHERE Carga_Fecha IS NOT NULL

--insert de gift_card
INSERT INTO RANDOM.Gift_Card (fecha, monto, id_usuario_origen, id_usuario_destino)
SELECT ma.GiftCard_Fecha, ma.GiftCard_Monto, cli.id_usuario, clidest.id_usuario
FROM gd_esquema.Maestra ma
LEFT JOIN RANDOM.Cliente cli ON (ma.Cli_Dni = cli.dni)
LEFT JOIN RANDOM.Cliente clidest ON (ma.Cli_Dest_Dni = clidest.dni)
WHERE ma.GiftCard_Monto is not null

--insert cupon_canjeado
INSERT INTO RANDOM.Cupon_Canjeado ( fecha_canje, id_compra, id_cliente, facturado)
SELECT ma.Groupon_Entregado_Fecha, cc.id_compra, cli.id_usuario,0
FROM gd_esquema.Maestra ma
LEFT JOIN RANDOM.Cliente cli ON (cli.dni = ma.Cli_Dni)
LEFT JOIN RANDOM.Cupon_Comprado cc ON (cc.codigo_compra like(ma.Groupon_Codigo+'%') and cc.fecha_compra = ma.Groupon_Fecha_Compra and cc.id_cliente = cli.id_usuario )
LEFT JOIN RANDOM.Cupon cup ON (cup.id_cupon = cc.id_cupon)
WHERE Groupon_Entregado_Fecha is not null 

--insert cupon_devuelto
INSERT INTO RANDOM.Cupon_Devuelto (fecha_devolucion, id_compra, id_cliente, motivo_devolucion, codigo_compra)
SELECT ma.Groupon_Devolucion_Fecha, cc.id_compra, cli.id_usuario,' ', codigo_compra
FROM gd_esquema.Maestra ma
LEFT JOIN RANDOM.Cliente cli ON (cli.dni = ma.Cli_Dni)
LEFT JOIN RANDOM.Cupon_Comprado cc ON (cc.codigo_compra like(ma.Groupon_Codigo+'%') and cc.fecha_compra = ma.Groupon_Fecha_Compra and cc.id_cliente = cli.id_usuario )
LEFT JOIN RANDOM.Cupon cup ON (cup.id_cupon = cc.id_cupon)
WHERE ma.Groupon_Devolucion_Fecha is not null

--insert factura
INSERT INTO RANDOM.Factura(id_proveedor, nro_factura, fecha)
SELECT distinct pr.id_usuario, ma.Factura_Nro, ma.Factura_Fecha  FROM gd_esquema.Maestra ma
LEFT JOIN RANDOM.Proveedor pr ON (ma.Provee_CUIT = pr.cuit)
WHERE Factura_Nro IS NOT NULL

--insert renglon_factura
INSERT INTO RANDOM.Renglon_Factura (id_cupon_canjeado, id_factura)
SELECT ccanj.id_canje, fac.id_factura
FROM gd_esquema.Maestra ma
LEFT JOIN RANDOM.Cliente cli ON (cli.dni = ma.Cli_Dni)
LEFT JOIN RANDOM.Cupon_Comprado cc ON (cc.codigo_compra like(ma.Groupon_Codigo+'%') and cc.fecha_compra = ma.Groupon_Fecha_Compra and cc.id_cliente = cli.id_usuario )
LEFT JOIN RANDOM.Cupon_Canjeado ccanj on cc.id_compra = ccanj.id_compra
LEFT JOIN RANDOM.Factura fac ON (fac.nro_factura = ma.Factura_Nro)
WHERE ma.Factura_Fecha is not null 

--marcar cupones facturados
UPDATE RANDOM.Cupon_Canjeado SET facturado = 1 
WHERE id_canje IN (select id_cupon_canjeado from RANDOM.Renglon_Factura)

--marcar cupones publicados
update RANDOM.Cupon
set publicado = 1

--maximo de cupones por usuario
UPDATE RANDOM.Cupon SET max_compra_por_usuario = cc.cant FROM
(SELECT id_cupon,COUNT(*) cant FROM RANDOM.Cupon_Comprado 
GROUP BY id_cupon, id_cliente) cc
WHERE RANDOM.Cupon.id_cupon = cc.id_cupon 

--saldos de los clientes
declare @id_usuario bigint
declare c1 cursor for (select id_usuario from RANDOM.Cliente)
open c1
fetch c1 into @id_usuario

while @@FETCH_STATUS = 0
begin
	update RANDOM.Cliente
	set saldo_actual =	(select sum(carga_credito) from RANDOM.Credito cred where @id_usuario = cred.id_cliente)
						+ (select sum(monto) from RANDOM.Gift_Card gc where @id_usuario = gc.id_usuario_destino)
						- (select sum(monto) from RANDOM.Gift_Card gc where @id_usuario = gc.id_usuario_origen)
						- (select sum(precio_real) from RANDOM.Cupon_Comprado cupc inner join RANDOM.Cupon cup on cupc.id_cupon = cup.id_cupon and cupc.id_cliente = @id_usuario)
						+ (select sum(precio_real) from RANDOM.Cupon_Comprado cupc inner join RANDOM.Cupon cup on cupc.id_cupon = cup.id_cupon inner join RANDOM.Cupon_Devuelto cupd on cupd.id_compra = cupc.id_compra and cupd.id_cliente = @id_usuario)
	where id_usuario = @id_usuario
	fetch c1 into @id_usuario
end

close c1
deallocate c1

--insert del admin
INSERT INTO RANDOM.Usuario (username, [password], id_rol,id_tipo_usuario, estado, fallas)
VALUES ('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',1,1,1, 0)
GO

--le quito a la tabla usuario la columna dni_cuit, ya que queda obsoleta
alter table RANDOM.Usuario drop column dni_cuit
go



/***** STORE PROCEDURES *****/
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

--Cambiar nombre de rol: RANDOM.CambiarNombreRol (todos los parametros son necesarios)
create procedure RANDOM.CambiarNombreRol @id_rol bigint output, @descripcion nvarchar(50) output
as
begin transaction
	if exists (select descripcion from RANDOM.Rol where @descripcion = descripcion and @id_rol != id_rol)
	begin
		rollback
		raiserror('El nombre de rol ya existe', 16, 1)
		return
	end	
	
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

--Modificacion de usuario: RANDOM.ModificarUsuario (todos los parametros son necesarios)
create procedure RANDOM.ModificarUsuario @id_usuario bigint output, @username nvarchar(255) output, @password nvarchar(255) output, @id_rol bigint out
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
	password = @password,
	id_rol = @id_rol
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
create procedure RANDOM.IncrementarFallas @id_usuario bigint output
as
begin 
      update RANDOM.Usuario
      set fallas = fallas + 1
      from RANDOM.Usuario
      where id_usuario = @id_usuario
end
go

--Reiniciar las fallas que tiene un usuario: RANDOM.ReiniciarFallas (parametro necesario)
create procedure RANDOM.ReiniciarFallas @id_usuario bigint output
as
begin 
      update RANDOM.Usuario
      set fallas = 0
      from RANDOM.Usuario
      where id_usuario = @id_usuario
end
go

--Registro de un proveedor: RANDOM.RegistrarProveedor (todos los parametros son necesarios)
create procedure RANDOM.RegistrarProveedor @username nvarchar(255) output, @password nvarchar(255) output, @razon_social nvarchar(255) output, @mail nvarchar(100) output, @telefono numeric (18,0) output, @direccion_completa nvarchar(255) output, @cod_postal numeric(18,0) output, @id_ciudad bigint output, @cuit nvarchar(20) output, @id_rubro bigint output, @contacto_nombre nvarchar(100) output
as
begin transaction
	if exists (select username from RANDOM.Usuario where @username = username)
	begin
		rollback
		raiserror('El nombre de usuario ya existe', 16, 1)
		return
	end	
	else
	begin
		if exists (select razon_social from RANDOM.Proveedor where razon_social = @razon_social)
		begin
			rollback
			raiserror('La razon social ya esta registrada para otro proveedor', 16, 1)
			return
		end	
		else
		begin
			if exists (select cuit from RANDOM.Proveedor where cuit = @cuit)
			begin
				rollback
				raiserror('El CUIT ya esta registrado para otro proveedor', 16, 1)
				return
			end
			else
			begin
				if exists (select telefono from RANDOM.Proveedor where telefono = @telefono)
				begin
					rollback
					raiserror('El telefono ya esta registrado para otro proveedor', 16, 1)
					return
				end
			end
		end	
	end

	insert into RANDOM.Usuario(username, password, id_rol,id_tipo_usuario, estado, fallas)
	values(@username, @password, 3 /*3 es rol proveedor*/,3 /*3 es proveedor*/, 1, 0)
	insert into RANDOM.Proveedor(id_usuario, razon_social, mail, telefono, direccion, cod_postal, id_ciudad, cuit, id_rubro, contacto_nombre)
	values((select id_usuario from RANDOM.Usuario where username = @username), @razon_social, @mail, @telefono, @direccion_completa, @cod_postal, @id_ciudad, @cuit, @id_rubro, @contacto_nombre)
commit
go

--Modificacion de un proveedor: RANDOM.ModificarProveedor (todos los parametros son necesarios)
create procedure RANDOM.ModificarProveedor @id_usuario bigint output, @razon_social nvarchar(255) output, @mail nvarchar(100) output, @telefono numeric (18,0) output, @direccion nvarchar(255) output, @cod_postal numeric(18,0) output, @id_ciudad bigint output, @cuit nvarchar(20) output, @id_rubro bigint output, @contacto_nombre nvarchar(100) output
as
begin transaction
	if (exists (select razon_social from RANDOM.Proveedor where razon_social = @razon_social)) and ((select razon_social from RANDOM.Proveedor where id_usuario = @id_usuario) != @razon_social)
	begin
		rollback
		raiserror('La razon social ya esta registrada para otro proveedor', 16, 1)
		return
	end	
	else
	begin
		if exists (select cuit from RANDOM.Proveedor where cuit = @cuit and id_usuario != @id_usuario)
		begin
			rollback
			raiserror('El CUIT ya esta registrado para otro proveedor', 16, 1)
			return
		end
		else
		begin
			if exists (select telefono from RANDOM.Proveedor where telefono = @telefono and id_usuario != @id_usuario)
			begin
				rollback
				raiserror('El telefono ya esta registrado para otro proveedor', 16, 1)
				return
			end
		end
	end	

	update RANDOM.Proveedor
	set	razon_social = @razon_social, 
	mail = @mail, 
	telefono = @telefono, 
	direccion = @direccion, 
	cod_postal = @cod_postal, 
	id_ciudad = @id_ciudad, 
	cuit = @cuit, 
	id_rubro = @id_rubro, 
	contacto_nombre = @contacto_nombre
	where id_usuario = @id_usuario
commit
go

--Registro de cliente: RANDOM.RegistrarCliente (el parametro @id_usuario es solo output, para usarlo en RANDOM.AgregarClientePorCiudad)
create procedure RANDOM.RegistrarCliente @id_usuario bigint output, @username nvarchar(255) output, @password nvarchar(255) output, @nombre nvarchar(255) output, @apellido nvarchar(255) output, @dni numeric(18,0) output, @mail nvarchar(100) output, @telefono numeric (18,0) output, @direccion_completa nvarchar(255) output, @cod_postal numeric(18,0) output, @fecha_nac datetime output
as
begin transaction
	if exists (select username from RANDOM.Usuario where @username = username)
	begin
		rollback
		raiserror('El nombre de usuario ya existe', 16, 1)
		return
	end        
	else
	begin
		if exists (select dni from RANDOM.Cliente where dni = @dni)
		begin
			rollback
			raiserror('El DNI ya esta registrado para otro cliente', 16, 1)
			return
		end        
		else
		begin
			if exists (select telefono from RANDOM.Cliente where telefono = @telefono)
			begin
				rollback
				raiserror('El telefono ya esta registrado para otro cliente', 16, 1)
				return
			end
			else
			begin
				if len(@dni) != 8
				begin
					rollback
					raiserror('El dni debe tener 8 digitos', 16, 1)
					return
			
				end
			end
		end        
	end
                    
    insert into RANDOM.Usuario(username, password, id_rol,id_tipo_usuario,estado, fallas)
    values(@username, @password, 2/*2 es rol cliente*/, 2/*2 es cliente*/, 1, 0)
    
	set @id_usuario = (select id_usuario from RANDOM.Usuario where username = @username)
	
    insert into RANDOM.Cliente(id_usuario, nombre, apellido, dni, mail, telefono, direccion, cod_postal, fecha_nac, saldo_actual)
    values(@id_usuario, @nombre, @apellido, @dni, @mail, @telefono, @direccion_completa, @cod_postal, @fecha_nac, 10)
commit
go

--Modificacion de cliente: RANDOM.ModificarCliente (todos los parametros son necesarios)
create procedure RANDOM.ModificarCliente @id_usuario bigint output, @nombre nvarchar(255) output, @apellido nvarchar(255) output, @dni numeric(18,0) output, @mail nvarchar(100) output, @telefono numeric (18,0) output, @direccion nvarchar(255) output, @cod_postal numeric(18,0) output, @fecha_nac datetime output
as
begin transaction
	if exists (select dni from RANDOM.Cliente where dni = @dni and id_usuario != @id_usuario)
	begin
		rollback
		raiserror('El DNI ya esta registrado para otro cliente', 16, 1)
		return
	end	
	else
	begin
		if exists (select telefono from RANDOM.Cliente where telefono = @telefono and id_usuario != @id_usuario)
		begin
			rollback
			raiserror('El telefono ya esta registrado para otro cliente', 16, 1)
			return
		end
		else
		begin
			if len(@dni) != 8
			begin
				rollback
				raiserror('El dni debe tener 8 digitos', 16, 1)
				return
			end
		end
	end	
			
	update RANDOM.Cliente
	set nombre = @nombre,
	apellido = @apellido,
	dni = @dni,
	mail = @mail,
	telefono = @telefono,
	direccion = @direccion,
	cod_postal = @cod_postal,
	fecha_nac = @fecha_nac 
	where id_usuario = @id_usuario
commit
go

--Agregar cliente x ciudad: RANDOM.AgregarClientePorCiudad (todos los parametros son necesarios)
create procedure RANDOM.AgregarClientePorCiudad @id_usuario bigint output, @id_ciudad bigint output
as
begin
	insert into RANDOM.Cliente_x_Ciudad(id_cliente, id_ciudad)
	values(@id_usuario , @id_ciudad)
end
go

--Quitar cliente x ciudad: RANDOM.QuitarClientePorCiudad (todos los parametros son necesarios)
create procedure RANDOM.QuitarClientePorCiudad @id_usuario bigint output, @id_ciudad bigint output
as
begin
	delete from RANDOM.Cliente_x_Ciudad
	where id_cliente = @id_usuario and id_ciudad = @id_ciudad
end
go

--Publicacion de cupones: RANDOM.PublicarCupon (parametro necesario)
create procedure RANDOM.PublicarCupon @id_cupon bigint out
as
begin	
	update RANDOM.Cupon
	set publicado = 1
	where id_cupon = @id_cupon
end
go

--Facturacion de cupones: RANDOM.FacturarCupones (los parametros @monto_total y @nro_factura son solo output, para mostrarlos al administrador)
create procedure RANDOM.FacturarCupones @monto_total bigint out, @nro_factura numeric(18,0) out, @id_proveedor bigint out, @fecha datetime out, @fecha_inicio datetime out, @fecha_fin datetime out
as
begin
	set @nro_factura = (select top 1 nro_factura from RANDOM.Factura order by nro_factura desc) + 1
	
	insert into RANDOM.Factura(nro_factura, fecha, id_proveedor)
	values(@nro_factura, @fecha, @id_proveedor)
		
	declare @id_factura bigint
	set @id_factura = (select id_factura from RANDOM.Factura where nro_factura = @nro_factura)
	
	insert into RANDOM.Renglon_Factura(id_cupon_canjeado, id_factura)
	select id_canje, @id_factura
	from RANDOM.Cupon_Canjeado cca inner join RANDOM.Cupon_Comprado cco on cca.id_compra = cco.id_compra inner join Cupon c on c.id_cupon = cco.id_cupon
	where id_proveedor = @id_proveedor and fecha_canje between @fecha_inicio and @fecha_fin
	
	set @monto_total = (select sum(precio_real)
						from RANDOM.Renglon_Factura rf 
							 inner join RANDOM.Cupon_Canjeado ccan on ccan.id_canje = rf.id_cupon_canjeado and rf.id_factura = @id_factura
							 inner join RANDOM.Cupon_Comprado ccom on ccom.id_compra = ccan.id_compra
							 inner join RANDOM.Cupon c on ccom.id_cupon = c.id_cupon
						where rf.id_factura = @id_factura)
						
	update RANDOM.Cupon_Canjeado
	set facturado = 1
	where id_canje in (select id_cupon_canjeado from RANDOM.Renglon_Factura where id_factura = @id_factura)
	
end
go

--Armar un cupon: RANDOM.ArmarCupon (el parametro @id_cupon es solo output, para usarlo en RANDOM.AgregarCuponPorCiudad)
create procedure RANDOM.ArmarCupon @id_cupon bigint out, @id_proveedor bigint out, @descripcion nvarchar(255) out, @fecha_actual datetime out, @fec_publicacion datetime out, @fec_venc_publicacion datetime out, @fec_venc_consumo datetime out, @precio_real numeric(18,2) out, @precio_ficticio numeric(18,2) out, @cant_disp numeric(18,0) out, @max_compra_por_usuario numeric(18,0) out
as
begin  transaction
	if exists (select 1 from RANDOM.Usuario where id_usuario = @id_proveedor and estado = 0)
	begin
		rollback
		raiserror('Está deshabilitado, no puede armar ofertas', 16, 1)
		return
	end
	else
	begin
		if @fecha_actual > @fec_publicacion
		begin
			rollback
			raiserror('La fecha de publicacion no puede ser anterior a la actual', 16, 1)
			return
		end
		else
		begin
			if @fec_publicacion > @fec_venc_consumo
			begin
				rollback
				raiserror('La fecha de vencimiento de canje no puede ser anterior a la fecha de inicio de la publicacion', 16, 1)
				return
			end
			else
			begin
				if @fec_publicacion > @fec_venc_publicacion
				begin
					rollback
					raiserror('La fecha de vencimiento de la oferta no puede ser anterior a la fecha de inicio de la misma', 16, 1)
					return			
				end
			end
		end	
	end
	
	insert into RANDOM.Cupon(descripcion, fec_publicacion, fec_venc_consumo, fec_venc_publicacion, precio_real, precio_ficticio, id_proveedor, cant_disp, max_compra_por_usuario, publicado)
	values(@descripcion, @fec_publicacion, @fec_venc_consumo, @fec_venc_publicacion, @precio_real, @precio_ficticio, @id_proveedor, @cant_disp, @max_compra_por_usuario, 0)
	
	set @id_cupon = (select max(id_cupon) from RANDOM.Cupon)
commit
go

--Agregar cupon x ciudad: RANDOM.AgregarCuponPorCiudad (todos los parametros son necesarios)
create procedure RANDOM.AgregarCuponPorCiudad @id_cupon bigint output, @id_ciudad bigint output
as
begin
	insert into RANDOM.Cupon_x_Ciudad(id_cupon, id_ciudad)
	values(@id_cupon , @id_ciudad)
end
go

--Quitar cupon x ciudad: RANDOM.QuitarCuponPorCiudad (todos los parametros son necesarios)
create procedure RANDOM.QuitarCuponPorCiudad @id_cupon bigint output, @id_ciudad bigint output
as
begin
	delete from RANDOM.Cupon_x_Ciudad
	where id_cupon = @id_cupon and id_ciudad = @id_ciudad
end
go

--Registrar que un cupon fue consumido: RANDOM.RegistrarConsumo (todos los parametros son necesarios)
create procedure RANDOM.RegistrarConsumo @id_proveedor bigint out, @codigo_compra nvarchar(50) out, @fecha_canje datetime out
as
begin  transaction
	if exists (select 1 from RANDOM.Usuario where id_usuario = @id_proveedor and estado = 0)
	begin
		rollback
		raiserror('Está deshabilitado, no puede registrar un consumo', 16, 1)
		return
	end
	else
	begin
		if not exists (select 1 from RANDOM.Cupon_Comprado where codigo_compra = @codigo_compra)
		begin
			rollback
			raiserror('El codigo de cupon es erroneo', 16, 1)		
			return	
		end
		else
		begin
			if exists (select 1 from RANDOM.Cupon_Canjeado ccan inner join RANDOM.Cupon_Comprado ccom on ccom.id_compra = ccan.id_compra where ccom.codigo_compra = @codigo_compra)
			begin
				rollback
				raiserror('Ese canje ya esta registrado', 16, 1)		
				return
			end
			else
			begin
				if @fecha_canje > (select c.fec_venc_consumo from RANDOM.Cupon c inner join Cupon_Comprado cc on c.id_cupon = cc.id_cupon where cc.codigo_compra = @codigo_compra)
				begin
					rollback
					raiserror('La fecha de canje ha expirado', 16, 1)
					return
				end
				else
				begin
					if exists (select 1 from RANDOM.Cupon c inner join RANDOM.Cupon_Comprado cc on c.id_cupon = cc.id_cupon where cc.codigo_compra = @codigo_compra and c.id_proveedor != @id_proveedor)
					begin
						rollback
						raiserror('No es el proveedor de este cupon', 16, 1)
						return			
					end
					else
					begin
						if exists (select 1 from RANDOM.Cupon_Comprado cc inner join RANDOM.Cupon_Devuelto cd on cd.id_compra = cc.id_compra where cc.codigo_compra = @codigo_compra)
						begin
							rollback
							raiserror('Ese cupon fue devuelto', 16, 1)
							return	
						end	
					end
				end
			end	
		end
	end
	
	insert into RANDOM.Cupon_Canjeado(fecha_canje, id_compra, id_cliente, facturado)
	select @fecha_canje, id_compra, id_cliente, 0 
	from RANDOM.Cupon_Comprado 
	where codigo_compra = @codigo_compra
commit
go

--Registro de una carga de credito: RANDOM.CargarCredito (todos los parametros necesarios)
create procedure RANDOM.CargarCredito @id_cliente bigint output, @carga_credito bigint output, @fecha datetime output, @id_forma_pago bigint output, @nro_tarjeta numeric(15,0) output, @cod_seguridad_tarjeta numeric(3,0) output, @fecha_vto_tarjeta nvarchar(5) output
as
begin
	if exists (select 1 from RANDOM.Usuario where id_usuario = @id_cliente and estado = 0)
	begin
		rollback
		raiserror('Está deshabilitado, no puede cargar credito', 16, 1)
		return
	end
	
	insert into RANDOM.Credito(id_cliente, carga_credito, fecha,id_forma_pago, nro_tarjeta, cod_seguridad_tarjeta, fecha_vto_tarjeta)
	values(@id_cliente, @carga_credito, @fecha, @id_forma_pago, @nro_tarjeta, @cod_seguridad_tarjeta, @fecha_vto_tarjeta)
	
	update RANDOM.Cliente
	set saldo_actual = saldo_actual + @carga_credito
	where id_usuario = @id_cliente
end
go

--Registro de una compra de gift card: RANDOM.ComprarGiftCard (todos los parametros necesarios)
create procedure RANDOM.ComprarGiftCard @id_usuario_origen bigint output, @id_usuario_destino bigint output, @fecha datetime output, @monto bigint output
as
begin transaction

	if not exists (select 1 from RANDOM.Usuario where id_usuario = @id_usuario_destino)
	begin
		rollback
		raiserror('El nombre de usuario es incorrecto', 16, 1)
		return
	end
	else
	begin
		if not exists (select 1 from RANDOM.Usuario where id_usuario = @id_usuario_destino and estado = 1)
		begin
			rollback
			raiserror('El usuario esta deshabilitado', 16, 1)
			return
		end
		else
		begin
			if @id_usuario_destino = @id_usuario_origen
			begin
				rollback
				raiserror('No puede regalarse credito a si mismo', 16, 1)
				return			
			end
			else
			begin
				if (select saldo_actual from RANDOM.Cliente where id_usuario = @id_usuario_origen) < @monto
				begin
					rollback
					raiserror('No posee credito suficiente para regalar', 16, 1)
					return			
				end
			end
		end
	end	
	
	insert into RANDOM.Gift_Card(id_usuario_origen, id_usuario_destino, fecha, monto)
	values(@id_usuario_origen, @id_usuario_destino, @fecha, @monto)
	
	update RANDOM.Cliente
	set saldo_actual = saldo_actual + @monto
	where id_usuario = @id_usuario_destino
	
	update RANDOM.Cliente
	set saldo_actual = saldo_actual - @monto
	where id_usuario = @id_usuario_origen
commit
go

--Comprar cupon: RANDOM.ComprarCupon (el parametro codigo_compra es solo output, para mostrarlo por pantalla)
create procedure RANDOM.ComprarCupon @id_cliente bigint output, @id_cupon bigint output, @fecha_compra datetime output, @id_compra bigint output
as
begin transaction

	if exists (select 1 from RANDOM.Usuario where id_usuario = @id_cliente and estado = 0)
	begin
		rollback
		raiserror('Está deshabilitado, no puede comprar cupones', 16, 1)
		return
	end
	else
	begin
		if (select cant_disp from RANDOM.Cupon where id_cupon = @id_cupon) <= 0
		begin
			rollback
			raiserror('No hay suficiente stock', 16, 1)
			return
		end
		else
		begin
			if (select saldo_actual from RANDOM.Cliente where id_usuario = @id_cliente) < (select precio_real from RANDOM.Cupon where id_cupon = @id_cupon)
			begin
				rollback
				raiserror('No posee credito suficiente para realizar la compra', 16, 1)
				return
			end
			else
			begin
				if (select COUNT(*) from RANDOM.Cupon_Comprado where id_cliente = @id_cliente and id_cupon = @id_cupon) >= (select max_compra_por_usuario from RANDOM.Cupon where id_cupon = @id_cupon)
				begin
					rollback
					raiserror('Ya ha comprado el maximo permitido de este cupon', 16, 1)
					return			
				end
			end
		end	
	end
	
	insert into RANDOM.Cupon_Comprado(fecha_compra, id_cliente, id_cupon, codigo_compra)
	values (@fecha_compra, @id_cliente, @id_cupon, 0)
	
	set @id_compra = (select max(id_compra) from RANDOM.Cupon_Comprado)
	
	update RANDOM.Cupon_Comprado
	set codigo_compra = @id_compra
	where id_compra = @id_compra
	
	update RANDOM.Cupon
	set cant_disp = cant_disp - 1
	where id_cupon = @id_cupon
	
	update RANDOM.Cliente
	set saldo_actual = saldo_actual - (select precio_real from RANDOM.Cupon where id_cupon = @id_cupon)
	where id_usuario = @id_cliente
	
commit
go

--Pedir devolucion: RANDOM.PedirDevolucionCupon (los parametros @id_cupon y @id_compra son solo output, para mostrarlos antes de concretar la devolucion, para lo cual se llama a RANDOM.DevolverCupon)
create procedure RANDOM.PedirDevolucionCupon @id_cliente bigint output, @fecha_devolucion datetime output, @codigo_compra nvarchar(50) output, @id_cupon bigint output, @id_compra bigint output
as
begin transaction
	if not exists (select 1 from RANDOM.Cupon_Comprado where codigo_compra = @codigo_compra)
	begin
		rollback
		raiserror('El codigo de compra es erroneo', 16, 1)
		return
	end
	else
	begin
		if exists (select 1 from RANDOM.Cupon_Comprado where codigo_compra = @codigo_compra and id_cliente != @id_cliente)
		begin
			rollback
			raiserror('No es dueño del cupon', 16, 1)
			return
		end
		else
		begin
			if (select fec_venc_consumo from RANDOM.Cupon c inner join RANDOM.Cupon_Comprado cc on cc.id_cupon = c.id_cupon where codigo_compra = @codigo_compra) < @fecha_devolucion
			begin
				rollback
				raiserror('La fecha de vencimiento para el consumo ha expirado, no puede devolverse este cupon', 16, 1)		
				return	
			end
			else
			begin
				if exists (select 1 from RANDOM.Cupon_Devuelto cd inner join RANDOM.Cupon_Comprado cc on cc.id_compra = cd.id_compra where cc.codigo_compra = @codigo_compra)
				begin
					rollback
					raiserror('Ese cupon ya fue devuelto', 16, 1)		
					return	
				end
				else
				begin
					if exists (select 1 from RANDOM.Cupon_Canjeado ccan inner join RANDOM.Cupon_Comprado ccom on ccom.id_compra = ccan.id_compra where ccom.codigo_compra=@codigo_compra)
					begin
					rollback
					raiserror('Ese cupon ha sido canjeado', 16, 1)		
					return
					end
				end
			end
		end
	end	

	set @id_cupon = 
		(select id_cupon
		from RANDOM.Cupon_Comprado
		where codigo_compra = @codigo_compra)
	set @id_compra = 
		(select id_compra
		from RANDOM.Cupon_Comprado
		where codigo_compra = @codigo_compra)
		
commit
go

--Devolver un cupon: RANDOM.DevolverCupon (todos los parametros necesarios)
create procedure RANDOM.DevolverCupon @id_cliente bigint out, @fecha_devolucion datetime out, @codigo_compra nvarchar(50) out, @motivo_devolucion nvarchar(255) out
as
begin
	insert into RANDOM.Cupon_Devuelto(fecha_devolucion, id_cliente, id_compra, codigo_compra, motivo_devolucion)
	values(@fecha_devolucion, @id_cliente, (select id_compra from RANDOM.Cupon_Comprado where codigo_compra = @codigo_compra), @codigo_compra, @motivo_devolucion)
	
	update RANDOM.Cliente
	set saldo_actual = saldo_actual + (select precio_real from RANDOM.Cupon c inner join RANDOM.Cupon_Comprado cc on c.id_cupon = cc.id_cupon where codigo_compra = @codigo_compra)
	where id_usuario = @id_cliente

	update RANDOM.Cupon
	set cant_disp = cant_disp + 1
	where id_cupon = (select id_cupon from Cupon_Comprado where codigo_compra = @codigo_compra)

end
go





/***** FUNCIONES ****/
create function RANDOM.EsCliente(@id_usuario bigint)
returns numeric(1,0)
as
begin
	if exists (select 1 from RANDOM.Cliente where id_usuario = @id_usuario) 
	begin
		return 1
	end
	return 0
end
go

create function RANDOM.EsProveedor(@id_usuario bigint)
returns numeric(1,0)
as
begin
	if exists (select 1 from RANDOM.Proveedor where id_usuario = @id_usuario) 
	begin
		return 1
	end
	return 0
end
go





/***** VISTAS *****/
-- Vista de cupones para cliente 
create view RANDOM.Cupones_Para_Cliente
as
select distinct cu.id_cupon, descripcion, precio_ficticio, precio_real, fec_publicacion, fec_venc_publicacion, id_cliente
from RANDOM.Cupon cu 
	 inner join RANDOM.Cupon_x_ciudad cuxc on (cuxc.id_cupon = cu.id_cupon)
	 inner join RANDOM.Cliente_x_Ciudad clxc on (clxc.id_ciudad = cuxc.id_ciudad)
where cu.publicado = 1
go

-- Vista para historial de cupones 
create view RANDOM.Historial_Compra_Cupones
as
select id_cliente, fecha_compra, fec_venc_consumo, descripcion, precio_real, codigo_compra, estado =
	case when exists (select 1 from RANDOM.Cupon_Canjeado ccan where ccan.id_compra = cc.id_compra) then 'Canjeado'
		 when exists (select 1 from RANDOM.Cupon_Devuelto cdev where cdev.id_compra = cc.id_compra) then 'Devuelto'
		 else 'Comprado'
	end
from RANDOM.Cupon_Comprado cc 
	 inner join RANDOM.Cupon c on cc.id_cupon = c.id_cupon
go
 
-- Vista para facturacion de proveedor 
create view RANDOM.Facturacion_Proveedor
as
select id_proveedor, codigo_compra, fecha_canje, precio_real 
from RANDOM.Cupon_Canjeado ccan 
	  inner join RANDOM.Cupon_Comprado ccom on ccan.id_compra = ccom.id_compra
	  inner join RANDOM.Cupon c on c.id_cupon = ccom.id_cupon
where facturado = 0
go





/***** TRIGGERS *****/
-- Cambia el rol de los clientes a NULL cuando se deshabilita dicho rol en la tabla rol
create trigger RANDOM.inhabilitar_rol ON RANDOM.Rol
after update
as
begin
	if exists (select 1 from inserted where estado = 0)
	begin
		update RANDOM.Usuario
		set id_rol = NULL	
		where id_rol = (select id_rol from inserted)
	end
end
go
