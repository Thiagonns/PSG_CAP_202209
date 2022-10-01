--DECLARE @Iniciais VARCHAR(4)
--SET @Iniciais = 'mar' + '%'

--SELECT * FROM Funcionario 
--WHERE Nome LIKE @Iniciais 
--GO

CREATE PROCEDURE SP_Desafio_21
@Iniciais VARCHAR(4)
AS
BEGIN
	SET @Iniciais = @Iniciais + '%'
	SELECT * FROM Funcionario 
	WHERE Nome LIKE @Iniciais
END
GO

EXEC dbo.SP_Desafio_21 'mar'
GO
