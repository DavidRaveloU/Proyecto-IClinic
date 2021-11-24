create database Iclinic;
CREATE SEQUENCE  id_agenda
 start with 1
  increment by 1
  maxvalue 99999
  minvalue 1
  no cycle;
  
CREATE SEQUENCE   id_cita  
 start with 1
  increment by 1
  maxvalue 99999
  minvalue 1
  no cycle;
  
CREATE SEQUENCE  id_consultamedica   
 start with 1
  increment by 1
  maxvalue 99999
  minvalue 1
  no cycle;
  
 CREATE SEQUENCE  id_detalle  
 start with 1
  increment by 1
  maxvalue 99999
  minvalue 1
  no cycle;    
  
   
 CREATE SEQUENCE  id_horario 
 start with 1
  increment by 1
  maxvalue 99999
  minvalue 1
  no cycle;    

  

CREATE TABLE agenda (
    id_agenda                   INT NOT NULL,
    cita_medica_id_cita         INT NOT NULL,
    detalleagenda_id_detalle    INT,
    medico_cedula_medico        VARCHAR(15) NOT NULL
);

ALTER TABLE agenda ADD CONSTRAINT agenda_pk PRIMARY KEY ( id_agenda );

CREATE TABLE cita_medica (
    id_cita                    INT NOT NULL,
    hora_cita                  DATE NOT NULL,
    fecha_cita                 DATE NOT NULL,
    medico_cedula_medico       VARCHAR(15),
    paciente_cedula_paciente   VARCHAR(15) NOT NULL
);

ALTER TABLE cita_medica ADD CONSTRAINT cita_medica_pk PRIMARY KEY ( id_cita );

CREATE TABLE consulta (
    id_consultamedica              INT NOT NULL,
    peso                           VARCHAR(5) NOT NULL,
    estatura                       VARCHAR(5) NOT NULL,
    presion_arterial               VARCHAR(10) NOT NULL,
    ritmo_cardiaco                 VARCHAR(10) NOT NULL,
    antecedentes_quirurjicos       VARCHAR(50),
    tratamiento_id_tratamiento     INT,
    diagnostico_id_diagnostico     INT,
    recetamedica_id_recetamedica   INT,
    medico_cedula_medico           VARCHAR(15) NOT NULL,
);

ALTER TABLE consulta ADD CONSTRAINT consulta_pk PRIMARY KEY ( id_consultamedica );

CREATE TABLE detalleagenda (
    id_detalle             INT NOT NULL,
    fecha_disponible       DATE NOT NULL,
    fecha_final_atencion   DATE NOT NULL,
    estado                 CHAR(1) NOT NULL,
    horario_id_horario     INT NOT NULL,
    medico_cedula_medico   VARCHAR(15) NOT NULL
);

ALTER TABLE detalleagenda ADD CONSTRAINT detalleagenda_pk PRIMARY KEY ( id_detalle );

CREATE TABLE diagnostico (
    id_diagnostico   INT NOT NULL,
    descripcion      VARCHAR(100) NOT NULL
);

ALTER TABLE diagnostico ADD CONSTRAINT diagnostico_pk PRIMARY KEY ( id_diagnostico );

CREATE TABLE horario (
    id_horario     INT NOT NULL,
    hora_inicial   DATE NOT NULL,
    hora_final     DATE NOT NULL
);

ALTER TABLE horario ADD CONSTRAINT horario_pk PRIMARY KEY ( id_horario );

CREATE TABLE medico (
    cedula_medico        VARCHAR(15) NOT NULL,
    primer_nombre        VARCHAR(22) NOT NULL,
    segundo_nombre       VARCHAR(22),
    primer_apellido      VARCHAR(22) NOT NULL,
    segundo_apellido     VARCHAR(22),
    telefono             VARCHAR(15) NOT NULL,
    correo_electronico   VARCHAR(50) NOT NULL,
    direccion            VARCHAR(50) NOT NULL,
    sexo                 VARCHAR(15) NOT NULL,
    ciudad               VARCHAR(32) NOT NULL
);

ALTER TABLE medico ADD CONSTRAINT medico_pk PRIMARY KEY ( cedula_medico );

CREATE TABLE paciente (
    cedula_paciente      VARCHAR(15) NOT NULL,
    primer_nombre        VARCHAR(22) NOT NULL,
    segundo_nombre       VARCHAR(22),
    primer_apellido      VARCHAR(22) NOT NULL,
    segundo_apellido     VARCHAR(22),
    telefono             VARCHAR(15) NOT NULL,
    correo_electronico   VARCHAR(50) NOT NULL,
    direccion            VARCHAR(50) NOT NULL,
    sexo                 VARCHAR(15) NOT NULL,
    ciudad               VARCHAR(32) NOT NULL
);

ALTER TABLE paciente ADD CONSTRAINT paciente_pk PRIMARY KEY ( cedula_paciente );

CREATE TABLE recetamedica (
    id_recetamedica      INT NOT NULL,
    nombre_medicamento   VARCHAR(50) NOT NULL,
    indicaciones         VARCHAR(300) NOT NULL
);

ALTER TABLE recetamedica ADD CONSTRAINT recetamedica_pk PRIMARY KEY ( id_recetamedica );

CREATE TABLE tratamiento (
    id_tratamiento       INT NOT NULL,
    nombre_tratamiento   VARCHAR(25) NOT NULL,
    descripcion          VARCHAR(100) NOT NULL
);

ALTER TABLE tratamiento ADD CONSTRAINT tratamiento_pk PRIMARY KEY ( id_tratamiento );

ALTER TABLE agenda
    ADD CONSTRAINT agenda_cita_medica_fk FOREIGN KEY ( cita_medica_id_cita )
        REFERENCES cita_medica ( id_cita );

ALTER TABLE agenda
    ADD CONSTRAINT agenda_detalleagenda_fk FOREIGN KEY ( detalleagenda_id_detalle )
        REFERENCES detalleagenda ( id_detalle );

ALTER TABLE agenda
    ADD CONSTRAINT agenda_medico_fk FOREIGN KEY ( medico_cedula_medico )
        REFERENCES medico ( cedula_medico );

ALTER TABLE cita_medica
    ADD CONSTRAINT cita_medica_medico_fk FOREIGN KEY ( medico_cedula_medico )
        REFERENCES medico ( cedula_medico );

ALTER TABLE cita_medica
    ADD CONSTRAINT cita_medica_paciente_fk FOREIGN KEY ( paciente_cedula_paciente )
        REFERENCES paciente ( cedula_paciente );

ALTER TABLE consulta
    ADD CONSTRAINT consulta_diagnostico_fk FOREIGN KEY ( diagnostico_id_diagnostico )
        REFERENCES diagnostico ( id_diagnostico );

ALTER TABLE consulta
    ADD CONSTRAINT consulta_medico_fk FOREIGN KEY ( medico_cedula_medico )
        REFERENCES medico ( cedula_medico );

ALTER TABLE consulta
    ADD CONSTRAINT consulta_recetamedica_fk FOREIGN KEY ( recetamedica_id_recetamedica )
        REFERENCES recetamedica ( id_recetamedica );

ALTER TABLE consulta
    ADD CONSTRAINT consulta_tratamiento_fk FOREIGN KEY ( tratamiento_id_tratamiento )
        REFERENCES tratamiento ( id_tratamiento );

ALTER TABLE detalleagenda
    ADD CONSTRAINT detalleagenda_horario_fk FOREIGN KEY ( horario_id_horario )
        REFERENCES horario ( id_horario );

ALTER TABLE detalleagenda
    ADD CONSTRAINT detalleagenda_medico_fk FOREIGN KEY ( medico_cedula_medico )
        REFERENCES medico ( cedula_medico );


