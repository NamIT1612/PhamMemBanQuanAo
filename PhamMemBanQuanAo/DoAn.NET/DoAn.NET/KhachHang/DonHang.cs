using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.NET
{
    public class DonHang:MySQL
    {
        public string MaDonHang { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public double TongTien { get; set; }
        public string KichCo { get; set; }
        public string HinhAnh { get; set; }

        public List<DonHang> loadDonHangChuaGiao(string tenDN)
        {
            try
            {
                List<DonHang> lstDonHang = new List<DonHang>();
                string cauLenh = "SELECT MaDonHang,dbo.DONHANG.MaSP,TenSP,SoLuong,TongTien,KichCo,HinhAnh FROM dbo.DONHANG,dbo.SANPHAM " +
                    "WHERE TenDangNhapKhachHang='" + tenDN + "' AND TrangThai=N'Chưa giao' AND DONHANG.MaSP=SANPHAM.MaSP";

                return loadDonHang(cauLenh);
            }
            catch
            {
                return null; //Lỗi truy vấn
            }
        }

        public List<DonHang> loadDonHangDaGiao(string tenDN)
        {
            try
            {
                List<DonHang> lstDonHang = new List<DonHang>();
                string cauLenh = "SELECT MaDonHang,dbo.DONHANG.MaSP,TenSP,SoLuong,TongTien,KichCo,HinhAnh FROM dbo.DONHANG,dbo.SANPHAM " +
                    "WHERE TenDangNhapKhachHang='" + tenDN + "' AND TrangThai=N'Đã giao' AND DONHANG.MaSP=SANPHAM.MaSP";
                
                return loadDonHang(cauLenh);
            }
            catch
            {
                return null; //Lỗi truy vấn
            }
        }

        private List<DonHang> loadDonHang(string cauLenh)
        {
            try
            {
                List<DonHang> lstDonHang = new List<DonHang>();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand(cauLenh, con);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    DonHang DH = new DonHang();
                    DH.MaDonHang = rd["MaDonHang"].ToString();
                    DH.MaSP = rd["MaSP"].ToString();
                    DH.TenSP = rd["TenSP"].ToString();
                    DH.SoLuong = int.Parse(rd["SoLuong"].ToString());
                    DH.TongTien = double.Parse(rd["TongTien"].ToString());
                    DH.KichCo = rd["KichCo"].ToString();
                    DH.HinhAnh = rd["HinhAnh"].ToString();
                    lstDonHang.Add(DH);
                }
                rd.Close();
                if (con.State == ConnectionState.Open)
                    con.Close();

                return lstDonHang;
            }
            catch
            {
                return null; //Lỗi truy vấn
            }
        }
        
        public bool xoaSPKhoiDonHang(string maDH, string tenDN, string maSP, string kichCo, int soLuong)
        {
            //cập nhật lại số lượng trong kho
            string thuocTinh = "SoLuongTonKho=SoLuongTonKho+" + soLuong;
            updateSLKho(maSP, kichCo, thuocTinh);
            //xóa khỏi giỏ hàng
            string dieuKien = "MaDonHang = '"+maDH+"'";
            return xoa("DonHang", dieuKien);
        }

        public bool updateSLKho(string maSP, string kichCo, string thuocTinh)
        {
            string dieuKien = "MaSP='" + maSP + "' AND KichCo ='" + kichCo + "'";
            return sua("Kho", thuocTinh, dieuKien);
        }
    }
}
