CREATE VIEW VW_Municipios_IBGE
AS
SELECT 
	Municipio.CodigoMunicipio, 
	Municipio.NomeMunicipio, 
	Municipio.CodigoIBGE6, 
	Municipio.CodigoIBGE7, 
	Municipio.CEP, 
	Municipio.SiglaUF, 
	Estado.DescricaoUF
FROM Estado INNER JOIN Municipio ON Estado.CodigoUF = Municipio.CodigoUF
GO
