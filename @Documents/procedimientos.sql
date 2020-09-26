-- DASHBOARD -------------------------------------------------------------------------------------------------------------------------------------
DELIMITER $$
CREATE PROCEDURE `MasDiagnosticados`()
BEGIN
SELECT nomE AS Enfermedad FROM diagnostico GROUP BY nomE ORDER BY COUNT(nomE) DESC LIMIT 10;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `SintomaMasSeleccionado`()
BEGIN
SELECT nomSint AS Sintoma FROM selec GROUP BY nomSInt ORDER BY COUNT(nomSint) DESC LIMIT 5;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `CantidadUsuarios_chats`(
	OUT cantPac INT,
	OUT cantMed INT,
	OUT cantGer INT,
	OUT cantChats INT
)
BEGIN

SELECT COUNT(ciP) INTO cantPac FROM paciente;
SELECT COUNT(ciM) INTO cantMed FROM medico;
SELECT COUNT(ciG) INTO cantGer FROM gerente;
SELECT COUNT(idChat)INTO cantChats FROM chat;

END$$
DELIMITER ;

-- ABM PACIENTE -------------------------------------------------------------------------------------------------------------------------------------
DELIMITER $$
CREATE PROCEDURE `SetPaciente`(
IN ci CHAR(8),
IN Tel_cel VARCHAR(9) ,
IN edad INT(3) ,
IN domi TEXT ,
IN sexo VARCHAR(10) ,
IN pNom VARCHAR(30) ,
IN sNom VARCHAR(30) ,
IN pApe VARCHAR(30) ,
IN sApe VARCHAR(30),
IN mail VARCHAR(50) ,
IN contrasena VARCHAR(40),
OUT estado BOOLEAN
)
BEGIN
IF NOT EXISTS(SELECT ciP FROM paciente WHERE ciP=ci)THEN
	BEGIN
		INSERT INTO persona(ci,Tel_cel,Edad,Domicilio,Sexo,pNom,sNom,pApe,sApe) 
			VALUES(ci,tel_cel,edad,domi,sexo,pnom,snom,pape,sape);
		INSERT INTO paciente(ciP,contrasena,mail) 
			VALUES(ci,mail,contrasena);
		SET estado = TRUE;
	END;
ELSE
    BEGIN
    SET estado = FALSE;
    END;
END IF;

END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `DelPaciente`(
IN ci CHAR(8),
OUT estado BOOLEAN
)
BEGIN
IF EXISTS(SELECT ciP FROM paciente WHERE ciP=ci)THEN
	BEGIN
		DELETE FROM paciente WHERE ciP=ci;
        IF NOT EXISTS(SELECT ciP FROM paciente WHERE ciP=ci)THEN
        BEGIN
			DELETE FROM persona WHERE persona.ci=ci;
			SET estado = TRUE;
        END;
        END IF;
	END;
ELSE
	BEGIN
    SET estado = FALSE;
    END;
END IF;

END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `updatePaciente`(
IN ci CHAR(8),
IN Tel_cel VARCHAR(9) ,
IN edad INT(3) ,
IN domi TEXT ,
IN sexo VARCHAR(10) ,
IN pNom VARCHAR(30) ,
IN sNom VARCHAR(30) ,
IN pApe VARCHAR(30) ,
IN sApe VARCHAR(30),
IN mail VARCHAR(50) ,
OUT estado BOOLEAN
)
BEGIN
IF EXISTS(SELECT ciP FROM paciente WHERE ciP=ci)THEN
	BEGIN
		UPDATE persona SET tel_cel=tel_cel,edad=edad,domicilio=domi,sexo=sexo,pnom=pnom,snom=snom,pape=pape,sape=sape
        WHERE persona.ci=ci;
		UPDATE paciente SET mail=mail WHERE ciP=ci;
        SET estado = TRUE;
	END;
ELSE
	BEGIN
    SET estado = FALSE;
    END;
END IF;

END$$
DELIMITER ;

-- ABM MEDICOS -------------------------------------------------------------------------------------------------------------------------------------
DELIMITER $$
CREATE PROCEDURE `SetMedico`(
IN ci CHAR(8),
IN Tel_cel VARCHAR(9) ,
IN edad INT(3) ,
IN domi TEXT ,
IN sexo VARCHAR(10) ,
IN pNom VARCHAR(30) ,
IN sNom VARCHAR(30) ,
IN pApe VARCHAR(30) ,
IN sApe VARCHAR(30),
IN numMed INT(4) ,
IN idEspecialidad INT(4) ,
IN Lun CHAR(15) ,
IN Mar CHAR(15) ,
IN Mie CHAR(15) ,
IN Jue CHAR(15) ,
IN Vie CHAR(15) ,
IN Sab CHAR(15) ,
IN Dom CHAR(15) ,
IN lugarTrabajo VARCHAR(30),
IN contrasena VARCHAR(40),
OUT estado BOOLEAN
)
BEGIN
IF NOT EXISTS(SELECT ciM FROM medico WHERE ciM=ci)THEN
	BEGIN
		INSERT INTO persona(ci,Tel_cel,Edad,Domicilio,Sexo,pNom,sNom,pApe,sApe) 
			VALUES(ci,tel_cel,edad,domi,sexo,pnom,snom,pape,sape);
		INSERT INTO medico VALUES
	(ci,numMed,idEspcecialidad,lun,mar,mie,jue,vie,sab,dom,lugarTrabajo,contrasena);
		SET estado = TRUE;
	END;
ELSE
    BEGIN
    SET estado = FALSE;
    END;
END IF;

END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `DelMedico`(
IN ci CHAR(8),
OUT estado BOOLEAN
)
BEGIN
IF EXISTS(SELECT ciM FROM medico WHERE ciM=ci)THEN
	BEGIN
		DELETE FROM medico WHERE ciM=ci;
        IF NOT EXISTS(SELECT ciM FROM medico WHERE ciM=ci)THEN
        BEGIN
			DELETE FROM persona WHERE persona.ci=ci;
			SET estado = TRUE;
        END;
        END IF;
	END;
ELSE
	BEGIN
    SET estado = FALSE;
    END;
END IF;

END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `UpdateMedico`(
IN ci CHAR(8),
IN Tel_cel VARCHAR(9) ,
IN edad INT(3) ,
IN domi TEXT ,
IN sexo VARCHAR(10) ,
IN pNom VARCHAR(30) ,
IN sNom VARCHAR(30) ,
IN pApe VARCHAR(30) ,
IN sApe VARCHAR(30),
IN numMed INT(4) ,
IN idEspecialidad INT(4) ,
IN Lun CHAR(15) ,
IN Mar CHAR(15) ,
IN Mie CHAR(15) ,
IN Jue CHAR(15) ,
IN Vie CHAR(15) ,
IN Sab CHAR(15) ,
IN Dom CHAR(15) ,
IN lugarTrabajo VARCHAR(30),
OUT estado BOOLEAN
)
BEGIN
IF EXISTS(SELECT ciP FROM paciente WHERE ciP=ci)THEN
	BEGIN
		UPDATE persona SET tel_cel=tel_cel,edad=edad,domi=domicilio,sexo=sexo,pnom=pnom,snom=snom,pape=pape,sape=sape
        WHERE persona.ci=ci;
		UPDATE medico SET ciM=ci,numMed=numMed,idEspcecialidad=idEspecialidad,lun=lun,mar=mar,mie=mie,jue=jue,vie=vie,sab=sab,dom=dom,lugarTrabajo=lugarTrabajo WHERE ciM=ci;
        SET estado = TRUE;
	END;
ELSE
	BEGIN
    SET estado = FALSE;
    END;
END IF;

END$$
DELIMITER ;

-- ABM GERENTE -------------------------------------------------------------------------------------------------------------------------------------
DELIMITER $$
CREATE PROCEDURE `SetGerente`(
IN ci CHAR(8),
IN Tel_cel VARCHAR(9) ,
IN edad INT(3) ,
IN domi TEXT ,
IN sexo VARCHAR(10) ,
IN pNom VARCHAR(30) ,
IN sNom VARCHAR(30) ,
IN pApe VARCHAR(30) ,
IN sApe VARCHAR(30),
IN contrasena VARCHAR(40),
OUT estado BOOLEAN
)
BEGIN
IF NOT EXISTS(SELECT ciM FROM medico WHERE ciM=ci)THEN
	BEGIN
		INSERT INTO persona(ci,Tel_cel,Edad,Domicilio,Sexo,pNom,sNom,pApe,sApe) 
			VALUES(ci,tel_cel,edad,domi,sexo,pnom,snom,pape,sape);
		INSERT INTO gerente VALUES(ci,contrasena);
		SET estado = TRUE;
	END;
ELSE
    BEGIN
    SET estado = FALSE;
    END;
END IF;

END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `DelGerente`(
IN ci CHAR(8),
OUT estado BOOLEAN
)
BEGIN
IF EXISTS(SELECT ciG FROM gerente WHERE ciG=ci)THEN
	BEGIN
		DELETE FROM gerente WHERE ciG=ci;
        IF NOT EXISTS(SELECT ciG FROM gerente WHERE ciG=ci)THEN
        BEGIN
			DELETE FROM persona WHERE persona.ci=ci;
			SET estado = TRUE;
        END;
        END IF;
	END;
ELSE
	BEGIN
    SET estado = FALSE;
    END;
END IF;

END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `UpdateGerente`(
IN ci CHAR(8),
IN Tel_cel VARCHAR(9) ,
IN edad INT(3) ,
IN domi TEXT ,
IN sexo VARCHAR(10) ,
IN pNom VARCHAR(30) ,
IN sNom VARCHAR(30) ,
IN pApe VARCHAR(30) ,
IN sApe VARCHAR(30),
OUT estado BOOLEAN
)
BEGIN
IF EXISTS(SELECT ciP FROM paciente WHERE ciP=ci)THEN
	BEGIN
		UPDATE persona SET tel_cel=tel_cel,edad=edad,domi=domicilio,sexo=sexo,pnom=pnom,snom=snom,pape=pape,sape=sape
        WHERE persona.ci=ci;
        SET estado = TRUE;
	END;
ELSE
	BEGIN
    SET estado = FALSE;
    END;
END IF;

END$$
DELIMITER ;
-- -----------------------------------------------------------------------------------------------------------------------------------


