IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_Pagos_Beneficiarios]') AND parent_object_id = OBJECT_ID(N'[mozilla].[Pagos]'))
ALTER TABLE [mozilla].[Pagos] DROP CONSTRAINT [FK_Pagos_Beneficiarios]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_RolFuncionalidad_Funcionalidades]') AND parent_object_id = OBJECT_ID(N'[mozilla].[RolFuncionalidad]'))
ALTER TABLE [mozilla].[RolFuncionalidad] DROP CONSTRAINT [FK_RolFuncionalidad_Funcionalidades]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_RolFuncionalidad_Roles]') AND parent_object_id = OBJECT_ID(N'[mozilla].[RolFuncionalidad]'))
ALTER TABLE [mozilla].[RolFuncionalidad] DROP CONSTRAINT [FK_RolFuncionalidad_Roles]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[mozilla].[FK_Usuarios_Roles]') AND parent_object_id = OBJECT_ID(N'[mozilla].[Usuarios]'))
ALTER TABLE [mozilla].[Usuarios] DROP CONSTRAINT [FK_Usuarios_Roles]
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
