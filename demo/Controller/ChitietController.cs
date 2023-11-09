using demo.Model;
using demo.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.Controller
{
    internal class ChitietController
    {
        List<Chitiet> chitietList;

        public ChitietController()
        {
            chitietList = new List<Chitiet>();

        }
        public List<Chitiet> load()
        {

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                // Mở kết nối
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from chitietphieuthue", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"].ToString());
                    String idp = reader["idp"].ToString();
                    String idsp = reader["idsp"].ToString();
                    int soluong = Convert.ToInt32(reader["soluong"].ToString());
                    int hoadon = Convert.ToInt32(reader["hoadon"].ToString());
                    Chitiet chitiet = new Chitiet(id, idp, idsp, soluong, hoadon);
                    chitietList.Add(chitiet);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
            }
            return chitietList;
        }
        public Chitiet get(string id)
        {

            foreach (Chitiet chitiet in chitietList)
            {
                if (chitiet.getId().ToString() == id)
                {
                    return chitiet;
                }
            }
            return null;
        }

        public bool insert(Chitiet chitiet)
        {

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO chitietphieuthue( sophieu, masp , soluong, hoadon)  VALUES (@sophieu, @masp , @soluong, @hoadon)", conn);
                command.Parameters.AddWithValue("@sophieu", chitiet.getIdp());
                command.Parameters.AddWithValue("@masp", chitiet.getIdsp());
                command.Parameters.AddWithValue("@soluong", chitiet.getSongay());
                command.Parameters.AddWithValue("@hoadon", chitiet.getHoadon());
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
            }
            return false;
        }
        public bool update(Chitiet chitiet)
        {
            if (chitiet != null && !string.IsNullOrEmpty(chitiet.getId().ToString()) && !string.IsNullOrEmpty(chitiet.getIdp()) && !string.IsNullOrEmpty(chitiet.getIdsp()))
            {
                // Update the kho in the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update chitietphieuthue set sophieu = @sophieu, masp  = @masp , soluong = @soluong, hoadon = @hoadon where chitietphieuthue = @chitietphieuthue", conn);
                    cmd.Parameters.AddWithValue("@sophieu", chitiet.getIdp());
                    cmd.Parameters.AddWithValue("@masp", chitiet.getIdsp());
                    cmd.Parameters.AddWithValue("@soluong", chitiet.getSongay());
                    cmd.Parameters.AddWithValue("@hoadon", chitiet.getHoadon());
                    cmd.Parameters.AddWithValue("@chitietsophieu", chitiet.getId());
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    // Log the exception and handle it appropriately.
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    // Đóng kết nối
                    conn.Close();
                }
            }
            return false;
        }

        public bool delete(Chitiet chitiet)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from chitietphieuthue where chitietphieuthue = @chitietphieuthue", conn);
                command.Parameters.AddWithValue("@chitietphieuthue", chitiet.getId());
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
            }
            return false;
        }
        public bool delete(String id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                // Delete the kho from the list.
                chitietList.Remove(chitietList.FirstOrDefault(k => k.getId().ToString() == id));

                // Delete the kho from the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from chitietphieuthue where chitietphieuthue = @chitietphieuthue", conn);
                    cmd.Parameters.AddWithValue("@chitietphieuthue", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    // Log the exception and handle it appropriately.
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    // Đóng kết nối
                    conn.Close();
                }
            }
            return false;
        }
        public List<Chitiet> search(String keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return chitietList;
            }

            // Create a list to store the results.
            List<Chitiet> results = new List<Chitiet>();

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM chitietphieuthue where chitietphieuthue = @chitietphieuthue", conn);
                command.Parameters.AddWithValue("@chitietphieuthue", keyword);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["chitietphieuthue"].ToString());
                    String idp = reader["sophieu"].ToString();
                    String idsp = reader["masp"].ToString();
                    int soluong = Convert.ToInt32(reader["soluong"].ToString());
                    int dongia = Convert.ToInt32(reader["hoadon"].ToString());
                    Chitiet chitiet = new Chitiet(id, idp, idsp, soluong, dongia);
                    results.Add(chitiet);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
            }
            return results;
        }
        public bool isExist(string id)
        {
            // Create a connection to the database
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                // Open the connection
                conn.Open();

                // Create a command to check if the id exists in the QLKho table
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM chitietphieuthue WHERE chitietphieuthue = @chitietphieuthue", conn);
                // Add a parameter for the id
                command.Parameters.AddWithValue("@chitietphieuthue", id);
                // Execute the command and get the result
                int count = (int)command.ExecuteScalar();
                // If the count is greater than zero, the id exists
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }
        public bool isExist(Chitiet chitiet)
        {
            // Kiểm tra xem đối tượng Kho có hợp lệ hay không
            if (chitiet == null || string.IsNullOrEmpty(chitiet.getId().ToString()))
            {
                return false;
            }

            // Tạo một kết nối đến cơ sở dữ liệu
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                // Mở kết nối
                conn.Open();
                // Tạo một lệnh để kiểm tra xem mã kho của đối tượng Kho có tồn tại trong bảng QLKho hay không
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM ChiTietNhap WHERE ID = @ID", conn);
                // Thêm một tham số cho mã kho
                command.Parameters.AddWithValue("@ID", chitiet.getId().ToString());
                // Thực thi lệnh và lấy kết quả
                int count = (int)command.ExecuteScalar();
                // Nếu số lượng lớn hơn không, tức là mã kho tồn tại
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
            }
        }

    }
}

