using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NhanVien
{
    public partial class HopDong_NV : Form
    {
        string maDT;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN2;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public HopDong_NV(string madt)
        {
            maDT = madt;
            InitializeComponent();
            loadData();
        }

        void loadData()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.Connection = conn;
            string query = @"Select * from HOPDONG where MaDoiTac = '" + maDT + "'";
            cmd.CommandText = query;
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    mahdHD.Text = reader["MaHopDong"].ToString();
                    msthueHD.Text = reader["MaSoThueDT"].ToString();
                    stkHD.Text = reader["SoTaiKhoan"].ToString();
                    nganhangHD.Text = reader["NganHang"].ToString();
                    chinhanhnganhangHD.Text = reader["ChiNhanhNganHang"].ToString();
                    thoigianhieulucHD.Text = reader["ThoiGianHieuLuc"].ToString();
                }
            }
            conn.Close();
        }
        
        private void btn_capnhat_Click_1(object sender, EventArgs e)
        {
            if (thoigianhieulucHD.Text != "")
            {
                DateTime tghieuluc =  Convert.ToDateTime(thoigianhieulucHD.Text);

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd.Connection = conn;
                string query = @"EXEC pr_ChangeTimeContract '" + maDT + "', N'" + tghieuluc + "'";
                cmd.CommandText = query;
                int exec = cmd.ExecuteNonQuery();
                if (exec == -1)
                {
                    MessageBox.Show("Thông tin không hợp lệ, vui lòng kiểm tra lại.", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (exec == -2)
                {
                    MessageBox.Show("Hợp đồng không tồn tại.", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (exec == -3)
                {
                    MessageBox.Show("Thời gian không hợp lệ.", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thành công.");
                    loadData();
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng điền thời gian hiệu lực.");
            }
        }
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
