USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_HerbCategory') IS NOT NULL
DROP TABLE tb_HerbCategory;
GO
CREATE TABLE tb_HerbCategory
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
		CONSTRAINT pk_tb_HerbCategory_No
		PRIMARY KEY(No)
	,Category
		VARCHAR(50))

INSERT INTO tb_HerbCategory
	(Category)
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

SELECT * FROM tb_HerbCategory