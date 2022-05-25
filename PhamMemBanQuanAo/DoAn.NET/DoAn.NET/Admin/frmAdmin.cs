using DoAn.NET.KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.NET
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

            loadChildForm(new frmBanner());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            lbTieuDe.Text = btnKhachHang.Text;
            loadChildForm(new frmQLKhachHang());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            lbTieuDe.Text = btnSanPham.Text;
            loadChildForm(new frmQLSanPham());
        }
        private void btnKho_Click(object sender, EventArgs e)
        {
            lbTieuDe.Text = btnKho.Text;
            loadChildForm(new frmQLKho());
        }
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            lbTieuDe.Text = btnHoaDon.Text;
            loadChildForm(new frmQLHoaDon());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            lbTieuDe.Text = btnThongKe.Text;
            loadChildForm(new frmThongKe());
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            lbTieuDe.Text = btnCaiDat.Text;
            loadChildForm(new frmCaiDatAdmin());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Visible = false;
                Main m = new Main();
                m.Show();
            }
        }
        private void loadChildForm(Form frmChild)
        {
            panelForm.Controls.Clear();
            frmChild.TopLevel = false;
            panelForm.Controls.Add(frmChild);
            frmChild.Dock = DockStyle.Fill;
            frmChild.Show();
        }

        private void labelLogo_Click(object sender, EventArgs e)
        {
            lbTieuDe.Text = "TRANG CHỦ ADMIN";
            loadChildForm(new frmBanner());
        }
    }
}
