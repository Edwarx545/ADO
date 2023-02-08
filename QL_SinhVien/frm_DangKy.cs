using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SinhVien
{
    public partial class frm_DangKy : Form
    {
        LopDungChung lopchung;
        public frm_DangKy()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
        }
        public bool CheckEmail(string mail)
        {
            //return Regex.IsMatch(mail, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
            return Regex.IsMatch(mail, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
            //return Regex.IsMatch(mail, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string sqlDangKy = "insert into TAIKHOAN values('" + txt_TenDangNhap.Text + "', '" + txt_MatKhauDangKy.Text + "', '" + 
                txt_xnMatKhau.Text + "', '" + txt_Email.Text + "', N'" + txt_DiaChi.Text + "', N'"+txt_TenDangKy.Text+"')";
            string sqlDem = "select count (TenDangNhap) from TAIKHOAN where TenDangNhap ='"+txt_TenDangNhap.Text+"'";
            int check = (int)lopchung.Scalar(sqlDem);
            if (check == 0)
            {
                if (txt_MatKhauDangKy.Text != txt_xnMatKhau.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận phải giống với mật khẩu");
                }
                else if (txt_TenDangKy.Text == "")
                    MessageBox.Show("bạn phải nhập tên đăng ký");
                else if (txt_TenDangNhap.Text == "")
                    MessageBox.Show("bạn phải nhập tên đăng nhập");
                else if (txt_MatKhauDangKy.Text == "")
                    MessageBox.Show("bạn phải nhập mật khẩu");
                else if (!CheckEmail(txt_Email.Text))
                    MessageBox.Show("bạn phải nhập đúng định dạng email");
                else lopchung.Nonquery(sqlDangKy);
            }
            else
            MessageBox.Show("Tên tài khoản đã tồn tại");
            LoadGrid();
        }
        public void LoadGrid()
        {
            string sqlLoadGrid = "select * from TAIKHOAN";
            dataGridView1.DataSource = lopchung.LoadData(sqlLoadGrid);
        }

        private void frm_DangKy_Load(object sender, EventArgs e)
        {
           // LoadGrid();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            string sqlSua = "update TAIKHOAN set MatKhau = '" + txt_MatKhauDangKy.Text + "', XacNhanMatKhau = '" +
               txt_xnMatKhau.Text + "', Email = '" + txt_Email.Text + "', DiaChi = N'"+txt_DiaChi.Text+"', TenDangKy = N'"+
               txt_TenDangKy.Text+"' where TenDangNhap = '" + txt_TenDangNhap.Text + "' ";
            if (txt_MatKhauDangKy.Text != txt_xnMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận phải giống với mật khẩu");
            }
            else if (txt_TenDangKy.Text == "")
                MessageBox.Show("bạn phải nhập tên đăng ký");
            else if (txt_TenDangNhap.Text == "")
                MessageBox.Show("bạn phải nhập tên đăng nhập");
            else if (txt_MatKhauDangKy.Text == "")
                MessageBox.Show("bạn phải nhập mật khẩu");
            else if (!CheckEmail(txt_Email.Text))
                MessageBox.Show("bạn phải nhập đúng định dạng email");
            else lopchung.Nonquery(sqlSua);
            LoadGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TenDangNhap.Text = dataGridView1.CurrentRow.Cells["TenDangNhap"].Value.ToString();
            txt_MatKhauDangKy.Text = dataGridView1.CurrentRow.Cells["MatKhau"].Value.ToString();
            txt_xnMatKhau.Text = dataGridView1.CurrentRow.Cells["XacNhanMatKhau"].Value.ToString();
            txt_Email.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            txt_TenDangKy.Text = dataGridView1.CurrentRow.Cells["TenDangKy"].Value.ToString();
            txt_DiaChi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "delete from TAIKHOAN where TenDangNhap = '" + txt_TenDangNhap.Text + "'";
            lopchung.Nonquery(sqlXoa);
            LoadGrid();
        }
        
    }
}
