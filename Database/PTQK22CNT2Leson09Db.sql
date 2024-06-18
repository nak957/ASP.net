USE [PtqK22CNT2Lesson09Db]
GO
/****** Object:  Table [dbo].[ptqKhoa]    Script Date: 17/06/2024 5:36:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ptqKhoa](
	[PtqMaKH] [nchar](10) NOT NULL,
	[PtqTenKH] [nvarchar](50) NULL,
	[PtqTranngThai] [bit] NULL,
 CONSTRAINT [PK_ptqKhoa] PRIMARY KEY CLUSTERED 
(
	[PtqMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ptqSinhVien]    Script Date: 17/06/2024 5:36:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ptqSinhVien](
	[PtqMasv] [nvarchar](50) NOT NULL,
	[PtqHosv] [nvarchar](50) NULL,
	[PtqTensv] [nvarchar](50) NULL,
	[PtqNgaySinh] [date] NULL,
	[PtqPhai] [bit] NULL,
	[PtqPhone] [nchar](10) NULL,
	[PtqEmail] [nvarchar](50) NULL,
	[PtqMaKH] [nchar](10) NULL,
 CONSTRAINT [PK_ptqSinhVien] PRIMARY KEY CLUSTERED 
(
	[PtqMasv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ptqKhoa] ([PtqMaKH], [PtqTenKH], [PtqTranngThai]) VALUES (N'K22CNT2   ', N'K22CNT3', 1)
GO
INSERT [dbo].[ptqSinhVien] ([PtqMasv], [PtqHosv], [PtqTensv], [PtqNgaySinh], [PtqPhai], [PtqPhone], [PtqEmail], [PtqMaKH]) VALUES (N'2210900059', N' Phạm Thế', N'Quyền', CAST(N'2004-11-14' AS Date), 1, N'096786582 ', N'thequyen700@gmail.com', N'K22CNT2   ')
GO
