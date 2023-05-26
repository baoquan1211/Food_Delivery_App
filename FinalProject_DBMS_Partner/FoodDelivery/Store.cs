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
    public partial class Store : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string MaDT;
        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from CUAHANG where MaDoiTac = '"+MaDT+"'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvStore.DataSource = table;
        }
        
        public Store()
        {
            InitializeComponent();
            
            
        }

        private void btn_XemThongTinCuaHang_Click(object sender, EventArgs e)
        {
            MaDT = txtMaDoiTac.Text;
            loadData();
        }

        private void btn_ThucDon_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
        }

        private void btn_ThongTinDonHang_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Show();
        }
    }
}
