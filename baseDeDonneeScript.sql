create database LocationVoiture

USE [LocationVoiture]
GO


CREATE TABLE [dbo].[client](
	[noPermis] [varchar](11) NOT NULL,
	[nom] [varchar](20) NOT NULL,
	[prenom] [varchar](20) NOT NULL,
	[dateNaissance] [date] NOT NULL,
	[courriel] [varchar](50) NOT NULL,
	[noTelephone] [varchar](10) NOT NULL,
	[adresse] [varchar](50) NOT NULL,
	PRIMARY KEY ([noPermis])
)
GO

USE [LocationVoiture]
GO


CREATE TABLE [dbo].[Vehicule](
	[idVehicule] [varchar](5) NOT NULL,
	[marque] [varchar](10) NOT NULL,
	[modele] [varchar](10) NOT NULL,
	[annee] [varchar](8) NULL,
	[couleur] [nvarchar](10) NOT NULL,
	[Kilometrage] [int] NOT NULL,
	[categorie] [nvarchar](1) NULL,
	PRIMARY KEY ([idVehicule]))
GO

