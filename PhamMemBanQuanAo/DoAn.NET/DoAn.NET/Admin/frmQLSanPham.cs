using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace DoAn.NET
{
    public partial class frmQLSanPham : Form
    {
        MySQL r = new MySQL();
        public frmQLSanPham()
        {
            InitializeComponent();
        }

        private void frmQLSanPham_Load(object sender, EventArgs e)
        {
            r.LoadToTable("SANPHAM");
            dataGridView1.DataSource = r.GetTable("SANPHAM");
            r.LoadComboBoxTen(cbbMaLoai, "TenLoai", "MaLoai", "LOAISANPHAM");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "" || txtTenSP.Text == "" || txtGiaBan.Text == "" || txtGiaCu.Text == "" || txtMoTa.Text == "" || txtHinhAnh.Text == "" || cbbMaLoai.Text == "")
            {
                MessageBox.Show("Nhập thông tin thiếu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int giaBan = Convert.ToInt32(txtGiaBan.Text);
                int giaCu = Convert.ToInt32(txtGiaCu.Text);
                if (r.themSanPham(txtMaSP.Text, txtTenSP.Text, giaBan, giaCu, txtMoTa.Text, txtHinhAnh.Text, cbbMaLoai.Text) == true)
                {
                    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Thêm không thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "" || txtTenSP.Text == "" || txtGiaBan.Text == "" || txtGiaCu.Text == "" || txtMoTa.Text == "" || txtHinhAnh.Text == "" || cbbMaLoai.Text == "")
            {
                MessageBox.Show("Nhập thông tin thiếu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ma = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (r.xoaSanPham(ma) == true)
                {
                    MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Xóa không thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "" || txtTenSP.Text == "" || txtGiaBan.Text == "" || txtGiaCu.Text == "" || txtMoTa.Text == "" || txtHinhAnh.Text == "" || cbbMaLoai.Text == "")
            {
                MessageBox.Show("Nhập thông tin thiếu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int giaBan = Convert.ToInt32(txtGiaBan.Text);
                int giaCu = Convert.ToInt32(txtGiaCu.Text);
                if (r.suaSanPham(txtMaSP.Text, txtTenSP.Text, giaBan, giaCu, txtMoTa.Text, txtHinhAnh.Text, cbbMaLoai.Text) == true)
                {
                    MessageBox.Show("Sửa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Sửa không thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtMaSP.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenSP.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtGiaBan.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtGiaCu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtMoTa.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
            string ha = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtHinhAnh.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string duongDanHienTai = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));// lấy đường dẫn vào project 
            if (ha != "")
            {
                pcHinhAnh.Image = Image.FromFile(duongDanHienTai + @"\Images\" + ha);
            }
            else
            {
                pcHinhAnh.Image = Image.FromFile(duongDanHienTai + @"\Images\" + "Rong.png");
            }
            cbbMaLoai.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
