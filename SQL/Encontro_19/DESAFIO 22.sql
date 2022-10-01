--DECLARE @AnoNascimento int
--SET @AnoNascimento = 1960

--SELECT Nome, Sobrenome, DataNascimento FROM Funcionario 
--WHERE YEAR(DataNascimento)= @AnoNascimento;
--GO

CREATE PROCEDURE SP_Desafio_22
@AnoNascimento int
AS
BEGIN
	SELECT Nome, Sobrenome, DataNascimento FROM Funcionario 
	WHERE YEAR(DataNascimento)= @AnoNascimento;
END
GO

EXEC dbo.SP_Desafio_22 1960
GO
