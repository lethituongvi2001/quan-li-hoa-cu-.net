using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietHD_BUS
    {
        public static List<ChiTietDH_DTO> LayChiTiet(string mahd)
        {
            return ChiTietHD_DAO.LayChiTiet( mahd);
        }

        public static ChiTietDH_DTO KiemTraSanPham(string sMahc, string mahd)
        {
            return ChiTietHD_DAO.KiemTraSanPham(sMahc, mahd);
        }

        public static bool ThemChiTietHD(ChiTietDH_DTO cthd)
        {
            return ChiTietHD_DAO.ThemCTHD(cthd);
        }

        public static bool XoaSP(string sMahc, string mahd)
        {
            return ChiTietHD_DAO.XoaSP(sMahc, mahd);
        }

        public static bool CapNhatSP(string sMahc, string sMahd, int conlai, int thanhtien)
        {
            return ChiTietHD_DAO.CapNhatSP(sMahc, sMahd, conlai, thanhtien);
        }
    }
}
