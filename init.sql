-- init.sql

CREATE DATABASE PersonasDB;
GO

USE PersonasDB;
GO

CREATE TABLE Personas (
    Id INT PRIMARY KEY IDENTITY,
    Cedula VARCHAR(20) NOT NULL UNIQUE,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    NumeroCelular VARCHAR(15) NOT NULL
);

-- Insertar datos de prueba
INSERT INTO Personas (Cedula, Nombre, Apellido, NumeroCelular) VALUES
('1234567890', 'Juan', 'Pérez', '555-1234'),
('2345678901', 'María', 'González', '555-5678'),
('3456789012', 'Pedro', 'López', '555-8765'),
('4567890123', 'Ana', 'Martínez', '555-4321'),
('5678901234', 'Luis', 'Hernández', '555-1357'),
('6789012345', 'Sofía', 'García', '555-2468'),
('7890123456', 'Diego', 'Rodríguez', '555-3579'),
('8901234567', 'Lucía', 'Sánchez', '555-4680'),
('9012345678', 'Carlos', 'Ramírez', '555-5791'),
('0123456789', 'Valeria', 'Torres', '555-6802');