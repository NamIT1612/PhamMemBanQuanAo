using DoAn.NET.KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.NET
{
    public partial class frmKhachHang : Form
    {
        private string tenDN;

        public string TenDN
        {
            set { tenDN = value.ToUpper(); }
        }

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            btnTenDangNhap.Text = tenDN;
            loadChildForm(new frmBanner());
        }

        private void btnCuaHang_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = btnCuaHang.Text;
            loadChildForm(new frmCuaHang(tenDN));
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = btnGioHang.Text;
            loadChildForm(new frmGioHang(tenDN));
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = btnDonHang.Text;
            loadChildForm(new frmDonHang(tenDN));
        }

        private void btnLichSuMua_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = btnLichSuMua.Text;
            loadChildForm(new frmLichSuMua(tenDN));
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = btnCaiDat.Text;
            loadChildForm(new frmCaiDat(tenDN));
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thông báo thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Visible = false;
                Main main = new Main();
                main.ShowDialog();
            }
            
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "TRANG CHỦ";
        }

        //load form con hiển thị vào panelChildFrom
        private void loadChildForm(Form frmChild)
        {
            panelChildFrom.Controls.Clear();
            frmChild.TopLevel = false;
            panelChildFrom.Controls.Add(frmChild);
            frmChild.Dock = DockStyle.Fill;
            frmChild.Show();
        }

        private void btnTenDangNhap_Click(object sender, EventArgs e)
        {

        }

        
    }
}
