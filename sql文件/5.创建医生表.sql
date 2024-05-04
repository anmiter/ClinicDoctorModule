USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Doctor') IS NOT NULL
DROP TABLE tb_Doctor;
GO
CREATE TABLE tb_Doctor
	(No
		VARCHAR(50)
		NOT NULL
	CONSTRAINT pk_Doctor_No
		PRIMARY KEY(No)
	,Password
		VARCHAR(50)
	,Name
		VARCHAR(50)
	,Gender
		BIT
	,Age
		INT
	,BirthDate
		DATE
	,Identification
		VARCHAR(50)
	,Telephone
		VARCHAR(50)
	,QQEmail
		VARCHAR(50)
	,DepartmentNo
		INT
		CONSTRAINT fk_Doctor_DepartmentNo
		FOREIGN KEY (DepartmentNo)
		REFERENCES tb_Department(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,TitleNo
		INT
		CONSTRAINT fk_Doctor_TitleNo
		FOREIGN KEY (TitleNo)
		REFERENCES tb_Title(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Introduction
		VARCHAR(1000)
	,Avatar
		VARBINARY(MAX))

INSERT INTO tb_Doctor
	(No,Password,Name,Gender,Age,BirthDate,Identification,Telephone,QQEmail,DepartmentNo,TitleNo,Introduction)
	VALUES
	('1989001',HASHBYTES('MD5','13022389239'),'蔡立勉',1,63,'1961-3-23','350427196103234010','13022389239','3454634841@qq.com',10,4,'擅长胃肠病和肝病的诊治'),
	('2008016',HASHBYTES('MD5','13028716229'),'邱丽贞',0,35,'1989-5-29','350427198905293028','13028716229','2837482929@qq.com',25,3,'乳腺、甲状腺疾病综合诊治，甲状腺、腹股沟疝、切口疝等腹壁疝的腔镜微创治疗'),
	('2000009',HASHBYTES('MD5','13028716429'),'高玉玲',0,43,'1981-10-10','350427198110101826','13028716429','1928238145@qq.com',25,4,'妇科肿瘤，宫颈疾病，生殖道感染性疾病、月经量多、阴道出血等'),
	('2012003',HASHBYTES('MD5','13028716266'),'曾华科',1,37,'1987-5-30','350427198705302313','13028716266','6574233172@qq.com',28,3,'眼底病、黄斑疾病、视网膜脱离、糖尿病视网膜病变、眼外伤、玻璃体积血、白内障的手术治疗'),
	('1998025',HASHBYTES('MD5','13029878829'),'吕绍光',1,58,'1966-6-2','350427196606024712','13029878829','2837666273@qq.com',26,4,'不孕症、月经失调、痛经以及妇科炎症、糖尿病、甲状腺疾病以及肥胖症等'),
	('2018014',HASHBYTES('MD5','13028372839'),'施小妹',0,36,'1988-12-5','350427198812055623','13028372839','3827648812@qq.com',23,3,'颈肩腰腿痛，神经痛，癌痛综合管理，失眠四高等亚健康状态调理'),
	('2020032',HASHBYTES('MD5','13228372293'),'郑益新',1,31,'1993-12-28','350427199312281112','13228372293','3948273771@qq.com',24,2,'腰腿痛，颈椎病，腰椎间盘突出症，骨质疏松，腱鞘炎，腱鞘囊肿，腕管综合症，关节炎'),
	('2016008',HASHBYTES('MD5','13027382718'),'林丽容',0,37,'1987-8-19','350427198708191426','13027382718','1119230293@qq.com',4,2,'高血压，急慢性心衰，冠心病，心律失常，心肌病，高血脂等内科常见疾病的诊治'),
	('1999011',HASHBYTES('MD5','13527839920'),'林毅',1,52,'1972-1-4','350427197201044318','13527839920','2837889898@qq.com',30,3,'骨量不足的牙列缺损、牙列缺失的种植治疗，老年人的种植、补牙、烤瓷牙、整牙、牙结石、牙周病、氟斑牙的治疗');

SELECT * FROM tb_Doctor