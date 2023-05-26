using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using DoiTac;
using FoodDelivery;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        string taiKhoan;
        string ID;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN2;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Login()
        {
            InitializeComponent();
        }
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Taikhoan.Text != "" && Matkhau.Text != "")
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd.Connection = conn;
                string query = "EXEC SP_LOGIN_ROLE '"+Taikhoan.Text+"', '"+Matkhau.Text+"'";
                cmd.CommandText = query;
                SqlDataReader dt = cmd.ExecuteReader();
                if(dt.HasRows)
                {
                    if(dt.Read())
                    {
                        taiKhoan = (string)dt[0];
                         
                        if ((string)dt[3] == "DT")
                        {
                            ID = (string)dt[2];
                            Partner form = new Partner();
                            form.Show();
                            this.Visible = false;
                        }
                        if ((string)dt[3] == "KH")
                        {
                            ID = (string)dt[2];
                            Khachhang form = new Khachhang(taiKhoan, ID);
                            form.Show();
                            this.Visible = false;
                        }
                        if ((string)dt[3] == "TX")
                        {
                            ID = (string)dt[2];
                            DoiTac.MainScreen form = new DoiTac.MainScreen(taiKhoan, ID);
                            form.Show();
                            this.Visible = false;
                        }
                        if ((string)dt[3] == "NV")
                        {
                            NhanVien.MainScreem form = new NhanVien.MainScreem(); 
                            form.Show();
                            this.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập sai", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền tài khoản và mật khẩu.");
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Matkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
