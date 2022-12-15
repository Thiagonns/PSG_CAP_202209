CREATE TABLE Bilhete(
    CodigoBilhete BIGINT NOT NULL IDENTITY(1,1),
	NumeroBilhete INT NOT NULL,
    Assento CHAR(3) NOT NULL	
    CONSTRAINT PK_Bilhete PRIMARY KEY (CodigoBilhete)
)
GO

--INSERT INTO Bilhete(NumeroBilhete, Assento) VALUES
--(2,'A1'),
--(4,'B2'),
--(6,'C3'),
--(8,'D4'),
--(10,'E5')
--GO