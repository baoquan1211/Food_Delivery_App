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
    public partial class DS_Sanpham_KH : Form
    {
        string maCH;
        string maKH;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN2;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string mamon;
        public DS_Sanpham_KH(string makh, string mach)
        {
            maKH = makh;
            maCH = mach;
            InitializeComponent();
            loadData();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "EXEC pr_MonAn_BinhThuong '"+maCH+"'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            ds_Monan_KH.DataSource = table;
        }

        void countData()
        {

        }

        private void ds_Monan_KH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = ds_Monan_KH.CurrentRow.Index;
            tenmonan.Text = ds_Monan_KH.Rows[i].Cells[1].Value.ToString();
            mieuta.Text = ds_Monan_KH.Rows[i].Cells[2].Value.ToString();
            gia.Text = ds_Monan_KH.Rows[i].Cells[3].Value.ToString();
            mamon = ds_Monan_KH.Rows[i].Cells[0].Value.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (soluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng", "Đặt hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int sl = Convert.ToInt32(soluong.Text);
                DatHang_KH dathang = new DatHang_KH(maKH, mamon, sl);
                dathang.Show();
            }
        }
    }
}
