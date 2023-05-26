namespace WindowsFormsApp1
{
    partial class DS_DoiTac_KH
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
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tencuahang = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.TextBox();
            this.tghoatdong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ds_doitac = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_doitac)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_close.Location = new System.Drawing.Point(728, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 35);
            this.btn_close.TabIndex = 32;
            this.btn_close.TabStop = false;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ds_doitac);
            this.groupBox1.Location = new System.Drawing.Point(51, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 439);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên cửa hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Địa chỉ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Thời gian hoạt động";
            // 
            // tencuahang
            // 
            this.tencuahang.Location = new System.Drawing.Point(58, 75);
            this.tencuahang.Name = "tencuahang";
            this.tencuahang.ReadOnly = true;
            this.tencuahang.Size = new System.Drawing.Size(223, 22);
            this.tencuahang.TabIndex = 27;
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(58, 148);
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            this.diachi.Size = new System.Drawing.Size(223, 22);
            this.diachi.TabIndex = 28;
            // 
            // tghoatdong
            // 
            this.tghoatdong.Location = new System.Drawing.Point(412, 75);
            this.tghoatdong.Name = "tghoatdong";
            this.tghoatdong.ReadOnly = true;
            this.tghoatdong.Size = new System.Drawing.Size(223, 22);
            this.tghoatdong.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 30;
            this.button1.Text = "Xem danh sách sản phẩm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ds_doitac
            // 
            this.ds_doitac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ds_doitac.Location = new System.Drawing.Point(42, 21);
            this.ds_doitac.Name = "ds_doitac";
            this.ds_doitac.ReadOnly = true;
            this.ds_doitac.RowHeadersWidth = 51;
            this.ds_doitac.RowTemplate.Height = 24;
            this.ds_doitac.Size = new System.Drawing.Size(633, 394);
            this.ds_doitac.TabIndex = 1;
            this.ds_doitac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DS_DoiTac_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 652);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tghoatdong);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.tencuahang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DS_DoiTac_KH";
            this.Text = "DS_DoiTac_KH";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_doitac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ds_doitac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tencuahang;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.TextBox tghoatdong;
        private System.Windows.Forms.Button button1;
    }
}