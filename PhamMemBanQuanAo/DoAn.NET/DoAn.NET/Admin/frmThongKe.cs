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
    public partial class frmThongKe : Form
    {
        MySQL r = new MySQL();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            r.LoadThongKe();
            dataGridView1.DataSource = r.GetThongKe();
            lbSoLuong.Text = r.soLuongBan("Select SoLuong from KHACHHANG kh,DONHANG dh,SANPHAM sp where kh.TenDangNhap=dh.TenDangNhapKhachHang and dh.MaSP=sp.MaSP and TrangThai=N'Đã giao'").ToString();
            lbTongTien.Text = r.tongTien("Select TongTien from KHACHHANG kh,DONHANG dh,SANPHAM sp where kh.TenDangNhap=dh.TenDangNhapKhachHang and dh.MaSP=sp.MaSP and TrangThai=N'Đã giao'").ToString();
        }
    }
}
