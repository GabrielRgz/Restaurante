-- Crear una nueva base de datos
CREATE DATABASE MojodojoDB;
GO

-- Usar la base de datos
USE MojodojoDB;
GO

-- Crear una tabla para los platos del menú
CREATE TABLE Platillos (
    PlatilloID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100),
    Descripcion VARCHAR(255),
    Precio DECIMAL(10, 2),
	Categoria VARCHAR(40)
);

-- Crear una tabla para los clientes
CREATE TABLE Cliente (
    ClienteID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100),
    Email VARCHAR(100),
    Telefono VARCHAR(15)
);


-- Crear una tabla para las cajas
CREATE TABLE Usuario (
    UsuarioID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100)
);

-- Crear una tabla para los pedidos
CREATE TABLE Venta (
    VentaID INT IDENTITY(1,1) PRIMARY KEY,
    ClienteID INT,
    UsuarioID INT, -- Agregar una referencia a la caja
    FechaPedido DATETIME,
    Estado VARCHAR(20),
    FOREIGN KEY (ClienteID) REFERENCES Cliente(ClienteID),
    FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID)
);

-- Crear una tabla para los detalles de los pedidos
CREATE TABLE DetalleVenta (
    DetalleID INT IDENTITY(1,1) PRIMARY KEY,
    VentaID INT,
    PlatilloID INT,
    Cantidad INT,
    FOREIGN KEY (VentaID) REFERENCES Venta(VentaID),
    FOREIGN KEY (PlatilloID) REFERENCES Platillos(PlatilloID)
);

CREATE TABLE Sucursal (
    SucursalID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100)
);

CREATE TABLE Reservacion (
    ReservacionID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100),
    FechaReservada DATETIME,
	SucursalID INT,

	FOREIGN KEY (SucursalID) REFERENCES Sucursal(SucursalID)
);

CREATE TABLE Reservacion_Cliente (
    ReservacionID INT,
    ClienteID INT,
    -- Llaves
    CONSTRAINT PK_Reservacion_Cliente PRIMARY KEY (ReservacionID, ClienteID),

    FOREIGN KEY (ReservacionID) REFERENCES Reservacion(ReservacionID),
    FOREIGN KEY (ClienteID) REFERENCES Cliente(ClienteID)
);
