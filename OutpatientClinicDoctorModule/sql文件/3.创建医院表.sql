USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Hospital') IS NOT NULL
DROP TABLE tb_Hospital;
GO
CREATE TABLE tb_Hospital
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
	CONSTRAINT pk_Hospital_No
		PRIMARY KEY(No)
	,Name
		VARCHAR(50))
INSERT INTO tb_Hospital
	(Name)
	VALUES
	('����ʡ��������ҽԺ'),
	('����ʡ��ҽԺ');
SELECT * FROM tb_Hospital