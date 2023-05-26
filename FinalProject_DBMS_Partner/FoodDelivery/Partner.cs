using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDelivery
{
    public partial class Partner : Form
    {
        public Partner()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void btn_ThongTinDoiTac_Click(object sender, EventArgs e)
        {
            loadForm(new PartnerInformation());
        }

        private void btn_ThongTinHopDong_Click(object sender, EventArgs e)
        {
            loadForm(new ContractInformation());
        }

        private void tn_DanhSachCuaHang_Click(object sender, EventArgs e)
        {
            loadForm(new Store());
        }

       
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
