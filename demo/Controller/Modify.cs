using demo.Model;
using demo.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Controller
{
    internal class Modify
    {
        public Modify()
        {

        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;//doc dữ liệu trong bảng
        SqlDataAdapter dataAdapter;//sẽ truy xuất toàn bộ dữ liệu và datatable
        public List<Taikhoan> Taikhoan(string query)
        {
            List<Taikhoan> taikhoan = new List<Taikhoan>();
            using (SqlConnection sqlConnection = DatabaseHelper.getConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taikhoan.Add(new Taikhoan(dataReader.GetString(1), dataReader.GetString(2)));
                }
                sqlConnection.Close();
            }
            return taikhoan;
        }

        internal static object taikhoan(string query)
        {
            throw new NotImplementedException();
        }
    }
}
