CREATE SCHEMA ATL;

go
ALTER TABLE    ATL.Turma_Atividades               DROP CONSTRAINT   turAtividadesAtividade
ALTER TABLE    ATL.Turma_Atividades               DROP CONSTRAINT   turAtividadesTurma
ALTER TABLE    ATL.Aluno                          DROP CONSTRAINT   alunoEncarregado
ALTER TABLE    ATL.Aluno                          DROP CONSTRAINT   alunoTurma
ALTER TABLE    ATL.Encarregado_Educacao           DROP CONSTRAINT   encarregadoAluno
ALTER TABLE    ATL.Encarregado_Educacao           DROP CONSTRAINT   encarregadoAdulto
ALTER TABLE    ATL.Adulto_autorizado              DROP CONSTRAINT   adultoAluno
ALTER TABLE    ATL.Adulto_autorizado              DROP CONSTRAINT   adultoGrauParentesco
ALTER TABLE    ATL.Frequenta                      DROP CONSTRAINT   freqAluno
ALTER TABLE    ATL.Frequenta                      DROP CONSTRAINT   freqAtividade
ALTER TABLE    ATL.Leciona_em                     DROP CONSTRAINT   lecionaProfessor
ALTER TABLE    ATL.Leciona_em                     DROP CONSTRAINT   lecionaTurma
ALTER TABLE    ATL.Turma                          DROP CONSTRAINT   turmaEscolaridade


DROP TABLE ATL.Professor
DROP TABLE ATL.Escolaridade
DROP TABLE ATL.Turma
DROP TABLE ATL.Atividade
DROP TABLE ATL.Turma_Atividades
DROP TABLE ATL.Aluno
DROP TABLE ATL.Relacao_com_aluno
DROP TABLE ATL.Encarregado_Educacao
DROP TABLE ATL.Adulto_autorizado
DROP TABLE ATL.Frequenta
DROP TABLE ATL.Leciona_em


--professor
create table ATL.Professor(
    CC varchar(14) not null,
    Numero_funcionario int not null,
    Email varchar(30) not null,
    Data_nascimento varchar(9) not null,
    Contacto_telefonico int(9) ,
    Morada varchar(100) ,
    Nome varchar(50) not null,

    primary key (CC),
)

create table ATL.Escolaridade(
    Classe int not null,

    primary key (Classe)
)

create table ATL.Turma(
    Identificador varchar(1024) not null,
    Designacao varchar(1) not null,
    Numero_alunos int not null,
    Ano_letivo varchar(9),
    Escolaridade_Classe int not null,

    primary key (Identificador),

)

create table ATL.Atividade(
    Identificador varchar(1024) not null,
    Custo float not null,
    Designacao varchar(1024),

    primary key (Identificador),

)

create table ATL.Turma_Atividades(
    Atividade_Identificador varchar(1024) not null,
    Turma_Identificador varchar(1024) not null,

    primary key (Atividade_Identificador, Turma_Identificador),

)

create table ATL.Aluno(
    CC varchar(14) not null,
    Data_nascimento varchar(9) not null,
    Nome varchar(50), not null,
    Morada varchar(50),

    Encarregado_CC varchar(14) set null,
    Turma_Identificador varchar(1024),

    primary key (CC)
)

create table ATL.Relacao_com_aluno(
    GrauParentesco varchar(15), not null,

    primary key (GrauParentesco)

)

create table ATL.Encarregado_Educacao(
    CC varchar(14) not null,
    Email varchar(30) not null,
    Data_nascimento varchar(9) not null,
    Nome varchar(50), not null,
    Morada varchar(50),
    Contacto_telefonico int(9),

    Relacao_com_aluno varchar(15),
    Aluno_CC varchar(14),

   primary key (CC),
)

create table ATL.Adulto_autorizado(
    CC varchar(14) not null,
    Email varchar(30) not null,
    Data_nascimento varchar(9) not null,
    Nome varchar(50), not null,
    Morada varchar(50),
    Contacto_telefonico int(9),

    Relacao_com_aluno varchar(15),
    Aluno_CC varchar(14),

    primary key (CC),
)

create table ATL.Frequenta(
    Aluno_CC varchar(14) not null,
    Turma_Identificador varchar(1024) not null,

    primary key (Aluno_CC, Turma_Identificador)
)

create table ATL.Leciona_em(
    Professor_CC varchar(14) not null,
    Turma_Identificador varchar(1024) not null,

    primary key (Professor_CC, Turma_Identificador)
)


-- Realtions






ALTER TABLE    ATL.Turma_Atividades               ADD CONSTRAINT   turAtividadesAtividade   foreign key (Atividade_Identificador)                REFERENCES                       ATL.Atividade              (Identificador);
ALTER TABLE    ATL.Turma_Atividades               ADD CONSTRAINT   turAtividadesTurma       foreign key (Turma_Identificador)                    REFERENCES                       ATL.Turma                  (Identificador);
ALTER TABLE    ATL.Aluno                          ADD CONSTRAINT   alunoEncarregado         foreign key (Encarregado_CC)                         REFERENCES                       ATL.Encarregado_Educacao   (CC);
ALTER TABLE    ATL.Aluno                          ADD CONSTRAINT   alunoTurma               foreign key (Turma_Identificador)                    REFERENCES                       ATL.Turma                  (Identificador);
ALTER TABLE    ATL.Encarregado_Educacao           ADD CONSTRAINT   encarregadoAluno         foreign key (Aluno_CC)                               REFERENCES                       ATL.Aluno                  (CC);
ALTER TABLE    ATL.Encarregado_Educacao           ADD CONSTRAINT   encarregadoAdulto        foreign key (Relacao_com_aluno)                      REFERENCES                       ATL.Adulto_autorizado      (Relacao_com_aluno);
ALTER TABLE    ATL.Adulto_autorizado              ADD CONSTRAINT   adultoAluno              foreign key (Aluno_CC)                               REFERENCES                       ATL.Aluno                  (CC);
ALTER TABLE    ATL.Adulto_autorizado              ADD CONSTRAINT   adultoGrauParentesco     foreign key (Relacao_com_aluno)                      REFERENCES                       ATL.Relacao_com_aluno      (GrauParentesco);
ALTER TABLE    ATL.Frequenta                      ADD CONSTRAINT   freqAluno                foreign key (Aluno_CC)                               REFERENCES                       ATL.Aluno                  (CC);
ALTER TABLE    ATL.Frequenta                      ADD CONSTRAINT   freqAtividade            foreign key (Turma_Identificador)                    REFERENCES                       ATL.Turma                  (Identificador);
ALTER TABLE    ATL.Leciona_em                     ADD CONSTRAINT   lecionaProfessor         foreign key (Professor_CC)                           REFERENCES                       ATL.Professor              (CC);
ALTER TABLE    ATL.Leciona_em                     ADD CONSTRAINT   lecionaTurma             foreign key (Turma_Identificador)                    REFERENCES                       ATL.Turma                  (Identificador);
ALTER TABLE    ATL.Turma                          ADD CONSTRAINT   turmaEscolaridade        foreign key (Escolaridade_Classe)                    REFERENCES                       ATL.Escolaridade           (Classe);
