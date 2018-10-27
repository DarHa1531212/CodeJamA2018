USE master

IF EXISTS(select * from sys.databases where name='CGICodeJamA2018')
DROP DATABASE CGICodeJamA2018
GO

CREATE DATABASE CGICodeJamA2018
GO


USE CGICodeJamA2018
GO
IF OBJECT_ID ('tblUser') IS NOT NULL
DROP TABLE tblUser
GO

CREATE TABLE tblUser
(
	noEmploye		Varchar	(25)		NOT NULL UNIQUE,
	prenomNom		varchar (50)		NOT NULL, 
	motPasse		varchar (50)		NOT NULL DEFAULT 'motpasse',
	gold			INT					NOT NULL DEFAULT 0,
	xpTotal			INT					NOT NULL DEFAULT 0,
	dateEmbaudhe	DATE				NOT NULL,


	PRIMARY KEY (noEmploye)
)



IF OBJECT_ID ('tblBadge') IS NOT NULL
DROP TABLE tblBadge
GO

CREATE TABLE tblBadge
(
	idbadge				int NOT NULL UNIQUE IDENTITY (1,1),
	nombadge			varchar (25),
	descriptionbadge	varchar (200),
	PRIMARY KEY  (idbadge)
)

IF OBJECT_ID ('tbluserBadge') IS NOT NULL
DROP TABLE tbluserBadge
GO

CREATE TABLE tbluserBadge
(
	idUser				varchar (25) NOT NULL,
	idBadge				int NOT NULL,
	dateObtention		date NOT NULL,	
)

IF OBJECT_ID ('tblNiveau') IS NOT NULL
DROP TABLE idNiveau
GO

CREATE TABLE idNiveau
(
	idNiveau			int NOT NULL UNIQUE IDENTITY (1,1),
	xpMinNiveau			int NOT NULL UNIQUE,
	PRIMARY KEY  (idNiveau)
)
