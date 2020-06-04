create database Sapataria;
use Sapataria;
create table Clientes(
	ID int auto_increment primary key,
    Nome varchar(40) not null,
    Pedidos int not null,
    Telefone varchar(20) not null
);
create table Vendedores(
	Login varchar(40) primary key,
    Senha varchar(15) not null,
    Vendas int not null
);
create table Adm(
	Login varchar(40) primary key
);
create table Sapatos(
	ID int auto_increment primary key,
    Nome varchar(40) not null,
    Tamanho int not null,
    Quantidade int not null,
    Sexo varchar(20) not null,
    Valor float not null
);
create table Vendas(
	ID int auto_increment primary key,
    Vendedor varchar(40) not null,
    Cliente int not null,
    Valor float not null,
    Dia int not null,
    Mes int not null,
    Ano int not null
);