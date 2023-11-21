using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuNhapDAO
    {
        public PhieuNhapDAO() { }

        public int DemSoPhieuNhapTheoNgay(DateTime ngay)
        {
            string query = $"SELECT COUNT(*) AS SoPhieuNhap FROM PhieuNhap WHERE CONVERT(DATE, thoiGianTao) = '{ngay.ToString("yyyy-MM-dd")}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoPhieuNhap"];

            return count;
        }

        public List<PhieuNhap> LayDanhSachPhieuNhapChuaDuyet()
        {
            List<PhieuNhap> listPhieuNhap = new List<PhieuNhap> ();

            string query = "SELECT * FROM PhieuNhap WHERE trangThaiDuyet = N'Chưa duyệt';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0 )
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    PhieuNhap phieuNhap = new PhieuNhap();

                    phieuNhap.maPhieuNhap = dataTable.Rows[0]["maPhieuNhap"].ToString();
                    phieuNhap.maNhaCungCap = dataTable.Rows[0]["maNhaCungCap"].ToString();
                    phieuNhap.maNhanVien = dataTable.Rows[0]["maNhanVien"].ToString();
                    phieuNhap.maQuanLi = dataTable.Rows[0]["maQuanLi"].ToString();
                    phieuNhap.thoiGianTao = (DateTime)dataTable.Rows[0]["thoiGianTao"];
                    try { phieuNhap.thoiGianDuyet = (DateTime)dataTable.Rows[0]["thoiGianDuyet"]; }
                    catch { phieuNhap.thoiGianDuyet = null; }
                    phieuNhap.thanhTien = Decimal.Parse(dataTable.Rows[0]["thanhTien"].ToString());
                    phieuNhap.trangThaiDuyet = dataTable.Rows[0]["trangThaiDuyet"].ToString();

                    listPhieuNhap.Add(phieuNhap);
                }
            }
            
            return listPhieuNhap;
        }

        public List<PhieuNhap> LayDanhSachPhieuNhap()
        {
            List<PhieuNhap> listPhieuNhap = new List<PhieuNhap>();

            string query = "SELECT * FROM PhieuNhap;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    PhieuNhap phieuNhap = new PhieuNhap();

                    phieuNhap.maPhieuNhap = row["maPhieuNhap"].ToString();
                    phieuNhap.maNhaCungCap = row["maNhaCungCap"].ToString();
                    phieuNhap.maNhanVien =row["maNhanVien"].ToString();
                    phieuNhap.maQuanLi = row["maQuanLi"].ToString();
                    phieuNhap.thoiGianTao = (DateTime)row["thoiGianTao"];
                    try { phieuNhap.thoiGianDuyet = (DateTime)row["thoiGianDuyet"]; }
                    catch { phieuNhap.thoiGianDuyet = null; }
                    phieuNhap.thanhTien = Decimal.Parse(row["thanhTien"].ToString());
                    phieuNhap.trangThaiDuyet = row["trangThaiDuyet"].ToString();

                    listPhieuNhap.Add(phieuNhap);
                }
            }

            return listPhieuNhap;
        }

        public List<PhieuNhap> LayDanhSachPhieuNhapDaDuyet()
        {
            List<PhieuNhap> listPhieuNhap = new List<PhieuNhap>();

            string query = "SELECT * FROM PhieuNhap WHERE trangThaiDuyet = N'Đã duyệt';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    PhieuNhap phieuNhap = new PhieuNhap();

                    phieuNhap.maPhieuNhap = dataTable.Rows[0]["maPhieuNhap"].ToString();
                    phieuNhap.maNhaCungCap = dataTable.Rows[0]["maNhaCungCap"].ToString();
                    phieuNhap.maNhanVien = dataTable.Rows[0]["maNhanVien"].ToString();
                    phieuNhap.maQuanLi = dataTable.Rows[0]["maQuanLi"].ToString();
                    phieuNhap.thoiGianTao = (DateTime)dataTable.Rows[0]["thoiGianTao"];
                    try { phieuNhap.thoiGianDuyet = (DateTime)dataTable.Rows[0]["thoiGianDuyet"]; }
                    catch { phieuNhap.thoiGianDuyet = null; }
                    phieuNhap.thanhTien = Decimal.Parse(dataTable.Rows[0]["thanhTien"].ToString());
                    phieuNhap.trangThaiDuyet = dataTable.Rows[0]["trangThaiDuyet"].ToString();

                    listPhieuNhap.Add(phieuNhap);
                }
            }

            return listPhieuNhap;
        }

        public List<PhieuNhap> LayDanhSachPhieuNhapDaTuChoi()
        {
            List<PhieuNhap> listPhieuNhap = new List<PhieuNhap>();

            string query = "SELECT * FROM PhieuNhap WHERE trangThaiDuyet = N'Từ chối';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    PhieuNhap phieuNhap = new PhieuNhap();

                    phieuNhap.maPhieuNhap = dataTable.Rows[0]["maPhieuNhap"].ToString();
                    phieuNhap.maNhaCungCap = dataTable.Rows[0]["maNhaCungCap"].ToString();
                    phieuNhap.maNhanVien = dataTable.Rows[0]["maNhanVien"].ToString();
                    phieuNhap.maQuanLi = dataTable.Rows[0]["maQuanLi"].ToString();
                    phieuNhap.thoiGianTao = (DateTime)dataTable.Rows[0]["thoiGianTao"];
                    try { phieuNhap.thoiGianDuyet = (DateTime)dataTable.Rows[0]["thoiGianDuyet"]; }
                    catch { phieuNhap.thoiGianDuyet = null; }
                    phieuNhap.thanhTien = Decimal.Parse(dataTable.Rows[0]["thanhTien"].ToString());
                    phieuNhap.trangThaiDuyet = dataTable.Rows[0]["trangThaiDuyet"].ToString();

                    listPhieuNhap.Add(phieuNhap);
                }
            }

            return listPhieuNhap;
        }

        public PhieuNhap LayPhieuNhapTheoMa(string maPhieuNhap)
        {
            PhieuNhap phieuNhap = new PhieuNhap();

            string query = $"SELECT * FROM PhieuNhap WHERE maPhieuNhap = '{maPhieuNhap}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0 )
            {
                phieuNhap.maPhieuNhap = dataTable.Rows[0]["maPhieuNhap"].ToString();
                phieuNhap.maNhaCungCap = dataTable.Rows[0]["maNhaCungCap"].ToString();
                phieuNhap.maNhanVien = dataTable.Rows[0]["maNhanVien"].ToString();
                phieuNhap.maQuanLi = dataTable.Rows[0]["maQuanLi"].ToString();
                phieuNhap.thoiGianTao = (DateTime)dataTable.Rows[0]["thoiGianTao"];
                try { phieuNhap.thoiGianDuyet = (DateTime)dataTable.Rows[0]["thoiGianDuyet"]; }
                catch { phieuNhap.thoiGianDuyet = null; }
                phieuNhap.thanhTien = Decimal.Parse(dataTable.Rows[0]["thanhTien"].ToString());
                phieuNhap.trangThaiDuyet = dataTable.Rows[0]["trangThaiDuyet"].ToString();
            }

            return phieuNhap;
        }

        public bool ThemPhieuNhap(PhieuNhap phieuNhap, List<ChiTietPhieuNhap> listChiTietPhieuNhap)
        {
            int rowsAffected = 0;

            string phieuNhapQuery = $"INSERT INTO PhieuNhap VALUES('{phieuNhap.maPhieuNhap}', '{phieuNhap.maNhaCungCap}', '{phieuNhap.maNhanVien}', NULL, '{phieuNhap.thoiGianTao}', NULL, {phieuNhap.thanhTien}, N'Chưa duyệt');";
                                 
            rowsAffected += DBHelper.ExecuteNonQuery(phieuNhapQuery);

            foreach (ChiTietPhieuNhap chiTietPhieuNhap in listChiTietPhieuNhap)
            {
                string chiTietPhieuNhapQuery = $"INSERT INTO ChiTietPhieuNhap (maPhieuNhap, maSanPham, soLuong, donViTinh, donGia, thanhTien) " +
                                               $"SELECT '{phieuNhap.maPhieuNhap}' AS maPhieuNhap, maSanPham, {chiTietPhieuNhap.soLuong} AS soLuong, donViTinh, {chiTietPhieuNhap.donGia} AS donGia, {chiTietPhieuNhap.donGia} * {chiTietPhieuNhap.soLuong} AS thanhTien " +
                                               $"FROM SanPham WHERE maSanPham = '{chiTietPhieuNhap.maSanPham}';";

                rowsAffected += DBHelper.ExecuteNonQuery(chiTietPhieuNhapQuery);
            }

            return rowsAffected == listChiTietPhieuNhap.Count + 1;
        }

        public bool SuaPhieuNhapChuaDuyet(List<ChiTietPhieuNhap> listChiTietPhieuNhap)
        {
            string query;
            int rowsAffected = 0;
            decimal thanhTien = 0;

            foreach(ChiTietPhieuNhap chiTietPhieuNhap in listChiTietPhieuNhap)
            {
                query = $"UPDATE ChiTietPhieuNhap SET soLuong = {chiTietPhieuNhap.soLuong}, donGia = {chiTietPhieuNhap.donGia}, thanhTien = {chiTietPhieuNhap.thanhTien} WHERE maPhieuNhap = '{chiTietPhieuNhap.maPhieuNhap}' AND maSanPham = '{chiTietPhieuNhap.maSanPham}';";

                rowsAffected += DBHelper.ExecuteNonQuery(query);

                thanhTien += chiTietPhieuNhap.thanhTien;
            }

            query = $"UPDATE PhieuNhap SET thanhTien = {thanhTien} WHERE maPhieuNhap = '{listChiTietPhieuNhap[0].maPhieuNhap}';";

            rowsAffected += DBHelper.ExecuteNonQuery(query);

            return rowsAffected == listChiTietPhieuNhap.Count + 1;
        }

        public bool DuyetPhieuNhap(string maPhieuNhap, string maQuanLi, DateTime thoiGianDuyet)
        {
            string query = $"UPDATE PhieuNhap SET maQuanLi = '{maQuanLi}', thoiGianDuyet = '{thoiGianDuyet}',trangThaiDuyet = N'Đã duyệt' WHERE maPhieuNhap = '{maPhieuNhap}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool TuChoiDuyetPhieuNhap(string maPhieuNhap)
        {
            string query = $"UPDATE PhieuNhap SET trangThaiDuyet = N'Từ chối' WHERE maPhieuNhap = '{maPhieuNhap}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public List<PhieuNhap> TimKiemPhieuNhap(string tuKhoa, string trangThaiDuyet)
        {
            List<PhieuNhap> listPhieuNhap = new List<PhieuNhap> ();

            string query = $"SELECT * FROM PhieuNhap " +
                           $"WHERE LOWER(maPhieuNhap) LIKE '%{tuKhoa}%' " +
                           $"OR LOWER(maNhaCungCap) LIKE '%{tuKhoa}%' " +
                           $"OR LOWER(maNhanVien) LIKE '%{tuKhoa}%' " +
                           $"OR LOWER(maQuanLi) LIKE '%{tuKhoa}%' " +
                           $"OR thanhTien = {tuKhoa} " +
                           $"WHERE trangThaiDuyet = N'{trangThaiDuyet}';";

            DataTable dataTable = new DataTable();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    PhieuNhap phieuNhap = new PhieuNhap();

                    phieuNhap.maPhieuNhap = dataTable.Rows[0]["maPhieuNhap"].ToString();
                    phieuNhap.maNhaCungCap = dataTable.Rows[0]["maNhaCungCap"].ToString();
                    phieuNhap.maNhanVien = dataTable.Rows[0]["maNhanVien"].ToString();
                    phieuNhap.maQuanLi = dataTable.Rows[0]["maQuanLi"].ToString();
                    phieuNhap.thoiGianTao = (DateTime)dataTable.Rows[0]["thoiGianTao"];
                    try { phieuNhap.thoiGianDuyet = (DateTime)dataTable.Rows[0]["thoiGianDuyet"]; }
                    catch { phieuNhap.thoiGianDuyet = null; }
                    phieuNhap.thanhTien = Decimal.Parse(dataTable.Rows[0]["thanhTien"].ToString());
                    phieuNhap.trangThaiDuyet = dataTable.Rows[0]["trangThaiDuyet"].ToString();

                    listPhieuNhap.Add(phieuNhap);
                }
            }

            return listPhieuNhap;
        }
    }
}
