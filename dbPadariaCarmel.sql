-- Apagando banco de dados
-- DROP DATABASE dbPadariaCarmel;

-- Criando banco de dados;
-- CREATE DATABASE dbPadariaCarmel;

-- Acessando banco de dados
USE dbPadariaCarmel;

-- Criando as tableas
CREATE TABLE tbFuncionarios(
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
);

create table tbClientes(
	codCli int not null auto_increment,
	nome varchar(100) not null,
	email varchar(100),
	telCel char(10),
	primary key(codCli)
);

create table tbFornecedores(
	codForn int not null auto_increment,
	nome varchar(100) not null,
	email varchar(100),
	cnpj char(18) not null unique,
	primary key(codForn)
);

CREATE TABLE tbUsuarios (
	codUsu INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    senha VARCHAR(50) NOT NULL,
    codFunc INT NOT NULL,
    FOREIGN KEY (codFunc) REFERENCES tbFuncionarios (codFunc)
);

create table tbProdutos(
	codProd int not null auto_increment,
	descricao varchar(100),
	dataEntrada date,
	horaEntrada time,
	quantidade decimal(9,2),
	valorUnit decimal(9,2),
	codForn int not null,
	primary key(codProd),
	foreign key(codForn) references tbFornecedores(codForn)
);

create table tbVendas(
	codVenda int not null auto_increment,
	codUsu int not null,
	codCli int not null,
	codProd int not null,
	dataVenda date,
	quantidade decimal(9,2),
	valorTotal decimal(9,2),
	primary key(codVenda),
	foreign key(codUsu) references tbUsuarios(codUsu),
	foreign key(codCli) references tbClientes(codCli),
	foreign key(codProd) references tbProdutos(codProd)
);

-- tbFuncionarios
INSERT INTO tbFuncionarios(nome, email, telCel, cpf, endereco, numero, bairro, cidade, estado, cep) VALUES ('Tonhao Motomoto', 'tonhao@email.com', '(11) 99999-9999', '123.456.789-10', 'Rua Dr. Antônio Bento', '355', 'Santo Amaro', 'São Paulo', 'SP', '04750-000');

INSERT INTO tbFuncionarios(nome, email, telCel, cpf, endereco, numero, bairro, cidade, estado, cep) VALUES ('Tonhao', 'tonhao2@email.com', '(11) 99999-9999', '111.111.111-11', 'Rua Dr. Antônio Bento', '355', 'Santo Amaro', 'São Paulo', 'SP', '04750-000');

INSERT INTO tbFuncionarios(nome, email, telCel, cpf, endereco, numero, bairro, cidade, estado, cep) VALUES ('Tonhaozinho', 'tonhaozinho@email.com', '(11) 99999-9999', '111.111.111-12', 'Rua Dr. Antônio Bento', '355', 'Santo Amaro', 'São Paulo', 'SP', '04750-000');

-- UPDATE tbFuncionarios SET nome = @nome, email = @email, telCel = @telCel, cpf = @cpf, endereco = @endereco, numero = @numero, cidade = @cidade, estado = @estado, cep = @cep WHERE condFunc = @codFunc;

DESC tbFuncionarios;
SELECT nome FROM tbFuncionarios WHERE codFunc = 1;
SELECT nome FROM tbFuncionarios WHERE nome LIKE '%a%';
SELECT * FROM tbFuncionarios;
SELECT nome FROM tbFuncionarios WHERE codFunc = 1;
DELETE FROM tbFuncionarios WHERE codFunc != 1;
ALTER TABLE tbfuncionarios AUTO_INCREMENT = 1;

INSERT INTO tbFuncionarios(nome, email, telCel, cpf, endereco, numero, bairro, cidade, estado, cep) VALUES ('SENAC L13', 'senac@email.com', '(11) 99999-9999', '123.456.789-10', 'Rua Dr. Antônio Bento', '355', 'Santo Amaro', 'São Paulo', 'SP', '04750-000');

-- tbUsuarios
INSERT INTO tbUsuarios (nome, senha, codFunc) VALUES ('senac', 'senac', 1);
SELECT * FROM tbUsuarios;
SELECT * FROM tbUsuarios WHERE nome = 'senac' AND senha = 'senac';