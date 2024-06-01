USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Hostipal') IS NOT NULL
DROP TABLE tb_Hostipal;
GO
CREATE TABLE tb_Hostipal
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)：自增长，起始值1，增量1*/
		NOT NULL
	CONSTRAINT pk_Hostipal_No
		PRIMARY KEY(No)
	,Name
		VARCHAR(50))

INSERT INTO tb_Hostipal
	(Name)
	VALUES
	('福建省第三人民医院'),
	('福建省立医院')

SELECT * FROM tb_Hostipal
