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

            string query = "SELECT * FROM SanPham WHERE trangThai = N'Đang bán';";

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
                    sanPham.trangThai = row["trangThai"].ToString();

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
            sanPham.trangThai = dataTable.Rows[0]["trangThai"].ToString();
            
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
            string query = $"UPDATE SanPham SET trangThai = N'Ngừng kinh doanh', soLuong = 0 WHERE maSanPham = '{maSanPham}';";

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

        public List<SanPham> TimKiemSanPham(string tuKhoa, string maLoaiSanPham, string maNhaCungCap, string trangThai, string sapXep)
        {
            List<SanPham> listSanPham = new List<SanPham>();

            switch(sapXep)
            {
                case "Giá tăng dần":
                    sapXep = "giaBan ASC;";
                    break;
                case "Giá giảm dần":
                    sapXep = "giaBan DESC;";
                    break;
                case "Số lượng tăng dần":
                    sapXep = "soLuong ASC;";
                    break;
                case "Số lượng giảm dần":
                    sapXep = "soLuong DESC;";
                    break;
            }

            string query = $"SELECT * FROM SanPham " +
                           $"WHERE ('{tuKhoa}' = '' OR LOWER(maSanPham) LIKE '%{tuKhoa}%' OR tenSanPham COLLATE Latin1_General_CI_AI LIKE '%{tuKhoa}%') " +
                           $"AND ('{maLoaiSanPham}' = '' OR maLoaiSanPham = '{maLoaiSanPham}') " +
                           $"AND ('{maNhaCungCap}' = '' OR maNhaCungCap = '{maNhaCungCap}') " +
                           $"AND ('{trangThai}' = '' OR trangThai = N'{trangThai}') ";
            if (!string.IsNullOrEmpty(sapXep))
                query += "ORDER BY " + sapXep;

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
                    sanPham.trangThai = row["trangThai"].ToString();

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
