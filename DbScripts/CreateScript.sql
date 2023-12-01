create table if not exists prova.pedido(
	id serial,
	nome_produto varchar(100) unique,
	celular char(11) unique,
	constraint pk_pedido primary key (id)
);

select * from prova.pedido;


--drop table prova.pedido;