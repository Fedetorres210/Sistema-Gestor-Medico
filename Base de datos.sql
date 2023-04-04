CREATE DATABASE tuSalud;
use tuSalud

-- Centro de salud
CREATE TABLE centro(
	codigo_centro INTEGER IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (50) NOT NULL,
	ID_lugar INTEGER  NOT NULL,
	capacidad_maxima INT NOT NULL,
	tipo_centro VARCHAR (20) NOT NULL--tipo de centro (Hospital, Clínica, EBAIS, estos tipos de centros podrían aumentar si la CCSS define nuevas tipologías
);

CREATE TABLE lugar(
	ID_LUGAR INTEGER  PRIMARY KEY,
	pais VARCHAR (50) NOT NULL,
	canton VARCHAR (50) NOT NULL,
	distrito VARCHAR (50) NOT NULL,
);

CREATE TABLE area(
	ID_area INTEGER  PRIMARY KEY,
	nombre VARCHAR (50) NOT NULL,
	descripcion VARCHAR (50) NOT NULL,
	ID_centro INTEGER NOT NULL
);

-- Funcionario
CREATE TABLE funcionarios(
	cedula_funcionario INT PRIMARY KEY,
	tipo_funcionario VARCHAR (50) NOT NULL,
	fecha_ingreso DATE NOT NULL,
	area_trabajo VARCHAR (20) NOT NULL,
	ID_centro INTEGER NOT NULL,
	ID_area INTEGER NOT NULL
);

-- Pacientes
CREATE TABLE paciente(
	id_persona INT PRIMARY KEY,
	tipo_sangre VARCHAR (100) NOT NULL,
	id_diagnostico INTEGER NOT NULL,
	id_citas INTEGER NOT NULL,
	id_tratamiento INTEGER NOT NULL
);
CREATE TABLE persona(
	id_persona INT PRIMARY KEY,
	nombre VARCHAR (20) NOT NULL,
	apellido1 VARCHAR (10) NOT NULL,
	apellido2 VARCHAR (10)  NULL,
	fecha_nacimiento DATETIME NOT NULL,
	nacionalidad VARCHAR(20) NOT NULL,
	id_lugar INTEGER NOT NULL,
	direccion VARCHAR (100) NOT NULL
);

-- Crear tabla de citas
CREATE TABLE cita (
    id_cita INT PRIMARY KEY,
    id_paciente INT NOT NULL,
    id_especialidad INT NOT NULL,
	id_centro INT NOT NULL,
	id_area INT NOT NULL,
    fecha_cita DATETIME NOT NULL,
	hora_cita DATETIME NOT NULL,
    observacion TEXT,
    tipo_cita VARCHAR(10) NOT NULL, -- texto o audio
    estado_cita VARCHAR(20) NOT NULL -- Registrada, Asignada, Realizada, Cancelada
);
CREATE TABLE diagnostico (
    id_diagnostico INT PRIMARY KEY,
    nombre VARCHAR NOT NULL,
    descripcion text NOT NULL,
    nivel VARCHAR(20) NOT NULL,
	observaciones VARCHAR(50)
);
CREATE TABLE tratamientos (
    id_tratamiento INT PRIMARY KEY,
	descripcion text NOT NULL,
	nivel VARCHAR(20) NOT NULL,
	id_diagnostico INT NOT NULL,
	unidad INT NOT NULL,
    tipo_tratamiento VARCHAR(50) NOT NULL
);
CREATE TABLE fichaClinica (
    id_paciente INT PRIMARY KEY NOT NULL,
	id_ficha INT NOT NULL,
    id_diagnostico INT NOT NULL,
	id_tratamiento INT NOT NULL,
	id_CITA INT NOT NULL,
	descripcion text NOT NULL,
	nivel VARCHAR(20) NOT NULL,
	unidad INT NOT NULL,
	fecha DATETIME NOT NULL,
    tipo_tratamiento VARCHAR(50) NOT NULL,
	observaciones VARCHAR(50)
);
CREATE TABLE consultas (
    id_persona INT PRIMARY KEY NOT NULL,
	id_doctor INT  NOT NULL,
    id_diagnostico INT NOT NULL,
	transcripcion_consulta VARCHAR(50) NOT NULL,
	fecha DATETIME NOT NULL
);
CREATE TABLE usuarios (
    id_usuario INT PRIMARY KEY NOT NULL,
    id_persona INT NOT NULL,
	id_rol INT NOT NULL,
	correo INT NOT NULL,
	telefono VARCHAR (12) NOT NULL
);
CREATE TABLE rol (
    id_rol INT PRIMARY KEY NOT NULL,
	nombre VARCHAR(20) NOT NULL,
	descripcion VARCHAR(50) NOT NULL,
);
CREATE TABLE permisos (
    id_permiso INT PRIMARY KEY NOT NULL,
	id_rol INT NOT NULL,
	nombre VARCHAR(20) NOT NULL
);

-- Crear clave foránea para la tabla
--tratamientos
ALTER TABLE tratamientos ADD CONSTRAINT tratamientoDiagnodtico_FK FOREIGN KEY (id_diagnostico) REFERENCES diagnostico (id_diagnostico);
--cita
ALTER TABLE cita ADD CONSTRAINT citapaciente_FK FOREIGN KEY (id_paciente) REFERENCES paciente (id_persona);
ALTER TABLE cita ADD FOREIGN KEY (id_centro) REFERENCES centro (codigo_centro);
ALTER TABLE cita ADD FOREIGN KEY (id_area) REFERENCES area (id_area);
--ficha clinica
ALTER TABLE fichaclinica ADD FOREIGN KEY (id_paciente) REFERENCES paciente (id_persona);
ALTER TABLE fichaclinica ADD FOREIGN KEY (id_diagnostico) REFERENCES diagnostico (id_diagnostico);
ALTER TABLE fichaclinica ADD FOREIGN KEY (id_tratamiento) REFERENCES tratamientos (id_tratamiento);
ALTER TABLE fichaclinica ADD FOREIGN KEY (id_CITA) REFERENCES cita (id_cita);
--consulta
ALTER TABLE consultas ADD FOREIGN KEY (id_persona) REFERENCES paciente (id_persona);
ALTER TABLE consultas ADD FOREIGN KEY (id_doctor) REFERENCES funcionarios (cedula_funcionario);
--paciente
ALTER TABLE paciente ADD FOREIGN KEY (id_diagnostico) REFERENCES diagnostico (id_diagnostico);
ALTER TABLE paciente ADD FOREIGN KEY (id_citas) REFERENCES cita (id_cita);
ALTER TABLE paciente ADD FOREIGN KEY (id_tratamiento) REFERENCES tratamientos (id_tratamiento);
--funcionario
ALTER TABLE funcionarios ADD FOREIGN KEY (cedula_funcionario) REFERENCES paciente (id_persona);
ALTER TABLE funcionarios ADD FOREIGN KEY (id_centro) REFERENCES centro (codigo_centro);
ALTER TABLE funcionarios ADD FOREIGN KEY (id_area) REFERENCES area (id_area);
--persona
ALTER TABLE persona ADD FOREIGN KEY (id_persona) REFERENCES paciente (id_persona);
ALTER TABLE persona ADD FOREIGN KEY (id_persona) REFERENCES funcionarios (cedula_funcionario);
ALTER TABLE persona ADD FOREIGN KEY (id_lugar) REFERENCES lugar (id_lugar);
--usuario
ALTER TABLE usuarios ADD FOREIGN KEY (id_persona) REFERENCES persona (id_persona);
ALTER TABLE usuarios ADD FOREIGN KEY (id_rol) REFERENCES rol (id_rol);
--rol
/*
ALTER TABLE rol ADD FOREIGN KEY (nombre) REFERENCES rol (nombre);
ALTER TABLE rol ADD FOREIGN KEY (descripcion) REFERENCES rol (descripcion);*/
--permiso
ALTER TABLE permisos ADD FOREIGN KEY (id_rol) REFERENCES rol (id_rol);
--centro
ALTER TABLE centro ADD FOREIGN KEY (id_lugar) REFERENCES lugar (id_lugar);
--area
ALTER TABLE area ADD FOREIGN KEY (id_centro) REFERENCES centro (codigo_centro);
