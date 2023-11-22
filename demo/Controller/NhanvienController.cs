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
    internal class NhanvienController
    {
        List<Nhanvien> nhanvienlist;
        public NhanvienController() { 
            nhanvienlist = new List<Nhanvien>();
        }
        public List<Nhanvien> load()
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from nhanvien", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String idnv = reader["manhanvien"].ToString();
                    String tennv = reader["tennhanvien"].ToString();
                    DateTime ngaysinh = Convert.ToDateTime(reader["ngaysinh"].ToString());
                    String email = reader["email"].ToString();
                    String sdt = reader["sodienthoainv"].ToString();
                    String diachi = reader["diachi"].ToString();
                    int sodon = Convert.ToInt32(reader["sodonhang"].ToString());

                    Nhanvien nhanvien = new Nhanvien(idnv, tennv, ngaysinh, email, sdt, diachi, sodon);
                    nhanvienlist.Add(nhanvien);

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return nhanvienlist;
        }
        public bool insert(Nhanvien nhanvien)
        {
            Nhanvien newNhanvien = new Nhanvien();
            nhanvienlist.Add(newNhanvien);
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();
                string query = "INSERT INTO nhanvien (manhanvien,tennhanvien,ngaysinh,email, sodienthoainv, diachi, sodonhang ) VALUES (@manhanvien,@tennhanvien,@ngaysinh,@email, @sodienthoainv, @diachi, @sodonhang)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@manhanvien", nhanvien.getIdnv());
                    command.Parameters.AddWithValue("@tennhanvien", nhanvien.getTennv());
                    command.Parameters.AddWithValue("@ngaysinh", nhanvien.getNgaysinh());
                    command.Parameters.AddWithValue("@email", nhanvien.getEmail());
                    command.Parameters.AddWithValue("@sodienthoainv", nhanvien.getSdt());
                    command.Parameters.AddWithValue("@diachi", nhanvien.getDiachi());
                    command.Parameters.AddWithValue("@sodonhang", nhanvien.getSodon());
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
