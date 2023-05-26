namespace WindowsFormsApp1
{
    partial class DatHang_KH
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dstuychon = new System.Windows.Forms.DataGridView();
            this.diachigiaohang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hinhthuctt = new System.Windows.Forms.ComboBox();
            this.btn_datmon = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mdon = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dstuychon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dstuychon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 286);
            this.panel1.TabIndex = 0;
            // 
            // dstuychon
            // 
            this.dstuychon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dstuychon.Location = new System.Drawing.Point(3, 3);
            this.dstuychon.Name = "dstuychon";
            this.dstuychon.ReadOnly = true;
            this.dstuychon.RowHeadersWidth = 51;
            this.dstuychon.RowTemplate.Height = 24;
            this.dstuychon.Size = new System.Drawing.Size(424, 358);
            this.dstuychon.TabIndex = 0;
            this.dstuychon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // diachigiaohang
            // 
            this.diachigiaohang.Location = new System.Drawing.Point(49, 220);
            this.diachigiaohang.Name = "diachigiaohang";
            this.diachigiaohang.Size = new System.Drawing.Size(332, 22);
            this.diachigiaohang.TabIndex = 41;
            this.diachigiaohang.TextChanged += new System.EventHandler(this.diachigiaohang_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Hình thức thanh toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Địa chỉ giao hàng";
            // 
            // hinhthuctt
            // 
            this.hinhthuctt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hinhthuctt.FormattingEnabled = true;
            this.hinhthuctt.Items.AddRange(new object[] {
            "tiền mặt",
            "Internet banking"});
            this.hinhthuctt.Location = new System.Drawing.Point(49, 146);
            this.hinhthuctt.Name = "hinhthuctt";
            this.hinhthuctt.Size = new System.Drawing.Size(332, 24);
            this.hinhthuctt.TabIndex = 43;
            // 
            // btn_datmon
            // 
            this.btn_datmon.Location = new System.Drawing.Point(191, 248);
            this.btn_datmon.Name = "btn_datmon";
            this.btn_datmon.Size = new System.Drawing.Size(60, 60);
            this.btn_datmon.TabIndex = 45;
            this.btn_datmon.Text = "Đặt ngay";
            this.btn_datmon.UseVisualStyleBackColor = true;
            this.btn_datmon.Click += new System.EventHandler(this.btn_datmon_Click);
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_close.Location = new System.Drawing.Point(355, -1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 35);
            this.btn_close.TabIndex = 46;
            this.btn_close.TabStop = false;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mã đơn";
            // 
            // mdon
            // 
            this.mdon.Location = new System.Drawing.Point(49, 63);
            this.mdon.Name = "mdon";
            this.mdon.Size = new System.Drawing.Size(332, 22);
            this.mdon.TabIndex = 48;
            // 
            // DatHang_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 600);
            this.Controls.Add(this.mdon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_datmon);
            this.Controls.Add(this.hinhthuctt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diachigiaohang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatHang_KH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatHang_KH";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dstuychon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dstuychon;
        private System.Windows.Forms.TextBox diachigiaohang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox hinhthuctt;
        private System.Windows.Forms.Button btn_datmon;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mdon;
    }
}