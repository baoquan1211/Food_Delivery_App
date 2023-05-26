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
    public partial class Feedback : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string TenMon;
        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from PHANHOI where TenMon = N'" + TenMon + "'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvFeedback.DataSource = table;
        }
        public Feedback()
        {
            InitializeComponent();
        }

        private void btn_XemPhanHoi_Click(object sender, EventArgs e)
        {
            TenMon = txtTenMon.Text;
            loadData();
        }
    }
}
