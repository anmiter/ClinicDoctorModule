USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Unit') IS NOT NULL
DROP TABLE tb_Unit;
GO
CREATE TABLE tb_Unit
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
		CONSTRAINT pk_Unit_No
		PRIMARY KEY(No)
	,Name
		VARCHAR(50))

INSERT INTO tb_Unit
	(Name)
	VALUES
	('��'),
	('ƿ'),
	('��'),
	('g'),
	('mg'),
	('ug'),
	('ml'),
	('Ƭ'),
	('��'),
	('��'),
	('֧'),
	('��'),
	('UI'),
	('U')

SELECT * FROM tb_Unit