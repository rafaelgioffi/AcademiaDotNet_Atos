use atosUfn

CREATE TABLE Fornecedores
(
FornId INT PRIMARY KEY IDENTITY,
FornNome VARCHAR(60) NOT NULL,
FornCnpj VARCHAR(18)
)

CREATE TABLE Clientes
(
CliId INT PRIMARY KEY IDENTITY,
CliNome VARCHAR(60) NOT NULL,
CliTel VARCHAR(14)
)

CREATE TABLE Produtos
(
ProdId INT PRIMARY KEY IDENTITY,
FornId INT NOT NULL,
ProdNome VARCHAR(50) NOT NULL,
ProdDesc TEXT,
ProdValUnit DECIMAL(10,2) NOT NULL,
ProdQuant INT NOT NULL

FOREIGN KEY (FornId) REFERENCES Produtos (ProdId)
)

CREATE TABLE Notas
(
NotId VARCHAR(30) PRIMARY KEY,
NotInfo VARCHAR(200),
NotDataHora DATETIME,
NotTipo VARCHAR(6),
CliId INT,
ProdId INT,

FOREIGN KEY (CliId) REFERENCES Clientes (CliId),
FOREIGN KEY (ProdId) REFERENCES Produtos (ProdId)
)

INSERT INTO Fornecedores(FornNome, FornCnpj) VALUES ('Zé das Candongas LTDA', '01.234.567/0008-90')
INSERT INTO Clientes (CliNome, CliTel) VALUES ('Joãozinho', '(51)99988-7766')
INSERT INTO Produtos (FornId, ProdNome, ProdDesc, ProdValUnit, ProdQuant) VALUES (1, 'Pacote Figurinhas da Copa do Mundo', 'Pacote unitário de figurinhas da copa do mundo 2022 no Qatar', 4.00, 2500)
INSERT INTO Notas VALUES ('1611202215280511','Venda de um lote de figurinhas', '16-11-2022 15:27:05','Venda', 1, 1)
