Create Procedure SP_Clientes
@OP tinyint,
@clt_Id int = 0,
@clt_Nombre varchar(50)=null,
@clt_AP_Paterno varchar(20)=null,
@clt_AP_Materno varchar(20) = null,
@clt_Telefono varchar (10) = null,
@clt_estatus char(1)=null

/*@clt_Id = 1,
@clt_Nombre = 'Ricardo',
@clt_AP_Paterno = 'Mascareño',
@clt_AP_Materno = 'Reza',
@clt_Telefono = '6871732226'*/

AS  
BEGIN
    if @OP = 1
    BEGIN
        IF NOT EXISTS(SELECT * FROM Clientes WHERE Clt_Id = @clt_Id)
        BEGIN
            INSERT INTO Clientes(Clt_Id, Clt_Nombre, Clt_AP_Paterno, Clt_Ap_Materno, Clt_Telefono, Clt_Estatus)
            VALUES(@clt_Id, @clt_Nombre, @clt_AP_Paterno,@clt_AP_Materno, @clt_Telefono,@clt_estatus)
        END
        ELSE
        BEGIN   
            UPDATE Clientes set Clt_Nombre = @clt_Nombre,  Clt_Ap_Paterno= @clt_Ap_Paterno,
			Clt_Ap_Materno = @clt_AP_Materno, Clt_Telefono = @clt_Telefono,Clt_Estatus = @clt_estatus
            WHERE Clt_Id = @clt_Id
        END
    END
    if @OP = 2
    BEGIN
        SELECT Clt_Nombre as Nombre, Clt_AP_Paterno as Ap_Paterno, Clt_AP_Materno as Ap_Materno, Clt_Telefono as Telefono
        from Clientes
        where Clt_Id = @clt_Id
    END
    if @OP = 3
    BEGIN
        UPDATE Clientes set Clt_Nombre = @clt_Nombre,  Clt_Ap_Paterno= @clt_Ap_Paterno, Clt_Ap_Materno = @clt_AP_Materno, Clt_Telefono = @clt_Telefono
        WHERE Clt_Id = @clt_Id
    END
	if @OP = 4
	begin
		Delete from Clientes
		where Clt_Id = @clt_Id
	end
END
