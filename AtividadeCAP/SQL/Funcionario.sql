CREATE TABLE Funcionario(
    CodigoFuncionario INT NOT NULL IDENTITY(1,1),
	Matricula VARCHAR(50) NOT NULL,
    Nome VARCHAR(50) NOT NULL,
	ContaCorrente VARCHAR(50) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	Telefone VARCHAR(20) NOT NULL,
	Usuario VARCHAR(20) NOT NULL,
	Senha VARCHAR(20) NOT NULL,
	DataNascimento DATE NOT NULL
    CONSTRAINT PK_Funcionario PRIMARY KEY (CodigoFuncionario)
)
GO

--INSERT INTO Funcionario(Matricula, Nome, ContaCorrente, Email, Telefone, Usuario, Senha, DataNascimento) VALUES
--('20100150001','Georgi','49001540741','georgi@acme.com','1111-1111','@Georgi','Senha1','1953-09-02'),
--('20100150002','Bezalel','38050201548','Bezalel@acme.com','2222-2222','@Bezalel','Senha2','1964-06-02 '),
--('20100150003','Parto','45152038868','Parto@acme.com','3333-3333','@Parto','Senha3','1959-12-03'),
--('20100150004','Chirstian','93993062385','Chirstian@acme.com','4444-4444','@Chirstian','Senha4','1954-05-01'),
--('20100150005','Kyoichi','64885131268','Kyoichi@acme.com','5555-5555','@Kyoichi','Senha5','1955-01-21'),
--('20100150006','Anneke','32097781440','Anneke@acme.com','6666-6666','@Anneke','Senha6','1953-04-20'),
--('20100150007','Tzvetan','45521773009','Tzvetan@acme.com','7777-7777','@Tzvetan','Senha7','1957-05-23')
--GO
