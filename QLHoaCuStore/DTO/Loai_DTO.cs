using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Loai_DTO
    {
        //sMaKhach sTenKhach sDiaChi sDienThoai
        private string sMaLoai;
        private string sTenLoai;
        private string sAn;
        public string SMaLoai { get => sMaLoai; set => sMaLoai = value; }
        public string STenLoai { get => sTenLoai; set => sTenLoai = value; }
        public string SAn { get => sAn; set => sAn = value; }
    }
}
