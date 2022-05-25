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
    public partial class ItemLichSu : Bunifu.UI.WinForms.BunifuUserControl
    {
        
        public ItemLichSu(DonHang dh, string duongDanHienTai)
        {
            InitializeComponent();

            lblTenSP.Text = dh.TenSP;            
            lblSize.Text += dh.KichCo;
            lblSoLuong.Text = "x"+dh.SoLuong;
            lblTongTien.Text = dh.TongTien + "đ";
            picSanPham.Image = Image.FromFile(duongDanHienTai + @"\Images\" + dh.HinhAnh);
        }

    }
}
