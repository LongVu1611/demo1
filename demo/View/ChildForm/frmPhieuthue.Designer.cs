namespace demo.View.ChildForm
{
    partial class frmPhieuthue
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
            this.id = new System.Windows.Forms.TextBox();
            this.idnv = new System.Windows.Forms.ComboBox();
            this.datethue = new System.Windows.Forms.DateTimePicker();
            this.datetra = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.tientra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idkh = new System.Windows.Forms.TextBox();
            this.op_phieu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(160, 56);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(190, 22);
            this.id.TabIndex = 0;
            // 
            // idnv
            // 
            this.idnv.FormattingEnabled = true;
            this.idnv.Location = new System.Drawing.Point(160, 197);
            this.idnv.Name = "idnv";
            this.idnv.Size = new System.Drawing.Size(190, 24);
            this.idnv.TabIndex = 2;
            // 
            // datethue
            // 
            this.datethue.Location = new System.Drawing.Point(643, 54);
            this.datethue.Name = "datethue";
            this.datethue.Size = new System.Drawing.Size(200, 22);
            this.datethue.TabIndex = 4;
            // 
            // datetra
            // 
            this.datetra.Location = new System.Drawing.Point(643, 119);
            this.datetra.Name = "datetra";
            this.datetra.Size = new System.Drawing.Size(200, 22);
            this.datetra.TabIndex = 5;
            this.datetra.ValueChanged += new System.EventHandler(this.datetra_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(931, 180);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Số phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày cho thuê";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày trả";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(942, 54);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(96, 55);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tientra
            // 
            this.tientra.Location = new System.Drawing.Point(653, 208);
            this.tientra.Name = "tientra";
            this.tientra.Size = new System.Drawing.Size(190, 22);
            this.tientra.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nhập số tiền thanh toán";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // idkh
            // 
            this.idkh.Location = new System.Drawing.Point(160, 125);
            this.idkh.Name = "idkh";
            this.idkh.Size = new System.Drawing.Size(190, 22);
            this.idkh.TabIndex = 16;
            // 
            // op_phieu
            // 
            this.op_phieu.Location = new System.Drawing.Point(918, 150);
            this.op_phieu.Name = "op_phieu";
            this.op_phieu.Size = new System.Drawing.Size(120, 55);
            this.op_phieu.TabIndex = 17;
            this.op_phieu.Text = "Mở bảng phiếu thuê";
            this.op_phieu.UseVisualStyleBackColor = true;
            this.op_phieu.Click += new System.EventHandler(this.op_phieu_Click);
            // 
            // frmPhieuthue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 443);
            this.Controls.Add(this.op_phieu);
            this.Controls.Add(this.idkh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tientra);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.datetra);
            this.Controls.Add(this.datethue);
            this.Controls.Add(this.idnv);
            this.Controls.Add(this.id);
            this.Name = "frmPhieuthue";
            this.Text = "frmPhieuthue";
            this.Load += new System.EventHandler(this.frmPhieuthue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.ComboBox idnv;
        private System.Windows.Forms.DateTimePicker datethue;
        private System.Windows.Forms.DateTimePicker datetra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tientra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idkh;
        private System.Windows.Forms.Button op_phieu;
    }
}