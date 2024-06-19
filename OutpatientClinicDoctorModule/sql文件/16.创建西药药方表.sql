USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Prescription') IS NOT NULL
DROP TABLE tb_Prescription;
GO
CREATE TABLE tb_Prescription
	(No
		VARCHAR(50)
	,HealthCardNo
		VARCHAR(50)
		CONSTRAINT fk_PrescriptionList_HealthCardNo
		FOREIGN KEY (HealthCardNo)
		REFERENCES tb_Patient(HealthCardNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,DoctorNo
		VARCHAR(50)
		CONSTRAINT fk_PrescriptionList_DoctorNo
		FOREIGN KEY (DoctorNo)
		REFERENCES tb_Doctor(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Date
		DATE
	,DrugNo
		INT
		CONSTRAINT fk_Prescription_DrugNo
		FOREIGN KEY (DrugNo)
		REFERENCES tb_Drug(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Number
		INT
	,Unit
		VARCHAR(50)
	,Usage
		VARCHAR(50))