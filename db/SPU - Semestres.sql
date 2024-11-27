USE apphorarios;

DROP PROCEDURE IF EXISTS `spu_semestres_listar`;
DELIMITER //
CREATE PROCEDURE spu_semestres_listar()
BEGIN
	SELECT id, CONCAT(anio, '-', periodo) 'periodo' FROM semestres WHERE estado = '1';
END //