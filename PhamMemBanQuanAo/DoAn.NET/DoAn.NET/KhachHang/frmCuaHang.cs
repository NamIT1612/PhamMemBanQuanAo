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
    public partial class frmCuaHang : Form
    {
        private string tenDN;
        SanPham SP = new SanPham();

        public string TenDN
        {
            set { tenDN = value.ToLower(); }
        }
        
        public frmCuaHang(string tenDN)
        {
            InitializeComponent();
            this.tenDN = tenDN;
        }

        private void frmCuaHang_Load(object sender, EventArgs e)
        {
            List<SanPham> ListSP = SP.loadTatCaDuLieu();
            if (ListSP.Count == 0)
                flowLayoutSanPham.Controls.Add(lblThongBao);
            else
            loadDuLieu(ListSP);
        }

        //load tất cả dữ liệu sản phẩm
        private void loadDuLieu(List<SanPham> ListSP)
        {
            flowLayoutSanPham.Controls.Clear();
            string duongDanHienTai = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            foreach (SanPham item in ListSP)
            {
                ItemSanPham iSP = new ItemSanPham(item, tenDN, duongDanHienTai);                
                flowLayoutSanPham.Controls.Add(iSP);
            }
        }

        private void txtTimSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtTimSP.Text.Length == 0)
            {
                txtTimSP.Focus();
                return;
            }
            if (e.KeyCode == Keys.Enter)
            {
                List<SanPham> ListSP = SP.timSanPhamTheoTen(txtTimSP.Text);
                if (ListSP.Count==0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm có tên " + txtTimSP.Text + "!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtTimSP.Focus();
                }
                else
                {
                    loadDuLieu(ListSP);
                    btnHienTatCaSP.Visible = true;
                }
            }
        }

        private void btnHienTatCaSP_Click(object sender, EventArgs e)
        {
            btnHienTatCaSP.Visible = false;
            List<SanPham> ListSP = SP.loadTatCaDuLieu();
            loadDuLieu(ListSP);
        }

    }
}
