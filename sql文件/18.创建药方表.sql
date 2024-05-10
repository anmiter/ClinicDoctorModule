USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Prescription') IS NOT NULL
DROP TABLE tb_Prescription;
GO
CREATE TABLE tb_Prescription
	(No
		VARCHAR(50)
	,DrugNo
		INT
	,Type
		VARCHAR(50)
	,Number
		INT
	,Unit
		VARCHAR(50)
	,Usage
		VARCHAR(50)
	,Dosage
		VARCHAR(50)
	,Times
		INT
	,DAYS
		INT)