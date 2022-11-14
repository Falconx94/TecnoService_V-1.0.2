Create Procedure SP_Usuario
@OP tinyint,
@us_Id int = 0,
@us_Nombre varchar(50),
@us_Pass varchar(20),
@us_AP_Paterno varchar(20),
@us_AP_Materno varchar(20) = null,
@us_Telefono varchar (10) = null,
@us_Nivel tinyint=null

AS
BEGIN
    if @OP = 1
    BEGIN
        IF NOT EXISTS(SELECT * FROM Usuario WHERE Us_Id = @us_Id)
        BEGIN
            INSERT INTO Usuario (Us_Id, Us_Nombre,Us_pass, Us_AP_Paterno, Us_Ap_Materno, Us_Telefono, Us_Nivel)
            VALUES(@us_Id, @us_Nombre, @us_Pass, @us_AP_Paterno, @us_AP_Materno, @us_Telefono, @us_nivel)
        END
        ELSE
        BEGIN   
            UPDATE Usuario set Us_Nombre = @us_Nombre, Us_pass= @us_Pass, Us_Ap_Paterno=@us_AP_Paterno, Us_Ap_Materno=@us_AP_Materno, Us_Telefono = @us_Telefono, Us_Nivel = @us_nivel
            WHERE Us_Id = @us_Id
        END
    END
    if @OP = 2
    BEGIN
        SELECT Us_Nombre as Nombre, Us_AP_Paterno as Ap_Paterno, Us_AP_Materno as Ap_Materno, Us_Telefono as Telefono
        from Usuario
        where Us_Id = @us_Id
    END
    if @OP = 3
    BEGIN
        UPDATE Usuario set Us_Nombre = @us_Nombre, Us_pass= @us_Pass, Us_Ap_Paterno=@us_AP_Paterno, Us_Ap_Materno = @us_AP_Materno, Us_Telefono = @us_Telefono, Us_Nivel = @us_nivel
            WHERE Us_Id = @us_Id
    END
    if @OP = 4
    BEGIN
        SELECT Us_Id as Identificador, Us_Nombre as Nombre, Us_Ap_Paterno as Ap_Paterno, Us_Nivel as Nivel
        FROM Usuario
    END
END

select * from usuario

--declare @us_Id = 0,
--declare @us_Nombre varchar(50),
--declare @us_Pass varchar(20),
--declare @us_AP_Paterno varchar(20),
--declare @us_AP_Materno varchar(20) = null,
--declare @us_Telefono varchar (10) = null,
--declare @us_Nivel tinyint(1)

--@us_Id=1
--select Us_Nombre = @us_Nombre, Us_pass= @us_Pass  Us_Ap_Paterno=@us_AP_Paterno, Us_Ap_Materno=@us_AP_Materno, Us_Telefono = @us_Telefono, Us_Nivel = @us_nivel
--from Usuario
--WHERE Us_Id = @us_Id

exec SP_Usuario @OP = 2;