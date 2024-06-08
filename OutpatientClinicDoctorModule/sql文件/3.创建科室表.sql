USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Department') IS NOT NULL
DROP TABLE tb_Department;
GO
CREATE TABLE tb_Department
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
	CONSTRAINT pk_Department_No
		PRIMARY KEY(No)
	,Name
		VARCHAR(50))
INSERT INTO tb_Department
	(Name)
	VALUES
	('��ҽ��'),
	('��δ����'),
	('��ҽ������'),
	('��Ѫ�ܿ�'),
	('�ڷ��ڿ�'),
	('�β���'),
	('���겡��'),
	('���ڿ�'),
	('������'),
	('Ƣθ����'),
	('������'),
	('�ε���'),
	('ѪҺ��'),
	('�Բ�����ר��'),
	('��������'),
	('�п�����'),
	('��Ѫѹר������'),
	('�����'),
	('�������'),
	('�س���'),
	('Ƥ����'),
	('���˿�'),
	('��ʹ����'),
	('����������'),
	('����'),
	('���в�����'),
	('����'),
	('�ۿ�'),
	('�����ʺ��'),
	('��ǻ��'),
	('��ҽ��������'),
	('Ѫ��ͨ·��������'),
	('����ҽѧ��'),
	('��Ŀ�'),
	('���ÿ�'),
	('�뵶����')

SELECT * FROM tb_Department
