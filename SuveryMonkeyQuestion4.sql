/*First Step Create Tables */
CREATE TABLE alunos (
id INTEGER NOT NULL PRIMARY KEY,
nome VARCHAR(200),
valor INTEGER
);

CREATE TABLE notas (
nota INTEGER NOT NULL PRIMARY KEY,
valor_min INTEGER,
valor_max INTEGER
);

/* Populate Table notas with range values */
INSERT INTO notas (nota,valor_min,valor_max) VALUES (1,0,9);
INSERT INTO notas (nota,valor_min,valor_max) VALUES (2,10,19);
INSERT INTO notas (nota,valor_min,valor_max) VALUES (3,20,29);
INSERT INTO notas (nota,valor_min,valor_max) VALUES (4,30,39);
INSERT INTO notas (nota,valor_min,valor_max) VALUES (5,40,49);
INSERT INTO notas (nota,valor_min,valor_max) VALUES (6,50,59);
INSERT INTO notas (nota,valor_min,valor_max) VALUES (7,60,69);
INSERT INTO notas (nota,valor_min,valor_max) VALUES (8,70,79);
INSERT INTO notas (nota,valor_min,valor_max) VALUES (9,80,89);
INSERT INTO notas (nota,valor_min,valor_max) VALUES (10,90,100);

/* Populate Table Alunos with input values */

INSERT INTO alunos (id,nome,valor) VALUES (1,'Julia',88);
INSERT INTO alunos (id,nome,valor) VALUES (2,'Carol',68);
INSERT INTO alunos (id,nome,valor) VALUES (3,'Maria',99);
INSERT INTO alunos (id,nome,valor) VALUES (4,'Andreia',78);
INSERT INTO alunos (id,nome,valor) VALUES (5,'Jaqueline',63);
INSERT INTO alunos (id,nome,valor) VALUES (6,'Marcela',81);


/* Query to return the data order by Nota and Nome */

SELECT 	CASE 
		WHEN n.nota < 8 THEN 
			NULL
		ELSE
			a.nome
		END nome,
		n.nota,
		a.valor
FROM 	notas n,alunos a 
WHERE 	a.valor BETWEEN n.valor_min AND n.valor_max
ORDER BY n.nota DESC,nome ASC;
