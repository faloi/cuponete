USE [GD2C2012]
GO
/****** Object:  ForeignKey [FK_Cliente_x_Ciudad_Ciudad]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Cliente_x_Ciudad] DROP CONSTRAINT [FK_Cliente_x_Ciudad_Ciudad]
GO
/****** Object:  ForeignKey [FK_Cliente_x_Ciudad_Cliente]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Cliente_x_Ciudad] DROP CONSTRAINT [FK_Cliente_x_Ciudad_Cliente]
GO
/****** Object:  ForeignKey [FK_Credito_Cliente]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Credito] DROP CONSTRAINT [FK_Credito_Cliente]
GO
/****** Object:  ForeignKey [FK_Credito_Forma_de_Pago]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Credito] DROP CONSTRAINT [FK_Credito_Forma_de_Pago]
GO
/****** Object:  ForeignKey [FK_Cupon_Proveedor]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Cupon] DROP CONSTRAINT [FK_Cupon_Proveedor]
GO
/****** Object:  ForeignKey [FK_Cupon_Canjeado_Cliente]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Cupon_Canjeado] DROP CONSTRAINT [FK_Cupon_Canjeado_Cliente]
GO
/****** Object:  ForeignKey [FK_Cupon_Comprado_Cliente]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Cupon_Comprado] DROP CONSTRAINT [FK_Cupon_Comprado_Cliente]
GO
/****** Object:  ForeignKey [FK_Cupon_Comprado_Cupon]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Cupon_Comprado] DROP CONSTRAINT [FK_Cupon_Comprado_Cupon]
GO
/****** Object:  ForeignKey [FK_Cupon_Devuelto_Cliente]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Cupon_Devuelto] DROP CONSTRAINT [FK_Cupon_Devuelto_Cliente]
GO
/****** Object:  ForeignKey [FK_Cupon_Devuelto_Cupon_Comprado]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Cupon_Devuelto] DROP CONSTRAINT [FK_Cupon_Devuelto_Cupon_Comprado]
GO
/****** Object:  ForeignKey [FK_Cupon_Devuelto_Motivo_devolucion]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Cupon_Devuelto] DROP CONSTRAINT [FK_Cupon_Devuelto_Motivo_devolucion]
GO
/****** Object:  ForeignKey [FK_Cupon_x_ciudad_Ciudad]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Cupon_x_ciudad] DROP CONSTRAINT [FK_Cupon_x_ciudad_Ciudad]
GO
/****** Object:  ForeignKey [FK_Cupon_x_ciudad_Cupon]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Cupon_x_ciudad] DROP CONSTRAINT [FK_Cupon_x_ciudad_Cupon]
GO
/****** Object:  ForeignKey [FK_Factura_Proveedor]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Factura] DROP CONSTRAINT [FK_Factura_Proveedor]
GO
/****** Object:  ForeignKey [FK_Gift_Card_Cliente]    Script Date: 11/04/2012 15:06:48 ******/
ALTER TABLE [RANDOM].[Gift_Card] DROP CONSTRAINT [FK_Gift_Card_Cliente]
GO
/****** Object:  ForeignKey [FK_Gift_Card_Cliente1]    Script Date: 11/04/2012 15:06:48 ******/
ALTER TABLE [RANDOM].[Gift_Card] DROP CONSTRAINT [FK_Gift_Card_Cliente1]
GO
/****** Object:  ForeignKey [FK_Proveedor_Ciudad]    Script Date: 11/04/2012 15:06:48 ******/
ALTER TABLE [RANDOM].[Proveedor] DROP CONSTRAINT [FK_Proveedor_Ciudad]
GO
/****** Object:  ForeignKey [FK_Proveedor_Rubro]    Script Date: 11/04/2012 15:06:48 ******/
ALTER TABLE [RANDOM].[Proveedor] DROP CONSTRAINT [FK_Proveedor_Rubro]
GO
/****** Object:  ForeignKey [FK_Renglon_Factura_Cupon_Canjeado]    Script Date: 11/04/2012 15:06:48 ******/
ALTER TABLE [RANDOM].[Renglon_Factura] DROP CONSTRAINT [FK_Renglon_Factura_Cupon_Canjeado]
GO
/****** Object:  ForeignKey [FK_Renglon_Factura_Factura]    Script Date: 11/04/2012 15:06:48 ******/
ALTER TABLE [RANDOM].[Renglon_Factura] DROP CONSTRAINT [FK_Renglon_Factura_Factura]
GO
/****** Object:  ForeignKey [FK_Usuario_Cliente]    Script Date: 11/04/2012 15:06:48 ******/
ALTER TABLE [RANDOM].[Usuario] DROP CONSTRAINT [FK_Usuario_Cliente]
GO
/****** Object:  ForeignKey [FK_Usuario_Proveedor]    Script Date: 11/04/2012 15:06:48 ******/
ALTER TABLE [RANDOM].[Usuario] DROP CONSTRAINT [FK_Usuario_Proveedor]
GO
/****** Object:  ForeignKey [FK_Usuario_Rol]    Script Date: 11/04/2012 15:06:48 ******/
ALTER TABLE [RANDOM].[Usuario] DROP CONSTRAINT [FK_Usuario_Rol]
GO
/****** Object:  Table [RANDOM].[Cupon_Devuelto]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Cupon_Devuelto] DROP CONSTRAINT [FK_Cupon_Devuelto_Cliente]
GO
ALTER TABLE [RANDOM].[Cupon_Devuelto] DROP CONSTRAINT [FK_Cupon_Devuelto_Cupon_Comprado]
GO
ALTER TABLE [RANDOM].[Cupon_Devuelto] DROP CONSTRAINT [FK_Cupon_Devuelto_Motivo_devolucion]
GO
DROP TABLE [RANDOM].[Cupon_Devuelto]
GO
/****** Object:  Table [RANDOM].[Cupon_x_ciudad]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Cupon_x_ciudad] DROP CONSTRAINT [FK_Cupon_x_ciudad_Ciudad]
GO
ALTER TABLE [RANDOM].[Cupon_x_ciudad] DROP CONSTRAINT [FK_Cupon_x_ciudad_Cupon]
GO
DROP TABLE [RANDOM].[Cupon_x_ciudad]
GO
/****** Object:  Table [RANDOM].[Renglon_Factura]    Script Date: 11/04/2012 15:06:48 ******/
ALTER TABLE [RANDOM].[Renglon_Factura] DROP CONSTRAINT [FK_Renglon_Factura_Cupon_Canjeado]
GO
ALTER TABLE [RANDOM].[Renglon_Factura] DROP CONSTRAINT [FK_Renglon_Factura_Factura]
GO
DROP TABLE [RANDOM].[Renglon_Factura]
GO
/****** Object:  Table [RANDOM].[Cupon_Comprado]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Cupon_Comprado] DROP CONSTRAINT [FK_Cupon_Comprado_Cliente]
GO
ALTER TABLE [RANDOM].[Cupon_Comprado] DROP CONSTRAINT [FK_Cupon_Comprado_Cupon]
GO
DROP TABLE [RANDOM].[Cupon_Comprado]
GO
/****** Object:  Table [RANDOM].[Cupon]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Cupon] DROP CONSTRAINT [FK_Cupon_Proveedor]
GO
DROP TABLE [RANDOM].[Cupon]
GO
/****** Object:  Table [RANDOM].[Factura]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Factura] DROP CONSTRAINT [FK_Factura_Proveedor]
GO
DROP TABLE [RANDOM].[Factura]
GO
/****** Object:  Table [RANDOM].[Usuario]    Script Date: 11/04/2012 15:06:48 ******/
ALTER TABLE [RANDOM].[Usuario] DROP CONSTRAINT [FK_Usuario_Cliente]
GO
ALTER TABLE [RANDOM].[Usuario] DROP CONSTRAINT [FK_Usuario_Proveedor]
GO
ALTER TABLE [RANDOM].[Usuario] DROP CONSTRAINT [FK_Usuario_Rol]
GO
DROP TABLE [RANDOM].[Usuario]
GO
/****** Object:  Table [RANDOM].[Gift_Card]    Script Date: 11/04/2012 15:06:48 ******/
ALTER TABLE [RANDOM].[Gift_Card] DROP CONSTRAINT [FK_Gift_Card_Cliente]
GO
ALTER TABLE [RANDOM].[Gift_Card] DROP CONSTRAINT [FK_Gift_Card_Cliente1]
GO
DROP TABLE [RANDOM].[Gift_Card]
GO
/****** Object:  Table [RANDOM].[Proveedor]    Script Date: 11/04/2012 15:06:48 ******/
ALTER TABLE [RANDOM].[Proveedor] DROP CONSTRAINT [FK_Proveedor_Ciudad]
GO
ALTER TABLE [RANDOM].[Proveedor] DROP CONSTRAINT [FK_Proveedor_Rubro]
GO
DROP TABLE [RANDOM].[Proveedor]
GO
/****** Object:  Table [RANDOM].[Cupon_Canjeado]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Cupon_Canjeado] DROP CONSTRAINT [FK_Cupon_Canjeado_Cliente]
GO
DROP TABLE [RANDOM].[Cupon_Canjeado]
GO
/****** Object:  Table [RANDOM].[Cliente_x_Ciudad]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Cliente_x_Ciudad] DROP CONSTRAINT [FK_Cliente_x_Ciudad_Ciudad]
GO
ALTER TABLE [RANDOM].[Cliente_x_Ciudad] DROP CONSTRAINT [FK_Cliente_x_Ciudad_Cliente]
GO
DROP TABLE [RANDOM].[Cliente_x_Ciudad]
GO
/****** Object:  Table [RANDOM].[Credito]    Script Date: 11/04/2012 15:06:47 ******/
ALTER TABLE [RANDOM].[Credito] DROP CONSTRAINT [FK_Credito_Cliente]
GO
ALTER TABLE [RANDOM].[Credito] DROP CONSTRAINT [FK_Credito_Forma_de_Pago]
GO
DROP TABLE [RANDOM].[Credito]
GO
/****** Object:  Table [RANDOM].[Ciudad]    Script Date: 11/04/2012 15:06:46 ******/
DROP TABLE [RANDOM].[Ciudad]
GO
/****** Object:  Table [RANDOM].[Cliente]    Script Date: 11/04/2012 15:06:47 ******/
DROP TABLE [RANDOM].[Cliente]
GO
/****** Object:  Table [RANDOM].[Rol]    Script Date: 11/04/2012 15:06:48 ******/
DROP TABLE [RANDOM].[Rol]
GO
/****** Object:  Table [RANDOM].[Rubro]    Script Date: 11/04/2012 15:06:48 ******/
DROP TABLE [RANDOM].[Rubro]
GO
/****** Object:  Table [RANDOM].[Forma_de_Pago]    Script Date: 11/04/2012 15:06:48 ******/
DROP TABLE [RANDOM].[Forma_de_Pago]
GO
/****** Object:  Table [RANDOM].[Funcionalidad]    Script Date: 11/04/2012 15:06:48 ******/
DROP TABLE [RANDOM].[Funcionalidad]
GO
/****** Object:  Table [RANDOM].[Funcionalidad_x_Rol]    Script Date: 11/04/2012 15:06:48 ******/
DROP TABLE [RANDOM].[Funcionalidad_x_Rol]
GO
/****** Object:  Table [RANDOM].[Motivo_devolucion]    Script Date: 11/04/2012 15:06:48 ******/
DROP TABLE [RANDOM].[Motivo_devolucion]
GO
DROP VIEW [RANDOM].[Cupones_para_cliente]
/****** Object:  Schema [RANDOM]    Script Date: 11/04/2012 15:06:46 ******/
DROP SCHEMA [RANDOM]
GO