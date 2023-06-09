USE [QuanLyNhanSu]
GO
/****** Object:  Table [dbo].[login]    Script Date: 6/7/2023 6:06:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[taikhoan] [varchar](50) NOT NULL,
	[matkhau] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[quyen] [varchar](50) NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TTchamcong]    Script Date: 6/7/2023 6:06:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TTchamcong](
	[macong] [nchar](10) NOT NULL,
	[msnv] [nchar](10) NULL,
	[ngay] [date] NULL,
	[tinhtrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_TTchamcong] PRIMARY KEY CLUSTERED 
(
	[macong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TTchucvu]    Script Date: 6/7/2023 6:06:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TTchucvu](
	[macv] [varchar](50) NOT NULL,
	[tencv] [nvarchar](50) NULL,
 CONSTRAINT [PK_TTchucvu] PRIMARY KEY CLUSTERED 
(
	[macv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TThopdong]    Script Date: 6/7/2023 6:06:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TThopdong](
	[mahd] [varchar](50) NOT NULL,
	[msnv] [nchar](10) NULL,
	[ngayvaolam] [date] NULL,
	[luongcoban] [float] NULL,
	[macv] [varchar](50) NULL,
	[mapb] [varchar](50) NULL,
 CONSTRAINT [PK_TThopdong] PRIMARY KEY CLUSTERED 
(
	[mahd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TTluong]    Script Date: 6/7/2023 6:06:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TTluong](
	[maluong] [nchar](10) NOT NULL,
	[msnv] [nchar](10) NULL,
	[ngaybd] [date] NULL,
	[ngaykt] [date] NULL,
	[hesoluong] [float] NULL,
	[luongcoban] [float] NULL,
	[songaylam] [int] NULL,
	[tongtien] [nchar](10) NULL,
 CONSTRAINT [PK_TTluong1] PRIMARY KEY CLUSTERED 
(
	[maluong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TTnhanvien]    Script Date: 6/7/2023 6:06:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TTnhanvien](
	[msnv] [nchar](10) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](6) NULL,
	[namsinh] [date] NULL,
	[diachi] [nvarchar](50) NULL,
	[sodienthoai] [varchar](50) NULL,
	[hinh] [image] NULL,
	[cmnd] [nchar](10) NULL,
	[trinhdo] [nvarchar](50) NULL,
	[chuyenmon] [nvarchar](50) NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[msnv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TTphongban]    Script Date: 6/7/2023 6:06:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TTphongban](
	[mapb] [varchar](50) NOT NULL,
	[tenpb] [nvarchar](50) NULL,
 CONSTRAINT [PK_TTphongban] PRIMARY KEY CLUSTERED 
(
	[mapb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TTchamcong]  WITH CHECK ADD  CONSTRAINT [FK_TTchamcong_TTnhanvien] FOREIGN KEY([msnv])
REFERENCES [dbo].[TTnhanvien] ([msnv])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TTchamcong] CHECK CONSTRAINT [FK_TTchamcong_TTnhanvien]
GO
ALTER TABLE [dbo].[TThopdong]  WITH CHECK ADD  CONSTRAINT [FK_TThopdong_TTchucvu] FOREIGN KEY([macv])
REFERENCES [dbo].[TTchucvu] ([macv])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TThopdong] CHECK CONSTRAINT [FK_TThopdong_TTchucvu]
GO
ALTER TABLE [dbo].[TThopdong]  WITH CHECK ADD  CONSTRAINT [FK_TThopdong_TTnhanvien] FOREIGN KEY([msnv])
REFERENCES [dbo].[TTnhanvien] ([msnv])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TThopdong] CHECK CONSTRAINT [FK_TThopdong_TTnhanvien]
GO
ALTER TABLE [dbo].[TThopdong]  WITH CHECK ADD  CONSTRAINT [FK_TThopdong_TTphongban] FOREIGN KEY([mapb])
REFERENCES [dbo].[TTphongban] ([mapb])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TThopdong] CHECK CONSTRAINT [FK_TThopdong_TTphongban]
GO
ALTER TABLE [dbo].[TTluong]  WITH CHECK ADD  CONSTRAINT [FK_TTluong_TTnhanvien] FOREIGN KEY([msnv])
REFERENCES [dbo].[TTnhanvien] ([msnv])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TTluong] CHECK CONSTRAINT [FK_TTluong_TTnhanvien]
GO
