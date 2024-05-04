USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Patient') IS NOT NULL
DROP TABLE tb_Patient;
GO
CREATE TABLE tb_Patient
	(PatientIDCard
		VARCHAR(50)
		NOT NULL
		CONSTRAINT pk_Patient_PatientIDCard
		PRIMARY KEY(PatientIDCard)
	,Identification
		VARCHAR(50)
	,Name
		VARCHAR(50)
	,Gender
		BIT
	,Age
		INT
	,Birthday
		DATE
	,Telephone
		VARCHAR(50)
	,MaritalState
		BIT
	,ComeFromNo
		INT
		CONSTRAINT fk_Patient_ComeFromNo
		FOREIGN KEY (ComeFromNo)
		REFERENCES tb_ComeFrom(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,DrugAllergyHistory
		VARCHAR(1000)
	,Balance
		DECIMAL(18,2)
		DEFAULT 0)

INSERT INTO tb_Patient
	(PatientIDCard,Identification,Name,Gender,Age,Birthday,Telephone,MaritalState,ComeFromNo,DrugAllergyHistory,Balance)
	VALUES
	('350427200401214025','350427200401214025','ÕÅÊçì¾',0,20,'2004-1-21','13023892230',0,9,'',199.8),
	('350283722938401934','350283722938401934','×¿ÑÅ½à',0,20,'2004-1-23','13948308823',0,9,'',23.6),
	('350273847261983763','350273847261983763','µËðØ·ï',0,21,'2003-10-1','18962837628',0,9,'',57.9)

SELECT * FROM tb_Patient