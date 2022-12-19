Entre no SQL Server e digite o código a seguir:
create database bdcliente
/*Apague a linha de cima e digite o trecho abaixo*/
Use bdCliente
Create table tbCliente // name table - 
(
codCliente int not null primary key,
nome varchar(100),
cpf char(14),
telephone char(13)
);
