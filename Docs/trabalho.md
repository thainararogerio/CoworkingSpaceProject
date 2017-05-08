Sistema para 

Sistema para espaço coworking.

Cadastros:
Clientes
Equipamentos
Reservas

Tabelas:
tp_equipamento - código, nome
equipamento - código, tipo_equipamento, série
sala - código, nome, tamanho, equipamentos
sala_equipamento - sala, equipamento
cliente - código, nome, telefone, endereço
reserva - cliente, sala, data/hora entrada, data/hora saída 
localidade - nr_localidade, nm_localidade, sg_uf

//criar tabelas de localização, endereço, etc, etc, pra complicar um pouco.


create table equipamento
(
	cd_equipamento int not null primary key,
	nm_equipamento varchar(255)
);

create table tp_sala
(
	cd_tp_sala int not null primary key,
	nm_tp_sala varchar(30),
	tamanho int
);

create table sala
(
	cd_sala int not null primary key,
	cd_tp_sala int not null references tp_sala(cd_tp_sala),
	nm_sala varchar(30),
	observacao varchar(255)
);

create table sala_equipamento
(
	cd_sala int not null references sala(cd_sala),
	cd_equipamento int not null references equipamento(cd_equipamento),
	primary key (cd_sala, cd_equipamento),
	dt_recebido datetime
);

create table localidade
(
	nr_localidade int not null primary key,
	nm_localidade varchar(50),
	sg_uf char(2)
);

create table cliente
(
	cd_cliente int not null primary key,
	nr_localidade int not null references localidade(nr_localidade),
	cd_responsavel int references cliente(cd_cliente),
	nm_cliente varchar(50),
	ds_logradouro varchar(50),
	ds_complemento varchar(30),
	ds_bairro varchar(30),
	nr_telefone_res varchar(12),
	nr_telefone_com varchar(12),
	nr_telefone_cel varchar(12),
	ds_email varchar(50)
);


Funcionalidades:
1. Cadastros
2. Relatórios:
 2.1: Reservas de determinada sala em certa data/hora.
 2.2: Salas livres em certa data/hora.
 2.3: Salas com certo equipamento.
 2.4: Clientes que utilizaram a sala na data e hora determinados
 2.5: Reservas de determinado cliente.
 2.6: Reservas não pagas e o nome do seu cliente, agrupadas por cliente.
 2.7: 
 2.8:
 2.9:
 2.10:

2.1: 
select * from reserva
where cd_sala = codi_sala
and data_info between dt_entrada and dt_saida
2.2:
select * 
from sala
where cd_sala not in
(select cd_sala from reserva
where data_info between dt_entrada and dt_saida)
2.3:
select * 
from sala, sala_equipamento
where sala.cd_sala = sala_equipamento.cd_sala
and sala_equipamento.cd_equipamento = codi_equi
2.4:
select * 
from cliente
where cd_cliente in
(select cd_cliente 
from cliente, reserva
where data_info between reserva.dt_entrada and reserva.dt_saida
and reserva.cd_sala = codi_sala)
2.5:
select * from reserva
where cd_cliente = codi_cliente
2.6:
select cd_reserva, cd_sala, dt_entrada, dt_saida, vl_pago, cliente.nm_cliente
from reserva, cliente
group by cd_cliente
having fl_pago = 0 
and reserva.cd_cliente = cliente.cd_cliente
2.7:

2.8:
2.9:
2.10:


create table reserva
(
	cd_reserva int not null primary key,
	cd_cliente int not null references cliente(cd_cliente),
	cd_sala int not null references sala(cd_sala),
	dt_entrada datetime,
	dt_saida datetime,
	vl_reserva numeric(8,2),
	fl_pago char(1)
);

create table multa
(
	cd_multa int not null primary key,
	cd_reserva int not null references reserva(cd_reserva),
	vl_multa numeric(8,2),
	dt_pagto datetime
);

select * from tp_equipamento
select * from equipamento
select * from tp_sala
select * from sala
select * from sala_equipamento

select * from localidade
select * from cliente
select * from reserva

select * from multa


Objetivo: informatizar estabelecimentos
utilizados como espaços coworking - espaços compartilhados por pessoas
de diferentes profissões para realizar seus trabalhos. São
estabelecimentos que oferecem uma infra estrutura que o cliente não
teria por si só, com equipamentos de alta qualidade e serviço de café e cozinha.

