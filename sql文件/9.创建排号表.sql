USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Queue') IS NOT NULL
DROP TABLE tb_Queue;
GO
CREATE TABLE tb_Queue
	(DoctorNo
		VARCHAR(50)
		CONSTRAINT fk_Queue_DoctorNo
		FOREIGN KEY (DoctorNo)
		REFERENCES tb_Doctor(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,PaitentNo
		VARCHAR(50)
		CONSTRAINT fk_Queue_PaitentNo
		FOREIGN KEY (PaitentNo)
		REFERENCES tb_Patient(PatientIDCard)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Date
		DATE
	,Number
		INT
	,StateNo
		INT)