USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Drug') IS NOT NULL
DROP TABLE tb_Drug;
GO
CREATE TABLE tb_Drug
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)：自增长，起始值1，增量1*/
		NOT NULL
	CONSTRAINT pk_Drug_No
		PRIMARY KEY(No)
	,ChineseName
		VARCHAR(50)
	,EnglishName
		VARCHAR(50)
	,Pinyin
		VARCHAR(50)
	,Treat
		VARCHAR(250)
	,UnitNo
		INT
		CONSTRAINT fk_Drug_UnitNo
		FOREIGN KEY (UnitNo)
		REFERENCES tb_Unit(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Price
		DECIMAL(18,2))

INSERT INTO tb_Drug
	(ChineseName,EnglishName,Pinyin,Treat,UnitNo,Price)
	VALUES
	('盐酸氮卓斯汀片','Azelastine Hydrochloride Tablets','yansuandanzhuosidingpian','抗过敏',8,12.80),
	('匹维溴铵片','Pinaverium Bromide Tablets','piweixiuanjianpian','肠道或胆道功能紊乱有关的疼痛',8,19.50),
	('头孢克肟胶囊','Cefix Me Capsules','toubaokewojiaonang','急性支气管炎、肺炎、膀胱炎、胆囊炎、中耳炎',10,22.70),
	('枫蓼肠胃康颗粒','Fengliao Changweikang Keli','fengliaochangweikangkeli','清热除湿化滞',1,9.50),
	('夫西地酸钠软膏','Sodium Fusidate Ointment','fuxidisuannaruangao','脓包疮、浅表性毛囊炎、寻常须疮、甲沟炎',11,18.20),
	('曲安奈德益康唑乳膏','Pevisone','quannaideyikaozuolangao','皮炎、湿疹、手足癣、体癣、甲沟炎',11,15.80)

SELECT * FROM tb_Drug