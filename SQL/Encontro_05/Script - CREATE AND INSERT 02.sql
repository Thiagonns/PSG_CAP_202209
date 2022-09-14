CREATE TABLE Municipio(
CodigoMunicipio INT NOT NULL,
NomeMunicipio VARCHAR(MAX) NOT NULL,
CodigoIBGE6 INT NOT NULL,
CodigoIBGE7 INT NOT NULL,
CEP INT NOT NULL,
CodigoUF INT NOT NULL,
SiglaUF CHAR(2) NOT NULL,
Regiao VARCHAR(MAX) NOT NULL,
Populacao INT NOT NULL,
Porte VARCHAR(MAX) NOT NULL,
DataInclusao DATETIME  NULL DEFAULT GETDATE(),
CONSTRAINT PK_Municipio PRIMARY KEY (CodigoMunicipio),
CONSTRAINT FK_Municipio_Estado FOREIGN KEY (CodigoUF) REFERENCES Estado(CodigoUF)
)
GO

INSERT INTO Municipio(
CodigoMunicipio,
NomeMunicipio,
CodigoIBGE6,
CodigoIBGE7,
CEP,
CodigoUF,
SiglaUF,
Regiao,
Populacao,
Porte
)

SELECT 
A.MunicipioID, 
A.Nome, 
B.IBGE, 
B.IBGE7, 
C.CEP, 
A.UFID, 
C.UF, 
B.Região, 
B.População_2010, 
B.Porte
FROM RAW_Municipios_Complementar_IBGE_UTF8 AS A 
INNER JOIN
[RAW_Lista_de_MunicIpios_com_IBGE_Brasil_UTF8] AS B ON A.CodigoIBGE = B.IBGE7 
INNER JOIN
RAW_Cidades_IBGE6_UTF8 AS C ON B.IBGE = C.IBGE
