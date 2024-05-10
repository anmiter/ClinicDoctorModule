USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_ExamineItems') IS NOT NULL
DROP TABLE tb_ExamineItems;
GO
CREATE TABLE tb_ExamineItems
	(No
		VARCHAR(50)
	,ExamineNo
		INT
		CONSTRAINT fk_ExamineItems_ExamineNo
		FOREIGN KEY (ExamineNo)
		REFERENCES tb_ExamineItem(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Time
		SMALLDATETIME
	,Result
		VARCHAR(2000))