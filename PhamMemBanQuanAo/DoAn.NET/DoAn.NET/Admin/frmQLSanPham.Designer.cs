namespace DoAn.NET
{
    partial class frmQLSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSanPham));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiaCu = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pcHinhAnh = new System.Windows.Forms.PictureBox();
            this.cbbMaLoai = new System.Windows.Forms.ComboBox();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.btnThem = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSua = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnXoa = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(15, 121);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 24);
            this.label9.TabIndex = 59;
            this.label9.Text = "Mô tả :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(163, 118);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(173, 30);
            this.txtMoTa.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(344, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 24);
            this.label7.TabIndex = 56;
            this.label7.Text = "Tên loại :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1045, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 55;
            this.label8.Text = "Hình ảnh :";
            // 
            // txtGiaCu
            // 
            this.txtGiaCu.Location = new System.Drawing.Point(497, 63);
            this.txtGiaCu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGiaCu.Name = "txtGiaCu";
            this.txtGiaCu.Size = new System.Drawing.Size(203, 30);
            this.txtGiaCu.TabIndex = 52;
            this.txtGiaCu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaCu_KeyPress);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(497, 7);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(203, 30);
            this.txtTenSP.TabIndex = 51;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(163, 63);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(173, 30);
            this.txtGiaBan.TabIndex = 49;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(163, 7);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(173, 30);
            this.txtMaSP.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(344, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 24);
            this.label5.TabIndex = 46;
            this.label5.Text = "Giá cũ :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(344, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = "Tên sản phẩm :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Giá bán :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mã Sản Phẩm :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.GiaBan,
            this.GiaCu,
            this.MoTa,
            this.HinhAnh,
            this.MaLoai});
            this.dataGridView1.Location = new System.Drawing.Point(13, 234);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(939, 409);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // pcHinhAnh
            // 
            this.pcHinhAnh.Location = new System.Drawing.Point(708, 7);
            this.pcHinhAnh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pcHinhAnh.Name = "pcHinhAnh";
            this.pcHinhAnh.Size = new System.Drawing.Size(244, 186);
            this.pcHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcHinhAnh.TabIndex = 62;
            this.pcHinhAnh.TabStop = false;
            // 
            // cbbMaLoai
            // 
            this.cbbMaLoai.FormattingEnabled = true;
            this.cbbMaLoai.Location = new System.Drawing.Point(493, 118);
            this.cbbMaLoai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbbMaLoai.Name = "cbbMaLoai";
            this.cbbMaLoai.Size = new System.Drawing.Size(207, 33);
            this.cbbMaLoai.TabIndex = 63;
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.Location = new System.Drawing.Point(733, 199);
            this.txtHinhAnh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.Size = new System.Drawing.Size(207, 30);
            this.txtHinhAnh.TabIndex = 64;
            // 
            // btnThem
            // 
            this.btnThem.AllowAnimations = true;
            this.btnThem.AllowMouseEffects = true;
            this.btnThem.AllowToggling = false;
            this.btnThem.AnimationSpeed = 200;
            this.btnThem.AutoGenerateColors = false;
            this.btnThem.AutoRoundBorders = false;
            this.btnThem.AutoSizeLeftIcon = true;
            this.btnThem.AutoSizeRightIcon = true;
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.ButtonTextMarginLeft = 0;
            this.btnThem.ColorContrastOnClick = 45;
            this.btnThem.ColorContrastOnHover = 45;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnThem.CustomizableEdges = borderEdges4;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThem.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThem.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThem.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnThem.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnThem.IconMarginLeft = 11;
            this.btnThem.IconPadding = 10;
            this.btnThem.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnThem.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnThem.IconSize = 25;
            this.btnThem.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.IdleBorderRadius = 30;
            this.btnThem.IdleBorderThickness = 1;
            this.btnThem.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.IdleIconLeftImage = null;
            this.btnThem.IdleIconRightImage = null;
            this.btnThem.IndicateFocus = false;
            this.btnThem.Location = new System.Drawing.Point(138, 173);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThem.OnDisabledState.BorderRadius = 30;
            this.btnThem.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThem.OnDisabledState.BorderThickness = 1;
            this.btnThem.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThem.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThem.OnDisabledState.IconLeftImage = null;
            this.btnThem.OnDisabledState.IconRightImage = null;
            this.btnThem.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnThem.onHoverState.BorderRadius = 30;
            this.btnThem.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThem.onHoverState.BorderThickness = 1;
            this.btnThem.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnThem.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnThem.onHoverState.IconLeftImage = null;
            this.btnThem.onHoverState.IconRightImage = null;
            this.btnThem.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.OnIdleState.BorderRadius = 30;
            this.btnThem.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThem.OnIdleState.BorderThickness = 1;
            this.btnThem.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnThem.OnIdleState.IconLeftImage = null;
            this.btnThem.OnIdleState.IconRightImage = null;
            this.btnThem.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThem.OnPressedState.BorderRadius = 30;
            this.btnThem.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThem.OnPressedState.BorderThickness = 1;
            this.btnThem.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThem.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnThem.OnPressedState.IconLeftImage = null;
            this.btnThem.OnPressedState.IconRightImage = null;
            this.btnThem.Size = new System.Drawing.Size(143, 45);
            this.btnThem.TabIndex = 65;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThem.TextMarginLeft = 0;
            this.btnThem.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnThem.UseDefaultRadiusAndThickness = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.AllowAnimations = true;
            this.btnSua.AllowMouseEffects = true;
            this.btnSua.AllowToggling = false;
            this.btnSua.AnimationSpeed = 200;
            this.btnSua.AutoGenerateColors = false;
            this.btnSua.AutoRoundBorders = false;
            this.btnSua.AutoSizeLeftIcon = true;
            this.btnSua.AutoSizeRightIcon = true;
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.ButtonTextMarginLeft = 0;
            this.btnSua.ColorContrastOnClick = 45;
            this.btnSua.ColorContrastOnHover = 45;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnSua.CustomizableEdges = borderEdges5;
            this.btnSua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSua.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSua.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSua.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSua.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSua.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSua.IconMarginLeft = 11;
            this.btnSua.IconPadding = 10;
            this.btnSua.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSua.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSua.IconSize = 25;
            this.btnSua.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.IdleBorderRadius = 30;
            this.btnSua.IdleBorderThickness = 1;
            this.btnSua.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.IdleIconLeftImage = null;
            this.btnSua.IdleIconRightImage = null;
            this.btnSua.IndicateFocus = false;
            this.btnSua.Location = new System.Drawing.Point(340, 173);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSua.OnDisabledState.BorderRadius = 30;
            this.btnSua.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSua.OnDisabledState.BorderThickness = 1;
            this.btnSua.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSua.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSua.OnDisabledState.IconLeftImage = null;
            this.btnSua.OnDisabledState.IconRightImage = null;
            this.btnSua.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSua.onHoverState.BorderRadius = 30;
            this.btnSua.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSua.onHoverState.BorderThickness = 1;
            this.btnSua.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSua.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSua.onHoverState.IconLeftImage = null;
            this.btnSua.onHoverState.IconRightImage = null;
            this.btnSua.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.OnIdleState.BorderRadius = 30;
            this.btnSua.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSua.OnIdleState.BorderThickness = 1;
            this.btnSua.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSua.OnIdleState.IconLeftImage = null;
            this.btnSua.OnIdleState.IconRightImage = null;
            this.btnSua.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSua.OnPressedState.BorderRadius = 30;
            this.btnSua.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSua.OnPressedState.BorderThickness = 1;
            this.btnSua.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSua.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSua.OnPressedState.IconLeftImage = null;
            this.btnSua.OnPressedState.IconRightImage = null;
            this.btnSua.Size = new System.Drawing.Size(143, 45);
            this.btnSua.TabIndex = 66;
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSua.TextMarginLeft = 0;
            this.btnSua.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSua.UseDefaultRadiusAndThickness = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AllowAnimations = true;
            this.btnXoa.AllowMouseEffects = true;
            this.btnXoa.AllowToggling = false;
            this.btnXoa.AnimationSpeed = 200;
            this.btnXoa.AutoGenerateColors = false;
            this.btnXoa.AutoRoundBorders = false;
            this.btnXoa.AutoSizeLeftIcon = true;
            this.btnXoa.AutoSizeRightIcon = true;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.ButtonText = "Xóa";
            this.btnXoa.ButtonTextMarginLeft = 0;
            this.btnXoa.ColorContrastOnClick = 45;
            this.btnXoa.ColorContrastOnHover = 45;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnXoa.CustomizableEdges = borderEdges6;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXoa.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXoa.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXoa.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnXoa.IconMarginLeft = 11;
            this.btnXoa.IconPadding = 10;
            this.btnXoa.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnXoa.IconSize = 25;
            this.btnXoa.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.IdleBorderRadius = 30;
            this.btnXoa.IdleBorderThickness = 1;
            this.btnXoa.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.IdleIconLeftImage = null;
            this.btnXoa.IdleIconRightImage = null;
            this.btnXoa.IndicateFocus = false;
            this.btnXoa.Location = new System.Drawing.Point(547, 173);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXoa.OnDisabledState.BorderRadius = 30;
            this.btnXoa.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.OnDisabledState.BorderThickness = 1;
            this.btnXoa.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXoa.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXoa.OnDisabledState.IconLeftImage = null;
            this.btnXoa.OnDisabledState.IconRightImage = null;
            this.btnXoa.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXoa.onHoverState.BorderRadius = 30;
            this.btnXoa.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.onHoverState.BorderThickness = 1;
            this.btnXoa.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXoa.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.onHoverState.IconLeftImage = null;
            this.btnXoa.onHoverState.IconRightImage = null;
            this.btnXoa.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.OnIdleState.BorderRadius = 30;
            this.btnXoa.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.OnIdleState.BorderThickness = 1;
            this.btnXoa.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.OnIdleState.IconLeftImage = null;
            this.btnXoa.OnIdleState.IconRightImage = null;
            this.btnXoa.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXoa.OnPressedState.BorderRadius = 30;
            this.btnXoa.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.OnPressedState.BorderThickness = 1;
            this.btnXoa.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXoa.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.OnPressedState.IconLeftImage = null;
            this.btnXoa.OnPressedState.IconRightImage = null;
            this.btnXoa.Size = new System.Drawing.Size(143, 45);
            this.btnXoa.TabIndex = 67;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoa.TextMarginLeft = 0;
            this.btnXoa.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnXoa.UseDefaultRadiusAndThickness = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // GiaCu
            // 
            this.GiaCu.DataPropertyName = "GiaCu";
            this.GiaCu.HeaderText = "Giá cũ";
            this.GiaCu.Name = "GiaCu";
            this.GiaCu.ReadOnly = true;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình ảnh";
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.ReadOnly = true;
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã loại";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            // 
            // frmQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 655);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtHinhAnh);
            this.Controls.Add(this.cbbMaLoai);
            this.Controls.Add(this.pcHinhAnh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGiaCu);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmQLSanPham";
            this.Text = "frmQLSanPham";
            this.Load += new System.EventHandler(this.frmQLSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGiaCu;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pcHinhAnh;
        private System.Windows.Forms.ComboBox cbbMaLoai;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThem;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSua;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;

    }
}