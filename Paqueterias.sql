CREATE DATABASE Paqueterias

GO

USE Paqueterias

GO

CREATE TABLE PaqueteExpress(
	id int primary key identity(1,1) ,
	CodigoPostal varchar(10) NOT NULL ,
	origen varchar(10) ,
	sucursal varchar(10) ,
	municipio varchar(100) ,
	ciudad varchar(100) ,
	colonia varchar(100) ,
	estado varchar(100) ,
	cobertura varchar(100) ,	
)

GO 

CREATE INDEX INDEX_CODIGO_POSTAL ON PaqueteExpress(CodigoPostal)

GO

CREATE TABLE Sendex(
	id int primary key identity(1,1) ,
	CodigoPostal varchar(10) NOT NULL ,
	estado varchar(100) ,
	ciudad varchar(100) ,
	colonia varchar(100) ,
	entregaDomicilio varchar(2) ,
	recoleccionDomicilio varchar(2) ,
)

GO 

CREATE INDEX INDEX_CODIGO_POSTAL ON Sendex(CodigoPostal)

GO 

CREATE TABLE Estafeta(
	id int primary key identity(1,1) ,
	CodigoPostal varchar(10) NOT NULL ,
	municipio varchar(100) ,
	estado varchar(100) ,
	periodisidad varchar(50) ,
	forzoso varchar(20) ,
	reexpedicion varchar(20) ,
	entregaFinSemana varchar(20) ,
	horarioExtendido varchar(20) ,
	lunes varchar(1) ,
	martes varchar(1) ,
	miercoles varchar(1) ,
	jueves varchar(1) ,
	viernes varchar(1) ,
	sabado varchar(1) ,
	domingo varchar(1) 
)

GO 

CREATE INDEX INDEX_CODIGO_POSTAL ON Estafeta(CodigoPostal)