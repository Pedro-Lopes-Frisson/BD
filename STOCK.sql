--CREATE SCHEMA STOCK
go

ALTER TABLE   STOCK.Armazem                    DROP   CONSTRAINT       arProdutoCodigo        
--ALTER TABLE   STOCK.Armazem                    DROP   CONSTRAINT       arProdutoQuantidade                    
ALTER TABLE   STOCK.Encomenda                  DROP   CONSTRAINT       encProdutoCodigo                     
--ALTER TABLE   STOCK.Encomenda                  DROP   CONSTRAINT       encProdutoPreco                      
--ALTER TABLE   STOCK.Encomenda                  DROP   CONSTRAINT       encFornecedorNIF                     
--ALTER TABLE   STOCK.Fornecedor                 DROP   CONSTRAINT       fornTipoCodigo                      
go

DROP TABLE STOCK.Armazem
DROP TABLE STOCK.Produto
DROP TABLE STOCK.Encomenda
DROP TABLE STOCK.Fornecedor
DROP TABLE STOCK.Tipo
go

CREATE TABLE STOCK.Armazem(
 ID                                   varchar(128)                               not null,
 quantidade_produto_ar                int                               ,
 Produto_codigo                       int                               ,
primary key (ID),

);
go

CREATE TABLE STOCK.Produto(
 codigo                               int                                 not null,
 nome                                 varchar(30)                         not null,
 preco                                float                               not null,
 iva                                  float                               ,
primary key (codigo),

);
go

CREATE TABLE STOCK.Encomenda(
 numero                             int                               not null,
 data_encomenda                     date                               not null,
 quantidade_produto		            int                               not null,
 Produto_codigo                     int                               not null,
 Produto_preco                      float                               not null,
 Fornecedor_NIF						int									not null,
primary key (numero),

);
go

CREATE TABLE STOCK.Fornecedor(
 NIF                                int                               not null,
 nome                               varchar(30)                               not null,
 endereco                           varchar(30)                               not null,
 fax                                varchar(30)                               ,
 condicao_de_pagamento              varchar(128)                               ,
 Tipo_codigo                        varchar(128)                                not null,
primary key (NIF),

);
go

CREATE TABLE STOCK.Tipo(
 codigo                             varchar(128)                               not null,
 descricao                          varchar(256)                               ,
primary key (codigo),
);
go

ALTER TABLE   STOCK.Armazem                      ADD   CONSTRAINT       arProdutoCodigo			foreign key (Produto_codigo)		          REFERENCES          STOCK.Produto(Codigo);
ALTER TABLE   STOCK.Encomenda                    ADD   CONSTRAINT       encProdutoCodigo        foreign key (Produto_codigo)			      REFERENCES          STOCK.Produto(codigo);
ALTER TABLE   STOCK.Encomenda                    ADD   CONSTRAINT       encFornecedorNIF        foreign key (Fornecedor_NIF)				  REFERENCES          STOCK.Fornecedor(NIF);
ALTER TABLE   STOCK.Fornecedor                   ADD   CONSTRAINT       fornTipoCodigo			foreign key (Tipo_codigo)					  REFERENCES          STOCK.Tipo(codigo);
go