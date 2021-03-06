USE [master]
GO
/****** Object:  Database [TurStok]    Script Date: 11/25/2013 23:13:45 ******/
CREATE DATABASE [TurStok] ON  PRIMARY 
( NAME = N'TurStok', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.GTIDB\MSSQL\DATA\TurStok.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TurStok_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.GTIDB\MSSQL\DATA\TurStok_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TurStok] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TurStok].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TurStok] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [TurStok] SET ANSI_NULLS OFF
GO
ALTER DATABASE [TurStok] SET ANSI_PADDING OFF
GO
ALTER DATABASE [TurStok] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [TurStok] SET ARITHABORT OFF
GO
ALTER DATABASE [TurStok] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [TurStok] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [TurStok] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [TurStok] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [TurStok] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [TurStok] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [TurStok] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [TurStok] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [TurStok] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [TurStok] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [TurStok] SET  DISABLE_BROKER
GO
ALTER DATABASE [TurStok] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [TurStok] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [TurStok] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [TurStok] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [TurStok] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [TurStok] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [TurStok] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [TurStok] SET  READ_WRITE
GO
ALTER DATABASE [TurStok] SET RECOVERY FULL
GO
ALTER DATABASE [TurStok] SET  MULTI_USER
GO
ALTER DATABASE [TurStok] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [TurStok] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'TurStok', N'ON'
GO
USE [TurStok]
GO
/****** Object:  User [AppUser]    Script Date: 11/25/2013 23:13:45 ******/
CREATE USER [AppUser] FOR LOGIN [AppUser] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[SaklamaKosulu]    Script Date: 11/25/2013 23:13:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaklamaKosulu](
	[SaklamaKosuluID] [bigint] IDENTITY(1,1) NOT NULL,
	[SaklamaKosulu] [nvarchar](max) NULL,
 CONSTRAINT [PK_SaklamaKosulu] PRIMARY KEY CLUSTERED 
(
	[SaklamaKosuluID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParaBirimi]    Script Date: 11/25/2013 23:13:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParaBirimi](
	[ParaBirimiID] [bigint] IDENTITY(1,1) NOT NULL,
	[ParaBirimi] [nvarchar](10) NULL,
 CONSTRAINT [PK_ParaBirimi] PRIMARY KEY CLUSTERED 
(
	[ParaBirimiID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OlcuBirimi]    Script Date: 11/25/2013 23:13:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OlcuBirimi](
	[OlcuBirimiID] [bigint] IDENTITY(1,1) NOT NULL,
	[OlcuBirimi] [nvarchar](50) NULL,
 CONSTRAINT [PK_OlcuBirimi] PRIMARY KEY CLUSTERED 
(
	[OlcuBirimiID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OdemeSekli]    Script Date: 11/25/2013 23:13:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OdemeSekli](
	[OdemeSekilID] [bigint] IDENTITY(1,1) NOT NULL,
	[OdemeSekli] [nvarchar](50) NULL,
 CONSTRAINT [PK_OdemeSekli] PRIMARY KEY CLUSTERED 
(
	[OdemeSekilID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marka]    Script Date: 11/25/2013 23:13:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marka](
	[MarkaID] [bigint] IDENTITY(1,1) NOT NULL,
	[MarkaAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Marka] PRIMARY KEY CLUSTERED 
(
	[MarkaID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kategori]    Script Date: 11/25/2013 23:13:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategori](
	[KategoriID] [bigint] IDENTITY(1,1) NOT NULL,
	[KategoriAdi] [nvarchar](50) NULL,
	[MiadVarmi] [bit] NULL,
 CONSTRAINT [PK_Kategori] PRIMARY KEY CLUSTERED 
(
	[KategoriID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tedarikci]    Script Date: 11/25/2013 23:13:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tedarikci](
	[TedarikciID] [bigint] IDENTITY(1,1) NOT NULL,
	[TedarikciAdi] [nvarchar](100) NULL,
	[YurtIcimi] [bit] NULL,
	[Telefon] [nvarchar](20) NULL,
	[Faks] [nvarchar](20) NULL,
	[EMail] [nvarchar](100) NULL,
	[Adres] [nvarchar](200) NULL,
	[IBAN] [nvarchar](40) NULL,
	[BankaHesapNo] [nvarchar](100) NULL,
	[EklenmeTarihi] [date] NULL,
 CONSTRAINT [PK_Tedarikci] PRIMARY KEY CLUSTERED 
(
	[TedarikciID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Depo]    Script Date: 11/25/2013 23:13:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Depo](
	[DepoID] [bigint] IDENTITY(1,1) NOT NULL,
	[DepoAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Depo] PRIMARY KEY CLUSTERED 
(
	[DepoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fatura]    Script Date: 11/25/2013 23:13:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fatura](
	[FaturaID] [bigint] IDENTITY(1,1) NOT NULL,
	[FaturaNo] [nvarchar](20) NULL,
	[TedarikciID] [bigint] NULL,
	[FaturaTarihi] [date] NULL,
	[Aciklama] [nvarchar](200) NULL,
	[ParaBirimiID] [bigint] NULL,
	[Kur] [decimal](18, 2) NULL,
	[OdemeYapildimi] [bit] NULL,
	[OdemeSekliID] [bigint] NULL,
 CONSTRAINT [PK_Fatura] PRIMARY KEY CLUSTERED 
(
	[FaturaID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urun]    Script Date: 11/25/2013 23:13:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urun](
	[UrunID] [bigint] IDENTITY(1,1) NOT NULL,
	[UrunAdi] [nvarchar](50) NULL,
	[KategoriID] [bigint] NULL,
	[AzamiMiktar] [decimal](10, 2) NULL,
	[SaklamaKosuluID] [bigint] NULL,
	[OlcuBirimID] [bigint] NULL,
 CONSTRAINT [PK_Urun] PRIMARY KEY CLUSTERED 
(
	[UrunID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stok]    Script Date: 11/25/2013 23:13:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stok](
	[StokID] [bigint] IDENTITY(1,1) NOT NULL,
	[UrunID] [bigint] NULL,
	[DepoID] [bigint] NULL,
	[MarkaID] [bigint] NULL,
	[TedarikciID] [bigint] NULL,
	[KalanMiktar] [decimal](10, 2) NULL,
	[GelisTarihi] [date] NULL,
	[SonKullanmaTarihi] [date] NULL,
	[FaturaDetayID] [bigint] NULL,
	[OlcuBirimID] [bigint] NULL,
 CONSTRAINT [PK_Stok] PRIMARY KEY CLUSTERED 
(
	[StokID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IhtiyacListesi]    Script Date: 11/25/2013 23:13:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IhtiyacListesi](
	[UrunID] [bigint] NOT NULL,
	[Tarih] [datetime] NULL,
 CONSTRAINT [PK_IhtiyacListesi] PRIMARY KEY CLUSTERED 
(
	[UrunID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FaturaDetay]    Script Date: 11/25/2013 23:13:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FaturaDetay](
	[FaturaDetayID] [bigint] IDENTITY(1,1) NOT NULL,
	[FaturaID] [bigint] NULL,
	[UrunID] [bigint] NULL,
	[MarkaID] [bigint] NULL,
	[SiparisVerilenMiktar] [decimal](10, 2) NULL,
	[GelenMiktar] [decimal](10, 2) NULL,
	[BirimFiyati] [decimal](18, 2) NULL,
	[KDVOrani] [int] NULL,
	[TeslimAlindimi] [bit] NULL,
 CONSTRAINT [PK_FaturaDetay] PRIMARY KEY CLUSTERED 
(
	[FaturaDetayID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Fatura_OdemeSekli]    Script Date: 11/25/2013 23:13:46 ******/
ALTER TABLE [dbo].[Fatura]  WITH CHECK ADD  CONSTRAINT [FK_Fatura_OdemeSekli] FOREIGN KEY([OdemeSekliID])
REFERENCES [dbo].[OdemeSekli] ([OdemeSekilID])
GO
ALTER TABLE [dbo].[Fatura] CHECK CONSTRAINT [FK_Fatura_OdemeSekli]
GO
/****** Object:  ForeignKey [FK_Fatura_ParaBirimi]    Script Date: 11/25/2013 23:13:46 ******/
ALTER TABLE [dbo].[Fatura]  WITH CHECK ADD  CONSTRAINT [FK_Fatura_ParaBirimi] FOREIGN KEY([ParaBirimiID])
REFERENCES [dbo].[ParaBirimi] ([ParaBirimiID])
GO
ALTER TABLE [dbo].[Fatura] CHECK CONSTRAINT [FK_Fatura_ParaBirimi]
GO
/****** Object:  ForeignKey [FK_Fatura_Tedarikci]    Script Date: 11/25/2013 23:13:46 ******/
ALTER TABLE [dbo].[Fatura]  WITH CHECK ADD  CONSTRAINT [FK_Fatura_Tedarikci] FOREIGN KEY([TedarikciID])
REFERENCES [dbo].[Tedarikci] ([TedarikciID])
GO
ALTER TABLE [dbo].[Fatura] CHECK CONSTRAINT [FK_Fatura_Tedarikci]
GO
/****** Object:  ForeignKey [FK_Urun_Kategori]    Script Date: 11/25/2013 23:13:46 ******/
ALTER TABLE [dbo].[Urun]  WITH CHECK ADD  CONSTRAINT [FK_Urun_Kategori] FOREIGN KEY([KategoriID])
REFERENCES [dbo].[Kategori] ([KategoriID])
GO
ALTER TABLE [dbo].[Urun] CHECK CONSTRAINT [FK_Urun_Kategori]
GO
/****** Object:  ForeignKey [FK_Urun_OlcuBirimi]    Script Date: 11/25/2013 23:13:46 ******/
ALTER TABLE [dbo].[Urun]  WITH CHECK ADD  CONSTRAINT [FK_Urun_OlcuBirimi] FOREIGN KEY([OlcuBirimID])
REFERENCES [dbo].[OlcuBirimi] ([OlcuBirimiID])
GO
ALTER TABLE [dbo].[Urun] CHECK CONSTRAINT [FK_Urun_OlcuBirimi]
GO
/****** Object:  ForeignKey [FK_Urun_SaklamaKosulu]    Script Date: 11/25/2013 23:13:46 ******/
ALTER TABLE [dbo].[Urun]  WITH CHECK ADD  CONSTRAINT [FK_Urun_SaklamaKosulu] FOREIGN KEY([SaklamaKosuluID])
REFERENCES [dbo].[SaklamaKosulu] ([SaklamaKosuluID])
GO
ALTER TABLE [dbo].[Urun] CHECK CONSTRAINT [FK_Urun_SaklamaKosulu]
GO
/****** Object:  ForeignKey [FK_Stok_Depo]    Script Date: 11/25/2013 23:13:46 ******/
ALTER TABLE [dbo].[Stok]  WITH CHECK ADD  CONSTRAINT [FK_Stok_Depo] FOREIGN KEY([OlcuBirimID])
REFERENCES [dbo].[OlcuBirimi] ([OlcuBirimiID])
GO
ALTER TABLE [dbo].[Stok] CHECK CONSTRAINT [FK_Stok_Depo]
GO
/****** Object:  ForeignKey [FK_Stok_Marka]    Script Date: 11/25/2013 23:13:46 ******/
ALTER TABLE [dbo].[Stok]  WITH CHECK ADD  CONSTRAINT [FK_Stok_Marka] FOREIGN KEY([MarkaID])
REFERENCES [dbo].[Marka] ([MarkaID])
GO
ALTER TABLE [dbo].[Stok] CHECK CONSTRAINT [FK_Stok_Marka]
GO
/****** Object:  ForeignKey [FK_Stok_Tedarikci]    Script Date: 11/25/2013 23:13:46 ******/
ALTER TABLE [dbo].[Stok]  WITH CHECK ADD  CONSTRAINT [FK_Stok_Tedarikci] FOREIGN KEY([TedarikciID])
REFERENCES [dbo].[Tedarikci] ([TedarikciID])
GO
ALTER TABLE [dbo].[Stok] CHECK CONSTRAINT [FK_Stok_Tedarikci]
GO
/****** Object:  ForeignKey [FK_Stok_Urun]    Script Date: 11/25/2013 23:13:46 ******/
ALTER TABLE [dbo].[Stok]  WITH CHECK ADD  CONSTRAINT [FK_Stok_Urun] FOREIGN KEY([UrunID])
REFERENCES [dbo].[Urun] ([UrunID])
GO
ALTER TABLE [dbo].[Stok] CHECK CONSTRAINT [FK_Stok_Urun]
GO
/****** Object:  ForeignKey [FK_IhtiyacListesi_Urun]    Script Date: 11/25/2013 23:13:46 ******/
ALTER TABLE [dbo].[IhtiyacListesi]  WITH CHECK ADD  CONSTRAINT [FK_IhtiyacListesi_Urun] FOREIGN KEY([UrunID])
REFERENCES [dbo].[Urun] ([UrunID])
GO
ALTER TABLE [dbo].[IhtiyacListesi] CHECK CONSTRAINT [FK_IhtiyacListesi_Urun]
GO
/****** Object:  ForeignKey [FK_FaturaDetay_Fatura]    Script Date: 11/25/2013 23:13:46 ******/
ALTER TABLE [dbo].[FaturaDetay]  WITH CHECK ADD  CONSTRAINT [FK_FaturaDetay_Fatura] FOREIGN KEY([FaturaID])
REFERENCES [dbo].[Fatura] ([FaturaID])
GO
ALTER TABLE [dbo].[FaturaDetay] CHECK CONSTRAINT [FK_FaturaDetay_Fatura]
GO
/****** Object:  ForeignKey [FK_FaturaDetay_Marka]    Script Date: 11/25/2013 23:13:46 ******/
ALTER TABLE [dbo].[FaturaDetay]  WITH CHECK ADD  CONSTRAINT [FK_FaturaDetay_Marka] FOREIGN KEY([MarkaID])
REFERENCES [dbo].[Marka] ([MarkaID])
GO
ALTER TABLE [dbo].[FaturaDetay] CHECK CONSTRAINT [FK_FaturaDetay_Marka]
GO
/****** Object:  ForeignKey [FK_FaturaDetay_Urun]    Script Date: 11/25/2013 23:13:46 ******/
ALTER TABLE [dbo].[FaturaDetay]  WITH CHECK ADD  CONSTRAINT [FK_FaturaDetay_Urun] FOREIGN KEY([UrunID])
REFERENCES [dbo].[Urun] ([UrunID])
GO
ALTER TABLE [dbo].[FaturaDetay] CHECK CONSTRAINT [FK_FaturaDetay_Urun]
GO
