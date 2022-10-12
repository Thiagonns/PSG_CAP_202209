--DECLARE @Municipio INT
--DECLARE @Ano INT
--SET @Municipio = 1100015
--SET @Ano = 2013

--SELECT * FROM VW_Aquicultura 
--WHERE Id_Municipio = @Municipio AND Ano = @Ano AND Producao IS NOT NULL
--GO

CREATE PROCEDURE SP_Questao_08
@Municipio INT,
@Ano INT

AS
BEGIN
	SELECT * FROM VW_Aquicultura 
	WHERE Id_Municipio = @Municipio AND Ano = @Ano AND Producao IS NOT NULL
END
GO
