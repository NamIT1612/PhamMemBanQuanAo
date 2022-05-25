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
    public partial class frmQLKhachHang : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-UNN3T1U\\SQL;Initial Catalog= QL_ShopQuanAo; Persist Security Info= true;User ID=sa;Password=123");
        MySQL r = new MySQL();
        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            //String sql = "Select TenDangNhap,HoTen,SoDT,Email,DiaChi,GioiTinh from KHACHHANG";
            //SqlDataAdapter da = new SqlDataAdapter(sql, con);
            //DataTable tb = new DataTable();
            //da.Fill(tb);
            //lstView.Items.Clear();
            //lstView.View = View.Details;
            //lstView.Columns.Add("ID");
            //lstView.Columns.Add("Tên đăng nhập");
            //lstView.Columns.Add("Họ tên");
            //lstView.Columns.Add("Số điện thoại");
            //lstView.Columns.Add("Email");
            //lstView.Columns.Add("Địa chỉ");
            //lstView.Columns.Add("Giới tính");
            //lstView.GridLines = true;
            //lstView.FullRowSelect = true;
            //int i = 0;
            //foreach (DataRow row in tb.Rows)
            //{
            //    int stt = lstView.Items.Count + 1;
            //    lstView.Items.Add(stt.ToString());
            //    lstView.Items[i].SubItems.Add(row["TenDangNhap"].ToString());
            //    lstView.Items[i].SubItems.Add(row["HoTen"].ToString());
            //    lstView.Items[i].SubItems.Add(row["SoDT"].ToString());
            //    lstView.Items[i].SubItems.Add(row["Email"].ToString());
            //    lstView.Items[i].SubItems.Add(row["DiaChi"].ToString());
            //    lstView.Items[i].SubItems.Add(row["GioiTinh"].ToString());
            //    i++;
            //}
            r.LoadToTable("KHACHHANG");
            dataGridView1.DataSource = r.GetTable("KHACHHANG");
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtTenDN.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMatKhau.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtHoVaTen.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDienThoai.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cbGioiTinh.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "" || txtMatKhau.Text == "" || txtHoVaTen.Text == "" || txtDienThoai.Text == "" || txtEmail.Text == "" || txtDiaChi.Text == "" || cbGioiTinh.Text == "")
            {
                MessageBox.Show("Nhập thông tin thiếu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (r.themKhachHang(txtTenDN.Text, txtMatKhau.Text, txtHoVaTen.Text, txtDienThoai.Text, txtEmail.Text, txtDiaChi.Text, cbGioiTinh.Text) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "" || txtMatKhau.Text == "" || txtHoVaTen.Text == "" || txtDienThoai.Text == "" || txtEmail.Text == "" || txtDiaChi.Text == "" || cbGioiTinh.Text == "")
            {
                MessageBox.Show("Nhập thông tin thiếu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (r.suaKhachHang(txtTenDN.Text, txtMatKhau.Text, txtHoVaTen.Text, txtDienThoai.Text, txtEmail.Text, txtDiaChi.Text, cbGioiTinh.Text) == true)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "" || txtMatKhau.Text == "" || txtHoVaTen.Text == "" || txtDienThoai.Text == "" || txtEmail.Text == "" || txtDiaChi.Text == "" || cbGioiTinh.Text == "")
            {
                MessageBox.Show("Nhập thông tin thiếu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ten = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (r.xoaKhachHang(ten) == true)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
