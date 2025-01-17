USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_TreatRecord') IS NOT NULL
DROP TABLE tb_TreatRecord;
GO
CREATE TABLE tb_TreatRecord
	(No
		VARCHAR(50)
		NOT NULL
		CONSTRAINT pk_TreatRecord_No
		PRIMARY KEY(No)
	,Date
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
	,DepartmentNo
		INT
		CONSTRAINT fk_TreatRecord_DepartmentNo
		FOREIGN KEY (DepartmentNo)
		REFERENCES tb_Department(No)
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
	,TCMPrice
		DECIMAL(18,2)
	,PrescriptionPrice
		DECIMAL(18,2)
	,ExaminationPrice
		DECIMAL(18,2)
	,IsPaid
		BIT
		DEFAULT 0)
SELECT * FROM tb_TreatRecord