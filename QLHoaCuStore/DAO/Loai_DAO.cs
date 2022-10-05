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
    public class Loai_DAO
    {
        static SqlConnection con;
        public static List<Loai_DTO> LayLoai()
        {
            string sTruyVan = "select  * from loaisp where an=0";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Loai_DTO> lstLoai = new List<Loai_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //sMaKhach sTenKhach sDiaChi sDienThoai
                Loai_DTO lo = new Loai_DTO();
                lo.SMaLoai = dt.Rows[i]["maloai"].ToString();
                lo.STenLoai = dt.Rows[i]["tenloai"].ToString();               
            
                lstLoai.Add(lo);
            }
            DataProvider.DongKetNoi(con);
            return lstLoai;
        }

       
        // Thêm NV
        public static bool ThemLoai(Loai_DTO lo)
        {
            string sTruyVan = string.Format(@"exec InsertLoai N'{0}', N'{1}', N'{2}'", lo.SMaLoai, lo.STenLoai, lo.SAn);
           
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin nhân viên có mã ma, trả về null nếu không thấy
        public static Loai_DTO TimLoaiTheoMa(string mal)
        {
            string sTruyVan = string.Format(@"select * from loaisp where maloai=N'{0}'", mal);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu Loai_DTO
           
            Loai_DTO lo = new Loai_DTO();
            lo.SMaLoai = dt.Rows[0]["maloai"].ToString();
            lo.STenLoai = dt.Rows[0]["tenloai"].ToString();         
          
            DataProvider.DongKetNoi(con);
            return lo;
        }

        // Cập nhật thông tin NV
        public static bool CapNhatLoai(Loai_DTO lo)
        {
            string sTruyVan = string.Format(@"exec UpdateLoai N'{0}',N'{1}', N'{2}'", lo.STenLoai,lo.SAn,  lo.SMaLoai);
            
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Xóa thông tin 1 loại
        public static bool XoaLoai(string malo)
        {
            string sTruyVan = string.Format(@"update loaisp set an=1 where maloai = '{0}'", malo);           
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}

