--DECLARE @Iniciais CHAR(3) 
--SET @Iniciais = 'san'

--SELECT * FROM Funcionario
--WHERE Sobrenome LIKE '%' + @Iniciais + '%'
--ORDER BY Nome, Sobrenome
--GO

CREATE PROCEDURE SP_Desafio_25
@Iniciais CHAR(3)
AS
BEGIN
	SELECT * FROM Funcionario
	WHERE Sobrenome LIKE '%' + @Iniciais + '%'
	ORDER BY Nome, Sobrenome
END
GO

EXEC SP_Desafio_25 'san'
GO
