namespace demo.View.ChildForm
{
    partial class frmChitiet
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
            this.data_chitiet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_chitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // data_chitiet
            // 
            this.data_chitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_chitiet.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.data_chitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_chitiet.Location = new System.Drawing.Point(12, 79);
            this.data_chitiet.Name = "data_chitiet";
            this.data_chitiet.RowHeadersWidth = 51;
            this.data_chitiet.RowTemplate.Height = 24;
            this.data_chitiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_chitiet.Size = new System.Drawing.Size(969, 345);
            this.data_chitiet.TabIndex = 0;
            this.data_chitiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_chitiet_CellContentClick);
            // 
            // frmChitiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.data_chitiet);
            this.Name = "frmChitiet";
            this.Text = "frmChitiet";
            this.Load += new System.EventHandler(this.frmChitiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_chitiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_chitiet;
    }
}