CREATE TABLE Estado(
	CodigoUF INT NOT NULL PRIMARY KEY,
	SiglaUF CHAR(2) NOT NULL,
	DescricaoUF varchar(255) null

)

INSERT INTO Estado (CodigoUF, SiglaUF)
	SELECT CodigoUF, DescricaoUF
	FROM RAW_Municipio_Previa_01
	GROUP BY CodigoUF, DescricaoUF
	ORDER BY CodigoUF
GO
