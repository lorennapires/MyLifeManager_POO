create database mylifemanager12;

use mylifemanager12;

create table categoria (
    id int auto_increment primary key,
    nome varchar(50) not null,
    cor varchar(20)
);

create table tarefa (
    id int auto_increment primary key,
    titulo varchar(100) not null,
    descricao text,
    data_inicio datetime,
    data_fim datetime,
    concluida boolean default false
);

create table tarefas_categorias (
    tarefa_id int,
    categoria_id int,
    primary key (tarefa_id, categoria_id)
);

alter table tarefas_categorias
    add foreign key (tarefa_id) references tarefa(id) on delete cascade;

alter table tarefas_categorias
    add foreign key (categoria_id) references categoria(id) on delete cascade;

insert into categoria (nome, cor) values
('Trabalho', '#FF5733'),
('Estudos', '#33C1FF'),
('Pessoal', '#85FF33'),
('Saúde', '#FFBD33');

