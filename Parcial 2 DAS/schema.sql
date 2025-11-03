-- Script para crear la base de datos y las tablas del Sistema de Reservas de Laboratorio
-- Script para crear las tablas del Sistema de Reservas de Laboratorio

-- La base de datos es creada programáticamente por la aplicación si no existe.
-- Este script solo se encarga de crear las tablas.

-- Tabla para almacenar los laboratorios de informática
CREATE TABLE Laboratorios (
    NumeroAsignado INT PRIMARY KEY,
    UbicacionPiso VARCHAR(100) NOT NULL,
    CapacidadPuestos INT NOT NULL
);
GO

-- Tabla para almacenar todas las reservas, tanto cuatrimestrales como eventuales
CREATE TABLE Reservas (
    -- Datos comunes de la reserva
    IdReserva INT PRIMARY KEY IDENTITY(1,1),
    NumeroLaboratorio INT NOT NULL,
    Carrera VARCHAR(150) NOT NULL,
    Asignatura VARCHAR(150) NOT NULL,
    Anio INT NOT NULL,
    Comision VARCHAR(50) NOT NULL,
    Profesor VARCHAR(150) NOT NULL,
    TipoReserva VARCHAR(20) NOT NULL CHECK (TipoReserva IN ('Cuatrimestral', 'Eventual')),

    -- Columnas específicas para Reserva Cuatrimestral (pueden ser NULL)
    FechaHoraComienzo DATETIME NULL,
    FechaHoraFinalizacion DATETIME NULL,
    Frecuencia VARCHAR(15) NULL,

    -- Columnas específicas para Reserva Eventual (pueden ser NULL)
    FechaComienzoEventual DATETIME NULL,
    CantidadSemanas INT NULL,

    -- Constraint para la clave foránea que enlaza con la tabla Laboratorios
    CONSTRAINT FK_Reservas_Laboratorios FOREIGN KEY (NumeroLaboratorio)
        REFERENCES Laboratorios(NumeroAsignado)
);
GO
