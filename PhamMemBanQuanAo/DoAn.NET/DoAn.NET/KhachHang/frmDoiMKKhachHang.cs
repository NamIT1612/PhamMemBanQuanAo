using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.NET.KhachHang
{
    public partial class frmDoiMKKhachHang : Form
    {
        private string tenDN;
        public frmDoiMKKhachHang(string tenDN)
        {
            InitializeComponent();
            this.tenDN = tenDN;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtTenAdmin.TextLength == 0 || txtMatKhau.TextLength == 0 || txtMatKhauLL.TextLength == 0)
            {
                MessageBox.Show("Nhập thông tin thiếu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (new MySQL().doiMKKhachHang(txtTenAdmin.Text, txtMatKhau.Text) && txtMatKhau.Text == txtMatKhauLL.Text)
            {
                MessageBox.Show("Đổi mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Text = "";
                txtMatKhauLL.Text = "";
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {
            txtTenAdmin.Text = tenDN;
        }

        private void frmDoiMK_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != txtMatKhauLL.Text)
            {
                lbThongBao.Text = "nhập sai mật khẩu lặp!";
                btnDoiMatKhau.Enabled = false;
            }
            else
            {
                btnDoiMatKhau.Enabled = true;
            }
        }

        private void txtMatKhauLL_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != txtMatKhauLL.Text)
            {
                lbThongBao.Text = "nhập sai mật khẩu lặp!";
                btnDoiMatKhau.Enabled = false;
            }
            else
            {
                lbThongBao.Text = "";
                btnDoiMatKhau.Enabled = true;
            }
        }

    }
}
