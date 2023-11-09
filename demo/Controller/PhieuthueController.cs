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
    internal class PhieuthueController
    {
        List<Phieuthue> phieuthuelist;
        public PhieuthueController()
        {
            phieuthuelist = new List<Phieuthue>();
        }
        public List<Phieuthue> load()
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                // Mở kết nối
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from thue", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader["sophieu"].ToString();
                    string idnv = reader["manhanvien"].ToString();
                    string idkh = reader["makh"].ToString();
                    DateTime datethue = Convert.ToDateTime(reader["ngaychothue"].ToString());
                    DateTime datetra = Convert.ToDateTime(reader["ngaytra"].ToString());
                    String tientra = reader["tientradutinh"].ToString();        
                    Phieuthue phieuthue = new Phieuthue(id, idnv, idkh, datethue, datetra, tientra);
                    phieuthuelist.Add(phieuthue);
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
            return phieuthuelist;
        }
        public Phieuthue get(string id)
        {

            foreach (Phieuthue phieuthue in phieuthuelist)
            {
                if (phieuthue.getId().ToString() == id)
                {
                    return phieuthue;
                }
            }
            return null;
        }
        public bool insert(Phieuthue phieuthue)
        {

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO thue( sophieu, manhanvien, makh, ngaychothue, ngaytra,tientradutinh)  VALUES ( @sophieu, @manhanvien, @makh, @ngaychothue, @ngaytra,@tientradutinh)", conn);
                command.Parameters.AddWithValue("@sophieu", phieuthue.getId());
                command.Parameters.AddWithValue("@manhanvien", phieuthue.getIdnv());
                command.Parameters.AddWithValue("@makh", phieuthue.getIdkh());
                command.Parameters.AddWithValue("@ngaychothue", phieuthue.getDatethue());
                command.Parameters.AddWithValue("@ngaytra", phieuthue.getDatetra());
                command.Parameters.AddWithValue("@tientradutinh", phieuthue.getTientra());
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
        public bool update(Phieuthue phieuthue)
        {
            if (phieuthue != null && !string.IsNullOrEmpty(phieuthue.getId().ToString()) && !string.IsNullOrEmpty(phieuthue.getIdnv().ToString()) && !string.IsNullOrEmpty(phieuthue.getIdkh().ToString()) && !string.IsNullOrEmpty(phieuthue.getDatethue().ToString()) && !string.IsNullOrEmpty(phieuthue.getDatetra().ToString()) && !string.IsNullOrEmpty(phieuthue.getTientra()) )
            {
                // Update the kho in the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update thue set  manhanvien = @manhanvien, makh = @makh ,ngaychothue = @ngaychothue ,ngaytra=@ngaytra, tientradutinh = @tientradutinh where sophieu = @sophieu ", conn);
                    cmd.Parameters.AddWithValue("@sophieu", phieuthue.getId());
                    cmd.Parameters.AddWithValue("@manhanvien", phieuthue.getIdnv());
                    cmd.Parameters.AddWithValue("@makh", phieuthue.getIdkh());
                    cmd.Parameters.AddWithValue("@ngaychothue", phieuthue.getDatethue());
                    cmd.Parameters.AddWithValue("@ngaytra", phieuthue.getDatetra());
                    cmd.Parameters.AddWithValue("@tientradutinh", phieuthue.getTientra());
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

        public bool delete(Phieuthue phieuthue)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from thue where sophieu = @sophieu", conn);
                command.Parameters.AddWithValue("@sophieu", phieuthue.getId());
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
                // Delete the kho tu list.
                phieuthuelist.Remove(phieuthuelist.FirstOrDefault(k => k.getId().ToString() == id));

                // Delete the kho tu database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from thue where sophieu = @sophieu", conn);
                    cmd.Parameters.AddWithValue("@sophieu", id);
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
    }
}
