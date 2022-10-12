CREATE TABLE Aquicultura(
	Id_Aquicultura BIGINT NOT NULL,
	Ano INT NOT NULL,
	Id_Municipio INT NOT NULL,
	Id_Tipo_Aquicultura BIGINT NOT NULL,
	Producao NVARCHAR(50) NULL,
	Valor_Producao DECIMAL(18,2) NULL,
	Proporcao_Valor_Producao NVARCHAR(50) NULL,
	Moeda NVARCHAR(15) NOT NULL,
 CONSTRAINT PK_Aquicultura PRIMARY KEY (Id_Aquicultura),
 CONSTRAINT FK_Aquicultura_Tipo_Aquicultura FOREIGN KEY (Id_Tipo_Aquicultura) REFERENCES Tipo_Aquicultura(Id_Tipo_Aquicultura)
)

INSERT INTO Aquicultura(
Id_Aquicultura,
Ano,
Id_Municipio,
Id_Tipo_Aquicultura,
Producao,
Valor_Producao,
Proporcao_Valor_Producao,
Moeda
)

SELECT   
Id_Aquicultura,
Ano,
Id_Municipio,
Id_Tipo_Aquicultura,
Producao,
Valor_Producao,
Proporcao_Valor_Producao,
Moeda

FROM RAW_Aquicultura_Brasil_Municipios
GO
