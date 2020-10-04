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
-- FIN DASHBOARD -------------------------------------------------------------------------------------------------------------------------------------

-- ABM PACIENTE -------------------------------------------------------------------------------------------------------------------------------------
DELIMITER $$
CREATE PROCEDURE `PacienteSet`(
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
CREATE PROCEDURE `PacienteDelete`(
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
CREATE PROCEDURE `PacienteUpdate`(
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

DELIMITER $$
CREATE PROCEDURE `PacienteGet`()
BEGIN
	SELECT ci Cedula,pnom Primer_Nombre, snom Segundo_Nombre, pape Primer_Apellido, sape Segundo_Apellido,edad, sexo, tel_cel Celular, mail, domicilio
	FROM persona JOIN paciente ON ciP=ci;
END$$
DELIMITER ;

-- ABM MEDICOS -------------------------------------------------------------------------------------------------------------------------------------
DELIMITER $$
CREATE PROCEDURE `MedicoSet`(
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
CREATE PROCEDURE `MedicoDelete`(
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
CREATE PROCEDURE `MedicoUpdate`(
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

DELIMITER $$
CREATE PROCEDURE `MedicoGet`()
BEGIN
	SELECT ci Cedula,numMed,pnom Primer_Nombre, snom Segundo_Nombre, pape Primer_Apellido, sape Segundo_Apellido,lugarTrabajo,nombre Especialidad,Tel_cel,Domicilio,sexo,Lun Lunes,Mar Martes, Mie Miercoles, Jue Jueves, Vie Viernes, Sab Sabado,Dom Domingo,edad, sexo, tel_cel Celular,domicilio
	FROM medico
	JOIN especialidad ON id=idEspecialidad
	JOIN persona ON ciM=ci;
END$$
DELIMITER ;

-- ABM GERENTE -------------------------------------------------------------------------------------------------------------------------------------
DELIMITER $$
CREATE PROCEDURE `GerenteSet`(
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
CREATE PROCEDURE `GerenteDelete`(
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
CREATE PROCEDURE `GerenteUpdate`(
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
IF EXISTS(SELECT ciG FROM gerente WHERE ciG=ci)THEN
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

DELIMITER $$
CREATE PROCEDURE `GerenteGet`()
BEGIN
	SELECT ci Cedula,pnom Primer_Nombre, snom Segundo_Nombre, pape Primer_Apellido, sape Segundo_Apellido,edad, sexo, tel_cel Celular, mail, domicilio
	FROM persona JOIN paciente ON ciG=ci;
END$$
DELIMITER ;

/*IMAGENES*/
DELIMITER $$
CREATE PROCEDURE `ImaagenSet`(
	IN ci CHAR(8),
	IN foto LONGTEXT,
	OUT estado BOOLEAN
)
BEGIN
	INSERT INTO fotoPerfil(ci,foto)VALUES (ci,foto)ON DUPLICATE KEY UPDATE foto=foto;
	SET estado = TRUE;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `ImagenGet`(
	IN ci CHAR(8),
	OUT foto LONGTEXT
)
BEGIN
	SELECT * FROM fotoPerfil WHERE ci=ci;
END$$
DELIMITER ;

--Sintomas -----------------------------------------------------------------------------------------------------------------------------------
DELIMITER $$
CREATE PROCEDURE `SintomaSet`(
	IN nombre VARCHAR(30),
	OUT estado BOOLEAN
)
BEGIN
	IF NOT EXISTS (SELECT nombre FROM sintoma s WHERE s.nombre=nombre)THEN
		BEGIN
			INSERT INTO sintoma(id,nombre) VALUES(null,nombre);
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
CREATE PROCEDURE `SintomaDelete`(
	IN nombre VARCHAR(30),
	OUT estado BOOLEAN
)
BEGIN
IF EXISTS (SELECT nombre FROM sintoma s WHERE s.nombre=nombre)THEN
	BEGIN
		DELETE FROM define WHERE nomSint=nombre;
		IF NOT EXISTS(SELECT nomSint FROM define WHERE nomSint=nombre)THEN
			BEGIN
				DELETE FROM sintoma s WHERE s.nombre=nombre;
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
CREATE PROCEDURE `SintomaUpdate`(
	IN nombre VARCHAR(30),
	OUT estado BOOLEAN
)
BEGIN
	IF EXISTS (SELECT nombre FROM sintoma s WHERE s.nombre=nombre)THEN
	BEGIN
		SET @id=(SELECT id FROM sintoma WHERE nombre=nombre);
		UPDATE define SET nomSint=nombre WHERE idSint=@id;
		UPDATE sintoma s SET s.nombre = nombre WHERE id=@id;
		SET estado = TRUE;
	END;
ELSE
	BEGIN
    SET estado = FALSE;
    END;
end if;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `SintomaGet`()
BEGIN
	SELECT nombre Nombre_Sintoma FROM sintoma;
END$$
DELIMITER ;

--Enfermedad -----------------------------------------------------------------------------------------------------------------------------------
DELIMITER $$
CREATE PROCEDURE `EnfermedadSet`(
	IN nombre VARCHAR(30),
	IN riesgo INT(1),
	IN descripcion TEXT,
	OUT estado BOOLEAN
)
BEGIN
IF NOT EXISTS (SELECT nombre FROM enfermedad WHERE nombre=nombre)THEN
	BEGIN
		INSERT INTO sintoma(idEnf,nombre,riesgo,descripcion) VALUES(null,nombre,riesgo,descripcion);
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
CREATE PROCEDURE `EnfermedadDelete`(
	IN nombre VARCHAR(30),
	OUT estado BOOLEAN
)
BEGIN
	IF EXISTS (SELECT nombre FROM enfermedad WHERE nombre=nombre)THEN
		BEGIN
			IF NOT EXISTS(SELECT diagnostico FROM solicita WHERE nomE=nombre )THEN
				BEGIN
					SET @id = (SELECT idEnf FROM enfermedad WHERE nombre=nombre);

					DELETE FROM diagnostico WHERE idE=@id;
					DO SLEEP(2);
					DELETE FROM define WHERE idENf=@id;
					DO SLEEP(1);
					DELETE FROM enfermedad WHERE nombre=nombre;
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
CREATE PROCEDURE `EnfermedadUpdate`(
	IN nombre VARCHAR(30),
	IN riesgo INT(1),
	IN descripcion TEXT,
	OUT estado BOOLEAN
)
BEGIN
	IF EXISTS (SELECT nombre FROM enfermedad WHERE nombre=nombre)THEN
		BEGIN
			SET @id = (SELECT idEnf FROM enfermedad WHERE nombre=nombre);
			UPDATE define SET nomEnf=nombre WHERE idEnf=@id;
			UPDATE enfermedad e SET e.nombre=nombre WHERE id=@id;
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
CREATE PROCEDURE `EnfermedadGet`()
BEGIN
IF EXISTS (SELECT nombre FROM enfermedad WHERE nombre=nombre)THEN
	BEGIN
		select idEnf id,nombre,riesgo,descripcion,nomSint Sintomas FROM enfermedad
		JOIN define ON nombre=nomENf
		Group by nomEnf;
		SET estado = TRUE;
	END;
ELSE
	BEGIN
		SET estado = FALSE;
	END;
END IF;
END$$
DELIMITER ;