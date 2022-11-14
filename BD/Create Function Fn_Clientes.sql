Create Function Fn_Clientes
(
    @state int
)
RETURNS INT
AS
BEGIN
    DECLARE @Resultado INT
    SET @Resultado = (Select COUNT(*) as Concordantes FROM Clientes where Clt_Estatus=@state)
    RETURN @Resultado
END
go
