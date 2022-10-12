CREATE TABLE Tipo_Aquicultura(
Id_Tipo_Aquicultura BIGINT NOT NULL,
Descricao_Tipo_Aquicultura VARCHAR(100) NOT NULL
CONSTRAINT PK_Tipo_Aquicultura PRIMARY KEY (Id_Tipo_Aquicultura)
)
INSERT INTO Tipo_Aquicultura(
Id_Tipo_Aquicultura,
Descricao_Tipo_Aquicultura
)
SELECT DISTINCT
Id_Tipo_Aquicultura, 
Descricao_Tipo_Aquicultura
	FROM Raw_Aquicultura_Brasil_Municipios 
GO

--SELECT * FROM Tipo_Aquicultura
