USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_QueueState') IS NOT NULL
DROP TABLE tb_QueueState;
GO
CREATE TABLE tb_QueueState
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
		CONSTRAINT pk_tb_QueueState_No
		PRIMARY KEY(No)
	,State
		VARCHAR(50))

INSERT INTO tb_QueueState
	(State)
	VALUES
	('����'),
	('����'),
	('���Ⱥ�'),
	('�������'),
	('��Ӧ��')

SELECT * FROM tb_QueueState