create procedure SP_Dispositivos
@OP int,
@dis_Id int null,
@dis_CltID int null,
@dis_Marca varchar (50) null,
@dis_Modelo varchar(50) null,
@dis_Problema varchar(200) null,
@dis_IMEI varchar(15) null,
@dis_Estado char(1) null

AS
	Begin
		if @OP = 1
			Begin
				If NOT EXISTS(Select * From Dispositivo Where Ds_Id = @dis_Id)
					Begin
						Insert Into Dispositivo(Ds_Id,Clt_Id,Ds_Marca,Ds_Modelo,Ds_Problema,Ds_IMEI,Ds_Estado)
						Values(@dis_Id,@dis_CltID,@dis_Marca,@dis_Modelo,@dis_Problema,@dis_IMEI,@dis_Estado)
					End
				Else
					Begin
						Update Dispositivo set Clt_Id = @dis_CltID, Ds_Marca = @dis_Marca, Ds_Modelo = @dis_Modelo, Ds_Problema = @dis_Problema, Ds_IMEI = @dis_IMEI, Ds_Estado = @dis_Estado
						where Ds_Id = @dis_Id
					End
			End
		if @OP = 2
			Begin
				Delete from Dispositivo
				where Ds_Id = @dis_Id
			End
		if @OP = 3
			Begin
				Select * from Dispositivo where Clt_Id = @dis_CltID
			End
	End
