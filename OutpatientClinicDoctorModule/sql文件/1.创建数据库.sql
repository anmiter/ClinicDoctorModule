USE master;
IF DB_ID('OutpatientClinicDoctorDB') IS NOT NULL
	BEGIN
		ALTER DATABASE OutpatientClinicDoctorDB
			SET SINGLE_USER
			WITH ROLLBACK IMMEDIATE;
		DROP DATABASE OutpatientClinicDoctorDB;
	END
GO
CREATE DATABASE OutpatientClinicDoctorDB
	ON
		(NAME='DataFile_1'
		,FILENAME='D:\OutpatientClinicDoctor\OutpatientClinicDoctorDB\Data\DataFile_1.mdf')
	LOG ON
		(NAME='l=LogFile_1'
		,FILENAME='D:\OutpatientClinicDoctor\OutpatientClinicDoctorDB\Log\LogFile_1.ldf');