CREATE VIEW VW_Aquicultura
AS 
SELECT 
	Id_Aquicultura,
	Ano,
	Id_Municipio,
	Descricao_Tipo_Aquicultura,
	Producao,
	Valor_Producao,
	Proporcao_Valor_Producao,
	Moeda
FROM Aquicultura INNER JOIN Tipo_Aquicultura ON Aquicultura.Id_Tipo_Aquicultura = Tipo_Aquicultura.Id_Tipo_Aquicultura
GO
