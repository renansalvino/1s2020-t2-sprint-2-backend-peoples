--DDL--

Create database T_Peoples

use T_Peoples

create table Funcionarios (
IdFuncionarios INT PRIMARY KEY IDENTITY,
Nome			VARCHAR (255),
Sobrenome		VARCHAR (255)
);
CREATE TABLE Usuarios (
IdUsuarios		INT PRIMARY KEY IDENTITY
,Email			VARCHAR (255)
,Senha			VARCHAR (255)
);
CREATE TABLE TipoUsuario (
IdTipoUsuario		INT PRIMARY KEY IDENTITY
,Tipos_de_usuario		VARCHAR (255)
);

