CREATE DATABASE LibrosDb
GO
USE LibrosDb
GO
CREATE TABLE Libros

(
  TipoId int primary key identity(1,1),
  LibroId int,
  Descripcion varchar(max),
  Siglas varchar(13)
  );