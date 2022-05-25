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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        MySQL r = new MySQL();
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.ShowDialog();
            m.Close();
        }
        public string checkGT()
        {
            string gt;
            if (rdNam.Checked)
                return gt = rdNam.Text;
            return gt = rdNu.Text;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {

            if(txtTaiKhoan.Text=="" ||txtMatKhau.Text==""||txtHoTen.Text==""||txtSDT.Text==""||txtMail.Text==""||txtDiaChi.Text=="")
            {
                MessageBox.Show("Hãy nhập thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                
                string sql="'"+txtTaiKhoan.Text+"','"+txtMatKhau.Text+"',N'"+txtHoTen.Text+"','"+txtSDT.Text+"','"+txtMail.Text+"',N'"+txtDiaChi.Text+"',N'"+checkGT()+"'";
                if(r.them("KHACHHANG",sql)==true)
                {
                    MessageBox.Show("Đăng Ký thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DangNhap dn = new DangNhap();
                    this.Hide();
                    dn.Show();
                   
                }
                else
                {
                    MessageBox.Show("không đăng ký thành công!!", "Trùng Tên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTaiKhoan_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = "";
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
        }

        private void txtHoTen_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
        }

        private void txtSDT_Click(object sender, EventArgs e)
        {
            txtSDT.Text = "";
        }

        private void txtMail_Click(object sender, EventArgs e)
        {
            txtMail.Text = "";
        }

        private void txtDiaChi_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = "";
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar='*';
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Hide();
                Main m = new Main();
                m.ShowDialog();
                m.Close();
            }
        }

        
    }
}
