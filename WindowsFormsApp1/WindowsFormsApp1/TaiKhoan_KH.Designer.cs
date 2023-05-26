namespace WindowsFormsApp1
{
    partial class TaiKhoan_KH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiKhoan_KH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.emailKH = new System.Windows.Forms.TextBox();
            this.sdtKH = new System.Windows.Forms.TextBox();
            this.diachiKH = new System.Windows.Forms.TextBox();
            this.tenKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_capnhat);
            this.panel1.Controls.Add(this.emailKH);
            this.panel1.Controls.Add(this.sdtKH);
            this.panel1.Controls.Add(this.diachiKH);
            this.panel1.Controls.Add(this.tenKH);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 365);
            this.panel1.TabIndex = 0;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(350, 230);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(89, 72);
            this.btn_capnhat.TabIndex = 40;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // emailKH
            // 
            this.emailKH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailKH.Location = new System.Drawing.Point(459, 165);
            this.emailKH.Name = "emailKH";
            this.emailKH.Size = new System.Drawing.Size(223, 22);
            this.emailKH.TabIndex = 39;
            this.emailKH.TextChanged += new System.EventHandler(this.tinhtrang_TextChanged);
            // 
            // sdtKH
            // 
            this.sdtKH.Location = new System.Drawing.Point(459, 92);
            this.sdtKH.Name = "sdtKH";
            this.sdtKH.Size = new System.Drawing.Size(223, 22);
            this.sdtKH.TabIndex = 38;
            this.sdtKH.TextChanged += new System.EventHandler(this.tghoatdong_TextChanged);
            // 
            // diachiKH
            // 
            this.diachiKH.Location = new System.Drawing.Point(105, 165);
            this.diachiKH.Name = "diachiKH";
            this.diachiKH.Size = new System.Drawing.Size(223, 22);
            this.diachiKH.TabIndex = 37;
            this.diachiKH.TextChanged += new System.EventHandler(this.diachi_TextChanged);
            // 
            // tenKH
            // 
            this.tenKH.Location = new System.Drawing.Point(105, 92);
            this.tenKH.Name = "tenKH";
            this.tenKH.Size = new System.Drawing.Size(223, 22);
            this.tenKH.TabIndex = 36;
            this.tenKH.TextChanged += new System.EventHandler(this.tencuahang_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Số điện thoại";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Địa chỉ ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Họ tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(326, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 180);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_close.Location = new System.Drawing.Point(709, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 35);
            this.btn_close.TabIndex = 40;
            this.btn_close.TabStop = false;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // TaiKhoan_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 605);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaiKhoan_KH";
            this.Text = "TaiKhoan_KH";
            this.Load += new System.EventHandler(this.TaiKhoan_KH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox emailKH;
        private System.Windows.Forms.TextBox sdtKH;
        private System.Windows.Forms.TextBox diachiKH;
        private System.Windows.Forms.TextBox tenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_capnhat;
    }
}