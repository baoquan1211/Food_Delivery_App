namespace FoodDelivery
{
    partial class ContractInformation
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
            this.lblMaHopDong = new System.Windows.Forms.Label();
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMaDoiTac = new System.Windows.Forms.Label();
            this.txtMaDoiTac = new System.Windows.Forms.TextBox();
            this.btn_XemThongTin = new System.Windows.Forms.Button();
            this.dgvContractInformation = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaHopDong
            // 
            this.lblMaHopDong.AutoSize = true;
            this.lblMaHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHopDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblMaHopDong.Location = new System.Drawing.Point(18, 58);
            this.lblMaHopDong.Name = "lblMaHopDong";
            this.lblMaHopDong.Size = new System.Drawing.Size(130, 25);
            this.lblMaHopDong.TabIndex = 1;
            this.lblMaHopDong.Text = "Mã Hợp đồng";
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHopDong.Location = new System.Drawing.Point(172, 57);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.Size = new System.Drawing.Size(192, 30);
            this.txtMaHopDong.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMaDoiTac);
            this.groupBox2.Controls.Add(this.lblMaHopDong);
            this.groupBox2.Controls.Add(this.txtMaDoiTac);
            this.groupBox2.Controls.Add(this.txtMaHopDong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.groupBox2.Location = new System.Drawing.Point(25, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 245);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hợp đồng";
            // 
            // lblMaDoiTac
            // 
            this.lblMaDoiTac.AutoSize = true;
            this.lblMaDoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDoiTac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblMaDoiTac.Location = new System.Drawing.Point(410, 58);
            this.lblMaDoiTac.Name = "lblMaDoiTac";
            this.lblMaDoiTac.Size = new System.Drawing.Size(102, 25);
            this.lblMaDoiTac.TabIndex = 1;
            this.lblMaDoiTac.Text = "Mã đối tác";
            // 
            // txtMaDoiTac
            // 
            this.txtMaDoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDoiTac.Location = new System.Drawing.Point(549, 58);
            this.txtMaDoiTac.Name = "txtMaDoiTac";
            this.txtMaDoiTac.Size = new System.Drawing.Size(192, 30);
            this.txtMaDoiTac.TabIndex = 0;
            // 
            // btn_XemThongTin
            // 
            this.btn_XemThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_XemThongTin.Location = new System.Drawing.Point(841, 117);
            this.btn_XemThongTin.Name = "btn_XemThongTin";
            this.btn_XemThongTin.Size = new System.Drawing.Size(215, 72);
            this.btn_XemThongTin.TabIndex = 2;
            this.btn_XemThongTin.Text = "Xem thông tin hợp đồng";
            this.btn_XemThongTin.UseVisualStyleBackColor = false;
            this.btn_XemThongTin.Click += new System.EventHandler(this.btn_XemThongTin_Click);
            // 
            // dgvContractInformation
            // 
            this.dgvContractInformation.BackgroundColor = System.Drawing.Color.White;
            this.dgvContractInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractInformation.Location = new System.Drawing.Point(25, 310);
            this.dgvContractInformation.Name = "dgvContractInformation";
            this.dgvContractInformation.RowHeadersWidth = 62;
            this.dgvContractInformation.RowTemplate.Height = 28;
            this.dgvContractInformation.Size = new System.Drawing.Size(790, 203);
            this.dgvContractInformation.TabIndex = 3;
            // 
            // ContractInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 732);
            this.Controls.Add(this.dgvContractInformation);
            this.Controls.Add(this.btn_XemThongTin);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContractInformation";
            this.Text = "ContractInformation";
            
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMaHopDong;
        private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMaDoiTac;
        private System.Windows.Forms.TextBox txtMaDoiTac;
        private System.Windows.Forms.Button btn_XemThongTin;
        private System.Windows.Forms.DataGridView dgvContractInformation;
    }
}