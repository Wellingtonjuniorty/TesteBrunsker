create database Brunsker;

use Brunsker;

create table Imobiliarias (
CodigoImobiliaria int not null auto_increment,
nomeProprietario varchar(255), 
nomeImobiliaria varchar(255),
primary key (CodigoImobiliaria)
);

create table Imoveis (
CodigoImovel int not null auto_increment,
CodigoImobiliaria int,
cep int,
logradouro varchar(255),
complemento varchar(255),
bairro varchar(255),
localidade varchar(255),
uf varchar(2),
disponibilidade varchar(255),
primary key (CodigoImovel),
FOREIGN KEY(CodigoImobiliaria) references Imobiliarias(CodigoImobiliaria)
);

SELECT * FROM Imobiliarias;
INSERT INTO Imobiliarias (nomeProprietario, nomeImobiliaria) VALUES ('Glaydson Silva', 'GS IMOVEIS');
UPDATE Imobiliarias SET nomeProprietario = 'Jose Silva', nomeImobiliaria = 'JS IMOVEIS' WHERE CodigoImobiliaria = 2;
DELETE FROM Imobiliarias WHERE CodigoImobiliaria = 1;

SELECT * FROM Imoveis;
INSERT INTO Imoveis (CodigoImobiliaria, cep, logradouro, complemento, bairro, localidade, uf, disponibilidade) VALUES (5, 32685082, 'Rua Industrial 47', 'Casa', 'Amazonas', 'Betim', 'MG', 'DISPONÍVEL');
INSERT INTO Imoveis (CodigoImobiliaria, cep, logradouro, complemento, bairro, localidade, uf, disponibilidade) VALUES (5, 32685082, 'Rua Industrial 500', 'Casa', 'Amazonas', 'Betim', 'MG', 'DISPONÍVEL');
INSERT INTO Imoveis (CodigoImobiliaria, cep, logradouro, complemento, bairro, localidade, uf, disponibilidade) VALUES (5, 32685082, 'Rua Industrial 200', 'Casa', 'Amazonas', 'Betim', 'MG', 'DISPONÍVEL');
INSERT INTO Imoveis (CodigoImobiliaria, cep, logradouro, complemento, bairro, localidade, uf, disponibilidade) VALUES (5, 32685082, 'Rua Industrial 250', 'Casa', 'Amazonas', 'Betim', 'MG', 'DISPONÍVEL');
INSERT INTO Imoveis (CodigoImobiliaria, cep, logradouro, complemento, bairro, localidade, uf, disponibilidade) VALUES (5, 32685082, 'Rua Industrial 254', 'Casa', 'Amazonas', 'Betim', 'MG', 'DISPONÍVEL');
UPDATE Imoveis SET CodigoImobiliaria = 5, cep = 32685082, logradouro = 'Rua Industrial 220', complemento = 'Casa', bairro = 'Amazonas', localidade = 'Betim', uf = 'MG', disponibilidade = 'DISPONÍVEL' WHERE CodigoImovel = 1; 
DELETE FROM Imoveis WHERE CodigoImovel = 1 ;