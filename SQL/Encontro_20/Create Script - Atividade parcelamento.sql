--SELECT 
--FuncionarioId,
--Nome,
--Sobrenome,
--Sexo
--FROM Funcionario 
--WHERE Sexo = 'F' AND Sobrenome LIKE 'MID%'

CREATE TABLE Parcelamento (
ParcelaId BIGINT,
FuncionarioId BIGINT,
ParcelaNumero INT NOT NULL,
Valor DECIMAL NOT NULL
)

DECLARE @FuncId BIGINT
DECLARE CursorFunc CURSOR
	FOR SELECT FuncionarioId FROM Funcionario WHERE Sexo = 'F' AND Sobrenome LIKE 'MID%' 

OPEN CursorFunc
FETCH NEXT FROM CursorFunc INTO @FuncId

DECLARE @Valor DECIMAL
SET @Valor = 300

DECLARE @ParcIni INT 

WHILE (@@FETCH_STATUS = 0)
BEGIN
	DECLARE @NumeroParcela INT 
	SET @NumeroParcela = FLOOR(RAND() * (10 + 1))

	DECLARE @ValorParcela NUMERIC (10,2) 

	SET @ParcIni = 1

WHILE(@ParcIni < @NumeroParcela)
	BEGIN
		SET @ValorParcela = @Valor * @ParcIni

	INSERT INTO Parcelamento(FuncionarioId, ParcelaNumero, Valor)
		SELECT 
			FuncionarioId,
			@ParcIni,
			@ValorParcela
		FROM Funcionario
		WHERE (FuncionarioId = @FuncId)
		SET @ParcIni = @ParcIni + 1
	END

	FETCH NEXT FROM CursorFunc INTO @FuncId
END
CLOSE CursorFunc
DEALLOCATE CursorFunc
SELECT * FROM Parcelamento

GO

