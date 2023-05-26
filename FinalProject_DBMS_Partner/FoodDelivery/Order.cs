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
    public partial class Order : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string MaCH;
        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from DONDATHANG d, DON_CUAHANG c where MaCuaHang = '" + MaCH + "' AND d.MaDon = c.MaDon";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvOrder.DataSource = table;
        }
        
        public Order()
        {
            InitializeComponent();
        }

        private void btn_ThongTinDonHang_Click(object sender, EventArgs e)
        {
            MaCH = txtMaCuaHang.Text;
            loadData();
        }

        private void btn_CapNhatDonHang_Click(object sender, EventArgs e)
        {
            UpdateOrder upt = new UpdateOrder();
            upt.Show();

        }

        
    }
}
