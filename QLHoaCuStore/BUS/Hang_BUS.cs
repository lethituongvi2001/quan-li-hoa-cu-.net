using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class Hang_BUS
    {
        public static List<Hang_DTO> LayHang()
        {
            return Hang_DAO.LayHang();
        }
       
        //thim mới nè

        public static bool ThemHang(Hang_DTO ha)
        {
            return Hang_DAO.ThemHang(ha);
        }
        // Tìm NV theo mã
        public static Hang_DTO TimHangTheoMa(string mah)
        {
            return Hang_DAO.TimHangTheoMa(mah);
        }

        // Sửa thông tin NV
        public static bool CapNhatHang(Hang_DTO ha)
        {
            return Hang_DAO.CapNhatHang(ha);
        }

        // Xóa thông tin NV
        public static bool XoaHang(string mah)
        {
            return Hang_DAO.XoaHang(mah);
        }
        public static bool CapNhatHang_MANCC_MoiBUS(string ncc, string manccCu)
        {
            return Hang_DAO.CapNhatHang_MANCC_MoiDAO(ncc, manccCu);
        }

        public static List<Hang_DTO> GetID_Hang(string manccCu)
        {
            return Hang_DAO.GetID_Hang(manccCu);
        }

        public static void CapNhatSLHC(string sMahc, decimal value)
        {
             Hang_DAO.CapNhatSLHC(sMahc, value);
        }

        public static bool ThemAnh(string fileName, string mahc)
        {
            return Hang_DAO.ThemAnh(fileName, mahc);
        }

        public static void TaoAnh(string sMahc)
        {
            Hang_DAO.TaoAnh(sMahc);
        }

        public static string LayAnh(string cellvalue)
        {
            return Hang_DAO.LayTenAnh(cellvalue);
        }
    }
} 
    

