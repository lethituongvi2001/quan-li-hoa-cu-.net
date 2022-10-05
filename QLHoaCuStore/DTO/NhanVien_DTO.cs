using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string sManv;//sManv sHoTen dtNgaySinh sGioiTinh sDiaChi sDienThoai
        private string sHoTen;
        private DateTime dtNgaySinh;
        private string sGioiTinh;
        private string sDiaChi;
        private string sDienThoai;
        private int sAn;
        public string SManv { get => sManv; set => sManv = value; }
        public string SHoTen { get => sHoTen; set => sHoTen = value; }
        
        public string SGioiTinh { get => sGioiTinh; set => sGioiTinh = value; }
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        public string SDienThoai { get => sDienThoai; set => sDienThoai = value; }
        public DateTime DtNgaySinh { get => dtNgaySinh; set => dtNgaySinh = value; }
        public int SAn { get => sAn; set => sAn = value; }
    }
}
