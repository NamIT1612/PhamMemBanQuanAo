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
    public partial class ItemSanPham : Bunifu.UI.WinForms.BunifuUserControl
    {
        public string TenDN { get; set; }
        public string MaSP { get; set; }
        public string KichCo { get; set; }
        public string moTa { get; set; }
        public string tenSP { get; set; }
        public string giaSP { get; set; }
        
        public Image PIC 
        {
            set { picSP.Image = value; }
        }

        public ItemSanPham(SanPham item, string tenDN, string duongDanHienTai)
        {
            InitializeComponent();
            this.TenDN = tenDN;
            this.MaSP = item.MaSP;
            this.tenSP = item.TenSP;
            this.moTa = item.MoTa;
            this.giaSP = item.GiaBan.ToString() + " VNĐ";
            this.PIC = Image.FromFile(duongDanHienTai + @"\Images\" + item.HinhAnh);
        }

        private void ItemSanPham_MouseLeave(object sender, EventArgs e)
        {
            picSP.Size = new Size(211, 211);
        }

        private void picSP_MouseMove(object sender, MouseEventArgs e)
        {
            picSP.Size = new Size(213, 213);
        }

        private void picThemVaoGioHang_Click(object sender, EventArgs e)
        {
            itemChonSize chonSize = new itemChonSize(TenDN,MaSP);
            chonSize.ShowDialog();
        }

        private void ItemSanPham_Load(object sender, EventArgs e)
        {
            lblGia.Text = giaSP;

            //nếu độ dài tên sản phẩm > 20
            //thì chỉ lấy kí tự từ 0 đến 20
            if (tenSP.Length > 20)
                lblTenSP.Text = tenSP.Substring(0, 20) + "...";
            else
                lblTenSP.Text = tenSP;

            //hiện đầy đủ tên sản phẩm
            ToolTip tipTenSP = new ToolTip();
            tipTenSP.BackColor = Color.White;
            tipTenSP.ForeColor = Color.DodgerBlue;
            tipTenSP.IsBalloon = true;
            string[] mota = moTa.Trim().Split('.');
            string mt = "";
            foreach (string item in mota)
            {
                mt += item + "\n";
            }
            tipTenSP.SetToolTip(lblTenSP, tenSP+"\n"+mt);

        }

        private void picSP_Click(object sender, EventArgs e)
        {
            string[] gia = giaSP.Trim().Split(' ');
            itemDatHang datHang = new itemDatHang(TenDN, MaSP,double.Parse(gia[0]));
            datHang.ShowDialog();
        }
    }
}
