namespace DoAn.NET
{
    partial class frmDoiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMK));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenAdmin = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtMatKhauLL = new System.Windows.Forms.TextBox();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.btnDoiMatKhau = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(234, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Admin :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(234, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(234, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu lặp lại :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTenAdmin
            // 
            this.txtTenAdmin.Enabled = false;
            this.txtTenAdmin.Location = new System.Drawing.Point(419, 77);
            this.txtTenAdmin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenAdmin.Name = "txtTenAdmin";
            this.txtTenAdmin.Size = new System.Drawing.Size(282, 29);
            this.txtTenAdmin.TabIndex = 4;
            this.txtTenAdmin.Text = "Admin";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(419, 200);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(282, 29);
            this.txtMatKhau.TabIndex = 5;
            // 
            // txtMatKhauLL
            // 
            this.txtMatKhauLL.Location = new System.Drawing.Point(419, 351);
            this.txtMatKhauLL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMatKhauLL.Name = "txtMatKhauLL";
            this.txtMatKhauLL.PasswordChar = '*';
            this.txtMatKhauLL.Size = new System.Drawing.Size(282, 29);
            this.txtMatKhauLL.TabIndex = 6;
            this.txtMatKhauLL.Leave += new System.EventHandler(this.txtMatKhauLL_Leave);
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.Location = new System.Drawing.Point(425, 435);
            this.lbThongBao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(0, 24);
            this.lbThongBao.TabIndex = 7;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.AllowAnimations = true;
            this.btnDoiMatKhau.AllowMouseEffects = true;
            this.btnDoiMatKhau.AllowToggling = false;
            this.btnDoiMatKhau.AnimationSpeed = 200;
            this.btnDoiMatKhau.AutoGenerateColors = false;
            this.btnDoiMatKhau.AutoRoundBorders = false;
            this.btnDoiMatKhau.AutoSizeLeftIcon = true;
            this.btnDoiMatKhau.AutoSizeRightIcon = true;
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.btnDoiMatKhau.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnDoiMatKhau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.BackgroundImage")));
            this.btnDoiMatKhau.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDoiMatKhau.ButtonText = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.ButtonTextMarginLeft = 0;
            this.btnDoiMatKhau.ColorContrastOnClick = 45;
            this.btnDoiMatKhau.ColorContrastOnHover = 45;
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDoiMatKhau.CustomizableEdges = borderEdges1;
            this.btnDoiMatKhau.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDoiMatKhau.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDoiMatKhau.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDoiMatKhau.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDoiMatKhau.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMatKhau.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDoiMatKhau.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDoiMatKhau.IconMarginLeft = 11;
            this.btnDoiMatKhau.IconPadding = 10;
            this.btnDoiMatKhau.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiMatKhau.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDoiMatKhau.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDoiMatKhau.IconSize = 25;
            this.btnDoiMatKhau.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDoiMatKhau.IdleBorderRadius = 1;
            this.btnDoiMatKhau.IdleBorderThickness = 1;
            this.btnDoiMatKhau.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnDoiMatKhau.IdleIconLeftImage = null;
            this.btnDoiMatKhau.IdleIconRightImage = null;
            this.btnDoiMatKhau.IndicateFocus = false;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(419, 462);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDoiMatKhau.OnDisabledState.BorderRadius = 1;
            this.btnDoiMatKhau.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDoiMatKhau.OnDisabledState.BorderThickness = 1;
            this.btnDoiMatKhau.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDoiMatKhau.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDoiMatKhau.OnDisabledState.IconLeftImage = null;
            this.btnDoiMatKhau.OnDisabledState.IconRightImage = null;
            this.btnDoiMatKhau.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnDoiMatKhau.onHoverState.BorderRadius = 1;
            this.btnDoiMatKhau.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDoiMatKhau.onHoverState.BorderThickness = 1;
            this.btnDoiMatKhau.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnDoiMatKhau.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.onHoverState.IconLeftImage = null;
            this.btnDoiMatKhau.onHoverState.IconRightImage = null;
            this.btnDoiMatKhau.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDoiMatKhau.OnIdleState.BorderRadius = 1;
            this.btnDoiMatKhau.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDoiMatKhau.OnIdleState.BorderThickness = 1;
            this.btnDoiMatKhau.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDoiMatKhau.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.OnIdleState.IconLeftImage = null;
            this.btnDoiMatKhau.OnIdleState.IconRightImage = null;
            this.btnDoiMatKhau.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDoiMatKhau.OnPressedState.BorderRadius = 1;
            this.btnDoiMatKhau.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDoiMatKhau.OnPressedState.BorderThickness = 1;
            this.btnDoiMatKhau.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDoiMatKhau.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.OnPressedState.IconLeftImage = null;
            this.btnDoiMatKhau.OnPressedState.IconRightImage = null;
            this.btnDoiMatKhau.Size = new System.Drawing.Size(181, 49);
            this.btnDoiMatKhau.TabIndex = 17;
            this.btnDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDoiMatKhau.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDoiMatKhau.TextMarginLeft = 0;
            this.btnDoiMatKhau.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDoiMatKhau.UseDefaultRadiusAndThickness = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // frmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 655);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.txtMatKhauLL);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDoiMK";
            this.Text = "frmDoiMK";
            this.Load += new System.EventHandler(this.frmDoiMK_Load);
            this.TextChanged += new System.EventHandler(this.frmDoiMK_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenAdmin;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtMatKhauLL;
        private System.Windows.Forms.Label lbThongBao;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDoiMatKhau;
    }
}