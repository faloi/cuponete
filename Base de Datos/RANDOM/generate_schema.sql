USE [GD2C2012]
GO
/****** Object:  Schema [RANDOM]    Script Date: 11/04/2012 17:29:41 ******/
CREATE SCHEMA [RANDOM] AUTHORIZATION [gd]
GO
/****** Object:  Table [RANDOM].[Motivo_devolucion]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Motivo_devolucion](
	[id_motivo] [bigint] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Motivo_devolucion] PRIMARY KEY CLUSTERED 
(
	[id_motivo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Funcionalidad_x_Rol]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Funcionalidad_x_Rol](
	[id_funcionalidad] [bigint] NOT NULL,
	[id_rol] [bigint] NOT NULL,
 CONSTRAINT [PK_Funcionalidad_x_Rol] PRIMARY KEY CLUSTERED 
(
	[id_funcionalidad] ASC,
	[id_rol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Funcionalidad]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Funcionalidad](
	[id_funcionalidad] [bigint] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Funcionalidad] PRIMARY KEY CLUSTERED 
(
	[id_funcionalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Forma_de_Pago]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Forma_de_Pago](
	[id_forma_pago] [bigint] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Forma_de_Pago] PRIMARY KEY CLUSTERED 
(
	[id_forma_pago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Rubro]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Rubro](
	[id_rubro] [bigint] IDENTITY(1,1) NOT NULL,
	[desc_rubro] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Rubro] PRIMARY KEY CLUSTERED 
(
	[id_rubro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Rol]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Rol](
	[id_rol] [bigint] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
	[estado] [numeric](1, 0) NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Cliente]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Cliente](
	[id_usuario] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](255) NOT NULL,
	[apellido] [nvarchar](255) NOT NULL,
	[dni] [numeric](18, 0) NOT NULL,
	[mail] [nvarchar](100) NOT NULL,
	[telefono] [numeric](18, 0) NOT NULL,
	[direccion] [nvarchar](255) NOT NULL,
	[cod_postal] [numeric](18, 0) NULL,
	[fecha_nac] [datetime] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UNQ_Cliente_telefono] UNIQUE NONCLUSTERED 
(
	[telefono] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Ciudad]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Ciudad](
	[id_ciudad] [bigint] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Ciudad] PRIMARY KEY CLUSTERED 
(
	[id_ciudad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Credito]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Credito](
	[id_credito] [bigint] IDENTITY(1,1) NOT NULL,
	[id_cliente] [bigint] NOT NULL,
	[carga_credito] [numeric](18, 2) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_forma_pago] [bigint] NOT NULL,
	[nro_tarjeta] [numeric](15, 0) NOT NULL,
	[cod_seguridad_tarjeta] [numeric](3, 0) NOT NULL,
	[fecha_vto_tarjeta] [datetime] NOT NULL,
 CONSTRAINT [PK_Credito] PRIMARY KEY CLUSTERED 
(
	[id_credito] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Cliente_x_Ciudad]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Cliente_x_Ciudad](
	[id_cliente] [int] NOT NULL,
	[id_ciudad] [int] NOT NULL,
CONSTRAINT [PK_Cliente_x_Ciudad] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC,
	[id_ciudad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Cupon_Canjeado]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Cupon_Canjeado](
	[id_canje] [bigint] IDENTITY(1,1) NOT NULL,
	[fecha_canje] [datetime] NOT NULL,
	[id_compra] [bigint] NOT NULL,
	[id_cliente] [bigint] NOT NULL,
	[facturado] [int] NULL,
 CONSTRAINT [PK_Cupon_Canjeado] PRIMARY KEY CLUSTERED 
(
	[id_canje] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Proveedor]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Proveedor](
	[id_usuario] [bigint] IDENTITY(1,1) NOT NULL,
	[razon_social] [nvarchar](100) NOT NULL,
	[mail] [nvarchar](100) NOT NULL,
	[telefono] [numeric](18, 0) NOT NULL,
	[direccion] [nvarchar](100) NOT NULL,
	[cod_postal] [numeric](10, 0) NOT NULL,
	[id_ciudad] [bigint] NOT NULL,
	[cuit] [nvarchar](20) NOT NULL,
	[id_rubro] [bigint] NOT NULL,
	[contacto_nombre] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UNQ_Proveedor_cuit] UNIQUE NONCLUSTERED 
(
	[cuit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UNQ_Proveedor_Razon_Socal] UNIQUE NONCLUSTERED 
(
	[razon_social] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Gift_Card]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Gift_Card](
	[id_gift_card] [bigint] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[monto] [numeric](18, 2) NOT NULL,
	[id_usuario_origen] [bigint] NOT NULL,
	[id_usuario_destino] [bigint] NOT NULL,
 CONSTRAINT [PK_Gift_Card] PRIMARY KEY CLUSTERED 
(
	[id_gift_card] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Usuario]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Usuario](
	[id_usuario] [bigint] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](255) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
	[id_rol] [bigint] NOT NULL,
	[tipo] [nvarchar](20) NOT NULL,
	[estado] [numeric](1, 0) NOT NULL,
	[fallas] [numeric](1, 0) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UNQ_Usuario_telefono] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Factura]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Factura](
	[id_factura] [bigint] NOT NULL,
	[nro_factura] [numeric](18, 0) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_proveedor] [bigint] NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Cupon]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Cupon](
	[id_cupon] [bigint] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](255) NOT NULL,
	[fec_publicacion] [datetime] NOT NULL,
	[fec_venc_consumo] [datetime] NOT NULL,
	[precio_real] [numeric](18, 2) NOT NULL,
	[precio_ficticio] [numeric](18, 2) NOT NULL,
	[id_proveedor] [bigint] NOT NULL,
	[cant_disp] [numeric](18, 0) NOT NULL,
	[max_compra_por_usuario] [numeric](18, 0) NOT NULL,
	[publicados] [numeric](1, 0) NOT NULL,
 CONSTRAINT [PK_Cupon] PRIMARY KEY CLUSTERED 
(
	[id_cupon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Cupon_Comprado]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Cupon_Comprado](
	[id_compra] [bigint] IDENTITY(1,1) NOT NULL,
	[fecha_compra] [datetime] NOT NULL,
	[id_cupon] [bigint] NOT NULL,
	[id_cliente] [bigint] NOT NULL,
	[descripcion] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Cupon_Comprado] PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Renglon_Factura]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Renglon_Factura](
	[id_cupon_canjeado] [int] NOT NULL,
	[id_factura] [int] NOT NULL,
 CONSTRAINT [PK_Renglon_Factura] PRIMARY KEY CLUSTERED 
(
	[id_cupon_canjeado] ASC,
	[id_factura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Cupon_x_ciudad]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Cupon_x_ciudad](
		[id_cupon] [int] NOT NULL,
	[id_ciudad] [int] NOT NULL,
 CONSTRAINT [PK_Cupon_x_ciudad] PRIMARY KEY CLUSTERED 
(
	[id_cupon] ASC,
	[id_ciudad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Cupon_Devuelto]    Script Date: 11/04/2012 17:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Cupon_Devuelto](
	[id_devolucion] [bigint] IDENTITY(1,1) NOT NULL,
	[fecha_devolucion] [datetime] NOT NULL,
	[id_cliente] [bigint] NOT NULL,
	[id_compra] [bigint] NOT NULL,
	[motivo_devolucion_id] [bigint] NOT NULL,
 CONSTRAINT [PK_Cupon_Devuelto] PRIMARY KEY CLUSTERED 
(
	[id_devolucion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Cliente_x_Ciudad_Ciudad]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Cliente_x_Ciudad]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_x_Ciudad_Ciudad] FOREIGN KEY([id_ciudad])
REFERENCES [RANDOM].[Ciudad] ([id_ciudad])
GO
ALTER TABLE [RANDOM].[Cliente_x_Ciudad] CHECK CONSTRAINT [FK_Cliente_x_Ciudad_Ciudad]
GO
/****** Object:  ForeignKey [FK_Cliente_x_Ciudad_Cliente]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Cliente_x_Ciudad]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_x_Ciudad_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [RANDOM].[Cliente] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Cliente_x_Ciudad] CHECK CONSTRAINT [FK_Cliente_x_Ciudad_Cliente]
GO
/****** Object:  ForeignKey [FK_Credito_Cliente]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Credito]  WITH CHECK ADD  CONSTRAINT [FK_Credito_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [RANDOM].[Cliente] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Credito] CHECK CONSTRAINT [FK_Credito_Cliente]
GO
/****** Object:  ForeignKey [FK_Credito_Forma_de_Pago]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Credito]  WITH CHECK ADD  CONSTRAINT [FK_Credito_Forma_de_Pago] FOREIGN KEY([id_forma_pago])
REFERENCES [RANDOM].[Forma_de_Pago] ([id_forma_pago])
GO
ALTER TABLE [RANDOM].[Credito] CHECK CONSTRAINT [FK_Credito_Forma_de_Pago]
GO
/****** Object:  ForeignKey [FK_Cupon_Proveedor]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Cupon]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_Proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [RANDOM].[Proveedor] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Cupon] CHECK CONSTRAINT [FK_Cupon_Proveedor]
GO
/****** Object:  ForeignKey [FK_Cupon_Canjeado_Cliente]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Cupon_Canjeado]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_Canjeado_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [RANDOM].[Cliente] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Cupon_Canjeado] CHECK CONSTRAINT [FK_Cupon_Canjeado_Cliente]
GO
/****** Object:  ForeignKey [FK_Cupon_Comprado_Cliente]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Cupon_Comprado]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_Comprado_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [RANDOM].[Cliente] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Cupon_Comprado] CHECK CONSTRAINT [FK_Cupon_Comprado_Cliente]
GO
/****** Object:  ForeignKey [FK_Cupon_Comprado_Cupon]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Cupon_Comprado]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_Comprado_Cupon] FOREIGN KEY([id_cupon])
REFERENCES [RANDOM].[Cupon] ([id_cupon])
GO
ALTER TABLE [RANDOM].[Cupon_Comprado] CHECK CONSTRAINT [FK_Cupon_Comprado_Cupon]
GO
/****** Object:  ForeignKey [FK_Cupon_Devuelto_Cliente]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Cupon_Devuelto]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_Devuelto_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [RANDOM].[Cliente] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Cupon_Devuelto] CHECK CONSTRAINT [FK_Cupon_Devuelto_Cliente]
GO
/****** Object:  ForeignKey [FK_Cupon_Devuelto_Cupon_Comprado]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Cupon_Devuelto]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_Devuelto_Cupon_Comprado] FOREIGN KEY([id_compra])
REFERENCES [RANDOM].[Cupon_Comprado] ([id_compra])
GO
ALTER TABLE [RANDOM].[Cupon_Devuelto] CHECK CONSTRAINT [FK_Cupon_Devuelto_Cupon_Comprado]
GO
/****** Object:  ForeignKey [FK_Cupon_Devuelto_Motivo_devolucion]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Cupon_Devuelto]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_Devuelto_Motivo_devolucion] FOREIGN KEY([motivo_devolucion_id])
REFERENCES [RANDOM].[Motivo_devolucion] ([id_motivo])
GO
ALTER TABLE [RANDOM].[Cupon_Devuelto] CHECK CONSTRAINT [FK_Cupon_Devuelto_Motivo_devolucion]
GO
/****** Object:  ForeignKey [FK_Cupon_x_ciudad_Ciudad]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Cupon_x_ciudad]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_x_ciudad_Ciudad] FOREIGN KEY([id_ciudad])
REFERENCES [RANDOM].[Ciudad] ([id_ciudad])
GO
ALTER TABLE [RANDOM].[Cupon_x_ciudad] CHECK CONSTRAINT [FK_Cupon_x_ciudad_Ciudad]
GO
/****** Object:  ForeignKey [FK_Cupon_x_ciudad_Cupon]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Cupon_x_ciudad]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_x_ciudad_Cupon] FOREIGN KEY([id_cupon])
REFERENCES [RANDOM].[Cupon] ([id_cupon])
GO
ALTER TABLE [RANDOM].[Cupon_x_ciudad] CHECK CONSTRAINT [FK_Cupon_x_ciudad_Cupon]
GO
/****** Object:  ForeignKey [FK_Factura_Proveedor]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [RANDOM].[Proveedor] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Factura] CHECK CONSTRAINT [FK_Factura_Proveedor]
GO
/****** Object:  ForeignKey [FK_Gift_Card_Cliente]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Gift_Card]  WITH CHECK ADD  CONSTRAINT [FK_Gift_Card_Cliente] FOREIGN KEY([id_usuario_origen])
REFERENCES [RANDOM].[Cliente] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Gift_Card] CHECK CONSTRAINT [FK_Gift_Card_Cliente]
GO
/****** Object:  ForeignKey [FK_Gift_Card_Cliente1]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Gift_Card]  WITH CHECK ADD  CONSTRAINT [FK_Gift_Card_Cliente1] FOREIGN KEY([id_usuario_destino])
REFERENCES [RANDOM].[Cliente] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Gift_Card] CHECK CONSTRAINT [FK_Gift_Card_Cliente1]
GO
/****** Object:  ForeignKey [FK_Proveedor_Ciudad]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor_Ciudad] FOREIGN KEY([id_ciudad])
REFERENCES [RANDOM].[Ciudad] ([id_ciudad])
GO
ALTER TABLE [RANDOM].[Proveedor] CHECK CONSTRAINT [FK_Proveedor_Ciudad]
GO
/****** Object:  ForeignKey [FK_Proveedor_Rubro]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor_Rubro] FOREIGN KEY([id_rubro])
REFERENCES [RANDOM].[Rubro] ([id_rubro])
GO
ALTER TABLE [RANDOM].[Proveedor] CHECK CONSTRAINT [FK_Proveedor_Rubro]
GO
/****** Object:  ForeignKey [FK_Renglon_Factura_Cupon_Canjeado]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Renglon_Factura]  WITH CHECK ADD  CONSTRAINT [FK_Renglon_Factura_Cupon_Canjeado] FOREIGN KEY([id_cupon_canjeado])
REFERENCES [RANDOM].[Cupon_Canjeado] ([id_canje])
GO
ALTER TABLE [RANDOM].[Renglon_Factura] CHECK CONSTRAINT [FK_Renglon_Factura_Cupon_Canjeado]
GO
/****** Object:  ForeignKey [FK_Renglon_Factura_Factura]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Renglon_Factura]  WITH CHECK ADD  CONSTRAINT [FK_Renglon_Factura_Factura] FOREIGN KEY([id_factura])
REFERENCES [RANDOM].[Factura] ([id_factura])
GO
ALTER TABLE [RANDOM].[Renglon_Factura] CHECK CONSTRAINT [FK_Renglon_Factura_Factura]
GO
/****** Object:  ForeignKey [FK_Usuario_Cliente]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Cliente] FOREIGN KEY([id_usuario])
REFERENCES [RANDOM].[Cliente] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Usuario] CHECK CONSTRAINT [FK_Usuario_Cliente]
GO
/****** Object:  ForeignKey [FK_Usuario_Proveedor]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Proveedor] FOREIGN KEY([id_usuario])
REFERENCES [RANDOM].[Proveedor] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Usuario] CHECK CONSTRAINT [FK_Usuario_Proveedor]
GO
/****** Object:  ForeignKey [FK_Usuario_Rol]    Script Date: 11/04/2012 17:29:46 ******/
ALTER TABLE [RANDOM].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([id_rol])
REFERENCES [RANDOM].[Rol] ([id_rol])
GO
ALTER TABLE [RANDOM].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol]
GO