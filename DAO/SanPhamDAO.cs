using DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

            string query = "SELECT * FROM SanPham;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

           if (dataTable.Rows.Count > 0 )
            {
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
                    sanPham.duLieuAnh = (byte[])row["duLieuAnh"];
                    sanPham.trangThai = (bool)row["trangThai"];

                    listSanPham.Add(sanPham);
                }
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
            sanPham.duLieuAnh = (byte[])dataTable.Rows[0]["duLieuAnh"];
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
            string query = $"INSERT INTO SanPham (maSanPham, maLoaiSanPham, maNhaCungCap, tenSanPham, donViTinh, soLuong, giaBan, duLieuAnh, trangThai) " +
                $"VALUES (@maSanPham, @maLoaiSanPham, @maNhaCungCap, @tenSanPham, @donViTinh, @soLuong, @giaBan, @duLieuAnh, @trangThai)";

            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(DBHelper.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@maSanPham", sanPham.maSanPham);
                command.Parameters.AddWithValue("@maLoaiSanPham", sanPham.maLoaiSanPham);
                command.Parameters.AddWithValue("@maNhaCungCap", sanPham.maNhaCungCap);
                command.Parameters.AddWithValue("@tenSanPham", sanPham.tenSanPham);
                command.Parameters.AddWithValue("@donViTinh", sanPham.donViTinh);
                command.Parameters.AddWithValue("@soLuong", sanPham.soLuong);
                command.Parameters.AddWithValue("@giaBan", sanPham.giaBan);
                command.Parameters.AddWithValue("@duLieuAnh", sanPham.duLieuAnh);
                command.Parameters.AddWithValue("@trangThai", sanPham.trangThai);

                try
                {
                    connection.Open();
                    
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }

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
            string query = $"UPDATE SanPham SET maLoaiSanPham = @maLoaiSanPham, maNhaCungCap = @maNhaCungCap, tenSanPham = @tenSanPham, donViTinh = @donViTinh, giaBan = @giaBan, duLieuAnh = @duLieuAnh " +
                           $"WHERE maSanPham = @maSanPham;";

            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(DBHelper.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@maSanPham", sanPham.maSanPham);
                command.Parameters.AddWithValue("@maLoaiSanPham", sanPham.maLoaiSanPham);
                command.Parameters.AddWithValue("@maNhaCungCap", sanPham.maNhaCungCap);
                command.Parameters.AddWithValue("@tenSanPham", sanPham.tenSanPham);
                command.Parameters.AddWithValue("@donViTinh", sanPham.donViTinh);             
                command.Parameters.AddWithValue("@giaBan", sanPham.giaBan);
                command.Parameters.AddWithValue("@duLieuAnh", sanPham.duLieuAnh);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return rowsAffected > 0;
        }

        public List<SanPham> TimKiemSanPham(string keyword)
        {
            List<SanPham> listSanPham = new List<SanPham>();

            string query = $"SELECT SP.* FROM SanPham AS SP " +
                           $"JOIN LoaiSanPham AS LSP ON SP.maLoaiSanPham = LSP.maLoaiSanPham " +
                           $"JOIN NhaCungCap AS NCC ON SP.maNhaCungCap = NCC.maNhaCungCap " +
                           $"WHERE LOWER(LSP.tenLoaiSanPham) LIKE N'%{keyword}%' " +
                           $"OR LOWER(NCC.tenNhaCungCap) LIKE N'%{keyword}%' " +
                           $"OR LOWER(SP.tenSanPham) LIKE N'%{keyword}%';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
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
                    sanPham.duLieuAnh = (byte[])row["duLieuAnh"];
                    sanPham.trangThai = (bool)row["trangThai"];

                    listSanPham.Add(sanPham);
                }
            }

            return listSanPham;
        }

        public List<SanPham> LocSanPhamTheoLoaiSanPham(string tenLoaiSanPham)
        {
            List<SanPham> listSanPham = new List<SanPham>();

            string query = $"SELECT * FROM SanPham AS SP " +
                           $"JOIN LoaiSanPham AS LSP ON SP.maLoaiSanPham = LSP.maLoaiSanPham " +
                           $"WHERE LSP.tenLoaiSanPham = N'{tenLoaiSanPham}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
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
                    sanPham.duLieuAnh = (byte[])row["duLieuAnh"];
                    sanPham.trangThai = (bool)row["trangThai"];

                    listSanPham.Add(sanPham);
                }
            }

            return listSanPham;
        }

        public List<SanPham> LocSanPhamTheoNhaCungCap(string maNhaCungCap)
        {
            List<SanPham> listSanPham = new List<SanPham>();

            string query = $"SELECT * FROM SanPham AS SP " +
                           $"JOIN NhaCungCap AS NCC ON SP.maNhaCungCap = NCC.maNhaCungCap " +
                           $"WHERE NCC.maNhaCungCap = '{maNhaCungCap}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
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
                    sanPham.duLieuAnh = (byte[])row["duLieuAnh"];
                    sanPham.trangThai = (bool)row["trangThai"];

                    listSanPham.Add(sanPham);
                }
            }

            return listSanPham;
        }

        public bool CapNhatSoLuong(string maSanPham, int soLuong)
        {
            string query = $"UPDATE SanPham SET soLuong = soLuong + {soLuong} WHERE maSanPham = '{maSanPham}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }
    }
}
