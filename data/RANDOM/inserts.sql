/** INSERT DE LOS ROLES**/
INSERT INTO RANDOM.Rol (descripcion,estado) VALUES ('Administrador',1);
INSERT INTO RANDOM.Rol (descripcion,estado) VALUES ('Cliente',1);
INSERT INTO RANDOM.Rol (descripcion,estado) VALUES ('Proveedor',1);

/** INSERT DE FUNCIONALIDAD**/

INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Cargar Cr�dito');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Comprar GiftCard');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Comprar Cup�n');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Pedir Devoluci�n');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Historial de Compra de Cupones');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Armar Cup�n');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Registro de consumo de Cup�n');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Publicar Cup�n');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Facturaci�n a Proveedor');
INSERT INTO RANDOM.Funcionalidad (descripcion) VALUES ('Listado Estad�stico');

/** INSERT DE FUNCIONALIDAD x ROL**/

INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (10,1);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (9,1);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (8,1);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (1,2);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (2,2);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (3,2);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (4,2);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (5,2);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (6,3);
INSERT INTO RANDOM.Funcionalidad_x_Rol (id_funcionalidad,id_rol) VALUES (7,3);


/** INSERT DE USUARIOS_CLIENTES**/

INSERT INTO  RANDOM.Usuario(username,password,id_rol,estado,dni_cuit,fallas)
(SELECT DISTINCT ('u'+CONVERT(nvarchar,Cli_Dni)), '9b8769a4a742959a2d0298c36fb70623f2dfacda8436237df08d8dfd5b37374c',2,1,CONVERT(nvarchar,Cli_Dni),0
FROM gd_esquema.Maestra
WHERE Cli_Dni IS not null)

/** INSERT DE CLIENTES**/
INSERT INTO RANDOM.Cliente (id_usuario,apellido,nombre,dni,mail,telefono,direccion,fecha_nac)(
SELECT DISTINCT us.id_usuario,Cli_Apellido,Cli_Nombre,Cli_Dni,Cli_Mail,Cli_Telefono,Cli_Direccion,Cli_Fecha_Nac
FROM gd_esquema.Maestra ma
LEFT JOIN RANDOM.Usuario us ON (us.dni_cuit = ma.Cli_Dni)
WHERE Cli_Dni IS NOT NULL);

/** INSERT DE RUBRO**/
INSERT INTO RANDOM.Rubro (desc_rubro) (
SELECT DISTINCT ma.Provee_Rubro 
FROM gd_esquema.Maestra ma 
WHERE ma.Provee_Rubro IS NOT NULL);

/** INSERT DE USUARIO_PROVEEDOR**/
INSERT INTO RANDOM.Usuario (username, password, dni_cuit, id_rol, estado, fallas)
(SELECT DISTINCT ('u'+Provee_Cuit), 'pass123', Provee_Cuit, 3, 1, 0  FROM gd_esquema.Maestra
WHERE Provee_RS IS NOT NULL);

/** INSERT DE CIUDAD**/
INSERT INTO RANDOM.Ciudad (descripcion)
(SELECT DISTINCT Provee_Ciudad FROM gd_esquema.Maestra
WHERE Provee_Ciudad IS NOT NULL);

/** INSERT DE CIUDAD**/
INSERT INTO RANDOM.Ciudad(descripcion)
(SELECT DISTINCT Cli_Ciudad FROM gd_esquema.Maestra
WHERE Cli_Ciudad IS NOT NULL
and Cli_Ciudad NOT IN  (SELECT DISTINCT descripcion FROM RANDOM.Ciudad));


/** INSERT DE PROVEEDORES**/
INSERT INTO RANDOM.Proveedor (id_usuario, razon_social,telefono, 
direccion,id_ciudad, cuit, id_rubro)
(SELECT DISTINCT usu.id_usuario,Provee_RS, Provee_Telefono, Provee_Dom, ciu.id_ciudad, ma.Provee_CUIT , rub.id_rubro 
 FROM gd_esquema.Maestra ma
 LEFT JOIN RANDOM.Usuario usu ON (usu.dni_cuit = ma.Provee_CUIT)
 LEFT JOIN RANDOM.Ciudad ciu ON (ciu.descripcion = ma.Provee_Ciudad)
 LEFT JOIN RANDOM.Rubro rub ON (rub.desc_rubro = ma.Provee_Rubro)
 WHERE ma.Provee_RS IS NOT NULL);
 
 
 /** INSERT CUPONES**/
INSERT INTO RANDOM.Cupon (descripcion,fec_publicacion, fec_venc_consumo, precio_real, precio_ficticio, id_proveedor, cant_disp, publicados)
SELECT Groupon_Descripcion descripcion, Groupon_Fecha fec_publicacion, Groupon_Fecha_Venc fec_venc_consumo, Groupon_Precio precio_real, Groupon_Precio_Ficticio precio_ficticio, prov.id_usuario id_proveedor, Groupon_Cantidad cant_disp,0 publicado
FROM gd_esquema.Maestra ma
LEFT JOIN RANDOM.Proveedor prov ON (prov.cuit = ma.Provee_CUIT)
WHERE Groupon_Descripcion IS NOT NULL
GROUP BY Groupon_Descripcion, Groupon_Fecha, Groupon_Fecha_Venc, Groupon_Precio, Groupon_Precio_Ficticio, prov.id_usuario, Groupon_Cantidad


 
/** INSERT CLIENTE X CIUDAD **/
INSERT INTO RANDOM.Cliente_x_Ciudad (id_cliente, id_ciudad)
select DISTINCT cli.id_usuario, ciu.id_ciudad  
from gd_esquema.Maestra ma
left join RANDOM.Ciudad ciu ON (ciu.descripcion = ma.Cli_Ciudad)
left join RANDOM.Cliente cli ON (cli.dni = ma.Cli_Dni)
WHERE ma.Cli_Dni is not null
order by cli.id_usuario

/** INSERT FORMA_DE_PAGO**/
INSERT INTO RANDOM.Forma_de_Pago(descripcion)
SELECT DISTINCT Tipo_Pago_Desc FROM gd_esquema.Maestra
WHERE Tipo_Pago_Desc IS NOT NULL

/** INSERT CUPON X CIUDAD **/
INSERT INTO RANDOM.Cupon_x_ciudad (id_cupon, id_ciudad)
SELECT DISTINCT cup.id_cupon, ciu.id_ciudad
FROM gd_esquema.Maestra ma
LEFT JOIN RANDOM.Proveedor prov ON (prov.razon_social = ma.Provee_RS)
LEFT JOIN RANDOM.Cupon cup ON (cup.descripcion = ma.Groupon_Descripcion AND cup.fec_publicacion = ma.Groupon_Fecha AND cup.fec_venc_consumo = ma.Groupon_Fecha_Venc
AND cup.precio_real = ma.Groupon_Precio AND cup.precio_ficticio = ma.Groupon_Precio_Ficticio AND cup.id_proveedor = prov.id_usuario 
AND cup.cant_disp = ma.Groupon_Cantidad)LEFT JOIN RANDOM.Ciudad ciu ON (ciu.descripcion = ma.Cli_Ciudad)
WHERE ma.Groupon_Fecha_Compra is not null

/** INSERT CUPON COMPRADO**/
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

--PARA ARREGLAR LOS CODIGOS DE COMPRA REPETIDOS
WITH duplicates AS (
  SELECT
    ROW_NUMBER() OVER (PARTITION BY cc.codigo_compra ORDER BY codigo_compra) AS duplicate_id,
    *
  FROM
     RANDOM.Cupon_Comprado cc
)

UPDATE
  duplicates
SET
  codigo_compra = codigo_compra+'/1'
WHERE
  duplicate_id > 1;

WITH duplicates AS (
  SELECT
    ROW_NUMBER() OVER (PARTITION BY cc.codigo_compra ORDER BY codigo_compra) AS duplicate_id,
    *
  FROM
     RANDOM.Cupon_Comprado cc
)

UPDATE
  duplicates
SET
  codigo_compra = SUBSTRING(codigo_compra,0,LEN(codigo_compra)-1)+'/2'
WHERE
  duplicate_id > 1
  

/** INSERT CREDITO**/
INSERT INTO RANDOM.Credito (id_cliente, carga_credito, fecha, id_forma_pago)
SELECT cli.id_usuario, ma.Carga_Credito, ma.Carga_Fecha, fp.id_forma_pago            
FROM gd_esquema.Maestra ma
LEFT JOIN RANDOM.Forma_de_Pago fp ON (fp.descripcion = ma.Tipo_Pago_Desc)
LEFT JOIN.RANDOM.Cliente cli ON (cli.dni = ma.Cli_Dni)
WHERE Carga_Fecha IS NOT NULL

/** INSERT GIFT_CARD**/
INSERT INTO RANDOM.Gift_Card (fecha, monto, id_usuario_origen, id_usuario_destino)
SELECT ma.GiftCard_Fecha, ma.GiftCard_Monto, cli.id_usuario, clidest.id_usuario
FROM gd_esquema.Maestra ma
LEFT JOIN RANDOM.Cliente cli ON (ma.Cli_Dni = cli.dni)
LEFT JOIN RANDOM.Cliente clidest ON (ma.Cli_Dest_Dni = clidest.dni)
WHERE ma.GiftCard_Monto is not null

/** INSERT CUPON CANJEADO**/

INSERT INTO RANDOM.Cupon_Canjeado ( fecha_canje, id_compra, id_cliente, facturado)
SELECT ma.Groupon_Entregado_Fecha, cc.id_compra, cli.id_usuario,0
FROM gd_esquema.Maestra ma
LEFT JOIN RANDOM.Cupon_Comprado cc ON (cc.codigo_compra = ma.Groupon_Codigo)
LEFT JOIN RANDOM.Cupon cup ON (cup.id_cupon = cc.id_cupon)
LEFT JOIN RANDOM.Cliente cli ON (cli.dni = ma.Cli_Dni)
WHERE Groupon_Entregado_Fecha is not null

/** INSERT CUPON DEVUELTO **/


INSERT INTO RANDOM.Cupon_Devuelto (fecha_devolucion, id_compra, id_cliente, motivo_devolucion, codigo_compra)
SELECT ma.Groupon_Devolucion_Fecha, cc.id_compra, cli.id_usuario,' ', codigo_compra
FROM gd_esquema.Maestra ma
LEFT JOIN RANDOM.Cupon_Comprado cc ON (cc.codigo_compra = ma.Groupon_Codigo)
LEFT JOIN RANDOM.Cupon cup ON (cup.id_cupon = cc.id_cupon)
LEFT JOIN RANDOM.Cliente cli ON (cli.dni = ma.Cli_Dni)
WHERE ma.Groupon_Devolucion_Fecha is not null

/** INSERT FACTURA **/
INSERT INTO RANDOM.Factura(id_proveedor, nro_factura, fecha)
SELECT distinct pr.id_usuario, ma.Factura_Nro, ma.Factura_Fecha  FROM gd_esquema.Maestra ma
LEFT JOIN RANDOM.Proveedor pr ON (ma.Provee_CUIT = pr.cuit)
WHERE Factura_Nro IS NOT NULL



UPDATE RANDOM.Cupon SET max_compra_por_usuario = cc.cant FROM
(SELECT id_cupon,COUNT(*) cant FROM RANDOM.Cupon_Comprado 
GROUP BY id_cupon, id_cliente) cc
WHERE RANDOM.Cupon.id_cupon = cc.id_cupon 


/** INSERT DEL USUARIO ADMINISTRADOR**/
INSERT INTO RANDOM.Usuario (username, [password], id_rol, estado, fallas)
VALUES ('admin','w23e',1, 1, 0)

