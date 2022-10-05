using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Security.Cryptography;

namespace BUS
{
    public class TaiKhoan_BUS
    {
        public static TaiKhoan_DTO LayNguoiDung(string ten, string matkhau)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = TaiKhoan_BUS.GetMd5Hash(md5Hash, matkhau);
            return TaiKhoan_DAO.LayNguoiDung(ten, matkhauMH);
        }
        public static bool CapNhatNguoiDungBUS(string ten, string mkmoi )
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = TaiKhoan_BUS.GetMd5Hash(md5Hash, mkmoi);
            return TaiKhoan_DAO.CapNhatNguoiDungDAO(ten, matkhauMH);
        }

        public static List<TaiKhoan_DTO> DanhSachNguoiDungBUS()
        {
            return TaiKhoan_DAO.DanhSachNguoiDungDAO();
        }

        // Hàm mã hóa
        // Tham khảo tại
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public static bool ThemNguoiDungBUS(string ten, string matkhau, int quyen, string manv)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = TaiKhoan_BUS.GetMd5Hash(md5Hash, matkhau);
            return TaiKhoan_DAO.ThemNguoiDungDAO(ten, matkhauMH, quyen, manv);
        }
        //dang thí nghiệm
        public static bool XoaNguoiDungBUS(string ten)
        {
            return TaiKhoan_DAO.XoaNguoiDungDAO(ten);
        }

        public static List<TaiKhoan_DTO> KiemTraID(string sTen)
        {
            return TaiKhoan_DAO.KiemTraID(sTen);
        }

        public static bool ThayDoiQuyenND_DAO(string id, int thaydoi)
        {
            return TaiKhoan_DAO.ThayDoiQuyenND_BUS(id, thaydoi);
        }

        public static bool CapLaiMatKhauBUS(string id, string manv)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = TaiKhoan_BUS.GetMd5Hash(md5Hash, "123");
            return TaiKhoan_DAO.CapLaiMatKhauDAO(id, matkhauMH, manv);
        }
    }

}



