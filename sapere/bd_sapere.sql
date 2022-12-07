CREATE DATABASE bd_sapere
DEFAULT CHARACTER SET utf8
DEFAULT COLLATE utf8_general_ci;

USE bd_sapere;

CREATE TABLE Usuario(
id int AUTO_INCREMENT,
cpf varchar(11) UNIQUE,
nome varchar(100),
email varchar(100) UNIQUE,
senha varchar(100),
tipoUsuario varchar(100),
idade int,
telefone varchar(13),
descricao varchar(300),
cursoDeGraduacao varchar(100),
instituicaoEnsinoSuperior varchar(100),
PRIMARY KEY(id)
) DEFAULT CHARSET = utf8;

CREATE TABLE Evento(
id int AUTO_INCREMENT,
idUsuarioCriador int,
idUsuarioRespondente int,
titulo varchar(100),
descricao varchar(600),
escopoDoEvento varchar(100),
localDeVisualizacao varchar(100),
dataHoraVisualizacao datetime,
link1 varchar(200),
link2 varchar(200),
link3 varchar(200),
resposta varchar(600),
PRIMARY KEY(id),
FOREIGN KEY(idUsuarioCriador) references Usuario(id),
FOREIGN KEY(idUsuarioRespondente) references Usuario(id)
) DEFAULT CHARSET = utf8;

INSERT INTO Usuario (nome, email, senha, tipoUsuario) VALUES
("Usuario Comum", "usuariocomum@gmail.com", "Usu@rio123", "comum");
INSERT INTO Usuario (cpf, nome, email, senha, tipoUsuario, idade, telefone, cursoDeGraduacao, InstituicaoEnsinoSuperior) VALUES
("19736866802", "Usuario Contribuinte", "usuariocontribuinte@gmail.com", "Contribuinte@123", "contribuinte", 33, "21992392654","Biologia", "USP");