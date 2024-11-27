CREATE DATABASE apphorarios;
USE apphorarios;

CREATE TABLE semestres
(
	id 			INT AUTO_INCREMENT PRIMARY KEY,
    anio 		CHAR(4) 	NOT NULL,
    periodo		CHAR(2)		NOT NULL,
    estado		CHAR(1) 	NOT NULL DEFAULT '1',
    CONSTRAINT uk_anio_per_sem UNIQUE (anio, periodo),
	CONSTRAINT ck_estado_sem CHECK (estado IN ('1', '0'))
)ENGINE = INNODB;


CREATE TABLE escuelas
(
	id 				INT AUTO_INCREMENT PRIMARY KEY,
    nombreescuela	VARCHAR(30)	NOT NULL,
    CONSTRAINT uk_nombreescuela_esc UNIQUE (nombreescuela)
)ENGINE = INNODB;


CREATE TABLE locaciones 
(
	id				INT AUTO_INCREMENT PRIMARY KEY,
    tipo 			CHAR(3) 	NOT NULL,
    locacion 		VARCHAR(20) NOT NULL,
    CONSTRAINT ck_tipo_loc CHECK (tipo IN ('UCP','CFP')),
    CONSTRAINT uk_locacion_loc UNIQUE (locacion)
)ENGINE = INNODB;

CREATE TABLE instructores
(
	id 				INT AUTO_INCREMENT PRIMARY KEY,
    idescuela 		INT 		NOT NULL,
    idsenati 		CHAR(9) 	NOT NULL,
    apellidos 		VARCHAR(40)	NOT NULL,
    nombres 		VARCHAR(40)	NOT NULL,
    tipocontrato 	CHAR(1) 	NOT NULL,
    estado 			CHAR(1) 	NOT NULL DEFAULT '1',
    CONSTRAINT uk_idescuela_ins FOREIGN KEY (idescuela) REFERENCES escuelas (id),
    CONSTRAINT ck_tipocontrato_ins CHECK (tipocontrato IN ('C', 'P')), -- Completa | Parcial
    CONSTRAINT ck_estado_ins CHECK (estado IN ('0', '1')) -- 0 Inactivo, 1 Activo
)ENGINE = INNODB;

CREATE TABLE ambientes
(
	id 				INT AUTO_INCREMENT PRIMARY KEY,
    idlocacion		INT 		NOT NULL,
    tipo 			VARCHAR(20)	NOT NULL,
    ambiente 		VARCHAR(10)	NOT NULL,
    aforo 			SMALLINT 	NOT NULL,
    numpiso 		TINYINT 	NOT NULL,
    estado 			VARCHAR(10)	NOT NULL DEFAULT 'Operativo',
    CONSTRAINT fk_idlocacion_amb FOREIGN KEY (idlocacion) REFERENCES locaciones (id),
    CONSTRAINT ck_tipo_amb CHECK (tipo IN ('Aula tecnología', 'Laboratorio', 'Taller')),
    CONSTRAINT ck_aforo_amb CHECK (aforo BETWEEN 15 AND 45),
    CONSTRAINT ck_numpiso_amb CHECK (numpiso BETWEEN 1 AND 15),
    CONSTRAINT ck_estado_amb CHECK (estado IN ('Operativo', 'Inactivo', 'Mantenimiento'))
)ENGINE = INNODB;

CREATE TABLE cargas
(
	id 				INT AUTO_INCREMENT PRIMARY KEY,
    idsemestre 		INT 		NOT NULL,
    idinstructor 	INT 		NOT NULL,
    CONSTRAINT fk_idsemestre_car FOREIGN KEY (idsemestre) REFERENCES semestres (id),
    CONSTRAINT fk_idinstructor_car FOREIGN KEY (idinstructor) REFERENCES instructores (id),
    CONSTRAINT uk_idinstructor_car UNIQUE (idsemestre, idinstructor)
)ENGINE = INNODB;

CREATE TABLE bloques
(
	id 				INT AUTO_INCREMENT PRIMARY KEY,
    idcarga 		INT 		NOT NULL,
    idambiente 		INT 		NOT NULL,
    contenido 		VARCHAR(30)	NOT NULL,
    fechainicio 	DATE 		NULL,
    fechafin 		DATE 		NULL,
    CONSTRAINT fk_idcarga_blo FOREIGN KEY (idcarga) REFERENCES cargas (id),
    CONSTRAINT fk_idambiente_blo FOREIGN KEY (idambiente) REFERENCES ambientes (id)
)ENGINE = INNODB;

CREATE TABLE horarios
(
	id 				INT AUTO_INCREMENT PRIMARY KEY,
    idbloque 		INT 		NULL,	  -- Cuando es NULL se trata de una pausa activa
    diasemana 		VARCHAR(10) NOT NULL, -- lunes, martes, miércoles, jueves, viernes, sábado
    horainicio 		TIME 		NOT NULL,
    horafin 		TIME 		NOT NULL,
    CONSTRAINT fk_idbloque_hor FOREIGN KEY (idbloque) REFERENCES bloques (id),
    CONSTRAINT ck_diasemana_hora CHECK (diasemana IN ('lunes', 'martes', 'miércoles', 'jueves', 'viernes', 'sábado', 'domingo'))
)ENGINE = INNODB;

-- Agregando datos...
INSERT INTO semestres (anio, periodo) VALUES ('2024', '20');

INSERT INTO escuelas (nombreescuela) VALUES
	('Metalmecánica'),
    ('Tecnologías de la Información'),
    ('Administración de empresas'),
    ('Electrotecnia');

INSERT INTO instructores (idescuela, idsenati, apellidos, nombres, tipocontrato) VALUES 
	(2, '000713752', 'Francia Minaya' , 'Jhon Edward', 'C'),
    (2, '000717171', 'De la Cruz Martinez', 'Lorenzo Claudio', 'C'),
    (2, '000717172', 'Amoretti Bautista', 'César Guillermo', 'C'),
    (2, '000717173', 'Ramos Carbajal', 'Angie Pilar' , 'P'),
    (2, '000717174', 'Barrios Quispe', 'Richard J', 'P'),
    (2, '000717175', 'Buleje Flores', 'Leonardo' , 'P');

INSERT INTO locaciones (tipo, locacion) VALUES
	('CFP', 'Chincha Baja'),
    ('UCP', 'Fátima');

INSERT INTO ambientes (idlocacion, tipo, ambiente, aforo, numpiso, estado) VALUES
	(1, 'Laboratorio', 'F303', 27, 3, 'Operativo'),
    (1, 'Laboratorio', 'F203', 27, 2, 'Operativo'),
    (1, 'Laboratorio', 'D101', 27, 1, 'Operativo'),
    (2, 'Laboratorio', 'F301', 27, 3, 'Operativo'),
    (2, 'Laboratorio', 'F302', 27, 3, 'Operativo');

INSERT INTO cargas (idsemestre, idinstructor) VALUES 
	(1, 1),
    (1, 2);
    
-- By NEL