USE [master]
GO
/****** Object:  Database [BulletProofRecords]    Script Date: 4/24/2021 11:45:59 AM ******/
CREATE DATABASE [BulletProofRecords]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BulletProofRecords', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BulletProofRecords.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BulletProofRecords_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BulletProofRecords_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BulletProofRecords] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BulletProofRecords].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BulletProofRecords] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BulletProofRecords] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BulletProofRecords] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BulletProofRecords] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BulletProofRecords] SET ARITHABORT OFF 
GO
ALTER DATABASE [BulletProofRecords] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BulletProofRecords] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BulletProofRecords] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BulletProofRecords] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BulletProofRecords] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BulletProofRecords] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BulletProofRecords] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BulletProofRecords] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BulletProofRecords] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BulletProofRecords] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BulletProofRecords] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BulletProofRecords] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BulletProofRecords] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BulletProofRecords] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BulletProofRecords] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BulletProofRecords] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BulletProofRecords] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BulletProofRecords] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BulletProofRecords] SET  MULTI_USER 
GO
ALTER DATABASE [BulletProofRecords] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BulletProofRecords] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BulletProofRecords] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BulletProofRecords] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BulletProofRecords] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BulletProofRecords] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BulletProofRecords] SET QUERY_STORE = OFF
GO
USE [BulletProofRecords]
GO
/****** Object:  Table [dbo].[Album]    Script Date: 4/24/2021 11:45:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Album](
	[AlbumID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[FKArtistaID] [int] NOT NULL,
 CONSTRAINT [PK_Album] PRIMARY KEY CLUSTERED 
(
	[AlbumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Artista]    Script Date: 4/24/2021 11:45:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artista](
	[ArtistaID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Artista] PRIMARY KEY CLUSTERED 
(
	[ArtistaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cancion]    Script Date: 4/24/2021 11:45:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cancion](
	[CancionID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[FKArtistaID] [int] NOT NULL,
	[FKAlbumID] [int] NOT NULL,
	[Genero] [varchar](100) NOT NULL,
	[AnioCreacion] [varchar](4) NOT NULL,
 CONSTRAINT [PK_Cancion] PRIMARY KEY CLUSTERED 
(
	[CancionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Album]  WITH CHECK ADD  CONSTRAINT [FK_Album_Artista] FOREIGN KEY([FKArtistaID])
REFERENCES [dbo].[Artista] ([ArtistaID])
GO
ALTER TABLE [dbo].[Album] CHECK CONSTRAINT [FK_Album_Artista]
GO
ALTER TABLE [dbo].[Cancion]  WITH CHECK ADD  CONSTRAINT [FK_Cancion_Album] FOREIGN KEY([FKAlbumID])
REFERENCES [dbo].[Album] ([AlbumID])
GO
ALTER TABLE [dbo].[Cancion] CHECK CONSTRAINT [FK_Cancion_Album]
GO
ALTER TABLE [dbo].[Cancion]  WITH CHECK ADD  CONSTRAINT [FK_Cancion_Artista] FOREIGN KEY([FKArtistaID])
REFERENCES [dbo].[Artista] ([ArtistaID])
GO
ALTER TABLE [dbo].[Cancion] CHECK CONSTRAINT [FK_Cancion_Artista]
GO
/****** Object:  StoredProcedure [dbo].[sp_Album_Insert]    Script Date: 4/24/2021 11:45:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		FranciscoMadrid
-- Create date: 
-- Description:	Inserta datos en la tabla album
-- =============================================
CREATE PROCEDURE [dbo].[sp_Album_Insert] 
	-- Add the parameters for the stored procedure here
	@Nombre VARCHAR(200),
	@FKArtistaID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

INSERT INTO [dbo].[Album]
           ([Nombre]
           ,[FKArtistaID])
     VALUES
           (@Nombre,
		    @FKArtistaID)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Album_Show]    Script Date: 4/24/2021 11:45:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		FranciscoMadrid
-- Create date: 
-- Description:	Muestra albums
-- =============================================
CREATE PROCEDURE [dbo].[sp_Album_Show] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT        Album.AlbumID, Album.Nombre AS 'Nombre de album', Artista.Nombre AS 'Nombre del artista', Artista.ArtistaID AS 'ID del artista'
FROM            Album INNER JOIN
                         Artista ON Album.FKArtistaID = Artista.ArtistaID
ORDER BY 'Nombre de album'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Artista_Insert]    Script Date: 4/24/2021 11:45:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		FranciscoMadrid
-- Create date: 
-- Description:	Inserta nuevo artista
-- =============================================
CREATE PROCEDURE [dbo].[sp_Artista_Insert] 
	-- Add the parameters for the stored procedure here
	@Nombre VARCHAR(200),
	@Estado BIT
AS
BEGIN

INSERT INTO [dbo].[Artista]
           ([Nombre]
           ,[Estado])
     VALUES
           (@Nombre,
		    @Estado)

END
GO
/****** Object:  StoredProcedure [dbo].[sp_Artista_Show]    Script Date: 4/24/2021 11:45:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		FranciscoMadrid
-- Create date: 
-- Description:	Muestra contenido de artista
-- =============================================
CREATE PROCEDURE [dbo].[sp_Artista_Show] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        ArtistaID AS ID, Nombre AS 'Nombre del artista', Estado
FROM            Artista
ORDER BY 'Nombre del artista'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cancion_Insert]    Script Date: 4/24/2021 11:45:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		FranciscoMadrid
-- Create date: 
-- Description:	Insertar datos en la tabla cancion
-- =============================================
CREATE PROCEDURE [dbo].[sp_Cancion_Insert] 
	-- Add the parameters for the stored procedure here
	@Nombre VARCHAR (200),
	@FKArtistaID INT,
	@FKAlbumID INT,
	@Genero VARCHAR (100),
	@AnioCreacion VARCHAR(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[Cancion]
           ([Nombre]
           ,[FKArtistaID]
           ,[FKAlbumID]
           ,[Genero]
           ,[AnioCreacion])
     VALUES
           (@Nombre,
		    @FKArtistaID,
			@FKAlbumID,
			@Genero,
			@AnioCreacion)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cancion_Show]    Script Date: 4/24/2021 11:45:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		FranciscoMadrid
-- Create date: 
-- Description:	Muestra cancion
-- =============================================
CREATE PROCEDURE [dbo].[sp_Cancion_Show] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        Cancion.Nombre AS 'Nombre de la cancion', 
			  Cancion.Genero, 
			  Artista.Nombre AS 'Nombre del artista', 
			  Album.Nombre AS 'Nombre del Album', 
			  Cancion.AnioCreacion AS Año
FROM            Cancion INNER JOIN
                         Artista ON Cancion.FKArtistaID = Artista.ArtistaID INNER JOIN
                         Album ON Cancion.FKAlbumID = Album.AlbumID AND Artista.ArtistaID = Album.FKArtistaID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Reporte_Show]    Script Date: 4/24/2021 11:45:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		FranciscoMadrid
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[sp_Reporte_Show] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
SELECT        Artista.Nombre AS 'Nombre del artista', Cancion.Nombre AS 'Nombre de la cancion', Album.Nombre AS 'Nombre del Album'
FROM            Album INNER JOIN
                         Artista ON Album.FKArtistaID = Artista.ArtistaID INNER JOIN
                         Cancion ON Album.AlbumID = Cancion.FKAlbumID AND Artista.ArtistaID = Cancion.FKArtistaID
END
GO
USE [master]
GO
ALTER DATABASE [BulletProofRecords] SET  READ_WRITE 
GO
