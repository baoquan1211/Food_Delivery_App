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

namespace DoiTac
{
    public partial class TTKhachHang_TX : Form
    {
        string maKH;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN2;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        public TTKhachHang_TX(string makh)
        {
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
                while (reader.Read())
                {
                    htenKH.Text = reader["HoTen"].ToString();
                    sdtKH.Text = reader["SDT"].ToString();
                    diachiKH.Text = reader["DiaChi"].ToString();
                    emailKH.Text = reader["Email"].ToString();
                }
            }
        }
        private void htenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void htenKH_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
