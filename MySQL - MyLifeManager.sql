create database mylifemanager;
use mylifemanager;

create table tarefa (
    id int auto_increment primary key,
    titulo varchar(100) not null,
    descricao text,
    data_inicio date,
    data_fim date,
    concluida boolean default false
);

create table categoria (
    id int auto_increment primary key,
    nome varchar(50) not null
);

create table tarefa_categoria (
    tarefa_id int,
    categoria_id int,
    primary key (tarefa_id, categoria_id)
);

alter table tarefa_categoria
    add foreign key (tarefa_id) references tarefa(id) on delete cascade;

alter table tarefa_categoria
    add foreign key (categoria_id) references categoria(id) on delete cascade;