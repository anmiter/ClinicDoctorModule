USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Examinations') IS NOT NULL
DROP TABLE tb_Examinations;
GO
CREATE TABLE tb_Examinations
	(No
		VARCHAR(50)
	,DoctorNo
		VARCHAR(50)
		CONSTRAINT fk_ExaminationList_DoctorNo
		FOREIGN KEY (DoctorNo)
		REFERENCES tb_Doctor(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,HealthCardNo
		VARCHAR(50)
		CONSTRAINT fk_ExaminationList_HealthCardNo
		FOREIGN KEY (HealthCardNo)
		REFERENCES tb_Patient(HealthCardNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Date
		DATE
	,ExaminationNo
		INT
		CONSTRAINT fk_Examinations_ExaminationNo
		FOREIGN KEY (ExaminationNo)
		REFERENCES tb_Examination(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Result
		VARCHAR(1500))