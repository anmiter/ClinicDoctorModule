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
		VARCHAR(50)
	,HostipalNo
		INT	
		CONSTRAINT fk_Department_HostipalNo
		FOREIGN KEY (HostipalNo)
		REFERENCES tb_Hostipal(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE)

INSERT INTO tb_Department
	(Name,HostipalNo)
	VALUES
	('��ҽ��','1'),
	('��δ����','1'),
	('��ҽ������','1'),
	('��Ѫ�ܿ�','1'),
	('�ڷ��ڿ�','1'),
	('�β���','1'),
	('���겡��','1'),
	('���ڿ�','1'),
	('������','1'),
	('Ƣθ����','1'),
	('������','1'),
	('�ε���','1'),
	('ѪҺ��','1'),
	('�Բ�����ר��','1'),
	('��������','1'),
	('�п�����','1'),
	('��Ѫѹר������','1'),
	('�����','1'),
	('�������','1'),
	('�س���','1'),
	('Ƥ����','1'),
	('���˿�','1'),
	('��ʹ����','1'),
	('����������','1'),
	('����','1'),
	('���в�����','1'),
	('����','1'),
	('�ۿ�','1'),
	('�����ʺ��','1'),
	('��ǻ��','1'),
	('��ҽ��������','1'),
	('Ѫ��ͨ·��������','1'),
	('����ҽѧ��','1'),
	('��Ŀ�','1'),
	('���ÿ�','1'),
	('�뵶����','1')

SELECT * FROM tb_Department
