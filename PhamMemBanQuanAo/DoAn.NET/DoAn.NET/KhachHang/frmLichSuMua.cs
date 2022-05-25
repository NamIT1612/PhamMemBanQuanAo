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
    public partial class frmLichSuMua : Form
    {
        private string TenDN;
        public frmLichSuMua(string tenDN)
        {
            InitializeComponent();
            this.TenDN = tenDN;
        }

        private void frmLichSuMua_Load(object sender, EventArgs e)
        {
            flowLayPnLichSu.Controls.Clear();
            //load Lịch sử mua hàng theo tên đăng nhập của khách hàng
            List<DonHang> listDH = new DonHang().loadDonHangDaGiao(TenDN);
            //nếu không có Lịch sử mua hàng thì thông báo là không có
            if (listDH.Count == 0)
                flowLayPnLichSu.Controls.Add(lblThongBao);
            else
                loadDonHang(listDH);    
        }

        private void loadDonHang(List<DonHang> listDH)
        {
            ItemLichSu DH;
            string duongDanHienTai = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            foreach (DonHang item in listDH)
            {
                DH = new ItemLichSu(item, duongDanHienTai);
                flowLayPnLichSu.Controls.Add(DH);
            }

        }
    }
}
