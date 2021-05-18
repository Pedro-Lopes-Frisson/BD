--create schema CONFERENCIA;
go

ALTER TABLE CONFERENCIA.Comprovativo            drop constraint    comprovativoEstudante          
ALTER TABLE CONFERENCIA.Comprovativo            drop constraint    comprovativoInstituicao        
ALTER Table CONFERENCIA.Pede                    drop constraint    pedeEstudante                  
ALTER Table CONFERENCIA.Pede                    drop constraint    pedeInstituicao                
ALTER Table CONFERENCIA.Pede                    drop constraint    pedeComprovativo               
ALTER Table CONFERENCIA.Autor                   drop constraint    autorInstituicao               
ALTER Table CONFERENCIA.Estudante               drop constraint    estudanteCompro                
ALTER Table CONFERENCIA.Estudante               drop constraint    estudanteInsti                 
ALTER Table CONFERENCIA.NaoEstudante            drop constraint    nEstudantePagamento            
go

drop table CONFERENCIA.artigo
drop table CONFERENCIA.Editou
drop table CONFERENCIA.Instituicao
drop table CONFERENCIA.Pede
drop table CONFERENCIA.Autor
drop table CONFERENCIA.Estudante
drop table CONFERENCIA.NaoEstudante
drop table CONFERENCIA.Pagamento
drop table CONFERENCIA.Comprovativo

go


create table CONFERENCIA.Artigo(
    numero_registo                               int                                        not null,
    titulo                                       varchar(30)                                not null,

    primary key ( numero_registo ),

);
go

create table CONFERENCIA.Conferencia(
    id											 char(9)                                        not null,
    primary key ( id ),

);
go

create table CONFERENCIA.Apresentados(
    Conferencia_id											 char(9)                                        not null,
	Artigo_numero_registo									 int											not null,	
    primary key ( Conferencia_id, Artigo_numero_registo ),

);
go


create table CONFERENCIA.Editou(

    Autor_email                                    varchar( 30)                              not null,
    Artigo_numero_registo                         int                                       not null,

    primary key ( Autor_email , Artigo_numero_registo),

);
go


create table CONFERENCIA.Instituicao(


    nome                                        varchar (30)                                not null,
    endereco                                    varchar (30)                                 ,

    primary key ( nome ),


);
go


create table CONFERENCIA.Pede(

    comprovativo_localizacao                    varchar(30)                                 not null,
    Instituicao_nome                            varchar(30)                                 not null,
    Estudante_email                             varchar(30)                                 not null,

    primary key (comprovativo_localizacao, Instituicao_nome, Estudante_email ),

);
go
create table CONFERENCIA.Autor(

    email                                       varchar(30)                                  not null,
    nome                                        varchar(30)                                  not null,
    Instituicao_nome                            varchar(30)                                  not null,

    primary key (email),
);
go


create table CONFERENCIA.Estudante(

    email                                       varchar(30)                                  not null,
    nome                                        varchar (30)                                 not null,
    endereco                                    varchar(30)                                  ,
    Data_nascimento                             date                                         not null,
    Instituicao_nome                            varchar(30)                                  not null,

    primary key (email),
);
go

create table CONFERENCIA.NaoEstudante(

    email                                       varchar(30)                                  not null,
    nome                                        varchar (30)                                 not null,
    endereco                                    varchar(30)                                  ,
    Data_nascimento                             date                                         not null,
    Pagamento_referecia                         int                                  not null,

    primary key (email),
);
go
create table CONFERENCIA.Pagamento(
    referecia                                   int                                         not null,


    primary key (referecia),
);
go
create table CONFERENCIA.Comprovativo(

    localizacao                                       varchar(30)                                  not null,
    Estudante_email                                   varchar(30)                                 not null,
    Instituicao_nome								  varchar(30)                                  not null,
    primary key(localizacao, Instituicao_nome),
);
go


ALTER TABLE CONFERENCIA.Comprovativo            add constraint    comprovativoEstudante          foreign key  (Estudante_email)                          REFERENCES                  CONFERENCIA.Estudante(email);
ALTER TABLE CONFERENCIA.Comprovativo            add constraint    comprovativoInstituicao        foreign key  (Instituicao_nome)						 REFERENCES					 CONFERENCIA.Instituicao(nome);
ALTER Table CONFERENCIA.Pede                    add constraint    pedeEstudante                  foreign key  (Estudante_email)                          REFERENCES                  CONFERENCIA.Estudante(email);
ALTER Table CONFERENCIA.Pede                    add constraint    pedeInstituicao                foreign key  (Instituicao_nome)                         REFERENCES                  CONFERENCIA.Instituicao(nome);
ALTER Table CONFERENCIA.Autor                   add constraint    autorInstituicao               foreign key  (Instituicao_nome)                         REFERENCES                  CONFERENCIA.Instituicao(nome);
ALTER Table CONFERENCIA.NaoEstudante            add constraint    nEstudantePagamento            foreign key  (Pagamento_referecia)                      REFERENCES                  CONFERENCIA.Pagamento(referecia);
ALTER Table CONFERENCIA.Pede                    add constraint    pedeComprovativo               foreign key  (comprovativo_localizacao, Instituicao_nome)                 REFERENCES                  CONFERENCIA.Comprovativo(localizacao, Instituicao_nome);
ALTER Table CONFERENCIA.Editou                  add constraint    autorEditou                    foreign key  (autor_email)								 REFERENCES                  CONFERENCIA.Autor(email);
ALTER Table CONFERENCIA.Editou                  add constraint    autorArtigo		             foreign key  (Artigo_numero_registo)				     REFERENCES                  CONFERENCIA.Artigo(numero_registo);
ALTER Table CONFERENCIA.Apresentados            add constraint    apresentadoConferencia         foreign key  (Conferencia_id)							 REFERENCES                  CONFERENCIA.Conferencia(id);
ALTER Table CONFERENCIA.Apresentados            add constraint    apresentadoArtigo              foreign key  (Artigo_numero_registo)					 REFERENCES                  CONFERENCIA.Artigo(numero_registo);

go