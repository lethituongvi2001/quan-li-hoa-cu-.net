using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class NCC_BUS
    {
        public static List<NCC_DTO> LayNCC()
        {
            return NCC_DAO.LayNCC();
        }
        //thim mới nè

        public static bool ThemNCC(NCC_DTO nc)
        {
            return NCC_DAO.ThemNCC(nc);
        }
        // Tìm NCC theo mã
        public static NCC_DTO TimNCCTheoMa(string man)
        {
            return NCC_DAO.TimNCCTheoMa(man);
        }

        // Sửa thông tin NCC
        public static bool CapNhatNCC(NCC_DTO nc)
        {
            return NCC_DAO.CapNhatNCC(nc);
        }

        // Xóa thông tin NCC
        public static bool XoaNCC(string manc)
        {
            return NCC_DAO.XoaNCC(manc);
        }
      
    }
}


