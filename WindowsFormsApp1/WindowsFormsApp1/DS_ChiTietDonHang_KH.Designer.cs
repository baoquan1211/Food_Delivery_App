namespace WindowsFormsApp1
{
    partial class DS_ChiTietDonHang_KH
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.soluong = new System.Windows.Forms.TextBox();
            this.diemdanhgia = new System.Windows.Forms.TextBox();
            this.tuychon = new System.Windows.Forms.TextBox();
            this.tenmonan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.ds_Monan_KH = new System.Windows.Forms.DataGridView();
            this.danhgia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Monan_KH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.danhgia);
            this.groupBox1.Controls.Add(this.soluong);
            this.groupBox1.Controls.Add(this.diemdanhgia);
            this.groupBox1.Controls.Add(this.tuychon);
            this.groupBox1.Controls.Add(this.tenmonan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 132);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // soluong
            // 
            this.soluong.Location = new System.Drawing.Point(461, 84);
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            this.soluong.Size = new System.Drawing.Size(223, 22);
            this.soluong.TabIndex = 10;
            // 
            // diemdanhgia
            // 
            this.diemdanhgia.Location = new System.Drawing.Point(461, 15);
            this.diemdanhgia.Name = "diemdanhgia";
            this.diemdanhgia.Size = new System.Drawing.Size(223, 22);
            this.diemdanhgia.TabIndex = 9;
            this.diemdanhgia.TextChanged += new System.EventHandler(this.gia_TextChanged);
            // 
            // tuychon
            // 
            this.tuychon.Location = new System.Drawing.Point(114, 81);
            this.tuychon.Name = "tuychon";
            this.tuychon.ReadOnly = true;
            this.tuychon.Size = new System.Drawing.Size(223, 22);
            this.tuychon.TabIndex = 8;
            // 
            // tenmonan
            // 
            this.tenmonan.Location = new System.Drawing.Point(114, 15);
            this.tenmonan.Name = "tenmonan";
            this.tenmonan.ReadOnly = true;
            this.tenmonan.Size = new System.Drawing.Size(223, 22);
            this.tenmonan.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng đặt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm đánh giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tùy chọn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên món ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(254, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 34);
            this.label2.TabIndex = 35;
            this.label2.Text = "Chi tiết đơn hàng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 34;
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_close.Location = new System.Drawing.Point(765, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 35);
            this.btn_close.TabIndex = 38;
            this.btn_close.TabStop = false;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // ds_Monan_KH
            // 
            this.ds_Monan_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ds_Monan_KH.Location = new System.Drawing.Point(36, 219);
            this.ds_Monan_KH.Name = "ds_Monan_KH";
            this.ds_Monan_KH.ReadOnly = true;
            this.ds_Monan_KH.RowHeadersWidth = 51;
            this.ds_Monan_KH.RowTemplate.Height = 24;
            this.ds_Monan_KH.Size = new System.Drawing.Size(763, 202);
            this.ds_Monan_KH.TabIndex = 37;
            this.ds_Monan_KH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ds_Monan_KH_CellContentClick);
            // 
            // danhgia
            // 
            this.danhgia.Location = new System.Drawing.Point(726, 30);
            this.danhgia.Name = "danhgia";
            this.danhgia.Size = new System.Drawing.Size(70, 70);
            this.danhgia.TabIndex = 46;
            this.danhgia.Text = "Đánh giá";
            this.danhgia.UseVisualStyleBackColor = true;
            this.danhgia.Click += new System.EventHandler(this.danhgia_Click);
            // 
            // DS_ChiTietDonHang_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.ds_Monan_KH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DS_ChiTietDonHang_KH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DS_ChiTietDonHang_KH";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Monan_KH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox soluong;
        private System.Windows.Forms.TextBox diemdanhgia;
        private System.Windows.Forms.TextBox tuychon;
        private System.Windows.Forms.TextBox tenmonan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridView ds_Monan_KH;
        private System.Windows.Forms.Button danhgia;
    }
}