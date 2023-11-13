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
	Rol int not null,
    NombreUsuario VARCHAR(30) not null,
	Contrasena VARCHAR(30) not null,
	Nombre VARCHAR(100),
	Apellido VARCHAR(50)
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




----------------------------------------
-- PROCEDIMIENTOS DE CONSULTA
-----------------------------------------

CREATE PROCEDURE dbo.ConsultarPlatillos
AS
BEGIN
    SELECT * FROM Platillos;
END;
GO
-----------------------------------------
CREATE PROCEDURE dbo.ConsultarClientes
AS
BEGIN
	SELECT * FROM Cliente;
END;
GO
-----------------------------------------
CREATE PROCEDURE dbo.ConsultarUsuarios
AS
BEGIN
    SELECT * FROM Usuario;
END;
GO
-----------------------------------------

CREATE PROCEDURE dbo.ConsultarVentas
AS
BEGIN
    SELECT * FROM Venta;
END;
GO
-----------------------------------------

CREATE PROCEDURE dbo.ConsultarSucursales
AS
BEGIN
    SELECT * FROM Sucursal;
END;
GO
-----------------------------------------
CREATE PROCEDURE dbo.ConsultarReservaciones
AS
BEGIN
    SELECT * FROM Reservacion;
END;
GO

-----------------------------------------
CREATE PROCEDURE dbo.ConsultarDetalleVenta
AS
BEGIN
    SELECT * FROM DetalleVenta;
END;
GO

-----------------------------------------
CREATE PROCEDURE dbo.ConsultarReservacion_Cliente
AS
BEGIN
    SELECT * FROM Reservacion_Cliente;
END;
GO

----------------------------------------
-- PROCEDIMIENTOS DE INSERCION
-----------------------------------------
CREATE PROCEDURE dbo.InsertarPlatillos
@Nombre VARCHAR(100), @Descripcion VARCHAR(255), @Precio DECIMAL(10, 2), @Categoria VARCHAR(40)
AS
BEGIN
    INSERT INTO  Platillos (Nombre, Descripcion, Precio, Categoria)
	VALUES	(@Nombre, @Descripcion, @Precio, @Categoria)
END;
GO

-- Ejemplo
-- EXEC dbo.InsertarPlatillos 'Tacos de Asada', 'Taco de carne de res asada', 18.50, 'mexicana'
-- EXEC dbo.ConsultarPlatillos
-----------------------------------------
CREATE PROCEDURE dbo.InsertarClientes
@Nombre VARCHAR(100), @Email VARCHAR(100), @Telefono VARCHAR(15)
AS
BEGIN
	INSERT INTO Cliente (Nombre, Email, Telefono)
		VALUES (@Nombre, @Email, @Telefono)
END;
GO

-- Ejemplo
-- EXEC dbo.InsertarClientes 'Cliente 1', 'juan@gmail.com', '6642652915'
-- EXEC dbo.ConsultarClientes
-----------------------------------------
CREATE PROCEDURE dbo.InsertarUsuarios
@Rol int, @NombreUsuario VARCHAR(30), @Contrasena VARCHAR(30), @Nombre VARCHAR(100), @Apellido VARCHAR(50)
AS
BEGIN
    INSERT INTO Usuario (Rol, NombreUsuario, Contrasena, Nombre, Apellido)
	VALUES (@Rol, @NombreUsuario, @Contrasena, @Nombre, @Apellido)
END;
GO

-- Ejemplo
-- EXEC dbo.InsertarUsuarios 2, 'Usuario 2', 'password123', 'Amy', 'lee'
-- EXEC dbo.ConsultarUsuarios
-----------------------------------------

CREATE PROCEDURE dbo.InsertarVentas
@ClienteID INT, @UsuarioID INT, @FechaPedido DATETIME, @Estado VARCHAR(20)
AS
BEGIN
    INSERT INTO Venta (ClienteID, UsuarioID, FechaPedido, Estado) VALUES (@ClienteID, @UsuarioID, @FechaPedido, @Estado);
END;
GO

-- Ejemplo
-- EXEC dbo.InsertarVentas 1, 1, '2023-11-12 21:45:56', 'Listo'
-- EXEC dbo.ConsultarVentas

-- Nota: DEBERIA DE USAR FUNCIÓN: SELECT GETDATE()
-----------------------------------------

CREATE PROCEDURE dbo.InsertarSucursales
@Nombre VARCHAR(100)
AS
BEGIN
    INSERT INTO Sucursal (Nombre)
	VALUES (@Nombre)
END;
GO

-- Ejemplo
-- EXEC dbo.InsertarSucursales 'Sucursal 1'
-- EXEC dbo.ConsultarSucursales
-----------------------------------------
CREATE PROCEDURE dbo.InsertarReservaciones
@Nombre VARCHAR(100), @FechaReservada DATETIME, @SucursalID INT
AS
BEGIN
    INSERT INTO Reservacion (Nombre, FechaReservada, SucursalID) 
	VALUES (@Nombre, @FechaReservada, @SucursalID);
END;
GO
-- Ejemplo
-- EXEC dbo.InsertarReservaciones 'Reservación 1', '2023-11-12 21:45:56', '1'
-- EXEC dbo.ConsultarSucursales

-----------------------------------------
CREATE PROCEDURE dbo.InsertarDetalleVenta
@VentaID INT, @PlatilloID INT, @Cantidad INT
AS
BEGIN
    INSERT INTO DetalleVenta (VentaID, PlatilloID, Cantidad)
		VALUES (@VentaID, @PlatilloID, @Cantidad);
END;
GO
-- Ejemplo
-- EXEC dbo.InsertarDetalleVenta 1, 1, 3
-- EXEC dbo.ConsultarDetalleVenta

-----------------------------------------
CREATE PROCEDURE dbo.InsertarReservacion_Cliente
@ReservacionID INT, @ClienteID INT
AS
BEGIN
    INSERT INTO Reservacion_Cliente (ReservacionID, ClienteID) VALUES (@ReservacionID, @ClienteID);
END;
GO
-- Ejemplo
-- EXEC dbo.InsertarReservacion_Cliente 1, 1
-- EXEC dbo.ConsultarReservacion_Cliente



INSERT INTO Usuario(Rol, NombreUsuario, Contrasena) values(1, 'admin', '999')
select * from Usuario
