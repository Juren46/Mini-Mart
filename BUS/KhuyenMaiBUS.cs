using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhuyenMaiBUS
    {
        KhuyenMaiDAO khuyenMaiDAO;

        public KhuyenMaiBUS()
        {
            khuyenMaiDAO = new KhuyenMaiDAO();
        }

        public List<KhuyenMai> LayDanhSachKhuyenMai()
        {
            return khuyenMaiDAO.LayDanhSachKhuyenMai();
        }

        public int DemSoKhuyenMai()
        {
            return khuyenMaiDAO.DemSoKhuyenMai();
        }

        public KhuyenMai LayKhuyenMaiTheoMa(string maKhuyenMai)
        {
            return khuyenMaiDAO.LayKhuyenMaiTheoMa(maKhuyenMai);
        }

        public string ThemKhuyenMai(string maKhuyenMai, string maQuanLi, string tenKhuyenMai, string thoiGianBatDau, string thoiGianKetThuc, string loaiGiaTri, string giaTriApDung)
        {
            if (string.IsNullOrEmpty(tenKhuyenMai) || string.IsNullOrEmpty(thoiGianBatDau) || string.IsNullOrEmpty(thoiGianKetThuc) || string.IsNullOrEmpty(loaiGiaTri) || string.IsNullOrEmpty(giaTriApDung))
                return "Vui lòng nhập đầy đủ thông tin!";

            DateTime dateTimeBatDau = DateTime.ParseExact(thoiGianBatDau, "dd/MM/yyyy HH:mm:ss", null);
            DateTime dateTimeKetThuc = DateTime.ParseExact(thoiGianKetThuc, "dd/MM/yyyy HH:mm:ss", null);

            if (dateTimeBatDau > dateTimeKetThuc)
                return "Thời gian bắt đầu phải trước thời gian kết thúc!";

            if (dateTimeBatDau < DateTime.Now)
                return "Thời gian bắt đầu không được trước thời điểm hiện tại!";

            if (!Decimal.TryParse(giaTriApDung, out decimal decimalGiaTriApDung))
                return "Giá trị áp dụng phải là kiểu decimal!";

            if (Decimal.Parse(giaTriApDung) <= 0)
                return "Giá trị áp dụng không được bé hơn 0!";

            KhuyenMai khuyenMai = new KhuyenMai();

            khuyenMai.maKhuyenMai = maKhuyenMai;
            khuyenMai.maQuanLi = maQuanLi;
            khuyenMai.tenKhuyenMai = tenKhuyenMai.Trim();
            khuyenMai.thoiGianBatDau = dateTimeBatDau;
            khuyenMai.thoiGianKetThuc = dateTimeKetThuc;
            khuyenMai.loaiGiaTri = loaiGiaTri;
            khuyenMai.giaTriApDung = decimalGiaTriApDung;

            if (khuyenMaiDAO.ThemKhuyenMai(khuyenMai))
                return "Thêm khuyến mãi thành công!";
            else
                return "Thêm khuyến mãi thất bại!";
        }

        public string XoaKhuyenMai(string maKhuyenMai)
        {
            if (khuyenMaiDAO.XoaKhuyenMai(maKhuyenMai))
                return "Xóa khuyến mãi thành công!";
            else
                return "Xóa khuyến mãi thất bại!";
        }

        public string SuaKhuyenMai(string maKhuyenMai, string tenKhuyenMai, string thoiGianBatDau, string thoiGianKetThuc, string loaiGiaTri, string giaTriApDung)
        {
            if (string.IsNullOrEmpty(tenKhuyenMai) || string.IsNullOrEmpty(thoiGianBatDau) || string.IsNullOrEmpty(thoiGianKetThuc) || string.IsNullOrEmpty(loaiGiaTri) || string.IsNullOrEmpty(giaTriApDung))
                return "Vui lòng nhập đầy đủ thông tin!";

            DateTime dateTimeBatDau = DateTime.ParseExact(thoiGianBatDau, "dd/MM/yyyy HH:mm:ss", null);
            DateTime dateTimeKetThuc = DateTime.ParseExact(thoiGianKetThuc, "dd/MM/yyyy HH:mm:ss", null);

            if (dateTimeBatDau > dateTimeKetThuc)
                return "Thời gian bắt đầu phải trước thời gian kết thúc!";

            if (dateTimeBatDau < DateTime.Now)
                return "Thời gian bắt đầu không được trước thời điểm hiện tại!";

            if (!Decimal.TryParse(giaTriApDung, out decimal decimalGiaTriApDung))
                return "Giá trị áp dụng phải là kiểu decimal!";

            if (Decimal.Parse(giaTriApDung) <= 0)
                return "Giá trị áp dụng không được bé hơn 0!";

            KhuyenMai khuyenMai = new KhuyenMai();

            khuyenMai.maKhuyenMai = maKhuyenMai;
            khuyenMai.tenKhuyenMai = tenKhuyenMai.Trim();
            khuyenMai.thoiGianBatDau = dateTimeBatDau;
            khuyenMai.thoiGianKetThuc = dateTimeKetThuc;
            khuyenMai.loaiGiaTri = loaiGiaTri;
            khuyenMai.giaTriApDung = decimalGiaTriApDung;

            if (khuyenMaiDAO.SuaKhuyenMai(khuyenMai))
                return "Sửa thông tin khuyến mãi thành công!";
            else
                return "Sửa thông tin khuyến mãi thất bại!";
        }

        public List<KhuyenMai> TimKiemKhuyenMai(string keyword)
        {
            keyword = keyword.Trim().ToLower();

            return khuyenMaiDAO.TimKiemKhuyenMai(keyword);
        }

        public List<KhuyenMai> TimKiemKhuyenMaiTheoKhoangThoiGian(string thoiGianBatDau, string thoiGianKetThuc)
        {
            DateTime dateTimeBatDau;
            try { dateTimeBatDau = DateTime.ParseExact(thoiGianBatDau, "dd/MM/yyyy HH:mm:ss", null); } 
            catch {  dateTimeBatDau = DateTime.MinValue;}

            DateTime dateTimeKetThuc;
            try { dateTimeKetThuc = DateTime.ParseExact(thoiGianKetThuc, "dd/MM/yyyy HH:mm:ss", null); }
            catch { dateTimeKetThuc = DateTime.MinValue; }

            return khuyenMaiDAO.TimKiemKhuyenMaiTheoKhoangThoiGian(dateTimeBatDau, dateTimeKetThuc);
        }

        public decimal ApDungKhuyenMai(string maKhuyenMai, string donGia)
        {
            decimal decimalDonGia = Decimal.Parse(donGia);

            return khuyenMaiDAO.ApDungKhuyenMai(maKhuyenMai, decimalDonGia);
        }
    }
}
