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
    public partial class ChiTietDonHang_TX : Form
    {
        string maDon;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN2;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public ChiTietDonHang_TX(string madon)
        {
            maDon = madon;
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select M.TenMon as N'Tên Món', CT.TuyChon as N'Tùy chọn', M.Gia as N'Giá', CT.SoLuong as N'Số lượng' from CHITIETDON CT join MONAN M on CT.MaDon = '" + maDon + "' AND CT.MaMon = M.MaMon";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            ds_Monan_KH.DataSource = table;
        }
        private void ds_Monan_KH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = ds_Monan_KH.CurrentRow.Index;
            tenmonan.Text = ds_Monan_KH.Rows[i].Cells[0].Value.ToString();
            tuychon.Text = ds_Monan_KH.Rows[i].Cells[1].Value.ToString();
            soluong.Text = ds_Monan_KH.Rows[i].Cells[3].Value.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
