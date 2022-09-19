CREATE PROCEDURE SP_Pesquisar_Municipios_Por_SiglaUF
@SIGLA CHAR(2)
AS
BEGIN
	SELECT CodigoMunicipio, NomeMunicipio, CodigoIBGE6, CodigoIBGE7, CEP, SiglaUF, DescricaoUF
	FROM VW_Municipios_IBGE
	WHERE (SiglaUF = @SIGLA)
END
GO
