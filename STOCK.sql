CREATE SCHEMA STOCK
go

ALTER TABLE   STOCK.Armazem                    DROP   CONSTRAINT       arProdutoCodigo        
ALTER TABLE   STOCK.Armazem                    DROP   CONSTRAINT       arProdutoQuantidade                    

 --
ALTER TABLE   STOCK.Encomenda                    DROP   CONSTRAINT       encProdutoCodigo                     
ALTER TABLE   STOCK.Encomenda                    DROP   CONSTRAINT       encProdutoQuantidade                 
ALTER TABLE   STOCK.Encomenda                    DROP   CONSTRAINT       encProdutoPreco                      
ALTER TABLE   STOCK.Encomenda                    DROP   CONSTRAINT       encFornecedorNIF                     

ALTER TABLE   STOCK.Fornecedor                    DROP   CONSTRAINT       fornTipoCodigo                      


DROP TABLE SCHEMA STOCK.Armazem
DROP TABLE SCHEMA STOCK.Produto
DROP TABLE SCHEMA STOCK.Encomenda
DROP TABLE SCHEMA STOCK.Fornecedor
DROP TABLE SCHEMA STOCK.Tipo


CREATE TABLE SCHEMA.Armazem(
 ID                                   varchar(128)                               not null,
 Produto_codigo                       int                               ,
 Produto_quantidade                   int                               ,
primary key (ID),

);


CREATE TABLE SCHEMA.Produto(
 codigo                               int                                 not null,
 nome                                 varchar(30)                         not null,
 preco                                float                               not null,
 iva                                  float                               ,
primary key (codigo),

);


CREATE TABLE SCHEMA.Encomenda(
 numero                             int                               not null,
 data_encomenda                     date                               not null,
 Produto_codigo                     int                               not null,
 Produto_quantidade                 int                               not null,
 Produto_preco                      float                               not null,
primary key (numero),

);


CREATE TABLE SCHEMA.Fornecedor(
 NIF                                int(9)                               not null,
 nome                               varchar(30)                               not null,
 endereco                           varchar(30)                               not null,
 fax                                varchar(30)                               ,
 condicao_de_pagamento              varchar(128)                               ,
 Tipo_codigo                        varchar(128)                                not null,
primary key (NIF),

);


CREATE TABLE SCHEMA.Tipo(
 codigo                             varchar(128)                               not null,
 descricao                          varchar(256)                               ,
primary key (codigo),
);


ALTER TABLE   STOCK.Armazem                    ADD   CONSTRAINT       arProdutoCodigo        foreign key (Produto_codigo)                REFERENCES          STOCK.Produto();
ALTER TABLE   STOCK.Armazem                    ADD   CONSTRAINT       arProdutoQuantidade        foreign key (Produto_quantidade)                REFERENCES          STOCK.Produto();

 --
ALTER TABLE   STOCK.Encomenda                    ADD   CONSTRAINT       encProdutoCodigo        foreign key (Produto_codigo)                REFERENCES          STOCK.Produto();
ALTER TABLE   STOCK.Encomenda                    ADD   CONSTRAINT       encProdutoQuantidade        foreign key (Produto_quantidade)                REFERENCES          STOCK.Produto();
ALTER TABLE   STOCK.Encomenda                    ADD   CONSTRAINT       encProdutoPreco        foreign key (Produto_preco)                REFERENCES          STOCK.Produto();
ALTER TABLE   STOCK.Encomenda                    ADD   CONSTRAINT       encFornecedorNIF        foreign key (Fornecedor_NIF)                REFERENCES          STOCK.Fornecedor();

ALTER TABLE   STOCK.Fornecedor                    ADD   CONSTRAINT       fornTipoCodigo        foreign key (Tipo_codigo)                REFERENCES          STOCK.Tipo();
