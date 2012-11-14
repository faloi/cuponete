/** CREACION DE VISTA DE CUPONES PARA CLIENTE**/
CREATE VIEW RANDOM.Cupones_Para_Cliente
AS
SELECT cu.id_cupon,cu.descripcion,cu.fec_publicacion,cu.precio_ficticio, cu.precio_real,cpc.id_cliente
FROM RANDOM.Cupon cu 
LEFT JOIN RANDOM.Cupon_x_ciudad cupc ON (cUpc.id_cupon = cu.id_cupon)
LEFT JOIN RANDOM.Cliente_x_Ciudad cpc ON (cpc.id_ciudad = cupc.id_ciudad)
WHERE cu.publicados = 1
