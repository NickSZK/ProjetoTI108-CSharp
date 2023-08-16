-- Apagando banco de dados
-- DROP DATABASE dbPadariaCarmel;

-- Criando banco de dados;
-- CREATE DATABASE dbPadariaCarmel;

-- Acessando banco de dados
USE dbPadariaCarmel;

-- Criando as tableas
/*CREATE TABLE tbFuncionarios(
	codFunc INT NOT NULL AUTO_INCREMENT,
	nome VARCHAR(100),
	email VARCHAR(100),
	telCel CHAR(15),
	cpf CHAR(14) UNIQUE,
	endereco VARCHAR(100),
	numero VARCHAR(10),
	bairro VARCHAR(100),
	cidade VARCHAR(100),
	estado CHAR(2),
	cep CHAR(9),
	PRIMARY KEY (codFunc)
);*/

-- Inserindo dados na tabela
INSERT INTO tbFuncionarios(nome, email, telCel, cpf, endereco, numero, bairro, cidade, estado, cep) VALUES ('Tonhao Motomoto', 'tonhao@email.com', '(11) 99999-9999', '123.456.789-10', 'Rua Dr. Antônio Bento', '355', 'Santo Amaro', 'São Paulo', 'SP', '04750-000');

DESC tbFuncionarios;

SELECT * FROM tbFuncionarios;
DELETE FROM tbFuncionarios WHERE codFunc != 1;
ALTER TABLE tbfuncionarios AUTO_INCREMENT = 2;