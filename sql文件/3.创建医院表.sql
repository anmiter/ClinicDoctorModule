USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Hostipal') IS NOT NULL
DROP TABLE tb_Hostipal;
GO
CREATE TABLE tb_Hostipal
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
	CONSTRAINT pk_Hostipal_No
		PRIMARY KEY(No)
	,Name
		VARCHAR(50))

INSERT INTO tb_Hostipal
	(Name)
	VALUES
	('����ʡ��������ҽԺ'),
	('����ʡ��ҽԺ')

SELECT * FROM tb_Hostipal
