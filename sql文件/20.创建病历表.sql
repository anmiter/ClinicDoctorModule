USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_MedicalRecord') IS NOT NULL
DROP TABLE tb_MedicalRecord;
GO
CREATE TABLE tb_MedicalRecord
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)：自增长，起始值1，增量1*/
		NOT NULL
		CONSTRAINT pk_MedicalRecord_No
		PRIMARY KEY(No)
	,PatientIDCard
		VARCHAR(50)
	,Hospital
		VARCHAR(500)
	,DepartmentNo
		INT
	,DoctorNo
		VARCHAR(50)
	,Date
		DATE
	,Description
		VARCHAR(1000)
	,Result
		VARCHAR(500)
	,PrescriptionNo
		VARCHAR(50)
	,ExamineItemsNo
		VARCHAR(50))