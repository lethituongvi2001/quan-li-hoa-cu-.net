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
    public class NhanVien_DAO
    {
        static SqlConnection con;
        public static List<NhanVien_DTO> LayNhanVien()
        {
            string sTruyVan = "select  * from nhanvien where an = 0";
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
                nv.SAn = Convert.ToInt32(dt.Rows[i]["an"]);
                lstNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }

     
        // Thêm NV
        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"exec InsertNV N'{0}', N'{1}',N'{2}',N'{3}','{4}',N'{5}',N'{6}'", nv.SManv, nv.SHoTen, nv.DtNgaySinh.ToString("MM/dd/yyyy"), nv.SGioiTinh,
                nv.SDiaChi, nv.SDienThoai, nv.SAn);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin nhân viên có mã ma, trả về null nếu không thấy
        public static NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where manv=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO
            //sManv sHoTen dtNgaySinh sGioiTinh sDiaChi sDienThoai
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SManv = dt.Rows[0]["manv"].ToString();
            nv.SHoTen = dt.Rows[0]["hoten"].ToString();
            nv.DtNgaySinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());//lỗi vì sao?
            nv.SGioiTinh = dt.Rows[0]["gioitinh"].ToString();
            nv.SDiaChi = dt.Rows[0]["diachi"].ToString();
            
            nv.SDienThoai = dt.Rows[0]["dienthoai"].ToString();
           // nv.SAn = Convert.ToInt32(dt.Rows[0]["an"]);
            DataProvider.DongKetNoi(con);
            return nv;
        }
     
        // Cập nhật thông tin NV
        public static bool CapNhatNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"exec updateNV N'{0}',N'{1}',N'{2}',N'{3}',N'{4}' ,N'{5}',N'{6}'", nv.SHoTen, nv.DtNgaySinh.ToString("MM/dd/yyyy"), nv.SGioiTinh, nv.SDiaChi, nv.SDienThoai,nv.SAn, nv.SManv);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Xóa thông tin 1 nhân viên
        public static bool XoaNhanVien(string manv)
        {
            string sTruyVan = string.Format(@"update nhanvien set an = 1 where manv = '{0}'", manv);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}

