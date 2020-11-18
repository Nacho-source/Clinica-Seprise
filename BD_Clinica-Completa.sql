drop database if exists Clinica;
create database Clinica;
use Clinica;

create table Sector
(
	IdSector int auto_increment,
	Nombre varchar(100),
	constraint PK_Sector primary key (IdSector)
)engine=innodb;

create table Sala
(
	IdSala int auto_increment,
	IdSector int,
	Telefono varchar(15),
	Capacidad int,
	constraint PK_Sala primary key (IdSala),
	constraint FK_Sector foreign key (IdSector) references Sector (IdSector)
)engine=innodb;

create table Paciente 
(
	IdPaciente int auto_increment,
	tipoDoc varchar(50),
	Documentacion long,
	Nombre varchar(50),
	Apellido varchar(50),
	FechaNacimiento date,
	Nacionalidad varchar(30),
	Localidad varchar(30),
	Direccion varchar(100),
	CodigoPostal int,
	Celular varchar(15),
	Telefono varchar(15),
	EMail varchar(75),
	GrupoS varchar(5),
	ObraSocial varchar(75),
	internado boolean,
	internadoUrgente boolean,
	constraint PK_Paciente primary key (IdPaciente)	
)engine=innodb;	

create table Rol
(
	IdRol int auto_increment,
	Descripcion varchar(50),
	constraint PK_Rol primary key (IdRol)
)engine=innodb;

create table Empleado
(
	IdEmpleado int auto_increment,
	IdRol int,
	tipoDoc varchar(50),
	Documentacion long,
	Nombre varchar(30),
	Apellido varchar(30),
	FechaNacimiento date,
	Telefono int,
	EMail varchar(75),
	Direccion varchar(100),
	constraint PK_Empleado primary key (IdEmpleado),
	constraint FK_Empleado foreign key (IdRol) references Rol (IdRol)
)engine=innodb;	

create table Medico
(
	IdMedico int auto_increment,
	IdEmpleado int,
	Matricula varchar(30),
	constraint PK_Medico primary key (IdMedico),
	constraint FK_Medico foreign key (IdEmpleado) references Empleado(idEmpleado)
)engine=innodb;

create table MedicoSala
(
	IdSalaMedico int auto_increment,
	IdMedico int,
	IdSala int,
	constraint PK_Sala_Medico primary key (IdSalaMedico),
	constraint FK_Medico_Sala foreign key (IdMedico) references Medico (IdMedico),
	constraint FK_Sala_Medico foreign key (IdSala) references Sala (IdSala)
)engine=innodb;

CREATE TABLE Proveedor
(
	IdProv int auto_increment,
	Nombre varchar(80)NOT NULL,
	Domi varchar(150)NOT NULL,
	Tel long NOT NULL,
	Activo boolean, /*PARA SABER SI SE PUEDE USAR, si esta en false, significa que esta eliminado para futuras cargas en otra table*/
	constraint PK_Proveedor primary key (IdProv)
)engine=innodb;

create table Especialidad
(
	IdEspecialidad int auto_increment,
	IdEmpleado int,
	Descripcion varchar(50),
	constraint PK_Especialidad primary key (IdEspecialidad)
)engine=innodb;

create table EspRol
(
	IdEspecialidad int,
	IdRol int,
	constraint PK_EspRol primary key (IdEspecialidad, idRol),
	constraint FK_EspRol foreign key (IdRol) references Rol(IdRol),
	constraint FK_EspRol2 foreign key (IdEspecialidad) references Especialidad (IdEspecialidad)
)engine=innodb;

CREATE TABLE Medicamento
(
	IdMedicamento INT auto_increment,
	IdProv INT,
	Stock INT,
	PP INT,
	Nombre VARCHAR(50),
	Presen VARCHAR(50),
	PrecioVenta FLOAT,/*Se agrego para cobrar a pacientes lo utilizado*/
	Activo boolean, /*PARA SABER SI SE PUEDE USAR, si esta en false, significa que esta eliminado para futuras cargas en otra table*/
	constraint PK_Medicamento primary key (IdMedicamento),
	constraint FK_Medicamento_P foreign key (IdProv) References Proveedor(IdProv)
)engine=innodb;

create table Privilegio
(
	privilegioID int auto_increment,
	privilegio varchar(30),
	constraint PK_Privilegio primary key (PrivilegioID)
)engine=innodb;

CREATE TABLE Insumo 
(
	IdInsumo INT,
	Nombre VARCHAR(50),
	Stock INT,
	PP INT,
	PrecioVenta FLOAT,/*Se agrego para cobrar a pacientes lo utilizado*/
	Activo boolean, /*PARA SABER SI SE PUEDE USAR, si esta en false, significa que esta eliminado para futuras cargas en otra table*/
	CONSTRAINT PK_Insumo PRIMARY KEY(IdInsumo)
)engine=innodb;

/*NO TOCAR*/
create table Usuario
(
	UsuarioID int auto_increment,
	Nombre varchar(50),
	Contraseña varchar(30),
	constraint PK_Usuario primary key (UsuarioID)
)engine=innodb;

create table EmpleadoAsistencia
(
	IdAsistencia int auto_increment,
	IdEmpleado int,
	Fecha date,
	Asistio boolean, /* 1-Asistio 0-Ausente*/
	constraint pk_asistencia primary key (idAsistencia),
	constraint fk_asistencia_empelado foreign key (IdEmpleado) references Empleado (IdEmpleado)
)engine=innodb;


/* Turnos de 15 minutos */
create table HorarioConsultaComun
(
idHorarioComun int auto_increment,
fechahora datetime,
sobreturno boolean,
constraint PK_IdHorarioComun primary key (idHorarioComun)
 )engine=innodb;

/* Turnos de 25 minutos */
create table HorarioFisiokinesiologiaCE
(
IdHorarioFisio int auto_increment,
fechahora datetime,
sobreturno boolean,
constraint PK_IdHorarioComun primary key (IdHorarioFisio)
 )engine=innodb;
 
 /* Turnos de 35 minutos */
create table HorarioSaludMentalCE
(
IdHorarioSM int auto_increment,
fechahora datetime,
sobreturno boolean,
constraint PK_IdHorarioComun primary key (IdHorarioSM)
 )engine=innodb;

create table TipoConsultaExterna
(
	tipoID int auto_increment,
	tipo varchar(100),
	tiempoConsulta varchar(30),
	constraint PK_TipoConsulta primary key (tipoID)
)engine=innodb;
/*
  15 minutos por paciente en consultas comunes
				25 minutos por paciente en consultas de Fisiokinesiologia
				1 paciente agregado por hora
				35 minutos por paciente en practicas de Salud Mental
*/

create table TurnoConsultaExterna
(
	turnoID int auto_increment,
	TipoConsultaExterna int, /* Se especifica el tipo de consulta al inicializarce. Esto sirve para saber el tiempo que durara la consulta */
	IdPaciente int, /* nulleable Al inicializarce*/
	IdSalaMedico int, /* nulleable Al inicializarce*/
	Estado boolean, /*si es 1 esta ocupado. Si es 0 esta disponible*/
	Asistido boolean, /*  1- asistio 0- No asistio*/
	idHorarioComun int, /* si no es comun va en null */
	idHorarioFisio int, /* si no es fisiokinesiologia va en null */
	idHorarioSM int, /* si no es salud mental va en null */
	constraint PK_Turno primary key (turnoID),
	constraint FK_Turno_tipo foreign key (TipoConsultaExterna) references TipoConsultaExterna(TipoID),
	constraint FK_Turno_MedicoSala foreign key (IdSalaMedico) references MedicoSala (IdSalaMedico),
	constraint FK_Turno_paciente foreign key (IdPaciente) references Paciente(IdPaciente),
	constraint FK_Horario_Comun foreign key (idHorarioComun) references HorarioConsultaComun (idHorarioComun),
	constraint FK_Horario_Fisio foreign key (idHorarioFisio) references HorarioFisiokinesiologiaCE (idHorarioFisio),
	constraint FK_Horario_SM foreign key (idHorarioSM) references HorarioSaludMentalCE (idHorarioSM)
)engine=innodb;


create table HistoriaClinicaExterna
(
	historiaClinicaID int auto_increment,
	IdPaciente int,
	descripcion varchar(400),
	fecha date,
	constraint PK_HistoriaClinica primary key (HistoriaClinicaID),
	constraint FK_HistoriaClinica_paciente foreign key (IdPaciente) references Paciente (IdPaciente)
)engine=innodb;


create table DoctorDisponibilidad
(
	IdMedico int,
	hora time,
	fecha date,
	Estado boolean,
	constraint PK_DocDisp primary key (IdMedico),
	constraint FK_DocDisp foreign key (IdMedico) references Medico (IdMedico)
)engine=innodb;

create table AsigSalaMedico
(
	IdAsignacion int auto_increment,
	idMedico int,
	IdSala int,
	Fecha date,
	Asigno boolean,
	constraint PK_AsigSalaMed primary key (IdAsignacion),
	constraint FK_AsigsalaMedMedico foreign key (IdMedico) references Medico (IdMedico),
	constraint FK_AsigSalaMedSala foreign key (IdSala) references Sala (IdSala)
)engine=innodb;

create table AsigMedicamentoMed
(
	IdAsignacion int auto_increment,
	idMedico int,
	Fecha date,
	Asigno boolean,
	constraint PK_AsigMedicamentoMed primary key (IdAsignacion),
	constraint FK_AsigMedicamentoMed foreign key (IdMedico) references Medico (IdMedico)
)engine=innodb;

create table AsigInsmoMed
(
	IdAsignacion int auto_increment,
	idMedico int,
	Fecha date,
	Asigno boolean,
	constraint PK_AsigInsumoMed primary key (IdAsignacion),
	constraint FK_AsigInsumoMed foreign key (IdMedico) references Medico (IdMedico)
)engine=innodb;

create table Habitacion_Internacion
(
	Nrohabi int,
	IdSector int,
	Capacidad int,
	Ocupadas int,
	Piso int,
	constraint PK_habi primary key (Nrohabi),
	constraint FK_HABI foreign key (IdSector) references Sector(IdSector)
)engine=innodb;


create table Estudio
(
	IdEstudio int auto_increment,
	Descripcion varchar(50),
	Precio float, 
	constraint PK_Estudis primary key (idEstudio)
)engine=innodb;

create table Operacion
(
	IdOperacion int auto_increment,
	Tipo varchar(30),
	estudios boolean, /* si la operacion necesita estudios prequirurgicos estudios = 1*/
	constraint PK_Operacion primary key (IdOperacion)
) engine=innodb;

create table EstudiosOperacion
(
	idEstudio int,
	idOperacion int,
	constraint pk_estudiosO primary key (idEstudio, idOperacion),
	constraint fk_estudiosOE foreign key (idEstudio) references Estudio (idEstudio)
) engine=innodb;

create table Acompañante
(
	idAcompanante int auto_increment,
	TipoDoc varchar(30),
	DNI varchar(12),
	nombre varchar(30),
	apellido varchar(30),
	constraint pk_acompanante primary key (idAcompanante)
) engine=innodb;

create table InternacionConsentimiento
(
	idInternacionC int auto_increment,
	IdMedico int,
	idPaciente int,
	Nrohabi int,
	IdSector int,
	fecha date,
	descripcion varchar(100),
	tipo varchar(30),
	aceptado boolean, /* acepta someterse a la internacion*/
	mayorEdad boolean, /* si es mayor de edad necesita acompañante si o si*/
	alta boolean, /* alta de la internacion*/
	idOperacion int, /* si se debe operar al paciente, en caso de que no haya operacion este atributo queda con el valor 0*/
	depositoGastosImprevistos int,
	constraint pk_consentimiento primary key (idInternacionC),
	constraint fk_consentimientoP foreign key (idPaciente) references Paciente (idPaciente),
	constraint fk_consentimientoM foreign key (IdMedico) references Medico (IdMedico),
	constraint FK_consentimientoS foreign key (IdSector) references Sector(IdSector),
	constraint fk_consentimientoH foreign key (Nrohabi) references Habitacion_Internacion (Nrohabi)
) engine=innodb;

create table InternacionProcedimiento
(
	idInternacionP int,
	idInternacionC int,
	idMedico int,
	Nrohabi int,
	fecha date,
	constraint pk_Procedimiento primary key (idInternacionP),
	constraint fk_ProcedimientoI foreign key (idInternacionC) references InternacionConsentimiento (idInternacionC)
) engine=innodb;

create table InternacionAcompañante
(
	idInternacionA int auto_increment,
	idInternacionC int,
	idAcompanante int,
	cena boolean, /* si el acompañante se queda a cenar*/
	constraint pk_internacionA primary key (idInternacionA),
	constraint fk_InternacionAA foreign key (idAcompanante) references Acompañante (idAcompanante),
	constraint fk_InternacionAIC foreign key (idInternacionC) references InternacionConsentimiento (idInternacionC)
) engine=innodb;

create table AltaMedica
(
	idAltaM int auto_increment,
	idInternacionC int,
	resumen varchar(50),
	fecha date,
	recomendaciones varchar(50),
	telContacto int,
	FAlta date,
	constraint pk_facturaA primary key (idAltaM),
	constraint fk_facturaAIC foreign key (idInternacionC) references InternacionConsentimiento (idInternacionC)
) engine=innodb;

create table MedicamentoEstancia /* todos los medicamentos que se utilizan durante la internacion*/
(
	idMedicamentoEstancia int auto_increment,
	idInternacionC int,
	IdMedicamento int,
	costo int,
	constraint pk_medicamentoestancia primary key (idMedicamentoEstancia),
	constraint fk_medicamentoEM foreign key (IdMedicamento) references Medicamento(IdMedicamento)
)engine=innodb;

create table InsumoEstancia
(
	idInsumoEstancia int auto_increment,
	idInternacionC int,
	idInsumo int,
	costo int,
	constraint pk_insumoestancia primary key (idInsumoEstancia),
	constraint fk_insumoEI foreign key (idInsumo) references Insumo (idInsumo)
) engine=innodb;


create table AltaAdministrativa /*  Arreglar, Barraza y Caldara*/
(
	idAltaA int auto_increment,
	idAltaM int,
	idMedicamentoEstancia int,
	idInsumoEstancia int,
	costoLlamadas int,
	costoTotal int,
	constraint pk_altaA primary key (idAltaA),
	constraint fk_AltaAAM foreign key (idAltaM) references AltaMedica (idAltaM),
	constraint fk_AltaAIE foreign key (idMedicamentoEstancia) references MedicamentoEstancia(idMedicamentoEstancia),
	constraint fk_AltaAI foreign key (idInsumoEstancia) references InsumoEstancia (idInsumoEstancia)
)engine=innodb;

create table EstudioPac
(
	idEstudiPac int auto_increment,
	idEstudio int,
	IdPaciente int,
	fecha date,
	hora time,
	constraint PK_EstudiPac primary key (idEstudiPac),
	constraint FK_EstudiPac foreign key (IdPaciente) references Paciente (IdPaciente),
	constraint FK_AEstudiPac foreign key (idEstudio) references Estudio (idEstudio)
)engine=innodb;

create table VisitaEnf
(
	idVisitaEnf int auto_increment,
	idpaciente int,
	idempleado int,
	observaciones varchar(100),
	Fecha date,
	Hora time,
	constraint PK_VisitaEnf primary key (IdVisitaEnf),
	constraint FK_VisitaEnf_A foreign key (IdPaciente) references Paciente(IdPaciente),
 	constraint FK_VisitaEnf_B foreign key (IdEmpleado) references Empleado(IdEmpleado)
)engine=innodb;

create table Ronda
(
	NroRonda int auto_increment,
	IdPaciente int,
	IdMedico int,
	observaciones varchar(100),
	Fecha date,
	hora time,
	constraint PK_Ronda primary key (NroRonda),
	constraint FK_Ronda foreign key (IdPaciente) references Paciente (IdPaciente),
	constraint FK_Ronda1 foreign key (IdMedico) references Medico (IdMedico)
)engine=innodb;

create table RondaPacMedic
(
	NroRondaPacMedic int auto_increment,
	NroRonda int,
	IdMedicamento int,
	dias varchar(7),
	CanHora int,
	cantidad int,
	cantXDia int,
	constraint PK_RondaPacMedic primary key (NroRondaPacMedic),
	constraint FK_RondaPacMedic_R foreign key (NroRonda) references Ronda (NroRonda),
	constraint FK_RondaPacMedic_M foreign key (IdMedicamento) references Medicamento (IdMedicamento)
)engine=innodb;

create table RondaPacInsumo
(
	NroRondaPacInsumo int auto_increment,
	NroRonda int,
	IdInsumo int,
	dias varchar(7),
	CanHora int,
	cantidad int,
	cantXDia int,
	constraint PK_RondaPacInsumo primary key (NroRondaPacInsumo),
	constraint FK_RondaPacInsumo_R foreign key (NroRonda) references Ronda (NroRonda),
	constraint FK_RondaPacInsumo_I foreign key (IdInsumo) references Insumo (IdInsumo)
)engine=innodb;

create table AlmacenEstudios 
(
	IdAlmacen int auto_increment,
	FechaIngreso date,
	IdEstudio int,
	IdPaciente int,
	Estado boolean,
	constraint PK_Almacen primary key (IdAlmacen),
	constraint FK_Almacen foreign key (IdEstudio) references Estudio (IdEstudio),
	constraint FK_Almacen2 foreign key (IdPaciente) references Paciente (IdPaciente)
)engine=innodb;

create table ObraSocial 
(
	IdObraSocial int auto_increment,
	Nombre varchar(50),
	Cuit long,
	Direccion varchar(100),
	Localidad varchar(100),
	Telefono int,
	Email varchar(150),
	constraint pk_ObraSocial primary key (idObraSocial)
)engine=innodb;

create table ObraEstudio
(
	idObraSocial int,
	idEstudio int,
	constraint PK_ObraEstudio primary key (idObraSocial, idEstudio),
	constraint FK_ObraEstudio foreign key (idObraSocial) references ObraSocial (idObraSocial),
	constraint FK_ObraEstudio2 foreign key (idEstudio) references Estudio (idEstudio)
)engine=innodb;

create table AgendaTurno 
(
	IdAgenda int auto_increment,
	Fecha date,
	Horario varchar(10),
	Detalle varchar(150),
	IdObraSocial int ,
	IdMedico int,
	IdEstudio int,
	IdPaciente int, 
	constraint pk_AgendaTurnos primary key(IdAgenda),
	constraint FK_AgendaTurnos foreign key (IdObraSocial) references ObraSocial(IdObraSocial),
	constraint FK_AgendaTurnos2 foreign key (IdMedico) references Medico(IdMedico),
	constraint FK_AgendaTurnos3 foreign key (IdEstudio) references Estudio(IdEstudio),
	constraint FK_AgendaTurnos4 foreign key (IdPaciente) references Paciente(IdPaciente)
)engine=innodb;

create table FormaPago 
(
	IdForma int auto_increment,
	Tipo varchar(50),
	constraint PK_FormaPago primary key (IdForma)
)engine=innodb;

create table Facturacion
(
	idFacturacion int auto_increment,
	idEstudios int,
	fechaPago date,
	idForma int,
	idPaciente int,
	constraint PK_Facturacion primary key (idFacturacion),
	constraint FK_Facturacion foreign key (idForma) references FormaPago (idForma),
	constraint FK_Facturacion2 foreign key (idPaciente) references Paciente(IdPaciente)
)engine=innodb; 
-- Estudios

CREATE TABLE Insumo_Sector
(
	idInsumo INT,
	IdSector INT,
	Stock INT,
	PP INT,
	Porcentaje INT,
	CONSTRAINT PK_Insumo_Sector PRIMARY KEY(idInsumo, IdSector),
	CONSTRAINT FK_Insumo_Sector_I FOREIGN KEY (idInsumo) REFERENCES Insumo(idInsumo),
	CONSTRAINT FK_Insumo_Sector_S FOREIGN KEY (IdSector) REFERENCES Sector(IdSector)
)engine=innodb;

CREATE TABLE Insumo_Proveedor
(
	idProv int,
	idInsumo int,
	Precio float,
	CONSTRAINT PK_Insumo_Proveedor primary key(IdProv, idInsumo),
	CONSTRAINT FK_Insumo_Proveedor_P foreign key(IdProv) References Proveedor (IdProv),
	CONSTRAINT FK_Insumo_Proveedor_I foreign key (idInsumo) References Insumo(idInsumo)
)engine=innodb;

CREATE TABLE Medicamento_Sector
(
	IdMedicamento INT,
	IdSector INT,
	Stock INT,
	PP INT,
	Porcentaje INT,
	CONSTRAINT PK_Medicamento_Sector PRIMARY KEY (IdMedicamento, IdSector),
	CONSTRAINT FK_Medicamento_Sector_M FOREIGN KEY (IdMedicamento) REFERENCES Medicamento (IdMedicamento),
	CONSTRAINT FK_Medicamento_Sector_S FOREIGN KEY (IdSector) REFERENCES Sector (IdSector)
)engine=innodb;

create table estudioMedicamento
(
	IdEstudio int, 
	IdMedicamento int,
	constraint pk_estudioMedicamento primary key (IdEstudio, IdMedicamento),
	constraint fk_estudioMedicamento foreign key (IdMedicamento) references Medicamento (IdMedicamento),
	constraint fk_estudioMedicamento1 foreign key (IdEstudio) references Estudio (IdEstudio)
)engine=innodb;

create table estudioInsumo
(
	IdEstudio int, 
	IdInsumo int,
	constraint pk_estudioInsumo primary key (IdEstudio, IdInsumo),
	constraint fk_estudioInsumo foreign key (IdInsumo) references Insumo (IdInsumo),
	constraint fk_estudioInsumo1 foreign key (IdEstudio) references Estudio (IdEstudio)
)engine=innodb;


CREATE TABLE Pedido
(
	IdPedido INT auto_increment,
	IdSector INT,
	IdEmpleado INT, /*El id del calendario tendra un valor especial*/
	Fecha date,
	constraint PK_Pedido primary key (IdPedido),
	constraint FK_Pedido_E foreign key (IdEmpleado) References Empleado(IdEmpleado),
	constraint FK_Pedido_S foreign key (IdSector) References Sector(IdSector)
)engine=innodb;

create table DetPedidoIns
(
	IdDetPedI INT auto_increment,
	IdPedido INT,
	idInsumo INT,
	Cantidad INT,
	Resto Int,
	Recibido boolean,
	constraint pk_DetPedidoI primary key (IdDetPedI, IdPedido),
	constraint fk_DetPedidoIP foreign key (IdPedido) references Pedido(IdPedido),
	constraint fk_DetPedidoII foreign key (idInsumo) references Insumo(idInsumo)
)engine=innodb;

create table DetPedidoMed
(
	IdDetPedM INT auto_increment,
	IdPedido INT,
	IdMedicamento INT,
	Cantidad INT,
	Resto Int,
	Recibido boolean,
	constraint pk_DetPedidoM primary key (IdDetPedM, IdPedido),
	constraint fk_DetPedidoMP foreign key (IdPedido) references Pedido(IdPedido),
	constraint fk_DetPedidoMM foreign key (IdMedicamento) references Medicamento(IdMedicamento)
)engine=innodb;

create table Ord_Comp
(
	IdOrdComp INT auto_increment,
	FOrdComp date,
	IdProv INT,
	Referencia INT,
	Recibido boolean,
	constraint pk_Ord_Comp primary key(IdOrdComp),
	constraint fk_Ord_Comp foreign key(IdProv) references Proveedor(IdProv)
)engine=innodb;

create table DetOrdComp_Med
(
	IdDetOCM INT auto_increment,
	IdOrdComp INT,
	IdMedicamento INT,
	Cantidad INT,
	VlrUni float,
	Resto INT,
	Recibido boolean,
	constraint pk_DetOrdCompM primary key (IdDetOCM, IdOrdComp),
	constraint fk_DetOrdCompMO foreign key (IdOrdComp) references Ord_Comp(IdOrdComp),
	constraint fk_DetOrdCompMM foreign key (IdMedicamento) references Medicamento(IdMedicamento)
)engine=innodb;

create table DetOrdComp_Ins
(
	IdDetOCI INT auto_increment,
	IdOrdComp INT,
	idInsumo INT,
	Cantidad INT,
	VlrUni float,
	Resto INT,
	Recibido boolean,
	constraint pk_DetOrdCompI primary key (IdDetOCI , IdOrdComp),
	constraint fk_DetOrdCompIO foreign key (IdOrdComp) references Ord_Comp(IdOrdComp),
	constraint fk_DetOrdCompIM foreign key (idInsumo) references Insumo(idInsumo)
)engine=innodb;

create table Remito
(
	IdRem INT,
	IdProv INT,
	FRem date,
	IdOrdComp INT,
	CONSTRAINT pk_Remito primary key (IdRem),
	CONSTRAINT fk_Remito_P foreign key (IdProv) references Proveedor(IdProv),
	CONSTRAINT fk_Remito_O foreign key (IdOrdComp) references Ord_Comp(IdOrdComp)
)engine=innodb;

create table FactProv
(
	idFactP INT auto_increment,
	CodFactP INT,
	IdProv INT, 
	IdRem INT,
	Monto float,
	FPago date,
	CONSTRAINT PK_FactProv primary key (idFactP),
	CONSTRAINT fk_FactProv_P foreign key (IdProv) references Proveedor(IdProv),
	CONSTRAINT FK_FactProv foreign key (IdRem) References Remito(IdRem)
)engine=innodb;

create table Paquete
(
	IdPaq INT auto_increment,
	IdPedido INT,
	Total BOOLEAN,/*Si es falso, se ingresara un detalle con lo faltante, y se cargara en pendientes */
	Detalle Varchar(200) DEFAULT "",
	CONSTRAINT PK_Paquete primary key (IdPaq),
	CONSTRAINT FK_Paquete foreign key (idPedido) References Pedido(IdPedido)
)engine=innodb;

CREATE TABLE Pendientes
(
	IdPend INT,
	IdPaq INT,
	Detalle VARCHAR(200),
	CONSTRAINT PK_Pendientes primary key (IdPend),
	CONSTRAINT FK_Pendientes_P foreign key (IdPaq) References Paquete(IdPaq)
)engine=innodb;

create table Urgencia
(
	IdUrgencia int auto_increment,
	Nombre varchar(50),
	constraint pk_Urgencia primary key (IdUrgencia)
)engine=innodb;

create table ListaEspera
(
	IdPacienteLista int auto_increment,
	TipoIngreso varchar(15),
	Motivo varchar(100),
	Fecha date,
	Hora time,
	IdPaciente int,
	IdUrgencia int,
	IdEspecialidad int,
	constraint pk_ListaEspera primary key (IdPacienteLista),
	constraint fk_ListaEspera_P foreign key (IdPaciente) references Paciente(IdPaciente),
	constraint fk_ListaEspera_E foreign key (IdEspecialidad) references Especialidad(IdEspecialidad),
	constraint fk_ListaEspera_U foreign key (IdUrgencia) references Urgencia(IdUrgencia)
)engine=innodb;

create table MedicoGuardia
(
	IdMedicoGuardia int auto_increment,
	Dia varchar(10),
	Comienzo time,
	Duracion int,
	IdMedico int,
	Activo boolean,
	constraint pk_MedicoGuardia primary key (IdMedicoGuardia),
	constraint fk_MedicoGuardia foreign key (IdMedico) references Medico(IdMedico)
)engine=innodb;

create table AtencionPaciente
(
	IdAtencionPaciente int auto_increment,
	IdPaciente int,
	IdMedicoGuardia int,
	Comienzo datetime,
	Fin datetime, /* Si fin esta en nulo no termino*/
	Estado varchar(1500),
	constraint pk_AtencionPaciente primary key (IdAtencionPaciente),
	constraint fk_AtencionPaciente_M foreign key (IdMedicoGuardia) references MedicoGuardia(IdMedicoGuardia),
	constraint fk_AtencionPaciente_P foreign key (IdPaciente) references Paciente(IdPaciente)
)engine=innodb;

create table AtencionPacienteMedicamento
(
	IdAtencionPacienteMed int auto_increment,
	IdAtencionPaciente int,
	IdMedicamento int,
	Cantidad int,
	FechaHora datetime,
	constraint pk_AtencionPacienteMed primary key (IdAtencionPacienteMed),
	constraint fk_AtencionPacienteMed_At foreign key (IdAtencionPaciente) references AtencionPaciente(IdAtencionPaciente),
	constraint fk_AtencionPacienteMed_Med foreign key (IdMedicamento) references Medicamento(IdMedicamento)
)engine=innodb;

create table AtencionPacienteInsumo
(
	IdAtencionPacienteIns int auto_increment,
	IdAtencionPaciente int,
	IdInsumo int,
	Cantidad int,
	FechaHora datetime,
	constraint pk_AtencionPacienteIns primary key (IdAtencionPacienteIns),
	constraint fk_AtencionPacienteIns_At foreign key (IdAtencionPaciente) references AtencionPaciente(IdAtencionPaciente),
	constraint fk_AtencionPacienteIns_Ins foreign key (IdInsumo) references Insumo(IdInsumo)
)engine=innodb;

create table Enfermedad
(
	IdEnfermedad int auto_increment,
	Descripcion varchar(30),
	constraint PK_Enfermedad primary key (IdEnfermedad)
)engine=innodb;

create table PacienteEnfermedad
(
	IdPaciente int,
	IdEnfermedad int,
	constraint PK_PacienteEnfermedad primary key (IdPaciente, IdEnfermedad),
	constraint FK_PacienteEnfermedad foreign key (IdPaciente) references Paciente(IdPaciente),
	constraint FK_PacienteEnfermedad2 foreign key (IdEnfermedad) references Enfermedad (IdEnfermedad)
)engine=innodb;	

create table Dieta
(	
	IdDieta int auto_increment,
	Descripcion varchar(30),
	Consistencia varchar(30),
	Borrado boolean,           /* Si la dieta esta borrada logicamente o no / 0 = No / 1 = Si */
	constraint PK_Dieta primary key (IdDieta)
)engine=innodb;

create table Plato
(
	IdPlato int auto_increment,
	Descripcion varchar(30),
	constraint PK_Plato primary key (IdPlato)
)engine=innodb;

create table Dieta_Plato
(
	IdPlato int,
	IdDieta int,
	constraint PK_Dieta_Plato primary key (IdPlato, IdDieta),
	constraint FK_Dieta_Plato foreign key (IdDieta) references Dieta (IdDieta),
	constraint FK_Dieta_Plato2 foreign key (IdPlato) references Plato (IdPlato)
)engine=innodb;

create table Ingrediente
(
	IdIngrediente int auto_increment,
	Descripcion varchar(30),
	constraint PK_Ingrediente primary key (IdIngrediente)
)engine=innodb;

create table Plato_Ingrediente
(
	IdPlato int,
	IdIngrediente int,
	constraint PK_Plato_Ingrediente primary key (IdPlato, IdIngrediente),
	constraint FK_Plato_Ingrediente foreign key (IdIngrediente) references Ingrediente (IdIngrediente),
	constraint FK_Plato_Ingrediente2 foreign key (IdPlato) references Plato (IdPlato)
)engine=innodb;

create table IngredienteNoPermitido
(
	IdIngrediente int,
	IdEnfermedad int,
	constraint PK_IngredientePermitido primary key (IdIngrediente, IdEnfermedad),
	constraint FK_IngredientePermitido foreign key (IdIngrediente) references Ingrediente (IdIngrediente),
	constraint FK_IngredientePermitido2 foreign key (IdEnfermedad) references Enfermedad (IdEnfermedad)
)engine=innodb;

create table DietaPaciente
(	
	IdDieta int,
	IdPaciente int,
	DiaInicio date,
	DiaFin date,
	Momento varchar(1),      /* D = Desayuno / A = Almuerzo / M = Merienda / C = Cena */
	Mostrado boolean,		/* 0 = No fue mostrado / 1 = Si fue mostrado */
	constraint PK_DietaPaciente primary key (IdDieta, IdPaciente),
	constraint FK_DietaPaciente foreign key (IdDieta) references Dieta(IdDieta),
	constraint FK_DietaPaciente2 foreign key (IdPaciente) references Paciente(IdPaciente)
)engine=innodb;

create table PlusHonorarioMedico
(
	IdMedico int,
	Fecha datetime,
	Monto float,
	constraint PK_HonMedico primary key (IdMedico),
	constraint FK_HonMedico foreign key (IdMedico) references Medico (IdMedico)
)engine=innodb;

create table especialidadEstudio
(
	IdEstudio int,
	IdEspecialidad int,
	constraint pk_especialidadEstudio primary key (IdEspecialidad, IdEstudio),
	constraint fk_especialidadEstudio foreign key (IdEspecialidad) references Especialidad (IdEspecialidad),
	constraint fk_especialidadEstudio1 foreign key (IdEstudio) references Estudio (IdEstudio)
)engine=innodb;

create table horarioMedico
(
	idHorarioMedico int auto_increment,
	IdEspecialidad int,
	Hora time,
	constraint pk_horarioMedico primary key (idHorarioMedico),
	constraint fk_horarioMedico foreign key (IdEspecialidad) references Especialidad (IdEspecialidad)
)