USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_ExamineType') IS NOT NULL
DROP TABLE tb_ExamineType;
GO
CREATE TABLE tb_ExamineType
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
	CONSTRAINT pk_ExamineType_No
		PRIMARY KEY(No)
	,Name
		VARCHAR(100))

INSERT INTO tb_ExamineType
	(Name)
	VALUES
	('ѪҺ���'),
	('��Һ���'),
	('Ӱ��ѧ���'),
	('�ĵ�ͼ���'),
	('�ڿ������'),
	('���Ƽ��'),
	('�������')

SELECT * FROM tb_ExamineType