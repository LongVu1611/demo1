using demo.Model;
using demo.View.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private Form currenFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currenFormChild != null)
            {
                currenFormChild.Close();
            }
            currenFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhach());
            label1.Text = khStrip.Text; 
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanpham());
            label1.Text = SanPhamstrip.Text;
        }

        private void tạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhieuthue());
            label1.Text = SanPhamstrip.Text;
        }
    }
}
