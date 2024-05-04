USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_HerbType') IS NOT NULL
DROP TABLE tb_HerbType;
GO
CREATE TABLE tb_HerbType
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)：自增长，起始值1，增量1*/
		NOT NULL
		CONSTRAINT pk_HerbType_No
		PRIMARY KEY(No)
	,Type
		VARCHAR(50))

INSERT INTO tb_HerbType
	(Type)
	VALUES
	('辛温解表药'),
	('辛凉解表药'),
	('清热泻火药'),
	('清热解毒药'),
	('清热燥湿药'),
	('攻下药'),
	('润下药'),
	('祛风寒湿药'),
	('祛风湿热药'),
	('利水消肿药'),
	('利尿通淋药'),
	('温中祛寒药'),
	('回阳救逆药'),
	('行气药'),
	('降气药'),
	('消食药'),
	('凉血止血药'),
	('化瘀止血药'),
	('活血止痛药'),
	('活血调经药'),
	('补气药'),
	('补阳药'),
	('补血药'),
	('补阴药'),
	('重镇安神药'),
	('养心安神药')

SELECT * FROM tb_CTDrugType