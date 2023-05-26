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
    public partial class NhanDon_TX : Form
    {
        string maTX;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN2;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string maDon;
        string maKH;
        public NhanDon_TX(string matx)
        {
            maTX = matx;
            InitializeComponent();
            loadData();
        }

        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "EXEC pr_DisplayOrderByArea '"+maTX+"'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            ds_donhang.DataSource = table;
        }

        private void ds_donhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = ds_donhang.CurrentRow.Index;
            diachicuahang.Text = ds_donhang.Rows[i].Cells[2].Value.ToString() + ", " + ds_donhang.Rows[i].Cells[3].Value.ToString() + ", " + ds_donhang.Rows[i].Cells[4].Value.ToString() + ", " + ds_donhang.Rows[i].Cells[5].Value.ToString();
            diachigiaohang.Text = ds_donhang.Rows[i].Cells[6].Value.ToString();
            phivanchuyen.Text = ds_donhang.Rows[i].Cells[8].Value.ToString();
            thanhtien.Text = ds_donhang.Rows[i].Cells[9].Value.ToString();
            maDon = ds_donhang.Rows[i].Cells[0].Value.ToString();
            maKH = ds_donhang.Rows[i].Cells[10].Value.ToString();
        }

        private void btn_chitietdon_Click(object sender, EventArgs e)
        {
            TTKhachHang_TX ttkh = new TTKhachHang_TX(maKH);
            ttkh.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_huydon_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.Connection = conn;
            string query = @"EXEC SP_CAPNHATTAIXEDONHANG '" + maTX + "', '" + maDon + "'";
            cmd.CommandText = query;
            int reader = cmd.ExecuteNonQuery();
            if (reader == -1)
            {
                MessageBox.Show("Tài xế không tồn tại", "Nhận đơn hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (reader == -2)
            {
                MessageBox.Show("Đơn hàng không tồn tại", "Nhận đơn hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (reader == -3)
            {
                MessageBox.Show("Đơn hàng chưa xác nhận hoặc đã được tài xế khác nhận", "Nhận đơn hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Nhận đơn hàng thành công");
                loadData();
            }
        }
    }
}
