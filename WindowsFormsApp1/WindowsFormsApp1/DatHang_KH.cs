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
using System.Data.SqlClient; 

namespace WindowsFormsApp1
{
    public partial class DatHang_KH : Form
    {
        string maMon;
        string maKH;
        string maDon;
        string tenMon;
        int soLuong;
        string tuyChon;
        string htThanhtoan;
        string diaChi;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN2;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        
        public DatHang_KH(string makh, string mamon, int soluong)
        {
            maKH = makh; 
            maMon = mamon;
            soLuong = soluong;
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select M.TenMon as N'Tên món', TC.TuyChon as N'Tùy chọn' from MONAN M JOIN TUYCHONMON TC ON M.MaMon = '"+maMon+"' AND M.MaMon = TC.MaMon";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dstuychon.DataSource = table;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dstuychon.CurrentRow.Index;
            tuyChon = dstuychon.Rows[i].Cells[1].Value.ToString();
        }

        private void diachigiaohang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_datmon_Click(object sender, EventArgs e)
        {
            if (mdon.Text != "")
            {
                if (diachigiaohang.Text != "")
                {
                    if (hinhthuctt.Text != "")
                    {
                        maDon = mdon.Text;
                        diaChi = diachigiaohang.Text;
                        htThanhtoan = hinhthuctt.Text;
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        cmd.Connection = conn;
                        string query = @"EXEC pr_AddOrder  '" + maDon + "', '" + maKH + "', '" + maMon + "', N'" + tuyChon + "', " + soLuong + ", N'" + htThanhtoan + "', N'"+diaChi+"'";
                        cmd.CommandText = query;
                        var reader = cmd.ExecuteNonQuery();
                        if (reader == -1)
                        {
                            MessageBox.Show("Thông tin đầu vào không hợp lệ", "Đặt hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (reader == -2)
                        {
                            MessageBox.Show("Mã khách hàng không tồn tại", "Đặt hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (reader == -3)
                        {
                            MessageBox.Show("Món ăn không tồn tại", "Đặt hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (reader == -4)
                        {
                            MessageBox.Show("Tùy chọn không tồn tại", "Đặt hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Đặt món thành công");
                            loadData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn hình thức thanh toán", "Đặt hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền địa chỉ giao hàng", "Đặt hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền mã đơn", "Đặt hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
