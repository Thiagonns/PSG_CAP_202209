CREATE TABLE Categoria(
    Codigo INT NOT NULL IDENTITY(1,1),
    Descricao VARCHAR(MAX) NOT NULL,
    Datainsert DATETIME NOT NULL,
    CONSTRAINT PK_Categoria PRIMARY KEY (Codigo)
)
GO
