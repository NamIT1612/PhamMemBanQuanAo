using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.NET
{
    public partial class ItemGioHang : Bunifu.UI.WinForms.BunifuUserControl
    {
        //readonly: chỉ đọc
        private readonly frmGioHang _frmGioHang;
        private MySQL mySQL = new MySQL();
        private string TenDN { get; set; }
        private string MaSP { get; set; }
        private string KichCo { get; set; }
        private int SoLuongSP { get; set; }
        private int SoLuongTonKho { get; set; }

        public void setChecked(bool check)
        {
            ckbChon.Checked = check;
        }

        public int soLuongSPHienTai()
        {
            return (SoLuongTonKho + SoLuongSP) - int.Parse(txtSoLuong.Text);
        }

        public double tongTien()
        {
            return double.Parse(lblTongTien.Text.Trim().Split(' ')[1]);
        }

        public bool getChecked()
        {
            return ckbChon.Checked;
        }

        public ItemGioHang(frmGioHang frmGH, GioHang GH, string tenDN, string duongDanHienTai)
        {
            InitializeComponent();
            _frmGioHang = frmGH;
            this.TenDN = tenDN;
            this.MaSP = GH.MaSP;
            this.KichCo = GH.KichCo;
            this.SoLuongSP = GH.SoLuongSP;
            this.SoLuongTonKho = GH.SoLuongTonKho;

            lblTenSP.Text = GH.TenSP;
            lblGiaBan.Text += GH.GiaBan.ToString() + " VNĐ";
            lblSize.Text += GH.KichCo;            
            txtSoLuong.Text = GH.SoLuongSP.ToString();
            lblTongTien.Text ="Tổng " + (GH.SoLuongSP * GH.GiaBan) + " VNĐ";
            picSanPham.Image = Image.FromFile(duongDanHienTai + @"\Images\" + GH.HinhAnh);
        }

        private void picXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn xóa sản phẩm khỏi giỏ hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                //xóa khỏi cơ sở dữ liệu
                new GioHang().xoaSPKhoiGioHang(TenDN, MaSP, KichCo, SoLuongSP);
                //xóa control ra khỏi flowlayout Gio Hang
                _frmGioHang.delItemLowlayPnGioHang(this);
            }
        }

        private void btnSuaSoLuong_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.TextLength == 0)
            {
                txtSoLuong.Text = SoLuongSP.ToString();
                MessageBox.Show("Số lượng không được bỏ trống!", "Thông báo");
                return;
            }
            if (int.Parse(txtSoLuong.Text) > SoLuongTonKho+SoLuongSP)
            {
                txtSoLuong.Text = SoLuongSP.ToString();
                MessageBox.Show("Trong kho hàng chỉ còn " + SoLuongTonKho + " sản phẩm.\n" +
                    "Vui lòng mua ít hơn số lượng trong kho.", "Thông báo");
                return;
            }
            int soLuongKho = (SoLuongTonKho + SoLuongSP) - int.Parse(txtSoLuong.Text);
            if (new GioHang().updateSLSanPhamGioHang(TenDN, MaSP, KichCo, soLuongKho, int.Parse(txtSoLuong.Text)))
            {
                SoLuongTonKho = soLuongKho;
                SoLuongSP = int.Parse(txtSoLuong.Text);
                MessageBox.Show("Lưu số lượng thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lưu số lượng thất bại!", "Thông báo");
            }
        }
        
        private void ckbChon_Click(object sender, System.EventArgs e)
        {
            //khi người dùng tự click tất cả thì sẽ thay đổi trạng thái của nút checkbox trong frmGioHang
            _frmGioHang.checkedALL();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {            
            if (txtSoLuong.TextLength > 0)
            {
                if (int.Parse(txtSoLuong.Text) == 0)
                {
                    txtSoLuong.Text = SoLuongSP.ToString();
                    MessageBox.Show("Số lượng không được nhỏ hơn 1!", "Thông báo");
                    return;
                }
                
                string[] gia = lblGiaBan.Text.Trim().Split(' ');
                double giaBan = double.Parse(gia[1]);
                string tongtien = (int.Parse(txtSoLuong.Text) * giaBan).ToString();
                lblTongTien.Text = "Tổng " + tongtien + " VNĐ";
                
                if(int.Parse(txtSoLuong.Text)>SoLuongTonKho+SoLuongSP)
                {
                    txtSoLuong.Text = (SoLuongTonKho + SoLuongSP).ToString();
                    MessageBox.Show("Trong kho chỉ còn " + (SoLuongTonKho + SoLuongSP) + " sản phẩm", "Thông báo");
                }
            }
            else
            {
                lblTongTien.Text = "Tổng 0 VNĐ";
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.TextLength == 0)
            {
                txtSoLuong.Text = SoLuongSP.ToString();
            }
            DialogResult r = MessageBox.Show("Bạn có muốn đặt hàng " + txtSoLuong.Text + " sản phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {                
                GioHang gh = new GioHang();
                if (gh.datHangGioHang(TenDN, MaSP, KichCo,
                int.Parse(txtSoLuong.Text), tongTien(), txtGhiChu.Text, soLuongSPHienTai()))
                {
                    gh.xoaSPKhoiGioHang(TenDN, MaSP, KichCo, 0);
                    _frmGioHang.delItemLowlayPnGioHang(this);
                    MessageBox.Show("Đặt hàng thành công!", "Thông báo");                    
                }
                else
                {
                    MessageBox.Show("Đặt hàng thất bại!", "Thông báo");
                }
            }
        }

        public void DatHang()
        {
            if (txtSoLuong.TextLength == 0)
            {
                txtSoLuong.Text = SoLuongSP.ToString();
            }
            GioHang gh = new GioHang();
            if (gh.datHangGioHang(TenDN, MaSP, KichCo,
                int.Parse(txtSoLuong.Text), tongTien(), txtGhiChu.Text, soLuongSPHienTai()))
            {
                gh.xoaSPKhoiGioHang(TenDN, MaSP, KichCo, 0);
                _frmGioHang.delItemLowlayPnGioHang(this);
            }
            else
            {
                MessageBox.Show("Đặt hàng " + lblTenSP.Text + " thất bại!", "Thông báo");
            }
        }

    }
}
