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
    public partial class ContractInformation : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string MaHD;
        string MaDT;
        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from HOPDONG where MaHopDong = N'"+MaHD+"' AND MaDoiTac = N'"+MaDT+"' ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvContractInformation.DataSource = table;
        }
        public ContractInformation()
        {
            InitializeComponent();
            
        }

        private void btn_XemThongTin_Click(object sender, EventArgs e)
        {
            MaHD = txtMaHopDong.Text;
            MaDT = txtMaDoiTac.Text;
            loadData();
        }

        
    }
}
    