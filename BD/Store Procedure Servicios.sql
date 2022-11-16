Create Procedure SP_Servicios
@OP tinyint,
@srv_Id int = 0,
@srv_cltID int = 0,
@srv_tipo tinyint, -- 1=Reparación de equipo 2=Venta de producto
@srv_precio float = null,
@srv_descrip varchar(200) = null,
@srv_Fecha DateTime = null,
@srv_estatus char(1) = null


AS
	BEGIN
		IF @OP = 1
		begin
			if Not Exists(select * from Servicio Where Clt_Id = @srv_cltID)
			begin
				insert into Servicio(Sv_Id,Clt_Id,Sv_Tipo,Sv_Precio,Sv_Descripcion,Sv_Fecha,Sv_Estado)
				values (@srv_Id,@srv_cltID,@srv_tipo,@srv_precio,@srv_descrip,@srv_Fecha,@srv_estatus)
			end
			ELSE
			BEGIN   
				UPDATE Servicio set Sv_Id = @srv_Id,Clt_Id = @srv_cltID, Sv_Tipo = @srv_tipo,
				Sv_Precio = @srv_precio, Sv_Descripcion = @srv_descrip, Sv_Fecha = @srv_Fecha,
				Sv_Estado = @srv_estatus
				WHERE Clt_Id = @srv_cltID
			END
		end				
	END					
						
select * from Servicio	
Select * from Clientes	

insert into Servicio(Sv_Id,Clt_Id,Sv_Tipo,Sv_Precio,Sv_Descripcion,Sv_Fecha,Sv_Estado)
values (2,1,2,249.99,'Venta de Protector de Teléfono Rigido','08-11-2022','R')
