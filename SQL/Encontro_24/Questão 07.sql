--DECLARE @Cultura VARCHAR(23)
--DECLARE @Municipio INT
--DECLARE @Ano INT
--SET @Cultura = 'Dourado'
--SET @Municipio = 1100015
--SET @Ano = 2018

--SELECT * FROM VW_Aquicultura 
--WHERE Descricao_Tipo_Aquicultura = @Cultura AND Id_Municipio = @Municipio AND Ano = @Ano
--GO

CREATE PROCEDURE SP_Questao_07
@Cultura VARCHAR(23),
@Municipio INT,
@Ano INT

AS
BEGIN
	SELECT * FROM VW_Aquicultura 
	WHERE Descricao_Tipo_Aquicultura = @Cultura AND Id_Municipio = @Municipio AND Ano = @Ano
END
GO
