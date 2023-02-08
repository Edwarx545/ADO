namespace QL_SinhVien
{
    partial class frm_SinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SinhVien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.txt_TenSV = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Dem = new System.Windows.Forms.Button();
            this.txt_Dem = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_Khoa = new System.Windows.Forms.ComboBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.btn_LoadLai = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NamThu = new System.Windows.Forms.TextBox();
            this.rdo_Tang = new System.Windows.Forms.RadioButton();
            this.rdo_Giam = new System.Windows.Forms.RadioButton();
            this.lb_QueQuan = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_TenHinhAnh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SV";
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(112, 16);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(100, 20);
            this.txt_MaSV.TabIndex = 2;
            // 
            // txt_TenSV
            // 
            this.txt_TenSV.Location = new System.Drawing.Point(112, 42);
            this.txt_TenSV.Name = "txt_TenSV";
            this.txt_TenSV.Size = new System.Drawing.Size(100, 20);
            this.txt_TenSV.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 187);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Dem
            // 
            this.btn_Dem.Location = new System.Drawing.Point(295, 12);
            this.btn_Dem.Name = "btn_Dem";
            this.btn_Dem.Size = new System.Drawing.Size(75, 23);
            this.btn_Dem.TabIndex = 5;
            this.btn_Dem.Text = "Đếm";
            this.btn_Dem.UseVisualStyleBackColor = true;
            this.btn_Dem.Click += new System.EventHandler(this.btn_Dem_Click);
            // 
            // txt_Dem
            // 
            this.txt_Dem.Location = new System.Drawing.Point(391, 14);
            this.txt_Dem.Name = "txt_Dem";
            this.txt_Dem.Size = new System.Drawing.Size(40, 20);
            this.txt_Dem.TabIndex = 6;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(12, 149);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(93, 149);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(174, 149);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 9;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày Nhập Học";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cb_Khoa
            // 
            this.cb_Khoa.FormattingEnabled = true;
            this.cb_Khoa.Location = new System.Drawing.Point(453, 12);
            this.cb_Khoa.Name = "cb_Khoa";
            this.cb_Khoa.Size = new System.Drawing.Size(182, 21);
            this.cb_Khoa.TabIndex = 12;
            this.cb_Khoa.Text = "Tên Khoa";
            this.cb_Khoa.SelectedIndexChanged += new System.EventHandler(this.cb_Khoa_SelectedIndexChanged);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(625, 113);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(154, 23);
            this.btn_Tim.TabIndex = 13;
            this.btn_Tim.Text = "Tìm theo Mã hoặc Tên SV";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(625, 149);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(154, 20);
            this.txt_Tim.TabIndex = 14;
            this.txt_Tim.TextChanged += new System.EventHandler(this.txt_Tim_TextChanged);
            // 
            // btn_LoadLai
            // 
            this.btn_LoadLai.Location = new System.Drawing.Point(482, 149);
            this.btn_LoadLai.Name = "btn_LoadLai";
            this.btn_LoadLai.Size = new System.Drawing.Size(97, 23);
            this.btn_LoadLai.TabIndex = 15;
            this.btn_LoadLai.Text = "Load Lại Grid";
            this.btn_LoadLai.UseVisualStyleBackColor = true;
            this.btn_LoadLai.Click += new System.EventHandler(this.btn_LoadLai_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Năm Thứ";
            // 
            // txt_NamThu
            // 
            this.txt_NamThu.Location = new System.Drawing.Point(313, 68);
            this.txt_NamThu.Name = "txt_NamThu";
            this.txt_NamThu.Size = new System.Drawing.Size(36, 20);
            this.txt_NamThu.TabIndex = 17;
            // 
            // rdo_Tang
            // 
            this.rdo_Tang.AutoSize = true;
            this.rdo_Tang.Location = new System.Drawing.Point(21, 96);
            this.rdo_Tang.Name = "rdo_Tang";
            this.rdo_Tang.Size = new System.Drawing.Size(94, 17);
            this.rdo_Tang.TabIndex = 18;
            this.rdo_Tang.TabStop = true;
            this.rdo_Tang.Text = "Tăng theo tuổi";
            this.rdo_Tang.UseVisualStyleBackColor = true;
            this.rdo_Tang.CheckedChanged += new System.EventHandler(this.rdo_Tang_CheckedChanged);
            // 
            // rdo_Giam
            // 
            this.rdo_Giam.AutoSize = true;
            this.rdo_Giam.Location = new System.Drawing.Point(21, 119);
            this.rdo_Giam.Name = "rdo_Giam";
            this.rdo_Giam.Size = new System.Drawing.Size(93, 17);
            this.rdo_Giam.TabIndex = 19;
            this.rdo_Giam.TabStop = true;
            this.rdo_Giam.Text = "Giảm theo tuổi";
            this.rdo_Giam.UseVisualStyleBackColor = true;
            this.rdo_Giam.CheckedChanged += new System.EventHandler(this.rdo_Giam_CheckedChanged);
            // 
            // lb_QueQuan
            // 
            this.lb_QueQuan.FormattingEnabled = true;
            this.lb_QueQuan.Location = new System.Drawing.Point(838, 179);
            this.lb_QueQuan.Name = "lb_QueQuan";
            this.lb_QueQuan.Size = new System.Drawing.Size(120, 186);
            this.lb_QueQuan.TabIndex = 20;
            this.lb_QueQuan.SelectedIndexChanged += new System.EventHandler(this.lb_QueQuan_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(799, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_TenHinhAnh
            // 
            this.txt_TenHinhAnh.Location = new System.Drawing.Point(811, 151);
            this.txt_TenHinhAnh.Name = "txt_TenHinhAnh";
            this.txt_TenHinhAnh.Size = new System.Drawing.Size(121, 20);
            this.txt_TenHinhAnh.TabIndex = 22;
            this.txt_TenHinhAnh.Text = "jpg_png_jpeg";
            // 
            // frm_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 377);
            this.Controls.Add(this.txt_TenHinhAnh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_QueQuan);
            this.Controls.Add(this.rdo_Giam);
            this.Controls.Add(this.rdo_Tang);
            this.Controls.Add(this.txt_NamThu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_LoadLai);
            this.Controls.Add(this.txt_Tim);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.cb_Khoa);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Dem);
            this.Controls.Add(this.btn_Dem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_TenSV);
            this.Controls.Add(this.txt_MaSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_SinhVien";
            this.Text = "frm_SinhVien";
            this.Load += new System.EventHandler(this.frm_SinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.TextBox txt_TenSV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Dem;
        private System.Windows.Forms.TextBox txt_Dem;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cb_Khoa;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Button btn_LoadLai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NamThu;
        private System.Windows.Forms.RadioButton rdo_Tang;
        private System.Windows.Forms.RadioButton rdo_Giam;
        private System.Windows.Forms.ListBox lb_QueQuan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_TenHinhAnh;
    }
}