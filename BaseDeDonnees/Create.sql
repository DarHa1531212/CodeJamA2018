USE master

IF EXISTS(select * from sys.databases where name='CGICodeJamA2018')
DROP DATABASE CGICodeJamA2018
GO

CREATE DATABASE CGICodeJamA2018
GO

--ALTER DATABASE CGICodeJamA2018
--SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

USE CGICodeJamA2018
GO
IF OBJECT_ID ('tblUser') IS NOT NULL
DROP TABLE tblUser
GO

CREATE TABLE tblUser
(
	
	idemploye		int					NOT NULL UNIQUE IDENTITY(1,1),
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
	idUser				int NOT NULL,
	idBadge				int NOT NULL,
	dateObtention		date NOT NULL,	
)

IF OBJECT_ID ('tblNiveau') IS NOT NULL
DROP TABLE tblNiveau
GO

CREATE TABLE tblNiveau
(
	idNiveau			int NOT NULL UNIQUE IDENTITY (1,1),
	xpMinNiveau			int NOT NULL UNIQUE,
	PRIMARY KEY  (idNiveau)
)


IF OBJECT_ID ('tblGainXP') IS NOT NULL
DROP TABLE tblGainXP
GO

CREATE TABLE tblGainXP
(
	idCauseGain		int		NOT NULL UNIQUE IDENTITY (1,1),
	nomCauseGain	varchar (25) NOT NULL UNIQUE,
	PRIMARY KEY  (idCauseGain)
)	

IF OBJECT_ID ('tblXPGagne') IS NOT NULL
DROP TABLE tblXPGagne
GO

CREATE TABLE tblXPGagne
(
	idGainXP			int		NOT NULL UNIQUE IDENTITY (1,1),
	idUser				int		NOT NULL ,
	dateXPGagne			date	NOT NULL,
	idCauseGainXP		int		NOT NULL,
	qteXPGagne			INT		not null,
	PRIMARY KEY  (idGainXP)
)


IF OBJECT_ID ('tblCheckIn') IS NOT NULL
DROP TABLE tblCheckIn
GO

CREATE TABLE tblCheckIn
(
	idCheckIn			int		NOT NULL UNIQUE IDENTITY (1,1),
	idUser				int		NOT NULL ,
	accepte				bit		NOT NULL,
	dateCheckIn			date	NOT NULL,
	PRIMARY KEY  (idCheckIn)
)

IF OBJECT_ID ('tblDonAgreabilite') IS NOT NULL
DROP TABLE tblDonAgreabilite
GO

CREATE TABLE tblDonAgreabilite
(
	idDonAgreabilite	int		NOT NULL UNIQUE IDENTITY (1,1),
	idEnvoyeur			int		not null,
	idReceveur			int		NOT NULL ,
	qteGoldEnvoye		int		NOT NULL,
	idRaisonEnvoi		int		not null,
	descriptionSupp		varchar(200) null,
	dateEnvoi			date	not null,
	PRIMARY KEY  (idDonAgreabilite)
)

IF OBJECT_ID ('tblraisonAgreabilite') IS NOT NULL
DROP TABLE tblraisonAgreabilite
GO

CREATE TABLE tblraisonAgreabilite
(
	idRaison	int		NOT NULL UNIQUE IDENTITY (1,1),
	nomRaison	varchar	(25) not null unique,

	PRIMARY KEY  (idRaison)
)

ALTER TABLE tblCheckin
ADD FOREIGN KEY (idUser) REFERENCES tblUser (idemploye)

ALTER TABLE tblDonAgreabilite
add foreign key (idEnvoyeur) REFERENCES tblUser (idemploye)

ALTER TABLE tblDonAgreabilite
add foreign key (idReceveur) REFERENCES tblUser (idemploye)

alter table tblXPGagne 
add foreign key (idUser) REFERENCES tblUser (idemploye)

alter table tblXPGagne 
add foreign key (idCauseGainXP) REFERENCES tblGainXP (idCauseGain)

alter table tbluserBadge
add foreign key (idUser) REFERENCES tblUser (idemploye)

alter table tblUserBadge
add foreign key (idBadge) REFERENCES tblBadge (idBadge)

alter table tblDonAgreabilite
add foreign key (idRaisonEnvoi) REFERENCES tblraisonAgreabilite (idRaion)
