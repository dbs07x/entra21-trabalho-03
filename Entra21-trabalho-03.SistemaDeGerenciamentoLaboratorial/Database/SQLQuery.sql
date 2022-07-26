CREATE TABLE planos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	abrangencia VARCHAR(12),
	acomodacao VARCHAR(12),
	coparticipacao DECIMAL(5,2),
	preco DECIMAL(6,2));

SELECT * FROM planos