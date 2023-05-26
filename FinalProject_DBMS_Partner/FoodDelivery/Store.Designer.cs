namespace FoodDelivery
{
    partial class Store
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
            this.lblMaDoiTac = new System.Windows.Forms.Label();
            this.txtMaDoiTac = new System.Windows.Forms.TextBox();
            this.dgvStore = new System.Windows.Forms.DataGridView();
            this.btn_ThongTinCuaHang = new System.Windows.Forms.Button();
            this.btn_ThongTinDonHang = new System.Windows.Forms.Button();
            this.btn_ThucDon = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMaDoiTac);
            this.groupBox2.Controls.Add(this.txtMaDoiTac);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 211);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cửa hàng";
            // 
            // lblMaDoiTac
            // 
            this.lblMaDoiTac.AutoSize = true;
            this.lblMaDoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDoiTac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblMaDoiTac.Location = new System.Drawing.Point(27, 69);
            this.lblMaDoiTac.Name = "lblMaDoiTac";
            this.lblMaDoiTac.Size = new System.Drawing.Size(102, 25);
            this.lblMaDoiTac.TabIndex = 1;
            this.lblMaDoiTac.Text = "Mã đối tác";
            // 
            // txtMaDoiTac
            // 
            this.txtMaDoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDoiTac.Location = new System.Drawing.Point(174, 69);
            this.txtMaDoiTac.Name = "txtMaDoiTac";
            this.txtMaDoiTac.Size = new System.Drawing.Size(192, 30);
            this.txtMaDoiTac.TabIndex = 0;
            // 
            // dgvStore
            // 
            this.dgvStore.BackgroundColor = System.Drawing.Color.White;
            this.dgvStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStore.Location = new System.Drawing.Point(12, 306);
            this.dgvStore.Name = "dgvStore";
            this.dgvStore.RowHeadersWidth = 62;
            this.dgvStore.RowTemplate.Height = 28;
            this.dgvStore.Size = new System.Drawing.Size(789, 239);
            this.dgvStore.TabIndex = 3;
            // 
            // btn_ThongTinCuaHang
            // 
            this.btn_ThongTinCuaHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_ThongTinCuaHang.Location = new System.Drawing.Point(818, 91);
            this.btn_ThongTinCuaHang.Name = "btn_ThongTinCuaHang";
            this.btn_ThongTinCuaHang.Size = new System.Drawing.Size(221, 72);
            this.btn_ThongTinCuaHang.TabIndex = 4;
            this.btn_ThongTinCuaHang.Text = "Thông tin cửa hàng ";
            this.btn_ThongTinCuaHang.UseVisualStyleBackColor = false;
            this.btn_ThongTinCuaHang.Click += new System.EventHandler(this.btn_XemThongTinCuaHang_Click);
            // 
            // btn_ThongTinDonHang
            // 
            this.btn_ThongTinDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_ThongTinDonHang.Location = new System.Drawing.Point(818, 258);
            this.btn_ThongTinDonHang.Name = "btn_ThongTinDonHang";
            this.btn_ThongTinDonHang.Size = new System.Drawing.Size(221, 72);
            this.btn_ThongTinDonHang.TabIndex = 5;
            this.btn_ThongTinDonHang.Text = "Thông tin đơn hàng";
            this.btn_ThongTinDonHang.UseVisualStyleBackColor = false;
            this.btn_ThongTinDonHang.Click += new System.EventHandler(this.btn_ThongTinDonHang_Click);
            // 
            // btn_ThucDon
            // 
            this.btn_ThucDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_ThucDon.Location = new System.Drawing.Point(818, 418);
            this.btn_ThucDon.Name = "btn_ThucDon";
            this.btn_ThucDon.Size = new System.Drawing.Size(221, 72);
            this.btn_ThucDon.TabIndex = 6;
            this.btn_ThucDon.Text = "Thực đơn";
            this.btn_ThucDon.UseVisualStyleBackColor = false;
            this.btn_ThucDon.Click += new System.EventHandler(this.btn_ThucDon_Click);
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 732);
            this.Controls.Add(this.btn_ThucDon);
            this.Controls.Add(this.btn_ThongTinDonHang);
            this.Controls.Add(this.btn_ThongTinCuaHang);
            this.Controls.Add(this.dgvStore);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Store";
            this.Text = "Store";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMaDoiTac;
        private System.Windows.Forms.TextBox txtMaDoiTac;
        private System.Windows.Forms.DataGridView dgvStore;
        private System.Windows.Forms.Button btn_ThongTinCuaHang;
        private System.Windows.Forms.Button btn_ThongTinDonHang;
        private System.Windows.Forms.Button btn_ThucDon;
    }
}