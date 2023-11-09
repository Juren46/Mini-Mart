using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiSanPhamDAO
    {
        public LoaiSanPhamDAO() { }

        public List<LoaiSanPham> LayDanhSachLoaiSanPham()
        {
            List<LoaiSanPham> listLoaiSanPham = new List<LoaiSanPham>();

            string query = "SELECT * FROM LoaiSanPham WHERE trangThai = 1;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                LoaiSanPham loaiSanPham = new LoaiSanPham();
                loaiSanPham.maLoaiSanPham = row["maLoaiSanPham"].ToString();
                loaiSanPham.tenLoaiSanPham = row["tenLoaiSanPham"].ToString();

                listLoaiSanPham.Add(loaiSanPham);
            }

            return listLoaiSanPham;
        }

        public LoaiSanPham LayLoaiSanPhamTheoTen(string tenLoaiSanPham)
        {
            LoaiSanPham loaiSanPham = new LoaiSanPham();

            string query = $"SELECT * FROM LoaiSanPham WHERE trangThai = 1 AND tenLoaiSanPham = '{tenLoaiSanPham}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            loaiSanPham.maLoaiSanPham = dataTable.Rows[0]["maLoaiSanPham"].ToString();
            loaiSanPham.tenLoaiSanPham = dataTable.Rows[0]["tenLoaiSanPham"].ToString();

            return loaiSanPham;
        }

        public int DemSoLoaiSanPham()
        {
            string query = "SELECT COUNT(*) AS SoLoaiSanPham FROM LoaiSanPham;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoLoaiSanPham"];

            return count;
        }

        public List<LoaiSanPham> TimKiemTheoTen(string tenLoaiSanPham)
        {
            List<LoaiSanPham> listLoaiSanPham = new List<LoaiSanPham>();

            string query = $"SELECT * FROM LoaiSanPham WHERE LOWER(tenLoaiSanPham) LIKE '%{tenLoaiSanPham}%' AND trangThai = 1;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                LoaiSanPham LoaiSanPham = new LoaiSanPham();

                LoaiSanPham.maLoaiSanPham = row["maLoaiSanPham"].ToString();
                LoaiSanPham.tenLoaiSanPham = row["tenLoaiSanPham"].ToString();

                listLoaiSanPham.Add(LoaiSanPham);
            }

            return listLoaiSanPham;
        }

        public bool ThemLoaiSanPham(LoaiSanPham loaiSanPham)
        {
            string query = $"INSERT INTO LoaiSanPham VALUES ('{loaiSanPham.maLoaiSanPham}', '{loaiSanPham.tenLoaiSanPham}', 1);";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool KiemTraDaTonTai(string tenLoaiSanPham)
        {
            string query = $"SELECT tenLoaiSanPham FROM LoaiSanPham WHERE LOWER(tenLoaiSanPham) = '{tenLoaiSanPham}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            return dataTable.Rows.Count > 0;
        }

        public bool XoaLoaiSanPham(string maLoaiSanPham)
        {
            string query = $"UPDATE LoaiSanPham SET trangThai = 0 WHERE maLoaiSanPham = '{maLoaiSanPham}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool ChinhSuaLoaiSanPham(LoaiSanPham loaiSanPham)
        {
            string query = $"UPDATE LoaiSanPham SET tenLoaiSanPham = '{loaiSanPham.tenLoaiSanPham}' WHERE maLoaiSanPham = '{loaiSanPham.maLoaiSanPham}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }
    }
}
