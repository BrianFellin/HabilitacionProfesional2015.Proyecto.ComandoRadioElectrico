/******Primero se debe crear la base de datos "ComandoRadioElectrico" y luego se ejecuta una nueva consulta con estos datos*******/
/******en la consulta (USE [ComandoRadioElectrico] el nombre de la base de datos debe ser ComandoRadioElectrico para que funcione)*******/

USE [ComandoRadioElectrico]
GO
/****** Object:  Table [dbo].[PeriodoGenerado]    Script Date: 08/28/2015 17:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PeriodoGenerado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Mes] [varchar](50) NOT NULL,
	[Año] [int] NOT NULL,
 CONSTRAINT [PK_PeriodoGenerado] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoMovimiento]    Script Date: 08/28/2015 17:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoMovimiento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](20) NULL,
 CONSTRAINT [PK_TipoMovimiento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 08/28/2015 17:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoDocumento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](20) NOT NULL,
 CONSTRAINT [PK_TipoDocumento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoCuenta]    Script Date: 08/28/2015 17:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoCuenta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](20) NULL,
 CONSTRAINT [PK_TipoCuenta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Balance]    Script Date: 08/28/2015 17:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Balance](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaDesde] [date] NULL,
	[FechaHasta] [date] NULL,
	[FechaRealizacion] [date] NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Balance] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CuentaContable]    Script Date: 08/28/2015 17:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CuentaContable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](100) NULL,
	[Nombre] [varchar](100) NULL,
	[Descripcion] [varchar](100) NULL,
	[IdTipoCuenta] [int] NULL,
	[Saldo] [decimal](18, 3) NULL,
 CONSTRAINT [PK_CuentaContable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [unique_code] UNIQUE NONCLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cobrador]    Script Date: 08/28/2015 17:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cobrador](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Apellido] [varchar](100) NULL,
	[IdTipoDocumento] [int] NULL,
	[NumeroDocumento] [varchar](50) NULL,
	[Domicilio] [varchar](100) NULL,
	[Telefono] [varchar](50) NULL,
	[FechaIngreso] [date] NULL,
	[FechaBaja] [date] NULL,
 CONSTRAINT [PK_Cobrador] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Cobrador__A42025884D94879B] UNIQUE NONCLUSTERED 
(
	[NumeroDocumento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AsientoContable]    Script Date: 08/28/2015 17:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AsientoContable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Fecha] [date] NULL,
	[Descripción] [varchar](100) NULL,
	[IdBalance] [int] NULL,
 CONSTRAINT [PK_AsientoContable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Socio]    Script Date: 08/28/2015 17:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Socio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Apellido] [varchar](100) NULL,
	[IdTipoDocumento] [int] NULL,
	[NumeroDocumento] [varchar](100) NULL,
	[Domicilio] [varchar](100) NULL,
	[Telefono] [varchar](100) NULL,
	[IdCobrador] [int] NOT NULL,
	[DomicilioCobro] [varchar](100) NULL,
	[DiaCobro] [varchar](100) NULL,
	[FechaIngreso] [date] NULL,
	[FechaBaja] [date] NULL,
	[ValorCuota] [decimal](18, 3) NULL,
	[RegimenCuota] [int] NULL,
	[ContadorCuota] [int] NULL,
 CONSTRAINT [PK_Socio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Socio__A42025884AB81AF0] UNIQUE NONCLUSTERED 
(
	[NumeroDocumento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MovimientoDiario]    Script Date: 08/28/2015 17:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovimientoDiario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NULL,
	[Fecha] [date] NULL,
	[Importe] [decimal](18, 3) NULL,
	[IdTipoMovimiento] [int] NULL,
	[IdCuentaContable] [int] NOT NULL,
	[IdAsientoContable] [int] NULL,
 CONSTRAINT [PK_MovimientoDiario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cuota]    Script Date: 08/28/2015 17:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuota](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPeriodo] [int] NOT NULL,
	[Importe] [decimal](18, 3) NULL,
	[Pagado] [bit] NULL,
	[IdSocio] [int] NOT NULL,
 CONSTRAINT [PK_Cuota] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_AsientoContable_Balance]    Script Date: 08/28/2015 17:22:48 ******/
ALTER TABLE [dbo].[AsientoContable]  WITH CHECK ADD  CONSTRAINT [FK_AsientoContable_Balance] FOREIGN KEY([IdBalance])
REFERENCES [dbo].[Balance] ([Id])
GO
ALTER TABLE [dbo].[AsientoContable] CHECK CONSTRAINT [FK_AsientoContable_Balance]
GO
/****** Object:  ForeignKey [FK_Cobrador_TipoDocumento]    Script Date: 08/28/2015 17:22:48 ******/
ALTER TABLE [dbo].[Cobrador]  WITH CHECK ADD  CONSTRAINT [FK_Cobrador_TipoDocumento] FOREIGN KEY([IdTipoDocumento])
REFERENCES [dbo].[TipoDocumento] ([Id])
GO
ALTER TABLE [dbo].[Cobrador] CHECK CONSTRAINT [FK_Cobrador_TipoDocumento]
GO
/****** Object:  ForeignKey [FK_CuentaContable_CuentaContable]    Script Date: 08/28/2015 17:22:48 ******/
ALTER TABLE [dbo].[CuentaContable]  WITH CHECK ADD  CONSTRAINT [FK_CuentaContable_CuentaContable] FOREIGN KEY([Id])
REFERENCES [dbo].[CuentaContable] ([Id])
GO
ALTER TABLE [dbo].[CuentaContable] CHECK CONSTRAINT [FK_CuentaContable_CuentaContable]
GO
/****** Object:  ForeignKey [FK_CuentaContable_TipoCuenta]    Script Date: 08/28/2015 17:22:48 ******/
ALTER TABLE [dbo].[CuentaContable]  WITH CHECK ADD  CONSTRAINT [FK_CuentaContable_TipoCuenta] FOREIGN KEY([IdTipoCuenta])
REFERENCES [dbo].[TipoCuenta] ([Id])
GO
ALTER TABLE [dbo].[CuentaContable] CHECK CONSTRAINT [FK_CuentaContable_TipoCuenta]
GO
/****** Object:  ForeignKey [FK_Cuota_Cuota]    Script Date: 08/28/2015 17:22:48 ******/
ALTER TABLE [dbo].[Cuota]  WITH CHECK ADD  CONSTRAINT [FK_Cuota_Cuota] FOREIGN KEY([Id])
REFERENCES [dbo].[Cuota] ([Id])
GO
ALTER TABLE [dbo].[Cuota] CHECK CONSTRAINT [FK_Cuota_Cuota]
GO
/****** Object:  ForeignKey [FK_Cuota_Periodo]    Script Date: 08/28/2015 17:22:48 ******/
ALTER TABLE [dbo].[Cuota]  WITH CHECK ADD  CONSTRAINT [FK_Cuota_Periodo] FOREIGN KEY([IdPeriodo])
REFERENCES [dbo].[PeriodoGenerado] ([Id])
GO
ALTER TABLE [dbo].[Cuota] CHECK CONSTRAINT [FK_Cuota_Periodo]
GO
/****** Object:  ForeignKey [FK_Cuota_Socio]    Script Date: 08/28/2015 17:22:48 ******/
ALTER TABLE [dbo].[Cuota]  WITH CHECK ADD  CONSTRAINT [FK_Cuota_Socio] FOREIGN KEY([IdSocio])
REFERENCES [dbo].[Socio] ([Id])
GO
ALTER TABLE [dbo].[Cuota] CHECK CONSTRAINT [FK_Cuota_Socio]
GO
/****** Object:  ForeignKey [FK_MovimientoDiario_AsientoContable]    Script Date: 08/28/2015 17:22:48 ******/
ALTER TABLE [dbo].[MovimientoDiario]  WITH CHECK ADD  CONSTRAINT [FK_MovimientoDiario_AsientoContable] FOREIGN KEY([IdAsientoContable])
REFERENCES [dbo].[AsientoContable] ([Id])
GO
ALTER TABLE [dbo].[MovimientoDiario] CHECK CONSTRAINT [FK_MovimientoDiario_AsientoContable]
GO
/****** Object:  ForeignKey [FK_MovimientoDiario_CuentaContable]    Script Date: 08/28/2015 17:22:48 ******/
ALTER TABLE [dbo].[MovimientoDiario]  WITH CHECK ADD  CONSTRAINT [FK_MovimientoDiario_CuentaContable] FOREIGN KEY([IdCuentaContable])
REFERENCES [dbo].[CuentaContable] ([Id])
GO
ALTER TABLE [dbo].[MovimientoDiario] CHECK CONSTRAINT [FK_MovimientoDiario_CuentaContable]
GO
/****** Object:  ForeignKey [FK_MovimientoDiario_TipoMovimiento]    Script Date: 08/28/2015 17:22:48 ******/
ALTER TABLE [dbo].[MovimientoDiario]  WITH CHECK ADD  CONSTRAINT [FK_MovimientoDiario_TipoMovimiento] FOREIGN KEY([IdTipoMovimiento])
REFERENCES [dbo].[TipoMovimiento] ([Id])
GO
ALTER TABLE [dbo].[MovimientoDiario] CHECK CONSTRAINT [FK_MovimientoDiario_TipoMovimiento]
GO
/****** Object:  ForeignKey [FK_Socio_Cobrador]    Script Date: 08/28/2015 17:22:48 ******/
ALTER TABLE [dbo].[Socio]  WITH CHECK ADD  CONSTRAINT [FK_Socio_Cobrador] FOREIGN KEY([IdCobrador])
REFERENCES [dbo].[Cobrador] ([Id])
GO
ALTER TABLE [dbo].[Socio] CHECK CONSTRAINT [FK_Socio_Cobrador]
GO
/****** Object:  ForeignKey [FK_Socio_TipoDocumento]    Script Date: 08/28/2015 17:22:48 ******/
ALTER TABLE [dbo].[Socio]  WITH CHECK ADD  CONSTRAINT [FK_Socio_TipoDocumento] FOREIGN KEY([IdTipoDocumento])
REFERENCES [dbo].[TipoDocumento] ([Id])
GO
ALTER TABLE [dbo].[Socio] CHECK CONSTRAINT [FK_Socio_TipoDocumento]
GO
