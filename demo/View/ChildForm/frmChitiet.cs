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
    public partial class frmChitiet : Form
    {
        ChitietController chitietController;
        List<Chitiet> ds_chitiet; //ds chưa các đối tượng 
        Chitiet currentchitiet;
        public frmChitiet()
        {
            InitializeComponent();
            chitietController = new ChitietController();
            ds_chitiet = new List<Chitiet>();
            currentchitiet = new Chitiet();

            data_chitiet.ColumnCount = 5;
            data_chitiet.Columns[0].Name = "STT";
            data_chitiet.Columns[1].Name = "Số phiếu";
            data_chitiet.Columns[2].Name = "Mã sản phẩm";
            data_chitiet.Columns[3].Name = "Số ngày cho thuê";
            data_chitiet.Columns[4].Name = "Hoá đơn";
        }

        private void frmChitiet_Load(object sender, EventArgs e)
        {
            
            ds_chitiet = chitietController.load();
            data_chitiet.Rows.Clear();

            //hien thi len datagridview
            foreach (Chitiet chitiet in ds_chitiet)
            {
                string[] row = { chitiet.getId().ToString(), chitiet.getIdp(), chitiet.getIdsp(), chitiet.getSongay().ToString(), chitiet.getHoadon().ToString() };
                data_chitiet.Rows.Add(row);

            }
        }

        private void data_chitiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
