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

-- Llena tabla Tarjetas
insert into
	mozilla.Compras
	(
		COMPRA_CODIGO,
		COMPRA_MONTO,
		COMPRA_FECHA,
		POSTNET_NRO_SERIE,
		TARJETA_NRO
	)
select
	m.COMPRA_CODIGO,
	m.COMPRA_MONTO,
	m.COMPRA_FECHA,
	m.POSTNET_NRO_SERIE,
	m.TARJETA_NRO

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
		TARJETA_NRO
	)
select
	m.CARGA_MONTO,
	m.CARGA_FECHA,
	m.TARJETA_NRO

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

CREATE UNIQUE INDEX UQ_DNIS ON mozilla.Clientes (CLIENTE_DNI); 