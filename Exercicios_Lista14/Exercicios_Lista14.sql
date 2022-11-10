create database empresa_db;
use empresa_db;

create table Departamento(
idDepartamento int primary key identity,
nome varchar(30),
localizacao varchar(50),
orcamento decimal(10,2)
)

create table Empregado
(
idEmpregado int primary key,
nome varchar(50) not null,
idGerente int,
funcao varchar(30),
idDepartamento int,
dataAdmissao date,
salario money not null,
comissao money,

foreign key (idDepartamento) references Departamento(idDepartamento),
foreign key (idGerente) references Empregado(idEmpregado)
)

INSERT INTO Departamento VALUES('Banco de Dados','Porto Alegre','2346');
INSERT INTO Departamento VALUES('Balconistas','Pelotas','10000');
INSERT INTO Departamento VALUES('Inteligência Artific','Pelotas','333');
INSERT INTO Departamento VALUES('Compiladores','Novo Hamburgo','5050');
INSERT INTO Departamento VALUES('Redes','Taquara','12122');

INSERT INTO Empregado VALUES('1','Mariewa',NULL,'Gerente','1','2000-04-05','2300','0');
INSERT INTO Empregado VALUES('2','Zico','1','Operário','1','1999-08-13','100','0');
INSERT INTO Empregado VALUES('3','Lula',NULL,'Presidente','5','1950-01-01','10000','0');
INSERT INTO Empregado VALUES('5','Luana Pyovany',NULL,'Gerente','2','1998-06-23','2300','0');
INSERT INTO Empregado VALUES('4','Vera Fixer','5','Balconista','2','1999-05-05','3300','0');
INSERT INTO Empregado VALUES('6','Daniela Schicarelli',NULL,'Gerente','3','1999-10-10','2300','0');
INSERT INTO Empregado VALUES('7','Luize Altenhofen',NULL,'Gerente','4','1999-04-26','2300','0');
INSERT INTO Empregado VALUES('8','Helo Pinheiro',NULL,'Gerente','5','1997-09-25','2300','0');
INSERT INTO Empregado VALUES('9','Pelé','1','Operário','1','2000-09-09','100',NULL);
INSERT INTO Empregado VALUES('10','Romário','1','Operário','5','2001-12-25','100','0');
INSERT INTO Empregado VALUES('11','Malu Mader','5','Balconista','2','2001-10-20','3400','0');
INSERT INTO Empregado VALUES('12','Antônio Fagundes','7','Vendedor','3','2002-12-22','5000','10');

update Empregado set comissao = NULL where comissao = '0';

select * from Departamento;
select * from Empregado;

-- Selecione todos os departamentos cujo orçamento mensal
--seja maior que 10000. Apresente o Nome de tal departamento
--e seu orçamento anual, que será obtido multiplicando-se o
--orçamento mensal por 12.
select nome, (orcamento*12) 'Orçamento Anual' from Departamento where orcamento > 10000;

-- Apresente a instrução anterior porém ao invés dos
--'feios' DepNome e DepOrca, os Títulos Departamento e Orçamento.
select nome 'Departamento', orcamento 'Orçamento' from Departamento;

-- Apresente todos os cargos existentes na empresa,
-- porém omita eventuais duplicidades.
select distinct funcao from Empregado;

-- Apresente os nomes e funções da cada funcionário contidos
--na tabela empregado, porém classificados alfabeticamente (A..Z)
--e depois alfabeticamente invertido (Z..A).
select nome, funcao from Empregado order by nome;
select nome, funcao from Empregado order by nome desc;

-- Demais Operadores
        --
        --Operador                  significado
        --between  ...  and ...     entre dois valores ( inclusive )
        --in ( .... )               lista de valores
        --like                      com um padrao de caracteres
        --is null                   é um valor nulo
select nome, funcao from Empregado where idEmpregado between 1 and 5;
select nome from Empregado where funcao Like 'Operário';

 -- Operadores Negativos
        --
        --operador               descrição
        --<>                     diferente
        --not nome_coluna =      diferente da coluna
        --not nome_coluna >      não maior que
        --not between            não entre dois valores informados
        --not in                 não existente numa dada lista de valores
        --not like               diferente do padrao de caracteres informado
        --is not null            não é um valor nulo
select * from Empregado where funcao not like 'Gerente';

-- Selecione os Empregados cujos salários sejam
--menores que 1000 ou maiores que 3500.
select nome, funcao, salario from Empregado where salario < 1000 or salario > 3500;

-- Apresente todos os funcionários com salários
--entre 3400 e 4000 e que sejam balconistas.
select * from Empregado where (salario between 3400 and 4000) and funcao = 'Balconista';

-- Apresente o nome de todos os empregados em letras minúsculas.
select lower(nome) from Empregado;
select upper(nome) from Empregado;

-- Apresente o nome de todos os empregados (somente as 5 primeiras letras).
select substring(nome,0,6) from Empregado;

-- Apresente a Média, o Maior, o Menor e também a Somatória
--dos Salários pagos aos empregados.
select avg(salario) 'Média', max(salario) 'Maior Salário', min(salario) 'Menor Salário', sum(salario) 'Soma de todos os salários' from Empregado;

-- Apresente a média de comissão pagos por departamento.
select avg(comissao) 'Média das Comissões', Departamento.nome from Empregado, Departamento 
where Empregado.idDepartamento = Departamento.idDepartamento
group by Departamento.nome;

--  Retome o problema anterior, porém apresente resposta
--apenas para departamentos com mais de 2 empregados.
select avg(comissao) 'Média das Comissões', Departamento.nome from Empregado, Departamento 
where Empregado.idDepartamento = Departamento.idDepartamento
group by Departamento.nome
having count(Empregado.funcao) > 2;

-- Listar Nomes de Empregados, Cargos e
--Nome do Departamento onde o empregado trabalha.
select Empregado.nome 'Nome', Empregado.funcao 'Cargo', Departamento.nome 'Departamento' from Empregado, Departamento
where Empregado.idDepartamento = Departamento.idDepartamento;

-- Liste os Códigos de Cada Funcionário, seus Nomes, seus Cargos
--e o nome do Gerente ao qual este se relaciona.
select * from Empregado
select A.idEmpregado 'Código', A.nome, A.funcao 'Cargo', B.nome 'Nome do Gerente'
from Empregado A, Empregado B
where A.idGerente = B.idEmpregado;

-- execute e avalie os comandos
-- INSERT
INSERT INTO Departamento (nome, localizacao, orcamento) VALUES ('PRODUCAO','RIO DE JANEIRO','1200');

-- UPDATE
update Empregado set salario = salario * 1.2
where salario < 1000;

delete from Empregado where salario > 5000;

select * from Empregado
select * from Departamento
-- Relacione todos os nomes de funcionários e seus respectivos
--cargos, desde que o orçamento do departamento seja igual a 10000.
select Empregado.nome, Empregado.funcao from Empregado, Departamento
where Departamento.orcamento = 10000 and Empregado.idDepartamento = Departamento.idDepartamento;

-- Relacione todos os departamentos que possuem
--empregados com remuneração maior que 3000.
select distinct Departamento.nome from Empregado, Departamento
where Empregado.salario > 3000 and Empregado.idDepartamento = Departamento.idDepartamento;
