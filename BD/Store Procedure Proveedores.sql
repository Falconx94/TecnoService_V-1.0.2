Create procedure SP_Proveedores
@OP tinyint,
@Prov_Id int = 0,
@Prov_RasSoci varchar (50)=null,
@Prov_NomContac varchar (50)=null,
@Prov_Telefono varchar(10)=null ,
@Prov_Direccion varchar(50)=null,
@Prov_estatus char (1)=null

AS
begin
    if @OP = 1
		begin
			if not exists (select * from Proveedores where Prv_Id = @Prov_Id)
			begin
				insert into Proveedores(Prv_Id, Prv_Razonsocial, Prv_Nombre_Contacto, Prv_Telefono, Prv_Direccion, Prv_Estatus)
				values(@Prov_Id,@Prov_RasSoci,@Prov_NomContac,@Prov_Telefono,@Prov_Direccion,@Prov_estatus)
			end
		end
	else
		begin
			update Proveedores set  Prv_Razonsocial=@Prov_RasSoci, Prv_Nombre_Contacto = @Prov_NomContac, Prv_Telefono = @Prov_Telefono, Prv_Direccion = @Prov_Direccion, Prv_Estatus=@Prov_estatus
			where Prv_Id = @Prov_Id
		end
	if @OP=2
	begin
		select  Prv_Razonsocial as 'Razon Social', Prv_Nombre_Contacto as 'Nombre Del Contacto', Prv_Telefono as Telefono,  Prv_Direccion as Direccion, Prv_Estatus as Estado
		from Proveedores
		where Prv_Id = @Prov_Id
	end
	if @OP=3
	begin
		update Proveedores set  Prv_Razonsocial=@Prov_RasSoci, Prv_Nombre_Contacto = @Prov_NomContac, Prv_Telefono = @Prov_Telefono, Prv_Direccion = @Prov_Direccion
		where Prv_Id = @Prov_Id
	end
	if @OP = 4
	begin
		Delete from Proveedores
		where Prv_Id = @Prov_Id
	end
end

--select * from proveedores

--alter table Proveedores
--add Prv_Estatus char(1)