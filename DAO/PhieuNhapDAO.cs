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

        public PhieuNhap LayPhieuNhapTheoMa(string maPhieuNhap)
        {
            PhieuNhap phieuNhap = new PhieuNhap();

            string query = $"SELECT * FROM PhieuNhap WHERE maPhieuNhap = '{maPhieuNhap}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            phieuNhap.maPhieuNhap = dataTable.Rows[0]["maPhieuNhap"].ToString();
            phieuNhap.maNhaCungCap = dataTable.Rows[0]["maNhaCungCap"].ToString();
            phieuNhap.maNhanVien = dataTable.Rows[0]["maNhanVien"].ToString();
            phieuNhap.maQuanLi = dataTable.Rows[0]["maQuanLi"].ToString();
            phieuNhap.thoiGianTao = (DateTime)dataTable.Rows[0]["thoiGianTao"];
            try { phieuNhap.thoiGianDuyet = (DateTime)dataTable.Rows[0]["thoiGianDuyet"]; }
            catch { phieuNhap.thoiGianDuyet = null; }
            phieuNhap.thanhTien = Decimal.Parse(dataTable.Rows[0]["thanhTien"].ToString());
            phieuNhap.trangThaiDuyet = (bool)dataTable.Rows[0]["trangThaiDuyet"];
            phieuNhap.trangThai = (bool)dataTable.Rows[0]["trangThai"];

            return phieuNhap;
        }

        public bool ThemPhieuNhap(PhieuNhap phieuNhap, List<ChiTietPhieuNhap> listChiTietPhieuNhap)
        {
            int rowsAffected = 0;

            string phieuNhapQuery = $"INSERT INTO PhieuNhap VALUES('{phieuNhap.maPhieuNhap}', '{phieuNhap.maNhaCungCap}', '{phieuNhap.maNhanVien}', NULL, '{phieuNhap.thoiGianTao}', NULL, {phieuNhap.thanhTien}, 0, 1);";
                                 
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
        
        /*public bool SuaPhieuNhapChuaDuyet(PhieuNhap phieuNhap, List<ChiTietPhieuNhap> listChiTietPhieuNhap)
        {

        }*/

        public bool DuyetPhieuNhap(string maPhieuNhap)
        {
            return true;
        }
    }
}
