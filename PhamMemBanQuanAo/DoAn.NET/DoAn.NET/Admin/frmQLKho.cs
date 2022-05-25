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
    public partial class frmQLKho : Form
    {
        MySQL r = new MySQL();
        public frmQLKho()
        {
            InitializeComponent();
        }
        private void frmQLKho_Load(object sender, EventArgs e)
        {
            r.LoadToKHO();
            dataGridView1.DataSource = r.GetTable("KHO");
            r.LoadComboBoxTen(cbbMaSP,"MaSP","MaSP","SANPHAM");
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            cbbMaSP.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSoLuong.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtKichThuoc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbbMaSP.Text == "" || txtSoLuong.Text == "" || txtKichThuoc.Text == "" )
            {
                MessageBox.Show("Nhập thông tin thiếu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //if (r.them("KHO", " '" + cbbMaSP.Text + "','" + txtSoLuong.Text + "','" + txtKichThuoc.Text + "'") == true)
                //{
                //    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //}
                //else
                //{
                //    MessageBox.Show("Thêm không thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                if(r.themKho(cbbMaSP.Text,Convert.ToInt32(txtSoLuong.Text),txtKichThuoc.Text))
                { 
                    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Thêm không thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
            //dataGridView1.DataSource = null;
            //r.LoadToKHO();
            //dataGridView1.DataSource = r.GetTable("KHO");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbbMaSP.Text == "" || txtSoLuong.Text == "" || txtKichThuoc.Text == "")
            {
                MessageBox.Show("Nhập thông tin thiếu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (r.suaKho(cbbMaSP.Text, txtKichThuoc.Text, Convert.ToInt32(txtSoLuong.Text)))
                {
                    MessageBox.Show("Sửa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Sửa không thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
            //dataGridView1.DataSource = null;
            //r.LoadToKHO();
            //dataGridView1.DataSource = r.GetTable("KHO");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbbMaSP.Text == "" || txtSoLuong.Text == "" || txtKichThuoc.Text == "")
            {
                MessageBox.Show("Nhập thông tin thiếu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (r.xoaKho(cbbMaSP.Text,  txtKichThuoc.Text))
                {
                    MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Xóa không thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
            //dataGridView1.DataSource = null;
            //r.LoadToKHO();
            //dataGridView1.DataSource = r.GetTable("KHO");
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
