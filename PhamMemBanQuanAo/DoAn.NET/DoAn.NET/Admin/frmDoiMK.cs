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
    public partial class frmDoiMK : Form
    {
        MySQL r = new MySQL();
        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(txtTenAdmin.Text=="" || txtMatKhau.Text=="" || txtMatKhauLL.Text=="")
            {
                MessageBox.Show("Nhập thông tin thiếu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (r.doiMatKhau(txtTenAdmin.Text, txtMatKhau.Text, 1) == true && txtMatKhau.Text == txtMatKhauLL.Text)
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
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {
            r.LoadToTable("QUANTRIVIEN");

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
