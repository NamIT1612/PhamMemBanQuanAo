USE [master]
GO
CREATE DATABASE [QuanLy_ShopQuanAo]
GO
USE [QuanLy_ShopQuanAo]
GO
/****** Object:  Table [dbo].[DONHANG]    Script Date: 12/5/2021 1:35:51 PM ******/
set dateformat DMY
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DONHANG](
	[MaDonHang] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhapKhachHang] [varchar](20) NULL,
	[MaSP] [char](20) NULL,
	[SoLuong] [int] NULL,
	[TongTien] [float] NULL,
	[KichCo] [char](5) NULL,
	[NgayDatHang] [datetime] NULL,
	[NgayGiaoHang] [datetime] NULL,
	[TrangThai] [nvarchar](10) NULL,
	[GhiChu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GIOHANG]    Script Date: 12/5/2021 1:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIOHANG](
	[TenDangNhapKhachHang] [varchar](20) NOT NULL,
	[MaSP] [char](20) NOT NULL,
	[KichCo] [char](5) NOT NULL,
	[SoLuongSP] [int] NULL,
 CONSTRAINT [PK_GIOHANG] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC,
	[TenDangNhapKhachHang] ASC,
	[KichCo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/5/2021 1:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[TenDangNhap] [varchar](20) NOT NULL,
	[MatKhau] [varchar](150) NULL,
	[Hoten] [nvarchar](50) NULL,
	[SoDT] [char](20) NULL,
	[Email] [varchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[GioiTinh] [nvarchar](5) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHO]    Script Date: 12/5/2021 1:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHO](
	[MaSP] [char](20) NOT NULL,
	[SoLuongTonKho] [int] NULL,
	[KichCo] [char](5) NOT NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC,
	[KichCo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAISANPHAM]    Script Date: 12/5/2021 1:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAISANPHAM](
	[MaLoai] [varchar](20) NOT NULL,
	[TenLoaiSP] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QUANTRIVIEN]    Script Date: 12/5/2021 1:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QUANTRIVIEN](
	[TenDangNhap] [varchar](20) NOT NULL,
	[MatKhau] [varchar](150) NULL,
	[Quyen] [int] NULL,
 CONSTRAINT [PK_QuanTriVien] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 12/5/2021 1:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MaSP] [char](20) NOT NULL,
	[TenSP] [nvarchar](100) NULL,
	[GiaBan] [int] NULL,
	[GiaCu] [int] NULL,
	[MoTa] [nvarchar](max) NULL,
	[HinhAnh] [varchar](100) NULL,
	[MaLoai] [varchar](20) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[DONHANG] ON 

INSERT [dbo].[DONHANG] ([MaDonHang], [TenDangNhapKhachHang], [MaSP], [SoLuong], [TongTien], [KichCo], [NgayDatHang], [NgayGiaoHang], [TrangThai], [GhiChu]) VALUES (25, N'KHANG', N'ALD65167            ', 4, 600000, N'L    ', CAST(N'2021-12-05' AS Date), NULL, N'Chưa giao', N'')
INSERT [dbo].[DONHANG] ([MaDonHang], [TenDangNhapKhachHang], [MaSP], [SoLuong], [TongTien], [KichCo], [NgayDatHang], [NgayGiaoHang], [TrangThai], [GhiChu]) VALUES (26, N'KHANG', N'ALD80501            ', 1, 170000, N'L    ', CAST(N'2021-12-05' AS Date), NULL, N'Chưa giao', N'')
SET IDENTITY_INSERT [dbo].[DONHANG] OFF
INSERT [dbo].[GIOHANG] ([TenDangNhapKhachHang], [MaSP], [KichCo], [SoLuongSP]) VALUES (N'KHANG', N'ALD80487            ', N'XL   ', 1)
INSERT [dbo].[GIOHANG] ([TenDangNhapKhachHang], [MaSP], [KichCo], [SoLuongSP]) VALUES (N'KHANG', N'QJDT1428            ', N'30   ', 2)
INSERT [dbo].[KHACHHANG] ([TenDangNhap], [MatKhau], [Hoten], [SoDT], [Email], [DiaChi], [GioiTinh]) VALUES (N'Khang', N'123', N'Lâm Chí Khang', N'0342468501          ', N'Khanglam517@gmail.com', N'Sóc Trăng', N'Nam')
INSERT [dbo].[KHACHHANG] ([TenDangNhap], [MatKhau], [Hoten], [SoDT], [Email], [DiaChi], [GioiTinh]) VALUES (N'Nam', N'123', N'Nguyễn Nhựt Nam', N'0339906489          ', N'nguyennhutnam112@gmail.com', N'Trà Vinh', N'Nam')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'ALD65167            ', 6, N'L    ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'ALD65167            ', 10, N'M    ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'ALD80471            ', 10, N'M    ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'ALD80471            ', 10, N'S    ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'ALD80487            ', 9, N'XL   ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'ALD80501            ', 9, N'L    ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'QJDT1419            ', 10, N'28   ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'QJDT1428            ', 8, N'30   ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'QJDT6476            ', 10, N'29   ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'QJDT6476-ME         ', 10, N'29   ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'QJDT6476-ME         ', 10, N'30   ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'QJDT6476-ME         ', 10, N'31   ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'QJDT6476-ME         ', 10, N'32   ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'QKSL17949           ', 10, N'31   ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'QKSL6205            ', 10, N'31   ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'QKSL625             ', 10, N'29   ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'QKSL6429            ', 10, N'30   ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'SW20243             ', 10, N'29   ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'SW20243             ', 10, N'30   ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'SW20243             ', 10, N'31   ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'TS18155N            ', 10, N'S    ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'TS65258             ', 10, N'M    ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'TSD81291-CO         ', 10, N'L    ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'TSD81291-CO         ', 10, N'M    ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'TSD81291-CO         ', 10, N'S    ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'TSD81508            ', 10, N'L    ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'TSD81508            ', 10, N'M    ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'TSD81511            ', 10, N'L    ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'TSD81527            ', 10, N'L    ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'TSD81527            ', 10, N'M    ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'TSD81527            ', 10, N'S    ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'TSD81527            ', 10, N'XL   ')
INSERT [dbo].[KHO] ([MaSP], [SoLuongTonKho], [KichCo]) VALUES (N'TSD81528            ', 10, N'S    ')
INSERT [dbo].[LOAISANPHAM] ([MaLoai], [TenLoaiSP]) VALUES (N'Ao', N'Áo')
INSERT [dbo].[LOAISANPHAM] ([MaLoai], [TenLoaiSP]) VALUES (N'Quan', N'Quần')
INSERT [dbo].[QUANTRIVIEN] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'Admin', N'123', 1)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'ALD65167            ', N'ÁO LEN NAM OWEN CAO CẤP - ALD65167', 150000, 325000, N'Chất liệu: 98% Cotton, 2% Spandex. Áo T-shirt dài tay chui đầu cổ tròn nam tính. Thiết kế thoải mái theo form dáng Relax Fit giúp chàng trai dễ dàng vận động. Gam màu trẻ trung, năng động, hiện đại.', N'ALD65167.jpg', N'Ao')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'ALD80471            ', N'ÁO LEN - ALD80471', 212500, 425000, N'Chất liệu: 98% Cotton, 2% Spandex. Áo T-shirt dài tay chui đầu cổ tròn nam tính. Thiết kế thoải mái theo form dáng Relax Fit giúp chàng trai dễ dàng vận động. Gam màu trẻ trung, năng động, hiện đại.', N'ALD80471.jpg', N'Ao')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'ALD80487            ', N'ÁO LEN - ALD80487', 222500, 445000, N'Chất liệu: 98% Cotton, 2% Spandex. Áo T-shirt dài tay chui đầu cổ tròn nam tính. Thiết kế thoải mái theo form dáng Relax Fit giúp chàng trai dễ dàng vận động. Gam màu trẻ trung, năng động, hiện đại.', N'ald80487-3.jpg', N'Ao')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'ALD80501            ', N'ÁO LEN NAM OWEN CAO CẤP - ALD80501', 170000, 345000, N'Chất liệu: 98% Cotton, 2% Spandex. Áo T-shirt dài tay chui đầu cổ tròn nam tính. Thiết kế thoải mái theo form dáng Relax Fit giúp chàng trai dễ dàng vận động. Gam màu trẻ trung, năng động, hiện đại.', N'ALD80501.jpg', N'Ao')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'QJDT1419            ', N'QUẦN JEANS - QJDT1419', 282500, 565000, N'Chất liệu: 99% Cotton, 1% Spandex. Chất liệu vải Cotton pha Spandex co dãn, đàn hồi tốt. Thiết kế theo form dáng Slim Fit mạnh mẽ, cá tính. Gam màu tối nam tính, trẻ trung, hiện đại dễ phối đồ.', N'QJDT1419.jpg', N'Quan')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'QJDT1428            ', N'QUẦN JEANS - QJDT1419', 282500, 565000, N'Chất liệu: 99% Cotton, 1% Spandex. Chất liệu vải Cotton pha Spandex co dãn, đàn hồi tốt. Thiết kế theo form dáng Slim Fit mạnh mẽ, cá tính. Gam màu tối nam tính, trẻ trung, hiện đại dễ phối đồ.', N'QJDT1419.jpg', N'Quan')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'QJDT6476            ', N'QUẦN JEANS - QJDT6476-ME', 302500, 605000, N'Chất liệu: 99% Cotton, 1% Spandex. Chất liệu vải Cotton pha Spandex co dãn, đàn hồi tốt. Thiết kế theo form dáng Slim Fit mạnh mẽ, cá tính. Gam màu tối nam tính, trẻ trung, hiện đại dễ phối đồ.', N'QJDT6476-ME.jpg', N'Quan')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'QJDT6476-ME         ', N'QUẦN JEANS - QJDT6476-ME', 302500, 605000, N'Chất liệu: 99% Cotton, 1% Spandex. Chất liệu vải Cotton pha Spandex co dãn, đàn hồi tốt. Thiết kế theo form dáng Slim Fit mạnh mẽ, cá tính. Gam màu tối nam tính, trẻ trung, hiện đại dễ phối đồ.', N'QJDT6476-ME.jpg', N'Quan')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'QKSL17949           ', N'QUẦN KHAKI - QKSL17949', 267500, 525000, N'Chất liệu: 99% Cotton, 1% Spandex. Chất liệu vải Cotton pha Spandex co dãn, đàn hồi tốt. Thiết kế theo form dáng Slim Fit mạnh mẽ, cá tính. Gam màu tối nam tính, trẻ trung, hiện đại dễ phối đồ.', N'QKSL17949.jpg', N'Quan')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'QKSL6205            ', N'QUẦN KHAKI - QKSL6205', 257500, 515000, N'Chất liệu: 99% Cotton, 1% Spandex. Chất liệu vải Cotton pha Spandex co dãn, đàn hồi tốt. Thiết kế theo form dáng Slim Fit mạnh mẽ, cá tính. Gam màu tối nam tính, trẻ trung, hiện đại dễ phối đồ.', N'QKSL6205.jpg', N'Quan')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'QKSL625             ', N'QUẦN KHAKI - QKSL6205', 257500, 515000, N'Chất liệu: 99% Cotton, 1% Spandex. Chất liệu vải Cotton pha Spandex co dãn, đàn hồi tốt. Thiết kế theo form dáng Slim Fit mạnh mẽ, cá tính. Gam màu tối nam tính, trẻ trung, hiện đại dễ phối đồ.', N'QKSL6205.jpg', N'Quan')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'QKSL6429            ', N'QUẦN KHAKI - QKSL6429', 237500, 456000, N'Chất liệu: 99% Cotton, 1% Spandex. Chất liệu vải Cotton pha Spandex co dãn, đàn hồi tốt. Thiết kế theo form dáng Slim Fit mạnh mẽ, cá tính. Gam màu tối nam tính, trẻ trung, hiện đại dễ phối đồ.', N'qksl6429-re_1_.jpg', N'Quan')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'SW20243             ', N'QUẦN SHORT - SW20243', 267500, 340000, N'Chất liệu: 99% Cotton, 1% Spandex. Chất liệu vải Cotton pha Spandex co dãn, đàn hồi tốt. Thiết kế theo form dáng Slim Fit mạnh mẽ, cá tính. Gam màu tối nam tính, trẻ trung, hiện đại dễ phối đồ.', N'SW20243.jpg', N'Quan')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'TS18155N            ', N'ÁO T-SHIRT - TS18155N', 124500, 249000, N'Chất liệu: 98% Cotton, 2% Spandex. Áo T-shirt, kiểu dáng Body Fit thể thao, trẻ trung, năng động. Tone màu tím thời trang, dễ phối đồ. Chất liệu cotton nhẹ, thoải mái, thoáng mát.', N'ts18155n.jpg', N'Ao')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'TS65258             ', N'ÁO T-SHIRT - TS65258', 170000, 345000, N'Chất liệu: 98% Cotton, 2% Spandex. Áo T-shirt dài tay chui đầu cổ tròn nam tính. Thiết kế thoải mái theo form dáng Relax Fit giúp chàng trai dễ dàng vận động. Gam màu trẻ trung, năng động, hiện đại.', N'ts65258-1.jpg', N'Ao')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'TSD81291-CO         ', N'ÁO TSHIRT - TSD81291-CO', 160000, 330000, N'Chất liệu: 98% Cotton, 2% Spandex. Áo T-shirt dài tay chui đầu cổ tròn nam tính. Thiết kế thoải mái theo form dáng Relax Fit giúp chàng trai dễ dàng vận động. Gam màu trẻ trung, năng động, hiện đại.', N'tsd81291.jpg', N'Ao')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'TSD81508            ', N'ÁO NỈ CHUI ĐẦU DÀI TAY - TSD81508', 175000, 355000, N'Chất liệu: 98% Cotton, 2% Spandex. Áo T-shirt dài tay chui đầu cổ tròn nam tính. Thiết kế thoải mái theo form dáng Relax Fit giúp chàng trai dễ dàng vận động. Gam màu trẻ trung, năng động, hiện đại.', N'tsd81508.jpg', N'Ao')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'TSD81511            ', N'ÁO TSHIRT - TSD81511', 210000, 410000, N'Chất liệu: 98% Cotton, 2% Spandex. Áo T-shirt dài tay chui đầu cổ tròn nam tính. Thiết kế thoải mái theo form dáng Relax Fit giúp chàng trai dễ dàng vận động. Gam màu trẻ trung, năng động, hiện đại.', N'tsd81511.jpg', N'Ao')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'TSD81527            ', N'ÁO T-SHIRT DÀI TAY - TSD81527', 180000, 360000, N'Chất liệu: 98% Cotton, 2% Spandex. Áo T-shirt dài tay chui đầu cổ tròn nam tính. Thiết kế thoải mái theo form dáng Relax Fit giúp chàng trai dễ dàng vận động. Gam màu trẻ trung, năng động, hiện đại.', N'tsd81527.jpg', N'Ao')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [GiaCu], [MoTa], [HinhAnh], [MaLoai]) VALUES (N'TSD81528            ', N'ÁO T-SHIRT DÀI TAY - TSD81528', 180000, 360000, N'Chất liệu: 98% Cotton, 2% Spandex. Áo T-shirt dài tay chui đầu cổ tròn nam tính. Thiết kế thoải mái theo form dáng Relax Fit giúp chàng trai dễ dàng vận động. Gam màu trẻ trung, năng động, hiện đại.', N'tsd81528.jpg', N'Ao')
SET ANSI_PADDING ON

GO
/****** Object:  Index [UNI_EMAIL]    Script Date: 12/5/2021 1:35:51 PM ******/
ALTER TABLE [dbo].[KHACHHANG] ADD  CONSTRAINT [UNI_EMAIL] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UNI_SODT]    Script Date: 12/5/2021 1:35:51 PM ******/
ALTER TABLE [dbo].[KHACHHANG] ADD  CONSTRAINT [UNI_SODT] UNIQUE NONCLUSTERED 
(
	[SoDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DONHANG]  WITH CHECK ADD  CONSTRAINT [FK_DONHANG_KHACHHANG] FOREIGN KEY([TenDangNhapKhachHang])
REFERENCES [dbo].[KHACHHANG] ([TenDangNhap])
GO
ALTER TABLE [dbo].[DONHANG] CHECK CONSTRAINT [FK_DONHANG_KHACHHANG]
GO
ALTER TABLE [dbo].[DONHANG]  WITH CHECK ADD  CONSTRAINT [FK_DONHANG_SANPHAM] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[DONHANG] CHECK CONSTRAINT [FK_DONHANG_SANPHAM]
GO
ALTER TABLE [dbo].[GIOHANG]  WITH CHECK ADD  CONSTRAINT [FK_GIOHANG_KHACHHANG] FOREIGN KEY([TenDangNhapKhachHang])
REFERENCES [dbo].[KHACHHANG] ([TenDangNhap])
GO
ALTER TABLE [dbo].[GIOHANG] CHECK CONSTRAINT [FK_GIOHANG_KHACHHANG]
GO
ALTER TABLE [dbo].[GIOHANG]  WITH CHECK ADD  CONSTRAINT [FK_GIOHANG_SANPHAM] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[GIOHANG] CHECK CONSTRAINT [FK_GIOHANG_SANPHAM]
GO
ALTER TABLE [dbo].[KHO]  WITH CHECK ADD  CONSTRAINT [FK_KHO_SANPHAM] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[KHO] CHECK CONSTRAINT [FK_KHO_SANPHAM]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_LOAISANPHAM] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LOAISANPHAM] ([MaLoai])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_LOAISANPHAM]
GO
/****** Object:  StoredProcedure [dbo].[checkLogin]    Script Date: 12/5/2021 1:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[checkLogin]
@Username nvarchar(20),
@Password nvarchar(20)
AS
BEGIN
    IF EXISTS (SELECT * FROM QUANTRIVIEN WHERE TenDangNhap = @Username and MatKhau = @Password and Quyen=1)
        SELECT 0 AS code
	IF EXISTS (SELECT * FROM QUANTRIVIEN WHERE TenDangNhap = @Username and MatKhau != @Password and Quyen=1)
        SELECT 1 AS code
    ELSE IF EXISTS (SELECT * FROM KHACHHANG WHERE TenDangNhap = @Username and MatKhau = @Password)
        select 2 as code
    ELSE IF EXISTS(SELECT * FROM KHACHHANG WHERE TenDangNhap = @Username and MatKhau != @Password) 
        SELECT 3 AS code
    ELSE SELECT 4 AS code
END
GO
USE [master]
GO
ALTER DATABASE [QuanLy_ShopQuanAo] SET  READ_WRITE 
GO
