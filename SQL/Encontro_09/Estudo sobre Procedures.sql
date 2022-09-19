DECLARE @SIGLA CHAR(2)
SET @SIGLA = 'MS'
SELECT CodigoMunicipio, NomeMunicipio, CodigoIBGE6, CodigoIBGE7, CEP, SiglaUF, DescricaoUF
FROM VW_Municipios_IBGE
WHERE (SiglaUF = @SIGLA)
GO
