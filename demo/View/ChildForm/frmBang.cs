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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace demo.View.ChildForm
{
    public partial class frmBang : Form
    {
        PhieuthueController phieuthueController;
        List<Phieuthue> ds_phieu;
        Phieuthue currentphieu;
        public frmBang()
        {
            InitializeComponent();
            phieuthueController = new PhieuthueController();
            ds_phieu = new List<Phieuthue>();
            currentphieu = new Phieuthue();

            data_bang.ColumnCount = 6;
            data_bang.Columns[0].Name = "Số phiếu";
            data_bang.Columns[1].Name = "Mã nhân viên";
            data_bang.Columns[2].Name = "Mã khách hàng";
            data_bang.Columns[3].Name = "Ngày cho thuê";
            data_bang.Columns[4].Name = "Ngày trả";
            data_bang.Columns[5].Name = "Tiền trả";

        }
        

        private void frmBang_Load(object sender, EventArgs e)
        {
            ds_phieu.Clear();
            ds_phieu = phieuthueController.load();
            data_bang.Rows.Clear();

            //hien thi len datagridview
            foreach (Phieuthue phieuthue in ds_phieu)
            {
                string[] row = { phieuthue.getId(), phieuthue.getIdnv(), phieuthue.getIdkh(), phieuthue.getDatethue().ToString(), phieuthue.getDatetra().ToString(), phieuthue.getTientra() };
                data_bang.Rows.Add(row);

            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //    currentphieu = new Phieuthue(txt_idkh.Text, txt_namekh.Text, txt_address.Text, txt_phone.Text);
            //    DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            //    if (result == DialogResult.Yes)
            //    {
            //        bool deletedSuccessfully = phieuthueController.delete(currentphieu);

            //        if (deletedSuccessfully)
            //        {
            //            MessageBox.Show("Đã xóa !!");
            //            clear();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Lỗi !");
            //        }
            //    }
        }

        private void LoadPDF_Click(object sender, EventArgs e)
        {
            if (data_bang.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi:" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(data_bang.Columns.Count);
                            pdfTable.DefaultCell.Padding = 6;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in data_bang.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in data_bang.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Dữ liệu Export thành công!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mô tả lỗi :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào được Export!!!", "Info");
            }
        }

        private void In_Click(object sender, EventArgs e)
        {
            
        }

        private int  tongtientra, pos = 60;

        private void In_Click_1(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        int idCounter = 1; // Biến đếm ID, bắt đầu từ 1
        private string manv, makh;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.Font font = new System.Drawing.Font("Arial", 13);
            


            // Vẽ nội dung hóa đơn
            g.DrawString("HÓA ĐƠN", new System.Drawing.Font("Arial", 18, FontStyle.Regular), new SolidBrush(Color.Black), new Point(80));
            g.DrawString("Ngày: " + DateTime.Now.ToString(), font, new SolidBrush(Color.Black), new Point(25, 40));


            // Các mục hóa đơn
            int rowCount = data_bang.Rows.Count;
            foreach (DataGridViewRow row in data_bang.Rows)
            {
                if (row.Index < rowCount - 1)
                {
                    // Chuyển đổi id thành chuỗi
                    string id = row.Cells["Số phiếu"].Value.ToString();

                    // Lấy giá trị của mã nhân viên và mã khách hàng
                    string manv = "" + row.Cells["Mã nhân viên"].Value;
                    string makh = "" + row.Cells["Mã khách hàng"].Value;

                    // Chuyển đổi datethue và datetra thành kiểu DateTime
                    DateTime datethue = Convert.ToDateTime(row.Cells["Ngày cho thuê"].Value);
                    DateTime datetra = Convert.ToDateTime(row.Cells["Ngày trả"].Value);

                    // Chuyển đổi tientra thành kiểu int
                    int tientra = Convert.ToInt32(Convert.ToDecimal(row.Cells["Tiền trả"].Value));


                    g.DrawString("" + id, new System.Drawing.Font("Arial", 18), new SolidBrush(Color.Black), new Point(26, pos));
                    g.DrawString("" + manv, new System.Drawing.Font("Arial", 18), new SolidBrush(Color.Black), new Point(70, pos));
                    g.DrawString("" + makh, new System.Drawing.Font("Arial", 18), new SolidBrush(Color.Black), new Point(150, pos));
                    g.DrawString("" + datethue, new System.Drawing.Font("Arial", 18), new SolidBrush(Color.Black), new Point(200, pos));
                    g.DrawString("" + datetra, new System.Drawing.Font("Arial", 18), new SolidBrush(Color.Black), new Point(300, pos));
                    g.DrawString("" + tientra, new System.Drawing.Font("Arial", 18), new SolidBrush(Color.Black), new Point(500, pos));
                    pos += 20;
                    idCounter++;
                    tongtientra += tientra;
                }
            }
            // Tổng cộng

            g.DrawString("Tổng cộng:" + tongtientra + "VN", font, new SolidBrush(Color.Black), new Point(50, pos + 50));
            pos = 100;
        }
    }
    }
