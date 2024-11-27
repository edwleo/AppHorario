USE apphorarios;

DROP PROCEDURE IF EXISTS `spu_instructores_listar`;
DELIMITER //
CREATE PROCEDURE spu_instructores_listar()
BEGIN
	SELECT
		INS.id,
		ESC.nombreescuela,
		INS.idsenati,
		INS.apellidos, INS.nombres, 
        CASE 
			WHEN INS.tipocontrato = 'C' THEN 'Tiempo completo'
            WHEN INS.tipocontrato = 'P' THEN 'Jornada parcial'
        END 'tipocontrato'
		FROM instructores INS
		INNER JOIN escuelas ESC ON ESC.id = INS.idescuela
		WHERE INS.estado = '1';
END //