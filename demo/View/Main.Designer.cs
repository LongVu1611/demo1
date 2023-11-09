namespace demo.View
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SanPhamstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.khStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinChoThuêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.tạoToolStripMenuItem,
            this.thôngTinChoThuêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SanPhamstrip,
            this.khStrip});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // SanPhamstrip
            // 
            this.SanPhamstrip.Name = "SanPhamstrip";
            this.SanPhamstrip.Size = new System.Drawing.Size(169, 26);
            this.SanPhamstrip.Text = "Sản phẩm";
            this.SanPhamstrip.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // khStrip
            // 
            this.khStrip.Name = "khStrip";
            this.khStrip.Size = new System.Drawing.Size(169, 26);
            this.khStrip.Text = "Khách hàng";
            this.khStrip.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // tạoToolStripMenuItem
            // 
            this.tạoToolStripMenuItem.Name = "tạoToolStripMenuItem";
            this.tạoToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.tạoToolStripMenuItem.Text = "Tạo ";
            this.tạoToolStripMenuItem.Click += new System.EventHandler(this.tạoToolStripMenuItem_Click);
            // 
            // thôngTinChoThuêToolStripMenuItem
            // 
            this.thôngTinChoThuêToolStripMenuItem.Name = "thôngTinChoThuêToolStripMenuItem";
            this.thôngTinChoThuêToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.thôngTinChoThuêToolStripMenuItem.Text = "Thông tin cho thuê";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.Menu);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 28);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1082, 475);
            this.panel.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(955, -25);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(55, 25);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(886, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SanPhamstrip;
        private System.Windows.Forms.ToolStripMenuItem khStrip;
        private System.Windows.Forms.ToolStripMenuItem thôngTinChoThuêToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.Label label1;
    }
}