USE [TurStok]
GO
/****** Object:  Table [dbo].[SaklamaKosulu]    Script Date: 07/18/2013 17:39:46 ******/
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
/****** Object:  Table [dbo].[ParaBirimi]    Script Date: 07/18/2013 17:39:46 ******/
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
/****** Object:  Table [dbo].[OlcuBirimi]    Script Date: 07/18/2013 17:39:46 ******/
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
/****** Object:  Table [dbo].[Marka]    Script Date: 07/18/2013 17:39:46 ******/
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
/****** Object:  Table [dbo].[Kategori]    Script Date: 07/18/2013 17:39:46 ******/
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
/****** Object:  Table [dbo].[Tedarikci]    Script Date: 07/18/2013 17:39:46 ******/
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
/****** Object:  Table [dbo].[Depo]    Script Date: 07/18/2013 17:39:46 ******/
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
/****** Object:  Table [dbo].[Urun]    Script Date: 07/18/2013 17:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urun](
	[UrunID] [bigint] IDENTITY(1,1) NOT NULL,
	[KategoriID] [bigint] NULL,
	[AzamiMiktar] [decimal](10, 2) NULL,
	[OlcuBirimiId] [bigint] NULL,
	[SaklamaKosuluID] [bigint] NULL,
	[UrunAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Urun] PRIMARY KEY CLUSTERED 
(
	[UrunID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fatura]    Script Date: 07/18/2013 17:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fatura](
	[FaturaID] [bigint] IDENTITY(1,1) NOT NULL,
	[FaturaNo] [nvarchar](20) NULL,
	[TedarikciID] [bigint] NULL,
	[SiparisTarihi] [date] NULL,
	[Aciklama] [nvarchar](200) NULL,
	[ParaBirimiID] [bigint] NULL,
	[Kur] [decimal](18, 2) NULL,
	[OdemeYapildimi] [bit] NULL,
 CONSTRAINT [PK_Fatura] PRIMARY KEY CLUSTERED 
(
	[FaturaID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stok]    Script Date: 07/18/2013 17:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stok](
	[StokID] [bigint] NOT NULL,
	[UrunID] [bigint] NULL,
	[DepoID] [bigint] NULL,
	[MarkaID] [bigint] NULL,
	[TedarikciID] [bigint] NULL,
	[KalanMiktar] [decimal](10, 2) NULL,
	[GelisTarihi] [date] NULL,
	[SonKullanmaTarihi] [date] NULL,
	[IlgiliFaturaID] [bigint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Stok] PRIMARY KEY CLUSTERED 
(
	[StokID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FaturaDetay]    Script Date: 07/18/2013 17:39:46 ******/
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
	[OlcuBirimiID] [bigint] NULL,
	[BirimFiyati] [decimal](18, 2) NULL,
	[KDVOrani] [int] NULL,
 CONSTRAINT [PK_FaturaDetay] PRIMARY KEY CLUSTERED 
(
	[FaturaDetayID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Fatura_ParaBirimi]    Script Date: 07/18/2013 17:39:46 ******/
ALTER TABLE [dbo].[Fatura]  WITH CHECK ADD  CONSTRAINT [FK_Fatura_ParaBirimi] FOREIGN KEY([ParaBirimiID])
REFERENCES [dbo].[ParaBirimi] ([ParaBirimiID])
GO
ALTER TABLE [dbo].[Fatura] CHECK CONSTRAINT [FK_Fatura_ParaBirimi]
GO
/****** Object:  ForeignKey [FK_Fatura_Tedarikci]    Script Date: 07/18/2013 17:39:46 ******/
ALTER TABLE [dbo].[Fatura]  WITH CHECK ADD  CONSTRAINT [FK_Fatura_Tedarikci] FOREIGN KEY([TedarikciID])
REFERENCES [dbo].[Tedarikci] ([TedarikciID])
GO
ALTER TABLE [dbo].[Fatura] CHECK CONSTRAINT [FK_Fatura_Tedarikci]
GO
/****** Object:  ForeignKey [FK_FaturaDetay_Fatura]    Script Date: 07/18/2013 17:39:46 ******/
ALTER TABLE [dbo].[FaturaDetay]  WITH CHECK ADD  CONSTRAINT [FK_FaturaDetay_Fatura] FOREIGN KEY([FaturaID])
REFERENCES [dbo].[Fatura] ([FaturaID])
GO
ALTER TABLE [dbo].[FaturaDetay] CHECK CONSTRAINT [FK_FaturaDetay_Fatura]
GO
/****** Object:  ForeignKey [FK_FaturaDetay_Marka]    Script Date: 07/18/2013 17:39:46 ******/
ALTER TABLE [dbo].[FaturaDetay]  WITH CHECK ADD  CONSTRAINT [FK_FaturaDetay_Marka] FOREIGN KEY([MarkaID])
REFERENCES [dbo].[Marka] ([MarkaID])
GO
ALTER TABLE [dbo].[FaturaDetay] CHECK CONSTRAINT [FK_FaturaDetay_Marka]
GO
/****** Object:  ForeignKey [FK_FaturaDetay_OlcuBirimi]    Script Date: 07/18/2013 17:39:46 ******/
ALTER TABLE [dbo].[FaturaDetay]  WITH CHECK ADD  CONSTRAINT [FK_FaturaDetay_OlcuBirimi] FOREIGN KEY([OlcuBirimiID])
REFERENCES [dbo].[OlcuBirimi] ([OlcuBirimiID])
GO
ALTER TABLE [dbo].[FaturaDetay] CHECK CONSTRAINT [FK_FaturaDetay_OlcuBirimi]
GO
/****** Object:  ForeignKey [FK_FaturaDetay_Urun]    Script Date: 07/18/2013 17:39:46 ******/
ALTER TABLE [dbo].[FaturaDetay]  WITH CHECK ADD  CONSTRAINT [FK_FaturaDetay_Urun] FOREIGN KEY([UrunID])
REFERENCES [dbo].[Urun] ([UrunID])
GO
ALTER TABLE [dbo].[FaturaDetay] CHECK CONSTRAINT [FK_FaturaDetay_Urun]
GO
/****** Object:  ForeignKey [FK_Stok_Depo]    Script Date: 07/18/2013 17:39:46 ******/
ALTER TABLE [dbo].[Stok]  WITH CHECK ADD  CONSTRAINT [FK_Stok_Depo] FOREIGN KEY([DepoID])
REFERENCES [dbo].[Depo] ([DepoID])
GO
ALTER TABLE [dbo].[Stok] CHECK CONSTRAINT [FK_Stok_Depo]
GO
/****** Object:  ForeignKey [FK_Stok_Marka]    Script Date: 07/18/2013 17:39:46 ******/
ALTER TABLE [dbo].[Stok]  WITH CHECK ADD  CONSTRAINT [FK_Stok_Marka] FOREIGN KEY([MarkaID])
REFERENCES [dbo].[Marka] ([MarkaID])
GO
ALTER TABLE [dbo].[Stok] CHECK CONSTRAINT [FK_Stok_Marka]
GO
/****** Object:  ForeignKey [FK_Stok_Tedarikci]    Script Date: 07/18/2013 17:39:46 ******/
ALTER TABLE [dbo].[Stok]  WITH CHECK ADD  CONSTRAINT [FK_Stok_Tedarikci] FOREIGN KEY([TedarikciID])
REFERENCES [dbo].[Tedarikci] ([TedarikciID])
GO
ALTER TABLE [dbo].[Stok] CHECK CONSTRAINT [FK_Stok_Tedarikci]
GO
/****** Object:  ForeignKey [FK_Stok_Urun]    Script Date: 07/18/2013 17:39:46 ******/
ALTER TABLE [dbo].[Stok]  WITH CHECK ADD  CONSTRAINT [FK_Stok_Urun] FOREIGN KEY([UrunID])
REFERENCES [dbo].[Urun] ([UrunID])
GO
ALTER TABLE [dbo].[Stok] CHECK CONSTRAINT [FK_Stok_Urun]
GO
/****** Object:  ForeignKey [FK_Urun_Kategori]    Script Date: 07/18/2013 17:39:46 ******/
ALTER TABLE [dbo].[Urun]  WITH CHECK ADD  CONSTRAINT [FK_Urun_Kategori] FOREIGN KEY([KategoriID])
REFERENCES [dbo].[Kategori] ([KategoriID])
GO
ALTER TABLE [dbo].[Urun] CHECK CONSTRAINT [FK_Urun_Kategori]
GO
/****** Object:  ForeignKey [FK_Urun_OlcuBirimi]    Script Date: 07/18/2013 17:39:46 ******/
ALTER TABLE [dbo].[Urun]  WITH CHECK ADD  CONSTRAINT [FK_Urun_OlcuBirimi] FOREIGN KEY([OlcuBirimiId])
REFERENCES [dbo].[OlcuBirimi] ([OlcuBirimiID])
GO
ALTER TABLE [dbo].[Urun] CHECK CONSTRAINT [FK_Urun_OlcuBirimi]
GO
/****** Object:  ForeignKey [FK_Urun_SaklamaKosulu]    Script Date: 07/18/2013 17:39:46 ******/
ALTER TABLE [dbo].[Urun]  WITH CHECK ADD  CONSTRAINT [FK_Urun_SaklamaKosulu] FOREIGN KEY([SaklamaKosuluID])
REFERENCES [dbo].[SaklamaKosulu] ([SaklamaKosuluID])
GO
ALTER TABLE [dbo].[Urun] CHECK CONSTRAINT [FK_Urun_SaklamaKosulu]
GO
