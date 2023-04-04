CREATE DATABASE tuSalud;
use tuSalud;

-- Centro de salud
CREATE TABLE centros(
	codigo_centro INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (50) NOT NULL,
	ubicacion VARCHAR (50) NOT NULL,
	capacidad_maxima INT NOT NULL,
	tipo_centro VARCHAR (20) NOT NULL,--tipo de centro (Hospital, Clínica, EBAIS, estos tipos de centros podrían aumentar si la CCSS define nuevas tipologías
	ID_ubicacion INT NOT NULL
);


--Persona

CREATE TABLE Persona(
	cedula INT PRIMARY KEY NOT NULL,
	nombre VARCHAR(15),
	apellido1 VARCHAR(15),
	apellido2 VARCHAR(15),
	Fecha_nacimiento DATETIME,
	nacionalidad VARCHAR(15),
	ID_Lugar INT NOT NULL,

-- Funcionario
CREATE TABLE funcionario(
	cedula_persona INT PRIMARY KEY,
	tipo_funcionario VARCHAR (50) NOT NULL,
	fecha_ingreso DATE NOT NULL,
	ID_area_trabajo INT  NOT NULL,
	ID_centro INT NOT NULL,

);

-- Pacientes
CREATE TABLE pacientes(
	cedula_paciente INT PRIMARY KEY,
	nombre_completoP VARCHAR (100) NOT NULL,
	fecha_nacimiento DATETIME NOT NULL,
	tipo_sangre VARCHAR (3) NOT NULL,
	nacionalidad VARCHAR (20) NOT NULL,
	lugar_residencia VARCHAR (50) NOT NULL,
	telefono VARCHAR (15) NOT NULL
);

-- Crear tabla de citas
CREATE TABLE citas (
    id_cita INT PRIMARY KEY IDENTITY,
    id_paciente INT NOT NULL,
    id_especialidad INT NOT NULL,
    fecha_cita DATETIME NOT NULL,
    observacion TEXT,
    tipo_cita VARCHAR(10) NOT NULL, -- texto o audio
    estado_cita VARCHAR(20) NOT NULL -- Registrada, Asignada, Realizada, Cancelada
);


-- Crear tabla de bitácora de citas
CREATE TABLE bitacora_citas (
    id_bitacora INT PRIMARY KEY IDENTITY,
    id_cita INT NOT NULL,
    fecha_modificacion DATETIME NOT NULL,
    usuario_modificacion VARCHAR(50) NOT NULL,
    estado_anterior VARCHAR(20) NOT NULL,
    estado_actual VARCHAR(20) NOT NULL
);

-- Crear clave foránea para la tabla de citas
ALTER TABLE citas ADD FOREIGN KEY (id_paciente) REFERENCES pacientes(cedula_paciente);
ALTER TABLE bitacora_citas ADD FOREIGN KEY (id_cita) REFERENCES citas(id_cita);

