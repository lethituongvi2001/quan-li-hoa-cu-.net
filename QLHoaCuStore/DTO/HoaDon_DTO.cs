using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        private string sMahd;//SMahd DtNgayBan STongTien SManv SMaKhach    
        private DateTime dtNgayBan;
        private int sTongTien;
        private string sManv;
        private string sMaKhach;

        public string SMahd { get => sMahd; set => sMahd = value; }
        public DateTime DtNgayBan { get => dtNgayBan; set => dtNgayBan = value; }
        public int STongTien { get => sTongTien; set => sTongTien = value; }
        public string SManv { get => sManv; set => sManv = value; }
        public string SMaKhach { get => sMaKhach; set => sMaKhach = value; }
    }
}
