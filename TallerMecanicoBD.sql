create database Mecanica;
use Mecanica;


CREATE TABLE Clientes (
    idCliente INT AUTO_INCREMENT PRIMARY KEY,
    rfc VARCHAR(13) UNIQUE,
    nombre VARCHAR(50),
    apellidoP VARCHAR(50),
    apellidoM VARCHAR(50),
    calle VARCHAR(100),
    numero VARCHAR(10),
    colonia VARCHAR(50),
    cp VARCHAR(5),
    ciudad VARCHAR(50),
    telefono1 VARCHAR(15),
    telefono2 VARCHAR(15),
    telefono3 VARCHAR(15),
    email VARCHAR(100),
    fecha_registro DATE
);



CREATE TABLE Vehiculos (
    num_serie VARCHAR(20) PRIMARY KEY,
    placas VARCHAR(10) NOT NULL,
    marca VARCHAR(50) NOT NULL,
    modelo VARCHAR(50) NOT NULL,
    anio INT NOT NULL,
    color VARCHAR(30),
    kilometraje INT NOT NULL,
    tipo VARCHAR(30),
	antiguedad INT DEFAULT (YEAR(CURRENT_DATE) - anio),
    idcliente INT NOT NULL,
    FOREIGN KEY (idcliente) REFERENCES Clientes(idCliente)
);

CREATE TABLE Mecanicos (
    num_empleado INT AUTO_INCREMENT PRIMARY KEY,
    rfc VARCHAR(13) NOT NULL,
    nombre_completo VARCHAR(150) NOT NULL,
    especialidades VARCHAR(200),
    telefono VARCHAR(20),
    salario DECIMAL(10, 2),
    anios_experiencia INT
);

CREATE TABLE Servicios (
    clave_servicio INT AUTO_INCREMENT PRIMARY KEY,
    nombre_servicio VARCHAR(100) NOT NULL,
    descripcion TEXT,
    costo_base DECIMAL(10, 2) NOT NULL,
    tiempo_estimado INT
);

CREATE TABLE Refacciones (
    codigo_refaccion VARCHAR(20) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    marca VARCHAR(50),
    precio_unitario DECIMAL(10, 2) NOT NULL,
    stock_actual INT NOT NULL,
    stock_minimo INT NOT NULL,
    proveedor VARCHAR(100)
);
CREATE TABLE Ordenes_Servicio (
    folio_orden INT AUTO_INCREMENT PRIMARY KEY,
    fecha_ingreso DATETIME NOT NULL,
    fecha_estimada_entrega DATETIME,
    fecha_real_entrega DATETIME,
    estado ENUM('abierta', 'en proceso', 'finalizada', 'cancelada'),
    costo_total DECIMAL(12, 2),
    num_serie VARCHAR(20) NOT NULL,
    FOREIGN KEY (num_serie) REFERENCES Vehiculos(num_serie)
);

CREATE TABLE Detalle_Orden_Mecanicos (
    folio_orden INT,
    num_empleado INT,
    PRIMARY KEY (folio_orden, num_empleado),
    FOREIGN KEY (folio_orden) REFERENCES Ordenes_Servicio(folio_orden),
    FOREIGN KEY (num_empleado) REFERENCES Mecanicos(num_empleado)
);

CREATE TABLE Detalle_Orden_Servicios (
    folio_orden INT,
    clave_servicio INT,
    PRIMARY KEY (folio_orden, clave_servicio),
    FOREIGN KEY (folio_orden) REFERENCES Ordenes_Servicio(folio_orden),
    FOREIGN KEY (clave_servicio) REFERENCES Servicios(clave_servicio)
);

CREATE TABLE Detalle_Orden_Refacciones (
    folio_orden INT,
    codigo_refaccion VARCHAR(20),
    cantidad INT,
    PRIMARY KEY (folio_orden, codigo_refaccion),
    FOREIGN KEY (folio_orden) REFERENCES Ordenes_Servicio(folio_orden),
    FOREIGN KEY (codigo_refaccion) REFERENCES Refacciones(codigo_refaccion)
);


INSERT INTO Clientes (rfc, nombre, apellidoP, apellidoM, calle, numero, colonia, cp, ciudad, telefono1, email, fecha_registro) VALUES
('GARC850101H01', 'Juan', 'García', 'Pérez', 'Av. Juárez', '123', 'Centro', '06000', 'CDMX', '5512345678', 'juan.garcia@email.com', '2024-01-15'),
('LOMM900510J02', 'María', 'López', 'Martínez', 'Calle 5 de Mayo', '45', 'Norte', '72000', 'Puebla', '2229876543', 'm.lopez@email.com', '2024-02-10'),
('RODR781120K03', 'Ricardo', 'Rodríguez', 'Sánchez', 'Reforma', '1010', 'Condesa', '06140', 'CDMX', '5544332211', 'ric.rod@email.com', '2024-03-05'),
('SANA820814L04', 'Ana', 'Sánchez', 'Alba', 'Hidalgo', '88', 'Zapopan', '45000', 'Guadalajara', '3311223344', 'ana.sanchez@email.com', '2024-03-20'),
('GOMP950325M05', 'Pedro', 'Gómez', 'Prado', 'Insurgentes Sur', '500', 'Roma', '06700', 'CDMX', '5566778899', 'p.gomez@email.com', '2024-04-02');


INSERT INTO Vehiculos (num_serie, placas, marca, modelo, anio, color, kilometraje, tipo, idcliente) VALUES
('VIN123456789ABC01', 'ABC-1234', 'Toyota', 'Corolla', 2020, 'Blanco', 45000, 'Sedán', 1),
('VIN987654321DEF02', 'XYZ-5678', 'Honda', 'Civic', 2018, 'Gris', 75000, 'Sedán', 2),
('VIN456123789GHI03', 'LMN-9012', 'Ford', 'F-150', 2022, 'Negro', 15000, 'Pick-up', 3),
('VIN321654987JKL04', 'QWE-3456', 'Nissan', 'Sentra', 2015, 'Azul', 120000, 'Sedán', 4),
('VIN789456123MNO05', 'RTY-7890', 'Volkswagen', 'Jetta', 2021, 'Rojo', 30000, 'Sedán', 5);

INSERT INTO Mecanicos (rfc, nombre_completo, especialidades, telefono, salario, anios_experiencia) VALUES
('HERR700101H01', 'Roberto Herrera', 'Motores y Transmisiones', '5500112233', 15000.00, 20),
('MART850202J02', 'José Martínez', 'Sistema Eléctrico', '5511223344', 12000.00, 10),
('DIAZ900303K03', 'Carlos Díaz', 'Suspensión y Frenos', '5522334455', 11000.00, 8),
('LUNA920404L04', 'Miguel Luna', 'Afinaciones y Diagnóstico', '5533445566', 10500.00, 5),
('RUIZ880505M05', 'Luis Ruiz', 'Aire Acondicionado', '5544556677', 11500.00, 12);


INSERT INTO Servicios (nombre_servicio, descripcion, costo_base, tiempo_estimado) VALUES
('Afinación Mayor', 'Cambio de aceite, filtros, bujías y limpieza de inyectores', 2500.00, 240),
('Cambio de Frenos', 'Reemplazo de balatas delanteras y rectificado de discos', 1200.00, 120),
('Cambio de Aceite', 'Aceite sintético y filtro de aceite', 850.00, 60),
('Diagnóstico Escáner', 'Lectura de códigos de falla y borrado', 500.00, 45),
('Alineación y Balanceo', 'Ajuste de ángulos de llantas y contrapesos', 700.00, 90);


INSERT INTO Refacciones (codigo_refaccion, nombre, marca, precio_unitario, stock_actual, stock_minimo, proveedor) VALUES
('REF-001', 'Filtro de Aceite', 'Fram', 150.00, 50, 10, 'AutoZone'),
('REF-002', 'Aceite Sintético 5W30', 'Mobil 1', 220.00, 100, 20, 'Lubricantes S.A.'),
('REF-003', 'Balatas Delanteras', 'Brembo', 850.00, 20, 5, 'Frenos de México'),
('REF-004', 'Bujía Iridium', 'NGK', 180.00, 80, 15, 'Refacciones Unidas'),
('REF-005', 'Filtro de Aire', 'Interfil', 120.00, 40, 10, 'AutoZone'),
('REF-006', 'Amortiguador Delantero', 'Monroe', 1200.00, 12, 4, 'Suspensiones King'),
('REF-007', 'Batería 12V', 'LTH', 2500.00, 15, 3, 'Acumuladores Monterrey'),
('REF-008', 'Bomba de Agua', 'Gates', 950.00, 8, 2, 'Refacciones Unidas'),
('REF-009', 'Banda de Distribución', 'Continental', 600.00, 10, 3, 'Bandas S.A.'),
('REF-010', 'Anticongelante Rosa', 'Prestone', 180.00, 30, 10, 'Químicos Automotrices'),
('REF-011', 'Filtro de Cabina', 'Bosch', 250.00, 25, 5, 'Bosch México'),
('REF-012', 'Disco de Freno', 'Wagner', 1100.00, 10, 4, 'Frenos de México'),
('REF-013', 'Sensor de Oxígeno', 'Denso', 1400.00, 5, 2, 'Eléctricos Japoneses'),
('REF-014', 'Limpiaparabrisas', 'Michelin', 300.00, 20, 5, 'Llantas y Accesorios'),
('REF-015', 'Kit de Embrague', 'Luk', 3500.00, 3, 1, 'Transmisiones del Valle');


INSERT INTO Ordenes_Servicio (fecha_ingreso, estado, num_serie) VALUES
(NOW(), 'en proceso', 'VIN123456789ABC01'),
(NOW(), 'abierta', 'VIN987654321DEF02'),
(NOW(), 'finalizada', 'VIN456123789GHI03'),
(NOW(), 'en proceso', 'VIN321654987JKL04'),
(NOW(), 'abierta', 'VIN789456123MNO05');

INSERT INTO Detalle_Orden_Mecanicos (folio_orden, num_empleado) VALUES (1, 1), (2, 2), (3, 3), (4, 4), (5, 5);

INSERT INTO Detalle_Orden_Servicios (folio_orden, clave_servicio) VALUES (1, 1), (2, 2), (3, 3), (4, 4), (5, 5);

INSERT INTO Detalle_Orden_Refacciones (folio_orden, codigo_refaccion, cantidad) VALUES 
(1, 'REF-001', 1), (1, 'REF-002', 5), (2, 'REF-003', 2), (3, 'REF-002', 4), (5, 'REF-005', 1);


ALTER TABLE Servicios ADD COLUMN activo iNT DEFAULT 1;
ALTER TABLE Refacciones ADD COLUMN activo int DEFAULT 1;

select * from Servicios;