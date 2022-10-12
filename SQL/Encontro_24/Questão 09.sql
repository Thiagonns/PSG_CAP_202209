--DECLARE @Cultura VARCHAR(23)
--DECLARE @Municipio INT
--DECLARE @Ano INT
--SET @Cultura = 'Carpa'
--SET @Municipio = 1100015
--SET @Ano = 2013

--SELECT * FROM VW_Aquicultura 
--WHERE Descricao_Tipo_Aquicultura = @Cultura AND Id_Municipio = @Municipio AND Ano = @Ano AND Producao IS NOT NULL
--GO

CREATE PROCEDURE SP_Questao_09
@Cultura VARCHAR(23),
@Municipio INT,
@Ano INT

AS
BEGIN
	SELECT * FROM VW_Aquicultura 
	WHERE Descricao_Tipo_Aquicultura = @Cultura AND Id_Municipio = @Municipio AND Ano = @Ano AND Producao IS NOT NULL
END
GO
