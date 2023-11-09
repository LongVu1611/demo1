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
    public partial class frmSanpham : Form
    {
        SanphamController sanphamController;
        List<Sanpham> dssanpham;
        Sanpham currentsp;
        public void clear()
        {
            txt_masp.Clear(); ;
            txt_tensp.Clear();
            txt_soluong.Clear();
            txt_xuatxu.Clear();
            txt_tinhtrang.Clear();
            txt_giavon.Clear();
            txt_giathue.Clear();

        }
        public frmSanpham()
        {
            InitializeComponent();
            sanphamController = new SanphamController();
            dssanpham = new List<Sanpham>();
            currentsp = new Sanpham();

            data_sp.ColumnCount = 7;
            data_sp.Columns[0].Name = "Mã sản phẩm";
            data_sp.Columns[1].Name = "Tên sản phẩm";
            data_sp.Columns[2].Name = "Số lượng";
            data_sp.Columns[3].Name = "Xuất xứ";
            data_sp.Columns[4].Name = "Tình trạng";
            data_sp.Columns[5].Name = "Giá vốn";
            data_sp.Columns[6].Name = "Giá thuê/ ngày";
        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            dssanpham.Clear();
            dssanpham = sanphamController.load();
            data_sp.Rows.Clear();

            //hien thi len datagridview
            foreach (Sanpham sanpham in dssanpham)
            {
                string[] row = { sanpham.getIdsp(), sanpham.getNamesp(), sanpham.getSoluong(), sanpham.getXuatxu(), sanpham.getTinhtrang(), sanpham.getGiavon(), sanpham.getGiathue(), };
                data_sp.Rows.Add(row);

            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_masp.Text) && !string.IsNullOrWhiteSpace(txt_tensp.Text) && !string.IsNullOrWhiteSpace(txt_soluong.Text) && !string.IsNullOrWhiteSpace(txt_xuatxu.Text) && !string.IsNullOrWhiteSpace(txt_tinhtrang.Text) && !string.IsNullOrWhiteSpace(txt_giavon.Text) && !string.IsNullOrWhiteSpace(txt_giathue.Text))
            {
                currentsp = new Sanpham(txt_masp.Text, txt_tensp.Text, txt_soluong.Text, txt_xuatxu.Text, txt_tinhtrang.Text , txt_giavon.Text , txt_giathue.Text);


                bool addedSuccessfully = sanphamController.insert(currentsp);

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
            if (data_sp.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in data_sp.SelectedRows)
                {
                    currentsp = new Sanpham(txt_masp.Text, txt_tensp.Text, txt_soluong.Text, txt_xuatxu.Text, txt_tinhtrang.Text, txt_giavon.Text, txt_giathue.Text);

                    bool updatedSuccessfully = sanphamController.update(currentsp);

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
            currentsp = new Sanpham(txt_masp.Text, txt_tensp.Text, txt_soluong.Text, txt_xuatxu.Text, txt_tinhtrang.Text, txt_giavon.Text, txt_giathue.Text);
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                bool deletedSuccessfully = sanphamController.delete(currentsp);

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
    }
}
