-- Limpia escenario!
-- drop views

GO
/****** Objeto:  View [mozilla].[tarjetasInactivas]    Fecha de la secuencia de comandos: 11/12/2011 17:37:16 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[mozilla].[tarjetasInactivas]'))
DROP VIEW [mozilla].[tarjetasInactivas]

-- drop procedures
GO
/****** Objeto:  StoredProcedure [mozilla].[editarRol]    Fecha de la secuencia de comandos: 11/13/2011 14:59:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[editarRol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [mozilla].[editarRol]

GO
/****** Objeto:  StoredProcedure [mozilla].[setTarjetasInactivas]    Fecha de la secuencia de comandos: 11/12/2011 21:48:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[setTarjetasInactivas]') AND type in (N'P', N'PC'))
DROP PROCEDURE [mozilla].[setTarjetasInactivas]

GO
/****** Objeto:  StoredProcedure [mozilla].[borrarRolFuncionalidad]    Fecha de la secuencia de comandos: 11/13/2011 14:55:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[borrarRolFuncionalidad]') AND type in (N'P', N'PC'))
DROP PROCEDURE [mozilla].[borrarRolFuncionalidad]

GO
/****** Objeto:  StoredProcedure [mozilla].[altaRolFuncionalidad]    Fecha de la secuencia de comandos: 11/13/2011 11:27:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[altaRolFuncionalidad]') AND type in (N'P', N'PC'))
DROP PROCEDURE [mozilla].[altaRolFuncionalidad]

GO
/****** Objeto:  StoredProcedure [mozilla].[altaRol]    Fecha de la secuencia de comandos: 11/13/2011 11:14:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[altaRol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [mozilla].[altaRol]

GO
/****** Objeto:  StoredProcedure [mozilla].[AltaTarjeta]    Fecha de la secuencia de comandos: 11/06/2011 12:16:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[AltaTarjeta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [mozilla].[AltaTarjeta]

GO
/****** Objeto:  StoredProcedure [mozilla].[cargarTarjeta]    Fecha de la secuencia de comandos: 10/08/2011 15:01:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[cargarTarjeta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [mozilla].[cargarTarjeta]

GO
/****** Objeto:  StoredProcedure [mozilla].[editarTarjeta]    Fecha de la secuencia de comandos: 11/11/2011 23:10:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[editarTarjeta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [mozilla].[editarTarjeta]

GO
/****** Objeto:  StoredProcedure [mozilla].[ClientesPremium]    Fecha de la secuencia de comandos: 11/12/2011 14:25:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[ClientesPremium]') AND type in (N'P', N'PC'))
DROP PROCEDURE [mozilla].[ClientesPremium]

-- drop relations
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_usuarioRol_Roles]') AND parent_object_id = OBJECT_ID(N'[mozilla].[usuarioRol]'))
ALTER TABLE [mozilla].[usuarioRol] DROP CONSTRAINT [FK_usuarioRol_Roles]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_usuarioRol_Usuarios]') AND parent_object_id = OBJECT_ID(N'[mozilla].[usuarioRol]'))
ALTER TABLE [mozilla].[usuarioRol] DROP CONSTRAINT [FK_usuarioRol_Usuarios]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_Pagos_Beneficiarios]') AND parent_object_id = OBJECT_ID(N'[mozilla].[Pagos]'))
ALTER TABLE [mozilla].[Pagos] DROP CONSTRAINT [FK_Pagos_Beneficiarios]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_RolFuncionalidad_Funcionalidades]') AND parent_object_id = OBJECT_ID(N'[mozilla].[RolFuncionalidad]'))
ALTER TABLE [mozilla].[RolFuncionalidad] DROP CONSTRAINT [FK_RolFuncionalidad_Funcionalidades]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_RolFuncionalidad_Roles]') AND parent_object_id = OBJECT_ID(N'[mozilla].[RolFuncionalidad]'))
ALTER TABLE [mozilla].[RolFuncionalidad] DROP CONSTRAINT [FK_RolFuncionalidad_Roles]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_Cargas_Tarjetas]') AND parent_object_id = OBJECT_ID(N'[mozilla].[Cargas]'))
ALTER TABLE [mozilla].[Cargas] DROP CONSTRAINT [FK_Cargas_Tarjetas]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_Compras_Postnets]') AND parent_object_id = OBJECT_ID(N'[mozilla].[Compras]'))
ALTER TABLE [mozilla].[Compras] DROP CONSTRAINT [FK_Compras_Postnets]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_Compras_Tarjetas]') AND parent_object_id = OBJECT_ID(N'[mozilla].[Compras]'))
ALTER TABLE [mozilla].[Compras] DROP CONSTRAINT [FK_Compras_Tarjetas]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_Beneficiarios_Rubros]') AND parent_object_id = OBJECT_ID(N'[mozilla].[Beneficiarios]'))
ALTER TABLE [mozilla].[Beneficiarios] DROP CONSTRAINT [FK_Beneficiarios_Rubros]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_Tarjetas_Clientes]') AND parent_object_id = OBJECT_ID(N'[mozilla].[Tarjetas]'))
ALTER TABLE [mozilla].[Tarjetas] DROP CONSTRAINT [FK_Tarjetas_Clientes]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_Postnets_Beneficiarios]') AND parent_object_id = OBJECT_ID(N'[mozilla].[Postnets]'))
ALTER TABLE [mozilla].[Postnets] DROP CONSTRAINT [FK_Postnets_Beneficiarios]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_Clientes_Provincias]') AND parent_object_id = OBJECT_ID(N'[mozilla].[Clientes]'))
ALTER TABLE [mozilla].[Clientes] DROP CONSTRAINT [FK_Clientes_Provincias]
GO
/****** Objeto:  Table [mozilla].[usuarioRol]    Fecha de la secuencia de comandos: 11/13/2011 21:14:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[usuarioRol]') AND type in (N'U'))
DROP TABLE [mozilla].[usuarioRol]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Pagos]') AND type in (N'U'))
DROP TABLE [mozilla].[Pagos]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[RolFuncionalidad]') AND type in (N'U'))
DROP TABLE [mozilla].[RolFuncionalidad]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Usuarios]') AND type in (N'U'))
DROP TABLE [mozilla].[Usuarios]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Cargas]') AND type in (N'U'))
DROP TABLE [mozilla].[Cargas]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Compras]') AND type in (N'U'))
DROP TABLE [mozilla].[Compras]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Beneficiarios]') AND type in (N'U'))
DROP TABLE [mozilla].[Beneficiarios]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Clientes]') AND type in (N'U'))
DROP TABLE [mozilla].[Clientes]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Rubros]') AND type in (N'U'))
DROP TABLE [mozilla].[Rubros]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Funcionalidades]') AND type in (N'U'))
DROP TABLE [mozilla].[Funcionalidades]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Roles]') AND type in (N'U'))
DROP TABLE [mozilla].[Roles]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Tarjetas]') AND type in (N'U'))
DROP TABLE [mozilla].[Tarjetas]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Postnets]') AND type in (N'U'))
DROP TABLE [mozilla].[Postnets]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Provincias]') AND type in (N'U'))
DROP TABLE [mozilla].[Provincias]

-- crea eschema
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'mozilla')
DROP SCHEMA [mozilla]

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'mozilla')
EXEC sys.sp_executesql N'CREATE SCHEMA [mozilla] AUTHORIZATION [gd]'

-- Creación de estructura

GO
/****** Objeto:  Table [mozilla].[Funcionalidades]    Fecha de la secuencia de comandos: 11/13/2011 10:01:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [mozilla].[Funcionalidades](
	[FUNCIONALIDAD_ID] [int] IDENTITY(1,1) NOT NULL,
	[FUNCIONALIDAD_NOMBRE] [varchar](255) COLLATE Modern_Spanish_CI_AS NOT NULL,
 CONSTRAINT [PK_Funcionalidades_1] PRIMARY KEY CLUSTERED 
(
	[FUNCIONALIDAD_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [Uk_NombreFuncionalidad] UNIQUE NONCLUSTERED 
(
	[FUNCIONALIDAD_NOMBRE] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF

GO
/****** Objeto:  Table [mozilla].[Roles]    Fecha de la secuencia de comandos: 11/13/2011 11:15:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [mozilla].[Roles](
	[ROL_ID] [int] NOT NULL,
	[ROL_NOMBRE] [varchar](255) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[HABILITADO] [bit] NOT NULL CONSTRAINT [DF_Rol_ROL_HABILITADO]  DEFAULT ('1'),
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[ROL_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Roles] UNIQUE NONCLUSTERED 
(
	[ROL_NOMBRE] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.objects
WHERE object_id = OBJECT_ID(N'[mozilla].[Provincias]') AND type in (N'U'))
BEGIN
CREATE TABLE [mozilla].[Provincias](
	[PROVINCIA_ID] [int] NOT NULL,
	[PROVINCIA_DESC] [varchar](255) NULL,
CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED
(
	[PROVINCIA_ID] ASC
)WITH (PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Clientes]') AND type in (N'U'))
BEGIN
CREATE TABLE [mozilla].[Clientes](
	[CLIENTE_NOMBRE] [varchar](255) NOT NULL,
	[CLIENTE_APELLIDO] [varchar](255) NOT NULL,
	[CLIENTE_TIPO_DNI] [varchar](50) NOT NULL,
	[CLIENTE_DNI] [int] NOT NULL,
	[CLIENTE_MAIL] [varchar](255) NOT NULL,
	[CLIENTE_TELEFONO] [varchar](30) NOT NULL,
	[CLIENTE_CALLE] [varchar](255) NOT NULL,
	[CLIENTE_NRO] [int] NOT NULL,
	[CLIENTE_PISO] [int] NOT NULL,
	[CLIENTE_DEPTO] [varchar](255) NOT NULL,
	[CLIENTE_ID] [int] IDENTITY(1,1) NOT NULL,
	[PROVINCIA_ID] [int] NOT NULL DEFAULT ((24)),
	[HABILITADO] [bit] NOT NULL DEFAULT ((1)),
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[CLIENTE_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Rubros]') AND type in (N'U'))
BEGIN
CREATE TABLE [mozilla].[Rubros](
	[RUBRO_ID] [int] NOT NULL,
	[RUBRO_NOMBRE] [varchar](255) NULL,
 CONSTRAINT [PK_Rubros] PRIMARY KEY CLUSTERED 
(
	[RUBRO_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[RolFuncionalidad]') AND type in (N'U'))
BEGIN
CREATE TABLE [mozilla].[RolFuncionalidad](
	[ROL_ID] [int] NOT NULL,
	[FUNCIONALIDAD_ID] [int] NOT NULL,
 CONSTRAINT [PK_RolFuncionalidad] PRIMARY KEY CLUSTERED 
(
	[ROL_ID] ASC,
	[FUNCIONALIDAD_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END

GO
/****** Objeto:  Table [mozilla].[Usuarios]    Fecha de la secuencia de comandos: 11/13/2011 22:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [mozilla].[Usuarios](
	[USUARIO_ID] [int] NOT NULL,
	[USUARIO_NOMBRE] [varchar](255) COLLATE Modern_Spanish_CI_AS NULL,
	[USUARIO_PASSWORD] [varchar](255) COLLATE Modern_Spanish_CI_AS NULL,
	[USUARIO_INTENTOS_FALLIDOS] [int] NOT NULL CONSTRAINT [DF__Usuarios__USUARI__3D53FE31]  DEFAULT ((0)),
	[HABILITADO] [bit] NOT NULL CONSTRAINT [DF__Usuarios__HABILI__3E48226A]  DEFAULT ((1)),
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[USUARIO_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Nombre] UNIQUE NONCLUSTERED 
(
	[USUARIO_NOMBRE] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF

GO
/****** Objeto:  Table [mozilla].[usuarioRol]    Fecha de la secuencia de comandos: 11/13/2011 21:14:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mozilla].[usuarioRol](
	[USUARIO_ID] [int] NOT NULL,
	[ROL_ID] [int] NOT NULL,
 CONSTRAINT [PK_usuarioRol] PRIMARY KEY CLUSTERED 
(
	[USUARIO_ID] ASC,
	[ROL_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Compras]') AND type in (N'U'))
BEGIN
CREATE TABLE [mozilla].[Compras](
	[COMPRA_CODIGO] [int] NOT NULL,
	[COMPRA_MONTO] [float] NULL,
	[COMPRA_FECHA] [datetime] NULL,
	[BENEFICIARIO_ID] [int] NULL,
	[TARJETA_ID] [int] NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[COMPRA_CODIGO] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[mozilla].[Compras]') AND name = N'IX_Postnet')
CREATE NONCLUSTERED INDEX [IX_Postnet] ON [mozilla].[Compras] 
(
	[BENEFICIARIO_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[mozilla].[Compras]') AND name = N'IX_Tarjeta_Nro')
CREATE NONCLUSTERED INDEX [IX_Tarjeta_Nro] ON [mozilla].[Compras] 
(
	[TARJETA_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Cargas]') AND type in (N'U'))
BEGIN
CREATE TABLE [mozilla].[Cargas](
	[CARGA_FECHA] [datetime] NULL,
	[CARGA_MONTO] [float] NULL,
	[TARJETA_ID] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Pagos]') AND type in (N'U'))
BEGIN
CREATE TABLE [mozilla].[Pagos](
	[PAGO_FECHA] [datetime] NULL,
	[PAGO_MONTO] [float] NULL,
	[PAGO_TRANS_CODIGO] [int] NOT NULL,
	[BENEFICIARIO_ID] [int] NULL,
 CONSTRAINT [PK_Pagos] PRIMARY KEY CLUSTERED 
(
	[PAGO_TRANS_CODIGO] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[mozilla].[Pagos]') AND name = N'IX_Beneficiario_id')
CREATE NONCLUSTERED INDEX [IX_Beneficiario_id] ON [mozilla].[Pagos] 
(
	[BENEFICIARIO_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Postnets]') AND type in (N'U'))
BEGIN
CREATE TABLE [mozilla].[Postnets](
	[POSTNET_NRO_SERIE] [int] NOT NULL,
	[POSTNET_MODELO] [varchar](50) NULL,
	[POSTNET_MARCA] [varchar](255) NULL,
	[HABILITADO] [bit] NOT NULL DEFAULT ((1)),
	[BENEFICIARIO_ID] [int] NULL,
 CONSTRAINT [PK_Postnets] PRIMARY KEY CLUSTERED 
(
	[POSTNET_NRO_SERIE] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[mozilla].[Postnets]') AND name = N'IX_Beneficiario')
CREATE NONCLUSTERED INDEX [IX_Beneficiario] ON [mozilla].[Postnets] 
(
	[BENEFICIARIO_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Tarjetas]') AND type in (N'U'))
BEGIN
CREATE TABLE [mozilla].[Tarjetas](
	[TARJETA_ID] [int] IDENTITY(1,1) NOT NULL,
	[TARJETA_NRO] [int] NOT NULL,
	[TARJETA_FECHA_ALTA] [datetime] NOT NULL,
	[CLIENTE_ID] [int] NOT NULL,
	[HABILITADA] [bit] NOT NULL DEFAULT ((1)),
 CONSTRAINT [PK_Tarjetas] PRIMARY KEY CLUSTERED 
(
	[TARJETA_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_ClienteId] UNIQUE NONCLUSTERED 
(
	[CLIENTE_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY],
CONSTRAINT [UQ_NroTarjeta] UNIQUE NONCLUSTERED 
(
	[TARJETA_NRO] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[mozilla].[Beneficiarios]') AND type in (N'U'))
BEGIN
CREATE TABLE [mozilla].[Beneficiarios](
	[BENEFICIARIO_NOMBRE] [varchar](255) NOT NULL,
	[RUBRO_ID] [int] NULL,
	[BENEFICIARIO_CALLE] [varchar](255) NOT NULL,
	[BENEFICIARIO_NRO] [int] NOT NULL,
	[BENEFICIARIO_PISO] [int] NULL,
	[BENEFICIARIO_DEPTO] [varchar](255) NULL,
	[BENEFICIARIO_ID] [int] IDENTITY(1,1) NOT NULL,
	[HABILITADO] [bit] NOT NULL DEFAULT ((1)),
 CONSTRAINT [PK_Beneficiarios] PRIMARY KEY CLUSTERED 
(
	[BENEFICIARIO_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_BENEFICIARIO_NOMBRE] UNIQUE NONCLUSTERED 
(
	[BENEFICIARIO_NOMBRE] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Beneficiarios_Nombre] UNIQUE NONCLUSTERED 
(
	[BENEFICIARIO_NOMBRE] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[mozilla].[Beneficiarios]') AND name = N'IX_Beneficiarios')
CREATE NONCLUSTERED INDEX [IX_Beneficiarios] ON [mozilla].[Beneficiarios] 
(
	[RUBRO_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_RolFuncionalidad_Funcionalidades]') AND parent_object_id = OBJECT_ID(N'[mozilla].[RolFuncionalidad]'))
ALTER TABLE [mozilla].[RolFuncionalidad]  WITH CHECK ADD  CONSTRAINT [FK_RolFuncionalidad_Funcionalidades] FOREIGN KEY([FUNCIONALIDAD_ID])
REFERENCES [mozilla].[Funcionalidades] ([FUNCIONALIDAD_ID])
GO
ALTER TABLE [mozilla].[RolFuncionalidad] CHECK CONSTRAINT [FK_RolFuncionalidad_Funcionalidades]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_RolFuncionalidad_Roles]') AND parent_object_id = OBJECT_ID(N'[mozilla].[RolFuncionalidad]'))
ALTER TABLE [mozilla].[RolFuncionalidad]  WITH CHECK ADD  CONSTRAINT [FK_RolFuncionalidad_Roles] FOREIGN KEY([ROL_ID])
REFERENCES [mozilla].[Roles] ([ROL_ID])
GO
ALTER TABLE [mozilla].[RolFuncionalidad] CHECK CONSTRAINT [FK_RolFuncionalidad_Roles]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_Compras_Beneficiarios]') AND parent_object_id = OBJECT_ID(N'[mozilla].[Compras]'))
ALTER TABLE [mozilla].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Beneficiarios] FOREIGN KEY([BENEFICIARIO_ID])
REFERENCES [mozilla].[Beneficiarios] ([BENEFICIARIO_ID])
GO
ALTER TABLE [mozilla].[Compras] CHECK CONSTRAINT [FK_Compras_Beneficiarios]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_Compras_Tarjetas]') AND parent_object_id = OBJECT_ID(N'[mozilla].[Compras]'))
ALTER TABLE [mozilla].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Tarjetas] FOREIGN KEY([TARJETA_ID])
REFERENCES [mozilla].[Tarjetas] ([TARJETA_ID])
GO
ALTER TABLE [mozilla].[Compras] CHECK CONSTRAINT [FK_Compras_Tarjetas]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_Cargas_Tarjetas]') AND parent_object_id = OBJECT_ID(N'[mozilla].[Cargas]'))
ALTER TABLE [mozilla].[Cargas]  WITH CHECK ADD  CONSTRAINT [FK_Cargas_Tarjetas] FOREIGN KEY([TARJETA_ID])
REFERENCES [mozilla].[Tarjetas] ([TARJETA_ID])
GO
ALTER TABLE [mozilla].[Cargas] CHECK CONSTRAINT [FK_Cargas_Tarjetas]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_Pagos_Beneficiarios]') AND parent_object_id = OBJECT_ID(N'[mozilla].[Pagos]'))
ALTER TABLE [mozilla].[Pagos]  WITH CHECK ADD  CONSTRAINT [FK_Pagos_Beneficiarios] FOREIGN KEY([BENEFICIARIO_ID])
REFERENCES [mozilla].[Beneficiarios] ([BENEFICIARIO_ID])
GO
ALTER TABLE [mozilla].[Pagos] CHECK CONSTRAINT [FK_Pagos_Beneficiarios]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_Postnets_Beneficiarios]') AND parent_object_id = OBJECT_ID(N'[mozilla].[Postnets]'))
ALTER TABLE [mozilla].[Postnets]  WITH CHECK ADD  CONSTRAINT [FK_Postnets_Beneficiarios] FOREIGN KEY([BENEFICIARIO_ID])
REFERENCES [mozilla].[Beneficiarios] ([BENEFICIARIO_ID])
GO
ALTER TABLE [mozilla].[Postnets] CHECK CONSTRAINT [FK_Postnets_Beneficiarios]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_Tarjetas_Clientes]') AND parent_object_id = OBJECT_ID(N'[mozilla].[Tarjetas]'))
ALTER TABLE [mozilla].[Tarjetas]  WITH CHECK ADD  CONSTRAINT [FK_Tarjetas_Clientes] FOREIGN KEY([CLIENTE_ID])
REFERENCES [mozilla].[Clientes] ([CLIENTE_ID])
GO
ALTER TABLE [mozilla].[Tarjetas] CHECK CONSTRAINT [FK_Tarjetas_Clientes]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_Beneficiarios_Rubros]') AND parent_object_id = OBJECT_ID(N'[mozilla].[Beneficiarios]'))
ALTER TABLE [mozilla].[Beneficiarios]  WITH CHECK ADD  CONSTRAINT [FK_Beneficiarios_Rubros] FOREIGN KEY([RUBRO_ID])
REFERENCES [mozilla].[Rubros] ([RUBRO_ID])
GO
ALTER TABLE [mozilla].[Beneficiarios] CHECK CONSTRAINT [FK_Beneficiarios_Rubros]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_Clientes_Provincias]') AND parent_object_id = OBJECT_ID(N'[mozilla].[Clientes]'))
ALTER TABLE [mozilla].[Clientes] WITH CHECK ADD CONSTRAINT [FK_Clientes_Provincias] FOREIGN KEY ([PROVINCIA_ID])
REFERENCES [mozilla].[Provincias] ([PROVINCIA_ID])

GO
ALTER TABLE [mozilla].[usuarioRol]  WITH CHECK ADD  CONSTRAINT [FK_usuarioRol_Roles] FOREIGN KEY([ROL_ID])
REFERENCES [mozilla].[Roles] ([ROL_ID])
GO
ALTER TABLE [mozilla].[usuarioRol] CHECK CONSTRAINT [FK_usuarioRol_Roles]
GO
ALTER TABLE [mozilla].[usuarioRol]  WITH CHECK ADD  CONSTRAINT [FK_usuarioRol_Usuarios] FOREIGN KEY([USUARIO_ID])
REFERENCES [mozilla].[Usuarios] ([USUARIO_ID])
GO
ALTER TABLE [mozilla].[usuarioRol] CHECK CONSTRAINT [FK_usuarioRol_Usuarios]

-- Migracion de datos

INSERT INTO [mozilla].[Funcionalidades] ([FUNCIONALIDAD_NOMBRE])VALUES('ABM de Tarjetas')
INSERT INTO [mozilla].[Funcionalidades] ([FUNCIONALIDAD_NOMBRE])VALUES('ABM de Rol')
INSERT INTO [mozilla].[Funcionalidades] ([FUNCIONALIDAD_NOMBRE])VALUES('ABM de Usuario')
INSERT INTO [mozilla].[Funcionalidades] ([FUNCIONALIDAD_NOMBRE])VALUES('ABM de Cliente')
INSERT INTO [mozilla].[Funcionalidades] ([FUNCIONALIDAD_NOMBRE])VALUES('ABM de Beneficiarios/Empresas')
INSERT INTO [mozilla].[Funcionalidades] ([FUNCIONALIDAD_NOMBRE])VALUES('Carga de crédito')
INSERT INTO [mozilla].[Funcionalidades] ([FUNCIONALIDAD_NOMBRE])VALUES('Efectuar Compra')
INSERT INTO [mozilla].[Funcionalidades] ([FUNCIONALIDAD_NOMBRE])VALUES('Pago a empresas')
INSERT INTO [mozilla].[Funcionalidades] ([FUNCIONALIDAD_NOMBRE])VALUES('Inactividad de tarjetas')
INSERT INTO [mozilla].[Funcionalidades] ([FUNCIONALIDAD_NOMBRE])VALUES('Clientes Premium')

INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(1,'BUENOS AIRES')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(2,'CATAMARCA')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(3,'CHACO')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(4,'CHUBUT')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(5,'CORDOBA')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(6,'CORRIENTES')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(7,'ENTRE RIOS')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(8,'FORMOSA')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(9,'JUJUY')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(10,'LA PAMPA')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(11,'LA RIOJA')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(12,'MENDOZA')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(13,'MISIONES')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(14,'NEUQUEN')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(15,'RIO NEGRO')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(16,'SALTA')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(17,'SAN JUAN')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(18,'SAN LUIS')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(19,'SANTA CRUZ')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(20,'SANTA FE')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(21,'SANTIAGO DEL ESTERO')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(22,'TIERRA DEL FUEGO')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(23,'TUCUMAN')
INSERT INTO [mozilla].[Provincias] ([PROVINCIA_ID],[PROVINCIA_DESC])VALUES(24,'')

-- Llena tabla Rubros
insert into
	mozilla.Rubros
	(
		RUBRO_ID,
		RUBRO_NOMBRE
	)

select distinct
	BENEFICIARIO_RUBRO_CODIGO,
	BENEFICIARIO_RUBRO_DESC

from
	gd_eschema.Maestra

where
	BENEFICIARIO_NOMBRE is not null

-- Llena tabla Beneficiarios
insert into mozilla.Beneficiarios
	(
		BENEFICIARIO_NOMBRE,
		RUBRO_ID,
		BENEFICIARIO_CALLE,
		BENEFICIARIO_NRO,
		BENEFICIARIO_PISO,
		BENEFICIARIO_DEPTO
	)
	
select distinct
	BENEFICIARIO_NOMBRE,
	BENEFICIARIO_RUBRO_CODIGO,
	BENEFICIARIO_CALLE,
	BENEFICIARIO_NRO,
	BENEFICIARIO_PISO,
	BENEFICIARIO_DEPTO

from
	gd_eschema.Maestra

where
	BENEFICIARIO_NOMBRE is not null
	
-- Llena tabla Postnets
insert into
	mozilla.Postnets
	(
		BENEFICIARIO_ID,
		POSTNET_NRO_SERIE,
		POSTNET_MODELO,
		POSTNET_MARCA
	)

select distinct
	(select b.BENEFICIARIO_ID from mozilla.Beneficiarios b where (m.BENEFICIARIO_NOMBRE = b.BENEFICIARIO_NOMBRE)) as BENEFICIARIO_ID,
	POSTNET_NRO_SERIE,
	POSTNET_MODELO,
	POSTNET_MARCA

from
	gd_eschema.Maestra m

where
	m.BENEFICIARIO_NOMBRE is not null and
	POSTNET_MODELO is not null

-- Llena tabla Pagos
insert into
	mozilla.Pagos
	(
		BENEFICIARIO_ID,
		PAGO_FECHA,
		PAGO_MONTO,
		PAGO_TRANS_CODIGO
	)
select
	(select b.BENEFICIARIO_ID from mozilla.Beneficiarios b where (m.BENEFICIARIO_NOMBRE = b.BENEFICIARIO_NOMBRE)) as BENEFICIARIO_ID,
	m.PAGO_FECHA,
	m.PAGO_MONTO,
	m.PAGO_TRANS_CODIGO

from
	gd_eschema.Maestra m

where
	m.BENEFICIARIO_NOMBRE is not null and
	PAGO_TRANS_CODIGO != 0

order by
	m.PAGO_TRANS_CODIGO

-- Llena tabla Clientes
insert into
	mozilla.Clientes
	(
		CLIENTE_NOMBRE,
		CLIENTE_APELLIDO,
		CLIENTE_TIPO_DNI,
		CLIENTE_DNI,
		CLIENTE_MAIL,
		CLIENTE_TELEFONO,
		CLIENTE_CALLE,
		CLIENTE_NRO,
		CLIENTE_PISO,
		CLIENTE_DEPTO
	)
select distinct
	m.CLIENTE_NOMBRE,
	m.CLIENTE_APELLIDO,
	m.CLIENTE_TIPO_DNI,
	m.CLIENTE_DNI,
	m.CLIENTE_MAIL,
	m.CLIENTE_TELEFONO,
	m.CLIENTE_CALLE,
	m.CLIENTE_NRO,
	m.CLIENTE_PISO,
	m.CLIENTE_DEPTO

from
	gd_eschema.Maestra m

where
	m.CLIENTE_DNI != 0

-- Llena tabla Tarjetas
insert into
	mozilla.Tarjetas
	(
		TARJETA_NRO,
		TARJETA_FECHA_ALTA,
		CLIENTE_ID
	)
select distinct
	m.TARJETA_NRO,
	m.TARJETA_FECHA_ALTA,
	(
		select
			c.CLIENTE_ID

		from 
			mozilla.Clientes c 

		where
			m.CLIENTE_NOMBRE = c.CLIENTE_NOMBRE and
			m.CLIENTE_APELLIDO = c.CLIENTE_APELLIDO and
			m.CLIENTE_TIPO_DNI = c.CLIENTE_TIPO_DNI and
			m.CLIENTE_DNI = c.CLIENTE_DNI and
			m.CLIENTE_MAIL = c.CLIENTE_MAIL and
			m.CLIENTE_TELEFONO = c.CLIENTE_TELEFONO and
			m.CLIENTE_CALLE = c.CLIENTE_CALLE and
			m.CLIENTE_NRO = c.CLIENTE_NRO and
			m.CLIENTE_PISO = c.CLIENTE_PISO and
			m.CLIENTE_DEPTO = c.CLIENTE_DEPTO
	) as CLIENTE_ID

from
	gd_eschema.Maestra m

where
	m.TARJETA_NRO != 0

order by
	m.TARJETA_NRO

-- Llena tabla Compras
insert into
	mozilla.Compras
	(
		COMPRA_CODIGO,
		COMPRA_MONTO,
		COMPRA_FECHA,
		BENEFICIARIO_ID,
		TARJETA_ID
	)
select
	m.COMPRA_CODIGO,
	m.COMPRA_MONTO,
	m.COMPRA_FECHA,
	(select z.BENEFICIARIO_ID from mozilla.Postnets z where m.POSTNET_NRO_SERIE = z.POSTNET_NRO_SERIE) as BENEFICIARIO_ID ,
	(select t.TARJETA_ID from mozilla.Tarjetas t where t.TARJETA_NRO = m.TARJETA_NRO)

from
	gd_eschema.Maestra m

where
	m.BENEFICIARIO_NOMBRE is not null and
	COMPRA_CODIGO != 0

order by
	m.COMPRA_CODIGO

-- Llena tabla Cargas
insert into
	mozilla.Cargas
	(
		CARGA_MONTO,
		CARGA_FECHA,
		TARJETA_ID
	)
select
	m.CARGA_MONTO,
	m.CARGA_FECHA,
	(select t.TARJETA_ID from mozilla.Tarjetas t where m.TARJETA_NRO = t.TARJETA_NRO)

from
	gd_eschema.Maestra m

where
	m.CARGA_MONTO != 0

-- Limpia dnis duplicados

WHILE
	(
		(SELECT TOP 1
			1

		FROM
			mozilla.Clientes c

		GROUP BY
			c.CLIENTE_DNI

		HAVING
			count(c.CLIENTE_DNI) >= 2) = 1
		
	)
	BEGIN

	UPDATE mozilla.Clientes
	SET CLIENTE_DNI =
		(
			SELECT TOP 1
				-c2.CLIENTE_DNI

			FROM
				mozilla.Clientes c2

			WHERE
				(
					SELECT TOP 1
						c.CLIENTE_DNI

					FROM
						mozilla.Clientes c

					GROUP BY
						c.CLIENTE_DNI

					HAVING
						count(c.CLIENTE_DNI) >= 2
				) = c2.CLIENTE_DNI
		)
	WHERE CLIENTE_ID = 
		(
			SELECT TOP 1
				c2.CLIENTE_ID

			FROM
				mozilla.Clientes c2

			WHERE
				(
					SELECT TOP 1
						c.CLIENTE_DNI

					FROM
						mozilla.Clientes c

					GROUP BY
						c.CLIENTE_DNI

					HAVING
						count(c.CLIENTE_DNI) >= 2

				) = c2.CLIENTE_DNI
		)
	END

CREATE UNIQUE INDEX UQ_DNIS ON mozilla.Clientes (CLIENTE_DNI,CLIENTE_TIPO_DNI); 

-- Agrego los roles

insert into	mozilla.Roles(	ROL_ID,	ROL_NOMBRE	)values	(1,'Administrador');
insert into	mozilla.Roles(	ROL_ID,	ROL_NOMBRE	)values	(2,'Gestor');
insert into	mozilla.Roles(	ROL_ID,	ROL_NOMBRE	)values	(3,'Cliente');

insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(1,1);
insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(1,2);
insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(1,3);
insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(1,4);
insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(1,5);
insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(1,6);
insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(1,7);
insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(1,8);
insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(1,9);
insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(1,10);

insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(2,1);
insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(2,2);
insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(2,3);
insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(2,4);
insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(2,5);
insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(2,8);
insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(2,9);
insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(2,10);

insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(3,6);
insert into	mozilla.RolFuncionalidad(	ROL_ID,	FUNCIONALIDAD_ID	)values	(3,7);

-- Agrego usuario de sistema

insert into
	mozilla.Usuarios
	(
		USUARIO_ID,
		USUARIO_NOMBRE,
		USUARIO_PASSWORD
	)
values
	(
	1,
	'admin',
	'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'
	)

insert into mozilla.usuarioRol (USUARIO_ID, ROL_ID) values (1,1)


/****** Objeto:  StoredProcedure [mozilla].[cargarTarjeta]    Fecha de la secuencia de comandos: 10/08/2011 15:02:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [mozilla].[cargarTarjeta]
(	
	@nroTarjeta int,
	@fecha datetime,
	@monto float
)
as

Declare @idTarjeta int

BEGIN TRANSACTION

	set @idTarjeta = (select t.TARJETA_ID from mozilla.Tarjetas t where t.TARJETA_NRO = @nroTarjeta)
	IF ((select t.HABILITADA from mozilla.Tarjetas t where t.TARJETA_ID = @idTarjeta) = 0)
	BEGIN
		RAISERROR ('Error, la tarjeta se encuentra inhabilitada!', 16, -1)
		ROLLBACK TRANSACTION
		return 1
	END

	insert mozilla.Cargas (TARJETA_ID, CARGA_FECHA, CARGA_MONTO)
	values (
			@idTarjeta,
			@fecha,
			@monto 
			)

	IF @@ERROR <> 0
	BEGIN
		RAISERROR ('Error, no se pudo completar la transaccion!', 16, -1)
		ROLLBACK TRANSACTION
		return 1
	END

	
COMMIT TRANSACTION


GO
/****** Objeto:  StoredProcedure [mozilla].[AltaTarjeta]    Fecha de la secuencia de comandos: 10/30/2011 21:27:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [mozilla].[AltaTarjeta]
(	
	@nroTarjeta int,
	@fecha datetime,
	@clienteId int
)
as

BEGIN TRANSACTION
insert into
	mozilla.Tarjetas
	(
		TARJETA_NRO,
		TARJETA_FECHA_ALTA,
		CLIENTE_ID
	)
	
	values
	(
		@nroTarjeta, 
		@fecha, 
		@clienteId
	)

	IF @@ERROR <> 0
	BEGIN
		RAISERROR ('Error, no se pudo completar la transaccion!', 16, -1)
		ROLLBACK TRANSACTION
		return 1
	END

COMMIT TRANSACTION

GO

create proc [mozilla].[editarTarjeta]
(	
	@idTarjeta int,
	@nroTarjeta int,
	@clienteId int,
	@estado bit
	
)
as

BEGIN TRANSACTION
	
	update mozilla.Tarjetas  set CLIENTE_ID = @clienteId, TARJETA_NRO = @nroTarjeta, HABILITADA = @estado
	where TARJETA_ID = @idTarjeta

	IF @@ERROR <> 0
	BEGIN
		RAISERROR ('Error, no se pudo completar la transaccion!', 16, -1)
		ROLLBACK TRANSACTION
		return 1
	END

COMMIT TRANSACTION

GO
CREATE PROC [mozilla].[ClientesPremium]
(	
	@year int
)
as

SELECT TOP 30 WITH TIES
	c.CLIENTE_NOMBRE,
	c.CLIENTE_APELLIDO,
	c.CLIENTE_DNI,
	t.TARJETA_NRO,
	SUM (co.COMPRA_MONTO) AS MONTO,
	MAX(co.COMPRA_FECHA) AS FECHA 

FROM
	mozilla.Clientes c

JOIN mozilla.Tarjetas t on t.CLIENTE_ID = c.CLIENTE_ID
JOIN mozilla.Compras co on t.TARJETA_ID = co.TARJETA_ID

WHERE
	(YEAR(COMPRA_FECHA) between 1995 and 2100) and
	YEAR(COMPRA_FECHA) = @year

GROUP BY 
	CLIENTE_NOMBRE, CLIENTE_APELLIDO, CLIENTE_DNI, t.TARJETA_NRO

ORDER BY SUM (COMPRA_MONTO) DESC;

GO
/****** Objeto:  View [mozilla].[tarjetasInactivas]    Fecha de la secuencia de comandos: 11/12/2011 17:37:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [mozilla].[tarjetasInactivas] as
-- si el cliente tiene 2 transacciones el mismo dia, al mismo horario, muestro las 2
-- recordando que píde el codigo del ultimo beneficiario

select
	cli.CLIENTE_NOMBRE Nombre,
	cli.CLIENTE_APELLIDO Apellido,
	cli.CLIENTE_DNI [Número de documento],
	c.COMPRA_FECHA,
	c.BENEFICIARIO_ID,
	c.TARJETA_ID,
	c.COMPRA_CODIGO
	

from
	mozilla.Compras c

join mozilla.Tarjetas t on t.TARJETA_ID = c.TARJETA_ID
join mozilla.Clientes cli on cli.CLIENTE_ID = t.CLIENTE_ID

where
	c.COMPRA_FECHA = (
						select max(co.COMPRA_FECHA)
						from mozilla.Compras co
						group by co.TARJETA_ID 
						having co.TARJETA_ID = c.TARJETA_ID 
					) and
	t.HABILITADA = 1 and
	DATEDIFF(day, c.COMPRA_FECHA, GETDATE()) > 30

group by
	cli.CLIENTE_NOMBRE ,
	cli.CLIENTE_APELLIDO,
	cli.CLIENTE_DNI,
	c.BENEFICIARIO_ID,
	c.TARJETA_ID,
	c.COMPRA_CODIGO,
	c.COMPRA_FECHA

GO
/****** Objeto:  StoredProcedure [mozilla].[setTarjetasInactivas]    Fecha de la secuencia de comandos: 11/12/2011 21:49:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [mozilla].[setTarjetasInactivas] as
declare @idTarjeta int
-- declaramos un cursor llamado "CURSORITO". El select debe contener sólo los campos a utilizar.
declare CURSORITO cursor for

select t.TARJETA_ID from mozilla.tarjetasInactivas t
BEGIN TRANSACTION

	open CURSORITO

	-- Avanzamos un registro y cargamos en las variables los valores encontrados en el primer registro
	fetch next from CURSORITO
	into @idTarjeta
	while @@fetch_status = 0
		begin
		update mozilla.Tarjetas set HABILITADA = 0 where TARJETA_ID=@idTarjeta
		IF @@ERROR <> 0
		BEGIN
			RAISERROR ('Error, no se pudo completar la transaccion!', 16, -1)
			ROLLBACK TRANSACTION
			return 1
		END
		-- Avanzamos otro registro
		fetch next from CURSORITO
		into @idTarjeta
	end
	-- cerramos el cursor
	close CURSORITO
	deallocate CURSORITO

COMMIT TRANSACTION

GO
/****** Objeto:  StoredProcedure [mozilla].[altaRol]    Fecha de la secuencia de comandos: 11/13/2011 11:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [mozilla].[altaRol]
(
	@maxId int,
	@nombreRol varchar(255)
)
as

BEGIN TRANSACTION

	insert into mozilla.Roles (ROL_ID, ROL_NOMBRE) values (@maxId,@nombreRol)
	IF @@ERROR <> 0
	BEGIN
		RAISERROR ('Error, no se pudo completar la transaccion!', 16, -1)
		ROLLBACK TRANSACTION
		return 1
	END

COMMIT TRANSACTION

GO
/****** Objeto:  StoredProcedure [mozilla].[altaRolFuncionalidad]    Fecha de la secuencia de comandos: 11/13/2011 11:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [mozilla].[altaRolFuncionalidad]
(
	@maxId int,
	@funcId int
)
as

BEGIN TRANSACTION

	insert into mozilla.RolFuncionalidad (ROL_ID, FUNCIONALIDAD_ID) values (@maxId,@funcId)
	IF @@ERROR <> 0
	BEGIN
		RAISERROR ('Error, no se pudo completar la transaccion!', 16, -1)
		ROLLBACK TRANSACTION
		return 1
	END

COMMIT TRANSACTION

GO
/****** Objeto:  StoredProcedure [mozilla].[borrarRolFuncionalidad]    Fecha de la secuencia de comandos: 11/13/2011 14:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [mozilla].[borrarRolFuncionalidad]
(	
	@idRol int
)
as

BEGIN TRANSACTION
	
	delete mozilla.RolFuncionalidad
	where ROL_ID = @idRol

	IF @@ERROR <> 0
	BEGIN
		RAISERROR ('Error, no se pudo completar la transaccion!', 16, -1)
		ROLLBACK TRANSACTION
		return 1
	END

COMMIT TRANSACTION

GO
/****** Objeto:  StoredProcedure [mozilla].[editarRol]    Fecha de la secuencia de comandos: 11/13/2011 14:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [mozilla].[editarRol]
(	
	@idRol int,
	@rolNombre varchar(255),
	@estado bit
)
as

BEGIN TRANSACTION
	
	update mozilla.Roles  set ROL_NOMBRE = @rolNombre, HABILITADO = @estado
	where ROL_ID = @idRol

	IF @@ERROR <> 0
	BEGIN
		RAISERROR ('Error, no se pudo completar la transaccion!', 16, -1)
		ROLLBACK TRANSACTION
		return 1
	END

COMMIT TRANSACTION

GO
CREATE TRIGGER [mozilla].[Usuarios_Update]
ON [mozilla].[Usuarios]
AFTER UPDATE
AS

BEGIN
		Declare @id int
		set @id = (SELECT i.USUARIO_ID FROM INSERTED i);
		IF((SELECT i.USUARIO_INTENTOS_FALLIDOS FROM INSERTED i) = 3)
		BEGIN
			UPDATE mozilla.usuarios set USUARIO_INTENTOS_FALLIDOS = 0, HABILITADO = 0 WHERE @id = USUARIO_ID
		END
END
