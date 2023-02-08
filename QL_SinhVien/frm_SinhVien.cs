using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SinhVien
{
    public partial class frm_SinhVien : Form
    {
        LopDungChung lopchung;
        public frm_SinhVien()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
        }
        private void frm_SinhVien_Load(object sender, EventArgs e)
        {
            LoadListBox();
            LoadCombo();
            LoadGrid();           
        }
        public void LoadListBox()
        {
            string sqlLoadLB = "select * from QUEQUAN";
            lb_QueQuan.DataSource = lopchung.LoadData(sqlLoadLB);
            lb_QueQuan.DisplayMember = "TenQueQuan";
            lb_QueQuan.ValueMember = "MaQueQuan";
        }
        public void LoadCombo()
        {           
            string sqlLoadCombo = "select * from KHOA";
            cb_Khoa.DataSource = lopchung.LoadData(sqlLoadCombo);
            cb_Khoa.DisplayMember = "TenKhoa";
            cb_Khoa.ValueMember = "MaKhoa";
        }
        public void LoadGrid()
        {
            string sqlLoadGrid = "select * from SINHVIEN";
            dataGridView1.DataSource = lopchung.LoadData(sqlLoadGrid);
        }
        private void btn_Dem_Click(object sender, EventArgs e)
        {
            string sqlDem = "select count (*) from SINHVIEN";
            int kq = (int)lopchung.Scalar(sqlDem);
            txt_Dem.Text = kq.ToString();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlThem = "insert into SINHVIEN values('" + txt_MaSV.Text + "', N'" + txt_TenSV.Text +
                "', Convert(DateTime,'" + dateTimePicker1.Value + "',103), '" + cb_Khoa.SelectedValue + "', '" +
                txt_NamThu.Text + "', '" + lb_QueQuan.SelectedValue + "', '" + txt_TenHinhAnh.Text + "')";
            pictureBox1.Image.Save(duongdan + txt_TenHinhAnh.Text);
            lopchung.Nonquery(sqlThem);
            LoadGrid();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "delete SINHVIEN where MaSV = '"+txt_MaSV.Text+"'";
            File.Delete(duongdan + txt_TenHinhAnh.Text);
            lopchung.Nonquery(sqlXoa);
            LoadGrid();
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "update SINHVIEN set TenSV = N'"+txt_TenSV.Text+"', NgayNhapHoc = Convert(DateTime,'"+
                dateTimePicker1.Value+"',103), MaKhoa = '"+cb_Khoa.SelectedValue+"', NamThu = '"+txt_NamThu.Text+
                "', MaQueQuan = '"+lb_QueQuan.SelectedValue+"', TenHinhAnh = '"+txt_TenHinhAnh.Text+"' where MaSV = '" + txt_MaSV.Text + "'";
            //pictureBox1.Image.Save(@"C:\Users\KHUONG\Desktop\ADO_O\QL_SinhVien\HINHANH\" + txt_TenHinhAnh.Text);
            pictureBox1.Image.Save(duongdan + txt_TenHinhAnh.Text);
            lopchung.Nonquery(sqlSua);
            LoadGrid();
        }
        int tim = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSV.Text = dataGridView1.CurrentRow.Cells["MaSV"].Value.ToString();
            txt_TenSV.Text = dataGridView1.CurrentRow.Cells["TenSV"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["NgayNhapHoc"].Value.ToString();
            txt_TenHinhAnh.Text = dataGridView1.CurrentRow.Cells["TenHinhAnh"].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_TenHinhAnh.Text;
            tim = 1;
            cb_Khoa.SelectedValue = dataGridView1.CurrentRow.Cells["MaKhoa"].Value.ToString();
            tim = 1;
            lb_QueQuan.SelectedValue = dataGridView1.CurrentRow.Cells["MaQueQuan"].Value.ToString();
        }
        private void txt_Tim_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = btn_Tim;
        }
        private void btn_Tim_Click(object sender, EventArgs e)
        {
       
            string sqlLoadGrid = "select * from SINHVIEN where MaSV like '%" + txt_Tim.Text + "%' or TenSV like N'%" + txt_Tim.Text + "%'";
            dataGridView1.DataSource = lopchung.LoadData(sqlLoadGrid);
        }

        private void cb_Khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tim == 0)
            {
            string maKhoa = cb_Khoa.SelectedValue.ToString();
            string sqlLoadGrid = "select * from SINHVIEN where MaKhoa = '" + maKhoa + "'";
            dataGridView1.DataSource = lopchung.LoadData(sqlLoadGrid);
            }
            tim = 0;
        }

        private void btn_LoadLai_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int nam = DateTime.Now.Year - dateTimePicker1.Value.Year + 1;
            txt_NamThu.Text = nam.ToString();
        }

        private void rdo_Tang_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["NamThu"], ListSortDirection.Ascending);
        }

        private void rdo_Giam_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["NamThu"], ListSortDirection.Descending);
        }

        private void lb_QueQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tim == 0)
            {
                string maQueQuan =  lb_QueQuan.SelectedValue.ToString();
                string sqlLoadGrid = "select * from SINHVIEN where MaQueQuan = '" + maQueQuan + "'";
                dataGridView1.DataSource = lopchung.LoadData(sqlLoadGrid);
            }
            tim = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Hãy chọn hình";
            OFD.Filter = "Tất cả đuôi|*.*|Đuôi jpg|*.jpg|Đuôi JPEG|*.jpeg|Đuôi PNG| *.png";
            if (OFD.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(OFD.FileName);
        }

    }
}
