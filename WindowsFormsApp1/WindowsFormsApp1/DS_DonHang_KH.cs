using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DS_DonHang_KH : Form
    {
        string maKH;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN2;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string madon;
        public DS_DonHang_KH(string makh)
        {
            maKH = makh;
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select MaDon, NgayLap, DiaChiGiaohang, HinhThucTT, TinhTrangDon, PhiVanChuyen, ThanhTien from DONDATHANG where MaKH = '"+maKH+"'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            ds_donhang.DataSource = table;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {

        }

        private void ds_donhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = ds_donhang.CurrentRow.Index;
            hinhthucthanhtoan.Text = ds_donhang.Rows[i].Cells[3].Value.ToString();
            diachigiaohang.Text = ds_donhang.Rows[i].Cells[2].Value.ToString();
            phivanchuyen.Text = ds_donhang.Rows[i].Cells[5].Value.ToString();
            thanhtien.Text = ds_donhang.Rows[i].Cells[6].Value.ToString();
            madon = ds_donhang.Rows[i].Cells[0].Value.ToString();
        }

        private void btn_chitietdon_Click(object sender, EventArgs e)
        {
            DS_ChiTietDonHang_KH ds_chitietdon = new DS_ChiTietDonHang_KH(maKH, madon);
            ds_chitietdon.Show();
        }

        private void btn_huydon_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.Connection = conn;
            string query = @"EXEC pr_DelOrder '"+madon+"'";
            cmd.CommandText = query;
            int reader = cmd.ExecuteNonQuery();
            if (reader == -1)
            {
                MessageBox.Show("Chỉ có thể hủy đơn có tình trạng chờ nhận", "Hủy đơn thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (reader == -2)
            {
                MessageBox.Show("Đơn hàng không tồn tại", "Hủy đơn thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Hủy đơn hàng thành công");
                loadData();
            }    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thanhtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void phivanchuyen_TextChanged(object sender, EventArgs e)
        {

        }

        private void diachigiaohang_TextChanged(object sender, EventArgs e)
        {

        }

        private void hinhthucthanhtoan_TextChanged(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
