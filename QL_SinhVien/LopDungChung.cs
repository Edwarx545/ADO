using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SinhVien
{
    class LopDungChung
    {
        string diachi = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Giang day\GiangDay_Winform CS_414_SL_Khuong_20170516\CS414 Lectures\Code cho cac Slide\Form DangKy\ADO_O\QL_SinhVien\SQL_SinhVien.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(diachi);
        }
        public void Nonquery(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            try
            {
                int ketqua = comm.ExecuteNonQuery();
                //int ketqua = (int)comm.ExecuteScalar();
                if (ketqua >= 1) MessageBox.Show("Thành công");
                else MessageBox.Show("Thất bại, (Xóa, chưa có mã), (Sửa, chưa có mã)");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi catch, (Thêm trùng mã, slq), (Xóa, sql)");
            }
            finally
            {
                conn.Close();
            }           
        }
        public object Scalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketqua;
        }
        public DataTable LoadData(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
