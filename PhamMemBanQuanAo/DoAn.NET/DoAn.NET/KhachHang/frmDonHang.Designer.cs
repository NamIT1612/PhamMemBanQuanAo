namespace DoAn.NET
{
    partial class frmDonHang
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
            this.flowLayPnDonHang = new System.Windows.Forms.FlowLayoutPanel();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.flowLayPnDonHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayPnDonHang
            // 
            this.flowLayPnDonHang.AutoScroll = true;
            this.flowLayPnDonHang.Controls.Add(this.lblThongBao);
            this.flowLayPnDonHang.Location = new System.Drawing.Point(12, 12);
            this.flowLayPnDonHang.Name = "flowLayPnDonHang";
            this.flowLayPnDonHang.Size = new System.Drawing.Size(805, 625);
            this.flowLayPnDonHang.TabIndex = 0;
            // 
            // lblThongBao
            // 
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(3, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(799, 46);
            this.lblThongBao.TabIndex = 1;
            this.lblThongBao.Text = "Bạn chưa có đơn hàng nào";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 650);
            this.Controls.Add(this.flowLayPnDonHang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDonHang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmGioHang";
            this.Load += new System.EventHandler(this.frmDonHang_Load);
            this.flowLayPnDonHang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayPnDonHang;
        private System.Windows.Forms.Label lblThongBao;

    }
}