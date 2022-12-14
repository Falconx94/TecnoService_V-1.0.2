Create procedure [dbo].[SP_Compras]
@OP tinyint,
@Comp_Id int = 0,
@Prov_Id int = 0,
@Com_Total varchar (10) = null,
@Comp_Fecha datetime

AS
begin
    if @OP = 1
		begin
			if not exists (select * from Compras where Com_Id = @Comp_Id)
			begin
				insert into Compras(Com_Id,Prv_Id ,Com_Total,Com_Fecha)
				values(@Comp_Id,@Prov_Id,@Com_Total,@Comp_Fecha)
			end
		end
	else
		begin
			update Compras set  Prv_Id=@Prov_Id,Com_Total = @Com_Total, Com_Fecha = @Comp_Fecha
			where Com_Id = @Comp_Id
		end
	if @OP=2
	begin
		Delete from Compras
		where Com_Id = @Comp_Id
	end
end

select * from Dispositivo