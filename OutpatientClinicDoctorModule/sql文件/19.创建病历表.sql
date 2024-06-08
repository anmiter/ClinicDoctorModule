USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_TreatRecord') IS NOT NULL
DROP TABLE tb_TreatRecord;
GO
CREATE TABLE tb_TreatRecord
	(Date
		DATE
	,HealthCardNo
		VARCHAR(50)
		CONSTRAINT fk_TreatRecord_HealthCardNo
		FOREIGN KEY (HealthCardNo)
		REFERENCES tb_Patient(HealthCardNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,DoctorNo
		VARCHAR(50)
		CONSTRAINT fk_TreatRecord_DoctorNo
		FOREIGN KEY (DoctorNo)
		REFERENCES tb_Doctor(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Description
		VARCHAR(1500)
	,Result
		VARCHAR(1500)
	,TCMNo
		VARCHAR(50)
	,PrescriptionNo
		VARCHAR(50)
	,ExaminationsNo
		VARCHAR(50)
	,Price
		DECIMAL(18,2)
	,IsPaid
		BIT
		DEFAULT 0)