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
    public partial class frmQLHoaDon : Form
    {
        MySQL r = new MySQL();
        public frmQLHoaDon()
        {
            InitializeComponent();
        }

        private void frmQLHoaDon_Load(object sender, EventArgs e)
        {
            r.LoadToTable("DONHANG");
            dataGridView1.DataSource = r.GetTable("DONHANG");
            r.LoadComboBoxTen(cbbMaSP, "MaSP", "TenSP", "SANPHAM");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(r.suaDonHang(txtMaDH.Text,txtTenKH.Text,cbbMaSP.Text,Convert.ToInt32(txtSoLuong.Text),Convert.ToDouble(txtTongTien.Text),txtKichCo.Text,txtNgayDH.Text,txtNgayGH.Text,txtTrangThai.Text,txtGhiChu.Text)==true)
            {
                MessageBox.Show("Sửa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa không thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (r.xoaDonHang(ma) == true)
            {
                MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa không thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtMaDH.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbbMaSP.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTongTien.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtKichCo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtNgayDH.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtNgayGH.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtTrangThai.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtGhiChu.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if(txtMaDH.Text!="")
            {
                string ngayHT = now.ToString();
                if(r.capNhatTT(txtMaDH.Text,"Đã giao",ngayHT))
                {
                    MessageBox.Show("Cập nhật thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon(txtTenKH.Text);
            hd.Show();
        }
    }
}
