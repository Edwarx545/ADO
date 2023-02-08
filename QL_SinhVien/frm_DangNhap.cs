using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SinhVien
{
    public partial class frm_DangNhap : Form
    {
        LopDungChung lopchung;
        public frm_DangNhap()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string sqlDangNhap = "select count (*) from TAIKHOAN where TenDangNhap = '"+
                txt_TenDangNhap.Text+"' and MatKhau = '"+txt_Mathau.Text+"'";
            int ketqua = (int)lopchung.Scalar(sqlDangNhap);
            if(ketqua >= 1)
            {
                frm_SinhVien SV = new frm_SinhVien();
                SV.Show();
            }
            else
                MessageBox.Show("Nhập sai tên đang nhập hoặc bị lỗi");
        }
        SqlDataReader dr;
        private void btn_QuenMatKhau_Click(object sender, EventArgs e)
        {
           // if (txt_Email.Text == "")
                MessageBox.Show("Mời bạn nhập email đã đăng ký");
                lb_NhapEmail.Visible = true;
                txt_Email.Visible = true;
                btn_xnEmail.Visible = true;
        }

        private void btn_xnEmail_Click(object sender, EventArgs e)
        {
                string diachi = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Giang day\GiangDay_Winform CS_414_SL_Khuong_20170516\CS414 Lectures\Code cho cac Slide\Form DangKy\ADO_O\QL_SinhVien\SQL_SinhVien.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(diachi);
                string sqlDem = "select * from TAIKHOAN where Email ='" + txt_Email.Text + "'";
                SqlCommand comm = new SqlCommand(sqlDem, conn);
                conn.Open();
                dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    //lb_MatKhau.Text = dr["MatKhau"].ToString();
                    //lb_MatKhau.Visible = true;
                    MessageBox.Show("Mật khẩu là" + dr["MatKhau"].ToString());
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Email này bạn không có đăng ký ");
                    //lb_NhapEmail.Text = "Email này chưa được đăng ký";
                }
        }
    }
}
