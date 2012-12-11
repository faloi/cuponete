USE [GD2C2012]
GO

drop trigger RANDOM.inhabilitar_rol

drop view RANDOM.Cupones_Para_Cliente
drop view RANDOM.Historial_Compra_Cupones
drop view RANDOM.Facturacion_Proveedor
drop view RANDOM.Porcentaje_Devolucion
drop view RANDOM.Estadistica_Giftcards

drop procedure RANDOM.AgregarCuponPorCiudad
drop procedure RANDOM.QuitarCuponPorCiudad
drop procedure RANDOM.RegistrarConsumo
drop procedure RANDOM.CargarCredito
drop procedure RANDOM.ComprarGiftCard
drop procedure RANDOM.ComprarCupon
drop procedure RANDOM.PedirDevolucionCupon
drop procedure RANDOM.DevolverCupon
drop procedure RANDOM.PublicarCupon
drop procedure RANDOM.ArmarCupon
drop procedure RANDOM.ModificarUsuario
drop procedure RANDOM.HabilitarUsuario
drop procedure RANDOM.DeshabilitarUsuario
drop procedure RANDOM.CambiarRol
drop PROCEDURE RANDOM.IncrementarFallas
drop procedure RANDOM.AgregarRol
drop procedure RANDOM.AgregarFuncionalidadPorRol
drop procedure RANDOM.QuitarFuncionalidadPorRol
drop procedure RANDOM.CambiarNombreRol
drop procedure RANDOM.HabilitarRol
drop procedure RANDOM.DeshabilitarRol
drop procedure RANDOM.RegistrarProveedor
drop procedure RANDOM.ModificarProveedor
drop procedure RANDOM.RegistrarCliente
drop procedure RANDOM.ModificarCliente
drop procedure RANDOM.AgregarClientePorCiudad
drop procedure RANDOM.QuitarClientePorCiudad
drop procedure RANDOM.ReiniciarFallas
drop procedure RANDOM.FacturarCupones

DROP TABLE [RANDOM].[Cupon_Devuelto]
DROP TABLE [RANDOM].[Cupon_x_ciudad]
DROP TABLE [RANDOM].[Renglon_Factura]
DROP TABLE [RANDOM].[Factura]
DROP TABLE [RANDOM].[Gift_Card]
DROP TABLE [RANDOM].[Proveedor]
DROP TABLE [RANDOM].[Cupon_Canjeado]
DROP TABLE [RANDOM].[Cupon_Comprado]
DROP TABLE [RANDOM].[Cupon]
DROP TABLE [RANDOM].[Cliente_x_Ciudad]
DROP TABLE [RANDOM].[Credito]
DROP TABLE [RANDOM].[Ciudad]
DROP TABLE [RANDOM].[Cliente]
DROP TABLE [RANDOM].[Usuario]
DROP TABLE [RANDOM].[Rubro]
DROP TABLE [RANDOM].[Forma_de_Pago]
DROP TABLE [RANDOM].[Funcionalidad_x_Rol]
DROP TABLE [RANDOM].[Funcionalidad]
DROP TABLE [RANDOM].[Rol]

DROP SCHEMA RANDOM