USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_TCMList') IS NOT NULL
DROP TABLE tb_TCMList;
GO
CREATE TABLE tb_TCMList
	(No
		VARCHAR(50)
	,Date
		DATE
	,HealthCardNo
		VARCHAR(50)
		CONSTRAINT fk_TCMList_HealthCardNo
		FOREIGN KEY (HealthCardNo)
		REFERENCES tb_Patient(HealthCardNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,DoctorNo
		VARCHAR(50)
		CONSTRAINT fk_TCMList_DoctorNo
		FOREIGN KEY (DoctorNo)
		REFERENCES tb_Doctor(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Days
		INT
	,Number
		INT
	,IsHelp
		BIT
	,Price
		DECIMAL(18,2))