using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn.NET
{
    public class MySQL
    {
        public string tenDangNhap { get; set; }
        protected SqlConnection con = new SqlConnection("Data Source =DESKTOP-QAP7SKJ;Initial Catalog= QuanLy_ShopQuanAo; Persist Security Info= true;User ID=sa;Password=123");
        public void dangNhap(String txtTenDangNhap, String txtMatKhau,Form a)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "checkLogin";
            cmd.Parameters.AddWithValue("@UserName", txtTenDangNhap);
            cmd.Parameters.AddWithValue("@Password", txtMatKhau);
            cmd.Connection = con;
            tenDangNhap = txtTenDangNhap;
            object kq = cmd.ExecuteScalar();
            int code = Convert.ToInt32(kq);
            if (code == 0)
            {
                MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDangNhap = "";
                txtMatKhau = "";
                frmAdmin Ad = new frmAdmin();
                Ad.ShowDialog();
                a.Hide();
            }
            else if (code == 1)
            {
                MessageBox.Show("Mật khẩu không đúng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDangNhap = "";
                txtMatKhau = "";

            }
            else if (code == 2)
            {
                MessageBox.Show("Chào mừng khách hàng đăng nhập !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDangNhap = "";
                txtMatKhau = "";
                frmKhachHang KH = new frmKhachHang();
                KH.TenDN = tenDangNhap;
                KH.ShowDialog();
                a.Hide();
            }
            else if (code == 3)
            {
                MessageBox.Show("Mật khẩu không đúng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau = "";
                txtTenDangNhap = "";
            }
            con.Close();
        }
        public int id(String bang)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                String sql = "select count(*) from " + bang;
                SqlCommand cmd = new SqlCommand(sql, con);
                int kq = (int)cmd.ExecuteScalar();
                con.Close();
                return kq;
            }
            catch
            {
                return 0;
            }
        }
        //thêm chung
        public bool them(String bang, String thuocTinh)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                String sql = "insert into " + bang + " values(" + thuocTinh + ")";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Xóa chung
        public bool xoa(String bang, String dieuKien)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                String sql = "Delete " + bang + " where " + dieuKien;
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Sửa chung
        public bool sua(String bang, String thuocTinhCN, String dieuKien)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                String sql = "Update " + bang + " set " + thuocTinhCN + " Where " + dieuKien;
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        DataSet dts = new DataSet();
        public MySQL()
        {
            //LoadKhachHang();
        }
        public void LoadToTable(string bang)
        {
            String sql = "Select * from " + bang;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dts, bang);
            DataColumn[] key = new DataColumn[1];
            key[0] = dts.Tables[bang].Columns[0];
            dts.Tables[bang].PrimaryKey = key;
        }
        public void Load(string bang ,string dk)
        {
            String sql = "Select * from " + bang +" where TenDangNhap='"+dk+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dts, bang);
            DataColumn[] key = new DataColumn[1];
            key[0] = dts.Tables[bang].Columns[0];
            dts.Tables[bang].PrimaryKey = key;
        }
        public DataTable GetTable(string bang)
        {
            return dts.Tables[bang];
        }
        //Loading combobox
        public void LoadComboBoxTen(ComboBox A, String duLieuLoad, String duLieu, String bang)
        {
            DataTable dt = new DataTable();
            con.Open();
            try
            {
                string sql = "Select " + duLieu + " From " + bang;
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }

            try
            {
                A.DataSource = dt;
                A.DisplayMember = duLieuLoad;
                A.ValueMember = duLieu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }
        //Giao tác trên bảng Khách hàng
        public bool themKhachHang(String pTenDN, String pMatKhau, String pHoTen, String pSoDT, String pEmail, String pDiaChi, String pGioiTinh)
        {
            try
            {
                DataRow dt = dts.Tables["KHACHHANG"].NewRow();
                dt["TenDangNhap"] = pTenDN;
                dt["MatKhau"] = pMatKhau;
                dt["HoTen"] = pHoTen;
                dt["SoDT"] = pSoDT;
                dt["Email"] = pEmail;
                dt["DiaChi"] = pDiaChi;
                dt["GioiTinh"] = pGioiTinh;
                dts.Tables["KHACHHANG"].Rows.Add(dt);
                String sql = "Select * from KHACHHANG";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder build_KH = new SqlCommandBuilder(da);
                da.Update(dts, "KHACHHANG");
                return true;
            }
            catch { return false; }

        }

        public bool xoaKhachHang(String pTenDangNhap)
        {
            try
            {
                DataRow dt = dts.Tables["KHACHHANG"].Rows.Find(pTenDangNhap);
                dt.Delete();
                String sql = "Select * from KHACHHANG";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder build_KH = new SqlCommandBuilder(da);
                da.Update(dts, "KHACHHANG");
                return true;
            }
            catch
            { return false; }

        }
        public bool suaKhachHang(String pTenDN, String pMatKhau, String pHoTen, String pSoDT, String pEmail, String pDiaChi, String pGioiTinh)
        {
            try
            {
                DataRow dt = dts.Tables["KHACHHANG"].Rows.Find(pTenDN);
                dt["MatKhau"] = pMatKhau;
                dt["HoTen"] = pHoTen;
                dt["SoDT"] = pSoDT;
                dt["Email"] = pEmail;
                dt["DiaChi"] = pDiaChi;
                dt["GioiTinh"] = pGioiTinh;
                String sql = "Select * from KHACHHANG";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder build_KH = new SqlCommandBuilder(da);
                da.Update(dts, "KHACHHANG");
                return true;
            }
            catch { return false; }
        }
        //Giao tác bảng sản phẩm
        public bool themSanPham(String pMaSP, String pTenSP, int pGiaBan, int pGiaCu, String pMoTa, String pHinhAnh, String pMaLoai)
        {
            try
            {
                DataRow dt = dts.Tables["SANPHAM"].NewRow();
                dt["MaSP"] = pMaSP;
                dt["TenSP"] = pTenSP;
                dt["GiaBan"] = pGiaBan;
                dt["GiaCu"] = pGiaCu;
                dt["MoTa"] = pMoTa;
                dt["HinhAnh"] = pHinhAnh;
                dt["MaLoai"] = pMaLoai;
                dts.Tables["SANPHAM"].Rows.Add(dt);
                String sql = "Select * from SANPHAM";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder build_KH = new SqlCommandBuilder(da);
                da.Update(dts, "SANPHAM");
                return true;
            }
            catch { return false; }

        }

        public bool xoaSanPham(String pMaSP)
        {
            try
            {
                DataRow dt = dts.Tables["SANPHAM"].Rows.Find(pMaSP);
                dt.Delete();
                String sql = "Select * from SANPHAM";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder build_KH = new SqlCommandBuilder(da);
                da.Update(dts, "SANPHAM");
                return true;
            }
            catch
            { return false; }

        }
        public bool suaSanPham(String pMaSP, String pTenSP, int pGiaBan, int pGiaCu, String pMoTa, String pHinhAnh, String pMaLoai)
        {
            try
            {
                DataRow dt = dts.Tables["SANPHAM"].Rows.Find(pMaSP);
                dt["TenSP"] = pTenSP;
                dt["GiaBan"] = pGiaBan;
                dt["GiaCu"] = pGiaCu;
                dt["MoTa"] = pMoTa;
                dt["HinhAnh"] = pHinhAnh;
                dt["MaLoai"] = pMaLoai;
                String sql = "Select * from SANPHAM";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder build_KH = new SqlCommandBuilder(da);
                da.Update(dts, "SANPHAM");
                return true;
            }
            catch { return false; }
        }
        //Giao tác bảng KHO
        public void LoadToKHO()
        {
            String sql = "Select * from KHO";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dts, "KHO");
            DataColumn[] key = new DataColumn[2];
            key[0] = dts.Tables["KHO"].Columns[0];
            key[1] = dts.Tables["KHO"].Columns[2];
            dts.Tables["KHO"].PrimaryKey = key;
        }
        public bool themKho(String pMaSP, int pSoLuongTonKho, String pKichCo)
        {
            try
            {
                DataRow dt = dts.Tables["KHO"].NewRow();
                dt["MaSP"] = pMaSP;
                dt["KichCo"] = pKichCo;
                dt["SoLuongTonKho"] = pSoLuongTonKho;
                dts.Tables["KHO"].Rows.Add(dt);
                String sql = "Select * from KHO";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder build_KH = new SqlCommandBuilder(da);
                da.Update(dts, "KHO");
                return true;
            }
            catch { return false; }

        }

        public bool xoaKho(String pMaSP, String pKichCo)
        {
            try
            {
                string[] khoachinh = { pMaSP, pKichCo };
                DataRow dt = dts.Tables["KHO"].Rows.Find(khoachinh);
                dt.Delete();
                String sql = "Select * from KHO";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder build_KH = new SqlCommandBuilder(da);
                da.Update(dts, "KHO");
                return true;
            }
            catch
            { return false; }

        }
        public bool suaKho(String pMaSP, String pKichCo, int pSoLuongTonKho)
        {
            try
            {
                string[] khoachinh = { pMaSP, pKichCo };
                DataRow dt = dts.Tables["KHO"].Rows.Find(khoachinh);
                dt["SoLuongTonKho"] = pSoLuongTonKho;
                String sql = "Select * from KHO";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder build_KH = new SqlCommandBuilder(da);
                da.Update(dts, "KHO");
                return true;
            }
            catch { return false; }
        }
        //Giao tác bảng đơn hàng
        public bool xoaDonHang(String pMaDH)
        {
            try
            {
                DataRow dt = dts.Tables["DONHANG"].Rows.Find(pMaDH);
                dt.Delete();
                String sql = "Select * from DONHANG";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder build_KH = new SqlCommandBuilder(da);
                da.Update(dts, "DONHANG");
                return true;
            }
            catch
            { return false; }

        }
        public bool suaDonHang(String pMaDH, String pTenKH, String pMaSP, int pSoLuong, double pTongTien, String pKichCo, String pNgayDatHang, String pNgayGiaoHang, String pTrangThai, String pGhiChu)
        {
            try
            {
                DataRow dt = dts.Tables["DONHANG"].Rows.Find(pMaDH);
                dt["TenDangNhapKhachHang"] = pTenKH;
                dt["MaSP"] = pMaSP;
                dt["SoLuong"] = pSoLuong;
                dt["TongTien"] = pTongTien;
                dt["KichCo"] = pKichCo;
                dt["NgayDatHang"] = pNgayDatHang;
                dt["NgayGiaoHang"] = pNgayGiaoHang;
                dt["TrangThai"] = pTrangThai;
                dt["GhiChu"] = pGhiChu;
                String sql = "Select * from DONHANG";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder build_KH = new SqlCommandBuilder(da);
                da.Update(dts, "DONHANG");
                return true;
            }
            catch { return false; }
        }
        //Giao tác thống kê
        public void LoadThongKe()
        {
            String sql = "Select Hoten,SoDT,Email,DiaChi,GioiTinh,TenSP,SoLuong,TongTien,NgayGiaoHang from KHACHHANG kh,DONHANG dh,SANPHAM sp where kh.TenDangNhap=dh.TenDangNhapKhachHang and dh.MaSP=sp.MaSP and TrangThai=N'Đã giao'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dts, "THONGKE");
            //DataColumn[] key = new DataColumn[1];
            //key[0] = dts.Tables["KHO"].Columns[0];
            //dts.Tables["KHO"].PrimaryKey = key;
        }
        public DataTable GetThongKe()
        {
            return dts.Tables["THONGKE"];
        }
        public int soLuongBan(string sql)
        {
            int tong = 0;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                string sl = dr["SoLuong"].ToString();
                tong = tong + Convert.ToInt32(sl);

            }
            return tong;
        }
        public int tongTien(string sql)
        {
            int tong = 0;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                string tt = dr["TongTien"].ToString();
                if (tt == "")
                { tong = 0; return tong; }

                tong = tong + Convert.ToInt32(tt);

            }
            return tong;
        }
        //giao tác cài đặt
        public bool doiMatKhau(String pTenAdmin, String pMK, int pQuyen)
        {
            try
            {
                DataRow dt = dts.Tables["QUANTRIVIEN"].Rows.Find(pTenAdmin);
                dt["MatKhau"] = pMK;
                dt["Quyen"] = pQuyen;
                String sql = "Select * from QUANTRIVIEN";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder build_KH = new SqlCommandBuilder(da);
                da.Update(dts, "QUANTRIVIEN");
                return true;
            }
            catch { return false; }
        }

        public bool doiMKKhachHang(String pTenTK, String pMK)
        {
            return sua("KhachHang", "MatKhau = '" + pMK + "'", "TenDangNhap = '" + pTenTK + "'");
        }
        public bool datHang(String pMaDH, String pTrangThai, String pNgayGiao)
        {
            try
            {
                DataRow dt = dts.Tables["DONHANG"].Rows.Find(pMaDH);
                dt["TrangThai"] = pTrangThai;
                dt["NgayGiaoHang"] = pNgayGiao;
                String sql = "Select * from DONHANG";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder build_KH = new SqlCommandBuilder(da);
                da.Update(dts, "DONHANG");
                return true;
            }
            catch { return false; }
        }
        public bool capNhatTT(String pMaDH,String pTrangThai,String pNgayGiao)
        {
            try
            {
                DataRow dt = dts.Tables["DONHANG"].Rows.Find(pMaDH);
                dt["TrangThai"] = pTrangThai;
                dt["NgayGiaoHang"] = pNgayGiao;
                String sql = "Select * from DONHANG";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder build_KH = new SqlCommandBuilder(da);
                da.Update(dts, "DONHANG");
                return true;
            }
            catch { return false; }
        }
        public bool suaThongTinKH(String pTenDN, String pHoTen, String pSoDT, String pEmail, String pDiaChi, String pGioiTinh)
        {
            try
            {
                DataRow dt = dts.Tables["KHACHHANG"].Rows.Find(pTenDN);
                dt["HoTen"] = pHoTen;
                dt["SoDT"] = pSoDT;
                dt["Email"] = pEmail;
                dt["DiaChi"] = pDiaChi;
                dt["GioiTinh"] = pGioiTinh;
                String sql = "Select * from KHACHHANG";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder build_KH = new SqlCommandBuilder(da);
                da.Update(dts, "KHACHHANG");
                return true;
            }
            catch { return false; }
        }
    }
}
