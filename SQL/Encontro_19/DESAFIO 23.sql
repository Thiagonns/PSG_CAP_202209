--DECLARE @SexoEscolhido CHAR(1)
--SET @SexoEscolhido = 'f'

--SELECT Nome, Sobrenome FROM Funcionario 
--WHERE Sexo = @SexoEscolhido;
--GO

CREATE PROCEDURE SP_Desafio_23
@SexoEscolhido CHAR(1)
AS
BEGIN
	SELECT Nome, Sobrenome FROM Funcionario 
	WHERE Sexo = @SexoEscolhido;
END
GO

EXEC dbo.SP_Desafio_23 'f'
GO
