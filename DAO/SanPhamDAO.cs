using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO
    {
        public SanPhamDAO() { }

        public List<SanPham> LayDanhSachSanPham()
        {
            List<SanPham> listSanPham = new List<SanPham>();

            string query = "SELECT * FROM SanPham WHERE trangThai = 1;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                SanPham sanPham = new SanPham();
                sanPham.maSanPham = row["maSanPham"].ToString();
                sanPham.maLoaiSanPham = row["maLoaiSanPham"].ToString();
                sanPham.maNhaCungCap = row["maNhaCungCap"].ToString();
                sanPham.tenSanPham = row["tenSanPham"].ToString();
                sanPham.donViTinh = row["donViTinh"].ToString();
                sanPham.soLuong = (int)row["soLuong"];
                sanPham.giaBan = (decimal)row["giaBan"];
                sanPham.duongDanAnh = row["duongDanAnh"].ToString();
                sanPham.trangThai = (bool)row["trangThai"];

                listSanPham.Add(sanPham);
            }

            return listSanPham;
        }

        public SanPham LaySanPhamTheoMa(string maSanPham)
        {
            SanPham sanPham = new SanPham();

            string query = $"SELECT * FROM SanPham WHERE maSanPham = '{maSanPham}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            sanPham.maSanPham = dataTable.Rows[0]["maSanPham"].ToString();
            sanPham.maLoaiSanPham = dataTable.Rows[0]["maLoaiSanPham"].ToString();
            sanPham.maNhaCungCap = dataTable.Rows[0]["maNhaCungCap"].ToString();
            sanPham.tenSanPham = dataTable.Rows[0]["tenSanPham"].ToString();
            sanPham.donViTinh = dataTable.Rows[0]["donViTinh"].ToString();
            sanPham.soLuong = (int)dataTable.Rows[0]["soLuong"];
            sanPham.giaBan = (decimal)dataTable.Rows[0]["giaBan"];
            sanPham.duongDanAnh = dataTable.Rows[0]["duongDanAnh"].ToString();
            sanPham.trangThai = (bool)dataTable.Rows[0]["trangThai"];
            
            return sanPham;
        }

        public int DemSoSanPham()
        {
            string query = "SELECT COUNT(*) AS SoSanPham FROM SanPham;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoSanPham"];

            return count;
        }

        public bool ThemSanPham(SanPham sanPham)
        {
            string query = $"INSERT INTO SanPham VALUES('{sanPham.maSanPham}', '{sanPham.maLoaiSanPham}', '{sanPham.maNhaCungCap}', N'{sanPham.tenSanPham}', N'{sanPham.donViTinh}', '{sanPham.soLuong}', '{sanPham.giaBan}', '{sanPham.duongDanAnh}', 1);";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool XoaSanPham(string maSanPham)
        {
            string query = $"UPDATE SanPham SET trangThai = 0, soLuong = 0 WHERE maSanPham = '{maSanPham}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool SuaSanPham(SanPham sanPham)
        {
            string query = $"UPDATE SanPham SET maLoaiSanPham = '{sanPham.maLoaiSanPham}', maNhaCungCap = '{sanPham.maNhaCungCap}', tenSanPham = N'{sanPham.tenSanPham}', donViTinh = N'{sanPham.donViTinh}', giaBan = {sanPham.giaBan}, duongDanAnh = '{sanPham.duongDanAnh}' " +
                           $"WHERE maSanPham = '{sanPham.maSanPham}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public List<SanPham> TimKiemSanPham(string keyword)
        {
            List<SanPham> listSanPham = new List<SanPham>();

            string query = $"SELECT SP.* FROM SanPham " +
                           $"JOIN LoaiSanPham AS LSP ON SP.maLoaiSanPham = LSP.maLoaiSanPham " +
                           $"JOIN NhaCungCap AS NCC ON SP.maNhaCungCap = LSP.maNhaCungCap " +
                           $"WHERE LOWER(LSP.tenLoaiSanPham) LIKE N'%{keyword}%' " +
                           $"OR LOWER(NCC.tenNhaCungCap) LIKE N'%{keyword}%' " +
                           $"OR LOWER(SP.tenSanPham) LIKE N'%{keyword}%';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                SanPham sanPham = new SanPham();
                sanPham.maSanPham = row["maSanPham"].ToString();
                sanPham.maLoaiSanPham = row["maLoaiSanPham"].ToString();
                sanPham.maNhaCungCap = row["maNhaCungCap"].ToString();
                sanPham.tenSanPham = row["tenSanPham"].ToString();
                sanPham.donViTinh = row["donViTinh"].ToString();
                sanPham.soLuong = (int)row["soLuong"];
                sanPham.giaBan = (decimal)row["giaBan"];
                sanPham.duongDanAnh = row["duongDanAnh"].ToString();
                sanPham.trangThai = (bool)row["trangThai"];

                listSanPham.Add(sanPham);
            }

            return listSanPham;
        }

        public List<SanPham> LocSanPhamTheoLoaiSanPham(string tenLoaiSanPham)
        {
            List<SanPham> listSanPham = new List<SanPham>();

            string query = $"SELECT * FROM SanPham AS SP " +
                           $"JOIN LoaiSanPham AS LSP ON SP.maLoaiSanPham = LSP.maLoaiSanPham " +
                           $"WHERE LSP.tenLoaiSanPham = '{tenLoaiSanPham}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                SanPham sanPham = new SanPham();
                sanPham.maSanPham = row["maSanPham"].ToString();
                sanPham.maLoaiSanPham = row["maLoaiSanPham"].ToString();
                sanPham.maNhaCungCap = row["maNhaCungCap"].ToString();
                sanPham.tenSanPham = row["tenSanPham"].ToString();
                sanPham.donViTinh = row["donViTinh"].ToString();
                sanPham.soLuong = (int)row["soLuong"];
                sanPham.giaBan = (decimal)row["giaBan"];
                sanPham.duongDanAnh = row["duongDanAnh"].ToString();
                sanPham.trangThai = (bool)row["trangThai"];

                listSanPham.Add(sanPham);
            }

            return listSanPham;
        }
    }
}
