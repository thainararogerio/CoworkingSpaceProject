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

select * from equipamento
select * from tp_sala
select * from sala
select * from sala_equipamento

select * from localidade
select * from cliente
select * from reserva

select * from multa

Funcionalidades:
 -1. Cadastros
 -2. Relatórios:
 - 2.1: Reservas de determinada sala em certa data/hora.
 - 2.2: Salas livres em certa data/hora.
 - 2.3: Salas com certo equipamento.
 - 2.4: Clientes que utilizaram a sala na data e hora determinados
 - 2.5: Reservas de determinado cliente.
 - 2.6: Reservas não pagas agrupadas por cliente e ordenadas por valor desc.
 - 2.7: Reservas e suas multas não pagas.
 - 2.8: Soma dos valores das reservas não pagas de determinado cliente.
 - 2.9: Soma dos valores de todas as multas não pagas agrupadas por cliente.
 - 2.10: Clientes de determinada localidade.

 -
 -2.1: 
 -select * from reserva
 -where cd_sala = 1
 -and '2017-01-01 20:00:00.000' between dt_entrada and dt_saida
 -2.2:
 -select * 
 -from sala
 -where cd_sala not in
 -(select cd_sala from reserva
 -where data_info between dt_entrada and dt_saida)
 -2.3:
 -select * 
 -from sala, sala_equipamento
 -where sala.cd_sala = sala_equipamento.cd_sala
 -and sala_equipamento.cd_equipamento = codi_equi
 -2.4:
 -select * 
 -from cliente
 -where cd_cliente in
 -(select cd_cliente 
 -from cliente, reserva
 -where data_info between reserva.dt_entrada and reserva.dt_saida
 -and reserva.cd_sala = codi_sala)
 -2.5:
 -select * from reserva
 -where cd_cliente = codi_cliente
 -2.6:
select cliente.nm_cliente, reserva.vl_reserva
from cliente, reserva
group by cliente.nm_cliente, reserva.cd_cliente, cliente.cd_cliente, reserva.vl_reserva, reserva.fl_pago
having cliente.cd_cliente = reserva.cd_cliente
and reserva.fl_pago = 0
order by reserva.vl_reserva desc
 -2.7:
select reserva.cd_cliente, reserva.cd_sala, reserva.dt_entrada, reserva.vl_reserva, multa.vl_multa
from reserva, multa
where reserva.cd_reserva  in
(select cd_reserva from multa
where dt_pagto is null)
 -2.8: 
select SUM(vl_reserva)
from reserva
where fl_pago=0
and cd_cliente = codigo_cliente
 -2.9:
select cd_cliente, reserva.cd_reserva, SUM(vl_multa)
from reserva, multa
group by cd_cliente, reserva.cd_reserva, multa.cd_reserva, dt_pagto
having dt_pagto is null
and reserva.cd_reserva = multa.cd_reserva
 -2.10:
select * from cliente
where cliente.nr_localidade =
(select nr_localidade from localidade
where nm_localidade='Localidade 1')




Objetivo: informatizar estabelecimentos
utilizados como espaços coworking - espaços compartilhados por pessoas
de diferentes profissões para realizar seus trabalhos. São
estabelecimentos que oferecem uma infra estrutura que o cliente não
teria por si só, com equipamentos de alta qualidade e serviço de café e cozinha.

