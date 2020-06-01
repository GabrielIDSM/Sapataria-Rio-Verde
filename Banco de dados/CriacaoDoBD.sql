create database Sapataria;
use Sapataria;
create table Clientes(
	ID int auto_increment primary key,
    Nome varchar(40) not null,
    Pedidos int not null,
    Telefone varchar(20) not null
);
