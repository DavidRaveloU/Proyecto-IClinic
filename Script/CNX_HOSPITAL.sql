CREATE TABLE agenda (
    id_agenda                  VARCHAR2(25) NOT NULL,
    cita_medica_id_cita        VARCHAR2(25) NOT NULL,
    detalleagenda_id_detalle   VARCHAR2(25),
    medico_cedula_medico       VARCHAR2(12) NOT NULL
);

ALTER TABLE agenda ADD CONSTRAINT agenda_pk PRIMARY KEY ( id_agenda );

CREATE TABLE cita_medica (
    id_cita                VARCHAR2(25) NOT NULL,
    hora_cita              DATE NOT NULL,
    fecha_cita             DATE NOT NULL,
    medico_cedula_medico   VARCHAR2(12)
);

ALTER TABLE cita_medica ADD CONSTRAINT cita_medica_pk PRIMARY KEY ( id_cita );

CREATE TABLE consulta (
    id_consultamedica              VARCHAR2(25) NOT NULL,
    peso                           VARCHAR2(5) NOT NULL,
    estatura                       VARCHAR2(5) NOT NULL,
    presion_arterial               VARCHAR2(10) NOT NULL,
    ritmo_cardiaco                 VARCHAR2(10) NOT NULL,
    antecedentes_quirurjicos       VARCHAR2(50),
    tratamiento_id_tratamiento     VARCHAR2(25),
    diagnostico_id_diagnostico     VARCHAR2(25),
    recetamedica_id_recetamedica   VARCHAR2(25),
    cita_medica_id_cita            VARCHAR2(25) NOT NULL,
    medico_cedula_medico           VARCHAR2(12) NOT NULL
);

ALTER TABLE consulta ADD CONSTRAINT consulta_pk PRIMARY KEY ( id_consultamedica );

CREATE TABLE detalleagenda (
    id_detalle             VARCHAR2(25) NOT NULL,
    fecha_disponible       DATE NOT NULL,
    fecha_final_atencion   DATE NOT NULL,
    estado                 CHAR(1) NOT NULL,
    horario_id_horario     VARCHAR2(25) NOT NULL,
    medico_cedula_medico   VARCHAR2(12) NOT NULL
);

ALTER TABLE detalleagenda ADD CONSTRAINT detalleagenda_pk PRIMARY KEY ( id_detalle );

CREATE TABLE diagnostico (
    id_diagnostico   VARCHAR2(25) NOT NULL,
    descripcion      VARCHAR2(100) NOT NULL
);

ALTER TABLE diagnostico ADD CONSTRAINT diagnostico_pk PRIMARY KEY ( id_diagnostico );

CREATE TABLE horario (
    id_horario     VARCHAR2(25) NOT NULL,
    hora_inicial   DATE NOT NULL,
    hora_final     DATE NOT NULL
);

ALTER TABLE horario ADD CONSTRAINT horario_pk PRIMARY KEY ( id_horario );

CREATE TABLE medico (
    cedula_medico        VARCHAR2(12) NOT NULL,
    primer_nombre        VARCHAR2(22) NOT NULL,
    segundo_nombre       VARCHAR2(22),
    primer_apellido      VARCHAR2(22) NOT NULL,
    segundo_apellido     VARCHAR2(22),
    telefono             VARCHAR2(15) NOT NULL,
    correo_electronico   VARCHAR2(50) NOT NULL,
    direccion            VARCHAR2(50) NOT NULL,
    sexo                 CHAR(1) NOT NULL,
    ciudad               VARCHAR2(32) NOT NULL
);

ALTER TABLE medico ADD CONSTRAINT medico_pk PRIMARY KEY ( cedula_medico );

CREATE TABLE paciente (
    cedula_paciente       VARCHAR2(12) NOT NULL,
    primer_nombre         VARCHAR2(22) NOT NULL,
    segundo_nombre        VARCHAR2(22),
    primer_apellido       VARCHAR2(22) NOT NULL,
    segundo_apellido      VARCHAR2(22),
    telefono              VARCHAR2(15) NOT NULL,
    correo_electronico    VARCHAR2(50) NOT NULL,
    direccion             VARCHAR2(50) NOT NULL,
    sexo                  CHAR(1) NOT NULL,
    ciudad                VARCHAR2(32) NOT NULL,
    cita_medica_id_cita   VARCHAR2(25)
);

ALTER TABLE paciente ADD CONSTRAINT paciente_pk PRIMARY KEY ( cedula_paciente );

CREATE TABLE recetamedica (
    id_recetamedica      VARCHAR2(25) NOT NULL,
    nombre_medicamento   VARCHAR2(50) NOT NULL,
    indicaciones         VARCHAR2(300) NOT NULL
);

ALTER TABLE recetamedica ADD CONSTRAINT recetamedica_pk PRIMARY KEY ( id_recetamedica );

CREATE TABLE tratamiento (
    id_tratamiento       VARCHAR2(25) NOT NULL,
    nombre_tratamiento   VARCHAR2(25) NOT NULL,
    descripcion          VARCHAR2(100) NOT NULL
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

ALTER TABLE consulta
    ADD CONSTRAINT consulta_cita_medica_fk FOREIGN KEY ( cita_medica_id_cita )
        REFERENCES cita_medica ( id_cita );

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

ALTER TABLE paciente
    ADD CONSTRAINT paciente_cita_medica_fk FOREIGN KEY ( cita_medica_id_cita )
        REFERENCES cita_medica ( id_cita );



