USE master
IF EXISTS(select * from sys.databases where name='CGICodeJamA2018')
DROP DATABASE CGICodeJamA2018
GO

CREATE DATABASE CGICodeJamA2018
GO


USE CGICodeJamA2018
GO

--	--------------------------------------------
IF OBJECT_ID ('tblUser') IS NOT NULL
DROP TABLE tblUser
GO

CREATE TABLE tblUser
(
	noEmploye		Varchar	(25)					NOT NULL IDENTITY(1,1) UNIQUE,
	nbrePts		INT,
	PRIMARY KEY (idUser)
)

GO