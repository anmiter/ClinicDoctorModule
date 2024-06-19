USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Provenance') IS NOT NULL
DROP TABLE tb_Provenance;
GO
CREATE TABLE tb_Provenance
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
	CONSTRAINT pk_Provenance_No
		PRIMARY KEY(No)
	,Name
		VARCHAR(50))

INSERT INTO tb_Provenance
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

SELECT * FROM tb_Provenance