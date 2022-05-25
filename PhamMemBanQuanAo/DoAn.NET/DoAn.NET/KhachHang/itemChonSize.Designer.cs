namespace DoAn.NET
{
    partial class itemChonSize
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
            this.btnThem = new System.Windows.Forms.Button();
            this.lblChonSize = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuongSP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.20895F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.Location = new System.Drawing.Point(109, 77);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(200, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblChonSize
            // 
            this.lblChonSize.AutoSize = true;
            this.lblChonSize.Font = new System.Drawing.Font("Times New Roman", 10.20895F, System.Drawing.FontStyle.Bold);
            this.lblChonSize.ForeColor = System.Drawing.Color.White;
            this.lblChonSize.Location = new System.Drawing.Point(13, 11);
            this.lblChonSize.Name = "lblChonSize";
            this.lblChonSize.Size = new System.Drawing.Size(92, 22);
            this.lblChonSize.TabIndex = 1;
            this.lblChonSize.Text = "Chọn Size";
            // 
            // cboSize
            // 
            this.cboSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(109, 6);
            this.cboSize.MaxDropDownItems = 5;
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(111, 32);
            this.cboSize.TabIndex = 2;
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged);
            this.cboSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboSize_KeyPress);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 10.20895F, System.Drawing.FontStyle.Bold);
            this.lblSoLuong.ForeColor = System.Drawing.Color.White;
            this.lblSoLuong.Location = new System.Drawing.Point(13, 46);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(90, 22);
            this.lblSoLuong.TabIndex = 3;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(109, 41);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(200, 29);
            this.txtSoLuong.TabIndex = 4;
            this.txtSoLuong.Text = "1";
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // lblSoLuongSP
            // 
            this.lblSoLuongSP.AutoSize = true;
            this.lblSoLuongSP.Font = new System.Drawing.Font("Times New Roman", 10.20895F, System.Drawing.FontStyle.Bold);
            this.lblSoLuongSP.ForeColor = System.Drawing.Color.White;
            this.lblSoLuongSP.Location = new System.Drawing.Point(226, 11);
            this.lblSoLuongSP.Name = "lblSoLuongSP";
            this.lblSoLuongSP.Size = new System.Drawing.Size(102, 22);
            this.lblSoLuongSP.TabIndex = 5;
            this.lblSoLuongSP.Text = "còn 100 SP";
            // 
            // itemChonSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(324, 116);
            this.Controls.Add(this.lblSoLuongSP);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.lblChonSize);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "itemChonSize";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm vào giỏ hàng";
            this.Load += new System.EventHandler(this.itemChonSize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblChonSize;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuongSP;

    }
}
