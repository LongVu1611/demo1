using demo.Model;
using demo.Utils;
using demo.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.Controller
{
    internal class SanphamController
    {
        List<Sanpham> splist;
        public SanphamController()
        {
            splist = new List<Sanpham>();
        }
        public List<Sanpham> load()
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from sanpham", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String idsp = reader["masp"].ToString();
                    String namesp = reader["tensp"].ToString();
                    String soluong = reader["soluong"].ToString();
                    String xuatxu = reader["xuatxu"].ToString();
                    String tinhtrang = reader["tinhtrangsp"].ToString();
                    String giavon = reader["giavon"].ToString();
                    String giathue = reader["giathue1ngay"].ToString();


                    Sanpham sanpham = new Sanpham(idsp, namesp, soluong, xuatxu, tinhtrang, giavon, giathue);
                    splist.Add(sanpham);

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return splist;
        }
        public Sanpham get(string idsp)
        {
            foreach (Sanpham sanpham in splist)
            {
                if (sanpham.getIdsp().Trim().Equals(idsp.Trim()))
                {
                    return sanpham;
                }
            }
            return new Sanpham("", "", "", "", "", "", "");
        }
        public bool insert(Sanpham sanpham)
        {
            Sanpham newSanpham = new Sanpham();
            splist.Add(newSanpham);
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();
                string query = "INSERT INTO sanpham (masp,tensp,soluong,xuatxu, tinhtrangsp, giavon, giathue1ngay ) VALUES (@masp,@tensp,@soluong,@xuatxu, @tinhtrangsp, @giavon, @giathue1ngay)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@masp", sanpham.getIdsp());
                    command.Parameters.AddWithValue("@tensp", sanpham.getNamesp());
                    command.Parameters.AddWithValue("@soluong", sanpham.getSoluong());
                    command.Parameters.AddWithValue("@xuatxu", sanpham.getXuatxu());
                    command.Parameters.AddWithValue("@tinhtrangsp", sanpham.getTinhtrang());
                    command.Parameters.AddWithValue("@giavon", sanpham.getGiavon());
                    command.Parameters.AddWithValue("@giathue1ngay", sanpham.getGiathue());
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool update(Sanpham sanpham)
        {
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();
                string query = "UPDATE sanpham SET tensp = @tensp, soluong = @soluong , xuatxu = @xuatxu, tinhtrangsp = @tinhtrangsp, giavon = @giavon, giathue1ngay = @giathue1ngay  WHERE masp = @masp";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@masp", sanpham.getIdsp());
                    command.Parameters.AddWithValue("@tensp", sanpham.getNamesp());
                    command.Parameters.AddWithValue("@soluong", sanpham.getSoluong());
                    command.Parameters.AddWithValue("@xuatxu", sanpham.getXuatxu());
                    command.Parameters.AddWithValue("@tinhtrangsp", sanpham.getTinhtrang());
                    command.Parameters.AddWithValue("@giavon", sanpham.getGiavon());
                    command.Parameters.AddWithValue("@giathue1ngay", sanpham.getGiathue());
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool delete(String masp)
        {
            if (!string.IsNullOrEmpty(masp))
            {
                // Delete the HH from the list.
                splist.Remove(splist.FirstOrDefault(k => k.getIdsp() == masp));

                // Delete the HH from the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from sanpham where masp = @masp", conn);
                    cmd.Parameters.AddWithValue("@masp", masp);
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
        public bool delete(Sanpham sanpham)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from sanpham where masp = @masp", conn);
                command.Parameters.AddWithValue("@masp", sanpham.getIdsp());
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


