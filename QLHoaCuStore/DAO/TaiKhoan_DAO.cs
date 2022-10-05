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
    public class TaiKhoan_DAO
    {
        static SqlConnection con;
        public static TaiKhoan_DTO LayNguoiDung(string ten, string matkhau)
        {
            string sTruyVan = string.Format("select * from taikhoan1 where ten='{0}' and matkhau='{1}'", ten, matkhau);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu NguoiDungDTO
            TaiKhoan_DTO nd = new TaiKhoan_DTO();
            nd.STen = dt.Rows[0]["ten"].ToString();
            nd.SMatKhau = dt.Rows[0]["matkhau"].ToString();           
            nd.IQuyen = int.Parse(dt.Rows[0]["quyen"].ToString());
            nd.NhanVien = NhanVien_DAO.TimNhanVienTheoMa(dt.Rows[0]["manv"].ToString());
            DataProvider.DongKetNoi(con);
            return nd;
        }

        //chua sua loi
        public static List<TaiKhoan_DTO> DanhSachNguoiDungDAO()
        {
            string sTruyVan = "select *from taikhoan1";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu NguoiDungDTO
            List<TaiKhoan_DTO> lstNguoiDung = new List<DTO.TaiKhoan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoan_DTO nd = new TaiKhoan_DTO();
                nd.STen = dt.Rows[i]["ten"].ToString();
                nd.SMatKhau = dt.Rows[i]["matkhau"].ToString();
                nd.IQuyen = int.Parse(dt.Rows[i]["quyen"].ToString());
                nd.NhanVien = NhanVien_DAO.TimNhanVienTheoMa(dt.Rows[0]["manv"].ToString());
                lstNguoiDung.Add(nd);
            }
            DataProvider.DongKetNoi(con);
            return lstNguoiDung;
        }

        public static bool ThemNguoiDungDAO(string ten, string matkhau, int quyen, string manv)
        {
            string sTruyVan = string.Format(@"insert into taikhoan1 values ('{0}', '{1}','{2}','{3}')", ten, matkhau, quyen, manv);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        //đang thí nghiệm
        public static bool XoaNguoiDungDAO(string ten)
        {
            string sTruyVan = string.Format(@"delete taikhoan1 where ten = '{0}'", ten);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool CapLaiMatKhauDAO(string id, string matkhauMH, string manv)
        {
            string sTruyVan = string.Format(@"update taikhoan1 set matkhau = '{0}' where ten = '{1}' and manv='{2}'", matkhauMH, id,manv);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        //đang thí nghiệm
        public static bool ThayDoiQuyenND_BUS(string id, int thaydoi)
        {
            string sTruyVan = string.Format(@"update taikhoan1 set quyen = {0} where ten = '{1}'", thaydoi, id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<TaiKhoan_DTO> KiemTraID(string sTen)
        {
            string sTruyVan = string.Format(@"select *from taikhoan1 where ten='{0}'", sTen);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu NguoiDungDTO
            List<TaiKhoan_DTO> lstNguoiDung = new List<TaiKhoan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoan_DTO nd = new TaiKhoan_DTO();
                nd.STen = dt.Rows[0]["ten"].ToString();
                nd.SMatKhau = dt.Rows[0]["matkhau"].ToString();
                nd.IQuyen = int.Parse(dt.Rows[0]["quyen"].ToString());
                nd.NhanVien = NhanVien_DAO.TimNhanVienTheoMa(dt.Rows[0]["manv"].ToString());
                lstNguoiDung.Add(nd);
            }

            DataProvider.DongKetNoi(con);
            return lstNguoiDung;
        }

        public static bool CapNhatNguoiDungDAO(string ten, string matkhauMH)
        {
            string sTruyVan = string.Format(@"update taikhoan1 set matkhau='{0}' where ten='{1}'", matkhauMH, ten);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}

