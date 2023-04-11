use tuSalud;

ALTER TABLE usuarios ADD clave VARCHAR(16)  NOT NULL;
ALTER TABLE usuarios ALTER COLUMN correo VARCHAR(20) NOT NULL
ALTER TABLE persona ALTER COLUMN fecha_nacimiento VARCHAR(20) NOT NULL
INSERT INTO lugar (ID_LUGAR,pais,canton,distrito)VALUES(001, 'Costa Rica','San Jose', 'Tibas')	

ALTER TABLE persona DROP CONSTRAINT  FK__persona__id_pers__60A75C0F 
INSERT INTO persona(id_persona, nombre, apellido1,apellido2,fecha_nacimiento, nacionalidad,id_lugar,direccion) values(123,'Federico','Torres','Lobo','21/04/2004','Tico',001,'Biblioteca publica de tibas');
select * from persona
SELECT * FROM LUGAR
INSERT INTO rol VALUES(1,'ADMINISTRADOR', 'MANEJA TODO EL SISTEMA')
INSERT INTO usuarios(id_usuario,id_persona,id_rol,correo,telefono,clave) VALUES (12,123,1,'fedeguapo@gmail.com','60554886','123456')