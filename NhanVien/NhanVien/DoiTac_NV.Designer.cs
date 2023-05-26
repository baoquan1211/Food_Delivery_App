namespace NhanVien
{
    partial class DoiTac_NV
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
            this.ds_doitac = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sdtDT = new System.Windows.Forms.TextBox();
            this.tennhahangDT = new System.Windows.Forms.TextBox();
            this.nguoidaidienDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailDT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ds_doitac)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.ds_doitac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ds_doitac_CellContentClick);
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_close.Location = new System.Drawing.Point(727, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 35);
            this.btn_close.TabIndex = 41;
            this.btn_close.TabStop = false;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 40;
            this.button1.Text = "Xem hợp đồng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sdtDT
            // 
            this.sdtDT.Location = new System.Drawing.Point(386, 81);
            this.sdtDT.Name = "sdtDT";
            this.sdtDT.ReadOnly = true;
            this.sdtDT.Size = new System.Drawing.Size(223, 22);
            this.sdtDT.TabIndex = 39;
            // 
            // tennhahangDT
            // 
            this.tennhahangDT.Location = new System.Drawing.Point(32, 154);
            this.tennhahangDT.Name = "tennhahangDT";
            this.tennhahangDT.ReadOnly = true;
            this.tennhahangDT.Size = new System.Drawing.Size(223, 22);
            this.tennhahangDT.TabIndex = 38;
            // 
            // nguoidaidienDT
            // 
            this.nguoidaidienDT.Location = new System.Drawing.Point(32, 81);
            this.nguoidaidienDT.Name = "nguoidaidienDT";
            this.nguoidaidienDT.ReadOnly = true;
            this.nguoidaidienDT.Size = new System.Drawing.Size(223, 22);
            this.nguoidaidienDT.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "SĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tên nhà hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Người đại diện";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ds_doitac);
            this.groupBox1.Location = new System.Drawing.Point(25, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 439);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Email";
            // 
            // emailDT
            // 
            this.emailDT.Location = new System.Drawing.Point(386, 154);
            this.emailDT.Name = "emailDT";
            this.emailDT.ReadOnly = true;
            this.emailDT.Size = new System.Drawing.Size(223, 22);
            this.emailDT.TabIndex = 43;
            // 
            // DoiTac_NV
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
            this.Name = "DoiTac_NV";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ds_doitac)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ds_doitac;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sdtDT;
        private System.Windows.Forms.TextBox tennhahangDT;
        private System.Windows.Forms.TextBox nguoidaidienDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailDT;
    }
}