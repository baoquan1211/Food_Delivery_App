using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoiTac
{
    public partial class DonDaNhan_TX : Form
    {
        string maTX;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN2;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string maDon;
        string maKH;
        public DonDaNhan_TX(string matx)
        {
            maTX = matx;
            InitializeComponent();
            loadData(); 
        }
        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select D.MaDon as N'Mã đơn hàng', D.NgayLap as N'Ngày lập', D.HinhThucTT as N'Hình thức thanh toán', D.DiaChiGiaoHang as N'Địa chỉ giao hàng', D.PhiVanChuyen as N'Phí vận chuyển', D.ThanhTien as N'Thành tiền' from DONDATHANG D where MaTX = '" + maTX + "'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            ds_donhang.DataSource = table;
        }
        private void btn_chitietdon_Click(object sender, EventArgs e)
        {
            ChiTietDonHang_TX ctietdon = new ChiTietDonHang_TX(maDon);
            ctietdon.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ds_donhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = ds_donhang.CurrentRow.Index;
            hinhthucthanhtoan.Text = ds_donhang.Rows[i].Cells[2].Value.ToString();
            diachigiaohang.Text = ds_donhang.Rows[i].Cells[3].Value.ToString();
            phivanchuyen.Text = ds_donhang.Rows[i].Cells[4].Value.ToString();
            thanhtien.Text = ds_donhang.Rows[i].Cells[5].Value.ToString();
            maDon = ds_donhang.Rows[i].Cells[0].Value.ToString();
        }

        private void btn_dagiao_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.Connection = conn;
            string query = @"EXEC pr_Delivered '" + maDon + "'";
            cmd.CommandText = query;
            int reader = cmd.ExecuteNonQuery();
            if (reader == -1)
            {
                MessageBox.Show("Thông tin sai", "Xác nhận thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (reader == -2)
            {
                MessageBox.Show("Đơn hàng không tồn tại", "Xác nhận thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Xác nhận đã giao thành công");
            }
        }
    }
}
