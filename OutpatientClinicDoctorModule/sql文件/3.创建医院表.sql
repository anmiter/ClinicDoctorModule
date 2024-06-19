USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Hospital') IS NOT NULL
DROP TABLE tb_Hospital;
GO
CREATE TABLE tb_Hospital
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)：自增长，起始值1，增量1*/
		NOT NULL
	CONSTRAINT pk_Hospital_No
		PRIMARY KEY(No)
	,Name
		VARCHAR(50))
INSERT INTO tb_Hospital
	(Name)
	VALUES
	('福建省第三人民医院'),
	('福建省立医院');
SELECT * FROM tb_Hospital