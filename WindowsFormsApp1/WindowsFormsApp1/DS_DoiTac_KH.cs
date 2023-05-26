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

namespace WindowsFormsApp1
{
    public partial class DS_DoiTac_KH : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN2;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string mach;
        string maKH;
        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select MaCuaHang as N'Mã cửa hàng', TenCuaHang as N'Tên cửa hàng', ThoiGianHoatDong as N'Thời gian hoạt động', TenDuong as N'Số/ Đường', Phuong as N'Phường', Quan as N'Quận', ThanhPho as N'Thành Phố'  from CUAHANG where TinhTrang=N'bình thường'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            ds_doitac.DataSource = table;
        }
        public DS_DoiTac_KH(string maKH)
        {   
            this.maKH = maKH;
            InitializeComponent();
            loadData();
            this.maKH = maKH;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = ds_doitac.CurrentRow.Index;
            tencuahang.Text = ds_doitac.Rows[i].Cells[1].Value.ToString();
            diachi.Text = ds_doitac.Rows[i].Cells[3].Value.ToString() + ", " + ds_doitac.Rows[i].Cells[4].Value.ToString() + ", " + ds_doitac.Rows[i].Cells[5].Value.ToString() + ", " + ds_doitac.Rows[i].Cells[6].Value.ToString();
            tghoatdong.Text = ds_doitac.Rows[i].Cells[2].Value.ToString();
            mach = ds_doitac.Rows[i].Cells[0].Value.ToString();
        }
        private void tinhtrang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DS_Sanpham_KH dsSanpham = new DS_Sanpham_KH(maKH, mach);
            dsSanpham.Show();
        }
    }
}
