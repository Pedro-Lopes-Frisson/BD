create schema


ALTER TABLE   RentaCar.RentaCar                    DROP   CONSTRAINT       aluguerClient
ALTER TABLE   RentaCar.RentaCar                    DROP   CONSTRAINT       aluguerVeiculo
ALTER TABLE   RentaCar.RentaCar                    DROP   CONSTRAINT       alguerBalcao
ALTER TABLE   RentaCar.RentaCar                    DROP   CONSTRAINT       simiVeiculo2
ALTER TABLE   RentaCar.RentaCar                    DROP   CONSTRAINT       simiVeiculo


DROP TABLE RentaCar.Aluguer
DROP TABLE RentaCar.Balcao
DROP TABLE RentaCar.Cliente
DROP TABLE RentaCar.Tipo_Veiculo
DROP TABLE RentaCar.Veiculo
DROP TABLE RentaCar.Ligeiro
DROP TABLE RentaCar.Pesado
DROP TABLE RentaCar.Similariadade



CREATE TABLE RentaCar.Aluguer(
 numero                                                   int                                        not null,
 data                                                     date                                       not null,
 duracao                                                  int                                        not null,
 balcao_numero                                            int                                        not null,
 cliente_nif                                              char(9)                                    not null,
 veiculo_matricula                                        char(6)                                    not null,
primary key (numero),

);


CREATE TABLE RentaCar.Balcao(
 numero                                                  int                                        not null,
 endereco                                                varchar(30)                               not null,
 nome                                                    varchar(20)                               not null,
primary key (numero),

);


CREATE TABLE RentaCar.Cliente(
 NIF                                                    char(9)                                      not null,
 nome                                                   varchar(9)                                   not null,
 num_carta                                              int                                          not null,
 endereco                                               varchar(30)                                  not null,
primary key (NIF),

);


CREATE TABLE RentaCar.Tipo_Veiculo(
 codigo                                                 int                                           not null,
 Designacao                                             varchar(10)                                   not null,
 arcondicionado                                         boolean                                       not null,
primary key (codigo),

);


CREATE TABLE RentaCar.Veiculo(
 Matricula                                               char(6)                                     not null,
 Marca                                                   varchar(10)                                 not null,
 Ano                                                     int                                         not null,
 TipoVeiculo_Codigo                                      varchar(12)                                 not null,
primary key (Matricula),

);


CREATE TABLE RentaCar.Ligeiro(
 codigo                                                  int                                       not null,
 Designacao                                              varchar(10)                               not null,
 arcondicionado                                          boolean                                   not null,
 numlugares                                              int                                       not null,
 portas                                                  int                                       not null,
 combustivel                                             varchar(10)                               not null,
primary key (codigo),

);


CREATE TABLE RentaCar.Pesado(
 Designacao                                              varchar(10)                               not null,
 arcondicionado                                          boolean                                   not null,
 peso                                                    float                                     not null,
 passageiros                                             int                                      not null,
primary key (codigo),

);


CREATE TABLE RentaCar.Similariadade(
 Tipo_de_veiculo_codigo_1                                      int                               not null,
 Tipo_de_veiculo_codigo_2                                      int                               not null,

primary key (Tipo_de_veiculo_codigo,Tipo_de_veiculo_codigo),

);


ALTER TABLE   RentaCar.Aluguer               ADD   CONSTRAINT       aluguerClient         foreign key (Cliente_nif)                           REFERENCES          RentaCar.Cliente(NIF);
ALTER TABLE   RentaCar.Aluguer               ADD   CONSTRAINT       aluguerVeiculo        foreign key (veiculo_matricula)                     REFERENCES          RentaCar.Veiculo(Matricula);
ALTER TABLE   RentaCar.Aluguer               ADD   CONSTRAINT       alguerBalcao          foreign key (Balcao_numero)                         REFERENCES          RentaCar.Balcao(numero);
ALTER TABLE   RentaCar.Similariadade         ADD   CONSTRAINT       simiVeiculo           foreign key (Tipo_de_veiculo_codigo_1)              REFERENCES          RentaCar.Tipo_Veiculo(codigo);
ALTER TABLE   RentaCar.Similariadade         ADD   CONSTRAINT       simiVeiculo2          foreign key (Tipo_de_veiculo_codigo_2)              REFERENCES          RentaCar.Tipo_Veiculo(codigo);
ALTER TABLE   RentaCar.Pesado                ADD   CONSTRAINT       ligeiroVeiculo        foreign key (codigo)                                REFERENCES          RentaCar.Tipo_Veiculo(codigo);
ALTER TABLE   RentaCar.Ligeiro               ADD   CONSTRAINT       pesadoVeiculo         foreign key (codigo)                                REFERENCES          RentaCar.Tipo_Veiculo(codigo);
