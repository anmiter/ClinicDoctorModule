USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Examinations') IS NOT NULL
DROP TABLE tb_Examinations;
GO
CREATE TABLE tb_Examinations
	(No
		VARCHAR(50)
	,ExaminationNo
		INT
		CONSTRAINT fk_Examinations_ExaminationNo
		FOREIGN KEY (ExaminationNo)
		REFERENCES tb_Examination(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Result
		VARCHAR(250))