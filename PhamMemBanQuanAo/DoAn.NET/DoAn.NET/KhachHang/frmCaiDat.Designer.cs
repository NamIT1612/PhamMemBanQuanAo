namespace DoAn.NET
{
    partial class frmCaiDat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaiDat));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnDoiMK = new System.Windows.Forms.ToolStripButton();
            this.btnLienHe = new System.Windows.Forms.ToolStripButton();
            this.btnTTKH = new System.Windows.Forms.ToolStripButton();
            this.panelMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.toolStrip1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(810, 39);
            this.panelMenu.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDoiMK,
            this.btnLienHe,
            this.btnTTKH});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(810, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panelForm
            // 
            this.panelForm.BackgroundImage = global::DoAn.NET.Properties.Resources.Cửa_hàng_quần_áo_thời_trang;
            this.panelForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 39);
            this.panelForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(810, 509);
            this.panelForm.TabIndex = 2;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMK.Image")));
            this.btnDoiMK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(166, 29);
            this.btnDoiMK.Text = "ĐỔI MẬT KHẨU";
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnLienHe
            // 
            this.btnLienHe.Image = ((System.Drawing.Image)(resources.GetObject("btnLienHe.Image")));
            this.btnLienHe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLienHe.Name = "btnLienHe";
            this.btnLienHe.Size = new System.Drawing.Size(102, 29);
            this.btnLienHe.Text = "LIÊN HỆ";
            this.btnLienHe.Click += new System.EventHandler(this.btnLienHe_Click);
            // 
            // btnTTKH
            // 
            this.btnTTKH.Image = global::DoAn.NET.Properties.Resources.user1;
            this.btnTTKH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTTKH.Name = "btnTTKH";
            this.btnTTKH.Size = new System.Drawing.Size(219, 29);
            this.btnTTKH.Text = "Thông Tin Khách Hàng";
            this.btnTTKH.Click += new System.EventHandler(this.btnTTKH_Click);
            // 
            // frmCaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 548);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCaiDat";
            this.Text = "frmLichSuMua";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDoiMK;
        private System.Windows.Forms.ToolStripButton btnLienHe;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.ToolStripButton btnTTKH;

    }
}