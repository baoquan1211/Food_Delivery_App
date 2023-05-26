namespace DoiTac
{
    partial class TTKhachHang_TX
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
            this.sdtKH = new System.Windows.Forms.TextBox();
            this.htenKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.diachiKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sdtKH
            // 
            this.sdtKH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sdtKH.Location = new System.Drawing.Point(54, 217);
            this.sdtKH.Name = "sdtKH";
            this.sdtKH.ReadOnly = true;
            this.sdtKH.Size = new System.Drawing.Size(223, 22);
            this.sdtKH.TabIndex = 45;
            // 
            // htenKH
            // 
            this.htenKH.Location = new System.Drawing.Point(54, 133);
            this.htenKH.Name = "htenKH";
            this.htenKH.ReadOnly = true;
            this.htenKH.Size = new System.Drawing.Size(223, 22);
            this.htenKH.TabIndex = 44;
            this.htenKH.TextChanged += new System.EventHandler(this.htenKH_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Họ tên khách hàng";
            // 
            // diachiKH
            // 
            this.diachiKH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.diachiKH.Location = new System.Drawing.Point(54, 299);
            this.diachiKH.Name = "diachiKH";
            this.diachiKH.ReadOnly = true;
            this.diachiKH.Size = new System.Drawing.Size(223, 22);
            this.diachiKH.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Địa chỉ";
            // 
            // emailKH
            // 
            this.emailKH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailKH.Location = new System.Drawing.Point(54, 372);
            this.emailKH.Name = "emailKH";
            this.emailKH.ReadOnly = true;
            this.emailKH.Size = new System.Drawing.Size(223, 22);
            this.emailKH.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Email";
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_close.Location = new System.Drawing.Point(298, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 35);
            this.btn_close.TabIndex = 50;
            this.btn_close.TabStop = false;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // TTKhachHang_TX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 568);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.emailKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diachiKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sdtKH);
            this.Controls.Add(this.htenKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TTKhachHang_TX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTKhachHang_TX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sdtKH;
        private System.Windows.Forms.TextBox htenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox diachiKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_close;
    }
}