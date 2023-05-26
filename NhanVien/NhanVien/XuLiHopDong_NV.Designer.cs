namespace NhanVien
{
    partial class XuLiHopDong_NV
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
            this.ds_hopdong = new System.Windows.Forms.DataGridView();
            this.emailDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sdtDT = new System.Windows.Forms.TextBox();
            this.tennhahangDT = new System.Windows.Forms.TextBox();
            this.nguoidaidienDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ds_hopdong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ds_hopdong
            // 
            this.ds_hopdong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ds_hopdong.Location = new System.Drawing.Point(42, 21);
            this.ds_hopdong.Name = "ds_hopdong";
            this.ds_hopdong.ReadOnly = true;
            this.ds_hopdong.RowHeadersWidth = 51;
            this.ds_hopdong.RowTemplate.Height = 24;
            this.ds_hopdong.Size = new System.Drawing.Size(633, 394);
            this.ds_hopdong.TabIndex = 1;
            this.ds_hopdong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ds_hopdong_CellContentClick);
            // 
            // emailDT
            // 
            this.emailDT.Location = new System.Drawing.Point(385, 153);
            this.emailDT.Name = "emailDT";
            this.emailDT.ReadOnly = true;
            this.emailDT.Size = new System.Drawing.Size(223, 22);
            this.emailDT.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "Email";
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_close.Location = new System.Drawing.Point(726, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 35);
            this.btn_close.TabIndex = 52;
            this.btn_close.TabStop = false;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 51;
            this.button1.Text = "Xem hợp đồng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sdtDT
            // 
            this.sdtDT.Location = new System.Drawing.Point(385, 80);
            this.sdtDT.Name = "sdtDT";
            this.sdtDT.ReadOnly = true;
            this.sdtDT.Size = new System.Drawing.Size(223, 22);
            this.sdtDT.TabIndex = 50;
            // 
            // tennhahangDT
            // 
            this.tennhahangDT.Location = new System.Drawing.Point(31, 153);
            this.tennhahangDT.Name = "tennhahangDT";
            this.tennhahangDT.ReadOnly = true;
            this.tennhahangDT.Size = new System.Drawing.Size(223, 22);
            this.tennhahangDT.TabIndex = 49;
            // 
            // nguoidaidienDT
            // 
            this.nguoidaidienDT.Location = new System.Drawing.Point(31, 80);
            this.nguoidaidienDT.Name = "nguoidaidienDT";
            this.nguoidaidienDT.ReadOnly = true;
            this.nguoidaidienDT.Size = new System.Drawing.Size(223, 22);
            this.nguoidaidienDT.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "SĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tên nhà hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Người đại diện";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ds_hopdong);
            this.groupBox1.Location = new System.Drawing.Point(24, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 439);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // XuLiHopDong_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 652);
            this.Controls.Add(this.emailDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sdtDT);
            this.Controls.Add(this.tennhahangDT);
            this.Controls.Add(this.nguoidaidienDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XuLiHopDong_NV";
            this.Text = "XuLiHopDong_NV";
            ((System.ComponentModel.ISupportInitialize)(this.ds_hopdong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ds_hopdong;
        private System.Windows.Forms.TextBox emailDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sdtDT;
        private System.Windows.Forms.TextBox tennhahangDT;
        private System.Windows.Forms.TextBox nguoidaidienDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}