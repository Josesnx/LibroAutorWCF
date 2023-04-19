CREATE DATABASE JSanchezLibro
USE JSanchezLibro
GO

CREATE TABLE Autor(
	IdAutor INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(50),
	ApellidoPaterno VARCHAR(50),
	ApellidoMaterno VARCHAR(50)
)
GO

CREATE TABLE Libro(
	IdLibro INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(50),
	FechaPublicacion DATE,
	NumeroPaginas INT,
	IdAutor INT
	CONSTRAINT fk_LibroAutor FOREIGN KEY (IdAutor) REFERENCES Autor(IdAutor)
)
GO

CREATE PROCEDURE LibroAdd
@Nombre VARCHAR(50),
@FechaPublicacion VARCHAR(50),
@NumeroPaginas INT,
@IdAutor INT
AS
INSERT INTO Libro(Nombre,FechaPublicacion,NumeroPaginas,IdAutor)VALUES(@Nombre,CONVERT(DATE,@FechaPublicacion,105),@NumeroPaginas,@IdAutor)
GO

CREATE PROCEDURE LibroUpdate
@IdLibro INT,
@Nombre VARCHAR(50),
@FechaPublicacion VARCHAR(20),
@NumeroPaginas INT,
@IdAutor INT
AS
UPDATE Libro
SET
Nombre=@Nombre,
FechaPublicacion=CONVERT(DATE,@FechaPublicacion,105),
NumeroPaginas=@NumeroPaginas,
IdAutor=@IdAutor
WHERE IdLibro=@IdLibro
GO

CREATE PROCEDURE LibroDelete
@IdLibro INT
AS
DELETE FROM Libro WHERE IdLibro=@IdLibro
GO

CREATE PROCEDURE LibroGetAll
AS
SELECT IdLibro,Libro.Nombre,FechaPublicacion,NumeroPaginas,Autor.IdAutor,Autor.Nombre AS Autor FROM Libro
INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor
GO

CREATE PROCEDURE LibroGetById
@IdLibro INT
AS
SELECT IdLibro,Libro.Nombre,FechaPublicacion,NumeroPaginas,Autor.IdAutor,Autor.Nombre AS Autor FROM Libro
INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor
WHERE IdLibro=@IdLibro
GO

CREATE PROCEDURE AutorAdd
@Nombre VARCHAR(50),
@ApellidoPaterno VARCHAR(50),
@ApellidoMaterno VARCHAR(50)
AS
INSERT INTO Autor(Nombre,ApellidoPaterno,ApellidoMaterno)VALUES(@Nombre,@ApellidoPaterno,@ApellidoMaterno)
GO

CREATE PROCEDURE AutorUpdate
@IdAutor INT,
@Nombre VARCHAR(50),
@ApellidoPaterno VARCHAR(50),
@ApellidoMaterno VARCHAR(50)
AS
UPDATE Autor
SET
Nombre=@Nombre,
ApellidoPaterno=@ApellidoPaterno,
ApellidoMaterno=@ApellidoMaterno
WHERE IdAutor=@IdAutor
GO

CREATE PROCEDURE AutorDelete
@IdAutor INT
AS
DELETE FROM Autor WHERE IdAutor=@IdAutor
GO

CREATE PROCEDURE AutorGetAll
AS
SELECT IdAutor,Nombre,ApellidoPaterno,ApellidoMaterno FROM Autor
GO

CREATE PROCEDURE AutorGetById
@IdAutor INT
AS
SELECT IdAutor,Nombre,ApellidoPaterno,ApellidoMaterno FROM Autor
WHERE IdAutor=@IdAutor
GO
