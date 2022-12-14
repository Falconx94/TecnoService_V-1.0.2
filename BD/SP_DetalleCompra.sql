USE [TecnoService]
GO
/****** Object:  StoredProcedure [dbo].[SP_Detalle_Compra]    Script Date: 02/12/2022 09:14:51 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[SP_Detalle_Compra]
@OP tinyint,
@DeCom_Id int = 0 ,
@Produc_Id int = 0,
@Comp_ID int= 0,
@Prov_Id int = 0,
@DeCom_Obsersacion varchar(100),
@DeCom_Unidad int =0,
@DeCom_Precio float ,
@DeCom_Cantidad float,
@DeCom_Importe float,
@DeCom_Estatus char(1)
AS
BEGIN
     --METODO GUARDAR--
	 IF @OP = 1
	    BEGIN
		    IF NOT EXISTS (SELECT * FROM Detalles_Compra WHERE DetCom_Id =@DeCom_Id)
			BEGIN
			    INSERT INTO Detalles_Compra(DetCom_Id,Com_Id,Prod_Id,Prv_Id,DetCom_Observacion,DetCom_Unidad,DetCom_Precio,DetCom_Cantidad,Det_importe,DetCom_Estatus)
				VALUES(@DeCom_Id,@Produc_Id,@Comp_ID,@Prov_Id,@DeCom_Obsersacion,@DeCom_Unidad,@DeCom_PreciO,@DeCom_Cantidad,@DeCom_Importe,@DeCom_Estatus)
			END								
		END
	ELSE
	    BEGIN
		     UPDATE Detalles_Compra SET Com_Id=@Comp_ID,Prod_Id=@Produc_Id,Prv_Id=@Prov_Id,DetCom_Observacion=@DeCom_Obsersacion,
			        DetCom_Unidad=@DeCom_Unidad,DetCom_Precio=@DeCom_Precio,DetCom_Cantidad=@DeCom_Cantidad,Det_importe=@DeCom_Importe,DetCom_Estatus=@DeCom_Estatus
			 WHERE  DetCom_Id=@DeCom_Id
		END
		-- METODO DE ACTUALIZAR XD
	IF @OP = 2
	   BEGIN
	         UPDATE Detalles_Compra SET Com_Id=@Comp_ID,Prod_Id=@Produc_Id,Prv_Id=@Prov_Id,DetCom_Observacion=@DeCom_Obsersacion,
			        DetCom_Unidad=@DeCom_Unidad,DetCom_Precio=@DeCom_Precio,DetCom_Cantidad=@DeCom_Cantidad,Det_importe=@DeCom_Importe
			 WHERE  DetCom_Id=@DeCom_Id
		END
			--METODO DE ELIMINAR
	IF @OP = 3 
	   BEGIN
	         DELETE FROM Detalles_Compra
			 WHERE DetCom_Id=@DeCom_Id
		END
END