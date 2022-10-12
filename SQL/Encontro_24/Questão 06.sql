--DECLARE @Municipio INT
--DECLARE @Ano INT
--SET @Municipio = 1100015
--SET @Ano = 2018

--SELECT * FROM VW_Aquicultura 
--WHERE Id_Municipio = @Municipio AND Ano = @Ano
--GO

CREATE PROCEDURE SP_Questao_06
@Municipio INT,
@Ano INT

AS
BEGIN
	SELECT * FROM VW_Aquicultura 
	WHERE Id_Municipio = @Municipio AND Ano = @Ano
END
GO
