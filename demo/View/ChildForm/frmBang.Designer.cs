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
            this.data_bang = new System.Windows.Forms.DataGridView();
            this.LoadPDF = new System.Windows.Forms.Button();
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
            this.LoadPDF.Location = new System.Drawing.Point(620, 50);
            this.LoadPDF.Name = "LoadPDF";
            this.LoadPDF.Size = new System.Drawing.Size(75, 23);
            this.LoadPDF.TabIndex = 1;
            this.LoadPDF.Text = "Xuất PDF";
            this.LoadPDF.UseVisualStyleBackColor = true;
            this.LoadPDF.Click += new System.EventHandler(this.LoadPDF_Click);
            // 
            // frmBang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 397);
            this.Controls.Add(this.LoadPDF);
            this.Controls.Add(this.data_bang);
            this.Name = "frmBang";
            this.Text = "frmBang";
            this.Load += new System.EventHandler(this.frmBang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_bang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_bang;
        private System.Windows.Forms.Button LoadPDF;
    }
}