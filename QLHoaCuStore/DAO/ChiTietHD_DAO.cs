using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietHD_DAO
    {
        static SqlConnection con;
        public static List<ChiTietDH_DTO> LayChiTiet(string mahd)
        {
            string sTruyVan = "select  * from cthdban where mahd = '"+mahd+"' ";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTietDH_DTO> lstChiTiet= new List<ChiTietDH_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietDH_DTO nv = new ChiTietDH_DTO();
                nv.Id = Convert.ToInt32(dt.Rows[i]["id"]);
                nv.Mahd = dt.Rows[i]["mahd"].ToString();
                nv.Mahc= dt.Rows[i]["mahc"].ToString();
                nv.Soluong = Convert.ToInt32(dt.Rows[i]["soluong"]);
                nv.Dongia = Convert.ToInt32(dt.Rows[i]["dongia"].ToString());
                nv.Khuyenmai= Convert.ToDouble(dt.Rows[i]["khuyenmai"].ToString());
                nv.Thanhtien= Convert.ToInt64(dt.Rows[i]["thanhtien"].ToString());
                lstChiTiet.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstChiTiet;
        }

        public static bool CapNhatSP(string sMahc, string sMahd, int conlai, int thanhtien)
        {
            string sTruyVan = string.Format(@"update cthdban set soluong = '{0}', thanhtien = '{1}' where mahc = '{2}' and mahd = '{3}' ", conlai, thanhtien, sMahc, sMahd);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaSP(string sMahc, string mahd)
        {
            string sTruyVan = string.Format(@"delete cthdban where mahd = '{0}' and mahc = '{1}'", mahd, sMahc);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool ThemCTHD(ChiTietDH_DTO cthd)
        {
            string sTruyVan = string.Format(@"insert into cthdban values('{0}','{1}','{2}','{3}','{4}', '{5}')", cthd.Mahd, cthd.Mahc, cthd.Soluong, cthd.Dongia, cthd.Khuyenmai, cthd.Thanhtien);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static ChiTietDH_DTO KiemTraSanPham(string sMahc, string mahd)
        {
            string sTruyVan = string.Format(@"select * from cthdban where mahd = '{0}' and mahc=N'{1}'", mahd, sMahc);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            ChiTietDH_DTO nv = new ChiTietDH_DTO();
            nv.Id = Convert.ToInt32(dt.Rows[0]["id"]);
            nv.Mahd = dt.Rows[0]["mahd"].ToString();
            nv.Mahc = dt.Rows[0]["mahc"].ToString();
            nv.Soluong = Convert.ToInt32(dt.Rows[0]["soluong"]);
            nv.Dongia = Convert.ToInt32(dt.Rows[0]["dongia"].ToString());
            nv.Khuyenmai = Convert.ToDouble(dt.Rows[0]["khuyenmai"].ToString());
            nv.Thanhtien = Convert.ToInt64(dt.Rows[0]["thanhtien"].ToString());

            return nv;
        }
    }
}
