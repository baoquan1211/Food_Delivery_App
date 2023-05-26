namespace DoiTac
{
    partial class NhanDon_TX
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ds_donhang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_huydon = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.thanhtien = new System.Windows.Forms.TextBox();
            this.btn_chitietdon = new System.Windows.Forms.Button();
            this.phivanchuyen = new System.Windows.Forms.TextBox();
            this.diachigiaohang = new System.Windows.Forms.TextBox();
            this.diachicuahang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ds_donhang)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ds_donhang
            // 
            this.ds_donhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ds_donhang.Location = new System.Drawing.Point(3, 3);
            this.ds_donhang.Name = "ds_donhang";
            this.ds_donhang.ReadOnly = true;
            this.ds_donhang.RowHeadersWidth = 51;
            this.ds_donhang.RowTemplate.Height = 24;
            this.ds_donhang.Size = new System.Drawing.Size(799, 323);
            this.ds_donhang.TabIndex = 2;
            this.ds_donhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ds_donhang_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_huydon);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.thanhtien);
            this.panel1.Controls.Add(this.btn_chitietdon);
            this.panel1.Controls.Add(this.phivanchuyen);
            this.panel1.Controls.Add(this.diachigiaohang);
            this.panel1.Controls.Add(this.diachicuahang);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 280);
            this.panel1.TabIndex = 1;
            // 
            // btn_huydon
            // 
            this.btn_huydon.Location = new System.Drawing.Point(649, 151);
            this.btn_huydon.Name = "btn_huydon";
            this.btn_huydon.Size = new System.Drawing.Size(70, 70);
            this.btn_huydon.TabIndex = 44;
            this.btn_huydon.Text = "Nhận đơn";
            this.btn_huydon.UseVisualStyleBackColor = true;
            this.btn_huydon.Click += new System.EventHandler(this.btn_huydon_Click);
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_close.Location = new System.Drawing.Point(727, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 35);
            this.btn_close.TabIndex = 42;
            this.btn_close.TabStop = false;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // thanhtien
            // 
            this.thanhtien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.thanhtien.Location = new System.Drawing.Point(320, 197);
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            this.thanhtien.Size = new System.Drawing.Size(223, 22);
            this.thanhtien.TabIndex = 41;
            // 
            // btn_chitietdon
            // 
            this.btn_chitietdon.Location = new System.Drawing.Point(649, 56);
            this.btn_chitietdon.Name = "btn_chitietdon";
            this.btn_chitietdon.Size = new System.Drawing.Size(70, 70);
            this.btn_chitietdon.TabIndex = 40;
            this.btn_chitietdon.Text = "Thông tin KH";
            this.btn_chitietdon.UseVisualStyleBackColor = true;
            this.btn_chitietdon.Click += new System.EventHandler(this.btn_chitietdon_Click);
            // 
            // phivanchuyen
            // 
            this.phivanchuyen.Location = new System.Drawing.Point(320, 75);
            this.phivanchuyen.Name = "phivanchuyen";
            this.phivanchuyen.ReadOnly = true;
            this.phivanchuyen.Size = new System.Drawing.Size(223, 22);
            this.phivanchuyen.TabIndex = 39;
            // 
            // diachigiaohang
            // 
            this.diachigiaohang.Location = new System.Drawing.Point(39, 197);
            this.diachigiaohang.Name = "diachigiaohang";
            this.diachigiaohang.ReadOnly = true;
            this.diachigiaohang.Size = new System.Drawing.Size(223, 22);
            this.diachigiaohang.TabIndex = 38;
            // 
            // diachicuahang
            // 
            this.diachicuahang.Location = new System.Drawing.Point(39, 75);
            this.diachicuahang.Name = "diachicuahang";
            this.diachicuahang.ReadOnly = true;
            this.diachicuahang.Size = new System.Drawing.Size(223, 22);
            this.diachicuahang.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Thành tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Phí vận chuyển";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Địa chỉ giao hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Địa chỉ cửa hàng";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ds_donhang);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 325);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(802, 327);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // NhanDon_TX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhanDon_TX";
            this.Text = "NhanDon_TX";
            ((System.ComponentModel.ISupportInitialize)(this.ds_donhang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ds_donhang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_huydon;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox thanhtien;
        private System.Windows.Forms.Button btn_chitietdon;
        private System.Windows.Forms.TextBox phivanchuyen;
        private System.Windows.Forms.TextBox diachigiaohang;
        private System.Windows.Forms.TextBox diachicuahang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}