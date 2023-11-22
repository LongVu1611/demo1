using demo.Controller;
using demo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.View.ChildForm
{
    public partial class frmNhanvien : Form
    {
        NhanvienController nhanvienController;
        List<Nhanvien> ds_nv;
        Nhanvien currentnhanvien;
        public frmNhanvien()
        {
            InitializeComponent();
            nhanvienController = new NhanvienController();
            ds_nv = new List<Nhanvien>();
            currentnhanvien = new Nhanvien();

            data_nv.ColumnCount = 7;
            data_nv.Columns[0].Name = "Mã nhân viên";
            data_nv.Columns[1].Name = "Tên nhân viên";
            data_nv.Columns[2].Name = "Ngày sinh";
            data_nv.Columns[3].Name = "Email";
            data_nv.Columns[4].Name = "Số diện thoại";
            data_nv.Columns[5].Name = "Địa chỉ";
            data_nv.Columns[6].Name = "Số đơn hàng ";

        }


        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            ds_nv.Clear();
            ds_nv = nhanvienController.load();
            data_nv.Rows.Clear();

            //hien thi len datagridview
            foreach (Nhanvien nhanvien in ds_nv)
            {
                string[] row = { nhanvien.getIdnv(), nhanvien.getTennv(), nhanvien.getNgaysinh().ToShortDateString(), nhanvien.getEmail().ToString(), nhanvien.getSdt().ToString(), nhanvien.getDiachi(), nhanvien.getSodon().ToString() };
                data_nv.Rows.Add(row);

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_manv.Text) && !string.IsNullOrWhiteSpace(txt_tennv.Text) && !string.IsNullOrWhiteSpace(data_nv.Text) && !string.IsNullOrWhiteSpace(txt_email.Text) && !string.IsNullOrWhiteSpace(txt_sdt.Text) && !string.IsNullOrWhiteSpace(txt_diachi.Text) && !string.IsNullOrWhiteSpace(txt_sodon.Text))
            {
                currentnhanvien = new Nhanvien(txt_manv.Text, txt_tennv.Text, date.MinDate, txt_email.Text, txt_sdt.Text, txt_diachi.Text, Convert.ToInt32(txt_sodon.ToString()));


                bool addedSuccessfully = nhanvienController.insert(currentnhanvien);

                if (addedSuccessfully)
                {
                    MessageBox.Show("Đã thêm thành công!");

                }
                else
                {
                    MessageBox.Show("Lỗi!");
                }

            }
        }
    }
}
