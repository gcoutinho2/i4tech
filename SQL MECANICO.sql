SELECT mod.Nome as Carro,car.Ano,mont.Nome as Montadora FROM Carro car INNER JOIN Modelo mod ON car.Id = mod.Id
                    LEFT JOIN Montadora mont ON mont.id = mod.id;

					SELECT * FROM Carro;
					SELECT * FROM Montadora;
					SELECT * FROM Modelo;


					INSERT INTO MODELO (Nome,IdMontadora) VALUES ('Corsa',1);
					INSERT INTO CARRO (ANO, KM, COR, Id_Modelo) VALUES (2012,5000,'VERMELHO',3);

SELECT CAR.ANO, CAR.Id_Modelo, MOD.Nome, CAR.ID
FROM CARRO AS CAR, MODELO AS MOD
JOIN MODELO AS MOD ON MOD.Id = CAR.ID;

SELECT MOD.NOME AS CARRO, CAR.ANO AS ANO, MONT.NOME AS MONTADORA FROM CARRO CAR
INNER JOIN MODELO MOD ON CAR.Id_Modelo = MOD.Id
INNER JOIN MONTADORA MONT ON MOD.IdMontadora = MONT.id;

