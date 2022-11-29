Create database TecnoService

use TecnoService;

Create table Clientes
(
	Clt_Id int not null,
	Clt_Nombre varchar(50) not null unique,
	Clt_Ap_Paterno varchar(120) not null unique,
	Clt_Ap_Materno varchar(120) not null unique,
	Clt_Telefono varchar(10) not null unique,
	Clt_Estatus char (1) null,
	Primary Key (Clt_Id)
);
Create table Dispositivo
(
	Ds_Id int not null Primary key,
	Clt_Id int not null,
	Ds_Marca varchar (50) not null,
	Ds_Modelo varchar(50) not null,
	Ds_Problema varchar(200) not null,
	Ds_IMEI varchar(15)not null,
	Foreign Key (Clt_Id) References Clientes(Clt_Id)
);
Create table Proveedores
(
	Prv_Id int not null Primary key,
	Prv_Razonsocial varchar (70) not null unique, -- Empresa proveedora
	Prv_Nombre_Contacto varchar (200) not null, -- Nombre Completo del contacto con la empresa proveedora
	Prv_Telefono varchar (13) not null, --Suponiendo que sea necesario los +52 o lada de otra naci�n
	Prv_Direccion varchar (100) not null, -- Direcci�n de la empresa proveedora o el proveedor
);
Create table Servicio
(
	Sv_Id int not null Primary key,
	Clt_Id int not null,
	Sv_Tipo tinyint not null, -- 1=Reparación de equipo 2=Venta de producto
	Sv_Precio float not null, -- Costo del Servicio o Producto
	Sv_Descripcion varchar (150) not null, --Descripción detallada del producto o serviciory key (Sv_Id),
	Sv_Fecha datetime not null,
	Sv_Estado char(1) null, -- P = En Proceso / R = Realizado / C = Cancelado 
	Foreign Key (Clt_Id) References Clientes(Clt_Id)
);
Create Table Detalles_Servicio
(
	DetSV_Id int not null Primary Key, --LO QUE SERIA EL FOLIO
	Sv_Id int not null,
	Ds_Id int not null,
	Foreign Key (Sv_Id) References Servicio (Sv_Id),
	Foreign Key (Ds_Id) References Dispositivo (Ds_Id)
);
Create table Compras
(
	Com_Id int not null Primary key,
	Prv_Id int not null,
	Com_Total varchar(10) not null,
	Com_Fecha datetime not null,
	Foreign key (Prv_Id) References Proveedores(Prv_ID)
);
Create table Unidad
(
	Unit_Id int not null Primary Key,
	Unit_Descripcion varchar (250) not null,
	Unit_Cantidad int
);
Create table Producto
(
	Prod_Id int not null Primary Key,
	Com_Id int not null,
	Unit_Id int not null,
	Prod_Tipo tinyint not null, -- 1=Reparaci�n de equipo 2=Venta de producto
	Prod_Precio int not null, -- Costo del Servicio o Producto
	Prod_Descripcion varchar (150) not null, --Descripci�n detallada del producto o servicio
	Prod_Estado char(1) null, -- E = Existencia / A = Agotado}
	Foreign key (Com_Id) References Compras(Com_Id),
	Foreign key (Unit_Id) References Unidad(Unit_Id)
);
Create Table Detalles_Compra
(
	DetCom_Id int not null,
	Com_Id int not null,
	Prod_Id int not null, -- Posiblemente quede para registrar por id al producto adquirido
	Prv_Id int not null, -- Id del proveedor registrado al cual se le compro el producto,
	DetCom_Observacion varchar (100) not null, --Nuevo Producto adquirido
	DetCom_Unidad int not null, --Unidades del producto adquirido
	DetCom_Precio float not null, -- Precio del producto adquirido con centavos
	DetCom_Cantidad int,
	DetCom_importe float,
	foreign key (Com_id) References Compras (Com_id),
	foreign key (Prod_id) References Producto (Prod_id),
	Foreign Key (Prv_Id) References Proveedores (Prv_Id)
);
Create table Usuario
(
	Us_Id int not null Primary Key,
	Us_Nombre varchar(50) not null unique,
	Us_pass varchar(20) not null, -- Contrase�a no menor a 7 ni mayor a 20
	Us_Ap_Paterno varchar(120) not null unique,
	Us_Ap_Materno varchar(120) not null unique,
	Us_Telefono varchar(10) not null,
	Us_Nivel tinyint not null, /* 1-Admin 2-Tecnico 3-Vendedor*/
	Us_Estado char(1) null -- A = Activo / C = Cancelado
);
/*Solo Admin puede Ingresar, Buscar o Eliminar Tecnicos, Clientes, Proveedores y Vendedores,
los Tecnicos y Vendedores no pueden hacer otros movivmientos que no sean Servicios, Ventas
o Registro y busqueda de Clientes, Proveedores o Productos*/

Create Table Ventas
(
	Vt_Id int not null Primary Key,
	Clt_Id int not null,
	Vt_total varchar(10),
	Us_Id int not null,
	Vt_Fecha datetime,
	foreign key (Clt_Id) References Clientes (Clt_Id),
	foreign key (Us_Id) References Usuario (Us_Id),
	Foreign Key (Clt_Id) references Clientes (Clt_Id)
);
Create Table Detalles_Venta
(
	Vt_Id int not null,
	Prod_Id int not null,
	Us_Id int not null, -- Para saber que Tecnico o Vendedor realizo la venta
	DetVent_Unidades int not null,
	DetVent_PrecioUnidad varchar(10) not null,
	DetVent_Fecha datetime not null, --Fecha en que se realizo la venta
	Foreign key (Prod_Id) references Producto(Prod_Id),
	Foreign key (Us_Id) references Usuario(Us_Id),
	Foreign key (Vt_Id) references Ventas (Vt_Id),
	foreign key (Us_Id) References Usuario (Us_Id)
);
Create Table CARRITO_Venta
(
	Carrito_Id int not null Primary Key,
	Prod_Id int not null,
	Us_Id int not null, -- Para saber que Tecnico o Vendedor realizo la venta
	Car_Unidades int not null,
	Car_PrecioUnidad varchar(10) not null,
	Car_Fecha datetime not null, --Fecha en que se realizo el carrito
	Vt_Id int not null,
	Foreign key (Prod_Id) references Producto(Prod_Id),
	Foreign key (Us_Id) references Usuario (Us_Id),
	Foreign key (Vt_Id) references Ventas (Vt_Id)
);
Create Table Abonos
(
	Abn_Id int not null Primary key,
	Clt_Id int not null,
	Abn_Fecha datetime,
	Abn_Nota varchar(500),
	Abn_Total float,
	Abn_Importe float,
	Abn_Estado char(1), -- A = Activo / F = Finalizado / C = Cancelado
	Foreign Key (Clt_Id) References Clientes (Clt_Id)
);

-

delete from Clientes Where Clt_Id = 4