USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Bill') IS NOT NULL
DROP TABLE tb_Bill;
GO
CREATE TABLE tb_Bill
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)：自增长，起始值1，增量1*/
		NOT NULL
		CONSTRAINT pk_Bill_No
		PRIMARY KEY(No)
	,PaitentIDCard
		VARCHAR(50)
	,Hostipal
		VARCHAR(500)
	,DepartmentNo
		INT
	,DoctorNo
		VARCHAR(50)
	,MedicinesCost
		DECIMAL(18,2)
	,ExamineCost
		DECIMAL(18,2)
	,CopayFee
		DECIMAL(18,2)
	,TotalCost
		AS (MedicinesCost+ExamineCost+CopayFee)
	,Date
		DATE
	,State
		BIT)