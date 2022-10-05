using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class HoaDon_BUS
    {
        public static List<HoaDon_DTO> LayHoaDon(string mahd)
        {
            return HoaDon_DAO.LayHoaDon(mahd);
        }
        public static List<HoaDon_DTO> LayHoaDon1()
        {
            return HoaDon_DAO.LayHoaDon1();
        }
        public static List<NhanVien_DTO> LayNhanVien()
        {
            return NhanVien_DAO.LayNhanVien();
        }
        //thim mới nè

        public static bool ThemHoaDon(HoaDon_DTO hd)
        {
            return HoaDon_DAO.ThemHoaDon(hd);
        }
        // Tìm NV theo mã
        public static HoaDon_DTO TimHoaDonTheoMa(string ma)
        {
            return HoaDon_DAO.TimHoaDonTheoMa(ma);
        }

        // Sửa thông tin NV
        public static bool CapNhatNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.CapNhatNhanVien(nv);
        }

        // Xóa thông tin NV
        public static bool XoaNhanVien(string manv)
        {
            return NhanVien_DAO.XoaNhanVien(manv);
        }

        public static void CapNhatTongTien(long v, string mahd)
        {
            HoaDon_DAO.CapNhatTongTien(v, mahd);
        }
        public static List<HoaDon_DTO> LayHoaDonTheoNgay(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            return HoaDon_DAO.LayHoaDonTheoNgay(ngaybatdau, ngayketthuc);
        }

    }
} 
    

