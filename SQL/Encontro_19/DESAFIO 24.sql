--	DECLARE @NovaLista TABLE(
--	NovaListaId BIGINT NOT NULL IDENTITY(1,1) PRIMARY KEY,
--	FuncionarioId BIGINT NOT NULL,
--	Matricula BIGINT NOT NULL,
--	Nome VARCHAR(50) NOT NULL,
--	Sobrenome VARCHAR(50) NOT NULL,
--	Sexo CHAR(1) NOT NULL,
--	DataNascimento DATETIME NOT NULL,
--	Email VARCHAR(50) NOT NULL,
--	Ctps VARCHAR(20) NOT NULL,
--	CtpsNum BIGINT NOT NULL,
--	CtpsSerie INT NOT NULL,
--	DataAdmissao DATETIME NULL
--)

--INSERT INTO @NovaLista 
--	SELECT * FROM Funcionario 
	
--	DECLARE @ListaSorteados TABLE(
--	ListaSorteadosId BIGINT NOT NULL PRIMARY KEY,
--	FuncionarioId BIGINT NOT NULL,
--	Matricula BIGINT NOT NULL,
--	Nome VARCHAR(50) NOT NULL,
--	Sobrenome VARCHAR(50) NOT NULL,
--	Sexo CHAR(1) NOT NULL,
--	DataNascimento DATETIME NOT NULL,
--	Email VARCHAR(50) NOT NULL,
--	Ctps VARCHAR(20) NOT NULL,
--	CtpsNum BIGINT NOT NULL,
--	CtpsSerie INT NOT NULL,
--	DataAdmissao DATETIME NULL
--)
--DECLARE @QtdDesejada INT
--SET @QtdDesejada = 40
--DECLARE @Contador BIGINT
--SET @Contador = 0

--WHILE (@Contador < @QtdDesejada)
--	BEGIN
--	DECLARE @Registros INT 
--		SELECT @Registros = COUNT(*) FROM @NovaLista

--	DECLARE @Chave INT 
--	SET @Chave = FLOOR(RAND() * (@Registros + 1))

--	WHILE(@Chave = 0)
--	BEGIN
--		SET @Chave = FLOOR(RAND() * (@Registros + 1))
--	END

--	IF ((SELECT COUNT(*) FROM @ListaSorteados) = 0)
--		BEGIN
--			INSERT INTO @ListaSorteados
--				SELECT * FROM @NovaLista WHERE NovaListaId = @Chave
--			SET @Contador = @Contador + 1
--		END
--		ELSE
--		BEGIN
--			IF ((SELECT COUNT(*) FROM @ListaSorteados WHERE ListaSorteadosId = @Chave) = 0)
--			BEGIN
--				INSERT INTO @ListaSorteados
--					SELECT * FROM @NovaLista WHERE NovaListaId = @Chave
--				SET @Contador = @Contador + 1
--			END
--		END
--	END
--SELECT * FROM @ListaSorteados
--GO

CREATE PROCEDURE SP_Desafio_24
@QtdDesejada BIGINT
AS
BEGIN
	DECLARE @NovaLista TABLE(
	NovaListaId BIGINT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FuncionarioId BIGINT NOT NULL,
	Matricula BIGINT NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	Sobrenome VARCHAR(50) NOT NULL,
	Sexo CHAR(1) NOT NULL,
	DataNascimento DATETIME NOT NULL,
	Email VARCHAR(50) NOT NULL,
	Ctps VARCHAR(20) NOT NULL,
	CtpsNum BIGINT NOT NULL,
	CtpsSerie INT NOT NULL,
	DataAdmissao DATETIME NULL
	)

	INSERT INTO @NovaLista 
		SELECT * FROM Funcionario 

	DECLARE @ListaSorteados TABLE(
		ListaSorteadaId BIGINT NOT NULL PRIMARY KEY,
		FuncionarioId BIGINT NOT NULL,
		Matricula BIGINT NOT NULL,
		Nome VARCHAR(50) NOT NULL,
		Sobrenome VARCHAR(50) NOT NULL,
		Sexo CHAR(1) NOT NULL,
		DataNascimento DATETIME NOT NULL,
		Email VARCHAR(50) NOT NULL,
		Ctps VARCHAR(20) NOT NULL,
		CtpsNum BIGINT NOT NULL,
		CtpsSerie INT NOT NULL,
		DataAdmissao DATETIME NULL
	)

	DECLARE @Contador BIGINT
	SET @Contador = 0

	WHILE(@Contador < @QtdDesejada)
	BEGIN
		DECLARE @Registros BIGINT
		SELECT @Registros = COUNT(*) FROM @NovaLista

		DECLARE @Chave BIGINT
		SET @Chave = FLOOR(RAND() * (@Registros + 1))

		WHILE(@Chave = 0)
		BEGIN
			SET @Chave = FLOOR(RAND() * (@Registros + 1))
		END

		IF((SELECT COUNT(*) FROM @ListaSorteados) = 0)
		BEGIN
			INSERT INTO @ListaSorteados 
				SELECT * FROM @NovaLista WHERE NovaListaId = @Chave
			SET @Contador = @Contador + 1
		END
		ELSE
		BEGIN
			IF ((SELECT COUNT(*) FROM @ListaSorteados WHERE ListaSorteadaId = @Chave) = 0)
			BEGIN
				INSERT INTO @ListaSorteados
					SELECT * FROM @NovaLista WHERE NovaListaId = @Chave
				SET @Contador = @Contador + 1
			END
		END
	END

	SELECT * FROM @ListaSorteados
END
GO

EXEC SP_Desafio_24 40
GO
