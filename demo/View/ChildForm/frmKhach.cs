using demo.Controller;
using demo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.View.ChildForm
{
    public partial class frmKhach : Form
    {
        KhachController khachController; //controller
        List<Khach> dskhach; //ds chưa các đối tượng 
        Khach currentKhach; // ds khach đang được chọn
        public void clear()
        {
            txt_idkh.Clear(); ;
            txt_namekh.Clear();
            txt_address.Clear();
            txt_phone.Clear();

        }
        public frmKhach()
        {
            InitializeComponent();
            khachController = new KhachController();
            dskhach = new List<Khach>() ;
            currentKhach = new Khach() ;

            data_kh.ColumnCount = 4;
            data_kh.Columns[0].Name = "Mã khách hàng";
            data_kh.Columns[1].Name = "Tên khách hàng";
            data_kh.Columns[2].Name = "Địa chỉ";
            data_kh.Columns[3].Name = "Số điện thoại";
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            dskhach.Clear();
            dskhach = khachController.load();
            data_kh.Rows.Clear();

            //hien thi len datagridview
            foreach (Khach khach in dskhach)
            {
                string[] row = { khach.getIdkh(), khach.getNamekh(), khach.getAddress(), khach.getPhone() };
                data_kh.Rows.Add(row);

            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_idkh.Text) && !string.IsNullOrWhiteSpace(txt_namekh.Text) && !string.IsNullOrWhiteSpace(txt_address.Text) && !string.IsNullOrWhiteSpace(txt_phone.Text))
            {
                currentKhach = new Khach(txt_idkh.Text, txt_namekh.Text, txt_address.Text, txt_phone.Text);


                bool addedSuccessfully = khachController.insert(currentKhach);

                if (addedSuccessfully)
                {
                    MessageBox.Show("Đã thêm thành công!");

                }
                else
                {
                    MessageBox.Show("Lỗi!");
                }

            }
            btn_load_Click(sender, e);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (data_kh.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in data_kh.SelectedRows)
                {
                    currentKhach = new Khach(txt_idkh.Text, txt_namekh.Text, txt_address.Text, txt_phone.Text);

                    bool updatedSuccessfully = khachController.update(currentKhach);

                    if (updatedSuccessfully)
                    {
                        MessageBox.Show("Đã sửa thành công!");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy đối tượng muốn sửa!");
            }
            btn_load_Click(sender, e);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            currentKhach = new Khach(txt_idkh.Text, txt_namekh.Text, txt_address.Text, txt_phone.Text);
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                bool deletedSuccessfully = khachController.delete(currentKhach);

                if (deletedSuccessfully)
                {
                    MessageBox.Show("Đã xóa !!");
                    clear();
                }
                else
                {
                    MessageBox.Show("Lỗi !");
                }
            }

            btn_load_Click(sender, e);
        }

        private void frmKhach_Load(object sender, EventArgs e)
        {

        }
    }
}
