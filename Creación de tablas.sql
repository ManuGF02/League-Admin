create table Estadios(
	ID int identity(1,1) primary key,
	Nombre varchar(30) not null,
	Capacidad int not null,
	Direccion varchar(100),
	FechaConstruccion timestamp
);

create table Equipos(
	ID varchar(3) primary key,
	NombreCompleto varchar(50) not null,
	Nombre varchar(40) not null,
	Ciudad varchar(30) not null,
	Estadio int foreign key (Estadio) references Estadios (ID),
	AñoFundacion timestamp not null,
	Socios int not null
);

create table Arbitros(
	ID int identity(1,1) primary key,
	Apellidos varchar(30) not null,
	Nombre varchar(20) not null,
	FechaNacimiento timestamp,
	Colegio varchar(20) not null	
);

create table clasificacion1(
	Equipo varchar(3) foreign key (Equipo) references Equipos (ID),
	PJ int not null,
	G int not null,
	E int not null,
	P int not null,
	DG int not null,
	Puntos int not null
);

create table clasificacion2(
	Equipo varchar(3) foreign key (Equipo) references Equipos (ID),
	PJ int not null,
	G int not null,
	E int not null,
	P int not null,
	DG int not null,
	Puntos int not null
);

create table Partidos(
	Equipo1 varchar(3) foreign key (Equipo1) references Equipos (ID),
	Equipo2 varchar(3) foreign key (Equipo2) references Equipos (ID),
	Fecha timestamp not null, 
	primary key(Equipo1, Equipo2, Fecha),
	Goles1 int not null,
	Goles2 int not null, 
	Arbitro int foreign key (Arbitro) references Arbitros (ID),
	Meteorología varchar(50)
);