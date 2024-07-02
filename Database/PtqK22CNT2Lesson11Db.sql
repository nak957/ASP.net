USE [PtqK22CNT2lesson11Db]
GO
/****** Object:  Table [dbo].[Ptqtaikhoan]    Script Date: 02/07/2024 8:30:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ptqtaikhoan](
	[Ptqid] [int] NOT NULL,
	[PtqUserName] [nvarchar](50) NULL,
	[PtqPassword] [nvarchar](50) NULL,
	[PtqfullName] [nvarchar](50) NULL,
	[PtqAge] [int] NULL,
	[PtqEmail] [nvarchar](50) NULL,
	[PtqPhone] [char](10) NULL,
	[PtqStatus] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ptqid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ptqtaikhoan] ([Ptqid], [PtqUserName], [PtqPassword], [PtqfullName], [PtqAge], [PtqEmail], [PtqPhone], [PtqStatus]) VALUES (221090059, N'PhamTheQuyen', N'123456@', N'Phạm Thế Quyền', 20, N'thequyen700@gmail.com', N'0936944283', 1)
GO
