using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDH_DTO
    {
        private int _id;
        private string _mahd;
        private string _mahc;
        private int _soluong;
        private int _dongia;
        private double _khuyenmai;
        private long _thanhtien;

        public int Id { get => _id; set => _id = value; }
        public string Mahd { get => _mahd; set => _mahd = value; }
        public string Mahc { get => _mahc; set => _mahc = value; }
        public int Soluong { get => _soluong; set => _soluong = value; }
        public int Dongia { get => _dongia; set => _dongia = value; }
        public double Khuyenmai { get => _khuyenmai; set => _khuyenmai = value; }
        public long Thanhtien { get => _thanhtien; set => _thanhtien = value; }


    }
}
