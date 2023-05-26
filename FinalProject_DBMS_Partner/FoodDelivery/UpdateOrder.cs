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
    public partial class UpdateOrder : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string MaDon;
        string TinhTrang;
        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from DONDATHANG d, DON_CUAHANG c where d.MaDon = '" + MaDon + "' AND d.TinhTrangDon = N'"+TinhTrang+"' AND d.MaDon = c.MaDon";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvUpdateOrder.DataSource = table;
        }
        public UpdateOrder()
        {
            InitializeComponent();
            
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            MaDon = txtMaDon.Text.ToString();
            TinhTrang = txtTinhTrang.Text.ToString();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd.Connection = conn;
            string query = @"EXEC pr_UpdateStateOrder '" + MaDon + "', '" + TinhTrang + "'";
            cmd.CommandText = query;
            int reader = cmd.ExecuteNonQuery();
            if (reader == -1)
            {
                MessageBox.Show("Thông tin không hợp lệ", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cập nhật thành công");
                loadData();
            }          
        }

        
    }
}
