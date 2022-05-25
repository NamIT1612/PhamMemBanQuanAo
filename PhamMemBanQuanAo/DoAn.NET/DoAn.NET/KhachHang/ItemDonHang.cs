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
    public partial class ItemDonHang : Bunifu.UI.WinForms.BunifuUserControl
    {
        MySQL cn = new MySQL();
        private readonly frmDonHang _frmDonHang;
        public string TenDN { get; set; }
        public string MaSP { get; set; }
        public string KichCo { get; set; }
        public int SoLuongSP { get; set; }
        private string MaDH { get; set; }

        public ItemDonHang(frmDonHang frmDH, DonHang dh,string TenDN, string duongDanHienTai)
        {
            InitializeComponent();
            _frmDonHang = frmDH;
            this.TenDN = TenDN;
            this.MaSP = dh.MaSP;
            this.MaDH = dh.MaDonHang;
            this.SoLuongSP = dh.SoLuong;
            this.KichCo = dh.KichCo;

            lblTenSP.Text = dh.TenSP;            
            lblSize.Text += dh.KichCo;
            lblSoLuong.Text = "x"+dh.SoLuong;
            lblTongTien.Text = dh.TongTien + "đ";
            picSanPham.Image = Image.FromFile(duongDanHienTai + @"\Images\" + dh.HinhAnh);
        }

        private void picHuy_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn hủy đơn hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (new DonHang().xoaSPKhoiDonHang(MaDH, TenDN, MaSP, KichCo, SoLuongSP)) 
                {
                    _frmDonHang.delItemFlowLayPnDonHang(this);
                }
                else
                {
                    MessageBox.Show("Hủy thất bại!", "Thông báo");
                }
                
            }
        }

        private void pcGiao_Click(object sender, EventArgs e)
        {
           
        }

    }
}
