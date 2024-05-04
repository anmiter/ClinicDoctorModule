USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_ExamineType') IS NOT NULL
DROP TABLE tb_ExamineType;
GO
CREATE TABLE tb_ExamineType
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)：自增长，起始值1，增量1*/
		NOT NULL
	CONSTRAINT pk_ExamineType_No
		PRIMARY KEY(No)
	,Name
		VARCHAR(100))

INSERT INTO tb_ExamineType
	(Name)
	VALUES
	('血液检查'),
	('尿液检查'),
	('影像学检查'),
	('心电图检查'),
	('内窥镜检查'),
	('妇科检查'),
	('其他检查')

SELECT * FROM tb_ExamineType