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
    public partial class frmPhieuthue : Form
    {
        KhachController khachController;
        SanphamController sanphamController;
        PhieuthueController phieuthueController;
        ChitietController chitietController;
        NhanvienController nhanvienController;
        List<Sanpham> ds_sanpham;//danh sach kho
        List<Khach> ds_khach;//danh sach hang hoa
        List<Nhanvien> ds_nhanvien;
        Phieuthue currentphieu;
        public frmPhieuthue()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                String idsp = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = sanphamController.get(idsp).getNamesp();
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = sanphamController.get(idsp).getGiavon();
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = sanphamController.get(idsp).getGiathue();
            }
            //column index 4 là đơn giá
            if (e.ColumnIndex == 5)
            {
                //int giaThue = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Trim());
                //int sn = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Trim());
                //dataGridView1.Rows[e.RowIndex].Cells[5].Value = sn * giaThue ;
                int giaThue = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Trim());
                int sn = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Trim());

                // Gán giá trị mới vào cột Cells[5]
                dataGridView1.Rows[e.RowIndex].Cells[5].Value = giaThue * sn;

            }
        }

        private void frmPhieuthue_Load(object sender, EventArgs e)
        {
            chitietController = new ChitietController();
            sanphamController = new SanphamController();
            nhanvienController = new NhanvienController();
            khachController = new KhachController();
            ds_sanpham = new List<Sanpham>(); 
            ds_khach = khachController.load();
            ds_khach = new List<Khach>();
            ds_nhanvien = new List<Nhanvien>();
            ds_nhanvien = nhanvienController.load();
            ds_sanpham = sanphamController.load();
            phieuthueController = new PhieuthueController();

            
            foreach (Nhanvien n in ds_nhanvien)
            {
                idnv.Items.Add(n.getIdnv());

            }
            DataGridViewComboBoxColumn comboboxColumn;
            comboboxColumn = new DataGridViewComboBoxColumn();
            comboboxColumn.DataPropertyName = "masp";
            comboboxColumn.HeaderText = "Mã sản phẩm";
            comboboxColumn.DropDownWidth = 160;
            comboboxColumn.Width = 90;
            comboboxColumn.MaxDropDownItems = 3;
            comboboxColumn.FlatStyle = FlatStyle.Flat;
            foreach (Sanpham sp in ds_sanpham)
            {
                comboboxColumn.Items.Add(sp.getIdsp());
            }
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(comboboxColumn);//Ma san pham
            //tên hàng
            DataGridViewTextBoxColumn colTenHang = new DataGridViewTextBoxColumn();
            colTenHang.DataPropertyName = "tensp";
            colTenHang.HeaderText = "Tên sản phẩm";
            dataGridView1.Columns.Add(colTenHang);
            // Đơn vị tính
            DataGridViewTextBoxColumn colGiavon = new DataGridViewTextBoxColumn();
            colGiavon.DataPropertyName = "giavon";
            colGiavon.HeaderText = "Giá vốn";
            dataGridView1.Columns.Add(colGiavon);
            // Số ngày thuê
            DataGridViewTextBoxColumn colSGiathue = new DataGridViewTextBoxColumn();
            colSGiathue.DataPropertyName = "giathue1ngay";
            colSGiathue.HeaderText = "Giá thuê 1 ngày";
            dataGridView1.Columns.Add(colSGiathue);
            // Đơn giá
            DataGridViewTextBoxColumn colSongay = new DataGridViewTextBoxColumn();
            colSongay.DataPropertyName = "songaychothue";
            colSongay.HeaderText = "Số ngày thuê";
            dataGridView1.Columns.Add(colSongay);
            // Thành tiền
            DataGridViewTextBoxColumn colThanhTien = new DataGridViewTextBoxColumn();
            colThanhTien.DataPropertyName = "hoadon";
            colThanhTien.HeaderText = "Thành tiền";
            dataGridView1.Columns.Add(colThanhTien);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            currentphieu = new Phieuthue(id.Text, idnv.Text, idkh.Text, Convert.ToDateTime(datethue.Value), Convert.ToDateTime(datetra.Value), tientra.Text );

            bool tbao = phieuthueController.insert(currentphieu);
            if (tbao)
            {
                MessageBox.Show("Đã lưu !!");

            }
            //2. Lưu chi tiết phiếu thuê
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Chitiet ct = new Chitiet();

                ct.setIdp(id.Text.ToString());
                ct.setIdsp(dataGridView1.Rows[i].Cells[0].Value.ToString());

                ct.setSongay(Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString()));
                ct.setHoadon(Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value.ToString()));

                chitietController.insert(ct);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void op_phieu_Click(object sender, EventArgs e)
        {
            frmBang bang = new frmBang();
            bang.ShowDialog();
        }

        private void datetra_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
