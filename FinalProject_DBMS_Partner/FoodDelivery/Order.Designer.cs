namespace FoodDelivery
{
    partial class Order
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMaCuaHang = new System.Windows.Forms.Label();
            this.txtMaCuaHang = new System.Windows.Forms.TextBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btn_ThongTinDonHang = new System.Windows.Forms.Button();
            this.btn_CapNhatDonHang = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMaCuaHang);
            this.groupBox2.Controls.Add(this.txtMaCuaHang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.groupBox2.Location = new System.Drawing.Point(23, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 172);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đơn hàng";
            // 
            // lblMaCuaHang
            // 
            this.lblMaCuaHang.AutoSize = true;
            this.lblMaCuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCuaHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblMaCuaHang.Location = new System.Drawing.Point(18, 50);
            this.lblMaCuaHang.Name = "lblMaCuaHang";
            this.lblMaCuaHang.Size = new System.Drawing.Size(126, 25);
            this.lblMaCuaHang.TabIndex = 1;
            this.lblMaCuaHang.Text = "Mã cửa hàng";
            // 
            // txtMaCuaHang
            // 
            this.txtMaCuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCuaHang.Location = new System.Drawing.Point(180, 50);
            this.txtMaCuaHang.Name = "txtMaCuaHang";
            this.txtMaCuaHang.Size = new System.Drawing.Size(192, 30);
            this.txtMaCuaHang.TabIndex = 0;
            // 
            // dgvOrder
            // 
            this.dgvOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(23, 245);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 62;
            this.dgvOrder.RowTemplate.Height = 28;
            this.dgvOrder.Size = new System.Drawing.Size(731, 266);
            this.dgvOrder.TabIndex = 4;
            
            // 
            // btn_ThongTinDonHang
            // 
            this.btn_ThongTinDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_ThongTinDonHang.Location = new System.Drawing.Point(804, 87);
            this.btn_ThongTinDonHang.Name = "btn_ThongTinDonHang";
            this.btn_ThongTinDonHang.Size = new System.Drawing.Size(221, 72);
            this.btn_ThongTinDonHang.TabIndex = 5;
            this.btn_ThongTinDonHang.Text = "Thông tin đơn hàng";
            this.btn_ThongTinDonHang.UseVisualStyleBackColor = false;
            this.btn_ThongTinDonHang.Click += new System.EventHandler(this.btn_ThongTinDonHang_Click);
            // 
            // btn_CapNhatDonHang
            // 
            this.btn_CapNhatDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_CapNhatDonHang.Location = new System.Drawing.Point(804, 262);
            this.btn_CapNhatDonHang.Name = "btn_CapNhatDonHang";
            this.btn_CapNhatDonHang.Size = new System.Drawing.Size(221, 72);
            this.btn_CapNhatDonHang.TabIndex = 6;
            this.btn_CapNhatDonHang.Text = "Cập nhật đơn hàng";
            this.btn_CapNhatDonHang.UseVisualStyleBackColor = false;
            this.btn_CapNhatDonHang.Click += new System.EventHandler(this.btn_CapNhatDonHang_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 676);
            this.Controls.Add(this.btn_CapNhatDonHang);
            this.Controls.Add(this.btn_ThongTinDonHang);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.groupBox2);
            this.Name = "Order";
            this.Text = "Order";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMaCuaHang;
        private System.Windows.Forms.TextBox txtMaCuaHang;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btn_ThongTinDonHang;
        private System.Windows.Forms.Button btn_CapNhatDonHang;
    }
}