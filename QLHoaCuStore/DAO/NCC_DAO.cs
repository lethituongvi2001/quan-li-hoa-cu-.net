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
    public class NCC_DAO
    {
        static SqlConnection con;
        public static List<NCC_DTO> LayNCC()
        {
            string sTruyVan = "select  * from nhacungcap where an=0 ";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NCC_DTO> lstNCC = new List<NCC_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //SMaNCC STenNCC SDiaChi SDienThoai SEmail SWebsite  
                NCC_DTO nc = new NCC_DTO();
                nc.SMaNCC = dt.Rows[i]["mancc"].ToString();
                nc.STenNCC = dt.Rows[i]["tenncc"].ToString();               
                nc.SDiaChi = dt.Rows[i]["diachi"].ToString();             
                nc.SDienThoai = dt.Rows[i]["dienthoai"].ToString();               
                nc.SWebsite = dt.Rows[i]["website"].ToString();
                lstNCC.Add(nc);
            }
            DataProvider.DongKetNoi(con);
            return lstNCC;
        }

       
        // Thêm NV
        public static bool ThemNCC(NCC_DTO nc)
        {
            
            string sTruyVan = string.Format(@"exec InsertNCC N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}'", nc.SMaNCC, nc.STenNCC, nc.SDiaChi, nc.SDienThoai,  nc.SWebsite, nc.SAn);
           
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin nhân viên có mã ma, trả về null nếu không thấy
        public static NCC_DTO TimNCCTheoMa(string man)
        {
            string sTruyVan = string.Format(@"select * from nhacungcap where mancc=N'{0}'", man);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu NCC_DTO
           
            NCC_DTO nc = new NCC_DTO();
            nc.SMaNCC = dt.Rows[0]["mancc"].ToString();
            nc.STenNCC = dt.Rows[0]["tenncc"].ToString();         
            nc.SDiaChi = dt.Rows[0]["diachi"].ToString();
            nc.SDienThoai = dt.Rows[0]["dienthoai"].ToString();            
            nc.SWebsite = dt.Rows[0]["website"].ToString();
            DataProvider.DongKetNoi(con);
            return nc;
        }

        // Cập nhật thông tin NCC
        public static bool CapNhatNCC(NCC_DTO nc)
        {
             string sTruyVan = string.Format(@"exec UpdateNCC N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}'",  nc.STenNCC, nc.SDiaChi, nc.SDienThoai, nc.SWebsite,nc.SAn, nc.SMaNCC);
                     
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Xóa thông tin 1 nhân viên
        public static bool XoaNCC(string manc)
        {
            string sTruyVan = string.Format(@"update nhacungcap set an = 1 where mancc = '{0}'", manc);

            
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}

