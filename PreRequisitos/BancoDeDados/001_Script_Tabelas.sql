
CREATE DATABASE [ColecaoFilmes];
GO

USE [ColecaoFilmes]
GO

--
-- Definition for table Filme : 
--

CREATE TABLE [dbo].[Filme] (
  [Id] int IDENTITY(1, 1) NOT NULL,
  [NomeOriginal] nvarchar(255) COLLATE Latin1_General_CI_AS NULL,
  [ImdbId] nvarchar(255) COLLATE Latin1_General_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Release : 
--

CREATE TABLE [dbo].[Release] (
  [Id] int IDENTITY(1, 1) NOT NULL,
  [Nome] nvarchar(255) COLLATE Latin1_General_CI_AS NULL,
  [CaminhoArquivoFisico] nvarchar(255) COLLATE Latin1_General_CI_AS NULL,
  [Filme_id] int NULL
)
ON [PRIMARY]
GO

--
-- Definition for indices : 
--

ALTER TABLE [dbo].[Filme]
ADD PRIMARY KEY CLUSTERED ([Id])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]
GO

ALTER TABLE [dbo].[Release]
ADD PRIMARY KEY CLUSTERED ([Id])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]
GO

--
-- Definition for foreign keys : 
--

ALTER TABLE [dbo].[Release]
ADD CONSTRAINT [FKA13D46BE5FEE883E] FOREIGN KEY ([Filme_id]) 
  REFERENCES [dbo].[Filme] ([Id]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION
GO

