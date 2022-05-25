namespace DoAn.NET
{
    partial class ItemGioHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemGioHang));
            this.pnitem = new System.Windows.Forms.Panel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.btnSuaSoLuong = new System.Windows.Forms.Button();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.picSanPham = new System.Windows.Forms.PictureBox();
            this.ckbChon = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.picXoa = new System.Windows.Forms.PictureBox();
            this.pnitem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnitem
            // 
            this.pnitem.BackColor = System.Drawing.Color.White;
            this.pnitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnitem.Controls.Add(this.lblTongTien);
            this.pnitem.Controls.Add(this.txtGhiChu);
            this.pnitem.Controls.Add(this.lblGhiChu);
            this.pnitem.Controls.Add(this.txtSoLuong);
            this.pnitem.Controls.Add(this.lblSoLuong);
            this.pnitem.Controls.Add(this.lblSize);
            this.pnitem.Controls.Add(this.btnDatHang);
            this.pnitem.Controls.Add(this.btnSuaSoLuong);
            this.pnitem.Controls.Add(this.lblGiaBan);
            this.pnitem.Controls.Add(this.lblTenSP);
            this.pnitem.Controls.Add(this.picSanPham);
            this.pnitem.Controls.Add(this.ckbChon);
            this.pnitem.Controls.Add(this.picXoa);
            this.pnitem.Location = new System.Drawing.Point(29, 1);
            this.pnitem.Name = "pnitem";
            this.pnitem.Size = new System.Drawing.Size(722, 221);
            this.pnitem.TabIndex = 2;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTongTien.Location = new System.Drawing.Point(505, 84);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(171, 25);
            this.lblTongTien.TabIndex = 30;
            this.lblTongTien.Text = "Tổng ";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(401, 111);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(275, 60);
            this.txtGhiChu.TabIndex = 29;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGhiChu.Location = new System.Drawing.Point(304, 112);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(91, 25);
            this.lblGhiChu.TabIndex = 28;
            this.lblGhiChu.Text = "Ghi Chú";
            this.lblGhiChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(401, 85);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 29);
            this.txtSoLuong.TabIndex = 27;
            this.txtSoLuong.Text = "1";
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoLuong.Location = new System.Drawing.Point(304, 84);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(91, 25);
            this.lblSoLuong.TabIndex = 24;
            this.lblSoLuong.Text = "Số Lượng";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSize
            // 
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSize.Location = new System.Drawing.Point(304, 61);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(100, 23);
            this.lblSize.TabIndex = 23;
            this.lblSize.Text = "Kích cỡ: ";
            // 
            // btnDatHang
            // 
            this.btnDatHang.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDatHang.ForeColor = System.Drawing.Color.White;
            this.btnDatHang.Location = new System.Drawing.Point(526, 180);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(150, 35);
            this.btnDatHang.TabIndex = 22;
            this.btnDatHang.Text = "Đặt Hàng";
            this.btnDatHang.UseVisualStyleBackColor = false;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // btnSuaSoLuong
            // 
            this.btnSuaSoLuong.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSuaSoLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaSoLuong.ForeColor = System.Drawing.Color.White;
            this.btnSuaSoLuong.Location = new System.Drawing.Point(371, 180);
            this.btnSuaSoLuong.Name = "btnSuaSoLuong";
            this.btnSuaSoLuong.Size = new System.Drawing.Size(150, 35);
            this.btnSuaSoLuong.TabIndex = 21;
            this.btnSuaSoLuong.Text = "Lưu Số lượng";
            this.btnSuaSoLuong.UseVisualStyleBackColor = false;
            this.btnSuaSoLuong.Click += new System.EventHandler(this.btnSuaSoLuong_Click);
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGiaBan.ForeColor = System.Drawing.Color.Red;
            this.lblGiaBan.Location = new System.Drawing.Point(304, 33);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(359, 27);
            this.lblGiaBan.TabIndex = 20;
            this.lblGiaBan.Text = "Giá: ";
            this.lblGiaBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenSP
            // 
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTenSP.Location = new System.Drawing.Point(304, 5);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(360, 27);
            this.lblTenSP.TabIndex = 19;
            this.lblTenSP.Text = "Tên SP";
            this.lblTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picSanPham
            // 
            this.picSanPham.Image = ((System.Drawing.Image)(resources.GetObject("picSanPham.Image")));
            this.picSanPham.Location = new System.Drawing.Point(56, 1);
            this.picSanPham.Name = "picSanPham";
            this.picSanPham.Size = new System.Drawing.Size(235, 218);
            this.picSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSanPham.TabIndex = 15;
            this.picSanPham.TabStop = false;
            // 
            // ckbChon
            // 
            this.ckbChon.AllowBindingControlAnimation = true;
            this.ckbChon.AllowBindingControlColorChanges = false;
            this.ckbChon.AllowBindingControlLocation = true;
            this.ckbChon.AllowCheckBoxAnimation = false;
            this.ckbChon.AllowCheckmarkAnimation = true;
            this.ckbChon.AllowOnHoverStates = true;
            this.ckbChon.AutoCheck = true;
            this.ckbChon.BackColor = System.Drawing.Color.Transparent;
            this.ckbChon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ckbChon.BackgroundImage")));
            this.ckbChon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ckbChon.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.ckbChon.BorderRadius = 12;
            this.ckbChon.Checked = false;
            this.ckbChon.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.ckbChon.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckbChon.CustomCheckmarkImage = null;
            this.ckbChon.Location = new System.Drawing.Point(17, 94);
            this.ckbChon.MinimumSize = new System.Drawing.Size(17, 17);
            this.ckbChon.Name = "ckbChon";
            this.ckbChon.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ckbChon.OnCheck.BorderRadius = 12;
            this.ckbChon.OnCheck.BorderThickness = 2;
            this.ckbChon.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.ckbChon.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.ckbChon.OnCheck.CheckmarkThickness = 2;
            this.ckbChon.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.ckbChon.OnDisable.BorderRadius = 12;
            this.ckbChon.OnDisable.BorderThickness = 2;
            this.ckbChon.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ckbChon.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.ckbChon.OnDisable.CheckmarkThickness = 2;
            this.ckbChon.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ckbChon.OnHoverChecked.BorderRadius = 12;
            this.ckbChon.OnHoverChecked.BorderThickness = 2;
            this.ckbChon.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ckbChon.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.ckbChon.OnHoverChecked.CheckmarkThickness = 2;
            this.ckbChon.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ckbChon.OnHoverUnchecked.BorderRadius = 12;
            this.ckbChon.OnHoverUnchecked.BorderThickness = 1;
            this.ckbChon.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ckbChon.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.ckbChon.OnUncheck.BorderRadius = 12;
            this.ckbChon.OnUncheck.BorderThickness = 1;
            this.ckbChon.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ckbChon.Size = new System.Drawing.Size(30, 30);
            this.ckbChon.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.ckbChon.TabIndex = 14;
            this.ckbChon.ThreeState = false;
            this.ckbChon.ToolTipText = null;
            this.ckbChon.Click += new System.EventHandler(this.ckbChon_Click);
            // 
            // picXoa
            // 
            this.picXoa.Image = global::DoAn.NET.Properties.Resources.delete_trash_384px;
            this.picXoa.Location = new System.Drawing.Point(682, 3);
            this.picXoa.Name = "picXoa";
            this.picXoa.Size = new System.Drawing.Size(35, 30);
            this.picXoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picXoa.TabIndex = 1;
            this.picXoa.TabStop = false;
            this.picXoa.Click += new System.EventHandler(this.picXoa_Click);
            // 
            // ItemGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.White;
            this.BorderRadius = 0;
            this.BorderThickness = 0;
            this.Controls.Add(this.pnitem);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ItemGioHang";
            this.Size = new System.Drawing.Size(780, 225);
            this.pnitem.ResumeLayout(false);
            this.pnitem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picXoa;
        private System.Windows.Forms.Panel pnitem;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Button btnSuaSoLuong;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.PictureBox picSanPham;
        private Bunifu.UI.WinForms.BunifuCheckBox ckbChon;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblTongTien;        
    }
}
