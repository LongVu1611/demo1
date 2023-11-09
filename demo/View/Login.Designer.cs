namespace demo
{
    partial class Login
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
            this.Acc = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.txt_acc = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Acc
            // 
            this.Acc.AutoSize = true;
            this.Acc.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acc.Location = new System.Drawing.Point(66, 126);
            this.Acc.Name = "Acc";
            this.Acc.Size = new System.Drawing.Size(90, 24);
            this.Acc.TabIndex = 0;
            this.Acc.Text = "Tài khoản";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(66, 181);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(88, 24);
            this.Pass.TabIndex = 1;
            this.Pass.Text = "Mật khẩu";
            // 
            // txt_acc
            // 
            this.txt_acc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_acc.Location = new System.Drawing.Point(201, 126);
            this.txt_acc.Name = "txt_acc";
            this.txt_acc.Size = new System.Drawing.Size(192, 22);
            this.txt_acc.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass.Location = new System.Drawing.Point(201, 181);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(192, 22);
            this.txt_pass.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(169, 34);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(236, 48);
            this.label.TabIndex = 4;
            this.label.Text = "ĐĂNG NHẬP";
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(213, 225);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(163, 37);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Đăng nhập";
            this.login_btn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 306);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_acc);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Acc);
            this.Name = "Login";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Acc;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox txt_acc;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button login_btn;
    }
}

