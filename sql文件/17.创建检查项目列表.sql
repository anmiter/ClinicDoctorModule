USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_ExamineList') IS NOT NULL
DROP TABLE tb_ExamineList;
GO
CREATE TABLE tb_ExamineList
	(No
		VARCHAR(50)
	,DoctorNo
		VARCHAR(50)
		CONSTRAINT fk_ExamineList_DoctorNo
		FOREIGN KEY (DoctorNo)
		REFERENCES tb_Doctor(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,PatientIDCard
		VARCHAR(50)
		CONSTRAINT fk_ExamineList_PatientIDCard
		FOREIGN KEY (PatientIDCard)
		REFERENCES tb_Patient(PatientIDCard)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,DATE
		DATE
	,TotalResult
		VARCHAR(1000))