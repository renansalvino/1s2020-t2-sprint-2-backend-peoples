--DDL--

Create database T_Peoples

use T_Peoples

create table Funcionarios (
IdFuncionarios INT PRIMARY KEY IDENTITY,
Nome			VARCHAR (255),
Sobrenome		VARCHAR (255)
);
<<<<<<< HEAD
=======

CREATE TABLE TiposUsuario (
IdTiposUsuarios		INT PRIMARY KEY IDENTITY
,Tipos		VARCHAR (255)
);

>>>>>>> 98381161094f18fe6eda70c12c3e712475e3fd0d
CREATE TABLE Usuarios (
IdUsuarios		INT PRIMARY KEY IDENTITY
,Email			VARCHAR (255)
,Senha			VARCHAR (255)
);
<<<<<<< HEAD
CREATE TABLE TipoUsuario (
IdTipoUsuario		INT PRIMARY KEY IDENTITY
,Tipos_de_usuario		VARCHAR (255)
);

=======

SELECT*FROM TiposUsuario

ALTER TABLE TiposUsuario
ADD  Tipos	VARCHAR (255)

-- USE T_Peoples;   
-- GO  
-- EXEC sp_rename 'Usuario', 'Usuarios'
>>>>>>> 98381161094f18fe6eda70c12c3e712475e3fd0d
