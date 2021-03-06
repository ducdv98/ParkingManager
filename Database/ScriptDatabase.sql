
USE [master]
GO
/****** Object:  Database [ParkingManager]    Script Date: 12/21/2018 11:31:59 AM ******/
CREATE DATABASE [ParkingManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ParkingManager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ParkingManager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ParkingManager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ParkingManager_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ParkingManager] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ParkingManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ParkingManager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ParkingManager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ParkingManager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ParkingManager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ParkingManager] SET ARITHABORT OFF 
GO
ALTER DATABASE [ParkingManager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ParkingManager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ParkingManager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ParkingManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ParkingManager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ParkingManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ParkingManager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ParkingManager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ParkingManager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ParkingManager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ParkingManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ParkingManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ParkingManager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ParkingManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ParkingManager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ParkingManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ParkingManager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ParkingManager] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ParkingManager] SET  MULTI_USER 
GO
ALTER DATABASE [ParkingManager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ParkingManager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ParkingManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ParkingManager] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ParkingManager] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ParkingManager] SET QUERY_STORE = OFF
GO
USE [ParkingManager]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [ParkingManager]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 12/21/2018 11:31:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [int] IDENTITY(1000,1) NOT NULL,
	[TenCV] [nvarchar](255) NULL,
	[PhanQuyen] [int] NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoanhThu]    Script Date: 12/21/2018 11:31:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoanhThu](
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[NgayCapNhat] [datetime] NULL,
	[DoanhThuTuGuiLuot] [money] NULL,
	[DoanhThuTuGuiThang] [money] NULL,
	[TongDoanhThu] [money] NULL,
 CONSTRAINT [PK_DoanhThu] PRIMARY KEY CLUSTERED 
(
	[Thang] ASC,
	[Nam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/21/2018 11:31:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1000,1) NOT NULL,
	[BKS] [varchar](50) NULL,
	[TenKH] [nvarchar](255) NULL,
	[CMND] [varchar](50) NULL,
	[SDT] [varchar](50) NULL,
	[ToaNha] [varchar](5) NULL,
	[LoaiXe] [int] NULL,
	[KhuVucGui] [int] NULL,
 CONSTRAINT [PK_KhachHang_1] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khu]    Script Date: 12/21/2018 11:31:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khu](
	[MaKhu] [int] IDENTITY(1,1) NOT NULL,
	[TenKhu] [nvarchar](50) NULL,
	[SL_ToiDa] [int] NULL,
	[SL_ConTrong] [int] NULL,
	[LoaiXe] [int] NULL,
	[ChoPhepGuiLuot] [bit] NULL,
 CONSTRAINT [PK_Khu] PRIMARY KEY CLUSTERED 
(
	[MaKhu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 12/21/2018 11:31:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiXe](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiXe] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MucPhi]    Script Date: 12/21/2018 11:31:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MucPhi](
	[MaMP] [int] IDENTITY(1000,1) NOT NULL,
	[TenMP] [nvarchar](255) NULL,
	[MucPhi] [money] NULL,
	[MaLoaiXe] [int] NULL,
	[HinhThuc] [nvarchar](50) NULL,
 CONSTRAINT [PK_MucPhi] PRIMARY KEY CLUSTERED 
(
	[MaMP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/21/2018 11:31:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1000,1) NOT NULL,
	[TenNV] [nvarchar](255) NULL,
	[SDT] [varchar](50) NULL,
	[CMND] [varchar](50) NULL,
	[MaCV] [int] NULL,
	[TaiKhoan] [varchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuGiuXe]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuGiuXe](
	[MaP] [int] IDENTITY(1000,1) NOT NULL,
	[BKS] [varchar](50) NULL,
	[ThoiGian] [datetime] NULL,
	[KhuVuc] [int] NULL,
	[LoaiXe] [int] NULL,
	[MaTheXe] [varchar](50) NULL,
	[MaPhi] [int] NULL,
	[DaThuTien] [bit] NULL,
 CONSTRAINT [PK_PhieuGiuXe] PRIMARY KEY CLUSTERED 
(
	[MaP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuThang]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThang](
	[MaP] [int] IDENTITY(1000,1) NOT NULL,
	[MaKH] [int] NOT NULL,
	[NgayCapNhat] [datetime] NULL,
	[MaPhi] [int] NULL,
	[MaTheXe] [varchar](50) NULL,
	[TrangThai] [bit] NULL,
	[XeDangOTrongBai] [bit] NULL,
 CONSTRAINT [PK_PhieuThang] PRIMARY KEY CLUSTERED 
(
	[MaP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheXe]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheXe](
	[MaTheXe] [varchar](50) NOT NULL,
	[TrangThai] [bit] NULL,
	[Loai] [nvarchar](50) NULL,
 CONSTRAINT [PK_TheXe] PRIMARY KEY CLUSTERED 
(
	[MaTheXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DoanhThu] ADD  CONSTRAINT [DF_DoanhThu_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[DoanhThu] ADD  CONSTRAINT [DF_DoanhThu_DoanhThuTuGuiLuot]  DEFAULT ((0)) FOR [DoanhThuTuGuiLuot]
GO
ALTER TABLE [dbo].[DoanhThu] ADD  CONSTRAINT [DF_DoanhThu_DoanhThuTuGuiThang]  DEFAULT ((0)) FOR [DoanhThuTuGuiThang]
GO
ALTER TABLE [dbo].[DoanhThu] ADD  CONSTRAINT [DF_DoanhThu_TongDoanhThu]  DEFAULT ((0)) FOR [TongDoanhThu]
GO
ALTER TABLE [dbo].[PhieuGiuXe] ADD  CONSTRAINT [DF_PhieuGiuXe_TrangThai]  DEFAULT ((0)) FOR [DaThuTien]
GO
ALTER TABLE [dbo].[PhieuThang] ADD  CONSTRAINT [DF_PhieuThang_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[PhieuThang] ADD  CONSTRAINT [DF_PhieuThang_TrangThai]  DEFAULT ((1)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[PhieuThang] ADD  CONSTRAINT [DF_PhieuThang_XeDangOTrongBai]  DEFAULT ((0)) FOR [XeDangOTrongBai]
GO
ALTER TABLE [dbo].[TheXe] ADD  CONSTRAINT [DF_TheXe_TrangThai]  DEFAULT ((1)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[TheXe] ADD  CONSTRAINT [DF_TheXe_Loai]  DEFAULT (N'Lượt') FOR [Loai]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_Khu] FOREIGN KEY([KhuVucGui])
REFERENCES [dbo].[Khu] ([MaKhu])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_Khu]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_LoaiXe] FOREIGN KEY([LoaiXe])
REFERENCES [dbo].[LoaiXe] ([MaLoai])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_LoaiXe]
GO
ALTER TABLE [dbo].[Khu]  WITH CHECK ADD  CONSTRAINT [FK_Khu_LoaiXe] FOREIGN KEY([LoaiXe])
REFERENCES [dbo].[LoaiXe] ([MaLoai])
GO
ALTER TABLE [dbo].[Khu] CHECK CONSTRAINT [FK_Khu_LoaiXe]
GO
ALTER TABLE [dbo].[MucPhi]  WITH CHECK ADD  CONSTRAINT [FK_MucPhi_LoaiXe] FOREIGN KEY([MaLoaiXe])
REFERENCES [dbo].[LoaiXe] ([MaLoai])
GO
ALTER TABLE [dbo].[MucPhi] CHECK CONSTRAINT [FK_MucPhi_LoaiXe]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan] FOREIGN KEY([TaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan]
GO
ALTER TABLE [dbo].[PhieuGiuXe]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiuXe_LoaiXe] FOREIGN KEY([LoaiXe])
REFERENCES [dbo].[LoaiXe] ([MaLoai])
GO
ALTER TABLE [dbo].[PhieuGiuXe] CHECK CONSTRAINT [FK_PhieuGiuXe_LoaiXe]
GO
ALTER TABLE [dbo].[PhieuGiuXe]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiuXe_MucPhi] FOREIGN KEY([MaPhi])
REFERENCES [dbo].[MucPhi] ([MaMP])
GO
ALTER TABLE [dbo].[PhieuGiuXe] CHECK CONSTRAINT [FK_PhieuGiuXe_MucPhi]
GO
ALTER TABLE [dbo].[PhieuGiuXe]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiuXe_TheXe] FOREIGN KEY([MaTheXe])
REFERENCES [dbo].[TheXe] ([MaTheXe])
GO
ALTER TABLE [dbo].[PhieuGiuXe] CHECK CONSTRAINT [FK_PhieuGiuXe_TheXe]
GO
ALTER TABLE [dbo].[PhieuThang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[PhieuThang] CHECK CONSTRAINT [FK_PhieuThang_KhachHang]
GO
ALTER TABLE [dbo].[PhieuThang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThang_MucPhi] FOREIGN KEY([MaPhi])
REFERENCES [dbo].[MucPhi] ([MaMP])
GO
ALTER TABLE [dbo].[PhieuThang] CHECK CONSTRAINT [FK_PhieuThang_MucPhi]
GO
ALTER TABLE [dbo].[PhieuThang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThang_TheXe] FOREIGN KEY([MaTheXe])
REFERENCES [dbo].[TheXe] ([MaTheXe])
GO
ALTER TABLE [dbo].[PhieuThang] CHECK CONSTRAINT [FK_PhieuThang_TheXe]
GO
/****** Object:  StoredProcedure [dbo].[get_number_of_ticket]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[get_number_of_ticket]
-- Lấy ra tổng số lượng vé xe và số lượng vé đã được cấp cho khách hàng
AS
BEGIN
	SELECT COUNT(*) AS TongSoVe FROM TheXe
	SELECT COUNT(*) AS DaPhatRa FROM TheXe WHERE TrangThai = 0
END
GO
/****** Object:  StoredProcedure [dbo].[usp_delete_customer]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery10.sql|7|0|C:\Users\Admin\AppData\Local\Temp\~vs6B4.sql
CREATE PROC [dbo].[usp_delete_customer]
-- Xoá khách hàng và phiếu tháng tương ứng
@customerId int
AS
BEGIN

	-- Lấy mã thẻ xe của khách hàng này đang giữ và trả về trạng thái chưa được cấp phát
	DECLARE @ticketId varchar(50)
	SELECT @ticketId = MaTheXe FROM PhieuThang WHERE MaKH = @customerId

	UPDATE TheXe SET TrangThai = 1 WHERE MaTheXe = @ticketId

	-- Kiểm tra xe của khách hàng này có đang trong nhà xe hay không, nếu có thì cập nhật số lượng trống cho khu vực tương ứng
	IF (SELECT XeDangOTrongBai FROM PhieuThang WHERE MaKH = @customerId) = 1
	BEGIN

		DECLARE @areaId int
		SELECT @areaId = KhuVucGui FROM KhachHang WHERE MaKH = @customerId
		
		UPDATE Khu SET SL_ConTrong = SL_ConTrong + 1 WHERE MaKhu = @areaId
	END

	-- Xoá khách hàng và phiếu tháng của khách hàng đó
	DELETE FROM PhieuThang WHERE MaKH = @customerId
	DELETE FROM KhachHang WHERE MaKH = @customerId
	
END
GO
/****** Object:  StoredProcedure [dbo].[usp_extend_term]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_extend_term]
-- Gia hạn cho phiếu tháng cho khách hàng, cập nhật trạng thái thành đã thanh toán và ngày cập nhật
@ticketId varchar(50)
AS
BEGIN
	UPDATE PhieuThang SET TrangThai = 1, NgayCapNhat = GETDATE() WHERE MaTheXe = @ticketId
END
GO
/****** Object:  StoredProcedure [dbo].[usp_get_all_customer]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_get_all_customer]
-- Lấy thông tin tất cả khách hàng
AS
BEGIN
	SELECT k.MaKH, TenKH, SDT, CMND, ToaNha, BKS, p.MaTheXe, p.TrangThai, p.XeDangOTrongBai FROM KhachHang k INNER JOIN PhieuThang p ON k.MaKH = p.MaKH
END
GO
/****** Object:  StoredProcedure [dbo].[usp_get_available_ticket_id]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_get_available_ticket_id]
-- Lấy ra mã vé xe chưa được sử dụng với loại tương ứng 
@mode bit
AS
BEGIN
	-- Vé tháng
	IF @mode = 1
	BEGIN
		SELECT TOP 1 MaTheXe FROM TheXe WHERE TrangThai = 1 AND Loai = N'Tháng'
	END
	-- Vé lượt
	ELSE
	BEGIN
		SELECT TOP 1 MaTheXe FROM TheXe WHERE TrangThai = 1 AND Loai = N'Lượt'
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_get_customer_infor]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery6.sql|7|0|C:\Users\Admin\AppData\Local\Temp\~vsDB2C.sql
CREATE PROC [dbo].[usp_get_customer_infor]
-- Lấy thông tin khách hàng theo mã vé xe, dùng cho cả lượt vào và lượt ra
@ticketId varchar(50),
@mode bit
AS
BEGIN

	-- Kiểm tra mã vé xe có hợp lệ hay không
	DECLARE @result int
	SELECT @result = COUNT(*) FROM TheXe WHERE MaTheXe = @ticketId AND TrangThai = 0
	-- Không hợp lệ
	IF @result = 0
		BEGIN
			RETURN @result
		END
	-- Hợp lệ
	ELSE
		BEGIN
			-- Kiểm tra xem mã thẻ xe đó có phải là thẻ xe lượt hay không và trả về thông tin theo kiểu vé lượt
			IF (SELECT Loai FROM TheXe WHERE MaTheXe = @ticketId) = N'Lượt'
				BEGIN
					SELECT BKS, KhuVuc, LoaiXe, m.MaMP, m.MucPhi FROM PhieuGiuXe p INNER JOIN MucPhi m ON p.MaPhi = m.MaMP 
					WHERE MaTheXe = @ticketId AND DaThuTien = 0
					SET @result = 1
					RETURN @result
				END
			-- Là vé tháng
			ELSE
			-- Kiểm tra xem xe của khách hàng có trong nhà xe hay không, tuỳ theo là lượt vào hay lượt ra để cho phép lấy thông tin
					BEGIN
					DECLARE @isParking bit
					-- Xe vào : nếu xe không có trong bãi, không cho phép vào
					IF @mode = 0
						BEGIN
							SELECT @isParking = XeDangOTrongBai FROM PhieuThang WHERE MaTheXe = @ticketId
							IF @isParking = 1
							BEGIN
								SET @result = -1
								RETURN @result
							END
						END

					-- Xe ra : nếu xe không có trong bãi, không cho phép ra
					IF @mode = 1
					BEGIN
						SELECT @isParking = XeDangOTrongBai FROM PhieuThang WHERE MaTheXe = @ticketId
						IF @isParking = 0
						BEGIN
							SET @result = -1
							RETURN @result
						END
					END

		
					-- Lấy thông tin khách hàng
					DECLARE @customerId int
					DECLARE @vehicleType int

					SELECT @customerId = MaKH FROM PhieuThang WHERE MaTheXe = @ticketId
					SELECT @vehicleType = LoaiXe FROM KhachHang WHERE MaKH = @customerId

					SELECT kh.BKS, kh.TenKH, kh.CMND, kh.SDT, kh.ToaNha, l.MaLoai, k.MaKhu FROM LoaiXe l INNER JOIN (KhachHang kh INNER JOIN Khu k ON kh.KhuVucGui = k.MaKhu)
											ON l.MaLoai = kh.LoaiXe WHERE kh.MaKH = @customerId

					SELECT TrangThai FROM PhieuThang WHERE MaTheXe = @ticketId

					SELECT MaMP, MucPhi FROM MucPhi WHERE MaMP = (SELECT MaPhi FROM PhieuThang WHERE MaTheXe = @ticketId)
					
					SET @result = 2
					RETURN @result

				END	

		END
		
END
GO
/****** Object:  StoredProcedure [dbo].[usp_get_in_term_mode]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_get_in_term_mode]
-- Gửi xe theo vé tháng
@ticketId varchar(50)
AS
BEGIN
	-- Kiểm tra vé tháng còn trong thời gian sử dụng hay không
	DECLARE @status bit
	DECLARE @result int
	SELECT @status = TrangThai FROM PhieuThang WHERE MaTheXe = @ticketId
	IF @status = 0 OR @status = NULL
	BEGIN
		SET @result = -1
		RETURN @result;
	END
	ELSE
	BEGIN
		
		DECLARE @areaId int
		DECLARE @customerId int
		SELECT @customerId = MaKH FROM PhieuThang WHERE MaTheXe = @ticketId
		SELECT @areaId = KhuVucGui FROM KhachHang WHERE MaKH = @customerId

		-- Kiểm tra số lượng chỗ trong của khu vực xe sắp được gửi
		DECLARE @available int
		SELECT @available = SL_ConTrong FROM Khu WHERE MaKhu = @areaId
		IF @available < 1
		BEGIN
			SET @result = 0
			RETURN @result
		END

		ELSE
		BEGIN
			-- Cập nhật số lượng chỗ trong của khu và cập nhật trạng thái xe đang ở trong bãi
			BEGIN TRY
				UPDATE PhieuThang SET XeDangOTrongBai = 1 WHERE MaTheXe = @ticketId
				UPDATE Khu SET SL_ConTrong = SL_ConTrong - 1 WHERE MaKhu = @areaId
				SET @result = 1;
				RETURN @result;
			END TRY
		
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS ErrorMessage;
				ROLLBACK TRAN
				SET @result = 0
				RETURN @result
			END CATCH

		END
	END

END
GO
/****** Object:  StoredProcedure [dbo].[usp_get_in_turn_mode]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_get_in_turn_mode]
-- Gửi xe theo lượt
@ticketId varchar(50),
@licsenPlate varchar(50) null,
@time datetime,
@areaId int,
@vehicleType int
AS
BEGIN
	-- Kiểm tra số lượng chỗ trống của khu vực mà xe sắp được gửi
	DECLARE @result int
	DECLARE @available int
	SELECT @available = SL_ConTrong FROM Khu WHERE MaKhu = @areaId
	IF @available < 1
	BEGIN
		SET @result = 0
		RETURN @result
	END

	ELSE
	BEGIN
		-- Thêm PhieuGiuXe mới và cập nhật lại số lượng chỗ trong của khu và tình trạng của vé xe
		INSERT INTO PhieuGiuXe (BKS, ThoiGian, KhuVuc, LoaiXe, MaTheXe, MaPhi)
		VALUES (@licsenPlate, @time, @areaId, (SELECT MaLoai FROM LoaiXe WHERE MaLoai = @vehicleType), (SELECT MaTheXe FROM TheXe WHERE MaTheXe = @ticketId), (SELECT MaMP FROM MucPhi WHERE MaLoaiXe = @vehicleType AND HinhThuc = N'Lượt'))

		BEGIN TRY
			UPDATE Khu SET SL_ConTrong = SL_ConTrong - 1 WHERE MaKhu = @areaId
			UPDATE TheXe SET TrangThai = 0 WHERE MaTheXe = @ticketId
			SET @result = 1
			RETURN @result
		END TRY
		BEGIN CATCH
			SELECT ERROR_MESSAGE() AS ErrorMessage;
			ROLLBACK TRAN
			SET @result = 0
			RETURN @result
		END CATCH
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_get_infor_of_area]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_get_infor_of_area]
-- Lấy ra thông tin của 1 khu vực
@id int
AS
BEGIN
	SELECT SL_ToiDa, SL_ConTrong, ChoPhepGuiLuot FROM Khu WHERE MaKhu = @id
END
GO
/****** Object:  StoredProcedure [dbo].[usp_get_out_of_parking]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_get_out_of_parking]
-- Cho xe ra khỏi nhà xe và thanh toán
@ticketId varchar(50),
@mode bit
AS
BEGIN
	--Giữ lượt
	IF @mode = 1
		BEGIN
			UPDATE Khu SET SL_ConTrong = SL_ConTrong + 1 WHERE MaKhu = (SELECT KhuVuc FROM PhieuGiuXe WHERE MaTheXe = @ticketId AND DaThuTien = 0)
			UPDATE PhieuGiuXe SET DaThuTien = 1 WHERE MaTheXe = @ticketId AND DaThuTien = 0
			UPDATE TheXe SET TrangThai = 1 WHERE MaTheXe = @ticketId
		END
	-- Giữ tháng
	ELSE
		BEGIN
			UPDATE PhieuThang SET XeDangOTrongBai = 0 WHERE MaTheXe = @ticketId
			DECLARE @areaId int
			SELECT @areaId = KhuVucGui FROM KhachHang WHERE MaKH = (SELECT MaKH FROM PhieuThang WHERE MaTheXe = @ticketId)
			UPDATE Khu SET SL_ConTrong = SL_ConTrong + 1 WHERE MaKhu = @areaId
		END

END
GO
/****** Object:  StoredProcedure [dbo].[usp_get_price_list]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_get_price_list]
-- Lấy ra thông tin các mức phí
@mode bit
AS
BEGIN
	-- Chỉ lấy ra các mức phí của các xe gửi tháng
	IF @mode = 1
		BEGIN
			SELECT MaMP, MucPhi FROM MucPhi WHERE HinhThuc = N'Tháng'
		END
	-- Lấy ra toàn bộ các mức phí
	ELSE
		BEGIN
			SELECT MucPhi FROM MucPhi
		END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_get_revenue]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_get_revenue]
-- Lấy thông tin doanh thu theo tháng
@date datetime
AS
BEGIN
	SELECT DoanhThuTuGuiLuot, DoanhThuTuGuiThang, TongDoanhThu FROM DoanhThu WHERE Thang = MONTH(@date) AND Nam = YEAR(@date)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_login]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_login]
-- Kiểm tra thông tin đăng nhập, trả về thông tin nhân viên tương ứng nếu có
@username varchar(50),
@password varchar(50)
AS
BEGIN
	DECLARE @count int
	SET @count = 0
	SELECT @count = COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @username AND MatKhau = @password
	IF @count = 0
	BEGIN
		RETURN @count;
	END
	ELSE
	BEGIN
		SELECT n.MaNV, n.TenNV, n.SDT, n.CMND, c.TenCV, c.PhanQuyen FROM NhanVien n INNER JOIN ChucVu c ON n.MaCV = c.MaCV
		WHERE n.TaiKhoan = @username
		RETURN @count;
	END

END	
GO
/****** Object:  StoredProcedure [dbo].[usp_register_customer]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_register_customer]
-- Thêm mới khách hàng và tạo mới vé tháng cho khách hàng đó
@name nvarchar(255),
@licensePlate varchar(50),
@idCard varchar(50),
@phoneNum varchar(50),
@block varchar(50),
@vehicleType int,
@areaId int,
@ticketId varchar(50),
@feeId int
AS
BEGIN
	INSERT INTO KhachHang (BKS, TenKH, CMND, SDT, ToaNha, LoaiXe, KhuVucGui)
	VALUES (@licensePlate, @name, @idCard, @phoneNum, @block, (SELECT MaLoai FROM LoaiXe WHERE MaLoai = @vehicleType), (SELECT @areaId FROM Khu WHERE MaKhu = @areaId))

	DECLARE @customerId int
	SELECT TOP 1 @customerId = MaKH FROM KhachHang ORDER BY MaKH DESC

	INSERT INTO PhieuThang(MaKH, MaPhi, MaTheXe)
	VALUES ((SELECT TOP 1 MaKH FROM KhachHang ORDER BY MaKH DESC), (SELECT MaMP FROM MucPhi WHERE MaMP = @feeId), (SELECT MaTheXe FROM TheXe WHERE MaTheXe = @ticketId))

	UPDATE TheXe SET TrangThai = 0 WHERE MaTheXe = @ticketId
END
GO
/****** Object:  StoredProcedure [dbo].[usp_reset_status_for_all_user]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_reset_status_for_all_user]
-- Cập nhật lại trạng thái hết hạn khi sang tháng mới
AS
BEGIN
	IF (DAY(getdate()) = 1)
	BEGIN
		UPDATE PhieuThang SET TrangThai = 0 WHERE NgayCapNhat < GETDATE()
	END 
END
GO
/****** Object:  StoredProcedure [dbo].[usp_update_price_list]    Script Date: 12/21/2018 11:32:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_update_price_list]
-- Cập nhật lại bảng giá cho các hình thức và loại xe
@pBikeTurn money,
@pBikeTerm money,
@pEBikeTurn money,
@pEBikeTerm money,
@pMBikeTurn money,
@pMBikeTerm money,
@pTBikeTurn money,
@pTBikeTerm money
AS
BEGIN
	UPDATE MucPhi SET MucPhi = @pBikeTurn WHERE MaMP = 1000
	UPDATE MucPhi SET MucPhi = @pBikeTerm WHERE MaMP = 1001
	UPDATE MucPhi SET MucPhi = @pEBikeTurn WHERE MaMP = 1002
	UPDATE MucPhi SET MucPhi = @pEBikeTerm WHERE MaMP = 1003
	UPDATE MucPhi SET MucPhi = @pMBikeTurn WHERE MaMP = 1004
	UPDATE MucPhi SET MucPhi = @pMBikeTerm WHERE MaMP = 1005
	UPDATE MucPhi SET MucPhi = @pTBikeTurn WHERE MaMP = 1006
	UPDATE MucPhi SET MucPhi = @pTBikeTerm WHERE MaMP = 1007

END
GO
USE [master]
GO
ALTER DATABASE [ParkingManager] SET  READ_WRITE 
GO
