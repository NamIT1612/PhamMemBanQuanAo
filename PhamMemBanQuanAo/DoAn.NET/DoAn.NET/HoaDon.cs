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
    public partial class HoaDon : Form
    {
        MySQL r = new MySQL();
        private string TenDN;
        public HoaDon(string tenDN)
        {
            InitializeComponent();
            this.TenDN = tenDN;
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLQA.DONHANG' table. You can move, or remove it, as needed.
            this.DONHANGTableAdapter.Fill(this.QLQA.DONHANG, TenDN, "Chưa giao");

            this.reportViewer1.RefreshReport();
           lbSoLuong.Text = r.soLuongBan("Select SoLuong from KHACHHANG kh,DONHANG dh,SANPHAM sp where kh.TenDangNhap=dh.TenDangNhapKhachHang and dh.MaSP=sp.MaSP and TrangThai=N'Chưa giao' and dh.TenDangNhapKhachHang='"+TenDN+"'").ToString();
           lbTongTien.Text = r.tongTien("Select TongTien from KHACHHANG kh,DONHANG dh,SANPHAM sp where kh.TenDangNhap=dh.TenDangNhapKhachHang and dh.MaSP=sp.MaSP and TrangThai=N'Chưa giao' and dh.TenDangNhapKhachHang='"+TenDN+"'").ToString();
        }
    }
}
