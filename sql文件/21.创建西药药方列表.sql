USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_PrescriptionList') IS NOT NULL
DROP TABLE tb_PrescriptionList;
GO
CREATE TABLE tb_PrescriptionList
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
	,Price
		DECIMAL(18,2))