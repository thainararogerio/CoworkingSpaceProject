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