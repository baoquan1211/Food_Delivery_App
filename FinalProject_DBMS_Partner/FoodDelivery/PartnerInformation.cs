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
    public partial class PartnerInformation : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaDoiTac, Email, TenNhaHang, NguoiDaiDien, ThanhPho, Quan, SLChiNhanh,SLDonHang, DiaChiKinhDoanh, SDT from DOITAC";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvPartnerInformation.DataSource = table;
        }
        public PartnerInformation()
        {
            InitializeComponent();
        }

        private void PartnerInformation_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loadData();
        }

        private void dgvPartnerInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDoiTac.ReadOnly = true;
            int i;
            i = dgvPartnerInformation.CurrentRow.Index;
            txtMaDoiTac.Text = dgvPartnerInformation.Rows[i].Cells[0].Value.ToString();
            txtEmail.Text = dgvPartnerInformation.Rows[i].Cells[1].Value.ToString();
            txtTenNhaHang.Text = dgvPartnerInformation.Rows[i].Cells[2].Value.ToString();
            txtNguoiDaiDien.Text = dgvPartnerInformation.Rows[i].Cells[3].Value.ToString();
            txtThanhPho.Text = dgvPartnerInformation.Rows[i].Cells[4].Value.ToString();
            txtQuan.Text = dgvPartnerInformation.Rows[i].Cells[5].Value.ToString();
            txtSLChiNhanh.Text = dgvPartnerInformation.Rows[i].Cells[6].Value.ToString();
            txtSLDonHang.Text = dgvPartnerInformation.Rows[i].Cells[7].Value.ToString();
            txtDiaChi.Text = dgvPartnerInformation.Rows[i].Cells[8].Value.ToString();
            txtSDT.Text = dgvPartnerInformation.Rows[i].Cells[9].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sInsert = "insert into DOITAC values (@MaDoiTac, @Email, @TenNhaHang, @NguoiDaiDien, @ThanhPho, @Quan, @SLChiNhanh, @SLDonHang, @DiaChiKinhDoanh, @SDT)";
            SqlCommand cmd = new SqlCommand(sInsert, conn);
            cmd.Parameters.AddWithValue("MaDoiTac", txtMaDoiTac.Text);
            cmd.Parameters.AddWithValue("Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("TenNhaHang", txtTenNhaHang.Text);
            cmd.Parameters.AddWithValue("NguoiDaiDien", txtNguoiDaiDien.Text);
            cmd.Parameters.AddWithValue("ThanhPho", txtThanhPho.Text);
            cmd.Parameters.AddWithValue("Quan", txtQuan.Text);
            cmd.Parameters.AddWithValue("SLChiNhanh", txtSLChiNhanh.Text);
            cmd.Parameters.AddWithValue("SLDonHang", txtSLDonHang.Text);
            cmd.Parameters.AddWithValue("DiaChiKinhDoanh", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("SDT", txtSDT.Text);
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sDelete = "delete from DOITAC where MaDoiTac = @MaDoiTac";
            SqlCommand cmd = new SqlCommand(sDelete, conn);
            cmd.Parameters.AddWithValue("MaDoiTac", txtMaDoiTac.Text);
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sUpdate = "update DOITAC set Email = @email, TenNhaHang = @TenNhaHang, NguoiDaiDien = @NguoiDaiDien, ThanhPho = @ThanhPho, Quan = @Quan, SLChiNhanh = @SLChiNhanh, SLDonHang = @SLDonHang, DiaChiKinhDoanh = @DiaChiKinhDoanh, SDT = @SDT where MaDoiTac = @MaDoiTac";
            SqlCommand cmd = new SqlCommand(sUpdate, conn);
            cmd.Parameters.AddWithValue("MaDoiTac", txtMaDoiTac.Text);
            cmd.Parameters.AddWithValue("Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("TenNhaHang", txtTenNhaHang.Text);
            cmd.Parameters.AddWithValue("NguoiDaiDien", txtNguoiDaiDien.Text);
            cmd.Parameters.AddWithValue("ThanhPho", txtThanhPho.Text);
            cmd.Parameters.AddWithValue("Quan", txtQuan.Text);
            cmd.Parameters.AddWithValue("SLChiNhanh", txtSLChiNhanh.Text);
            cmd.Parameters.AddWithValue("SLDonHang", txtSLDonHang.Text);
            cmd.Parameters.AddWithValue("DiaChiKinhDoanh", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("SDT", txtSDT.Text);
            cmd.ExecuteNonQuery();
            loadData();
        }
    }
}
