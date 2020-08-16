DROP DATABASE IF EXISTS `MedicaProyecto`;

CREATE DATABASE IF NOT EXISTS `MedicaProyecto` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;

USE `MedicaProyecto`;

CREATE TABLE Persona(
    ci CHAR(8) NOT NULL PRIMARY KEY,
    Tel_cel VARCHAR(9) NOT NULL UNIQUE KEY,
    Edad INT(3) NOT NULL,
    Domicilio TEXT,
    Sexo VARCHAR(10) NOT NULL,
    pNom VARCHAR(30) NOT NULL,
    sNom VARCHAR(30),
    pApe VARCHAR(30) NOT NULL,
    sApe VARCHAR(30) NOT NULL,
    fotoPerfil BLOB,
    CONSTRAINT chk_Sexo CHECK(
        Sexo = 'Hombre'
        OR Sexo = 'Mujer'
        OR Sexo = 'Otro'
    )
);

CREATE TABLE Paciente(
    ciP CHAR(8) NOT NULL,
    mail VARCHAR(50) NOT NULL,
    contraseña VARCHAR(40) NOT NULL UNIQUE KEY,
    CONSTRAINT fk_pac FOREIGN KEY(ciP) REFERENCES persona(ci)
);

CREATE TABLE Gerente(
    ciG CHAR(8) NOT NULL,
    contraseña VARCHAR(40) NOT NULL UNIQUE KEY,
    CONSTRAINT fk_ciG FOREIGN KEY(ciG) REFERENCES Persona(ci)
);

CREATE TABLE Medico(
    ciM CHAR(8) NOT NULL primary key,
    numMed INT(4),
    especialidad VARCHAR(30) NOT NULL,
    Lun char(15),
    Mar char(15),
    Mie char(15),
    Jue char(15),
    Vie char(15),
    Sab char(15),
    Dom char(15),
    lugarTrabajo VARCHAR(30) NOT NULL,
    contraseña VARCHAR(40) NOT NULL UNIQUE KEY,
    CONSTRAINT fk_ciM FOREIGN KEY(ciM) REFERENCES Persona(ci)
);

CREATE TABLE Riesgo (
idRiesgo int(1) primary key,
nombre varchar(10)
);

CREATE TABLE Sintoma(
    id INT(4) NOT NULL AUTO_INCREMENT UNIQUE KEY,
    nombre VARCHAR(20) NOT NULL PRIMARY KEY
);

CREATE TABLE Enfermedad(
    idEnf INT(4) NOT NULL AUTO_INCREMENT UNIQUE KEY,
    nombre VARCHAR(30) NOT NULL PRIMARY KEY,
    riesgo int(1) NOT NULL,
    descripcion TEXT,
    constraint fk_riesgo FOREIGN KEY(riesgo) REFERENCES Riesgo(idRiesgo),
    CONSTRAINT CHK_riesgo CHECK (
        riesgo = '5'
        OR riesgo = '4'
        OR riesgo = '3'
        OR riesgo = '2'
        OR riesgo = '1'
    )
);

CREATE TABLE diagnostico(
    idDiag INT(4) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    idP CHAR(8) NOT NULL,
    nomE VARCHAR(20) NOT NULL,
    Fecha DATE NOT NULL,
    CONSTRAINT fk_idP FOREIGN KEY(idP) REFERENCES Paciente(ciP),
    CONSTRAINT fk_nomE FOREIGN KEY(nomE) REFERENCES Enfermedad(nombre)
);

CREATE TABLE FichaMedica(
    Fecha DATE NOT NULL,
    Procedencia VARCHAR(30) NOT NULL,
    idDiag INT(4) UNIQUE KEY,
    id INT(4) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    cedP CHAR(8) UNIQUE KEY,
    Ocup VARCHAR(30),
    Medicacion VARCHAR(30),
    Motiv_Cons TEXT,
    antecedentesFamiliares char(50),
    CONSTRAINT fk_cedP FOREIGN KEY(cedP) REFERENCES Paciente(ciP)
);

CREATE TABLE Selec(
    dia DATE NOT NULL,
    hora TIME NOT NULL,
    nomSint VARCHAR(20) NOT NULL,
    idPac CHAR(8) NOT NULL,
    constraint pk_clav PRIMARY KEY (dia, hora, idPac),
    CONSTRAINT fk_idPac FOREIGN KEY(idPac) REFERENCES Paciente(ciP),
    CONSTRAINT fk_idSint FOREIGN KEY(nomSint) REFERENCES Sintoma(nombre)
);

CREATE TABLE Gestiona(
    tipo VARCHAR(10) NOT NULL,
    ciGerente CHAR(8) NOT NULL,
    nomEnf VARCHAR(30),
    nomSint VARCHAR(30),
    fecha DATE NOT NULL,
    hora time not null,
    CONSTRAINT fk_nEn FOREIGN KEY(nomEnf) REFERENCES Enfermedad(nombre),
    CONSTRAINT fk_cG FOREIGN KEY(ciGerente) REFERENCES Gerente(ciG),
    CONSTRAINT fk_Sintom FOREIGN KEY(nomSint) REFERENCES Sintoma(nombre),
    CONSTRAINT CHK_Tipo CHECK (
        tipo = 'Alta'
        OR tipo = 'Baja'
        OR tipo = 'Modificacion'
    )
);

CREATE TABLE Define(
    nomEnf VARCHAR(30) NOT NULL,
    nomSint VARCHAR(30) NOT NULL,
    CONSTRAINT fk_nomEnf FOREIGN KEY(nomEnf) REFERENCES Enfermedad(nombre),
    CONSTRAINT fk_sint FOREIGN KEY(nomSint) REFERENCES Sintoma(nombre)
);

CREATE TABLE chat(
    fecha DATE NOT NULL,
    ciPac CHAR(8) NOT NULL,
    FOREIGN KEY(ciPac) REFERENCES Paciente(ciP),
    diagnostico text NOT NULL,
    idChat INT(4) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    idMed char(8) NOT NULL,
    FOREIGN KEY (idMed) references Medico(ciM),
    estado VARCHAR(10) NOT NULL,
    constraint chk_estado CHECK(
    estado='Proceso' OR
    estado='Finalizado'
    )
);

CREATE TABLE Mensaje(
    hora TIME NOT NULL,
    idChat INT(4) NOT NULL,
    emisor CHAR(8),
    receptor CHAR(8),
    txt TEXT NOT NULL,
    FOREIGN KEY(emisor) REFERENCES Persona(ci),
    CONSTRAINT fk_receptor FOREIGN KEY(receptor) REFERENCES Persona(ci),
    CONSTRAINT fk_idChat FOREIGN KEY(idChat) REFERENCES Chat(idChat)
);

CREATE TABLE solicita(
    id int(4) NOT NULL PRIMARY KEY AUTO_INCREMENT,
    ci char(8) NOT NULL References Paciente(ciP),
    nombre varchar(15) NOT NULL,
    diagnostico text NOT NULL REferences Diagnostico(nomE),
    estado varchar(10) NOT NULL,
    CONSTRAINT chk_Estado CHECK (
        estado = 'Pendiente'
        OR estado = 'Atendido'
    )
);

-- Inserts -------------------------------------------------------------------------------
-- PERSONAS: --
INSERT INTO persona(ci,Tel_cel,Edad,Domicilio,Sexo,pNom,sNom,pApe,sApe)VALUES('11111111',22344568,49,'Av.Libertad','Hombre','Marco','','Aurelio','De Partabas');
INSERT INTO persona(ci,Tel_cel,Edad,Domicilio,Sexo,pNom,sNom,pApe,sApe)VALUES('22222222',22344567,28,'Av.Libertad','mujer','Romina','','Almiron','Rodriguez');
INSERT INTO persona(ci,Tel_cel,Edad,Domicilio,Sexo,pNom,sNom,pApe,sApe)VALUES('33333333',12345678,19,'Av.Bolivia 2446','Hombre','Martin','Marulo','Rodriguez','De Biscasua');
INSERT INTO persona(ci,Tel_cel,Edad,Domicilio,Sexo,pNom,sNom,pApe,sApe)VALUES('44444444',096714278,32,'Gral. Flores 2345','Mujer','Roberta','','Garcia','Domginguez');
INSERT INTO persona(ci,Tel_cel,Edad,Domicilio,Sexo,pNom,sNom,pApe,sApe)VALUES('55555555',11223366,89,'Av.Libertad 5421','Mujer','Agustina','','Mirella','Gutierrez');
INSERT INTO persona(ci,Tel_cel,Edad,Domicilio,Sexo,pNom,sNom,pApe,sApe)VALUES('66666666',94229964,18,'Ramallo 3194','Hombre','Mateo','Matias','Beron','Alegoa');
INSERT INTO persona(ci,Tel_cel,Edad,Domicilio,Sexo,pNom,sNom,pApe,sApe)VALUES('77777777',88888888,105,'Av.Libertad','Mujer','Mirtha','','Legrand','Suarez');
INSERT INTO persona(ci,Tel_cel,Edad,Domicilio,Sexo,pNom,sNom,pApe,sApe)VALUES('88888888',25072542,65,'Av.Italia 6544','Hombre','Roberto','','Diaz','Garcia');
-- ------------------------------------------ Gerentes, Medicos y Pacientes --------------------------------------------------------------- --
-- Gerentes: --
INSERT INTO Gerente(ciG, contraseña) VALUES('11111111', 'contraseña1');
INSERT INTO Gerente(ciG, contraseña) VALUES('33333333', 'contraseña2');
-- Pacientes: --
INSERT INTO paciente(ciP,contraseña,mail) VALUES('22222222','paciente1','elpacientenumero1@mail.com');
INSERT INTO paciente(ciP,contraseña,mail) VALUES('44444444','paciente2','elpacientenumero2@mail.com');
INSERT INTO paciente(ciP,contraseña,mail) VALUES('55555555','paciente3','elpacientenumero3@mail.com');
INSERT INTO paciente(ciP,contraseña,mail) VALUES('88888888','paciente4','elpacientenumero4@mail.com');
-- Medicos: --
INSERT INTO medico values
	('66666666',0123,'Medicina General','08:15-14:00','','9:00-16:00','11:00-17:30','','','','Clinica Central','medico1');
INSERT INTO medico values 
	('77777777',1234,'Nutricionista','','07:00 - 13:00','08:20 - 16:40','','13:00-19:40','','','Clinica Central','medico2');
    
-- RIESGO --
insert into Riesgo values (1,'rojo');
insert into Riesgo values (2,'naranja');
insert into Riesgo values (3,'amarillo');
insert into Riesgo values (4,'verde');
insert into Riesgo values (5,'azul');
-- ------------------------------------------ Sintomas, enfermedades y define  --------------------------------------------------------------- --
INSERT INTO sintoma VALUES(null,"resfrio");
INSERT INTO sintoma VALUES(null,"tos");
INSERT INTO sintoma VALUES(null,"fiebre");
INSERT INTO sintoma VALUES(null,"flemas");
INSERT INTO sintoma VALUES(null,"dolor de estomago");

INSERT INTO enfermedad VALUES(null,"covid","2","tos seca");
INSERT INTO enfermedad VALUES(null,"gripe","5","enfermedad infecciosa aguda de las vías respiratorias");
INSERT INTO enfermedad VALUES(null,"gastritis","2","inflamación de la mucosa que recubre las paredes del estómago");
-- Gestiona --
insert into gestiona values ('alta',33333333,'covid',null,CURDATE(),CURTIME());
insert into gestiona values ('alta',33333333,'gripe',null,CURDATE(),CURTIME());
insert into gestiona values ('alta',33333333,'gastritis',null,CURDATE(),CURTIME());
insert into gestiona values ('alta',33333333,null,'resfrio',CURDATE(),CURTIME());
insert into gestiona values ('alta',33333333,null,'tos',CURDATE(),CURTIME());
insert into gestiona values ('alta',33333333,null,'fiebre',CURDATE(),CURTIME());
insert into gestiona values ('alta',33333333,null,'flemas',CURDATE(),CURTIME());
insert into gestiona values ('alta',33333333,null,'dolor de estomago',CURDATE(),CURTIME());
-- Define --
INSERT INTO define VALUES("covid","tos");
INSERT INTO define VALUES("covid","resfrio");
INSERT INTO define VALUES("gripe","resfrio");
INSERT INTO define VALUES("gripe","tos");
INSERT INTO define VALUES("gastritis","dolor de estomago");
-- Paciente Selecciona Sintomas--
insert into selec values (curdate(),curtime(),'resfrio',22222222);
insert into selec values (curdate(),curtime(),'tos',44444444);
insert into selec values (curdate(),curtime(),'dolor de estomago',88888888);
insert into selec values (curdate(),curtime(),'resfrio',55555555);
insert into selec values (curdate(),curtime(),'tos',55555555);
insert into selec values (curdate(),curtime(),'fiebre',55555555);
-- -------------------------- Diagnostico -------------------------- -- 
Insert into diagnostico(idDiag,idP,nomE,Fecha) Values(null,'22222222','covid',CURDATE());
Insert into diagnostico(idDiag,idP,nomE,Fecha) Values(null,'44444444','covid',CURDATE());
Insert into diagnostico(idDiag,idP,nomE,Fecha) Values(null,'55555555','gripe',CURDATE());
Insert into diagnostico(idDiag,idP,nomE,Fecha) Values(null,'88888888','gastritis',CURDATE());
Insert into diagnostico(idDiag,idP,nomE,Fecha) Values(null,'55555555','covid',CURDATE());
Insert into diagnostico(idDiag,idP,nomE,Fecha) Values(null,'88888888','gripe',CURDATE());
-- Ficha medica --
insert into fichamedica values (CURDATE(),'Uruguay',15,null,44444444,'Ingeniero en Sistemas','Antialergico','Por malestar','Diabetes');
insert into fichamedica values (CURDATE(),'Uruguay',7,null,22222222,'En paro','','Por enfermedad','');
insert into fichamedica values (CURDATE(),'Uruguay',21,null,55555555,'En paro','Analgesicos','Por enfermedad','Hipertension');
insert into fichamedica values (CURDATE(),'Uruguay',20,null,88888888,'Docente','','Por enfermedad',''); 
-- ----------------------------- Solicita Chat, Acepta y Chat --------------------------- --
insert into solicita values (null,22222222,'Romina','covid','Pendiente');
insert into solicita values (null,55555555,'Agustina','gripe','Pendiente');
-- Chat --
insert into chat values (CURDATE(),'22222222','covid',null,66666666,'Proceso');
insert into chat values (CURDATE(),'55555555','gripe',null,66666666,'Proceso');
-- ---------------- Mensaje ------------------- --
insert into mensaje values (curtime(),'1',66666666,22222222,"Buenas dias, en que puedo ayudarle?");
insert into mensaje values (curtime(),'1',22222222,66666666,"Queria saber que medicamento me recomienda");
insert into mensaje values (curtime(),'1',66666666,22222222,"Actualmente para el covid no hay medicamento como tal para tratarlo,
								lo mejor que le puedo recomendar es hacer reposo y en caso de tener mucho dolor, tomar un analgesico");