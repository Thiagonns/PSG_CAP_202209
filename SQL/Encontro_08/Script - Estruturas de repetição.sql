-- declarar variável 
DECLARE @Valor INT;

-- Atribuir valor 
SET @Valor = 10

-- IF / ELSE

IF (@Valor <= 10)
BEGIN 
	PRINT ('EXEMPLO')
END
ELSE 
BEGIN 
	ELSE('MAL EXEMPLO')
END
GO

-- WHILE DO

while (@valor <> 20)
begin
set @valor = @valor + 1
print ('valor: ' + convert (varchar, @valor))
END
GO

-- CASE 
 CASE
     WHEN @Valor = 1 THEN print ('valor: ' + convert (varchar, @valor))
     WHEN @Valor = 2 THEN print ('valor: ' + convert (varchar, @valor))
     ELSE print ('valor: ' + convert (varchar, @valor))
 END; 
