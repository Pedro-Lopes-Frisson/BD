

ALTER TABLE   STOCK.<>                    ADD   CONSTRAINT       <>
ALTER TABLE   STOCK.<>                    ADD   CONSTRAINT       <>

 --
ALTER TABLE   STOCK.<>                    ADD   CONSTRAINT       <>
ALTER TABLE   STOCK.<>                    ADD   CONSTRAINT       <>
ALTER TABLE   STOCK.<>                    ADD   CONSTRAINT       <>
ALTER TABLE   STOCK.<>                    ADD   CONSTRAINT       <>

ALTER TABLE   STOCK.<>                    ADD   CONSTRAINT       <>

DROP TABLE SCHEMA.Armazem
DROP TABLE SCHEMA.Produto
DROP TABLE SCHEMA.Encomenda
DROP TABLE SCHEMA.Fornecedor
DROP TABLE SCHEMA.Tipo


CREATE TABLE SCHEMA.Armazem(
 ID
                                      <>                               not null,
 Produto_codigo
                                      <>                               not null,
 Produto_quantidade
                                      <>                               not null,
primary key (),

);


CREATE TABLE SCHEMA.Produto(
 codigo
                                      <>                               not null,
 nome
                                      <>                               not null,
 preco
                                      <>                               not null,
 iva
                                      <>                               not null,
primary key (),

);


CREATE TABLE SCHEMA.Encomenda(
 numero
                                      <>                               not null,
 data
                                      <>                               not null,
 Produto_codigo
                                      <>                               not null,
 Produto_quantidade
                                      <>                               not null,
 Produto_preco
                                      <>                               not null,
primary key (),

);


CREATE TABLE SCHEMA.Fornecedor(
 NIF
                                      <>                               not null,
 nome
                                      <>                               not null,
 endereco
                                      <>                               not null,
 fax
                                      <>                               not null,
 condicao_de_pagamento
                                      <>                               not null,
Tipo_codigo
                                      <>                               not null,
primary key (),

);


CREATE TABLE SCHEMA.Tipo(
 Codigo
                                      <>                               not null,
 descricao
                                      <>                               not null,
primary key (),

);


ALTER TABLE   STOCK.<>                    ADD   CONSTRAINT       <>        foreign key (Produto_codigo)                REFERENCES          STOCK.<>();
ALTER TABLE   STOCK.<>                    ADD   CONSTRAINT       <>        foreign key (Produto_quantidade)                REFERENCES          STOCK.<>();

 --
ALTER TABLE   STOCK.<>                    ADD   CONSTRAINT       <>        foreign key (Produto_codigo)                REFERENCES          STOCK.<>();
ALTER TABLE   STOCK.<>                    ADD   CONSTRAINT       <>        foreign key (Produto_quantidade)                REFERENCES          STOCK.<>();
ALTER TABLE   STOCK.<>                    ADD   CONSTRAINT       <>        foreign key (Produto_preco)                REFERENCES          STOCK.<>();
ALTER TABLE   STOCK.<>                    ADD   CONSTRAINT       <>        foreign key (Fornecedor_NIF)                REFERENCES          STOCK.<>();

ALTER TABLE   STOCK.<>                    ADD   CONSTRAINT       <>        foreign key (Tipo_codigo)                REFERENCES          STOCK.<>();
