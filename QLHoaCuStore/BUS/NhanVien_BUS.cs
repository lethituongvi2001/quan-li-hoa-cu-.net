using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class NhanVien_BUS
    {
        public static List<NhanVien_DTO> LayNhanVien()
        {
            return NhanVien_DAO.LayNhanVien();
        }
        //thim mới nè

        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.ThemNhanVien(nv);
        }
        // Tìm NV theo mã
        public static NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            return NhanVien_DAO.TimNhanVienTheoMa(ma);
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
        /*
       public static bool CapNhatNhienVien_MACV_MoiBUS(string cv, string macvCu)
       {
           return NhanVien_DAO.CapNhatNhienVien_MACV_MoiDAO(cv, macvCu);
       }

       public static List<NhanVien_DTO> GetID_NhanVien(string macvCu)
       {
           return NhanVien_DAO.GetID_NhanVien(macvCu);
       }
     */
    }
} 
    

