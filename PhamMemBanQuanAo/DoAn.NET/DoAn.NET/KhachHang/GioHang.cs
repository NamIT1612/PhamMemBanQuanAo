using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.NET
{
    public class GioHang:MySQL
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string KichCo { get; set; }
        public int SoLuongSP { get; set; }
        public int SoLuongTonKho { get; set; }
        public double GiaBan { get; set; }
        public string HinhAnh { get; set; }

        public List<GioHang> loadGioHangTheoTenDN(string TenDN)
        {
            string cauLenh = "SELECT GIOHANG.MaSP,TenSP,GIOHANG.KichCo,SoLuongSP,GiaBan,HinhAnh,SoLuongTonKho " +
                "FROM dbo.GIOHANG, dbo.SANPHAM, dbo.KHO " +
                "WHERE TenDangNhapKhachHang = '" + TenDN + "' AND GIOHANG.MaSP=SANPHAM.MaSP AND " +
                "GIOHANG.KichCo = KHO.KichCo AND GIOHANG.MaSP = KHO.MaSP";
            return loadDuLieu(cauLenh);
        }

        public bool themSPVaoGioHang(string tenDN, string maSP, string kichCo, int soLuong)
        {
            //update kho
            string thuocTinhKho = "SoLuongTonKho=SoLuongTonKho-" + soLuong;
            updateSLKho(maSP, kichCo, thuocTinhKho);

            string cauLenhThemSP = "'" + tenDN + "','" + maSP + "','" + kichCo + "', " + soLuong;
            //nếu thêm = false thì đã có sản phẩm đó trong giỏ hàng
            //nên chỉ cần update số lượng hiện có trong giỏ hàng cộng với số lượng cần thêm hiện tại

            if (!them("GIOHANG", cauLenhThemSP))
            {
                string thuocTinhCN = "SoLuongSP=SoLuongSP+" + soLuong;
                string dieuKien = "TenDangNhapKhachHang = '" + tenDN + "' AND MaSP = '" + maSP + "' AND KichCo = '" + kichCo + "'";
                //update thành công
                return sua("GIOHANG", thuocTinhCN, dieuKien);
            }

            //Thêm thành công
            return true;
        }

        public bool xoaSPKhoiGioHang(string tenDN, string maSP, string kichCo, int soLuong)
        {
            //cập nhật lại số lượng trong kho
            string thuocTinh = "SoLuongTonKho=SoLuongTonKho+" + soLuong;
            updateSLKho(maSP, kichCo, thuocTinh);
            //xóa khỏi giỏ hàng
            string dieuKien = "TenDangNhapKhachHang='" + tenDN + "' AND MaSP='" + maSP + "' AND KichCo ='" + kichCo + "'";
            return xoa("GIOHANG",dieuKien);
        }

        public bool updateSLKho(string maSP, string kichCo, string thuocTinh)
        {
            string dieuKien = "MaSP='" + maSP + "' AND KichCo ='" + kichCo + "'";
            return sua("Kho", thuocTinh, dieuKien);
        }

        public bool updateSLSanPhamGioHang(string tenDN, string maSP, string kichCo, int soLuongKho,int soLuongTrongGH)
        {
            //cập nhật lại số lượng trong kho
            string thuocTinhKho = "SoLuongTonKho=" + soLuongKho;
            updateSLKho(maSP, kichCo, thuocTinhKho);
            //cập nhật số lượng trong giỏ hàng
            string thuocTinh = "SoLuongSP=" + soLuongTrongGH;
            string dieuKien = "TenDangNhapKhachHang='"+tenDN+"' AND MaSP='" + maSP + "' AND KichCo ='" + kichCo + "'";
            return sua("GIOHANG",thuocTinh,dieuKien);
        }

        public bool datHangGioHang(string tenDN, string maSP, string kichCo, int soLuong, double TongTien, string ghiChu, int soLuongKho)
        {
            //cập nhật lại số lượng trong kho
            string thuocTinhKho = "SoLuongTonKho=" + soLuongKho;
            updateSLKho(maSP, kichCo, thuocTinhKho);

            //kiểm tra đơn hàng đã có chưa
            int SL = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string lenhKiemTra = "SELECT COUNT(*) FROM dbo.DONHANG WHERE TenDangNhapKhachHang = '" + tenDN + "' AND MaSP='" + maSP + "' AND KichCo = '" + kichCo + "' AND TrangThai= N'Chưa giao'";
                SqlCommand cmd = new SqlCommand(lenhKiemTra, con);
                SL = (int)cmd.ExecuteScalar();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch
            {
                return false;
            }

            if (SL > 0)
            {
                string thuocTinhSua = "SoLuong=SoLuong+" + soLuong + ", TongTien = TongTien+" + TongTien;
                string dieuKienSua = "TenDangNhapKhachHang = '" + tenDN + "' AND MaSP='" + maSP + "' AND KichCo = '" + kichCo + "' AND TrangThai= N'Chưa giao'";
                return sua("DONHANG", thuocTinhSua, dieuKienSua);
            }
            else
            {
                string bang = "DONHANG(TenDangNhapKhachHang,MaSP,KichCo,SoLuong,TongTien,NgayDatHang,TrangThai,GhiChu)";
                DateTime now = DateTime.Now;
                string[] ngayHienTai = now.ToString().Trim().Split(' ');
                string ngayHT = ngayHienTai[0] + " " + ngayHienTai[1];
                string cauLenh = "'" + tenDN + "','" + maSP + "','" + kichCo + "'," + soLuong + "," + TongTien + ",'" + ngayHT + "',N'Chưa giao',N'" + ghiChu + "'";
                return them(bang, cauLenh);
            }
        }

        //load dữ liệu Giỏ hàng
        public List<GioHang> loadDuLieu(string cauLenh)
        {
            List<GioHang> listGH = new List<GioHang>();
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand(cauLenh, con);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    GioHang SP = new GioHang();
                    SP.MaSP = rd["MaSP"].ToString();
                    SP.TenSP = rd["TenSP"].ToString();
                    SP.KichCo = rd["KichCo"].ToString();
                    SP.SoLuongSP = int.Parse(rd["SoLuongSP"].ToString());
                    SP.GiaBan = double.Parse(rd["GiaBan"].ToString());
                    SP.HinhAnh = rd["HinhAnh"].ToString();
                    SP.SoLuongTonKho = int.Parse(rd["SoLuongTonKho"].ToString());
                    listGH.Add(SP);
                }
                rd.Close();
                if (con.State == ConnectionState.Open)
                    con.Close();

                return listGH;
            }
            catch
            {
                return null; //Lỗi truy vấn
            }
        }
    }
}
