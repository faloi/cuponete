USE [GD2C2012]

GO
/****** Object:  Schema [RANDOM]    Script Date: 04/15/2012 01:58:54 ******/
CREATE SCHEMA [RANDOM] AUTHORIZATION [gd]
GO


GO
/****** Object:  Table [RANDOM].[Cliente]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Cliente](
  [id_usuario] [int] IDENTITY(1,1),
	[nombre] [nvarchar](255) NOT NULL,
	[apellido] [nvarchar](255) NOT NULL,
	[dni] [numeric](18, 0) NOT NULL,
	[mail] [nvarchar](100) NOT NULL,
	[telefono] [numeric](18, 0) NOT NULL,
	[direccion] [nvarchar](255) NOT NULL,
	[cod_postal] [numeric](18, 0) NOT NULL,
	[fecha_nac] [datetime] NOT NULL,	
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Ciudad]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Ciudad](
	[id_ciudad] [int] IDENTITY(1,1),
	[descripcion] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Ciudad] PRIMARY KEY CLUSTERED 
(
	[id_ciudad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Funcionalidad]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Funcionalidad](
	[id_funcionalidad] [int] IDENTITY(1,1),
	[descripcion] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Funcionalidad] PRIMARY KEY CLUSTERED 
(
	[id_funcionalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Forma_de_Pago]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Forma_de_Pago](
	[id_forma_pago] [int] IDENTITY(1,1),
	[descripcion] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Forma_de_Pago] PRIMARY KEY CLUSTERED 
(
	[id_forma_pago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [RANDOM].[Factura]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Factura](
	[id_factura] [int] NOT NULL,
	[nro_factura] [numeric](18, 0) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_proveedor] [int] NOT NULL
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
/****** Object:  Table [RANDOM].[Renglon_Factura]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Renglon_Factura](
	[id_renglon_factura] [int] IDENTITY,
	[id_cupon_canjeado] [int] NOT NULL,
  [id_factura] [int] NOT NULL,
 CONSTRAINT [PK_Renglon_Factura] PRIMARY KEY CLUSTERED 
(
	[id_renglon_factura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
/****** Object:  Table [RANDOM].[Motivo_devolucion]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Motivo_devolucion](
	[id_motivo] [int] IDENTITY(1,1),
	[descripcion] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Motivo_devolucion] PRIMARY KEY CLUSTERED 
(
	[id_motivo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Rubro]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Rubro](
	[id_rubro] [int] IDENTITY(1,1),
	[desc_rubro] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Rubro] PRIMARY KEY CLUSTERED 
(
	[id_rubro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Rol]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Rol](
	[id_rol] [int] IDENTITY(1,1),
  [tipo_usuario] [nvarchar](255) NOT NULL,	
	[descripcion] [nvarchar](50) NOT NULL,
	[estado] [numeric](1, 0)NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Proveedor]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Proveedor](
	[id_usuario] [int] IDENTITY(1,1),
	[razon_social] [nvarchar](100) NOT NULL,
	[mail] [nvarchar](100) NOT NULL,
	[telefono] [numeric](18, 0) NOT NULL,
	[direccion] [nvarchar](100) NOT NULL,
	[cod_postal] [numeric](10, 0) NOT NULL,
	[id_ciudad] [int] NOT NULL,
	[cuit] [nvarchar](20) NOT NULL,
	[id_rubro] [int] NOT NULL,
	[contacto_nombre] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Gift_Card]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Gift_Card](
	[id_gift_card] [int] IDENTITY(1,1),
	[fecha] [datetime] NOT NULL,
	[monto] [numeric](18, 2) NOT NULL,
	[id_usuario_origen] [int] NOT NULL,
	[id_usuario_destino] [int] NOT NULL,
 CONSTRAINT [PK_Gift_Card] PRIMARY KEY CLUSTERED 
(
	[id_gift_card] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Funcionalidad_x_Rol]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Funcionalidad_x_Rol](
	[id_funcionalidad] [int] NOT NULL,
	[id_rol] [int] NOT NULL,
 CONSTRAINT [PK_Funcionalidad_x_Rol] PRIMARY KEY CLUSTERED 
(
	[id_funcionalidad] ASC,
  [id_rol] ASC
  
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [RANDOM].[Credito]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Credito](
	[id_credito] [int] IDENTITY(1,1),
	[id_cliente] [int] NOT NULL,
	[carga_credito] [numeric](18, 2) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_forma_pago] [int] NOT NULL,
	[nro_tarjeta] [numeric](15, 0) NOT NULL,
	[cod_seguridad_tarjeta] [numeric](3, 0) NOT NULL,
	[fecha_vto_tarjeta] [datetime] NOT NULL,
 CONSTRAINT [PK_Credito] PRIMARY KEY CLUSTERED 
(
	[id_credito] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Cliente_x_Ciudad]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Cliente_x_Ciudad](
	[id_cliente_ciudad] [int] IDENTITY(1,1),
	[id_cliente] [int] NOT NULL,
	[id_ciudad] [int] NOT NULL,
 CONSTRAINT [PK_Cliente_x_Ciudad] PRIMARY KEY CLUSTERED 
(
	[id_cliente_ciudad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Usuario]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Usuario](
	[id_usuario] [int] IDENTITY(1,1),
	[login_name] [nvarchar](255) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
	[id_rol] [int] NOT NULL,
	[tipo] [nvarchar](255) NOT NULL,
	[estado] [numeric](1, 0) NOT NULL,
	[fallas] [numeric](1, 0) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Cupon]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Cupon](
	[id_cupon] [int] IDENTITY(1,1),
	[descripcion] [nvarchar](255) NOT NULL,
	[fec_publicacion] [datetime] NOT NULL,
	[fec_venc_consumo] [datetime] NOT NULL,
	[precio_real] [numeric](18, 2) NOT NULL,
	[precio_ficticio] [numeric](18, 2) NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[cant_disp] [numeric](18, 0) NOT NULL,
	[max_compra_por_usuario] [numeric](18, 0) NOT NULL,
	[publicados] [numeric](1, 0) NOT NULL,
 CONSTRAINT [PK_Cupon] PRIMARY KEY CLUSTERED 
(
	[id_cupon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Cupon_Comprado]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Cupon_Comprado](
	[id_compra] [int] IDENTITY(1,1),
	[fecha_compra] [datetime] NOT NULL,
	[id_cupon] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[descripcion] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Cupon_Comprado] PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Cupon_x_ciudad]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Cupon_x_ciudad](
	[id_cupon_ciudad] [int] IDENTITY(1,1),
	[id_cupon] [int] NOT NULL,
	[id_ciudad] [int] NOT NULL,
 CONSTRAINT [PK_Cupon_x_ciudad] PRIMARY KEY CLUSTERED 
(
	[id_cupon_ciudad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [RANDOM].[Cupon_Devuelto]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Cupon_Devuelto](
	[id_devolucion] [int] IDENTITY(1,1),
	[fecha_devolucion] [datetime] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_compra] [int] NOT NULL,
	[motivo_devolucion_id] [int] NOT NULL,
 CONSTRAINT [PK_Cupon_Devuelto] PRIMARY KEY CLUSTERED 
(
	[id_devolucion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [RANDOM].[Cupon_Canjeado]    Script Date: 11/01/2012 17:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [RANDOM].[Cupon_Canjeado](
	[id_canje] [int] IDENTITY(1,1),
	[fecha_canje] [datetime] NOT NULL,
	[id_compra] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[facturado] [numeric](1, 0),
 CONSTRAINT [PK_Cupon_Canjeado] PRIMARY KEY CLUSTERED 
(
	[id_canje] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  ForeignKey [FK_Cliente_x_Ciudad_Ciudad]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Cliente_x_Ciudad]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_x_Ciudad_Ciudad] FOREIGN KEY([id_ciudad])
REFERENCES [RANDOM].[Ciudad] ([id_ciudad])
GO
ALTER TABLE [RANDOM].[Cliente_x_Ciudad] CHECK CONSTRAINT [FK_Cliente_x_Ciudad_Ciudad]
GO
/****** Object:  ForeignKey [FK_Cliente_x_Ciudad_Cliente]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Cliente_x_Ciudad]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_x_Ciudad_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [RANDOM].[Cliente] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Cliente_x_Ciudad] CHECK CONSTRAINT [FK_Cliente_x_Ciudad_Cliente]
GO
/****** Object:  ForeignKey [FK_Credito_Cliente]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Credito]  WITH CHECK ADD  CONSTRAINT [FK_Credito_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [RANDOM].[Cliente] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Credito] CHECK CONSTRAINT [FK_Credito_Cliente]
GO
/****** Object:  ForeignKey [FK_Credito_Forma_de_Pago]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Credito]  WITH CHECK ADD  CONSTRAINT [FK_Credito_Forma_de_Pago] FOREIGN KEY([id_forma_pago])
REFERENCES [RANDOM].[Forma_de_Pago] ([id_forma_pago])
GO
ALTER TABLE [RANDOM].[Credito] CHECK CONSTRAINT [FK_Credito_Forma_de_Pago]
GO
/****** Object:  ForeignKey [FK_Cupon_Proveedor]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Cupon]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_Proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [RANDOM].[Proveedor] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Cupon] CHECK CONSTRAINT [FK_Cupon_Proveedor]
GO
/****** Object:  ForeignKey [FK_Cupon_Canjeado_Cliente]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Cupon_Canjeado]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_Canjeado_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [RANDOM].[Cliente] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Cupon_Canjeado] CHECK CONSTRAINT [FK_Cupon_Canjeado_Cliente]
GO
/****** Object:  ForeignKey [FK_Cupon_Canjeado_Cupon_Comprado]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Cupon_Canjeado]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_Canjeado_Cupon_Comprado] FOREIGN KEY([id_compra])
REFERENCES [RANDOM].[Cupon_Comprado] ([id_compra])
GO
ALTER TABLE [RANDOM].[Cupon_Canjeado] CHECK CONSTRAINT [FK_Cupon_Canjeado_Cupon_Comprado]
GO
/****** Object:  ForeignKey [FK_Cupon_Comprado_Cliente]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Cupon_Comprado]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_Comprado_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [RANDOM].[Cliente] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Cupon_Comprado] CHECK CONSTRAINT [FK_Cupon_Comprado_Cliente]
GO
/****** Object:  ForeignKey [FK_Cupon_Comprado_Cupon]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Cupon_Comprado]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_Comprado_Cupon] FOREIGN KEY([id_cupon])
REFERENCES [RANDOM].[Cupon] ([id_cupon])
GO
ALTER TABLE [RANDOM].[Cupon_Comprado] CHECK CONSTRAINT [FK_Cupon_Comprado_Cupon]
GO
/****** Object:  ForeignKey [FK_Cupon_Devuelto_Cliente]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Cupon_Devuelto]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_Devuelto_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [RANDOM].[Cliente] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Cupon_Devuelto] CHECK CONSTRAINT [FK_Cupon_Devuelto_Cliente]
GO
/****** Object:  ForeignKey [FK_Cupon_Devuelto_Cupon_Comprado]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Cupon_Devuelto]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_Devuelto_Cupon_Comprado] FOREIGN KEY([id_compra])
REFERENCES [RANDOM].[Cupon_Comprado] ([id_compra])
GO
ALTER TABLE [RANDOM].[Cupon_Devuelto] CHECK CONSTRAINT [FK_Cupon_Devuelto_Cupon_Comprado]
GO
/****** Object:  ForeignKey [FK_Cupon_Devuelto_Motivo_devolucion]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Cupon_Devuelto]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_Devuelto_Motivo_devolucion] FOREIGN KEY([motivo_devolucion_id])
REFERENCES [RANDOM].[Motivo_devolucion] ([id_motivo])
GO
ALTER TABLE [RANDOM].[Cupon_Devuelto] CHECK CONSTRAINT [FK_Cupon_Devuelto_Motivo_devolucion]
GO
/****** Object:  ForeignKey [FK_Cupon_x_ciudad_Ciudad]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Cupon_x_ciudad]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_x_ciudad_Ciudad] FOREIGN KEY([id_ciudad])
REFERENCES [RANDOM].[Ciudad] ([id_ciudad])
GO
ALTER TABLE [RANDOM].[Cupon_x_ciudad] CHECK CONSTRAINT [FK_Cupon_x_ciudad_Ciudad]
GO
/****** Object:  ForeignKey [FK_Cupon_x_ciudad_Cupon]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Cupon_x_ciudad]  WITH CHECK ADD  CONSTRAINT [FK_Cupon_x_ciudad_Cupon] FOREIGN KEY([id_cupon])
REFERENCES [RANDOM].[Cupon] ([id_cupon])
GO
ALTER TABLE [RANDOM].[Cupon_x_ciudad] CHECK CONSTRAINT [FK_Cupon_x_ciudad_Cupon]
GO
/****** Object:  ForeignKey [FK_Funcionalidad_x_Rol_Funcionalidad]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Funcionalidad_x_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Funcionalidad_x_Rol_Funcionalidad] FOREIGN KEY([id_funcionalidad])
REFERENCES [RANDOM].[Funcionalidad] ([id_funcionalidad])
GO
ALTER TABLE [RANDOM].[Funcionalidad_x_Rol] CHECK CONSTRAINT [FK_Funcionalidad_x_Rol_Funcionalidad]
GO
/****** Object:  ForeignKey [FK_Funcionalidad_x_Rol_Rol]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Funcionalidad_x_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Funcionalidad_x_Rol_Rol] FOREIGN KEY([id_rol])
REFERENCES [RANDOM].[Rol] ([id_rol])
GO
ALTER TABLE [RANDOM].[Funcionalidad_x_Rol] CHECK CONSTRAINT [FK_Funcionalidad_x_Rol_Rol]
GO
/****** Object:  ForeignKey [FK_Gift_Card_Cliente]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Gift_Card]  WITH CHECK ADD  CONSTRAINT [FK_Gift_Card_Cliente] FOREIGN KEY([id_usuario_origen])
REFERENCES [RANDOM].[Cliente] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Gift_Card] CHECK CONSTRAINT [FK_Gift_Card_Cliente]
GO
/****** Object:  ForeignKey [FK_Gift_Card_Cliente1]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Gift_Card]  WITH CHECK ADD  CONSTRAINT [FK_Gift_Card_Cliente1] FOREIGN KEY([id_usuario_destino])
REFERENCES [RANDOM].[Cliente] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Gift_Card] CHECK CONSTRAINT [FK_Gift_Card_Cliente1]
GO
/****** Object:  ForeignKey [FK_Proveedor_Ciudad]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor_Ciudad] FOREIGN KEY([id_ciudad])
REFERENCES [RANDOM].[Ciudad] ([id_ciudad])
GO
ALTER TABLE [RANDOM].[Proveedor] CHECK CONSTRAINT [FK_Proveedor_Ciudad]
GO
/****** Object:  ForeignKey [FK_Proveedor_Rubro]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor_Rubro] FOREIGN KEY([id_rubro])
REFERENCES [RANDOM].[Rubro] ([id_rubro])
GO
ALTER TABLE [RANDOM].[Proveedor] CHECK CONSTRAINT [FK_Proveedor_Rubro]
GO
/****** Object:  ForeignKey [FK_Usuario_Cliente]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Cliente] FOREIGN KEY([id_usuario])
REFERENCES [RANDOM].[Cliente] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Usuario] CHECK CONSTRAINT [FK_Usuario_Cliente]
GO
/****** Object:  ForeignKey [FK_Usuario_Proveedor]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Proveedor] FOREIGN KEY([id_usuario])
REFERENCES [RANDOM].[Proveedor] ([id_usuario])
GO
ALTER TABLE [RANDOM].[Usuario] CHECK CONSTRAINT [FK_Usuario_Proveedor]
GO
/****** Object:  ForeignKey [FK_Usuario_Rol]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([id_rol])
REFERENCES [RANDOM].[Rol] ([id_rol])
GO
ALTER TABLE [RANDOM].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol]
GO
GO
/****** Object:  ForeignKey [FK_Factura_Proveedor]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [RANDOM].[Proveedor] ([id_usuario])
GO
GO
/****** Object:  ForeignKey [FK_Renglon_Factura_Cupon_Canjeado]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Renglon_Factura]  WITH CHECK ADD  CONSTRAINT [FK_Renglon_Factura_Cupon_Canjeado] FOREIGN KEY([id_cupon_canjeado])
REFERENCES [RANDOM].[Cupon_Canjeado] ([id_canje])
GO
GO
/****** Object:  ForeignKey [FK_Renglon_Factura_Factura]    Script Date: 11/01/2012 17:22:14 ******/
ALTER TABLE [RANDOM].[Renglon_Factura]  WITH CHECK ADD  CONSTRAINT [FK_Renglon_Factura_Factura] FOREIGN KEY([id_factura])
REFERENCES [RANDOM].[Factura] ([id_factura])
GO

/**CONSTRAINT UNIQUE******/

GO
ALTER TABLE RANDOM.Proveedor ADD CONSTRAINT UNQ_Proveedor_Razon_Socal UNIQUE ([razon_social])
GO
GO
ALTER TABLE RANDOM.Proveedor ADD CONSTRAINT UNQ_Proveedor_cuit UNIQUE ([cuit])
GO
GO
ALTER TABLE RANDOM.Cliente ADD CONSTRAINT UNQ_Cliente_telefono UNIQUE ([telefono])
GO
GO
ALTER TABLE RANDOM.Usuario ADD CONSTRAINT UNQ_Usuario_telefono UNIQUE ([login_name])
GO

