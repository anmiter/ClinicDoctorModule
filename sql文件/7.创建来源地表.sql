USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Provenance') IS NOT NULL
DROP TABLE tb_Provenance;
GO
CREATE TABLE tb_Provenance
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)：自增长，起始值1，增量1*/
		NOT NULL
	CONSTRAINT pk_Provenance_No
		PRIMARY KEY(No)
	,Name
		VARCHAR(50))

INSERT INTO tb_Provenance
	(Name)
	VALUES
	('河北'),
	('山西'),
	('辽宁'),
	('吉林'),
	('黑龙江'),
	('江苏'),
	('浙江'),
	('安徽'),
	('福建'),
	('江西'),
	('山东'),
	('河南'),
	('湖北'),
	('湖南'),
	('广东'),
	('海南'),
	('四川'),
	('贵州'),
	('云南'),
	('陕西'),
	('甘肃'),
	('青海'),
	('台湾'),
	('内蒙古自治区'),
	('广西壮族自治区'),
	('西藏自治区'),
	('宁夏回族自治区'),
	('新疆维吾尔自治区'),
	('北京'),
	('天津'),
	('上海'),
	('重庆'),
	('香港'),
	('澳门')

SELECT * FROM tb_Provenance