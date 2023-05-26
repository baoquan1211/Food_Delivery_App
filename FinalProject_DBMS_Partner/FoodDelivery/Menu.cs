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
    public partial class Menu : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string MaCH;
        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select TenMon, MieuTaMon, Gia, TinhTrangMon, MaCuaHang from MONAN where MaCuaHang = N'"+MaCH+"'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvMenu.DataSource = table;
        }
        public Menu()
        {
            InitializeComponent();

        }

        private void btn_CapNhatMonAn_Click(object sender, EventArgs e)
        {
            UpdateMenu uptMenu = new UpdateMenu();
            uptMenu.Show();
        }

        private void btn_XemPhanHoi_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback();
            f.Show();
        }

        private void btn_XemThucDon_Click(object sender, EventArgs e)
        {
            MaCH = txtMaCuaHang.Text;
            loadData();
        }


    }
}
