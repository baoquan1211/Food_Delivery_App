using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoiTac
{
    public partial class MainScreen : Form
    {
        string taiKhoan;
        string maTX;
        public MainScreen(string taikhoan, string matx)
        {
            taiKhoan = taikhoan;
            maTX = matx;
            InitializeComponent();
        }

        public void loadForm(object Form)
        {

            if (this.Main.Controls.Count > 0)
                this.Main.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Main.Controls.Add(f);
            this.Main.Tag = f;
            f.Show();
        }

        private void btn_dathang_Click(object sender, EventArgs e)
        {
            loadForm(new NhanDon_TX(maTX));
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            loadForm(new TaiKhoan_TX(taiKhoan, maTX));
        }

        private void btn_donhang_Click(object sender, EventArgs e)
        {
            loadForm(new DonDaNhan_TX(maTX));
        }
    }
}
