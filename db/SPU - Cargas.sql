USE apphorarios;

DROP PROCEDURE IF EXISTS `spu_cargas_listar_semestre`;
DELIMITER //
CREATE PROCEDURE spu_cargas_listar_semestre(IN _idsemestre INT)
BEGIN
	SELECT
		CAR.id,
        INS.apellidos,
        INS.nombres
		FROM cargas CAR
        INNER JOIN instructores INS ON INS.id = CAR.idinstructor
        WHERE CAR.idsemestre = _idsemestre;
END //

DROP PROCEDURE IF EXISTS `spu_cargas_registrar`;
DELIMITER //
CREATE PROCEDURE spu_cargas_registrar
(
	IN _idsemestre		INT,
	IN _claves 			JSON
)
BEGIN
	DECLARE i INT DEFAULT 0;
    DECLARE _idinstructor	INT;
    DECLARE _totalitems 	INT;

	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION
		BEGIN
        	-- Capturamos cualquier error SQL y continuamos la ejecución
			SET i = i + 1;
            -- ... se podría agregar un manejo de error personalizado
        END;

    SET _totalitems = JSON_LENGTH(_claves); 
    WHILE i < _totalitems DO
		SET _idinstructor = JSON_UNQUOTE(JSON_EXTRACT(_claves, CONCAT('$[', i, '].idinstructor')));
        INSERT INTO cargas (idsemestre, idinstructor) VALUES (_idsemestre, _idinstructor);
        SET i = i + 1;
    END WHILE;
END //


DROP PROCEDURE IF EXISTS `spu_cargas_eliminar`;
DELIMITER //
CREATE PROCEDURE spu_cargas_eliminar(IN _idcarga INT)
BEGIN
	DELETE FROM cargas WHERE id = _idcarga;
END //