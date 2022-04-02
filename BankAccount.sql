create database bankAccount;
use bankAccount;

create table Account(
	id int primary key auto_increment,
    agency int,
    start_account date,
    number_account integer, 
    balance double(10,2)
);
select * from Account;
create table Conta_Poupanca(
	id_conta_poupanca int primary key auto_increment,
    tipo varchar(25),
    tax decimal(10,2),
    id_account int,
    foreign key (id_account) references Account(id) on delete cascade
);
create table Conta_Corrente(
	id_conta_Corrente int primary key auto_increment,
    tipo varchar(25),
    id_account int,
    foreign key (id_account) references Account(id)  on delete cascade
);

insert into Account (agency, start_account, number_account, balance)
values (231, '2020-02-10', 211, 2500);
insert into Account (agency, start_account, number_account, balance)
values (312, '2020-02-10', 213, 500);
insert into Account (agency, start_account, number_account, balance)
values (421, '2020-02-10', 215, 5000);

insert into Conta_Poupanca(tipo, tax, id_account) 
values ('comum', 0.06, 1);
insert into Conta_Poupanca(tipo, tax, id_account) 
values ('comum', 0.06, 2);
insert into Conta_Poupanca(tipo, tax, id_account) 
values ('comum', 0.08, 3);


insert into Conta_Poupanca(tipo,  id_account) 
values ('especial',  1);
insert into Conta_Poupanca(tipo,  id_account) 
values ('premium',  2);
insert into Conta_Poupanca(tipo, id_account) 
values ('comum',  3);