using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        //sMaKhach sTenKhach sDiaChi sDienThoai
        private string sMaKhach;
        private string sTenKhach;
        private string sDiaChi;
        private string sDienThoai;
        private string sAn;

        public string SMaKhach { get => sMaKhach; set => sMaKhach = value; }
        public string STenKhach { get => sTenKhach; set => sTenKhach = value; }
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        public string SDienThoai { get => sDienThoai; set => sDienThoai = value; }
        public string SAn { get => sAn; set => sAn = value; }
    }
}
