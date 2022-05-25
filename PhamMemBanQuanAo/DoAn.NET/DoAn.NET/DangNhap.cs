using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.NET
{
    public partial class DangNhap : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-QAP7SKJ;Initial Catalog= QuanLy_ShopQuanAo; Persist Security Info= true;User ID=sa;Password=123");
        MySQL r = new MySQL();
        public string tenDangNhap;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.ShowDialog();
            m.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap.TextLength == 0 || txtMatKhau.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    r.dangNhap(txtTenDangNhap.Text, txtMatKhau.Text,this);
                    txtTenDangNhap.Focus();
                    r.tenDangNhap = txtTenDangNhap.Text.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void txtTenDangNhap_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "";
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
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
