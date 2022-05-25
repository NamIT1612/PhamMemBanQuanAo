namespace DoAn.NET
{
    partial class itemDatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.lblChonSize = new System.Windows.Forms.Label();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoLuongSP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(108, 44);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(200, 29);
            this.txtSoLuong.TabIndex = 9;
            this.txtSoLuong.Text = "1";
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 10.20895F, System.Drawing.FontStyle.Bold);
            this.lblSoLuong.ForeColor = System.Drawing.Color.White;
            this.lblSoLuong.Location = new System.Drawing.Point(10, 54);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(90, 22);
            this.lblSoLuong.TabIndex = 8;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // cboSize
            // 
            this.cboSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(108, 6);
            this.cboSize.MaxDropDownItems = 5;
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(111, 32);
            this.cboSize.TabIndex = 7;
            // 
            // lblChonSize
            // 
            this.lblChonSize.AutoSize = true;
            this.lblChonSize.Font = new System.Drawing.Font("Times New Roman", 10.20895F, System.Drawing.FontStyle.Bold);
            this.lblChonSize.ForeColor = System.Drawing.Color.White;
            this.lblChonSize.Location = new System.Drawing.Point(10, 11);
            this.lblChonSize.Name = "lblChonSize";
            this.lblChonSize.Size = new System.Drawing.Size(92, 22);
            this.lblChonSize.TabIndex = 6;
            this.lblChonSize.Text = "Chọn Size";
            // 
            // btnDatHang
            // 
            this.btnDatHang.BackColor = System.Drawing.Color.White;
            this.btnDatHang.Font = new System.Drawing.Font("Times New Roman", 10.20895F, System.Drawing.FontStyle.Bold);
            this.btnDatHang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDatHang.Location = new System.Drawing.Point(108, 223);
            this.btnDatHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(200, 30);
            this.btnDatHang.TabIndex = 5;
            this.btnDatHang.Text = "Đặt Hàng";
            this.btnDatHang.UseVisualStyleBackColor = false;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.ForeColor = System.Drawing.Color.Black;
            this.txtTongTien.Location = new System.Drawing.Point(108, 83);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(200, 29);
            this.txtTongTien.TabIndex = 11;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 10.20895F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.White;
            this.lblTongTien.Location = new System.Drawing.Point(10, 90);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(95, 22);
            this.lblTongTien.TabIndex = 10;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.White;
            this.txtGhiChu.ForeColor = System.Drawing.Color.Black;
            this.txtGhiChu.Location = new System.Drawing.Point(108, 121);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(200, 95);
            this.txtGhiChu.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.20895F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ghi Chú";
            // 
            // lblSoLuongSP
            // 
            this.lblSoLuongSP.AutoSize = true;
            this.lblSoLuongSP.Font = new System.Drawing.Font("Times New Roman", 10.20895F, System.Drawing.FontStyle.Bold);
            this.lblSoLuongSP.ForeColor = System.Drawing.Color.White;
            this.lblSoLuongSP.Location = new System.Drawing.Point(226, 11);
            this.lblSoLuongSP.Name = "lblSoLuongSP";
            this.lblSoLuongSP.Size = new System.Drawing.Size(102, 22);
            this.lblSoLuongSP.TabIndex = 14;
            this.lblSoLuongSP.Text = "còn 100 SP";
            // 
            // itemDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(327, 265);
            this.Controls.Add(this.lblSoLuongSP);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.lblChonSize);
            this.Controls.Add(this.btnDatHang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "itemDatHang";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đặt hàng";
            this.Load += new System.EventHandler(this.itemDatHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.Label lblChonSize;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoLuongSP;


    }
}
