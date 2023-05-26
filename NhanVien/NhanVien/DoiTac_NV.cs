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

namespace NhanVien
{
    public partial class DoiTac_NV : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN2;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string madt;
        public DoiTac_NV()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from DOITAC";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            ds_doitac.DataSource = table;
        }
        private void ds_doitac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = ds_doitac.CurrentRow.Index;
            nguoidaidienDT.Text = ds_doitac.Rows[i].Cells[3].Value.ToString();
            tennhahangDT.Text = ds_doitac.Rows[i].Cells[2].Value.ToString();
            sdtDT.Text = ds_doitac.Rows[i].Cells[9].Value.ToString();
            emailDT.Text = ds_doitac.Rows[i].Cells[1].Value.ToString();
            madt = ds_doitac.Rows[i].Cells[0].Value.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HopDong_NV hopdong = new HopDong_NV(madt);
            hopdong.Show();
        }
    }
}
