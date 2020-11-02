DROP DATABASE IF EXISTS `mateo_vargas`;

CREATE DATABASE IF NOT EXISTS `mateo_vargas` DEFAULT CHARACTER SET LATIN1 COLLATE LATIN1_SWEDISH_CI;

USE `mateo_vargas`;

CREATE TABLE persona (
    ci CHAR(8) NOT NULL PRIMARY KEY,
    tel_cel VARCHAR(9) NOT NULL,
    edad INT(3) NOT NULL,
    domicilio TEXT,
    sexo VARCHAR(10) NOT NULL,
    pnom VARCHAR(30) NOT NULL,
    snom VARCHAR(30),
    pape VARCHAR(30) NOT NULL,
    sape VARCHAR(30) NOT NULL,
    CONSTRAINT chk_sexo CHECK (sexo = 'Hombre' OR sexo = 'Mujer'
        OR sexo = 'Otro')
); 

CREATE TABLE paciente(
    ciP CHAR(8) NOT NULL,
    mail VARCHAR(50) NOT NULL,
    contrasena LONGTEXT NOT NULL ,
    CONSTRAINT fk_pac FOREIGN KEY(ciP) REFERENCES persona(ci)
);

CREATE TABLE gerente(
    ciG CHAR(8) NOT NULL,
    contrasena LONGTEXT NOT NULL,
    CONSTRAINT fk_ciG FOREIGN KEY(ciG) REFERENCES persona(ci)
);
CREATE TABLE especialidad(
    id INT(4) NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(40) NOT NULL UNIQUE KEY
);
CREATE TABLE medico(
    ciM CHAR(8) NOT NULL PRIMARY KEY,
    numMed INT(4) UNIQUE KEY,
    idEspecialidad INT(4) NOT NULL ,
    lun CHAR(15),
    mar CHAR(15),
    mie CHAR(15),
    jue CHAR(15),
    vie CHAR(15),
    sab CHAR(15),
    dom CHAR(15),
    lugarTrabajo VARCHAR(30) NOT NULL,
    contrasena LONGTEXT NOT NULL ,
    CONSTRAINT fk_ciM FOREIGN KEY(ciM) REFERENCES persona(ci),
    CONSTRAINT fk_idEsp FOREIGN KEY(idEspecialidad) REFERENCES especialidad(id)
);

CREATE TABLE fotoPerfil(
ci CHAR(8) UNIQUE KEY REFERENCES persona(ci),
foto LONGTEXT
);
CREATE TABLE riesgo (
idriesgo INT(1) PRIMARY KEY,
riesgo VARCHAR(10)
);

CREATE TABLE sintoma(
    id INT(4) NOT NULL AUTO_INCREMENT PRIMARY KEY ,
    nombre VARCHAR(30) NOT NULL UNIQUE KEY
);

CREATE TABLE enfermedad(
    idEnf INT(4) NOT NULL AUTO_INCREMENT  PRIMARY KEY,
    nombre VARCHAR(30) NOT NULL  UNIQUE KEY,
    riesgo INT(1) NOT NULL,
    descripcion TEXT,
    CONSTRAINT fk_riesgo FOREIGN KEY(riesgo) REFERENCES riesgo(idriesgo),
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
    nomE VARCHAR(30) NOT NULL,
    fecha DATE NOT NULL,
    CONSTRAINT fk_idP FOREIGN KEY(idP) REFERENCES paciente(ciP),
    CONSTRAINT fk_nomE FOREIGN KEY(nomE) REFERENCES enfermedad(nombre)
);

CREATE TABLE fichaMedica(
	id INT(4) NOT NULL AUTO_INCREMENT PRIMARY KEY,
	cedP CHAR(8),
    fecha DATE NOT NULL,
    Procedencia VARCHAR(30) NOT NULL,
    idDiag INT(4) UNIQUE KEY,
    Ocup VARCHAR(30),
    Medicacion VARCHAR(30),
    Motiv_Cons TEXT,
    antecedentesFamiliares CHAR(50),
    CONSTRAINT fk_cedP FOREIGN KEY(cedP) REFERENCES paciente(ciP)
);

CREATE TABLE selec(
    dia DATE NOT NULL,
    hora TIME NOT NULL,
    idSint INT(4) NOT NULL,
    idPac CHAR(8) NOT NULL,
    CONSTRAINT pk_clav PRIMARY KEY (dia, hora, idPac),
    CONSTRAINT fk_idPac FOREIGN KEY(idPac) REFERENCES paciente(ciP),
    CONSTRAINT fk_idSint FOREIGN KEY(idSint) REFERENCES sintoma(id)
);
CREATE TABLE define(
    nomEnf VARCHAR(30) NOT NULL,
    idSint INT(4) NOT NULL,
    CONSTRAINT fk_nomEnf FOREIGN KEY(nomEnf) REFERENCES enfermedad(nombre),
    CONSTRAINT fk_sint FOREIGN KEY(idSint) REFERENCES sintoma(id)
);

CREATE TABLE chat(
	idchat INT(4) NOT NULL AUTO_INCREMENT PRIMARY KEY,
	ciPac CHAR(8) NOT NULL,
	idMed CHAR(8) NOT NULL,
    fecha DATE NOT NULL,
    diagnostico TEXT NOT NULL,
    FOREIGN KEY(ciPac) REFERENCES paciente(ciP),
    FOREIGN KEY (idMed) REFERENCES medico(ciM),
    estado VARCHAR(10) NOT NULL,
    CONSTRAINT chk_estado CHECK(
		estado='Proceso' OR
		estado='Finalizado'
    )
);

CREATE TABLE mensaje(
	idMsj INT(4) AUTO_INCREMENT PRIMARY KEY,
    hora TIME NOT NULL,
    idchat INT(4) NOT NULL,
    emisor CHAR(8),
    receptor CHAR(8),
    txt TEXT NOT NULL,
    FOREIGN KEY(emisor) REFERENCES persona(ci),
    CONSTRAINT fk_receptor FOREIGN KEY(receptor) REFERENCES persona(ci),
    CONSTRAINT fk_idchat FOREIGN KEY(idchat) REFERENCES chat(idchat)
);

CREATE TABLE solicita(
    id INT(4) NOT NULL PRIMARY KEY AUTO_INCREMENT,
    ci CHAR(8) NOT NULL REFERENCES paciente(ciP),
    nombre VARCHAR(15) NOT NULL,
    diagnostico VARCHAR(30) NOT NULL REFERENCES diagnostico(nomE),
    estado VARCHAR(10) NOT NULL,
    CONSTRAINT chk_Estado CHECK (
        estado = 'Pendiente'
        OR estado = 'Atendido'
    )
);


-- INSERTs -------------------------------------------------------------------------------
-- PERSONAS: --
INSERT INTO persona(ci,tel_cel,edad,domicilio,sexo,pnom,snom,pape,sape)VALUES('11111111',22344568,49,'Av.Libertad','Hombre','Marco','','Aurelio','De Partabas');
INSERT INTO persona(ci,tel_cel,edad,domicilio,sexo,pnom,snom,pape,sape)VALUES('22222222',22344567,28,'Av.Libertad','Mujer','Romina','','Almiron','Rodriguez');
INSERT INTO persona(ci,tel_cel,edad,domicilio,sexo,pnom,snom,pape,sape)VALUES('33333333',12345678,19,'Av.Bolivia 2446','Hombre','Martin','Marulo','Rodriguez','De Biscasua');
INSERT INTO persona(ci,tel_cel,edad,domicilio,sexo,pnom,snom,pape,sape)VALUES('44444444',096714278,32,'Gral. Flores 2345','Mujer','Roberta','','Garcia','Domginguez');
INSERT INTO persona(ci,tel_cel,edad,domicilio,sexo,pnom,snom,pape,sape)VALUES('55555555',11223366,89,'Av.Libertad 5421','Mujer','Agustina','','Mirella','Gutierrez');
INSERT INTO persona(ci,tel_cel,edad,domicilio,sexo,pnom,snom,pape,sape)VALUES('66666666',94229964,18,'Ramallo 3194','Hombre','Mateo','Matias','Beron','Alegoa');
INSERT INTO persona(ci,tel_cel,edad,domicilio,sexo,pnom,snom,pape,sape)VALUES('77777777',88888888,105,'Av.Libertad','Mujer','Mirtha','','Legrand','Suarez');
INSERT INTO persona(ci,tel_cel,edad,domicilio,sexo,pnom,snom,pape,sape)VALUES('88888888',25072542,65,'Av.Italia 6544','Hombre','Roberto','','Diaz','Garcia');
INSERT INTO persona(ci,tel_cel,edad,domicilio,sexo,pnom,snom,pape,sape)	VALUES('53393343',22344565,49,'Av.Libertad','Hombre','Marco','','Aurelio','De Partabas');
INSERT INTO persona(ci,tel_cel,edad,domicilio,sexo,pnom,snom,pape,sape)	VALUES('26314278',22344563,49,'Av.Libertad','mujer','Marcela','','Aurelia','De Ruedas');
INSERT INTO persona(ci,tel_cel,edad,domicilio,sexo,pnom,snom,pape,sape)	VALUES('52525252',22344233,49,'Av.Libertad','hombre','Ave','Maria','Roberta','Garcia');
-- ------------------------------------------ gerentes, Medicos y Pacientes --------------------------------------------------------------- --
-- gerentes: --
INSERT INTO gerente(ciG, contrasena) VALUES('11111111', SHA2('contraseña1', 256));
INSERT INTO gerente(ciG, contrasena) VALUES('33333333', SHA2('contraseña2', 256));
-- Pacientes: --
INSERT INTO paciente(ciP,contrasena,mail) VALUES('22222222',SHA2('paciente1', 256),'elpacientenumero1@mail.com');
INSERT INTO paciente(ciP,contrasena,mail) VALUES('44444444',SHA2('paciente2', 256),'elpacientenumero2@mail.com');
INSERT INTO paciente(ciP,contrasena,mail) VALUES('55555555',SHA2('paciente3', 256),'elpacientenumero3@mail.com');
INSERT INTO paciente(ciP,contrasena,mail) VALUES('88888888',SHA2('paciente4', 256),'elpacientenumero4@mail.com');
-- especialidad -- 
INSERT INTO especialidad VALUES (NULL,'Medico General');
INSERT INTO especialidad VALUES (NULL,'Pediatra');
INSERT INTO especialidad VALUES (NULL,'Nutricionista');
INSERT INTO especialidad VALUES (NULL,'Cardiologo');
-- Medicos: --
INSERT INTO medico VALUES
	('66666666',0123,1,'08:15 a 14:00','','9:00 a 16:00','11:00 a 17:30','','','','Clinica Central',SHA2('medico1', 256));
INSERT INTO medico VALUES 
	('77777777',1234,3,'','07:00 a 13:00','08:20 a 16:40','','13:00 a 19:40','','','Clinica Central',SHA2('medico2', 256));
INSERT INTO medico VALUES
	('53393343',0112,2,'08:15 a 14:00','','9:00 a 16:00','11:00 a 17:30','','','','Clinica Central',SHA2('medico3', 256));
INSERT INTO medico VALUES
	('26314278',0412,4,'08:15 a 14:00','','9:00 a 16:00','11:00 a 17:30','','','','Clinica Central',SHA2('medico4', 256));
INSERT INTO medico VALUES
	('52525252',0712,4,'08:15 a 14:00','','9:00 a 16:00','11:00 a 17:30','','','','Clinica Central',SHA2('medico5', 256));
    
-- riesgo --
INSERT INTO riesgo VALUES (1,'Rojo');
INSERT INTO riesgo VALUES (2,'Naranja');
INSERT INTO riesgo VALUES (3,'Amarillo');
INSERT INTO riesgo VALUES (4,'Verde');
INSERT INTO riesgo VALUES (5,'Azul');
-- ------------------------------------------ sintomas, enfermedades y define  --------------------------------------------------------------- --
INSERT INTO enfermedad VALUES(NULL,"covid","2","tos seca");
INSERT INTO enfermedad VALUES(NULL,"gripe","5","enfermedad infecciosa aguda de las vías respiratorias");

INSERT INTO enfermedad VALUES(NULL,"alergia","5","puede ser producida por hongos ambientales, los ácaros de polvo y los epitelios de algunos animales, como los perros, gatos, caballos y roedores.");
INSERT INTO enfermedad VALUES(NULL,"dengue","1","producido por la picadura de un mosquito");
INSERT INTO enfermedad VALUES(NULL,"leucemia","1","La leucemia es una enfermedad de la sangre en la que la médula ósea produce glóbulos blancos anómalos");

INSERT INTO sintoma VALUES(NULL,"resfrio");
INSERT INTO sintoma VALUES(NULL,"tos");
INSERT INTO sintoma VALUES(NULL,"fiebre");
INSERT INTO sintoma VALUES(NULL,"flemas");
INSERT INTO sintoma VALUES(NULL,"estornudos");
INSERT INTO sintoma VALUES(NULL,"lagrimeo");
INSERT INTO sintoma VALUES(NULL,"picor en los ojos");
INSERT INTO sintoma VALUES(NULL,"fiebre alta");
INSERT INTO sintoma VALUES(NULL,"sangrado en encias");
INSERT INTO sintoma VALUES(NULL,"dolor muscular");
INSERT INTO sintoma VALUES(NULL,"debilidad general");
INSERT INTO sintoma VALUES(NULL,"cansancio");
INSERT INTO sintoma VALUES(NULL,"perdida de apetito");
INSERT INTO sintoma VALUES(NULL,"perdidad de peso");
INSERT INTO sintoma VALUES(NULL,"sudores nocturnos");
-- define --
INSERT INTO define(nomEnf,idSInt) VALUES("covid",2);
INSERT INTO define(nomEnf,idSInt) VALUES("covid",1);
INSERT INTO define(nomEnf,idSInt) VALUES("gripe",1);
INSERT INTO define(nomEnf,idSInt) VALUES("gripe",2);

INSERT INTO define(nomEnf,idSInt) VALUES("dengue",8);
INSERT INTO define(nomEnf,idSInt) VALUES("dengue",9);
INSERT INTO define(nomEnf,idSInt) VALUES("dengue",10);
INSERT INTO define(nomEnf,idSInt) VALUES("dengue",11);

INSERT INTO define(nomEnf,idSInt) VALUES("alergia",5);
INSERT INTO define(nomEnf,idSInt) VALUES("alergia",6);
INSERT INTO define(nomEnf,idSInt) VALUES("alergia",7);

INSERT INTO define(nomEnf,idSInt) VALUES("leucemia",12);
INSERT INTO define(nomEnf,idSInt) VALUES("leucemia",13);
INSERT INTO define(nomEnf,idSInt) VALUES("leucemia",14);
INSERT INTO define(nomEnf,idSInt) VALUES("leucemia",15);
-- paciente selecciona sintomas--
INSERT INTO selec VALUES (CURDATE(),CURTIME(),1,22222222);
INSERT INTO selec VALUES (CURDATE(),CURTIME()+1,9,22222222);
INSERT INTO selec VALUES (CURDATE(),CURTIME()+2,10,22222222);
INSERT INTO selec VALUES (CURDATE(),CURTIME()+3,11,22222222);
INSERT INTO selec VALUES (CURDATE(),CURTIME()+4,2,44444444);
INSERT INTO selec VALUES (CURDATE(),CURTIME()+5,1,55555555);
INSERT INTO selec VALUES (CURDATE(),CURTIME(),2,55555555);
INSERT INTO selec VALUES (CURDATE(),CURTIME()+10,3,55555555);
-- -------------------------- Diagnostico -------------------------- -- 
INSERT INTO diagnostico(idDiag,idP,nomE,fecha) VALUES(NULL,'22222222','covid',CURDATE());
INSERT INTO diagnostico(idDiag,idP,nomE,fecha) VALUES(NULL,'22222222','dengue',DATE_SUB(CURDATE(),INTERVAL '8' DAY));
INSERT INTO diagnostico(idDiag,idP,nomE,fecha) VALUES(NULL,'44444444','covid',CURDATE());
INSERT INTO diagnostico(idDiag,idP,nomE,fecha) VALUES(NULL,'55555555','gripe',CURDATE());
INSERT INTO diagnostico(idDiag,idP,nomE,fecha) VALUES(NULL,'55555555','covid',CURDATE());
INSERT INTO diagnostico(idDiag,idP,nomE,fecha) VALUES(NULL,'88888888','dengue',DATE_SUB(CURDATE(),INTERVAL '7' DAY));
-- Ficha medica --
INSERT INTO fichaMedica(fecha,procedencia,idDiag,id,cedP,Ocup,Medicacion,Motiv_Cons,antecedentesFamiliares) 
VALUES (CURDATE(),'Uruguay',15,NULL,44444444,'Ingeniero en Sistemas','Antialergico','Por malestar','Diabetes'),
(CURDATE(),'Uruguay',7,NULL,22222222,'En paro','','Por enfermedad',''),
(CURDATE(),'Uruguay',21,NULL,55555555,'En paro','Analgesicos','Por enfermedad','Hipertension'),
(CURDATE(),'Uruguay',20,NULL,88888888,'Docente','','Por enfermedad',''); 
-- ----------------------------- Solicita chat, Acepta y chat --------------------------- --
#INSERT INTO solicita VALUES (null,22222222,'Romina','alergia','Pendiente');
#INSERT INTO solicita VALUES (null,44444444,'Romina','dengue','Pendiente');
#INSERT INTO solicita VALUES (null,88888888,'Romina','alergia','Pendiente');
#INSERT INTO solicita VALUES (null,55555555,'Agustina','gripe','Pendiente');
-- chat --
INSERT INTO chat VALUES (NULL,'22222222',66666666,CURDATE(),'covid','Finalizado');
INSERT INTO chat VALUES (NULL,'55555555',66666666,CURDATE(),'gripe','Finalizado');
-- prueba para consultas
INSERT INTO chat VALUES (NULL,'55555555',26314278,DATE_SUB(CURDATE(),INTERVAL '1' YEAR),'gripe','Finalizado');
INSERT INTO chat VALUES (NULL,'55555555',26314278,DATE_SUB(CURDATE(),INTERVAL '1' MONTH),'gripe','Finalizado');
INSERT INTO chat VALUES (NULL,'55555555',26314278,DATE_SUB(CURDATE(),INTERVAL '1' MONTH),'gripe','Finalizado');
INSERT INTO chat VALUES (NULL,'55555555',26314278,DATE_SUB(CURDATE(),INTERVAL '1' MONTH),'gripe','Finalizado');

INSERT INTO chat VALUES (NULL,'55555555',52525252,DATE_SUB(CURDATE(),INTERVAL '2' YEAR),'tos','Finalizado');
INSERT INTO chat VALUES (NULL,'55555555',52525252,DATE_SUB(CURDATE(),INTERVAL '5' DAY),'tos','Finalizado');

INSERT INTO chat VALUES (NULL,'22222222',53393343,DATE_SUB(CURDATE(),INTERVAL '3' YEAR),'tos','Finalizado');
INSERT INTO chat VALUES (NULL,'22222222',53393343,DATE_SUB(CURDATE(),INTERVAL '1' MONTH),'tos','Finalizado');
INSERT INTO chat VALUES (NULL,'22222222',53393343,DATE_SUB(CURDATE(),INTERVAL '1' MONTH),'tos','Finalizado');

## ######################################################################################
## 										DASHBOARD									   ##
#########################################################################################
DELIMITER $$
CREATE PROCEDURE `masDiagnosticados`()
BEGIN
SELECT nomE AS Enfermedad,COUNT(nomE) AS cant FROM diagnostico GROUP BY nomE ORDER BY COUNT(nomE) DESC LIMIT 5;
END$$
DELIMITER ;

DELIMITER $$

CREATE PROCEDURE `sintomaMasSeleccionado`()
BEGIN
SELECT nombre  AS sintoma ,COUNT(idSint) AS cant FROM sintoma
JOIN selec ON idSint=id
GROUP BY nombre 
ORDER BY COUNT(nombre) 
DESC LIMIT 5;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `cantchatsMes`()
BEGIN
SELECT 'Enero' AS mes,COUNT(idchat) AS 'Cantidad de consultas' FROM chat WHERE MONTH(fecha)=1 AND YEAR(fecha)=YEAR(CURDATE())
UNION
	SELECT 'Febrero',COUNT(idchat) FROM chat WHERE MONTH(fecha)=2 AND YEAR(fecha)=YEAR(CURDATE())
UNION
	SELECT 'Marzo',COUNT(idchat) FROM chat WHERE MONTH(fecha)=3 AND YEAR(fecha)=YEAR(CURDATE())
UNION
SELECT 'Abril',COUNT(idchat)  FROM chat WHERE MONTH(fecha)=4 AND YEAR(fecha)=YEAR(CURDATE())
UNION
	SELECT 'Mayo',COUNT(idchat) FROM chat WHERE MONTH(fecha)=5 AND YEAR(fecha)=YEAR(CURDATE())
UNION
	SELECT 'Junio',COUNT(idchat) FROM chat WHERE MONTH(fecha)=6 AND YEAR(fecha)=YEAR(CURDATE())
UNION
SELECT 'Julio',COUNT(idchat)FROM chat WHERE MONTH(fecha)=7 AND YEAR(fecha)=YEAR(CURDATE())
UNION
	SELECT 'Agosto',COUNT(idchat) FROM chat WHERE MONTH(fecha)=8 AND YEAR(fecha)=YEAR(CURDATE())
UNION
	SELECT 'Septiembre',COUNT(idchat) FROM chat WHERE MONTH(fecha)=9 AND YEAR(fecha)=YEAR(CURDATE())
UNION
    SELECT 'Octubre',COUNT(idchat) FROM chat WHERE MONTH(fecha)=10 AND YEAR(fecha)=YEAR(CURDATE())
UNION
	SELECT 'Noviembre',COUNT(idchat) FROM chat WHERE MONTH(fecha)=11 AND YEAR(fecha)=YEAR(CURDATE())
UNION
	SELECT 'Diciembre',COUNT(idchat) FROM chat WHERE MONTH(fecha)=12 AND YEAR(fecha)=YEAR(CURDATE());

END$$
DELIMITER ;
-- FIN DASHBOARD -------------------------------------------------------------------------------------------------------------------------------------
