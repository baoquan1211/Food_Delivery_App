namespace DoiTac
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.Main = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.side = new System.Windows.Forms.Panel();
            this.btn_taikhoan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_donhang = new System.Windows.Forms.Button();
            this.btn_dathang = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Main.SuspendLayout();
            this.side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.Controls.Add(this.pictureBox2);
            this.Main.Controls.Add(this.btn_close);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Main.Location = new System.Drawing.Point(198, 0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(802, 652);
            this.Main.TabIndex = 6;
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(723, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 35);
            this.btn_close.TabIndex = 0;
            this.btn_close.TabStop = false;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // side
            // 
            this.side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.side.Controls.Add(this.btn_taikhoan);
            this.side.Controls.Add(this.pictureBox1);
            this.side.Controls.Add(this.btn_donhang);
            this.side.Controls.Add(this.btn_dathang);
            this.side.Dock = System.Windows.Forms.DockStyle.Left;
            this.side.Location = new System.Drawing.Point(0, 0);
            this.side.Name = "side";
            this.side.Size = new System.Drawing.Size(198, 652);
            this.side.TabIndex = 5;
            // 
            // btn_taikhoan
            // 
            this.btn_taikhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_taikhoan.FlatAppearance.BorderSize = 0;
            this.btn_taikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taikhoan.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taikhoan.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_taikhoan.Location = new System.Drawing.Point(0, 333);
            this.btn_taikhoan.Name = "btn_taikhoan";
            this.btn_taikhoan.Size = new System.Drawing.Size(200, 54);
            this.btn_taikhoan.TabIndex = 2;
            this.btn_taikhoan.Text = "Tài khoản";
            this.btn_taikhoan.UseVisualStyleBackColor = false;
            this.btn_taikhoan.Click += new System.EventHandler(this.btn_taikhoan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 169);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_donhang
            // 
            this.btn_donhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_donhang.FlatAppearance.BorderSize = 0;
            this.btn_donhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_donhang.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_donhang.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_donhang.Location = new System.Drawing.Point(0, 268);
            this.btn_donhang.Name = "btn_donhang";
            this.btn_donhang.Size = new System.Drawing.Size(200, 54);
            this.btn_donhang.TabIndex = 1;
            this.btn_donhang.Text = "Đơn đã nhận";
            this.btn_donhang.UseVisualStyleBackColor = false;
            this.btn_donhang.Click += new System.EventHandler(this.btn_donhang_Click);
            // 
            // btn_dathang
            // 
            this.btn_dathang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_dathang.FlatAppearance.BorderSize = 0;
            this.btn_dathang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dathang.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dathang.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_dathang.Location = new System.Drawing.Point(0, 201);
            this.btn_dathang.Name = "btn_dathang";
            this.btn_dathang.Size = new System.Drawing.Size(200, 54);
            this.btn_dathang.TabIndex = 0;
            this.btn_dathang.Text = "Nhận đơn";
            this.btn_dathang.UseVisualStyleBackColor = false;
            this.btn_dathang.Click += new System.EventHandler(this.btn_dathang_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(61, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(680, 624);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 652);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.side);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.Main.ResumeLayout(false);
            this.side.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel side;
        private System.Windows.Forms.Button btn_taikhoan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_donhang;
        private System.Windows.Forms.Button btn_dathang;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}