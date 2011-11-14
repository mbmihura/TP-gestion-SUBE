
USE [GD2C2010]

go

-- ELIMINACION DE TABLAS PREEXISTENTES--
if object_id('proceso_calidad_clientes')is not null
	drop table proceso_calidad_clientes
if object_id('cheques')is not null
	drop table cheques;
if object_id('plazosfijos')is not null
	drop table plazosfijos;
if object_id('transacciones')is not null
	drop table transacciones;
if object_id('cuentas')is not null
	drop table cuentas;
if object_id('monedas')is not null
	drop table monedas;
if object_id('audit_log')is not null
	drop table audit_log
if object_id('audit_tarjetas_deu') is not null
	drop trigger audit_tarjetas_deu
if object_id('audit_tarjetas_pag') is not null
	drop trigger audit_tarjetas_pag
if object_id('tarjetas_deu')is not null
	drop table tarjetas_deu;
if object_id('tarjetas_pag')is not null
	drop table tarjetas_pag;
if object_id('tarjetas')is not null
	drop table tarjetas;
if object_id('sucursales_banco')is not null
	drop table sucursales_banco;
if object_id('clientes')is not null
	drop table clientes;
if object_id('personas')is not null
	drop table personas;

go


-- CREACION DE TABLAS --

  create table personas(
   CLI_DNI int,
   CLI_NOMB nchar(50),
   CLI_APELLIDO nchar(50),
   CLI_MAIL nchar(50),
   primary key(CLI_DNI)
  );
  
  create table sucursales_banco(
   SUC_ID int identity,
   BANC_DIR nchar(50),
   BANC_DIR_NRO int,
   BANC_CUIT int,
   BANC_NOM nchar(30),
   primary key(SUC_ID)
  );

  create table clientes(
   CLI_ID int identity,
   CLI_DNI int,
   CLI_COD int,
   CLI_ESTADO bit DEFAULT 1,
   SUC_ID int,
   primary key(CLI_ID),
   foreign key(CLI_DNI) references personas(CLI_DNI),
   foreign key(SUC_ID) references sucursales_banco(SUC_ID)
  );


  create table monedas(
   MONEDA_COD int,
   MONEDA_DESC nvarchar(max),
   MONEDA_COTIZA real,
   primary key(MONEDA_COD)
  );

  create table cuentas(
   CUE_SALDO real DEFAULT 0,
   CUE_MONEDA_COD int,
   CUE_NRO int,
   CUE_FCREA smalldatetime,
   CLI_ID int,
   CUE_ESTADO bit DEFAULT 1,
   primary key(CUE_NRO),
   foreign key(CLI_ID) references clientes(CLI_ID),
   foreign key(CUE_MONEDA_COD) references monedas (MONEDA_COD)
  );

  create table plazosfijos(
   PF_ID int identity,
   PF_COD int,
   PF_IMPOR real,
   PF_FCREA smalldatetime,
   PF_FFIN smalldatetime,
   PF_MONEDA_COD int,
   PF_PLAZO int,
   PF_PORC real,
   CLI_ID int,
   PF_ESTADO bit DEFAULT 1,
   primary key(PF_ID),
   foreign key(CLI_ID) references clientes(CLI_ID),
   foreign key(PF_MONEDA_COD) references monedas(MONEDA_COD)
  );

  create table transacciones(
   TRA_ID int identity,
   TRA_CUE_ORIGEN int,
   TRA_CUE_ORIGEN_FECRA smalldatetime,
   TRA_CUE_DESTINO int,
   TRA_CUE_DESTINO_FCREA smalldatetime,
   TRA_FECHA smalldatetime,
   TRA_MONTO real,
   TRA_MONEDA_COD int,
   primary key(TRA_ID),
   foreign key(TRA_CUE_ORIGEN) references cuentas(CUE_NRO),
   foreign key(TRA_CUE_DESTINO) references cuentas(CUE_NRO),
   foreign key(TRA_MONEDA_COD) references monedas(MONEDA_COD) 
  );

  create table cheques(
   CHE_ID int identity,
   CHE_CUE_ORIGEN int,
   CHE_CUE_ORIGEN_FCREA smalldatetime,
   CHE_CUE_DESTINO int,
   CHE_CUE_DESTINO_FCREA smalldatetime,
   CHE_NRO int,
   CHE_MONTO real,
   CHE_FECHA smalldatetime,
   CHE_MONEDA_COD int,
   primary key(CHE_ID),
   foreign key(CHE_CUE_ORIGEN) references cuentas(CUE_NRO),
   foreign key(CHE_CUE_DESTINO) references cuentas(CUE_NRO),
   foreign key(CHE_MONEDA_COD) references monedas(MONEDA_COD) 
  );

  create table tarjetas(
   TAR_ID int identity,
   TAR_FCREA smalldatetime,
   TAR_NRO int,
   CLI_ID int,
   SUC_ID int,
   primary key (TAR_ID),
   foreign key (CLI_ID) references clientes (CLI_ID)
  );

  create table tarjetas_deu(
   TAR_DEU_COD_NEGOCIO int,
   TAR_DEU_MONTO real,
   TAR_DEU_MONEDA_COD int,
   TAR_DEU_FECHA smalldatetime,
   TAR_ID int,
   foreign key (TAR_ID) references tarjetas (TAR_ID),
   foreign key(TAR_DEU_MONEDA_COD) references monedas(MONEDA_COD) 
  );

  create table tarjetas_pag(
   TAR_PAG_MONTO real,
   TAR_PAG_MONEDA_COD int,
   TAR_PAG_FECHA smalldatetime,
   TAR_ID int,
   foreign key (TAR_ID) references tarjetas (TAR_ID),
   foreign key(TAR_PAG_MONEDA_COD) references monedas(MONEDA_COD) 
  );


go  

create table audit_log(
   Accion nchar(6),
   Tabla nchar(20),
   OLD_TAR_ID int,
   OLD_TAR_MONTO real,
   OLD_TAR_MONEDA_COD int,
   OLD_TAR_FECHA smalldatetime,
   OLD_TAR_DEU_COD_NEGOCIO int DEFAULT null,
   NEW_TAR_ID int DEFAULT null,
   NEW_TAR_MONTO real DEFAULT null,
   NEW_TAR_MONEDA_COD int DEFAULT null,
   NEW_TAR_FECHA smalldatetime DEFAULT null,
   NEW_TAR_DEU_COD_NEGOCIO int DEFAULT null,
   FECHA_LOG smalldatetime
   foreign key (OLD_TAR_ID) references tarjetas (TAR_ID),
   foreign key (NEW_TAR_ID) references tarjetas (TAR_ID)
  );

 go
 
 create table proceso_calidad_clientes(
	CLI_DNI int,
	BANC_CUIT int,
	PCC_FECHA smalldatetime,
	PCC_ID int,
	PCC_VALOR int,
	foreign key(CLI_DNI) references personas(CLI_DNI)
  );

go


--Llena tabla sucursales

insert into dbo.sucursales_banco
	(BANC_DIR, BANC_DIR_NRO, BANC_CUIT, BANC_NOM)

	select distinct BANC_DIR, BANC_DIR_NRO, BANC_CUIT, BANC_NOM
	from gd_esquema.Maestra
go


--Llena la tabla personas

INSERT INTO personas (CLI_DNI, CLI_NOMB, CLI_APELLIDO, CLI_MAIL)
SELECT DISTINCT CLI_DNI, CLI_NOMB, CLI_APELLIDO, CLI_MAIL
FROM [gd_esquema].[Maestra];

go


--Llena la tabla de clientes

INSERT INTO clientes (CLI_DNI, CLI_COD, SUC_ID)
SELECT DISTINCT CLI_DNI, CLI_COD, sucus.SUC_ID
FROM [gd_esquema].[Maestra] maestra, dbo.sucursales_banco sucus 
WHERE maestra.BANC_DIR_NRO = sucus.BANC_DIR_NRO 
AND maestra.BANC_DIR = sucus.BANC_DIR;

go

--Llena la tabla monedas

INSERT INTO monedas (MONEDA_COD,MONEDA_DESC,MONEDA_COTIZA)
(SELECT DISTINCT CHE_MONEDA ,CHE_MONEDA_COD ,CHE_MONEDA_COTIZA 
FROM [gd_esquema].[Maestra] maestra
where maestra.CHE_MONEDA != 0
union
SELECT DISTINCT TAR_DEU_MONEDA_COD ,TAR_DEU_MONEDA_DESC ,TAR_DEU_MONEDA_COTIZA 
FROM [gd_esquema].[Maestra] maestra
union
SELECT DISTINCT TAR_PAG_MONEDA_COD ,TAR_PAG_MONEDA_DESC ,TAR_PAG_MONEDA_COTIZA 
FROM [gd_esquema].[Maestra] maestra
where maestra.TAR_PAG_MONEDA_COD !=0
union
SELECT DISTINCT PF_MONEDA_COD ,PF_MONEDA_DESC ,PF_MONEDA_COTIZA 
FROM [gd_esquema].[Maestra] maestra
where maestra.PF_MONEDA_COD !=0
union
SELECT DISTINCT TRA_MONEDA ,TRA_MONEDA_COD ,TRA_MONEDA_COTIZA 
FROM [gd_esquema].[Maestra] maestra)

go


--Llena la tabla de tarjetas

INSERT INTO tarjetas
	(TAR_FCREA, 
   	TAR_NRO,
   	CLI_ID,
    SUC_ID)
SELECT DISTINCT 
   TAR_FCREA,
   TAR_NRO,
   clie.CLI_ID,
   sucus.SUC_ID

FROM [gd_esquema].[Maestra] maestra, dbo.clientes clie, dbo.sucursales_banco sucus
WHERE (maestra.CLI_DNI= clie.CLI_DNI) AND
(clie.SUC_ID = sucus.SUC_ID) AND
(maestra.BANC_DIR_NRO = sucus.BANC_DIR_NRO) AND
(maestra.BANC_DIR = sucus.BANC_DIR) AND 
(maestra.TAR_NRO <> 0);

go


--Llena la tabla de tarjetas_deu

INSERT INTO tarjetas_deu(
   TAR_DEU_COD_NEGOCIO,
   TAR_DEU_MONTO,
   TAR_DEU_MONEDA_COD,
   TAR_DEU_FECHA,
   TAR_ID)
SELECT DISTINCT
   TAR_DEU_COD_NEGOCIO,
   TAR_DEU_MONTO,
   TAR_DEU_MONEDA_COD,
   TAR_DEU_FECHA,
   tarj.TAR_ID

FROM [gd_esquema].[Maestra] maestra, dbo.sucursales_banco sucus
INNER JOIN dbo.tarjetas tarj
ON sucus.SUC_ID = tarj.SUC_ID
WHERE (maestra.TAR_NRO = tarj.TAR_NRO) AND (TAR_DEU_FECHA is not null);

go


--Llena la tabla de tarjetas_pag

INSERT INTO tarjetas_pag(
   	TAR_PAG_MONTO,
   	TAR_PAG_MONEDA_COD,
   	TAR_PAG_FECHA,
	TAR_ID)
SELECT DISTINCT
	TAR_PAG_MONTO,
   	TAR_PAG_MONEDA_COD,
   	TAR_PAG_FECHA,
	tarj.TAR_ID

FROM [gd_esquema].[Maestra] maestra, dbo.sucursales_banco sucus
INNER JOIN dbo.tarjetas tarj
ON sucus.SUC_ID = tarj.SUC_ID
WHERE (maestra.TAR_NRO = tarj.TAR_NRO) AND (TAR_PAG_FECHA is not null);

go


-- Llenar tabla de cuentas

INSERT INTO dbo.cuentas
   (CUE_MONEDA_COD,
    CUE_NRO,
    CUE_FCREA,
    CLI_ID)

SELECT DISTINCT
   m.CHE_MONEDA,
   m.CHE_CUE_ORIGEN,
   m.CHE_CUE_ORIGEN_FCREA,
   c.CLI_ID
FROM [gd_esquema].[Maestra] m, dbo.clientes c
WHERE m.CHE_CUE_ORIGEN_FCREA IS NOT NULL
AND m.CHE_CUE_DESTINO_FCREA IS NOT NULL
AND c.CLI_DNI = m.CLI_DNI
AND m.BANC_DIR_NRO = (SELECT DISTINCT BANC_DIR_NRO FROM dbo.sucursales_banco s WHERE c.SUC_ID = s.SUC_ID)
AND m.BANC_DIR = (SELECT DISTINCT BANC_DIR FROM dbo.sucursales_banco s WHERE c.SUC_ID = s.SUC_ID)

go

INSERT INTO dbo.cuentas
   (CUE_MONEDA_COD,
    CUE_NRO,
    CUE_FCREA,
    CLI_ID)

SELECT DISTINCT
   m.TRA_MONEDA,
   m.TRA_CUE_ORIGEN,
   m.TRA_CUE_ORIGEN_FECRA,
   c.CLI_ID
FROM [gd_esquema].[Maestra] m, dbo.clientes c
WHERE m.TRA_CUE_ORIGEN_FECRA IS NOT NULL
AND c.CLI_DNI = m.CLI_DNI
AND m.BANC_DIR_NRO = (SELECT DISTINCT BANC_DIR_NRO FROM dbo.sucursales_banco s WHERE c.SUC_ID = s.SUC_ID)
AND not exists (SELECT * FROM dbo.cuentas
	WHERE m.TRA_CUE_ORIGEN = dbo.cuentas.CUE_NRO)
AND m.BANC_DIR = (SELECT DISTINCT BANC_DIR FROM dbo.sucursales_banco s WHERE c.SUC_ID = s.SUC_ID)

go


--Llena tabla de cheques

INSERT into dbo.cheques
  (CHE_CUE_ORIGEN,
   CHE_CUE_ORIGEN_FCREA,
   CHE_CUE_DESTINO,
   CHE_CUE_DESTINO_FCREA,
   CHE_NRO,
   CHE_MONTO,
   CHE_FECHA,
   CHE_MONEDA_COD)

SELECT 
   CHE_CUE_ORIGEN,
   CHE_CUE_ORIGEN_FCREA,
   CHE_CUE_DESTINO,
   CHE_CUE_DESTINO_FCREA,
   CHE_NRO,
   CHE_MONTO,
   CHE_FECHA,
   CHE_MONEDA
FROM [gd_esquema].[Maestra]
WHERE CHE_CUE_ORIGEN_FCREA IS NOT NULL
AND CHE_CUE_DESTINO_FCREA IS NOT NULL;

go


--LLena tabla de transacciones 

INSERT INTO transacciones 
   (TRA_CUE_ORIGEN,
   TRA_CUE_ORIGEN_FECRA,
   TRA_CUE_DESTINO,
   TRA_CUE_DESTINO_FCREA,
   TRA_FECHA,
   TRA_MONTO,
   TRA_MONEDA_COD)

SELECT
   TRA_CUE_ORIGEN,
   TRA_CUE_ORIGEN_FECRA,
   TRA_CUE_DESTINO,
   TRA_CUE_DESTINO_FCREA,
   TRA_FECHA,
   TRA_MONTO,
   TRA_MONEDA  
FROM [gd_esquema].[Maestra] maestra
WHERE TRA_CUE_ORIGEN_FECRA is not null
AND TRA_CUE_DESTINO_FCREA is not null
UNION ALL
SELECT
   NULL,
   NULL,
   TRA_CUE_DESTINO,
   TRA_CUE_DESTINO_FCREA,
   TRA_FECHA,
   TRA_MONTO,
   TRA_MONEDA 
FROM [gd_esquema].[Maestra] maestra
WHERE TRA_CUE_ORIGEN_FECRA is null
AND TRA_CUE_DESTINO_FCREA is not null
UNION ALL
SELECT
   TRA_CUE_ORIGEN,
   TRA_CUE_ORIGEN_FECRA,
   NULL,
   NULL,
   TRA_FECHA,
   TRA_MONTO,
   TRA_MONEDA
FROM [gd_esquema].[Maestra] maestra
WHERE TRA_CUE_ORIGEN_FECRA is not null
AND TRA_CUE_DESTINO_FCREA is null;

go

--LLena la tabla de plazos fijos 

INSERT INTO plazosfijos 
   (PF_COD,
   PF_IMPOR,
   PF_FCREA,
   PF_FFIN,
   PF_MONEDA_COD,
   PF_PLAZO,
   PF_PORC,
   CLI_ID)
SELECT DISTINCT
   PF_COD,
   PF_IMPOR,
   PF_FCREA,
   PF_FFIN,
   PF_MONEDA_COD,
   PF_PLAZO,
   PF_PORC,
   c.CLI_ID
FROM [gd_esquema].[Maestra] m, dbo.clientes c
WHERE m.PF_FCREA IS NOT NULL
AND c.CLI_COD = m.CLI_COD
AND m.BANC_DIR_NRO = (SELECT DISTINCT BANC_DIR_NRO FROM dbo.sucursales_banco s WHERE c.SUC_ID = s.SUC_ID)
AND m.BANC_DIR = (SELECT DISTINCT BANC_DIR FROM dbo.sucursales_banco s WHERE c.SUC_ID = s.SUC_ID)




------------------------------------- Creacion de Views--------------------------


if object_id('abm_cuentas') is not null
	drop view abm_cuentas;

go

CREATE VIEW abm_cuentas
AS(
SELECT cue.CUE_NRO, cue.CLI_ID, CLI_NOMB, CLI_APELLIDO, clie.CLI_DNI, sucus.BANC_NOM, sucus.BANC_DIR, sucus.BANC_DIR_NRO, CUE_SALDO, mon.MONEDA_DESC
FROM dbo.cuentas cue
INNER JOIN dbo.clientes clie
ON cue.CLI_ID = clie.CLI_ID
INNER JOIN dbo.personas pers
ON pers.CLI_DNI = clie.CLI_DNI
INNER JOIN dbo.sucursales_banco sucus
ON (clie.SUC_ID = sucus.SUC_ID)
INNER JOIN dbo.monedas mon
ON cue.CUE_MONEDA_COD = mon.MONEDA_COD
WHERE cue.CUE_ESTADO = 1);

go





---- FUNCIONES PARA PLAZOS FIJOS


IF OBJECT_ID ('dbo.PORCENTAJE') IS NOT NULL
	DROP FUNCTION dbo.PORCENTAJE;
IF OBJECT_ID ('dbo.INTERESGANADO') IS NOT NULL
	DROP FUNCTION dbo.INTERESGANADO;

GO

CREATE FUNCTION PORCENTAJE(@PORC REAL, @CANT INT) RETURNS REAL
BEGIN
	RETURN ((@PORC * @CANT) / 100)
END;

GO

CREATE FUNCTION INTERESGANADO(@FECINI SMALLDATETIME, @FECFIN SMALLDATETIME, @MONTO REAL) RETURNS REAL
BEGIN
	DECLARE @FECACTUAL SMALLDATETIME;
	DECLARE @DIFFDIAS INT;
	DECLARE @DIFFMESES INT;

	SET @FECACTUAL = GETDATE();

	-- Si la fecha de finalizacion del pf caduco, la seteo como fecha final del calculo
	IF (@FECFIN < @FECACTUAL)
		 SET @FECACTUAL = @FECFIN;

	SET @DIFFMESES = DATEDIFF(month, @FECINI, @FECACTUAL);

	IF (DATEDIFF(day, @FECINI, @FECACTUAL) != 0 AND @DIFFMESES != 0)
		SET @DIFFDIAS = ((@DIFFMESES * 30)  % DATEDIFF(day, @FECINI, @FECACTUAL));

	IF (DATEDIFF(day, @FECINI, @FECACTUAL) != 0 AND @DIFFMESES = 0)
		SET @DIFFDIAS = DATEDIFF(day, @FECINI, @FECACTUAL);

	IF (@DIFFMESES <= 3)
		RETURN (@MONTO + dbo.PORCENTAJE(5, @DIFFMESES) + dbo.PORCENTAJE(0.57, @DIFFDIAS));

	IF (@DIFFMESES > 3 AND @DIFFMESES <= 6)
		RETURN (@MONTO + dbo.PORCENTAJE(12, @DIFFMESES) + dbo.PORCENTAJE(0.57, @DIFFDIAS));

	IF (@DIFFMESES > 6 AND @DIFFMESES <= 12)
		RETURN (@MONTO + dbo.PORCENTAJE(17, @DIFFMESES) + dbo.PORCENTAJE(0.57, @DIFFDIAS));

	IF (@DIFFMESES > 12)
		RETURN (@MONTO + dbo.PORCENTAJE(23, @DIFFMESES) + dbo.PORCENTAJE(0.57, @DIFFDIAS));

	RETURN @MONTO;
END;


GO


-- FUNCIONES PARA OTORGACION DE PRESTAMOS ------->>>>>>>>>>>>>>>>>>>>>

IF OBJECT_ID('dbo.PROCESO_OTORGACION_PRESTAMOS') IS NOT NULL
	DROP TABLE dbo.PROCESO_OTORGACION_PRESTAMOS;

GO

CREATE TABLE PROCESO_OTORGACION_PRESTAMOS (
	CLI_DNI int,
	ID_BANCO int,
	FEC_PROCESO smalldatetime,
	ID_PROCESO int identity,
	MONTO real,
	primary key(ID_PROCESO)
	);

GO

IF OBJECT_ID('dbo.CALCULAR_MESES_DE_DEUDA_PARA_CUENTA') IS NOT NULL
	DROP FUNCTION dbo.CALCULAR_MESES_DE_DEUDA_PARA_CUENTA;

GO

CREATE FUNCTION CALCULAR_MESES_DE_DEUDA_PARA_CUENTA(@CUE_NRO INT) RETURNS INT
BEGIN
	DECLARE @MONTO REAL;
	DECLARE @MONTO_ANT REAL;
	DECLARE @MESES_DEUDA INT;
	DECLARE @INGRESO INT;
	DECLARE @EGRESO INT;
	DECLARE @FECHA SMALLDATETIME;
	DECLARE @FECHAINICIODEUDA SMALLDATETIME;
	DECLARE @FECHAFINDEUDA SMALLDATETIME;

	-- INICIALIZACION DE VARIABLES
	SET @MONTO = 0;
	SET @MONTO_ANT = 0;
	SET @MESES_DEUDA = 0;

	DECLARE CUR CURSOR FOR
		(
		SELECT CHE_MONTO, 0, CHE_FECHA FROM CHEQUES
		WHERE CHE_CUE_DESTINO = @CUE_NRO

		UNION ALL

		SELECT 0, CHE_MONTO, CHE_FECHA FROM CHEQUES
		WHERE CHE_CUE_ORIGEN = @CUE_NRO

		UNION ALL

		SELECT TRA_MONTO, 0, TRA_FECHA FROM TRANSACCIONES
		WHERE TRA_CUE_DESTINO = @CUE_NRO

		UNION ALL

		SELECT 0, TRA_MONTO, TRA_FECHA FROM TRANSACCIONES
		WHERE TRA_CUE_ORIGEN = @CUE_NRO
		) ORDER BY 3

	OPEN CUR
		fetch next from CUR into @INGRESO, @EGRESO, @FECHA

	-- RECORRO TODOS LOS REGISTROS
	WHILE @@fetch_status = 0
	BEGIN

		SET @MONTO_ANT = @MONTO;
		SET @MONTO = (@MONTO - @EGRESO + @INGRESO);

		IF (@MONTO < 0 AND @MONTO_ANT >= 0)
			SET @FECHAINICIODEUDA = @FECHA;

		IF (@MONTO >= 0 AND @MONTO_ANT <0)
			SET @MESES_DEUDA = @MESES_DEUDA + DATEDIFF(MONTH, @FECHAINICIODEUDA, @FECHA);


		fetch next from CUR into @INGRESO, @EGRESO, @FECHA
	END
	
	if (@MONTO < 0)
		SET @MESES_DEUDA = @MESES_DEUDA + DATEDIFF(MONTH, @FECHAINICIODEUDA, GETDATE());

	RETURN @MESES_DEUDA;
END;


go

IF OBJECT_ID('DBO.PROMEDIO_ANUAL_TRANSACCIONES') IS NOT NULL
	DROP FUNCTION DBO.PROMEDIO_ANUAL_TRANSACCIONES;

GO

CREATE FUNCTION PROMEDIO_ANUAL_TRANSACCIONES(@DNICLIENTE INT, @BANC_CUIT INT) RETURNS REAL
BEGIN
	DECLARE @PROM REAL;
	DECLARE @CANT_ANIOS INT;
	DECLARE @MONTO_TOTAL REAL;
	DECLARE @FEC_PRI_TRA SMALLDATETIME;

	SET @MONTO_TOTAL = (SELECT SUM(TRA_MONTO * m.MONEDA_COTIZA)
	FROM DBO.CLIENTES CLI
	INNER JOIN DBO.CUENTAS CUE ON CLI.CLI_ID = CUE.CLI_ID
	INNER JOIN DBO.TRANSACCIONES TRA ON TRA.TRA_CUE_DESTINO = CUE.CUE_NRO
	INNER JOIN DBO.SUCURSALES_BANCO SUCUS ON SUCUS.SUC_ID = CLI.SUC_ID
	inner join DBO.monedas m ON m.MONEDA_COD = TRA.TRA_MONEDA_COD
	WHERE CLI.CLI_DNI = @DNICLIENTE
	AND SUCUS.BANC_CUIT = @BANC_CUIT
	AND CLI.CLI_ESTADO = 1)

	SET @FEC_PRI_TRA = (SELECT DISTINCT MIN(TRA_FECHA)
	FROM DBO.CLIENTES CLI
	INNER JOIN DBO.CUENTAS CUE ON CLI.CLI_ID = CUE.CLI_ID
	INNER JOIN DBO.TRANSACCIONES TRA ON TRA.TRA_CUE_DESTINO = CUE.CUE_NRO
	INNER JOIN DBO.SUCURSALES_BANCO SUCUS ON SUCUS.SUC_ID = CLI.SUC_ID
	WHERE CLI.CLI_DNI = @DNICLIENTE
	AND SUCUS.BANC_CUIT = @BANC_CUIT
	AND CLI.CLI_ESTADO = 1)

	SET @CANT_ANIOS = (DATEDIFF(YEAR, @FEC_PRI_TRA, GETDATE()) + 1);

	RETURN (@MONTO_TOTAL / @CANT_ANIOS);
END;

GO

--- >>>>>>>>>>>>>

IF OBJECT_ID('DBO.PROMEDIO_ANUAL_CHEQUES') IS NOT NULL
	DROP FUNCTION DBO.PROMEDIO_ANUAL_CHEQUES;

GO

CREATE FUNCTION PROMEDIO_ANUAL_CHEQUES(@DNICLIENTE INT, @BANC_CUIT INT) RETURNS REAL
BEGIN
	DECLARE @PROM REAL;
	DECLARE @CANT_ANIOS INT;
	DECLARE @MONTO_TOTAL REAL;
	DECLARE @FEC_PRI_CHE SMALLDATETIME;

	SET @MONTO_TOTAL = (SELECT SUM(CHE_MONTO * m.MONEDA_COTIZA)
	FROM DBO.CLIENTES CLI
	INNER JOIN DBO.CUENTAS CUE ON CLI.CLI_ID = CUE.CLI_ID
	INNER JOIN DBO.CHEQUES CHE ON CHE.CHE_CUE_DESTINO = CUE.CUE_NRO
	INNER JOIN DBO.SUCURSALES_BANCO SUCUS ON SUCUS.SUC_ID = CLI.SUC_ID
	inner join DBO.monedas m ON m.MONEDA_COD = CHE.CHE_MONEDA_COD
	WHERE CLI.CLI_DNI = @DNICLIENTE
	AND SUCUS.BANC_CUIT = @BANC_CUIT
	AND CLI.CLI_ESTADO = 1)

	SET @FEC_PRI_CHE = (SELECT DISTINCT MIN(CHE_FECHA)
	FROM DBO.CLIENTES CLI
	INNER JOIN DBO.CUENTAS CUE ON CLI.CLI_ID = CUE.CLI_ID
	INNER JOIN DBO.CHEQUES CHE ON CHE.CHE_CUE_DESTINO = CUE.CUE_NRO
	INNER JOIN DBO.SUCURSALES_BANCO SUCUS ON SUCUS.SUC_ID = CLI.SUC_ID
	WHERE CLI.CLI_DNI = @DNICLIENTE
	AND SUCUS.BANC_CUIT = @BANC_CUIT
	AND CLI.CLI_ESTADO = 1)

	SET @CANT_ANIOS = (DATEDIFF(YEAR, @FEC_PRI_CHE, GETDATE()) + 1);

	RETURN (@MONTO_TOTAL / @CANT_ANIOS);
END;

GO

--- >>>>>>>>>>>>>

IF OBJECT_ID('DBO.PROMEDIO_ANUAL_TARJETAS') IS NOT NULL
	DROP FUNCTION DBO.PROMEDIO_ANUAL_TARJETAS;

GO

CREATE FUNCTION PROMEDIO_ANUAL_TARJETAS(@DNICLIENTE INT, @BANC_CUIT INT) RETURNS REAL
BEGIN
	DECLARE @PROM REAL;
	DECLARE @CANT_ANIOS INT;
	DECLARE @MONTO_TOTAL REAL;
	DECLARE @FEC_PRI_TAR_deu SMALLDATETIME;
	DECLARE @FEC_PRI_TAR_pag SMALLDATETIME;
	DECLARE @FEC_PRI_TAR SMALLDATETIME;

	SET @MONTO_TOTAL = (select sum(t_deu.TAR_DEU_MONTO * m.MONEDA_COTIZA)
	from clientes cli
	inner join sucursales_banco s on cli.SUC_ID = s.SUC_ID
	inner join tarjetas t on cli.CLI_ID = t.CLI_ID
	inner join tarjetas_deu t_deu on t.TAR_ID = t_deu.TAR_ID
	inner join monedas m on m.MONEDA_COD = t_deu.TAR_DEU_MONEDA_COD
	where cli.CLI_DNI = @DNICLIENTE
	AND s.BANC_CUIT = @BANC_CUIT
	and cli.CLI_ESTADO = 1)

	SET @MONTO_TOTAL = @MONTO_TOTAL + (select sum(t_pag.TAR_PAG_MONTO * m.MONEDA_COTIZA)
	from clientes cli
	inner join sucursales_banco s on cli.SUC_ID = s.SUC_ID
	inner join tarjetas t on cli.CLI_ID = t.CLI_ID
	inner join tarjetas_pag t_pag on t.TAR_ID = t_pag.TAR_ID
	inner join monedas m on m.MONEDA_COD = t_pag.TAR_PAG_MONEDA_COD
	where cli.CLI_DNI = @DNICLIENTE
	AND s.BANC_CUIT = @BANC_CUIT
	and cli.CLI_ESTADO = 1)


	SET @FEC_PRI_tar_pag = (SELECT DISTINCT MIN(TAR_PAG_FECHA)
	FROM DBO.CLIENTES CLI
	inner join sucursales_banco s on cli.SUC_ID = s.SUC_ID
	inner join tarjetas t on cli.CLI_ID = t.CLI_ID
	inner join tarjetas_pag t_pag on t.TAR_ID = t_pag.TAR_ID
	inner join monedas m on m.MONEDA_COD = t_pag.TAR_PAG_MONEDA_COD
	where cli.CLI_DNI = @DNICLIENTE
	AND s.BANC_CUIT = @BANC_CUIT
	and cli.CLI_ESTADO = 1)

	SET @FEC_PRI_tar_deu = (SELECT DISTINCT MIN(TAR_DEU_FECHA)
	FROM DBO.CLIENTES CLI
	inner join sucursales_banco s on cli.SUC_ID = s.SUC_ID
	inner join tarjetas t on cli.CLI_ID = t.CLI_ID
	inner join tarjetas_deu t_deu on t.TAR_ID = t_deu.TAR_ID
	inner join monedas m on m.MONEDA_COD = t_deu.TAR_DEU_MONEDA_COD
	where cli.CLI_DNI = @DNICLIENTE
	AND s.BANC_CUIT = @BANC_CUIT
	and cli.CLI_ESTADO = 1)

	if (@FEC_PRI_tar_deu > @FEC_PRI_tar_pag)
		SET @FEC_PRI_TAR = @FEC_PRI_tar_pag;

	if (@FEC_PRI_tar_deu <= @FEC_PRI_tar_pag)
		SET @FEC_PRI_TAR = @FEC_PRI_tar_deu;
		
	SET @CANT_ANIOS = (DATEDIFF(YEAR, @FEC_PRI_TAR, GETDATE()) + 1);

	RETURN (@MONTO_TOTAL / @CANT_ANIOS);
END;

GO


IF OBJECT_ID('dbo.MONTO_MAXIMO_PRESTAMO') IS NOT NULL
	DROP FUNCTION dbo.MONTO_MAXIMO_PRESTAMO;

GO

CREATE FUNCTION MONTO_MAXIMO_PRESTAMO(@DNI INT, @CUIT INT) RETURNS REAL
BEGIN
	DECLARE @MONTO_TOTAL REAL;
	DECLARE @CUENTA INT;
	DECLARE @MESES INT;


	SET @MONTO_TOTAL = (((SELECT DISTINCT DBO.PROMEDIO_ANUAL_TRANSACCIONES(@DNI, @CUIT) FROM CLIENTES C, SUCURSALES_BANCO
		WHERE C.CLI_DNI = @DNI AND BANC_CUIT = @CUIT) * 60) / 100);

	SET @MONTO_TOTAL = @MONTO_TOTAL + (((SELECT DISTINCT DBO.PROMEDIO_ANUAL_CHEQUES(@DNI, @CUIT) FROM CLIENTES, SUCURSALES_BANCO
		WHERE CLI_DNI = @DNI AND BANC_CUIT = @CUIT) * 45) / 100);

	SET @MONTO_TOTAL = @MONTO_TOTAL - (((SELECT DISTINCT DBO.PROMEDIO_ANUAL_TARJETAS(@DNI, @CUIT) FROM CLIENTES, SUCURSALES_BANCO
		WHERE CLI_DNI = @DNI AND BANC_CUIT = @CUIT) * 7) / 100);


	DECLARE CUR CURSOR FOR (
		SELECT CUE_NRO FROM CUENTAS CUE, CLIENTES CLIE, SUCURSALES_BANCO SUCUS
		WHERE CUE.CLI_ID = CLIE.CLI_ID
		AND CLIE.SUC_ID = SUCUS.SUC_ID
		AND CLIE.CLI_DNI = @DNI
		AND SUCUS.BANC_CUIT = @CUIT)

	OPEN CUR
		fetch next from CUR into @CUENTA

	WHILE @@fetch_status = 0
	BEGIN
		SET @MESES = DBO.CALCULAR_MESES_DE_DEUDA_PARA_CUENTA(@CUENTA);

		IF (@MESES = 0)
			SET @MONTO_TOTAL = @MONTO_TOTAL + ((@MONTO_TOTAL * 20) / 100);

		IF (@MESES >= 1 AND @MESES <= 3)
			SET @MONTO_TOTAL = @MONTO_TOTAL + ((@MONTO_TOTAL * 10) / 100);

		IF (@MESES >= 4 AND @MESES <= 6)
			SET @MONTO_TOTAL = @MONTO_TOTAL + ((@MONTO_TOTAL * 5) / 100);

		fetch next from CUR into @CUENTA
	END

	RETURN @MONTO_TOTAL;
END;

go



--FUNCIONES Y PROCESOS PARA TRANSACCIONES ----->>>>>>>>>>>>>>>>>>>>>>>>>>>>

IF OBJECT_ID ('dbo.extraccion') IS NOT NULL
	DROP PROCEDURE dbo.extraccion;
IF OBJECT_ID ('dbo.deposito') IS NOT NULL
	DROP PROCEDURE dbo.deposito;
IF OBJECT_ID ('dbo.transferencia') IS NOT NULL
	DROP PROCEDURE dbo.transferencia;
IF OBJECT_ID ('dbo.agregarTransaccion') IS NOT NULL
	DROP PROCEDURE dbo.agregarTransaccion;
IF OBJECT_ID ('dbo.cambio_moneda') IS NOT NULL
	DROP FUNCTION dbo.cambio_moneda;


go

CREATE FUNCTION cambio_moneda(@MONTO real, @COD_ORIGEN int,@COD_DEST int)RETURNS real
  BEGIN 
		DECLARE @COTIZA_ORIGEN real;
		DECLARE @COTIZA_DEST real;
		DECLARE @MONTO_FINAL real;

IF (@COD_ORIGEN = @COD_DEST)
	RETURN @MONTO;

SET @COTIZA_ORIGEN = (select MONEDA_COTIZA from dbo.monedas m
					where m.MONEDA_COD = @COD_ORIGEN);

SET @COTIZA_DEST = (select MONEDA_COTIZA from dbo.monedas m
					where m.MONEDA_COD = @COD_DEST);

SET @MONTO_FINAL = @MONTO * @COTIZA_ORIGEN / @COTIZA_DEST;

RETURN @MONTO_FINAL;    

END;

go    
             
        

CREATE PROCEDURE agregarTransaccion
(@CUENTA_ORIGEN int, @CUENTA_DEST int, @MONTO real, @MONEDA int) 

AS BEGIN
	DECLARE @FECHA_CUE_ORIGEN smalldatetime;
	DECLARE @FECHA_CUE_DEST smalldatetime;
	DECLARE @FECHA smalldatetime;

SET @FECHA = Getdate();


if (@CUENTA_ORIGEN = NULL)
	SET @FECHA_CUE_ORIGEN = NULL;
		
else
	SET @FECHA_CUE_ORIGEN = 
		(select CUE_FCREA from cuentas c
			where c.CUE_NRO = @CUENTA_ORIGEN);
	

if (@CUENTA_DEST = NULL)
	SET @FECHA_CUE_DEST = NULL;
		
else
	SET @FECHA_CUE_DEST = 
		(select CUE_FCREA from cuentas c
			where c.CUE_NRO = @CUENTA_DEST);

INSERT into dbo.transacciones
  (TRA_CUE_ORIGEN,
   TRA_CUE_ORIGEN_FECRA,
   TRA_CUE_DESTINO,
   TRA_CUE_DESTINO_FCREA,
   TRA_FECHA,
   TRA_MONTO,
   TRA_MONEDA_COD)

values
   (@CUENTA_ORIGEN,
   @FECHA_CUE_ORIGEN,
   @CUENTA_DEST,
   @FECHA_CUE_DEST, 
   @FECHA,
   @MONTO,
   @MONEDA) 
   
END;

go


CREATE PROCEDURE extraccion (@CUENTA int, @MONTO real, @MONEDA int)
AS BEGIN

		DECLARE @SALDO_ANT real;
		DECLARE @SALDO_ACT real;
		DECLARE @MONTO_FINAL real;
		DECLARE @MONEDA2 real;

SET @MONEDA2 = (select CUE_MONEDA_COD from dbo.cuentas m
				where m.CUE_NRO = @CUENTA);

SET @MONTO_FINAL = dbo.cambio_moneda(@MONTO, @MONEDA, @MONEDA2)

SET @SALDO_ANT = (select CUE_SALDO from dbo.cuentas 
					where dbo.cuentas.CUE_NRO = @CUENTA);

SET @SALDO_ACT = (@SALDO_ANT - @MONTO_FINAL);

UPDATE dbo.cuentas  SET CUE_SALDO = @SALDO_ACT
WHERE dbo.cuentas.CUE_NRO = @CUENTA AND dbo.cuentas.CUE_ESTADO = 1;

if (( select CUE_ESTADO from dbo.cuentas where dbo.cuentas.CUE_NRO = @CUENTA) = 1 )
exec agregarTransaccion @CUENTA_ORIGEN = NULL, @CUENTA_DEST = @CUENTA, @MONTO = @MONTO, @MONEDA = @MONEDA; 
	
			
END;

go


CREATE PROCEDURE deposito (@CUENTA int, @MONTO real, @MONEDA int)
AS BEGIN

		DECLARE @SALDO_ANT real;
		DECLARE @SALDO_ACT real;
		DECLARE @MONTO_FINAL real;
		DECLARE @MONEDA2 real;

SET @MONEDA2 = (select CUE_MONEDA_COD from dbo.cuentas m
				where m.CUE_NRO = @CUENTA);

SET @MONTO_FINAL = dbo.cambio_moneda(@MONTO, @MONEDA, @MONEDA2)


SET @SALDO_ANT = (select CUE_SALDO from dbo.cuentas 
					where dbo.cuentas.CUE_NRO = @CUENTA);

SET @SALDO_ACT = (@SALDO_ANT + @MONTO_FINAL);

UPDATE dbo.cuentas SET CUE_SALDO = @SALDO_ACT
WHERE dbo.cuentas.CUE_NRO = @CUENTA AND dbo.cuentas.CUE_ESTADO = 1;

if (( select CUE_ESTADO from dbo.cuentas where dbo.cuentas.CUE_NRO = @CUENTA) = 1 )
exec agregarTransaccion @CUENTA_ORIGEN = @CUENTA, @CUENTA_DEST = NULL, @MONTO = @MONTO, @MONEDA = @MONEDA; 
		
			
END;


go


CREATE PROCEDURE transferencia (@CUENTA_ORIGEN int, @CUENTA_DEST int, @MONTO real, @MONEDA int)
AS BEGIN

		DECLARE @SALDO_ANT_ORIGEN real;
		DECLARE @SALDO_ACT_ORIGEN real;
		DECLARE @SALDO_ANT_DEST real;
		DECLARE @SALDO_ACT_DEST real;
		DECLARE @MONTO_FINAL_ORIGEN real;
		DECLARE @MONEDA_ORIGEN int;
		DECLARE @MONTO_FINAL_DEST real;
		DECLARE @MONEDA_DEST int;

SET @MONEDA_ORIGEN = (select CUE_MONEDA_COD from dbo.cuentas m
				where m.CUE_NRO = @CUENTA_ORIGEN);

SET @MONTO_FINAL_ORIGEN = dbo.cambio_moneda(@MONTO, @MONEDA, @MONEDA_ORIGEN)

SET @MONEDA_DEST = (select CUE_MONEDA_COD from dbo.cuentas m
				where m.CUE_NRO = @CUENTA_DEST);

SET @MONTO_FINAL_DEST = dbo.cambio_moneda(@MONTO, @MONEDA, @MONEDA_ORIGEN)

SET @SALDO_ANT_ORIGEN = (select CUE_SALDO from dbo.cuentas 
						where dbo.cuentas.CUE_NRO = @CUENTA_ORIGEN
						AND dbo.cuentas.CUE_ESTADO = 1);

SET @SALDO_ANT_DEST = (select CUE_SALDO from dbo.cuentas
						where dbo.cuentas.CUE_NRO = @CUENTA_DEST
						AND dbo.cuentas.CUE_ESTADO = 1);

SET @SALDO_ACT_ORIGEN = (@SALDO_ANT_ORIGEN - @MONTO_FINAL_ORIGEN);
SET @SALDO_ACT_DEST = (@SALDO_ANT_DEST + @MONTO_FINAL_DEST);


IF (@SALDO_ANT_DEST IS NOT NULL AND @SALDO_ANT_ORIGEN IS NOT NULL)
UPDATE dbo.cuentas  SET CUE_SALDO = @SALDO_ACT_ORIGEN
WHERE dbo.cuentas.CUE_NRO = @CUENTA_ORIGEN;

IF (@SALDO_ANT_DEST IS NOT NULL AND @SALDO_ANT_ORIGEN IS NOT NULL)
UPDATE dbo.cuentas  SET CUE_SALDO = @SALDO_ACT_DEST
WHERE dbo.cuentas.CUE_NRO = @CUENTA_DEST;


IF (@SALDO_ANT_DEST IS NOT NULL AND @SALDO_ANT_ORIGEN IS NOT NULL)
exec agregarTransaccion @CUENTA_ORIGEN = @CUENTA_ORIGEN, @CUENTA_DEST = @CUENTA_DEST, @MONTO = @MONTO, @MONEDA = @MONEDA; 
		
END;

go

IF object_id ('calcular_saldo') is not null
	drop function calcular_saldo;

go

CREATE FUNCTION calcular_saldo (@CUENTA int) RETURNS REAL

BEGIN
	
	DECLARE @MONTO_INI real;
	DECLARE @TRA_ORIGEN real;
	DECLARE @TRA_DESTINO real;
	DECLARE @CHE_ORIGEN real;
	DECLARE @CHE_DESTINO real;
	DECLARE @MONTO_FIN real;

	SET @MONTO_INI =	(SELECT SUM(CUE_SALDO)
						FROM cuentas
						WHERE CUE_SALDO = @CUENTA);	
	IF @MONTO_INI is null SET @MONTO_INI = 0;

	SET @TRA_ORIGEN =	(SELECT SUM(TRA_MONTO)
						FROM transacciones tra
						INNER JOIN cuentas cue
						ON cue.CUE_NRO = tra.TRA_CUE_ORIGEN
						WHERE cue.CUE_NRO = @CUENTA);
	IF @TRA_ORIGEN is null SET @TRA_ORIGEN = 0;

	SET @TRA_DESTINO =	(SELECT SUM(TRA_MONTO)
						FROM transacciones tra
						INNER JOIN cuentas cue
						ON cue.CUE_NRO = tra.TRA_CUE_DESTINO
						WHERE cue.CUE_NRO = @CUENTA);
	IF @TRA_DESTINO is null SET @TRA_DESTINO = 0;

	SET @CHE_ORIGEN =	(SELECT SUM(CHE_MONTO)
						FROM cheques che
						INNER JOIN cuentas cue
						ON cue.CUE_NRO = che.CHE_CUE_ORIGEN
						WHERE cue.CUE_NRO = @CUENTA);
	IF @CHE_ORIGEN is null SET @CHE_ORIGEN = 0;
		
	SET @CHE_DESTINO =	(SELECT SUM(CHE_MONTO)
			 			FROM cheques che
				 		INNER JOIN cuentas cue
						ON cue.CUE_NRO = che.CHE_CUE_DESTINO
						WHERE cue.CUE_NRO = @CUENTA);
	IF @CHE_DESTINO is null SET @CHE_DESTINO = 0;

	SET @MONTO_FIN = @MONTO_INI + @TRA_DESTINO + @CHE_DESTINO - @TRA_ORIGEN - @CHE_ORIGEN;

RETURN @MONTO_FIN;

END;

---CREACION DE TRIGGERS

go

CREATE TRIGGER audit_tarjetas_deu
ON tarjetas_deu
AFTER UPDATE, DELETE
AS
SET NOCOUNT ON;
IF EXISTS(SELECT * FROM inserted)
	BEGIN
		INSERT INTO audit_log (NEW_TAR_ID, NEW_TAR_MONTO, NEW_TAR_MONEDA_COD, NEW_TAR_FECHA, NEW_TAR_DEU_COD_NEGOCIO, Accion, Tabla, OLD_TAR_ID, OLD_TAR_MONTO, OLD_TAR_MONEDA_COD, OLD_TAR_FECHA, OLD_TAR_DEU_COD_NEGOCIO, FECHA_LOG)
		SELECT i.TAR_ID, i.TAR_DEU_MONTO, i.TAR_DEU_MONEDA_COD, i.TAR_DEU_FECHA, i.TAR_DEU_COD_NEGOCIO, 'Update', 'tarjetas_deu', d.TAR_ID, d.TAR_DEU_MONTO, d.TAR_DEU_MONEDA_COD, d.TAR_DEU_FECHA, d.TAR_DEU_COD_NEGOCIO, GetDate()
		FROM deleted d, inserted i
		WHERE i.TAR_ID = d.TAR_ID
	END
ELSE
	BEGIN
		INSERT INTO audit_log (Accion, Tabla, OLD_TAR_ID, OLD_TAR_MONTO, OLD_TAR_MONEDA_COD, OLD_TAR_FECHA, OLD_TAR_DEU_COD_NEGOCIO, FECHA_LOG)
		SELECT 'Delete', 'tarjetas_deu', d.TAR_ID, d.TAR_DEU_MONTO, d.TAR_DEU_MONEDA_COD, d.TAR_DEU_FECHA, d.TAR_DEU_COD_NEGOCIO, GetDate()
		FROM deleted d;
	END

go

CREATE TRIGGER audit_tarjetas_pag
ON tarjetas_pag
AFTER UPDATE, DELETE
AS
SET NOCOUNT ON;
IF EXISTS(SELECT * FROM inserted)
	BEGIN
		INSERT INTO audit_log (NEW_TAR_ID, NEW_TAR_MONTO, NEW_TAR_MONEDA_COD, NEW_TAR_FECHA, Accion, Tabla, OLD_TAR_ID, OLD_TAR_MONTO, OLD_TAR_MONEDA_COD, OLD_TAR_FECHA, FECHA_LOG)
		SELECT i.TAR_ID, i.TAR_PAG_MONTO, i.TAR_PAG_MONEDA_COD, i.TAR_PAG_FECHA, 'Update', 'tarjetas_pag', d.TAR_ID, d.TAR_PAG_MONTO, d.TAR_PAG_MONEDA_COD, d.TAR_PAG_FECHA, GetDate()
		FROM deleted d, inserted i
		WHERE i.TAR_ID = d.TAR_ID
	END
ELSE
	BEGIN
		INSERT INTO audit_log (Accion, Tabla, OLD_TAR_ID, OLD_TAR_MONTO, OLD_TAR_MONEDA_COD, OLD_TAR_FECHA, FECHA_LOG)
		SELECT 'Delete', 'tarjetas_pag', d.TAR_ID, d.TAR_PAG_MONTO, d.TAR_PAG_MONEDA_COD, d.TAR_PAG_FECHA,GetDate()
		FROM deleted d;
	END




-- Actualizar Saldos

go

UPDATE cuentas
SET CUE_SALDO = dbo.calcular_saldo(CUE_NRO)



--PROCESO CALIDAD CLIENTES
go

IF object_id ('proc_calidad_clientes') is not null
	drop PROCEDURE proc_calidad_clientes;

go

CREATE PROCEDURE proc_calidad_clientes (@PCC_ID int, @DNI_PRUEBA int)
as BEGIN

	-- declaramos las variables
	declare @dni as int
	declare @cuit as int
	declare @cont as int
	declare @cli_id as int
	declare @suc_id as int
	declare @valor_calidad as int
	declare @aux as int
	declare @aux100 as int
	declare @aux30 as int
	declare @auxTarj as int
	declare @auxTransac as int
	declare @fecha as smalldatetime


	declare @z as int
	set @aux = 0
	set @auxTransac = 0
	set @auxTarj = 0
	set @aux100 = 0
	set @aux30 = 0
	set @cont = 0
	set @valor_calidad = 0
	set @fecha = convert(smalldatetime, GETDATE())

	-- declaramos un cursor llamado "CURSOR_1". El select debe contener sólo los campos a utilizar.
	
	if (@DNI_PRUEBA = 0)
	begin
		declare CURSOR_1 cursor for
		select distinct c.CLI_DNI, s.BANC_CUIT
		from clientes c 
		inner join sucursales_banco s
		on c.SUC_ID = s.SUC_ID
		where c.CLI_ESTADO = 1
		open CURSOR_1
	end
	else
	begin
		declare CURSOR_1 cursor for
		select distinct c.CLI_DNI, s.BANC_CUIT
		from clientes c 
		inner join sucursales_banco s
		on c.SUC_ID = s.SUC_ID
		where c.CLI_ESTADO = 1
		AND c.CLI_DNI = @DNI_PRUEBA
		open CURSOR_1
	end

	-- Avanzamos un registro y cargamos en las variables los valores encontrados en el primer registro
	fetch next from CURSOR_1
	into @dni, @cuit
	while @@fetch_status = 0
	begin
	--Comienza consulta del cursor_1

	------------------------------------------------------
		--Calculo de: 3 puntos por c/cuenta sin deudas
		set @aux =	(select count(cli.CLI_DNI)
					from clientes cli
					inner join cuentas cue
					on cli.CLI_ID = cue.CLI_ID
					inner join sucursales_banco s
					on cli.SUC_ID = s.SUC_ID
					where cli.CLI_ESTADO = 1
					and cli.CLI_DNI = @dni
					and s.BANC_CUIT = @cuit
					and cue.CUE_SALDO >= 0)
		set @valor_calidad = @valor_calidad + (@aux * 3)
		set @aux = 0

	------------------------------------------------------
		--Calculo de: 4 puntos por cada 100 transacciones
		set	@aux100 =	(select count(cli.CLI_DNI)
						from clientes cli
						inner join cuentas cue
						on cli.CLI_ID = cue.CLI_ID
						inner join transacciones t
						on cue.CUE_NRO = t.TRA_CUE_ORIGEN
						inner join sucursales_banco s
						on cli.SUC_ID = s.SUC_ID
						where cli.CLI_ESTADO = 1
						and cli.CLI_DNI = @dni
						and s.BANC_CUIT = @cuit)

		set @valor_calidad = @valor_calidad + ((@aux100 / 100) * 4)

	------------------------------------------------------
		--Calculo de: 6 puntos por cada 30 transac. cuenta destino ult año
		set	@aux30 =	(select count(cli.CLI_DNI)
						from clientes cli
						inner join cuentas cue
						on cli.CLI_ID = cue.CLI_ID
						inner join transacciones t
						on cue.CUE_NRO = t.TRA_CUE_DESTINO
						inner join sucursales_banco s
						on cli.SUC_ID = s.SUC_ID
						where cli.CLI_ESTADO = 1
						and cli.CLI_DNI = @dni
						and s.BANC_CUIT = @cuit
						and year(t.TRA_FECHA) = year(@fecha))
			
		set @valor_calidad = @valor_calidad + ((@aux30 / 30) * 6)
	------------------------------------------------------
		--Calculo de: 5 puntos x 100 op con tarj ultimo año
		set	@auxTarj =	(select count(cli.CLI_DNI)
						from clientes cli
						inner join sucursales_banco s
						on cli.SUC_ID = s.SUC_ID
						inner join tarjetas t
						on cli.CLI_ID = t.CLI_ID
						inner join tarjetas_deu t_deu
						on t.TAR_ID = t_deu.TAR_ID
						where cli.CLI_ESTADO = 1
						and cli.CLI_DNI = @dni
						and s.BANC_CUIT = @cuit
						and year(t_deu.TAR_DEU_FECHA) = year(@fecha))

		set	@auxTarj =	@auxTarj +	(select count(cli.CLI_DNI)
						from clientes cli
						inner join sucursales_banco s
						on cli.SUC_ID = s.SUC_ID
						inner join tarjetas t
						on cli.CLI_ID = t.CLI_ID
						inner join tarjetas_pag t_pag
						on t.TAR_ID = t_pag.TAR_ID
						where cli.CLI_ESTADO = 1
						and cli.CLI_DNI = @dni
						and s.BANC_CUIT = @cuit
						and year(t_pag.TAR_PAG_FECHA) = year(@fecha))

		set @valor_calidad = @valor_calidad + ((@auxTarj / 100) * 5)
		set @auxTarj = 0
	------------------------------------------------------
		--Calculo de: 3 puntos x 100 op con tarj resto de los años
		set	@auxTarj =	(select count(cli.CLI_DNI)
						from clientes cli
						inner join sucursales_banco s
						on cli.SUC_ID = s.SUC_ID
						inner join tarjetas t
						on cli.CLI_ID = t.CLI_ID
						inner join tarjetas_deu t_deu
						on t.TAR_ID = t_deu.TAR_ID
						where cli.CLI_ESTADO = 1
						and cli.CLI_DNI = @dni
						and s.BANC_CUIT = @cuit
						and year(t_deu.TAR_DEU_FECHA) < year(@fecha))

		set	@auxTarj =	@auxTarj +	(select count(cli.CLI_DNI)
						from clientes cli
						inner join sucursales_banco s
						on cli.SUC_ID = s.SUC_ID
						inner join tarjetas t
						on cli.CLI_ID = t.CLI_ID
						inner join tarjetas_pag t_pag
						on t.TAR_ID = t_pag.TAR_ID
						where cli.CLI_ESTADO = 1
						and cli.CLI_DNI = @dni
						and s.BANC_CUIT = @cuit
						and year(t_pag.TAR_PAG_FECHA) < year(@fecha))

		set @valor_calidad = @valor_calidad + ((@auxTarj / 100) * 3)
		set @auxTarj = 0

	------------------------------------------------------
		--Calculo de: 2 puntos x cada 2000 pesos total cheques
		set	@auxTarj =	(select sum(che.CHE_MONTO * m.MONEDA_COTIZA)
						from clientes cli
						inner join cuentas cue
						on cli.CLI_ID = cue.CLI_ID
						inner join sucursales_banco s
						on cli.SUC_ID = s.SUC_ID
						inner join cheques che
						on che.CHE_CUE_ORIGEN = cue.CUE_NRO
						inner join monedas m
						on m.MONEDA_COD = cue.CUE_MONEDA_COD
						where cli.CLI_ESTADO = 1
						and cli.CLI_DNI = @dni
						and s.BANC_CUIT = @cuit)

		set @valor_calidad = @valor_calidad + ((@auxTarj / 2000) * 2)
		set @auxTarj = 0

	------------------------------------------------------
		--Calculo de: 9 puntos si monto deudas tarj (ult 3 años) > monto transac (ult 3 años)
		set @auxTarj =	(select sum(t_deu.TAR_DEU_MONTO * m.MONEDA_COTIZA)
						from clientes cli
						inner join sucursales_banco s
						on cli.SUC_ID = s.SUC_ID
						inner join tarjetas t
						on cli.CLI_ID = t.CLI_ID
						inner join tarjetas_deu t_deu
						on t.TAR_ID = t_deu.TAR_ID
						inner join monedas m
						on m.MONEDA_COD = t_deu.TAR_DEU_MONEDA_COD
						where cli.CLI_ESTADO = 1
						and cli.CLI_DNI = @dni
						and s.BANC_CUIT = @cuit
						and year(t_deu.TAR_DEU_FECHA) BETWEEN (year(@fecha)-3) AND year(@fecha))

		set @auxTransac =	(select sum(t.TRA_MONTO * m.MONEDA_COTIZA)
							from clientes cli
							inner join cuentas cue
							on cli.CLI_ID = cue.CLI_ID
							inner join transacciones t
							on cue.CUE_NRO = t.TRA_CUE_ORIGEN
							inner join sucursales_banco s
							on cli.SUC_ID = s.SUC_ID
							inner join monedas m
							on m.MONEDA_COD = cue.CUE_MONEDA_COD
							where cli.CLI_ESTADO = 1
							and cli.CLI_DNI = @dni
							and s.BANC_CUIT = @cuit
							and year(t.TRA_FECHA) BETWEEN (year(@fecha)-3) AND year(@fecha))
		
		if (@auxTarj > @auxTransac)
		begin
			set @valor_calidad = @valor_calidad + 9
		end
		
		set @auxTarj = 0
		set @auxTransac = 0
	------------------------------------------------------
		--Calculo de: 4 puntos si promedio deudas tarj (ult 5 años) > 1000 pesos
		set @auxTarj = 	(select avg(t_deu.TAR_DEU_MONTO * m.MONEDA_COTIZA)
						from clientes cli
						inner join sucursales_banco s
						on cli.SUC_ID = s.SUC_ID
						inner join tarjetas t
						on cli.CLI_ID = t.CLI_ID
						inner join tarjetas_deu t_deu
						on t.TAR_ID = t_deu.TAR_ID
						inner join monedas m
						on m.MONEDA_COD = t_deu.TAR_DEU_MONEDA_COD
						where cli.CLI_ESTADO = 1
						and cli.CLI_DNI = @dni
						and s.BANC_CUIT = @cuit
						and year(t_deu.TAR_DEU_FECHA) BETWEEN (year(@fecha)-5) AND year(@fecha))
		
		if (@auxTarj > 1000)
		begin
			set @valor_calidad = @valor_calidad + 4
		end
		
		set @auxTarj = 0
		
		



	------------------------------------------------------


		if (@valor_calidad >= 100) 
		begin	
			set @valor_calidad = 100
		end

		insert into proceso_calidad_clientes (CLI_DNI, BANC_CUIT, PCC_FECHA, PCC_ID, PCC_VALOR) 
		values(
		@dni,
		@cuit,
		@fecha,
		@PCC_ID,
		@valor_calidad)

		set @valor_calidad = 0
		set @aux100 = 0
		set @aux30 = 0
		set @auxTarj = 0
		set @auxTransac = 0
		-- Avanzamos otro registro CURSOR_1
		fetch next from CURSOR_1
		into @dni, @cuit	
	end --end CURSOR_1

	-- cerramos el cursor_1
	close CURSOR_1
	deallocate CURSOR_1
	
END;

go