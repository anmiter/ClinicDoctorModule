USE OutpatientClinicDoctorDB
IF OBJECT_ID('tb_Queue') IS NOT NULL
DROP TABLE tb_Queue;
GO
CREATE TABLE tb_Queue
	(DoctorNo
		VARCHAR(50)
		CONSTRAINT fk_Queue_DoctorNo
		FOREIGN KEY (DoctorNo)
		REFERENCES tb_Doctor(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,PaitentIDCard
		VARCHAR(50)
		CONSTRAINT fk_Queue_PaitentIDCard
		FOREIGN KEY (PaitentIDCard)
		REFERENCES tb_Patient(PatientIDCard)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Date
		DATE
	,Number
		INT
	,StateNo
		INT
		DEFAULT 1)

INSERT INTO tb_Queue
	(DoctorNo,PaitentIDCard,Date,Number)
	VALUES
	('1989001','350273847261983763','2024-5-10',1),
	('1989001','350283722938401934','2024-5-10',2),
	('1989001','350427200401214025','2024-5-10',3)

SELECT * FROM tb_Queue