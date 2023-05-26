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
    public partial class TaiKhoan_TX : Form
    {
        string taiKhoan;
        string maTX;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G6SF4US\SQLEXPRESS;Initial Catalog=QLGIAOTHUCAN2;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        public TaiKhoan_TX(string taikhoan, string matx)
        {
            this.taiKhoan = taikhoan;   
            this.maTX = matx;
            InitializeComponent();
            loadData();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void loadData()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.Connection = conn;
            string query = @"Select * from TAIXE where MaTX = '" + maTX + "'";
            cmd.CommandText = query;
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    htenTX.Text = reader["HoTen"].ToString();
                    sdtTX.Text = reader["SDT"].ToString();
                    diachiTX.Text = reader["DiaChi"].ToString();
                    emailTX.Text = reader["Email"].ToString();
                    kvhdTX.Text = reader["KhuVucHD"].ToString();
                    bsxTX.Text = reader["BienSoXe"].ToString();
                    cmndTX.Text = reader["CMND"].ToString();
                    taikhoanTX.Text = reader["TaiKhoan"].ToString();

                }
            }
            conn.Close();
        }
        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string hoTen, diaChi, Email, Sdt, bienSo, kvHD, email, tk, cmnd;
            hoTen = htenTX.Text.ToString();
            diaChi = diachiTX.Text.ToString();
            Email = emailTX.Text.ToString();
            Sdt = sdtTX.Text.ToString();
            bienSo = bsxTX.Text.ToString();
            kvHD = kvhdTX.Text.ToString();
            tk = taikhoanTX.Text.ToString();
            cmnd = cmndTX.Text.ToString();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.Connection = conn;
            string query = @"EXEC PR_TAIXE_UPDATE '" + maTX + "', N'" + hoTen + "', '"+cmnd+"', '" + Sdt + "', N'" + diaChi + "', '"+bienSo+"', N'"+kvHD+"',N'" + Email + "', '"+tk+"'";
            cmd.CommandText = query;
            int exec = cmd.ExecuteNonQuery();
            if (exec == -1)
            {
                MessageBox.Show("Thông tin không hợp lệ, vui lòng kiểm tra lại", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (exec == -2)
            {
                MessageBox.Show("Tài xế không tồn tại", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                loadData();
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
