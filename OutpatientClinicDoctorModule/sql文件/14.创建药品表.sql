USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Drug') IS NOT NULL
DROP TABLE tb_Drug;
GO
CREATE TABLE tb_Drug
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
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
	('���ᵪ׿˹͡Ƭ','Azelastine Hydrochloride Tablets','yansuandanzhuosidingpian','������',8,12.80),
	('ƥά���Ƭ','Pinaverium Bromide Tablets','piweixiuanjianpian','�����򵨵����������йص���ʹ',8,19.50),
	('ͷ�߿�뿽���','Cefix Me Capsules','toubaokewojiaonang','����֧�����ס����ס������ס������ס��ж���',10,22.70),
	('��ޤ��θ������','Fengliao Changweikang Keli','fengliaochangweikangkeli','���ȳ�ʪ����',1,9.50),
	('�������������','Sodium Fusidate Ointment','fuxidisuannaruangao','ŧ������ǳ����ë���ס�Ѱ���봯���׹���',11,18.20),
	('�����ε��濵�����','Pevisone','quannaideyikaozuolangao','Ƥ�ס�ʪ�����Ѣ����Ѣ���׹���',11,15.80)

SELECT * FROM tb_Drug