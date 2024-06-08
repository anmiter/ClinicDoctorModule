USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Department') IS NOT NULL
DROP TABLE tb_Department;
GO
CREATE TABLE tb_Department
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)：自增长，起始值1，增量1*/
		NOT NULL
	CONSTRAINT pk_Department_No
		PRIMARY KEY(No)
	,Name
		VARCHAR(50))
INSERT INTO tb_Department
	(Name)
	VALUES
	('国医堂'),
	('治未病科'),
	('国医堂针推'),
	('心血管科'),
	('内分泌科'),
	('肺病科'),
	('老年病科'),
	('神经内科'),
	('肾病科'),
	('脾胃病科'),
	('肿瘤科'),
	('肝胆科'),
	('血液科'),
	('脑病康复专科'),
	('康复门诊'),
	('男科门诊'),
	('高血压专病门诊'),
	('普外科'),
	('泌尿外科'),
	('肛肠科'),
	('皮肤科'),
	('骨伤科'),
	('疼痛门诊'),
	('脊柱病门诊'),
	('妇科'),
	('不孕不育科'),
	('儿科'),
	('眼科'),
	('耳鼻咽喉科'),
	('口腔科'),
	('中医护理门诊'),
	('血管通路护理门诊'),
	('康复医学科'),
	('针灸科'),
	('推拿科'),
	('针刀门诊')

SELECT * FROM tb_Department
