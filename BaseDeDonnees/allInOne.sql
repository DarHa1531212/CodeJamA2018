--USE master

--IF EXISTS(select * from sys.databases where name='CGICodeJamA2018')
--DROP DATABASE CGICodeJamA2018
--GO

--CREATE DATABASE CGICodeJamA2018
--GO

--ALTER DATABASE CGICodeJamA2018
--SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

--USE CGICodeJamA2018
--GO
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
	nombadge			varchar (100),
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
add foreign key (idRaisonEnvoi) REFERENCES tblraisonAgreabilite (idRaison)


--insert starts here


INSERT INTO tblUser (	noEmploye	,	prenomNom			,	motPasse		,	xpTotal	,	dateEmbaudhe	,	gold	)	Values
					(	'1'			,	'Ananseth'			,	'Mot de passe'	,	559		,	'2020-12-08'	,	49		)	,
					(	'2'			,	'Anoshnornar'		,	'Mot de passe'	,	1410	,	'2021-11-19'	,	119		)	,
					(	'3'			,	'Ashariya'			,	'Mot de passe'	,	819		,	'2018-06-18'	,	11		)	,
					(	'4'			,	'Ashersan'			,	'Mot de passe'	,	1068	,	'2018-10-05'	,	102		)	,
					(	'5'			,	'Cersil'			,	'Mot de passe'	,	939		,	'2021-09-20'	,	21		)	,
					(	'6'			,	'Charosshen'		,	'Mot de passe'	,	878		,	'2022-08-12'	,	80		)	,
					(	'7'			,	'Chenassean'		,	'Mot de passe'	,	154		,	'2020-01-31'	,	145		)	,
					(	'8'			,	'Cheroshu'			,	'Mot de passe'	,	496		,	'2023-05-23'	,	53		)	,
					(	'9'			,	'Chyshysseth'		,	'Mot de passe'	,	1005	,	'2025-03-28'	,	33		)	,
					(	'10'		,	'Hynser'			,	'Mot de passe'	,	1985	,	'2021-12-02'	,	156		)	,
					(	'11'		,	'Hysnor'			,	'Mot de passe'	,	1264	,	'2025-10-01'	,	36		)	,
					(	'12'		,	'Hædarshen'			,	'Mot de passe'	,	1160	,	'2022-07-20'	,	153		)	,
					(	'13'		,	'Iseshisha'			,	'Mot de passe'	,	798		,	'2020-06-25'	,	119		)	,
					(	'14'		,	'Shamusnorser'		,	'Mot de passe'	,	138		,	'2018-05-18'	,	24		)	,
					(	'15'		,	'Shamyssila'		,	'Mot de passe'	,	514		,	'2024-02-04'	,	182		)	,
					(	'16'		,	'Shanyseannar'		,	'Mot de passe'	,	897		,	'2019-05-20'	,	130		)	,
					(	'17'		,	'Shariderish'		,	'Mot de passe'	,	181		,	'2020-03-25'	,	43		)	,
					(	'18'		,	'Shimasashaesh'		,	'Mot de passe'	,	1458	,	'2019-04-13'	,	54		)	,
					(	'19'		,	'Shoryso'			,	'Mot de passe'	,	847		,	'2021-09-02'	,	16		)	,
					(	'20'		,	'Shænæseru'			,	'Mot de passe'	,	1663	,	'2022-07-12'	,	95		)	,
					(	'21'		,	'Solushshœresh'		,	'Mot de passe'	,	26		,	'2025-09-09'	,	21		)	,
					(	'22'		,	'Solyssin'			,	'Mot de passe'	,	454		,	'2025-07-23'	,	50		)	,
					(	'23'		,	'Sorosyosha'		,	'Mot de passe'	,	1216	,	'2021-12-13'	,	9		)	,
					(	'24'		,	'Ushyssir'			,	'Mot de passe'	,	819		,	'2022-08-04'	,	102		)	,
					(	'25'		,	'Usæyosh'			,	'Mot de passe'	,	1328	,	'2019-01-22'	,	68		)	,
					(	'26'		,	'Amynder'			,	'Mot de passe'	,	1063	,	'2021-06-13'	,	41		)	,
					(	'27'		,	'Anisshœrseth'		,	'Mot de passe'	,	159		,	'2023-06-10'	,	82		)	,
					(	'28'		,	'Ceræsen'			,	'Mot de passe'	,	1004	,	'2022-11-12'	,	60		)	,
					(	'29'		,	'Cysshel'			,	'Mot de passe'	,	307		,	'2019-12-12'	,	92		)	,
					(	'30'		,	'Eshæiash'			,	'Mot de passe'	,	94		,	'2021-01-01'	,	146		)	,
					(	'31'		,	'Esshœr'			,	'Mot de passe'	,	1368	,	'2020-05-08'	,	135		)	,
					(	'32'		,	'Hushsearsen'		,	'Mot de passe'	,	397		,	'2018-09-17'	,	8		)	,
					(	'33'		,	'Oshomireily'		,	'Mot de passe'	,	1004	,	'2023-10-18'	,	121		)	,
					(	'34'		,	'Ososhsuri'			,	'Mot de passe'	,	1419	,	'2018-11-16'	,	184		)	,
					(	'35'		,	'Sanossirnoreil'	,	'Mot de passe'	,	704		,	'2018-09-13'	,	18		)	,
					(	'36'		,	'Sarirorsha'		,	'Mot de passe'	,	1034	,	'2019-07-19'	,	68		)	,
					(	'37'		,	'Seressurnarel'		,	'Mot de passe'	,	1976	,	'2020-04-04'	,	33		)	,
					(	'38'		,	'Serinoreilel'		,	'Mot de passe'	,	940		,	'2022-06-23'	,	200		)	,
					(	'39'		,	'Seræsham'			,	'Mot de passe'	,	981		,	'2019-06-07'	,	114		)	,
					(	'40'		,	'Shamorish'			,	'Mot de passe'	,	1810	,	'2023-07-31'	,	29		)	,
					(	'41'		,	'Shamunsan'			,	'Mot de passe'	,	107		,	'2021-11-28'	,	108		)	,
					(	'42'		,	'Shanara'			,	'Mot de passe'	,	151		,	'2022-12-13'	,	78		)	,
					(	'43'		,	'Shissormireil'		,	'Mot de passe'	,	1116	,	'2018-08-03'	,	78		)	,
					(	'44'		,	'Sinues'			,	'Mot de passe'	,	1179	,	'2019-07-16'	,	136		)	,
					(	'45'		,	'Soloelsor'			,	'Mot de passe'	,	1650	,	'2019-07-05'	,	46		)	,
					(	'46'		,	'Sorarorsha'		,	'Mot de passe'	,	1322	,	'2025-03-28'	,	15		)	,
					(	'47'		,	'Soronas'			,	'Mot de passe'	,	316		,	'2019-11-23'	,	151		)	,
					(	'48'		,	'Yshisearishæ'		,	'Mot de passe'	,	204		,	'2023-01-21'	,	21		)	,
					(	'49'		,	'Œonsan'			,	'Mot de passe'	,	343		,	'2020-05-06'	,	58		)	,
					(	'50'		,	'Æeyeaes'			,	'Mot de passe'	,	1120	,	'2025-03-07'	,	181		)	

SET IDENTITY_INSERT tblBadge ON

INSERT INTO tblBadge	(	idbadge	,	nombadge						,	descriptionbadge						)	Values
						(	1		,	'Bois'							,	'Atteindre le niveau 1'					)	,
						(	2		,	'Étain'							,	'Atteindre le niveau 5'					)	,
						(	3		,	'Cristal'						,	'Atteindre le niveau 10'				)	,
						(	4		,	'Saphir'						,	'Atteindre le niveau 15'				)	,
						(	5		,	'Opale'							,	'Atteindre le niveau 20'				)	,
						(	6		,	'Jade'							,	'Atteindre le niveau 25'				)	,
						(	7		,	'Diamant'						,	'Atteindre le niveau 30'				)	,
						(	8		,	'Jeune'							,	'Atteindre 1 an d"ancienneté'			)	,
						(	9		,	'Adolescent'					,	'Atteindre 5 ans d"ancienneté'			)	,
						(	10		,	'jeune Adulte'					,	'Atteindre 10 ans d"ancienneté'			)	,
						(	11		,	'Adulte'						,	'Atteindre 15 ans d"ancienneté'			)	,
						(	12		,	'Âge mûr'						,	'Atteindre 20 ans d"ancienneté'			)	,
						(	13		,	'Sénior'						,	'Atteindre 25 ans d"ancienneté'			)	,
						(	14		,	'Grand maître'					,	'Atteindre 30 ans d"ancienneté'			)	,
						(	15		,	'Vénérable'						,	'Atteindre 35 ans d"ancienneté'			)	,
						(	16		,	'En fin de vie'					,	'Atteindre 40 ans d"ancienneté'			)	,
						(	17		,	'Party de Noël'					,	'Être présent au party de Noël'			)	,
						(	18		,	'Participation aux activités'	,	'Être présent à 100% des activités'		)	,
						(	19		,	'Participation aux activités'	,	'Être présent à 75% des activités'		)	,
						(	20		,	'Participation aux activités'	,	'Être présent à 50% des activités'		)	,
						(	21		,	'Participation au jeu'			,	'Participer à 100% du programme de jeu'	)	,
						(	22		,	'Participation au jeu'			,	'Participer à 75% du programme de jeu'	)	,
						(	23		,	'Participation au jeu'			,	'Participer à 50% du programme de jeu'	)	,
						(	24		,	'Ratio'  						,	'Être premier au classement du ratio'	)	,
						(	25		,	'Ratio'							,	'Être deuxième au classement du ratio'	)	,
						(	26		,	'Ratio'							,	'Être troisième au classement du ratio'	)	,
						(	27		,	'Agréabilité'					,	'Être agréable à cotôyer'				)	

SET IDENTITY_INSERT tblBadge OFF

INSERT INTO tbluserBadge	(	idUser	,	idbadge	,	dateObtention	)	Values
							(	1		,	1		,	'2023-03-22'	)	,
							(	1		,	8		,	'2018-12-09'	)	,
							(	2		,	1		,	'2018-03-09'	)	,
							(	2		,	8		,	'2024-03-17'	)	,
							(	3		,	1		,	'2022-01-02'	)	,
							(	3		,	8		,	'2020-11-28'	)	,
							(	4		,	1		,	'2024-07-20'	)	,
							(	4		,	8		,	'2019-12-08'	)	,
							(	4		,	17		,	'2025-07-17'	)	,
							(	5		,	1		,	'2023-01-02'	)	,
							(	5		,	8		,	'2023-11-18'	)	,
							(	5		,	17		,	'2023-12-15'	)	,
							(	6		,	1		,	'2020-04-08'	)	,
							(	6		,	8		,	'2025-06-04'	)	,
							(	7		,	1		,	'2022-10-24'	)	,
							(	7		,	8		,	'2024-10-01'	)	,
							(	8		,	1		,	'2021-10-18'	)	,
							(	8		,	8		,	'2020-11-21'	)	,
							(	9		,	1		,	'2020-01-20'	)	,
							(	9		,	8		,	'2018-01-15'	)	,
							(	9		,	17		,	'2021-03-22'	)	,
							(	9		,	27		,	'2018-11-03'	)	,
							(	10		,	1		,	'2024-07-27'	)	,
							(	10		,	8		,	'2020-04-08'	)	,
							(	10		,	17		,	'2020-11-01'	)	,
							(	11		,	1		,	'2019-10-30'	)	,
							(	11		,	8		,	'2020-08-15'	)	,
							(	12		,	1		,	'2018-08-16'	)	,
							(	12		,	8		,	'2023-01-13'	)	,
							(	13		,	1		,	'2024-09-04'	)	,
							(	13		,	8		,	'2018-01-23'	)	,
							(	14		,	1		,	'2023-02-24'	)	,
							(	14		,	8		,	'2020-07-08'	)	,
							(	14		,	17		,	'2024-10-19'	)	,
							(	15		,	1		,	'2025-09-07'	)	,
							(	15		,	8		,	'2023-01-07'	)	,
							(	16		,	2		,	'2018-04-22'	)	,
							(	16		,	8		,	'2023-05-06'	)	,
							(	16		,	27		,	'2022-07-14'	)	,
							(	18		,	1		,	'2023-07-16'	)	,
							(	18		,	8		,	'2021-03-09'	)	,
							(	19		,	1		,	'2023-04-10'	)	,
							(	19		,	8		,	'2020-05-10'	)	,
							(	20		,	1		,	'2018-05-29'	)	,
							(	20		,	8		,	'2018-02-23'	)	,
							(	21		,	1		,	'2021-01-25'	)	,
							(	21		,	8		,	'2025-02-27'	)	,
							(	22		,	2		,	'2025-07-27'	)	,
							(	22		,	8		,	'2021-11-19'	)	,
							(	23		,	2		,	'2025-10-15'	)	,
							(	23		,	8		,	'2024-09-08'	)	,
							(	24		,	2		,	'2022-02-26'	)	,
							(	24		,	8		,	'2018-02-13'	)	,
							(	25		,	1		,	'2024-03-22'	)	,
							(	25		,	8		,	'2021-07-01'	)	,
							(	26		,	1		,	'2019-03-31'	)	,
							(	26		,	8		,	'2020-05-11'	)	,
							(	27		,	2		,	'2025-02-23'	)	,
							(	27		,	8		,	'2021-10-13'	)	,
							(	28		,	2		,	'2019-01-18'	)	,
							(	28		,	8		,	'2022-11-12'	)	,
							(	29		,	2		,	'2025-07-01'	)	,
							(	29		,	8		,	'2024-11-19'	)	,
							(	30		,	2		,	'2018-01-19'	)	,
							(	30		,	8		,	'2018-03-02'	)	,
							(	31		,	1		,	'2020-12-22'	)	,
							(	31		,	8		,	'2020-05-02'	)	,
							(	32		,	1		,	'2021-10-10'	)	,
							(	32		,	8		,	'2018-04-02'	)	,
							(	33		,	1		,	'2024-08-14'	)	,
							(	33		,	8		,	'2018-01-02'	)	,
							(	34		,	1		,	'2023-10-01'	)	,
							(	34		,	8		,	'2021-09-02'	)	,
							(	35		,	1		,	'2021-01-19'	)	,
							(	35		,	8		,	'2022-01-14'	)	,
							(	35		,	21		,	'2018-10-12'	)	,
							(	36		,	1		,	'2018-04-01'	)	,
							(	36		,	8		,	'2021-03-20'	)	,
							(	36		,	24		,	'2021-03-15'	)	,
							(	37		,	1		,	'2024-10-24'	)	,
							(	37		,	8		,	'2019-07-15'	)	,
							(	37		,	17		,	'2025-06-19'	)	,
							(	38		,	1		,	'2025-05-29'	)	,
							(	38		,	8		,	'2018-05-16'	)	,
							(	39		,	1		,	'2025-07-06'	)	,
							(	39		,	8		,	'2019-04-10'	)	,
							(	40		,	1		,	'2018-10-07'	)	,
							(	40		,	8		,	'2024-10-11'	)	,
							(	41		,	1		,	'2024-10-11'	)	,
							(	41		,	8		,	'2024-01-21'	)	,
							(	42		,	1		,	'2024-09-01'	)	,
							(	42		,	8		,	'2024-01-04'	)	,
							(	43		,	1		,	'2023-04-20'	)	,
							(	43		,	8		,	'2022-07-01'	)	,
							(	44		,	1		,	'2018-08-27'	)	,
							(	44		,	8		,	'2024-05-02'	)	,
							(	45		,	1		,	'2025-11-21'	)	,
							(	45		,	8		,	'2022-02-12'	)	,
							(	46		,	1		,	'2022-10-03'	)	,
							(	46		,	8		,	'2020-03-05'	)	,
							(	47		,	1		,	'2022-02-05'	)	,
							(	47		,	8		,	'2018-03-03'	)	,
							(	48		,	1		,	'2018-03-23'	)	,
							(	48		,	8		,	'2025-09-03'	)	,
							(	49		,	1		,	'2020-02-14'	)	,
							(	49		,	8		,	'2018-06-16'	)	,
							(	50		,	1		,	'2021-04-23'	)	,
							(	50		,	8		,	'2020-07-03'	)	,
							(	50		,	17		,	'2024-01-09'	)

