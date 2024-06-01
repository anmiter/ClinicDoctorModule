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
		VARCHAR(50)
	,HostipalNo
		INT	
		CONSTRAINT fk_Department_HostipalNo
		FOREIGN KEY (HostipalNo)
		REFERENCES tb_Hostipal(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE)

INSERT INTO tb_Department
	(Name,HostipalNo)
	VALUES
	('国医堂','1'),
	('治未病科','1'),
	('国医堂针推','1'),
	('心血管科','1'),
	('内分泌科','1'),
	('肺病科','1'),
	('老年病科','1'),
	('神经内科','1'),
	('肾病科','1'),
	('脾胃病科','1'),
	('肿瘤科','1'),
	('肝胆科','1'),
	('血液科','1'),
	('脑病康复专科','1'),
	('康复门诊','1'),
	('男科门诊','1'),
	('高血压专病门诊','1'),
	('普外科','1'),
	('泌尿外科','1'),
	('肛肠科','1'),
	('皮肤科','1'),
	('骨伤科','1'),
	('疼痛门诊','1'),
	('脊柱病门诊','1'),
	('妇科','1'),
	('不孕不育科','1'),
	('儿科','1'),
	('眼科','1'),
	('耳鼻咽喉科','1'),
	('口腔科','1'),
	('中医护理门诊','1'),
	('血管通路护理门诊','1'),
	('康复医学科','1'),
	('针灸科','1'),
	('推拿科','1'),
	('针刀门诊','1')

SELECT * FROM tb_Department
