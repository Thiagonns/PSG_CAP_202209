CREATE PROCEDURE SP_Pesquisar_Municipios_Por_CodigoIBGE
@CodigoIBGE7 INT
AS
BEGIN
	SELECT        CodigoMunicipio, NomeMunicipio, CodigoIBGE6, CodigoIBGE7, CEP, SiglaUF, DescricaoUF
	FROM            VW_Municipios_IBGE 
	WHERE (CodigoIBGE7 = @CodigoIBGE7)
END
GO
