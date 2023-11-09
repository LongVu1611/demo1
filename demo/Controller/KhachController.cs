using demo.Model;
using demo.Controller;
using demo.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Policy;
using System.Xml.Linq;

namespace demo.Controller
{
    internal class KhachController
    {
        
        List<Khach> khachlist;
        public KhachController() 
        { 
            khachlist = new List<Khach>(); 
        }
        public List<Khach> load()
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from khachhang", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String idkh = reader["makh"].ToString();
                    String namekh = reader["tenkh"].ToString();
                    String address = reader["diachi"].ToString();
                    String phone = reader["sodienthoai"].ToString();

                    Khach khach = new Khach(idkh, namekh, address, phone);
                    khachlist.Add(khach);

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return khachlist;
        }
        public bool insert(Khach khach)
        {
            Khach newkhach = new Khach();
            khachlist.Add(newkhach);
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();
                string query = "INSERT INTO khachhang (makh,tenkh,diachi,sodienthoai) VALUES (@makh, @tenkh, @diachi, @sodienthoai)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@makh", khach.getIdkh());
                    command.Parameters.AddWithValue("@tenkh", khach.getNamekh());
                    command.Parameters.AddWithValue("@diachi", khach.getAddress());
                    command.Parameters.AddWithValue("@sodienthoai", khach.getPhone());
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool update(Khach khach)
        {
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();
                string query = "UPDATE khachhang SET tenkh = @tenkh, diachi = @diachi , sodienthoai = @sodienthoai WHERE makh = @makh";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@makh", khach.getIdkh());
                    command.Parameters.AddWithValue("@tenkh", khach.getNamekh());
                    command.Parameters.AddWithValue("@diachi", khach.getAddress());
                    command.Parameters.AddWithValue("@sodienthoai", khach.getPhone());
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool delete(String makh)
        {
            if (!string.IsNullOrEmpty(makh))
            {
                // Delete the HH from the list.
                khachlist.Remove(khachlist.FirstOrDefault(k => k.getIdkh() == makh));

                // Delete the HH from the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from khachhang where makh = @makh", conn);
                    cmd.Parameters.AddWithValue("@makh", makh);
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
        public bool delete(Khach khach)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from khachhang where makh = @makh", conn);
                command.Parameters.AddWithValue("@makh", khach.getIdkh());
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
    }
}
