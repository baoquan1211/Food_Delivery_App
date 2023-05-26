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
using System.Net;

namespace WindowsFormsApp1
{
    public partial class Khachhang : Form
    {
        string taiKhoan;
        string maKH;
        public Khachhang(string taikhoan, string makh)
        {
            taiKhoan = taikhoan;
            maKH = makh;
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
           
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadForm(new DS_DoiTac_KH(maKH));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadForm(new TaiKhoan_KH(taiKhoan, maKH));
        }

        private void btn_donhang_Click(object sender, EventArgs e)
        {
            loadForm(new DS_DonHang_KH(maKH));
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
