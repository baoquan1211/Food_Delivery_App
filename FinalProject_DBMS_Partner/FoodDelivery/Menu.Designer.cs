namespace FoodDelivery
{
    partial class Menu
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
            this.btn_CapNhatMonAn = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.btn_XemPhanHoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMaCuaHang = new System.Windows.Forms.Label();
            this.txtMaCuaHang = new System.Windows.Forms.TextBox();
            this.btn_XemThucDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CapNhatMonAn
            // 
            this.btn_CapNhatMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_CapNhatMonAn.Location = new System.Drawing.Point(863, 241);
            this.btn_CapNhatMonAn.Name = "btn_CapNhatMonAn";
            this.btn_CapNhatMonAn.Size = new System.Drawing.Size(209, 72);
            this.btn_CapNhatMonAn.TabIndex = 3;
            this.btn_CapNhatMonAn.Text = "Cập nhật món ăn";
            this.btn_CapNhatMonAn.UseVisualStyleBackColor = false;
            this.btn_CapNhatMonAn.Click += new System.EventHandler(this.btn_CapNhatMonAn_Click);
            // 
            // dgvMenu
            // 
            this.dgvMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(46, 306);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 62;
            this.dgvMenu.RowTemplate.Height = 28;
            this.dgvMenu.Size = new System.Drawing.Size(770, 298);
            this.dgvMenu.TabIndex = 4;
            // 
            // btn_XemPhanHoi
            // 
            this.btn_XemPhanHoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_XemPhanHoi.Location = new System.Drawing.Point(863, 396);
            this.btn_XemPhanHoi.Name = "btn_XemPhanHoi";
            this.btn_XemPhanHoi.Size = new System.Drawing.Size(209, 72);
            this.btn_XemPhanHoi.TabIndex = 3;
            this.btn_XemPhanHoi.Text = "Xem phản hồi";
            this.btn_XemPhanHoi.UseVisualStyleBackColor = false;
            this.btn_XemPhanHoi.Click += new System.EventHandler(this.btn_XemPhanHoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMaCuaHang);
            this.groupBox2.Controls.Add(this.txtMaCuaHang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.groupBox2.Location = new System.Drawing.Point(46, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 194);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Món ăn";
            // 
            // lblMaCuaHang
            // 
            this.lblMaCuaHang.AutoSize = true;
            this.lblMaCuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCuaHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblMaCuaHang.Location = new System.Drawing.Point(29, 58);
            this.lblMaCuaHang.Name = "lblMaCuaHang";
            this.lblMaCuaHang.Size = new System.Drawing.Size(126, 25);
            this.lblMaCuaHang.TabIndex = 1;
            this.lblMaCuaHang.Text = "Mã cửa hàng";
            // 
            // txtMaCuaHang
            // 
            this.txtMaCuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCuaHang.Location = new System.Drawing.Point(193, 58);
            this.txtMaCuaHang.Name = "txtMaCuaHang";
            this.txtMaCuaHang.Size = new System.Drawing.Size(192, 30);
            this.txtMaCuaHang.TabIndex = 0;
            // 
            // btn_XemThucDon
            // 
            this.btn_XemThucDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_XemThucDon.Location = new System.Drawing.Point(863, 80);
            this.btn_XemThucDon.Name = "btn_XemThucDon";
            this.btn_XemThucDon.Size = new System.Drawing.Size(209, 72);
            this.btn_XemThucDon.TabIndex = 3;
            this.btn_XemThucDon.Text = "Xem thực đơn";
            this.btn_XemThucDon.UseVisualStyleBackColor = false;
            this.btn_XemThucDon.Click += new System.EventHandler(this.btn_XemThucDon_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 732);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.btn_XemPhanHoi);
            this.Controls.Add(this.btn_XemThucDon);
            this.Controls.Add(this.btn_CapNhatMonAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_CapNhatMonAn;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button btn_XemPhanHoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMaCuaHang;
        private System.Windows.Forms.TextBox txtMaCuaHang;
        private System.Windows.Forms.Button btn_XemThucDon;
    }
}