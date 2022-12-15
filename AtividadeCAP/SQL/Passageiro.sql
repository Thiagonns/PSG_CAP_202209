CREATE TABLE Passageiro(
    CodigoPassageiro BIGINT NOT NULL IDENTITY(1,1),
    Nome VARCHAR(50) NOT NULL,
	Documento VARCHAR(20) NOT NULL,
	NumeroCartao VARCHAR(20) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	Telefone VARCHAR(20) NOT NULL,
	DataNascimento DATE NOT NULL,
    CONSTRAINT PK_Passageiro PRIMARY KEY (CodigoPassageiro)
)
GO

--INSERT INTO Passageiro(Nome, Documento, NumeroCartao, Email, Telefone, DataNascimento) VALUES 
--('Thiago','2114340','123456','thiago@gmail.com', '1111-1111','1997-09-19'),
--('Bruno','1556423','654321','bruno@gmail.com', '2222-2222','2000-05-10'),
--('Akira','8665479','456789','akira@gmail.com', '3333-3333','1998-03-05'),
--('Marlon','9887465','987654','marlon@gmail.com', '4444-4444','2000-02-08'),
--('Rafael','9886743','123789','rafael@gmail.com', '5555-5555','1997-08-12')
--GO

