using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class KhachHang_BUS
    {
        public static List<KhachHang_DTO> LayKhachHang()
        {
            return KhachHang_DAO.LayKhachHang();
        }
        //thim mới nè

        public static bool ThemKhachHang(KhachHang_DTO kh)
        {
            return KhachHang_DAO.ThemKhachHang(kh);
        }
        // Tìm NV theo mã
        public static KhachHang_DTO TimKhachHangTheoMa(string mak)
        {
            return KhachHang_DAO.TimKhachHangTheoMa(mak);
        }

        // Sửa thông tin NV
        public static bool CapNhatKhachHang(KhachHang_DTO kh)
        {
            return KhachHang_DAO.CapNhatKhachHang(kh);
        }

        // Xóa thông tin NV
        public static bool XoaKhachHang(string makh)
        {
            return KhachHang_DAO.XoaKhachHang(makh);
        }
      
    }
}


