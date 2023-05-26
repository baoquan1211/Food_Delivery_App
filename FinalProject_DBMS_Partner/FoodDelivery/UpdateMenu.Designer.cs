namespace FoodDelivery
{
    partial class UpdateMenu
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
            this.dgvUpdateMenu = new System.Windows.Forms.DataGridView();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMieuTa = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtMieuTa = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateMenu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUpdateMenu
            // 
            this.dgvUpdateMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgvUpdateMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateMenu.Location = new System.Drawing.Point(26, 268);
            this.dgvUpdateMenu.Name = "dgvUpdateMenu";
            this.dgvUpdateMenu.RowHeadersWidth = 62;
            this.dgvUpdateMenu.RowTemplate.Height = 28;
            this.dgvUpdateMenu.Size = new System.Drawing.Size(731, 225);
            this.dgvUpdateMenu.TabIndex = 11;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_CapNhat.Location = new System.Drawing.Point(788, 116);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(221, 72);
            this.btn_CapNhat.TabIndex = 10;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTinhTrang);
            this.groupBox2.Controls.Add(this.lblMieuTa);
            this.groupBox2.Controls.Add(this.lblGia);
            this.groupBox2.Controls.Add(this.txtTinhTrang);
            this.groupBox2.Controls.Add(this.lblTenMon);
            this.groupBox2.Controls.Add(this.txtGia);
            this.groupBox2.Controls.Add(this.txtMieuTa);
            this.groupBox2.Controls.Add(this.txtTenMon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.groupBox2.Location = new System.Drawing.Point(26, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 172);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật thực đơn";
            // 
            // lblMieuTa
            // 
            this.lblMieuTa.AutoSize = true;
            this.lblMieuTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMieuTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblMieuTa.Location = new System.Drawing.Point(353, 50);
            this.lblMieuTa.Name = "lblMieuTa";
            this.lblMieuTa.Size = new System.Drawing.Size(76, 25);
            this.lblMieuTa.TabIndex = 1;
            this.lblMieuTa.Text = "Miêu tả";
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTenMon.Location = new System.Drawing.Point(18, 50);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(91, 25);
            this.lblTenMon.TabIndex = 1;
            this.lblTenMon.Text = "Tên Món";
            // 
            // txtMieuTa
            // 
            this.txtMieuTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMieuTa.Location = new System.Drawing.Point(477, 50);
            this.txtMieuTa.Name = "txtMieuTa";
            this.txtMieuTa.Size = new System.Drawing.Size(192, 30);
            this.txtMieuTa.TabIndex = 0;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.Location = new System.Drawing.Point(126, 50);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(192, 30);
            this.txtTenMon.TabIndex = 0;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(126, 122);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(192, 30);
            this.txtGia.TabIndex = 0;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.Location = new System.Drawing.Point(477, 122);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(192, 30);
            this.txtTinhTrang.TabIndex = 0;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblGia.Location = new System.Drawing.Point(18, 122);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(42, 25);
            this.lblGia.TabIndex = 1;
            this.lblGia.Text = "Giá";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTinhTrang.Location = new System.Drawing.Point(353, 122);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(100, 25);
            this.lblTinhTrang.TabIndex = 1;
            this.lblTinhTrang.Text = "Tình trạng";
            // 
            // UpdateMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 676);
            this.Controls.Add(this.dgvUpdateMenu);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.groupBox2);
            this.Name = "UpdateMenu";
            this.Text = "UpdateMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateMenu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpdateMenu;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMieuTa;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtMieuTa;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.TextBox txtGia;
    }
}