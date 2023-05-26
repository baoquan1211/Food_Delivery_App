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

namespace FoodDelivery
{
    public partial class UpdateMenu : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string tenMon, mieuTa, gia, tinhTrang;
        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from MONAN where TenMon = N'"+tenMon+"'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvUpdateMenu.DataSource = table;
        }
        public UpdateMenu()
        {
            InitializeComponent();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            tenMon = txtTenMon.Text.ToString();
            mieuTa = txtMieuTa.Text.ToString();
            gia = txtGia.Text.ToString();
            //int giaa = Convert.ToInt32(gia);
            tinhTrang = txtTinhTrang.Text.ToString();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd.Connection = conn;
            string query = @"EXEC pr_updateMenu N'" + tenMon + "', N'"+mieuTa+"', '"+gia+"', N'"+tinhTrang+"' ";
            cmd.CommandText = query;
            int reader = cmd.ExecuteNonQuery();
            if (reader == -1)
            {
                MessageBox.Show("Thông tin không hợp lệ", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (reader == -2)
            {
                MessageBox.Show("Món ăn không tồn tại", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (reader == -3)
            {
                MessageBox.Show("Tình trạng món phải là có bán, hết hàng hoặc tạm ngưng", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cập nhật thành công");
                loadData();
            }
            conn.Close();
           
        }
    }
}
