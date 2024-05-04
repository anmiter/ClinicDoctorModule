USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_HerbType') IS NOT NULL
DROP TABLE tb_HerbType;
GO
CREATE TABLE tb_HerbType
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
		CONSTRAINT pk_HerbType_No
		PRIMARY KEY(No)
	,Type
		VARCHAR(50))

INSERT INTO tb_HerbType
	(Type)
	VALUES
	('���½��ҩ'),
	('�������ҩ'),
	('����к��ҩ'),
	('���Ƚⶾҩ'),
	('������ʪҩ'),
	('����ҩ'),
	('����ҩ'),
	('��纮ʪҩ'),
	('���ʪ��ҩ'),
	('��ˮ����ҩ'),
	('����ͨ��ҩ'),
	('�����ҩ'),
	('��������ҩ'),
	('����ҩ'),
	('����ҩ'),
	('��ʳҩ'),
	('��ѪֹѪҩ'),
	('����ֹѪҩ'),
	('��Ѫֹʹҩ'),
	('��Ѫ����ҩ'),
	('����ҩ'),
	('����ҩ'),
	('��Ѫҩ'),
	('����ҩ'),
	('������ҩ'),
	('���İ���ҩ')

SELECT * FROM tb_CTDrugType