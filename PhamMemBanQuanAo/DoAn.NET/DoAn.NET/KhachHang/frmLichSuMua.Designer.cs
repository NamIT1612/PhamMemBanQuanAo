namespace DoAn.NET
{
    partial class frmLichSuMua
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
            this.flowLayPnLichSu = new System.Windows.Forms.FlowLayoutPanel();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.flowLayPnLichSu.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayPnLichSu
            // 
            this.flowLayPnLichSu.AutoScroll = true;
            this.flowLayPnLichSu.Controls.Add(this.lblThongBao);
            this.flowLayPnLichSu.Location = new System.Drawing.Point(13, 13);
            this.flowLayPnLichSu.Name = "flowLayPnLichSu";
            this.flowLayPnLichSu.Size = new System.Drawing.Size(805, 625);
            this.flowLayPnLichSu.TabIndex = 1;
            // 
            // lblThongBao
            // 
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(3, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(799, 46);
            this.lblThongBao.TabIndex = 1;
            this.lblThongBao.Text = "Bạn chưa mua hàng.";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLichSuMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 650);
            this.Controls.Add(this.flowLayPnLichSu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLichSuMua";
            this.Text = "frmLichSuMua";
            this.Load += new System.EventHandler(this.frmLichSuMua_Load);
            this.flowLayPnLichSu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayPnLichSu;
        private System.Windows.Forms.Label lblThongBao;

    }
}