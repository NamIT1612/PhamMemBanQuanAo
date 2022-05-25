namespace DoAn.NET
{
    partial class ItemDonHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDonHang));
            this.pnitem = new System.Windows.Forms.Panel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.picSanPham = new System.Windows.Forms.PictureBox();
            this.picHuy = new System.Windows.Forms.PictureBox();
            this.pnitem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHuy)).BeginInit();
            this.SuspendLayout();
            // 
            // pnitem
            // 
            this.pnitem.BackColor = System.Drawing.Color.White;
            this.pnitem.Controls.Add(this.lblTongTien);
            this.pnitem.Controls.Add(this.lblSoLuong);
            this.pnitem.Controls.Add(this.lblSize);
            this.pnitem.Controls.Add(this.lblTenSP);
            this.pnitem.Controls.Add(this.picSanPham);
            this.pnitem.Location = new System.Drawing.Point(29, 3);
            this.pnitem.Name = "pnitem";
            this.pnitem.Size = new System.Drawing.Size(710, 150);
            this.pnitem.TabIndex = 3;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTongTien.Location = new System.Drawing.Point(540, 59);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(171, 28);
            this.lblTongTien.TabIndex = 30;
            this.lblTongTien.Text = "190000đ";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSoLuong.Location = new System.Drawing.Point(156, 88);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(91, 23);
            this.lblSoLuong.TabIndex = 24;
            this.lblSoLuong.Text = "x1";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSize
            // 
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSize.ForeColor = System.Drawing.Color.Gray;
            this.lblSize.Location = new System.Drawing.Point(156, 65);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(100, 23);
            this.lblSize.TabIndex = 23;
            this.lblSize.Text = "Kích cỡ: ";
            // 
            // lblTenSP
            // 
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTenSP.Location = new System.Drawing.Point(156, 36);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(360, 27);
            this.lblTenSP.TabIndex = 19;
            this.lblTenSP.Text = "Tên SP";
            this.lblTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picSanPham
            // 
            this.picSanPham.Image = ((System.Drawing.Image)(resources.GetObject("picSanPham.Image")));
            this.picSanPham.Location = new System.Drawing.Point(0, 1);
            this.picSanPham.Name = "picSanPham";
            this.picSanPham.Size = new System.Drawing.Size(150, 150);
            this.picSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSanPham.TabIndex = 15;
            this.picSanPham.TabStop = false;
            // 
            // picHuy
            // 
            this.picHuy.Image = global::DoAn.NET.Properties.Resources.close_window_480px;
            this.picHuy.Location = new System.Drawing.Point(745, 58);
            this.picHuy.Name = "picHuy";
            this.picHuy.Size = new System.Drawing.Size(32, 32);
            this.picHuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHuy.TabIndex = 31;
            this.picHuy.TabStop = false;
            this.picHuy.Click += new System.EventHandler(this.picHuy_Click);
            // 
            // ItemDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.picHuy);
            this.Controls.Add(this.pnitem);
            this.Name = "ItemDonHang";
            this.Size = new System.Drawing.Size(780, 154);
            this.pnitem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHuy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnitem;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.PictureBox picSanPham;
        private System.Windows.Forms.PictureBox picHuy;
    }
}
