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
    public class HoaDon_DAO
    {
        static SqlConnection con;
        public static List<HoaDon_DTO> LayHoaDon(string mahd)
        {
             string sTruyVan = "select  * from hdban where mahd = '" + mahd + "' oder by mahd desc";
           // string sTruyVan = "select  * from hdban";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lstHoaDon = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO nv = new HoaDon_DTO();
                //SMahd DtNgayBan STongTien SManv SMaKhach    
                nv.SMahd = dt.Rows[i]["mahd"].ToString();
                nv.DtNgayBan = DateTime.Parse(dt.Rows[i]["ngayban"].ToString());
                nv.STongTien = Convert.ToInt32(dt.Rows[i]["tongtien"]);
                nv.SManv = dt.Rows[i]["manv"].ToString();
                nv.SMaKhach = dt.Rows[i]["makhach"].ToString();

                lstHoaDon.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstHoaDon;
        }
        public static List<HoaDon_DTO> LayHoaDon1()
        {
            
             string sTruyVan = "select  * from hdban";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lstHoaDon = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO nv = new HoaDon_DTO();
                //SMahd DtNgayBan STongTien SManv SMaKhach    
                nv.SMahd = dt.Rows[i]["mahd"].ToString();
                nv.DtNgayBan = DateTime.Parse(dt.Rows[i]["ngayban"].ToString());
                nv.STongTien = Convert.ToInt32(dt.Rows[i]["tongtien"]);
                nv.SManv = dt.Rows[i]["manv"].ToString();
                nv.SMaKhach = dt.Rows[i]["makhach"].ToString();

                lstHoaDon.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstHoaDon;
        }
        public static List<NhanVien_DTO> LayNhanVien()
        {
            string sTruyVan = "select  * from nhanvien ";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SManv = dt.Rows[i]["manv"].ToString();
                nv.SHoTen = dt.Rows[i]["hoten"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.SGioiTinh = dt.Rows[i]["gioitinh"].ToString();
                nv.SDiaChi = dt.Rows[i]["diachi"].ToString();
                nv.SDienThoai = dt.Rows[i]["dienthoai"].ToString();
                lstNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }

        public static void CapNhatTongTien(long v, string mahd )
        {
            string sTruyVan = string.Format(@"update hdban set tongtien = tongtien + {0} where mahd =  '{1}'", v, mahd);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
        }

        public static bool ThemHoaDon(HoaDon_DTO hd)
        {
            string sTruyVan = string.Format(@"insert into hdban values('{0}','{1}','{2}','{3}','{4}')", hd.SMahd, hd.DtNgayBan.ToString("MM/dd/yyyy"), hd.STongTien, hd.SManv, hd.SMaKhach);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin nhân viên có mã ma, trả về null nếu không thấy
        public static HoaDon_DTO TimHoaDonTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from hdban where mahd=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
          
            HoaDon_DTO nv = new HoaDon_DTO();
            nv.SMahd = dt.Rows[0]["mahd"].ToString();
            nv.DtNgayBan = DateTime.Parse(dt.Rows[0]["ngayban"].ToString());//lỗi vì sao?
            nv.STongTien = Convert.ToInt32(dt.Rows[0]["tongtien"]);
            nv.SManv = dt.Rows[0]["manv"].ToString();
            nv.SMaKhach = dt.Rows[0]["makhach"].ToString();
            
            DataProvider.DongKetNoi(con);
            return nv;
        }

        // Cập nhật thông tin NV
        public static bool CapNhatNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"exec updateNV N'{0}',N'{1}',N'{2}',N'{3}',N'{4}' ,N'{5}'", nv.SHoTen, nv.DtNgaySinh.ToString("MM/dd/yyyy"), nv.SGioiTinh, nv.SDiaChi, nv.SDienThoai, nv.SManv);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Xóa thông tin 1 nhân viên
        public static bool XoaNhanVien(string manv)
        {
            string sTruyVan = string.Format(@"delete nhanvien where manv = '{0}'", manv);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static List<HoaDon_DTO> LayHoaDonTheoNgay(DateTime ngbd, DateTime ngkt)
        {
            string sTruyVan = string.Format(@"select * from hdban where ngayban between '{0}' and '{1}'", ngbd.ToString("MM/dd/yyyy"), ngkt.ToString("MM/dd/yyyy"));
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lstQTLuong = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO qtl = new HoaDon_DTO();
                qtl.SMahd = dt.Rows[i]["mahd"].ToString();
                qtl.DtNgayBan = DateTime.Parse(dt.Rows[i]["ngayban"].ToString());//lỗi vì sao?
                qtl.STongTien = Convert.ToInt32(dt.Rows[i]["tongtien"]);
                qtl.SManv = dt.Rows[i]["manv"].ToString();
                qtl.SMaKhach = dt.Rows[i]["makhach"].ToString();
                lstQTLuong.Add(qtl);
                
               
            }
            DataProvider.DongKetNoi(con);
            return lstQTLuong;
        }
    }
}

