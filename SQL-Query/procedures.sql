USE [BANVECHUYENBAY]
GO

CREATE PROC [dbo].[GetFlightData] 
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
		AS [GheTrong]
	FROM 
		CHUYENBAY cb JOIN
		DUONGBAY db ON (cb.MaDuongBay=db.MaDuongBay) JOIN
		SANBAY sb1 ON (db.MaSanBayDi=sb1.MaSanBay) JOIN
		SANBAY sb2 ON (db.MaSanBayDen=sb2.MaSanBay) JOIN
		SANBAYTG sbtg ON (db.MaDuongBay=sbtg.MaDuongBay) JOIN
		CHITIETHANGVE cthv ON (cb.MaChuyenBay=cthv.MaChuyenBay)	
	GROUP BY cb.MaChuyenBay, sb1.MaSanBay, sb2.MaSanBay, sb1.TenSanBay, sb2.TenSanBay, sb1.VietTat, sb2.VietTat, NgayGio, cb.GiaVe

END
GO