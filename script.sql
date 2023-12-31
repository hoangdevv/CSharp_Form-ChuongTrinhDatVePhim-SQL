USE [ChuongTrinhDatGheXemPhim]
GO
/****** Object:  Table [dbo].[Categorys]    Script Date: 01/10/2023 9:21:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorys](
	[MaLoai] [int] NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_Categorys] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seats]    Script Date: 01/10/2023 9:21:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seats](
	[MaGhe] [nvarchar](20) NOT NULL,
	[HangGhe] [nvarchar](50) NULL,
	[SoGhe] [int] NULL,
	[LoaiGhe] [int] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_Seats] PRIMARY KEY CLUSTERED 
(
	[MaGhe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Categorys] ([MaLoai], [TenLoai]) VALUES (1, N'Thường')
INSERT [dbo].[Categorys] ([MaLoai], [TenLoai]) VALUES (2, N'Vip')
INSERT [dbo].[Categorys] ([MaLoai], [TenLoai]) VALUES (3, N'SweetBox')
GO
ALTER TABLE [dbo].[Seats]  WITH CHECK ADD  CONSTRAINT [FK_Seats_Categorys] FOREIGN KEY([LoaiGhe])
REFERENCES [dbo].[Categorys] ([MaLoai])
GO
ALTER TABLE [dbo].[Seats] CHECK CONSTRAINT [FK_Seats_Categorys]
GO
