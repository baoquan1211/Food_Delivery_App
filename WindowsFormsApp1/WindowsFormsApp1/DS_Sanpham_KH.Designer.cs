namespace WindowsFormsApp1
{
    partial class DS_Sanpham_KH
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.soluong = new System.Windows.Forms.TextBox();
            this.gia = new System.Windows.Forms.TextBox();
            this.mieuta = new System.Windows.Forms.TextBox();
            this.tenmonan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ds_Monan_KH = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Monan_KH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(252, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách món ăn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.soluong);
            this.groupBox1.Controls.Add(this.gia);
            this.groupBox1.Controls.Add(this.mieuta);
            this.groupBox1.Controls.Add(this.tenmonan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(1, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(741, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 76);
            this.button1.TabIndex = 31;
            this.button1.Text = "Đặt món";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // soluong
            // 
            this.soluong.Location = new System.Drawing.Point(492, 84);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(223, 22);
            this.soluong.TabIndex = 10;
            // 
            // gia
            // 
            this.gia.Location = new System.Drawing.Point(492, 18);
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            this.gia.Size = new System.Drawing.Size(223, 22);
            this.gia.TabIndex = 9;
            // 
            // mieuta
            // 
            this.mieuta.Location = new System.Drawing.Point(135, 84);
            this.mieuta.Name = "mieuta";
            this.mieuta.ReadOnly = true;
            this.mieuta.Size = new System.Drawing.Size(223, 22);
            this.mieuta.TabIndex = 8;
            // 
            // tenmonan
            // 
            this.tenmonan.Location = new System.Drawing.Point(135, 15);
            this.tenmonan.Name = "tenmonan";
            this.tenmonan.ReadOnly = true;
            this.tenmonan.Size = new System.Drawing.Size(223, 22);
            this.tenmonan.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng đặt";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Miêu tả";
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
            // ds_Monan_KH
            // 
            this.ds_Monan_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ds_Monan_KH.Location = new System.Drawing.Point(34, 221);
            this.ds_Monan_KH.Name = "ds_Monan_KH";
            this.ds_Monan_KH.ReadOnly = true;
            this.ds_Monan_KH.RowHeadersWidth = 51;
            this.ds_Monan_KH.RowTemplate.Height = 24;
            this.ds_Monan_KH.Size = new System.Drawing.Size(763, 202);
            this.ds_Monan_KH.TabIndex = 3;
            this.ds_Monan_KH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ds_Monan_KH_CellContentClick);
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_close.Location = new System.Drawing.Point(763, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 35);
            this.btn_close.TabIndex = 33;
            this.btn_close.TabStop = false;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // DS_Sanpham_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.ds_Monan_KH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DS_Sanpham_KH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DS_Sanpham_KH";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Monan_KH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soluong;
        private System.Windows.Forms.TextBox gia;
        private System.Windows.Forms.TextBox mieuta;
        private System.Windows.Forms.TextBox tenmonan;
        private System.Windows.Forms.DataGridView ds_Monan_KH;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button button1;
    }
}