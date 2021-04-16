create schema SNS;

go

alter table SNS.Prescricao drop constraint prescPaciente;
alter table SNS.Prescricao drop constraint prescMedico;
alter table SNS.Prescricao drop constraint presfarmacia;
alter table SNS.Contem     drop constraint contemPrescricao;
alter table SNS.Farmaco    drop constraint farmacoFamaceutica;
alter table SNS.Contem     drop constraint contemFarmaco;

alter table SNS.Farmaco_Prescrito                drop constraint f_prescritoPrescricao;
alter table SNS.Farmaco_Prescrito                drop constraint f_prescritoFarmaceutica;

alter table SNS.Farmaco_Prescrito                drop constraint f_prescritoFarmaco;


-- imports Farmaco

alter table SNS.Farmaco                         drop constraint  farmFarmaceutica;

-- imports Prescricao

alter table SNS.Prescricao                      drop constraint  prescMedico;
alter table SNS.Prescricao                      drop constraint  prescPaciente;
alter table SNS.Prescricao                      drop constraint  prescFarmacia;



drop table SNS.Medico;
drop table SNS.Farmacia;
drop table SNS.Paciente;
drop table SNS.Farmaceutica;
drop table SNS.Farmaco;
drop table SNS.Prescricao;
drop table SNS.Contem;



go


create table SNS.Medico(
	id_sns							int					not null,
	especialidade						varchar(30),
        nome                                                    varchar(30)                             not null,

        primary key(id_sns),

);


create table SNS.Paciente(

        numero_utente                                           int                                     not null,
        endereco                                                varchar(30)                             ,
        telefone                                                varchar(9)                                ,
        nome                                                    varchar(30)                             not null,
        date_birth                                              date                                    not null,

        primary key(numero_utente),
);

create table SNS.Farmacia(

        nome                                                    varchar(30)                             not null,
        endereco                                                varchar(30)                             not null,
        telefone                                                varchar(9)

        primary key( nome ),

);


create table SNS.Farmaceutica(

        numero_registo_nacional                                 varchar(15)                               not null,
        nome                                                    varchar(15)                             not null,
        endereco                                                varchar(30)                             ,
        telefone                                                varchar(9)                                ,

        primary key ( numero_registo_nacional )

);


create table SNS.Farmaco(

        nome_comercial                                          varchar(15)                             not null,
        Farmaceutica_numero_registo_nacional                    varchar(15)                               not null,
        Formula                                                 varchar(30)                             ,

        primary key ( nome_comercial, Farmaceutica_numero_registo_nacional ),
);

create table SNS.Prescricao(


       id                                                       int                                     not null,
       Medico_id_sns                                            int                                     not null,
       Paciente_numero_utente                                   int                                     not null,
       Farmacia_nome                                            VARCHAR(30)                             not NULL,

       primary key ( id ),
);


create table SNS.Farmaco_Prescrito(
        Prescricao_id                                           int                                     not null,
        Farmaco_nome_comercial                                  varchar(30)                             not null,
        Farmaceutica_numero_registo_nacional                    varchar(15)

);


-- imports Farmaco_Prescrito
alter table SNS.Farmaco_Prescrito                add constraint f_prescritoPrescricao           foreign key (Prescricao_id)                                     references          SNS.Prescricao              ( id );
alter table SNS.Farmaco_Prescrito                add constraint f_prescritoFarmaceutica         foreign key (Farmaceutica_numero_registo_nacional)              references          SNS.Farmaceutica            ( numero_registo_nacional );

alter table SNS.Farmaco_Prescrito                add constraint f_prescritoFarmaco              foreign key (Farmaco_nome_comercial)                            references          SNS.Farmaco                 ( nome_comercial );


-- imports Farmaco

alter table SNS.Farmaco                         add constraint  farmFarmaceutica                foreign key (Farmaceutica_numero_registo_nacional)              references          SNS.Farmaceutica            ( numero_registo_nacional );

-- imports Prescricao

alter table SNS.Prescricao                      add constraint  prescMedico                     foreign key (Medico_id_sns)                                     references           SNS.Medico                 ( id_sns );
alter table SNS.Prescricao                      add constraint  prescPaciente                   foreign key (Paciente_numero_utente)                            references           SNS.Paciente               ( numero_utente );
alter table SNS.Prescricao                      add constraint  prescFarmacia                   foreign key (Farmacia_nome)                                     references           SNS.Farmacia               ( nome );
