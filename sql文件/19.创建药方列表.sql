USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_PrescriptionList') IS NOT NULL
DROP TABLE tb_PrescriptionList;
GO
CREATE TABLE tb_PrescriptionList
	(PrescriptionNo
		VARCHAR(50)
	,PatientIDCard
		VARCHAR(50)
		CONSTRAINT fk_PrescriptionList_PatientIDCard
		FOREIGN KEY (PatientIDCard)
		REFERENCES tb_Patient(PatientIDCard)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,DoctorNo
		VARCHAR(50)
		CONSTRAINT fk_PrescriptionList_DoctorNo
		FOREIGN KEY (DoctorNo)
		REFERENCES tb_Doctor(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,DATE
		DATE)