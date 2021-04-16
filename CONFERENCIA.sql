create schema CONFERENCIA;
go

ALTER Table CONFERENCIA.NaoEstudante            drop constraint    nEstudantePagamento
ALTER Table CONFERENCIA.Estudante               drop constraint    estudanteCompro
ALTER Table CONFERENCIA.Estudante               drop constraint    estudanteInsti
ALTER Table CONFERENCIA.Autor                   drop constraint    autorInstituicao
ALTER Table CONFERENCIA.Pede                    drop constraint    pedeEstudante
ALTER Table CONFERENCIA.Pede                    drop constraint    pedeInstituicao
ALTER Table CONFERENCIA.Pede                    drop constraint    pedeComprovativo
ALTER TABLE CONFERENCIA.Comprovativo            drop constraint    comprovatiovoEstudante
ALTER TABLE CONFERENCIA.Comprovativo            drop constraint    comprovatiovoInstituicao


drop table CONFERENCIA.artigo
drop table CONFERENCIA.Editou
drop table CONFERENCIA.Instituicao
drop table CONFERENCIA.Pede
drop table CONFERENCIA.Autor
--drop table CONFERENCIA.Autor_Associado
drop table CONFERENCIA.Estudante
drop table CONFERENCIA.NaoEstudante
drop table CONFERENCIA.Pagamento
drop table CONFERENCIA.Comprovativo

go


create table CONFERENCIA.artigo(
    numero_registo                               int                                        not null,
    titulo                                       varchar(30)                                not null,

    primary key ( numero_registo ),

);



create table CONFERENCIA.Editou(

    Autor_email                                    varchar( 30)                              not null,
    Artigo_numero_registo                         int                                       not null,

    primary key ( Autor_email , Artigo_numero_registo),

);



create table CONFERENCIA.Instituicao(


    nome                                        varchar (30)                                not null,
    endereco                                    varchar (30)                                 ,

    primary key ( nome ),


);



create table CONFERENCIA.Pede(

    comprovativo_localizacao                    varchar(30)                                 not null,
    Instituicao_nome                            varchar(30)                                 not null,
    Estudante_email                             varchar(30)                                 not null,

    primary key (comprovativo_localizacao, Instituicao_nome, Estudante_email ),

);

create table CONFERENCIA.Autor(

    email                                       varchar(30)                                  not null,
    nome                                        varchar(30)                                  not null,
    Instituicao_nome                            varchar(30)                                  not null,

    primary key (email),
);

--create table CONFERENCIA.Autor_Associado(

  --  Autor_email                                 varchar(30)                                  not null,~
  -- Instituicao_nome                            varchar(30)                                  not null,

  --  primary key (Autor_email, Instituicao_nome),

--);

create table CONFERENCIA.Estudante(

    email                                       varchar(30)                                  not null,
    nome                                        varchar (30)                                 not null,
    endereco                                    varchar(30)                                  ,
    Data_nascimento                             date                                         not null,
    comprovativo_localizacao                    varchar(30)                                 not null,
    Instituicao_nome                            varchar(30)                                  not null,

    primary key (email),
);


create table CONFERENCIA.NaoEstudante(

    email                                       varchar(30)                                  not null,
    nome                                        varchar (30)                                 not null,
    endereco                                    varchar(30)                                  ,
    Data_nascimento                             date                                         not null,
    Pagamento_referecia                         int                                  not null,

    primary key (email),
);

create table CONFERENCIA.Pagamento(
    referecia                                   int                                         not null,


    primary key (referecia),
);

create table CONFERENCIA.Comprovativo(

    localizacao                                       varchar(30)                                  not null,
    Estudante_email                                   varchar(30)                                 not null,
    Instituicao_nome                            varchar(30)                                  not null,
    primary key(localizacao, Estudante_email, Instituicao_nome),
);




ALTER Table CONFERENCIA.NaoEstudante            add constraint    nEstudantePagamento            foreign key  (Pagamento_referecia)                      REFERENCES                  CONFERENCIA.Pagamento(referecia);
ALTER Table CONFERENCIA.Estudante               add constraint    estudanteCompro                foreign key  (comprovativo_localizacao)                 REFERENCES                  CONFERENCIA.Comprovativo(localizacao);
ALTER Table CONFERENCIA.Estudante               add constraint    estudanteInsti                 foreign key  (Instituicao_nome)                         REFERENCES                  CONFERENCIA.Instituicao(nome);
ALTER Table CONFERENCIA.Autor                   add constraint    autorInstituicao               foreign key  (Instituicao_nome)                         REFERENCES                  CONFERENCIA.Instituicao(nome);
ALTER Table CONFERENCIA.Pede                    add constraint    pedeEstudante                  foreign key  (Estudante_email)                          REFERENCES                  CONFERENCIA.Estudante_email(email);
ALTER Table CONFERENCIA.Pede                    add constraint    pedeInstituicao                foreign key  (Instituicao_nome)                         REFERENCES                  CONFERENCIA.Instituicao(nome);
ALTER Table CONFERENCIA.Pede                    add constraint    pedeComprovativo               foreign key  (comprovativo_localizacao)                 REFERENCES                  CONFERENCIA.Comprovativo(localizacao);
ALTER TABLE CONFERENCIA.Comprovativo            add constraint    comprovatiovoEstudante         foreign key  (Estudante_email)                          REFERENCES                  CONFERENCIA.Estudante(email);
ALTER TABLE CONFERENCIA.Comprovativo            add constraint    comprovatiovoInstituicao       foreign key  (nome)                                     REFERENCES                  CONFERENCIA.Instituicao(nome);
