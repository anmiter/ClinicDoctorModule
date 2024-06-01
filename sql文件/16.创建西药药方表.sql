USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Prescription') IS NOT NULL
DROP TABLE tb_Prescription;
GO
CREATE TABLE tb_Prescription
	(No
		VARCHAR(50)
	,DrugNo
		INT
		CONSTRAINT fk_Prescription_DrugNo
		FOREIGN KEY (DrugNo)
		REFERENCES tb_Drug(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Number
		INT
	,Frequency
		INT
	,Days
		INT
	,Usage
		INT
	,Price
		DECIMAL(18,2))