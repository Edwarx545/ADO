namespace QL_SinhVien
{
    partial class frm_DangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.txt_Mathau = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_QuenMatKhau = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lb_NhapEmail = new System.Windows.Forms.Label();
            this.lb_MatKhau = new System.Windows.Forms.Label();
            this.btn_xnEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(272, 25);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(100, 20);
            this.txt_TenDangNhap.TabIndex = 2;
            // 
            // txt_Mathau
            // 
            this.txt_Mathau.Location = new System.Drawing.Point(272, 75);
            this.txt_Mathau.Name = "txt_Mathau";
            this.txt_Mathau.Size = new System.Drawing.Size(100, 20);
            this.txt_Mathau.TabIndex = 3;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Location = new System.Drawing.Point(180, 137);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(75, 23);
            this.btn_DangNhap.TabIndex = 4;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(355, 137);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_QuenMatKhau
            // 
            this.btn_QuenMatKhau.Location = new System.Drawing.Point(180, 187);
            this.btn_QuenMatKhau.Name = "btn_QuenMatKhau";
            this.btn_QuenMatKhau.Size = new System.Drawing.Size(122, 23);
            this.btn_QuenMatKhau.TabIndex = 6;
            this.btn_QuenMatKhau.Text = "Quên Mật Khẩu";
            this.btn_QuenMatKhau.UseVisualStyleBackColor = true;
            this.btn_QuenMatKhau.Click += new System.EventHandler(this.btn_QuenMatKhau_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(180, 259);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(199, 20);
            this.txt_Email.TabIndex = 7;
            this.txt_Email.Visible = false;
            // 
            // lb_NhapEmail
            // 
            this.lb_NhapEmail.AutoSize = true;
            this.lb_NhapEmail.Location = new System.Drawing.Point(177, 226);
            this.lb_NhapEmail.Name = "lb_NhapEmail";
            this.lb_NhapEmail.Size = new System.Drawing.Size(103, 13);
            this.lb_NhapEmail.TabIndex = 8;
            this.lb_NhapEmail.Text = "Nhập Email đăng ký";
            this.lb_NhapEmail.Visible = false;
            // 
            // lb_MatKhau
            // 
            this.lb_MatKhau.AutoSize = true;
            this.lb_MatKhau.Location = new System.Drawing.Point(343, 192);
            this.lb_MatKhau.Name = "lb_MatKhau";
            this.lb_MatKhau.Size = new System.Drawing.Size(30, 13);
            this.lb_MatKhau.TabIndex = 9;
            this.lb_MatKhau.Text = "Pass";
            this.lb_MatKhau.Visible = false;
            // 
            // btn_xnEmail
            // 
            this.btn_xnEmail.Location = new System.Drawing.Point(321, 221);
            this.btn_xnEmail.Name = "btn_xnEmail";
            this.btn_xnEmail.Size = new System.Drawing.Size(122, 23);
            this.btn_xnEmail.TabIndex = 10;
            this.btn_xnEmail.Text = "Xác nhận Email";
            this.btn_xnEmail.UseVisualStyleBackColor = true;
            this.btn_xnEmail.Visible = false;
            this.btn_xnEmail.Click += new System.EventHandler(this.btn_xnEmail_Click);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 311);
            this.Controls.Add(this.btn_xnEmail);
            this.Controls.Add(this.lb_MatKhau);
            this.Controls.Add(this.lb_NhapEmail);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.btn_QuenMatKhau);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txt_Mathau);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_DangNhap";
            this.Text = "frm_DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.TextBox txt_Mathau;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_QuenMatKhau;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lb_NhapEmail;
        private System.Windows.Forms.Label lb_MatKhau;
        private System.Windows.Forms.Button btn_xnEmail;
    }
}