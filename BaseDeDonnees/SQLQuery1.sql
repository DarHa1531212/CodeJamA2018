--USE master
--USE CGICodeJamA2018

IF EXISTS(select * from sys.databases where name='CGICodeJamA2018')
DROP DATABASE CGICodeJamA2018
GO

CREATE DATABASE CGICodeJamA2018
GO


USE CGICodeJamA2018
GO

--	--------------------------------------------
IF OBJECT_ID ('tblUser') IS NOT NULL
DROP TABLE CGICodeJamA2018.tblUser
GO

CREATE TABLE CGICodeJamA2018.tblUser
(
	noEmploye		Varchar	(25)		NOT NULL UNIQUE,
	prenomNom		varchar (50)		NOT NULL, 
	motPasse		varchar (50)		NOT NULL DEFAULT 'motpasse',
	gold			INT					NOT NULL DEFAULT 0,
	xpTotal			INT					NOT NULL DEFAULT 0,
	dateEmbaudhe	DATE				NOT NULL,


	PRIMARY KEY (noEmploye)
)

GO