USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Patient') IS NOT NULL
DROP TABLE tb_Patient;
GO
CREATE TABLE tb_Patient
	(HealthCardNo
		VARCHAR(50)
		NOT NULL
		CONSTRAINT pk_Patient_PatientIDCard
		PRIMARY KEY(HealthCardNo)
	,IDCardNo
		VARCHAR(50)
	,Name
		VARCHAR(50)
	,Gender
		BIT
	,Birthdate
		DATE
	,Telephone
		VARCHAR(50)
	,IsMarried
		BIT
	,ProvenanceNo
		INT
		CONSTRAINT fk_Patient_ProvenanceNo
		FOREIGN KEY (ProvenanceNo)
		REFERENCES tb_Provenance(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,DrugAllergy
		VARCHAR(250)
	,Balance
		DECIMAL(18,2)
		DEFAULT 0)

INSERT INTO tb_Patient
	(HealthCardNo,IDCardNo,Name,Gender,Birthdate,Telephone,IsMarried,ProvenanceNo,DrugAllergy,Balance)
	VALUES
	('350427200401214025','350427200401214025','ÕÅÊçì¾',0,'2004-1-21','13023892230',0,9,'',199.8),
	('350283722938401934','350283722938401934','×¿ÑÅ½à',0,'2004-1-23','13948308823',0,9,'',23.6),
	('350273847261983763','350273847261983763','µËðØ·ï',0,'2003-10-1','18962837628',0,9,'',57.9)

SELECT * FROM tb_Patient