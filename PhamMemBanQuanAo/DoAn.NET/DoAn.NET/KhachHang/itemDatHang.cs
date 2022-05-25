using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.NET
{
    partial class itemDatHang : Form
    {
        private string tenDN;
        private string maSP;
        private double giaBan;
        MySQL mySQL = new MySQL();
        List<Kho> listKho = new List<Kho>();

        public itemDatHang(string tenDN, string maSP, double giaBan)
        {
            InitializeComponent();
            this.tenDN = tenDN;
            this.maSP = maSP;
            this.giaBan = giaBan;
            listKho = new Kho().loadKho(maSP);
        }

        private void itemDatHang_Load(object sender, EventArgs e)
        {
            cboSize.Items.Clear();
            //load size lên combobox size
            foreach (Kho item in listKho)
            {
                cboSize.Items.Add(item.KichCo);
            }
            //mặc định là giá trị đầu tiên
            cboSize.SelectedIndex = 0;

            //thay đổi số lượng hiện tại của size
            int soLuongHienTai = listKho[0].SoLuongTonKho;
            thayDoi_lblSoLuong(soLuongHienTai);  

            txtTongTien.Text = (double.Parse(txtSoLuong.Text) * giaBan).ToString() + " VNĐ";
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.TextLength > 0)
            {
                if (int.Parse(txtSoLuong.Text) == 0)
                {
                    txtSoLuong.Text = "1";
                    MessageBox.Show("Số lượng không được nhỏ hơn 1!", "Thông báo");
                }
                else
                    txtTongTien.Text = (double.Parse(txtSoLuong.Text) * giaBan).ToString() + " VNĐ";
            }                
            else
            {
                txtTongTien.Clear();
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
                MessageBox.Show("Vui lòng nhập số lượng cần mua!", "Thông báo");
                return;
            }

            if (!kiemTraSoLuong(int.Parse(txtSoLuong.Text)))
            {
                MessageBox.Show("Số lượng cần mua phải nhỏ hơn số lượng trong kho!", "Thông báo");
                return;
            }

            //thay đổi số lượng hiện tại của size. 
            //lấy số lượng của size hiện tại trừ cho số lượng người dùng mua
            int soLuongHienTai = int.Parse(lblSoLuongSP.Text.Trim().Split(' ')[1]) - int.Parse(txtSoLuong.Text);
            thayDoi_lblSoLuong(soLuongHienTai);

            string[] tongTien = txtTongTien.Text.Trim().Split(' ');
            if (new GioHang().datHangGioHang(tenDN, maSP, cboSize.SelectedItem.ToString(),
                int.Parse(txtSoLuong.Text), double.Parse(tongTien[0]), txtGhiChu.Text, soLuongHienTai))
            {
                MessageBox.Show("Đặt hàng thành công!", "Thông báo");
            }
        }

        private bool kiemTraSoLuong(int slMuonMua)
        {
            //lấy text của số lượng
            string[] soLuong = lblSoLuongSP.Text.Trim().Split(' ');
            int sl = int.Parse(soLuong[1]);
            if (slMuonMua <= sl)
                return true;
            return false;
        }

        private void thayDoi_lblSoLuong(int soLuongHienTai)
        {
            //lấy text của số lượng
            string[] soLuong = lblSoLuongSP.Text.Trim().Split(' ');
            //set số lượng bằng với size hiện tại. 
            //vd: size S còn 10 sản phẩm
            soLuong[1] = soLuongHienTai.ToString();
            lblSoLuongSP.Text = "";
            //load lại chuỗi vào lblSoLuongSP
            foreach (string s in soLuong)
            {
                lblSoLuongSP.Text += s + " ";
            }
        }
    }
}
