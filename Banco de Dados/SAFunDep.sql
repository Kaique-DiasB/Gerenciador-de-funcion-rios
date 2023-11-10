create database Sa2;
use Sa2;

-- Usuarios
create table usuarios(
username varchar(50) not null,
pwd varchar(50) not null
);
insert into usuarios (username,pwd) values ('Gestor','master'),('Admin','1234');
select * from usuarios;
SELECT username,pwd FROM usuarios WHERE username = 'Admin';

-- Tabela Auxiliares: Genêros
create table genero (
id int not null auto_increment,
sexo varchar (50) not null,
constraint pk_Sexo primary key (id)
);
insert into genero (sexo) values ('Masculino'),('Feminino');
select * from genero;

-- Tabela Auxiliares: Setores
create table setor(
id int not null auto_increment,
nome varchar (50) not null,
constraint pk_Setor primary key (id)
);
insert into setor (nome) values ('Administrativo'),('Financeiro'),('RH');
select * from setor;

-- Tabelas principais: Funcionarios
create table funcionario(
id int not null auto_increment,
nome varchar (120) not null,
cpf varchar(11) not null,
setorid int not null,
constraint pk_Funcionario primary key (id),
constraint fk_SetorID foreign key (setorid) references setor(id)
);
insert into funcionario (nome,cpf,setorid) values ('Fabricio Mosqueta','01825350612',1),
								('Davidson Gomes','07995998678',2),('Josiane Aparecida','13491831644',3);
select f.id,f.nome,f.cpf,s.nome from funcionario as f left join setor s on f.setorid = s.id WHERE f.nome LIKE  '%Mosqueta%';

-- Tabelas principais: Dependentes
create table dependentes (
id int not null auto_increment,
nome varchar (120) not null,
datanasc datetime not null,
sexoid int not null,
funcionarioid int not null,
constraint pk_Dependentes primary key (id),
constraint fk_Genero foreign key (sexoid) references genero(id)
);
insert into dependentes (nome,datanasc,sexoid,funcionarioid) values ('Artur Mosqueta','2008-10-15',1,1),
								('Ana Beatriz','2013-01-01',2,3), ('Enzo Menezes','2009-09-27',1,2),('Erica Mosqueta','2013-08-01',2,1);
select * from dependentes;
select d.id,d.nome,d.datanasc,d.sexoid,d.funcionarioid,g.id,g.sexo,f.id,f.nome from dependentes as d left join
funcionario as f on d.funcionarioid = f.id left join genero as g on d.sexoid = g.id;
