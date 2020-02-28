--DML--
USE T_Peoples

INSERT INTO Funcionarios (Nome,Sobrenome)
VALUES ('Catarina','Strada'), ('Tadeu','Vitelli')

INSERT INTO TiposUsuario (Tipos)
VALUES ('Administrador'),('Usuario'),('Funcionario')

INSERT INTO Usuarios (Email,Senha)
VALUES ('catarina@email.com', '132')
, ('tadeu@email','123')