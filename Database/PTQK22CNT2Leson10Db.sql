USE [PtqK22CNT2Lesson10Db]
GO
/****** Object:  Table [dbo].[PtqKetqua]    Script Date: 25/06/2024 8:39:53 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PtqKetqua](
	[PtqMaSV] [char](10) NOT NULL,
	[PtqMaMH] [char](10) NOT NULL,
	[PtqDiem] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[PtqMaSV] ASC,
	[PtqMaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PtqKhoa]    Script Date: 25/06/2024 8:39:53 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PtqKhoa](
	[PtqMaKH] [char](10) NOT NULL,
	[PtqTenKH] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[PtqMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PtqMonHoc]    Script Date: 25/06/2024 8:39:53 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PtqMonHoc](
	[PtqMaMH] [char](10) NOT NULL,
	[PtqTenMH] [nvarchar](50) NULL,
	[PtqSotiet] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PtqMaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PtqSinhVien]    Script Date: 25/06/2024 8:39:53 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PtqSinhVien](
	[PtqMaSV] [char](10) NOT NULL,
	[PtqHoSV] [nvarchar](50) NULL,
	[PtqTenSV] [nvarchar](50) NULL,
	[PtqPhai] [bit] NULL,
	[PtqNgaySinh] [date] NULL,
	[PtqNoiSinh] [nvarchar](50) NULL,
	[PtqMaKH] [char](10) NULL,
	[PtqHocBong] [float] NULL,
	[PtqDiemTrungBinh] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[PtqMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PtqKetqua] ([PtqMaSV], [PtqMaMH], [PtqDiem]) VALUES (N'1234567890', N'HCM       ', 10)
INSERT [dbo].[PtqKetqua] ([PtqMaSV], [PtqMaMH], [PtqDiem]) VALUES (N'2210900059', N'CSDL      ', 10)
GO
INSERT [dbo].[PtqKhoa] ([PtqMaKH], [PtqTenKH]) VALUES (N'K22CNT2   ', N'Công nghệ thông tin')
INSERT [dbo].[PtqKhoa] ([PtqMaKH], [PtqTenKH]) VALUES (N'KT        ', N'Kế Toán')
GO
INSERT [dbo].[PtqMonHoc] ([PtqMaMH], [PtqTenMH], [PtqSotiet]) VALUES (N'CSDL      ', N'cơ sở dữ liệu', 50)
INSERT [dbo].[PtqMonHoc] ([PtqMaMH], [PtqTenMH], [PtqSotiet]) VALUES (N'HCM       ', N'tư tưởng Hồ Chí Minh', 50)
GO
INSERT [dbo].[PtqSinhVien] ([PtqMaSV], [PtqHoSV], [PtqTenSV], [PtqPhai], [PtqNgaySinh], [PtqNoiSinh], [PtqMaKH], [PtqHocBong], [PtqDiemTrungBinh]) VALUES (N'1234567890', N'Trần Thị', N'Huyền Trang', 0, CAST(N'2005-08-31' AS Date), N'Ân Thi', N'KT        ', 0, 8.5)
INSERT [dbo].[PtqSinhVien] ([PtqMaSV], [PtqHoSV], [PtqTenSV], [PtqPhai], [PtqNgaySinh], [PtqNoiSinh], [PtqMaKH], [PtqHocBong], [PtqDiemTrungBinh]) VALUES (N'2210900059', N'Phạm', N'Thế Quyền', 1, CAST(N'2004-11-14' AS Date), N'Hưng Yên', N'K22CNT2   ', 0, 8.5)
GO
ALTER TABLE [dbo].[PtqKetqua]  WITH CHECK ADD FOREIGN KEY([PtqMaSV])
REFERENCES [dbo].[PtqSinhVien] ([PtqMaSV])
GO
ALTER TABLE [dbo].[PtqKetqua]  WITH CHECK ADD FOREIGN KEY([PtqMaMH])
REFERENCES [dbo].[PtqMonHoc] ([PtqMaMH])
GO
ALTER TABLE [dbo].[PtqSinhVien]  WITH CHECK ADD FOREIGN KEY([PtqMaKH])
REFERENCES [dbo].[PtqKhoa] ([PtqMaKH])
GO
