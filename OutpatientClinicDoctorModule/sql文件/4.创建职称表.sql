USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Title') IS NOT NULL
DROP TABLE tb_Title;
GO
CREATE TABLE tb_Title
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
	CONSTRAINT pk_Title_No
		PRIMARY KEY(No)
	,Name
		VARCHAR(50)
	,CounselingCost
		DECIMAL(18,2))

INSERT INTO tb_Title
	(Name,CounselingCost)
	VALUES
	('����ҽʦ',50),
	('������ҽʦ',40),
	('����ҽʦ',35),
	('סԺҽʦ',30);

SELECT * FROM tb_Title