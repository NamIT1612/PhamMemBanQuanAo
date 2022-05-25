namespace DoAn.NET
{
    partial class ItemSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemSanPham));
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.picThemVaoGioHang = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.picSP = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picThemVaoGioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGia
            // 
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.Color.Red;
            this.lblGia.Location = new System.Drawing.Point(0, 231);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(251, 24);
            this.lblGia.TabIndex = 1;
            this.lblGia.Text = "Giá";
            this.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenSP
            // 
            this.lblTenSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTenSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(0, 255);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(251, 24);
            this.lblTenSP.TabIndex = 2;
            this.lblTenSP.Tag = "";
            this.lblTenSP.Text = "TênSP";
            this.lblTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picThemVaoGioHang
            // 
            this.picThemVaoGioHang.AllowFocused = false;
            this.picThemVaoGioHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picThemVaoGioHang.AutoSizeHeight = true;
            this.picThemVaoGioHang.BorderRadius = 18;
            this.picThemVaoGioHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picThemVaoGioHang.Image = global::DoAn.NET.Properties.Resources.shopping_cart_240px;
            this.picThemVaoGioHang.IsCircle = true;
            this.picThemVaoGioHang.Location = new System.Drawing.Point(207, 3);
            this.picThemVaoGioHang.Name = "picThemVaoGioHang";
            this.picThemVaoGioHang.Size = new System.Drawing.Size(37, 37);
            this.picThemVaoGioHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThemVaoGioHang.TabIndex = 6;
            this.picThemVaoGioHang.TabStop = false;
            this.picThemVaoGioHang.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.picThemVaoGioHang.Click += new System.EventHandler(this.picThemVaoGioHang_Click);
            // 
            // picSP
            // 
            this.picSP.AllowFocused = false;
            this.picSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picSP.AutoSizeHeight = true;
            this.picSP.BorderRadius = 105;
            this.picSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSP.Image = ((System.Drawing.Image)(resources.GetObject("picSP.Image")));
            this.picSP.IsCircle = true;
            this.picSP.Location = new System.Drawing.Point(20, 16);
            this.picSP.Name = "picSP";
            this.picSP.Size = new System.Drawing.Size(211, 211);
            this.picSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSP.TabIndex = 3;
            this.picSP.TabStop = false;
            this.picSP.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.picSP.Click += new System.EventHandler(this.picSP_Click);
            this.picSP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picSP_MouseMove);
            // 
            // ItemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BorderRadius = 50;
            this.BorderThickness = 2;
            this.Controls.Add(this.picThemVaoGioHang);
            this.Controls.Add(this.picSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblGia);
            this.Name = "ItemSanPham";
            this.Size = new System.Drawing.Size(251, 279);
            this.Load += new System.EventHandler(this.ItemSanPham_Load);
            this.MouseLeave += new System.EventHandler(this.ItemSanPham_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picThemVaoGioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTenSP;
        private Bunifu.UI.WinForms.BunifuPictureBox picSP;
        private Bunifu.UI.WinForms.BunifuPictureBox picThemVaoGioHang;
    }
}
