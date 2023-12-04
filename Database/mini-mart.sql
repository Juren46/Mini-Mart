USE [master]
GO
/****** Object:  Database [mini-mart]    Script Date: 12/3/2023 7:40:38 PM ******/
CREATE DATABASE [mini-mart]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'mini-mart', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.ELIO\MSSQL\DATA\mini-mart.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'mini-mart_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.ELIO\MSSQL\DATA\mini-mart_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [mini-mart] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mini-mart].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [mini-mart] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [mini-mart] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [mini-mart] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [mini-mart] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [mini-mart] SET ARITHABORT OFF 
GO
ALTER DATABASE [mini-mart] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [mini-mart] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [mini-mart] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [mini-mart] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [mini-mart] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [mini-mart] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [mini-mart] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [mini-mart] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [mini-mart] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [mini-mart] SET  DISABLE_BROKER 
GO
ALTER DATABASE [mini-mart] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [mini-mart] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [mini-mart] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [mini-mart] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [mini-mart] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [mini-mart] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [mini-mart] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [mini-mart] SET RECOVERY FULL 
GO
ALTER DATABASE [mini-mart] SET  MULTI_USER 
GO
ALTER DATABASE [mini-mart] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [mini-mart] SET DB_CHAINING OFF 
GO
ALTER DATABASE [mini-mart] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [mini-mart] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [mini-mart] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [mini-mart] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'mini-mart', N'ON'
GO
ALTER DATABASE [mini-mart] SET QUERY_STORE = ON
GO
ALTER DATABASE [mini-mart] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [mini-mart]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 12/3/2023 7:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[maHoaDon] [char](15) NOT NULL,
	[maSanPham] [char](8) NOT NULL,
	[tenSanPham] [nvarchar](255) NOT NULL,
	[donVi] [nvarchar](50) NOT NULL,
	[soLuong] [int] NOT NULL,
	[donGia] [money] NOT NULL,
	[tongTien] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 12/3/2023 7:40:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[maPhieuNhap] [char](8) NOT NULL,
	[maSanPham] [char](8) NOT NULL,
	[tenSanPham] [nvarchar](255) NOT NULL,
	[donVi] [nvarchar](50) NOT NULL,
	[soLuong] [int] NOT NULL,
	[giaBan] [money] NOT NULL,
	[giaNhap] [money] NOT NULL,
	[tongTien] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/3/2023 7:40:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[maHoaDon] [char](15) NOT NULL,
	[maNhanVien] [char](8) NOT NULL,
	[maKhachHang] [char](8) NULL,
	[maKhuyenMai] [char](8) NULL,
	[thoiGianTao] [datetime2](0) NOT NULL,
	[tongTien] [money] NOT NULL,
	[giamGia] [money] NOT NULL,
	[thanhTien] [money] NOT NULL,
	[tienNhan] [money] NOT NULL,
	[tienThua] [money] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[maHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/3/2023 7:40:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[maKhachHang] [char](8) NOT NULL,
	[hangThanhVien] [nvarchar](4) NOT NULL,
	[diemThanhVien] [int] NOT NULL,
	[hoTen] [nvarchar](255) NOT NULL,
	[gioiTinh] [nvarchar](3) NULL,
	[ngaySinh] [date] NULL,
	[soDienThoai] [varchar](15) NOT NULL,
	[email] [varchar](255) NULL,
	[diaChi] [nvarchar](255) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[maKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 12/3/2023 7:40:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[maKhuyenMai] [char](8) NOT NULL,
	[tenKhuyenMai] [nvarchar](255) NOT NULL,
	[thoiGianBatDau] [datetime2](0) NOT NULL,
	[thoiGianKetThuc] [datetime2](0) NOT NULL,
	[loaiGiaTri] [nvarchar](9) NOT NULL,
	[giaTri] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_KhuyenMai] PRIMARY KEY CLUSTERED 
(
	[maKhuyenMai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 12/3/2023 7:40:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[maLoaiSanPham] [char](8) NOT NULL,
	[tenLoaiSanPham] [nvarchar](255) NOT NULL,
	[trangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiSanPham_1] PRIMARY KEY CLUSTERED 
(
	[maLoaiSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 12/3/2023 7:40:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[maNguoiDung] [char](8) NOT NULL,
	[maPhanQuyen] [char](4) NOT NULL,
	[tenDangNhap] [varchar](255) NOT NULL,
	[matKhau] [varchar](255) NOT NULL,
	[hoTen] [nvarchar](255) NOT NULL,
	[gioiTinh] [nvarchar](3) NULL,
	[ngaySinh] [date] NULL,
	[soDienThoai] [varchar](15) NULL,
	[email] [varchar](255) NULL,
	[diaChi] [nvarchar](255) NULL,
	[trangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[maNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 12/3/2023 7:40:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[maNhaCungCap] [char](8) NOT NULL,
	[tenNhaCungCap] [nvarchar](255) NOT NULL,
	[soDienThoai] [varchar](15) NULL,
	[email] [varchar](255) NULL,
	[diaChi] [nvarchar](255) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[maNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 12/3/2023 7:40:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[maPhanQuyen] [char](4) NOT NULL,
	[tenPhanQuyen] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[maPhanQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 12/3/2023 7:40:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[maPhieuNhap] [char](8) NOT NULL,
	[maNhaCungCap] [char](8) NOT NULL,
	[maNguoiTao] [char](8) NOT NULL,
	[maNguoiDuyet] [char](8) NULL,
	[thoiGianTao] [datetime2](0) NOT NULL,
	[thoiGianDuyet] [datetime2](0) NULL,
	[thanhTien] [money] NOT NULL,
	[trangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[maPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 12/3/2023 7:40:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[maSanPham] [char](8) NOT NULL,
	[maLoaiSanPham] [char](8) NOT NULL,
	[tenSanPham] [nvarchar](255) NOT NULL,
	[donVi] [nvarchar](50) NOT NULL,
	[soLuong] [int] NOT NULL,
	[giaBan] [money] NOT NULL,
	[duLieuAnh] [image] NOT NULL,
	[trangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[maSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([maHoaDon])
REFERENCES [dbo].[HoaDon] ([maHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([maSanPham])
REFERENCES [dbo].[SanPham] ([maSanPham])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([maPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([maPhieuNhap])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_SanPham] FOREIGN KEY([maSanPham])
REFERENCES [dbo].[SanPham] ([maSanPham])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([maKhachHang])
REFERENCES [dbo].[KhachHang] ([maKhachHang])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhuyenMai] FOREIGN KEY([maKhuyenMai])
REFERENCES [dbo].[KhuyenMai] ([maKhuyenMai])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhuyenMai]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NguoiDung] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[NguoiDung] ([maNguoiDung])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NguoiDung]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_PhanQuyen] FOREIGN KEY([maPhanQuyen])
REFERENCES [dbo].[PhanQuyen] ([maPhanQuyen])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_PhanQuyen]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCungCap] FOREIGN KEY([maNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([maNhaCungCap])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([maLoaiSanPham])
REFERENCES [dbo].[LoaiSanPham] ([maLoaiSanPham])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
USE [master]
GO
ALTER DATABASE [mini-mart] SET  READ_WRITE 
GO
