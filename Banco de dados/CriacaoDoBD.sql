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
    