using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hang_DTO
    {

        //sMahc, sTenhc, sSoLuong, sDonGia, sGhiChu, sMaLoai, sMaNcc,sFileAnh
        private string sMahc;
        private string sTenhc;
        private int sSoLuong;
        private int sDonGia;       
        private string sGhiChu;
        private string sMaLoai;
        private string sMaNcc;
        private string sFileAnh;
        private int sAn;

        public string SMahc { get => sMahc; set => sMahc = value; }
        public string STenhc { get => sTenhc; set => sTenhc = value; }
        public int SSoLuong { get => sSoLuong; set => sSoLuong = value; }
        public int SDonGia { get => sDonGia; set => sDonGia = value; }
        public string SGhiChu { get => sGhiChu; set => sGhiChu = value; }
        public string SMaLoai { get => sMaLoai; set => sMaLoai = value; }
        public string SMaNcc { get => sMaNcc; set => sMaNcc = value; }
        public string SFileAnh { get => sFileAnh; set => sFileAnh = value; }
        public int SAn { get => sAn; set => sAn = value; }
    }
    
}
