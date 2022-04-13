create database inventario
use inventario

create table [dbo].[registroArticulos](
[articulo] varchar (50) not null,
[codigo] int not null primary key,
[categoria] varchar (50) not null,
[cantidad] int not null,
[precio] int not null,
[proveedor] varchar (50) not null,
[fecha_ingreso] datetime not null
);


select * from registroArticulos

create table [dbo].[registroUsuario](
[nombres] varchar (50) not null,
[apellidos] varchar (50) not null,
[cedula] int primary key,
[usuario] varchar (50) not null,
[contrasena] varchar (50) not null,
[rol] varchar (50) not null,
[email] varchar (50) not null
);

insert into registroUsuario values('Naty', 'francisco',4023, 'natyf', 'naty02', 'administrado', 'fnaty629@gmail.com');
insert into registroUsuario values('Alexis', 'Mateo',00125, 'alexis', 'alexisM', 'administrador', 'alexism@gmail.com');
select * from registroUsuario;

create table [dbo].[registroEmpleado](
[nombres] varchar (50) not null,
[apellidos] varchar (50) not null,
[cedula] bigint primary key,
[edad] int not null,
[fecha_nacimiento] datetime not null,
[direccion] varchar (50) not null,
[email] varchar (50) not null
);
select * from registroEmpleado

create table [dbo].[registroProveedor](
[nombres] varchar (50) not null,
[apellidos] varchar (50) not null,
[cedula] bigint primary key,
[edad] int not null,
[direccion] varchar (50) not null,
[email] varchar (50) not null
);
insert into registroProveedor values('Naty', 'francisco',403, 21, 'Catalina, Bani', 'fnaty629@gmail.com');

select * from registroProveedor;


create table [dbo].[factura](
[id] int identity (1,1),
[codigo] int not null primary key,
[descripcion] varchar (50) not null,
[precio] int not null,
[cantidad] int not null,
);



select * from registroUsuario;