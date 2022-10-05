using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;



namespace DAO
{
    public class KhachHang_DAO
    {
        static SqlConnection con;
        public static List<KhachHang_DTO> LayKhachHang()
        {
            string sTruyVan = "select  * from khachhang where an=0";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> lstKhachHang = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //sMaKhach sTenKhach sDiaChi sDienThoai
                KhachHang_DTO nv = new KhachHang_DTO();
                nv.SMaKhach = dt.Rows[i]["makhach"].ToString();
                nv.STenKhach = dt.Rows[i]["tenkhach"].ToString();               
                nv.SDiaChi = dt.Rows[i]["diachi"].ToString();             
                nv.SDienThoai = dt.Rows[i]["dienthoai"].ToString();
                lstKhachHang.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstKhachHang;
        }

       
        // Thêm NV
        public static bool ThemKhachHang(KhachHang_DTO kh)
        {
            string sTruyVan = string.Format(@"exec InsertKH N'{0}', N'{1}',N'{2}',N'{3}',N'{4}'", kh.SMaKhach, kh.STenKhach, kh.SDiaChi, kh.SDienThoai,kh.SAn);
           
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin nhân viên có mã ma, trả về null nếu không thấy
        public static KhachHang_DTO TimKhachHangTheoMa(string mak)
        {
            string sTruyVan = string.Format(@"select * from khachhang where makhach=N'{0}'", mak);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO
           
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.SMaKhach = dt.Rows[0]["makhach"].ToString();
            kh.STenKhach = dt.Rows[0]["tenkhach"].ToString();         
            kh.SDiaChi = dt.Rows[0]["diachi"].ToString();
            kh.SDienThoai = dt.Rows[0]["dienthoai"].ToString();
            DataProvider.DongKetNoi(con);
            return kh;
        }

        // Cập nhật thông tin NV
        public static bool CapNhatKhachHang(KhachHang_DTO kh)
        {
            string sTruyVan = string.Format(@"exec updateKH N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", kh.STenKhach, kh.SDiaChi, kh.SDienThoai,kh.SAn, kh.SMaKhach);
            
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Xóa thông tin 1 nhân viên
        public static bool XoaKhachHang(string makh)
        {
            string sTruyVan = string.Format(@"update khachhang set an = 1 where makhach = '{0}'", makh);
           
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}

