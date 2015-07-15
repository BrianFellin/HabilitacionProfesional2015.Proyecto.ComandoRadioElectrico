/****** Con este Script se insertan los datos a la base de datos ******/
/****** En USE [ComandoRadioElectrico] ComandoRadioElectrico debe ser el nombre de la base de datos******/

USE [ComandoRadioElectrico]
GO
/****** Object:  Table [dbo].[TipoMovimiento]    Script Date: 07/14/2015 23:48:19 ******/
SET IDENTITY_INSERT [dbo].[TipoMovimiento] ON
INSERT [dbo].[TipoMovimiento] ([Id], [Tipo]) VALUES (1, N'Débito')
INSERT [dbo].[TipoMovimiento] ([Id], [Tipo]) VALUES (2, N'Crédito')
SET IDENTITY_INSERT [dbo].[TipoMovimiento] OFF
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 07/14/2015 23:48:19 ******/
SET IDENTITY_INSERT [dbo].[TipoDocumento] ON
INSERT [dbo].[TipoDocumento] ([Id], [Tipo]) VALUES (1, N'DNI       ')
INSERT [dbo].[TipoDocumento] ([Id], [Tipo]) VALUES (2, N'LC        ')
INSERT [dbo].[TipoDocumento] ([Id], [Tipo]) VALUES (3, N'LE        ')
SET IDENTITY_INSERT [dbo].[TipoDocumento] OFF
/****** Object:  Table [dbo].[TipoCuenta]    Script Date: 07/14/2015 23:48:19 ******/
SET IDENTITY_INSERT [dbo].[TipoCuenta] ON
INSERT [dbo].[TipoCuenta] ([Id], [Tipo]) VALUES (1, N'Activo')
INSERT [dbo].[TipoCuenta] ([Id], [Tipo]) VALUES (2, N'Pasivo')
INSERT [dbo].[TipoCuenta] ([Id], [Tipo]) VALUES (3, N'Patrimonio')
INSERT [dbo].[TipoCuenta] ([Id], [Tipo]) VALUES (4, N'Ingreso')
INSERT [dbo].[TipoCuenta] ([Id], [Tipo]) VALUES (5, N'Egreso')
SET IDENTITY_INSERT [dbo].[TipoCuenta] OFF
