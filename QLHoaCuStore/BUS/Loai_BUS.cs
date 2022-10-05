using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class Loai_BUS
    {
        public static List<Loai_DTO> LayLoai()
        {
            return Loai_DAO.LayLoai();
        }
        //thim mới nè

        public static bool ThemLoai(Loai_DTO lo)
        {
            return Loai_DAO.ThemLoai(lo);
        }
        // Tìm NV theo mã
        public static Loai_DTO TimLoaiTheoMa(string mal)
        {
            return Loai_DAO.TimLoaiTheoMa(mal);
        }

        // Sửa thông tin NV
        public static bool CapNhatLoai(Loai_DTO lo)
        {
            return Loai_DAO.CapNhatLoai(lo);
        }

        // Xóa thông tin NV
        public static bool XoaLoai(string malo)
        {
            return Loai_DAO.XoaLoai(malo);
        }
      
    }
}


