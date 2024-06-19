USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_ExaminationType') IS NOT NULL
DROP TABLE tb_ExaminationType;
GO
CREATE TABLE tb_ExaminationType
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
	CONSTRAINT pk_ExaminationType_No
		PRIMARY KEY(No)
	,Type
		VARCHAR(50))

INSERT INTO tb_ExaminationType
	(Type)
	VALUES
	('ѪҺ���'),
	('��Һ���'),
	('Ӱ��ѧ���'),
	('�ĵ�ͼ���'),
	('�ڿ������'),
	('���Ƽ��'),
	('�������')

SELECT * FROM tb_ExaminationType