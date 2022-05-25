using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.NET
{
    class Kho:MySQL
    {
        public int SoLuongTonKho { get; set; }
        public string KichCo { get; set; }

        public List<Kho> loadKho(string maSP)
        {
            List<Kho> listKho = new List<Kho>();
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string cauLenh = "SELECT SoLuongTonKho, KichCo FROM KHO WHERE SoLuongTonKho>0 AND MaSP = '"+maSP+"'";
                SqlCommand cmd = new SqlCommand(cauLenh, con);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Kho kho = new Kho();
                    kho.SoLuongTonKho = int.Parse(rd["SoLuongTonKho"].ToString());
                    kho.KichCo = rd["KichCo"].ToString();
                    listKho.Add(kho);
                }
                rd.Close();
                if (con.State == ConnectionState.Open)
                    con.Close();

                return listKho;
            }
            catch
            {
                return null; //Lỗi truy vấn
            }
        }

    }
}
