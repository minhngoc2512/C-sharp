USE [QLTAISAN]
GO
/****** Object:  Table [dbo].[lich_su_thay_doi]    Script Date: 02/07/2017 03:44:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lich_su_thay_doi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[cong_ty] [nvarchar](50) NULL,
	[loai_tai_san] [nvarchar](50) NULL,
	[thoi_gian_bao_hanh] [datetime] NULL,
	[thoi_gian_trang_bi] [datetime] NULL,
	[gia_tien] [int] NULL,
	[gia_tien_thue] [int] NULL,
	[nguoi_thay_doi] [nvarchar](50) NOT NULL,
	[thoi_diem_thay_doi] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nguoi_dung]    Script Date: 02/07/2017 03:44:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nguoi_dung](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[matkhau] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tai_san]    Script Date: 02/07/2017 03:44:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tai_san](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten_tai_san] [nvarchar](max) NOT NULL,
	[cong_ty_so_huu] [nvarchar](max) NOT NULL,
	[loai_tai_san] [nvarchar](50) NOT NULL,
	[thoi_gian_bao_hanh] [datetime] NULL,
	[thoi_diem_trang_bi] [datetime] NULL,
	[gia_tien] [int] NULL,
	[ten_tai_khoan] [nvarchar](50) NULL,
	[gia_tien_thue] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
