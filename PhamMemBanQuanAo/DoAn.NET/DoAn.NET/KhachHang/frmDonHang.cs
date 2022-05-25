using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.NET
{
    public partial class frmDonHang : Form
    {
        private string TenDN;
        public frmDonHang(string tenDN)
        {
            InitializeComponent();
            this.TenDN = tenDN;
            
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            flowLayPnDonHang.Controls.Clear();
            //load đơn hàng theo tên đăng nhập của khách hàng
            List<DonHang> listDH = new DonHang().loadDonHangChuaGiao(TenDN);
            //nếu không có đơn hàng thì thông báo là không có
            if (listDH.Count == 0)
                flowLayPnDonHang.Controls.Add(lblThongBao);
            else
                loadDonHang(listDH);    
        }

        private void loadDonHang(List<DonHang> listDH)
        {
            ItemDonHang DH;
            string duongDanHienTai = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            foreach (DonHang item in listDH)
            {
                DH = new ItemDonHang(this, item, TenDN,duongDanHienTai);
                flowLayPnDonHang.Controls.Add(DH);
            }

        }

        public void delItemFlowLayPnDonHang(ItemDonHang item)
        {
            flowLayPnDonHang.Controls.Remove(item);
            if (flowLayPnDonHang.Controls.Count == 0)
            {
                flowLayPnDonHang.Controls.Add(lblThongBao);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon(TenDN);
            hd.Show();
        }
    }
}
