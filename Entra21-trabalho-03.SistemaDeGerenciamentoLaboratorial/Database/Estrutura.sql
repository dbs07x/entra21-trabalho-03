CREATE TABLE planos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	abrangencia VARCHAR(12),
	acomodacao VARCHAR(12),
	coparticipacao DECIMAL(5,2),
	preco DECIMAL(6,2)
);

SELECT * FROM planos

CREATE TABLE unidades(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(30),
	cep VARCHAR(8),
	logradouro VARCHAR(30),
	bairro VARCHAR(30),
	cidade VARCHAR(30),
	uf VARCHAR(2)
);

SELECT * FROM unidades

CREATE TABLE medicos (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(30),
	data_nascimento DATETIME2,
	cpf VARCHAR(11),
	crm VARCHAR(6),
	uf VARCHAR(2),
	telefone VARCHAR(11),
	email VARCHAR(30)
);

SELECT * FROM medicos

CREATE TABLE pacientes (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(30),
	data_nascimento DATETIME2,
	cpf VARCHAR(11),
	telefone VARCHAR(11),
	email VARCHAR(30),

	id_plano INTEGER,

	FOREIGN KEY(id_plano) REFERENCES planos(id)
);

SELECT * FROM pacientes

CREATE TABLE exames (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(30),
	preco DECIMAL(7,2),
	instrucoes VARCHAR(50),

	id_medico INTEGER,

	FOREIGN KEY(id_medico) REFERENCES medicos(id)
);

SELECT * FROM exames

CREATE TABLE agendamentos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	preco_exame DECIMAL(7,2),
	data_hora DATETIME2,

	id_paciente INTEGER,
	id_exame INTEGER, 
	id_unidade INTEGER,

	FOREIGN KEY(id_paciente) REFERENCES pacientes(id),
	FOREIGN KEY(id_exame) REFERENCES exames(id),
	FOREIGN KEY(id_unidade) REFERENCES unidades(id)
);

SELECT * FROM agendamentos