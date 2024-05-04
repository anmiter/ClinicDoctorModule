USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_ExamineItem') IS NOT NULL
DROP TABLE tb_ExamineItem;
GO
CREATE TABLE tb_ExamineItem
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
	CONSTRAINT pk_ExamineItem_No
		PRIMARY KEY(No)
	,Name
		VARCHAR(100)
	,Pinyin
		VARCHAR(100)
	,TypeNo
		INT
		CONSTRAINT fk_ExamineItem_TypeNo
		FOREIGN KEY (TypeNo)
		REFERENCES tb_ExamineType(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Price
		DECIMAL(18,2)
	,Introduction
		VARCHAR(1000))

INSERT INTO tb_ExamineItem
	(Name,Pinyin,TypeNo,Price,Introduction)
	VALUES
	('Ѫ����','xuechanggui',1,45,'������ϸ����������ϸ��������Ѫ�쵰��Ũ�ȵȣ���������ƶѪ����Ⱦ����Ѫ����ѪҺ��ؼ���'),
	('�������','shenghuajiancha',1,180,'�����ι��ܡ������ܡ�Ѫ֬��Ѫ�ǵȣ������˽���������ٵĹ���״̬���Լ��Ƿ���ڴ�л�쳣'),
	('��Ѫ���ܼ��','ningxuegongnengjiancha',1,100,'����ѪҺ������������������ǰ������Ѫ˨�Լ��������'),
	('�򳣹�','niaochanggui',2,18,'��������ء���pHֵ���򵰰ס����ǵȣ���������ϵͳ�����ĳ���ɸ��'),
	('��������','niaochenzhajiancha',2,25,'�۲���Һ�е�ϸ�������͵ȣ�������������ס���·��Ⱦ�ȼ���'),
	('B��','Bchao',3,200,'���ó�����ԭ���۲������ڲ��ṹ�������ڸΡ������ȡ�Ƣ�������ӹ������������ٵļ��'),
	('X��','Xguang',3,130,'����X���ߴ�͸���壬�۲�������β��Ƚṹ�������ڹ��ۡ����׵ȼ��������'),
	('CT','ct',3,800,'������ϲ�ɨ�裬ͨ�����X���߲������ϣ����������ڲ�������ͼ�񣬳�������������Ѫ�ܼ��������'),
	('MRI','mri',3,1200,'�Ź���������ôų�����Ƶ�����������ڲ�����ϸͼ�񣬶�����֯�ֱ��ʸߣ���������ϵͳ���ؽڵȼ��������'),
	('�ĵ�ͼ���','xindiantujiancha',4,60,'ͨ����¼����ĵ����������๦�ܣ�����������ʧ�����ļ�ȱѪ�����༲�������'),
	('θ��','weijing',5,780,'ͨ����ǻ���룬�۲�ʳ����θ��ʮ��ָ�����Ĥ�����������θ����θ�ס�ʳ�ܰ��ȼ��������'),
	('����','changjing',5,550,'ͨ�����Ž��룬�۲�᳦��ֱ�����Ĥ����������ڽ᳦�ס���Ϣ�⡢�����ȼ��������'),
	('����ͿƬ','gongjingtupian',6,200,'�ɼ�����ϸ�����м�飬���ڹ�������ɸ��'),
	('���ټ��','ruxianjiancha',6,1280,'�������������B��������������������ϣ����ٰ���ɸ��'),
	('�Ե�ͼ','naodiantu',7,300,'��¼���Եĵ������������׵���ϵͳ���������'),
	('���ܶȼ��','gudumingdujiancha',7,300,'������������״���������ڹ������ɵ����'),
	('������','jiyinjiancha',7,1500,'ͨ�����������У�Ԥ�⻼ĳ�ּ����ķ��գ��������Ŵ��Լ��������')

SELECT * FROM tb_ExamineItem