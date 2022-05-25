using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.NET
{
    public class SanPham:MySQL
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public double GiaBan { get; set; }
        public double GiaCu { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }
        public string MaLoai { get; set; }

        public List<SanPham> loadTatCaDuLieu()
        {
            //lấy sản phẩm có lượng tồn kho lớn hơn 0
            string cauLenh = "SELECT MaSP,TenSP,GiaBan,GiaCu,MoTa,HinhAnh,MaLoai FROM SANPHAM "
                +"WHERE MaSP IN (SELECT MaSP FROM KHO GROUP BY MaSP HAVING SUM(SoLuongTonKho)>0)";
            return loadDuLieu(cauLenh);
        }

        public List<SanPham> timSanPhamTheoTen(string tenSP)
        {
            string cauLenh = "SELECT MaSP,TenSP,GiaBan,GiaCu,MoTa,HinhAnh,MaLoai FROM SANPHAM "
                + "WHERE TenSP LIKE '%' + N'" + tenSP + "' + '%' AND MaSP IN (SELECT MaSP FROM KHO GROUP BY MaSP HAVING SUM(SoLuongTonKho)>0)";
            return loadDuLieu(cauLenh);
        }

        //load dữ liệu sản phẩm
        public List<SanPham> loadDuLieu(string cauLenh)
        {
            List<SanPham> listSP = new List<SanPham>();
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand(cauLenh, con);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    SanPham SP = new SanPham();
                    SP.MaSP = rd["MaSP"].ToString();
                    SP.TenSP = rd["TenSP"].ToString();
                    SP.GiaBan = double.Parse(rd["GiaBan"].ToString());
                    SP.GiaCu = double.Parse(rd["GiaCu"].ToString());
                    SP.MoTa = rd["MoTa"].ToString();
                    SP.HinhAnh = rd["HinhAnh"].ToString();
                    SP.MaLoai = rd["MaLoai"].ToString();
                    listSP.Add(SP);
                }
                rd.Close();
                if (con.State == ConnectionState.Open)
                    con.Close();

                return listSP;
            }
            catch
            {
                return null; //Lỗi truy vấn
            }
        }
    }
}
