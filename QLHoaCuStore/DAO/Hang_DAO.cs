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
    public class Hang_DAO
    {
        static SqlConnection con;
        public static List<Hang_DTO> LayHang()
        {
            string sTruyVan = "select hc.mahc, hc.tenhc, hc.soluong, hc.dongia ,hc.ghichu,  l.tenloai,n.tenncc ,hc.an from  hoacu hc,loaisp l, nhacungcap n where l.maloai=hc.maloai and n.mancc = hc.mancc and hc.an=0 ";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Hang_DTO> lstHang = new List<Hang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //sMahc, sTenhc, sSoLuong, sDonGia, sMaLoai, sMaNcc, sGhiChu, sAnh
                Hang_DTO ha = new Hang_DTO();
                ha.SMahc = dt.Rows[i]["mahc"].ToString();
                ha.STenhc = dt.Rows[i]["tenhc"].ToString();
                ha.SSoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                ha.SDonGia = int.Parse(dt.Rows[i]["dongia"].ToString());
                ha.SGhiChu = dt.Rows[i]["ghichu"].ToString();
                ha.SMaLoai = dt.Rows[i]["tenloai"].ToString();
                ha.SMaNcc = dt.Rows[i]["tenncc"].ToString();
                ha.SFileAnh = LayTenAnh(dt.Rows[i]["mahc"].ToString());
               
               // ha.SAnh = byte[].Rows[i]["anh"].ToString();
                lstHang.Add(ha);
            }
            DataProvider.DongKetNoi(con);
            return lstHang;
        }

        public static void TaoAnh(string sMahc)
        {
            string sTruyVan = string.Format(@"insert into anhHoaCu values('{0}', '{1}')",sMahc, "");
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
        }

        public static bool ThemAnh(string fileName, string mahc)
        {
            //sMahc, sTenhc, sSoLuong, sDonGia, sGhiChu, sMaLoai, sMaNcc
            string sTruyVan = string.Format(@"update AnhHoaCu set fileAnh = '{0}' where mahc = '{1}'", fileName, mahc);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static string LayTenAnh(string mahc)
        {
            string sTruyVan = string.Format(@"select fileAnh from AnhHoaCu where mahc=N'{0}'", mahc);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO

            return dt.Rows[0]["fileAnh"].ToString();
        }

        public static void CapNhatSLHC(string sMahc, decimal value)
        {
            //sMahc, sTenhc, sSoLuong, sDonGia, sGhiChu, sMaLoai, sMaNcc
            string sTruyVan = string.Format(@"update hoacu set soluong = '{0}' where mahc = '{1}'", value, sMahc);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
        }


        // Thêm NV
        public static bool ThemHang(Hang_DTO ha)
        {
            //sMahc, sTenhc, sSoLuong, sDonGia, sGhiChu, sMaLoai, sMaNcc
            string sTruyVan = string.Format(@"exec InsertHC N'{0}', N'{1}',N'{2}',N'{3}','{4}',N'{5}',N'{6}',N'{7}'", ha.SMahc, ha.STenhc, ha.SSoLuong, ha.SDonGia, ha.SGhiChu, ha.SMaLoai, ha.SMaNcc,ha.SAn);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin nhân viên có mã ma, trả về null nếu không thấy
        public static Hang_DTO TimHangTheoMa(string mah)
        {
            string sTruyVan = string.Format(@"select * from hoacu where mahc=N'{0}'", mah);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO
         
            //sManv sHoTen dtNgaySinh sGioiTinh sDiaChi sDienThoai
            Hang_DTO ha = new Hang_DTO();
            ha.SMahc = dt.Rows[0]["mahc"].ToString();
            ha.STenhc = dt.Rows[0]["tenhc"].ToString();
           
            ha.SSoLuong = int.Parse(dt.Rows[0]["soluong"].ToString());
            ha.SDonGia = int.Parse(dt.Rows[0]["dongia"].ToString());
           
            ha.SGhiChu = dt.Rows[0]["ghichu"].ToString();
            ha.SMaLoai = dt.Rows[0]["ghichu"].ToString();
            ha.SMaNcc = dt.Rows[0]["ghichu"].ToString();
            DataProvider.DongKetNoi(con);
            return ha;
        }
     
        // Cập nhật thông tin NV
        public static bool CapNhatHang(Hang_DTO ha)
        {
           
            string sTruyVan = string.Format(@"exec updateHC N'{0}',N'{1}',N'{2}',N'{3}',N'{4}' ,N'{5}',N'{6}',N'{7}'", ha.STenhc, ha.SSoLuong,ha.SDonGia, ha.SGhiChu, ha.SMaLoai, ha.SMaNcc,ha.SAn, ha.SMahc);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Xóa thông tin 1 nhân viên
        public static bool XoaHang(string mah)
        {
            string sTruyVan = string.Format(@"update hoacu set an = 1 where mahc = '{0}'", mah);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
          
        }

        //còn 2 hàm macv với manccCu tạm thời chưa xài
          public static List<Hang_DTO> GetID_Hang(string manccCu)
           {
               string sTruyVan = string.Format("select mahc from hoacu where mancc = '{0}'", manccCu);
               con = DataProvider.MoKetNoi();
               DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
               if (dt.Rows.Count == 0)
               {
                   return null;
               }
               List<Hang_DTO> lstHang = new List<DTO.Hang_DTO>();
               for (int i = 0; i < dt.Rows.Count; i++)
               {
                Hang_DTO ha = new Hang_DTO();
                   ha.SMahc = dt.Rows[i]["mahc"].ToString();
                lstHang.Add(ha);
                
               }
               DataProvider.DongKetNoi(con);
               return lstHang;
           }

           public static bool CapNhatHang_MANCC_MoiDAO(string mancc, string manccCu)
           {
               string sTruyVan = string.Format(@"update hoacu set mannc = '{0}' where mancc = '{1}'", mancc, manccCu);
               con = DataProvider.MoKetNoi();
               bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
               DataProvider.DongKetNoi(con);
               return kq;
           }

        public static List<Hang_DTO> GetID2_Hang(string maloaiCu)
        {
            string sTruyVan = string.Format("select maloai from loaisp where maloai = '{0}'", maloaiCu);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Hang_DTO> lstHang = new List<DTO.Hang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Hang_DTO ha = new Hang_DTO();
                ha.SMaLoai = dt.Rows[i]["maloai"].ToString();
                lstHang.Add(ha);

            }
            DataProvider.DongKetNoi(con);
            return lstHang;
        }

        public static bool CapNhatHang_MALOAI_MoiDAO(string maloai, string maloaiCu)
        {
            string sTruyVan = string.Format(@"update loaisp set maloai = '{0}' where maloai = '{1}'", maloai, maloaiCu);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }


    }
}

