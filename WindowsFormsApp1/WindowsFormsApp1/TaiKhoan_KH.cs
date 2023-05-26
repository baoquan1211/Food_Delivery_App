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

namespace WindowsFormsApp1
{
    public partial class TaiKhoan_KH : Form
    {
        string taiKhoan;
        string maKH;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN2;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        public TaiKhoan_KH(string taikhoan, string makh)
        {
            taiKhoan = taikhoan;
            maKH = makh;
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.Connection = conn;
            string query = @"Select * from KHACHHANG where MaKH = '" + maKH + "'";
            cmd.CommandText = query;
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    tenKH.Text = reader["HoTen"].ToString();
                    sdtKH.Text = reader["SDT"].ToString();
                    diachiKH.Text = reader["DiaChi"].ToString();
                    emailKH.Text = reader["Email"].ToString();
                }
            }
            conn.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tghoatdong_TextChanged(object sender, EventArgs e)
        {

        }

        private void diachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tencuahang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tinhtrang_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaiKhoan_KH_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string hoTen, diaChi, Email, Sdt;
            hoTen = tenKH.Text.ToString();
            diaChi = diachiKH.Text.ToString();
            Email = emailKH.Text.ToString();
            Sdt = sdtKH.Text.ToString();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.Connection = conn;
            string query = @"EXEC pr_updateInfCustomer '"+maKH+"', N'" + hoTen + "', '"+Sdt+"', N'"+diaChi+"', N'"+Email+"'";
            cmd.CommandText = query;
            int exec = cmd.ExecuteNonQuery();
            if (exec == -1)
            {
                MessageBox.Show("Thông tin không hợp lệ, vui lòng kiểm tra lại", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (exec == -2)
            {
                MessageBox.Show("Khách hàng không tồn tại", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                loadData();
            }
            conn.Close();
        }
    }
}
