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
    public partial class DS_ChiTietDonHang_KH : Form
    {
        string maDon;
        string maKH;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN2;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string mamon, tchon;
        public DS_ChiTietDonHang_KH(string makh, string madon)
        {
            maKH = makh;
            maDon = madon; 
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select M.MaMon as 'Mã Món', M.TenMon as N'Tên Món', CT.TuyChon as N'Tùy chọn', M.Gia as N'Giá', CT.SoLuong as N'Số lượng' from CHITIETDON CT join MONAN M on CT.MaDon = '"+maDon+"' AND CT.MaMon = M.MaMon";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            ds_Monan_KH.DataSource = table;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gia_TextChanged(object sender, EventArgs e)
        {

        }

        private void ds_Monan_KH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = ds_Monan_KH.CurrentRow.Index;
            tenmonan.Text = ds_Monan_KH.Rows[i].Cells[1].Value.ToString();
            tuychon.Text = ds_Monan_KH.Rows[i].Cells[2].Value.ToString();
            soluong.Text = ds_Monan_KH.Rows[i].Cells[4].Value.ToString();
            mamon = ds_Monan_KH.Rows[i].Cells[0].Value.ToString();
            tchon = ds_Monan_KH.Rows[i].Cells[2].Value.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void danhgia_Click(object sender, EventArgs e)
        {
            if (diemdanhgia.Text != "")
            {
                int diem = Convert.ToInt32(diemdanhgia.Text);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd.Connection = conn;
                string query = @"EXEC pr_AddFeedback '" + maKH + "', '" + mamon + "', N'" + tchon + "', " + diem + "";
                cmd.CommandText = query;
                var reader = cmd.ExecuteNonQuery();
                if (reader == -1)
                {
                    MessageBox.Show("Thông tin đầu vào không hợp lệ", "Đánh giá thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (reader == -2)
                {
                    MessageBox.Show("Mã khách hàng không tồn tại", "Đánh giá thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (reader == -3)
                {
                    MessageBox.Show("Món ăn không tồn tại", "Đánh giá thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (reader == -4)
                {
                    MessageBox.Show("Tùy chọn không tồn tại", "Đánh giá thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đánh giá món ăn thành công");
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số điểm trên thang điểm 5", "Đánh giá thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
