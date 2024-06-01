USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_ExaminationList') IS NOT NULL
DROP TABLE tb_ExaminationList;
GO
CREATE TABLE tb_ExaminationList
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
	,Result
		VARCHAR(250)
	,Price
		DECIMAL(18,2))