using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NCC_DTO
    {
        //SMaNCC STenNCC SEmail SWebsite  SDiaChi SDienThoai
        private string sMaNCC;
        private string sTenNCC;
        private string sDiaChi;
        private string sDienThoai;      
        private string sWebsite;
        private string sAn;

        public string SMaNCC { get => sMaNCC; set => sMaNCC = value; }
        public string STenNCC { get => sTenNCC; set => sTenNCC = value; }
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        public string SDienThoai { get => sDienThoai; set => sDienThoai = value; }   
        public string SWebsite { get => sWebsite; set => sWebsite = value; }
        public string SAn { get => sAn; set => sAn = value; }
    }
}
