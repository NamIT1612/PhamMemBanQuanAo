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
    public partial class frmGioHang : Form
    {
        private string TenDN;
        public frmGioHang(string tenDN)
        {
            InitializeComponent();
            this.TenDN = tenDN;
        }

        private void frmGioHang_Load(object sender, EventArgs e)
        {
            fowlayPnGioHang.Controls.Clear();
            //load giỏ hàng theo tên đăng nhập của khách hàng
            List<GioHang> listGH = new GioHang().loadGioHangTheoTenDN(TenDN);
            //nếu không có sp thì thông báo là không có
            if(listGH.Count==0)
                fowlayPnGioHang.Controls.Add(lblThongBao);
            else
                loadGioHang(listGH);                       
        }

        private void loadGioHang(List<GioHang> listGH)
        {
            ItemGioHang GH;
            string duongDanHienTai = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            foreach (GioHang item in listGH)
            {
                GH = new ItemGioHang(this, item,TenDN, duongDanHienTai);
                fowlayPnGioHang.Controls.Add(GH);
            }
            
        }

        private void ckbChonALL_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (ckbChonALL.Checked)
            {
                lblChonALL.Text = "Bỏ Chọn Tất Cả";
                foreach (ItemGioHang item in fowlayPnGioHang.Controls.OfType<ItemGioHang>().ToList())
                {
                    item.setChecked(true);
                }
            }
            else
            {
                lblChonALL.Text = "Chọn Tất Cả";
                foreach (ItemGioHang item in fowlayPnGioHang.Controls.OfType<ItemGioHang>().ToList())
                {
                    item.setChecked(false);
                }
            }
        }

        public void checkedALL()
        {
            bool kiemTra = false;
            int kt = 0;
            foreach (ItemGioHang item in fowlayPnGioHang.Controls.OfType<ItemGioHang>().ToList())
            {
                if (item.getChecked())
                {
                    kiemTra = true;
                    kt++;
                }
            }
            //nếu tất cả checkbox có trạng thái là false thì ckbChonALL.Checked = false;
            //và ngược lại
            if (!kiemTra)
                ckbChonALL.Checked = kiemTra;
            if(kt==fowlayPnGioHang.Controls.OfType<ItemGioHang>().ToList().Count && kiemTra)
                ckbChonALL.Checked = kiemTra;
        }

        public void delItemLowlayPnGioHang(ItemGioHang item)
        {
            fowlayPnGioHang.Controls.Remove(item);
            if (fowlayPnGioHang.Controls.Count == 0)
            {
                fowlayPnGioHang.Controls.Add(lblThongBao);
            }
        }

        private void btnDatSPDaChon_Click(object sender, EventArgs e)
        {
            //kiểm tra nếu không chọn sản phẩm nào thì không cho đặt hàng
            int ktChecked = 0;
            foreach (ItemGioHang item in fowlayPnGioHang.Controls.OfType<ItemGioHang>().ToList())
            {
                if (item.getChecked())
                {
                    ktChecked++;
                }
            }
            if (ktChecked == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm đặt hàng!", "Thông báo");
                return;
            }

            DialogResult r = MessageBox.Show("Bạn có muốn đặt các sản phẩm đã chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                foreach (ItemGioHang item in fowlayPnGioHang.Controls.OfType<ItemGioHang>().ToList())
                {
                    if (item.getChecked())
                    {
                        item.DatHang();
                    }
                }
                MessageBox.Show("Đặt hàng thành công!", "Thông báo");
            }
        }
    }
}
