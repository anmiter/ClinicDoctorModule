USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_ComeFrom') IS NOT NULL
DROP TABLE tb_ComeFrom;
GO
CREATE TABLE tb_ComeFrom
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
	CONSTRAINT pk_ComeFrom_No
		PRIMARY KEY(No)
	,Name
		VARCHAR(100))

INSERT INTO tb_ComeFrom
	(Name)
	VALUES
	('�ӱ�'),
	('ɽ��'),
	('����'),
	('����'),
	('������'),
	('����'),
	('�㽭'),
	('����'),
	('����'),
	('����'),
	('ɽ��'),
	('����'),
	('����'),
	('����'),
	('�㶫'),
	('����'),
	('�Ĵ�'),
	('����'),
	('����'),
	('����'),
	('����'),
	('�ຣ'),
	('̨��'),
	('���ɹ�������'),
	('����׳��������'),
	('����������'),
	('���Ļ���������'),
	('�½�ά���������'),
	('����'),
	('���'),
	('�Ϻ�'),
	('����'),
	('���'),
	('����')

SELECT * FROM tb_ComeFrom