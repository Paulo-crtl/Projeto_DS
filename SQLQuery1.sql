CREATE DATABASE PDS_EAD;
USE PDS_EAD;

CREATE TABLE Usuario (
idUsuario INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100) NOT NULL,
email VARCHAR(100) NOT NULL UNIQUE,
userName VARCHAR(100) NOT NULL UNIQUE,
senha VARCHAR(50) NOT NULL,
tipo VARCHAR(20) NOT NULL,
ativo VARCHAR(10) NOT NULL DEFAULT 'ativo',
CPF VARCHAR(14) NOT NULL UNIQUE);

CREATE TABLE Produto (
IdProduto INT  PRIMARY KEY IDENTITY(1,1),
codBarras VARCHAR(13) NOT NULL UNIQUE,
nome VARCHAR(100) NOT NULL,
produto VARCHAR(200) NOT NULL,
preco FLOAT NOT NULL,
estoque INT NOT NULL,
ativo VARCHAR(10) NOT NULL,
foto VARCHAR(100) NULL);


INSERT INTO Usuario(nome, email, userName, senha, tipo, ativo, CPF)
VALUES('q','e','e','1','adm','inativo','12333547');
INSERT INTO Usuario(nome, email, userName, senha, tipo, ativo, CPF)
VALUES('q','fish','fish','1','funcionario','ativo','12333533');

select*from Usuario;