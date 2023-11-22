namespace demo.View.ChildForm
{
    partial class frmBang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBang));
            this.data_bang = new System.Windows.Forms.DataGridView();
            this.LoadPDF = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.In = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_bang)).BeginInit();
            this.SuspendLayout();
            // 
            // data_bang
            // 
            this.data_bang.AllowUserToAddRows = false;
            this.data_bang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_bang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_bang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_bang.Location = new System.Drawing.Point(12, 93);
            this.data_bang.Name = "data_bang";
            this.data_bang.RowHeadersWidth = 51;
            this.data_bang.RowTemplate.Height = 24;
            this.data_bang.Size = new System.Drawing.Size(834, 279);
            this.data_bang.TabIndex = 0;
            // 
            // LoadPDF
            // 
            this.LoadPDF.Location = new System.Drawing.Point(724, 27);
            this.LoadPDF.Name = "LoadPDF";
            this.LoadPDF.Size = new System.Drawing.Size(122, 60);
            this.LoadPDF.TabIndex = 1;
            this.LoadPDF.Text = "Xuất PDF";
            this.LoadPDF.UseVisualStyleBackColor = true;
            this.LoadPDF.Click += new System.EventHandler(this.LoadPDF_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // In
            // 
            this.In.Location = new System.Drawing.Point(572, 27);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(122, 60);
            this.In.TabIndex = 2;
            this.In.Text = "In";
            this.In.UseVisualStyleBackColor = true;
            this.In.Click += new System.EventHandler(this.In_Click_1);
            // 
            // frmBang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 397);
            this.Controls.Add(this.In);
            this.Controls.Add(this.LoadPDF);
            this.Controls.Add(this.data_bang);
            this.Name = "frmBang";
            this.Text = "Lịch sử phiếu thuê";
            this.Load += new System.EventHandler(this.frmBang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_bang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_bang;
        private System.Windows.Forms.Button LoadPDF;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button In;
    }
}