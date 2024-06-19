USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Title') IS NOT NULL
DROP TABLE tb_Title;
GO
CREATE TABLE tb_Title
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)：自增长，起始值1，增量1*/
		NOT NULL
	CONSTRAINT pk_Title_No
		PRIMARY KEY(No)
	,Name
		VARCHAR(50)
	,CounselingCost
		DECIMAL(18,2))

INSERT INTO tb_Title
	(Name,CounselingCost)
	VALUES
	('主任医师',50),
	('副主任医师',40),
	('主治医师',35),
	('住院医师',30);

SELECT * FROM tb_Title