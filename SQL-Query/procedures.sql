USE [BANVECHUYENBAY]
GO

ALTER PROC [dbo].[GetFlightData] 
AS
BEGIN
	SELECT 
		cb.MaChuyenBay,
		sb1.MaSanBay AS [MaSanBayDi],
		sb2.MaSanBay AS [MaSanBayDen],
		sb1.TenSanBay AS [SanBayDi],
		sb2.TenSanBay AS [SanBayDen],
		sb1.VietTat AS [SanBayDiVietTat],
		sb2.VietTat AS [SanBayDenVietTat],
		cb.NgayGio,
		COUNT(DISTINCT sbtg.MaSanBayTG) AS [SoDiemDung],
		COUNT(DISTINCT cthv.MaCTHV) AS [SoHangVe],
		cb.GiaVe,
		SUM(DISTINCT cthv.SoGhe) - 
		(
			SELECT ISNULL(COUNT(MaVe), 0)
			FROM VE
			WHERE VE.MaChuyenBay=cb.MaChuyenBay
		) - 
		(
			SELECT ISNULL(SUM(SoVeDat), 0)
			FROM DATCHO
			WHERE DATCHO.MaChuyenBay=cb.MaChuyenBay
		) 
		AS [GheTrong],
		(SELECT SUM(SoVeDat) FROM DATCHO 
		WHERE DATCHO.MaChuyenBay=cb.MaChuyenBay)
		AS [SoGheDat],
		cb.DaKhoiHanh
	FROM 
		CHUYENBAY cb LEFT JOIN
		DUONGBAY db ON (cb.MaDuongBay=db.MaDuongBay) LEFT JOIN
		SANBAY sb1 ON (db.MaSanBayDi=sb1.MaSanBay) LEFT JOIN
		SANBAY sb2 ON (db.MaSanBayDen=sb2.MaSanBay) LEFT JOIN
		SANBAYTG sbtg ON (db.MaDuongBay=sbtg.MaDuongBay) LEFT JOIN
		CHITIETHANGVE cthv ON (cb.MaChuyenBay=cthv.MaChuyenBay)	
	GROUP BY cb.MaChuyenBay, sb1.MaSanBay, sb2.MaSanBay, sb1.TenSanBay, sb2.TenSanBay, sb1.VietTat, sb2.VietTat, NgayGio, cb.GiaVe, cb.DaKhoiHanh

END
GO