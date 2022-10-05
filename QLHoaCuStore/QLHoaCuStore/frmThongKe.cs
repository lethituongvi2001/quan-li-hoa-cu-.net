using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmThongKe : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            HienThiDSHangLenDatagrid();

        }
        private void HienThiDSHangLenDatagrid()
        {
            List<Hang_DTO> lstHang = Hang_BUS.LayHang();
            dgvTonKho.DataSource = lstHang;

            //, sGhiChu, sMaLoai, sMaNcc,sFileAnh
            //sMahc, sTenhc, sSoLuong, sDonGia, sMaLoai, sMaNcc, sGhiChu, sAnh
            dgvTonKho.Columns["SMahc"].HeaderText = "Mã Họa Cụ";
            dgvTonKho.Columns["STenhc"].HeaderText = "Tên Họa Cụ ";
            dgvTonKho.Columns["SSoLuong"].HeaderText = "Số lượng";
            dgvTonKho.Columns["SDonGia"].HeaderText = "Đơn Giá";
            dgvTonKho.Columns["SGhiChu"].Visible = false;
            dgvTonKho.Columns["SMaLoai"].Visible = false;
            dgvTonKho.Columns["SMaNcc"].Visible = false;
            dgvTonKho.Columns["SFileAnh"].Visible = false;


            dgvTonKho.Columns["SMahc"].Width = 400;
            dgvTonKho.Columns["STenhc"].Width = 400;
            dgvTonKho.Columns["SSoLuong"].Width = 400;
            dgvTonKho.Columns["SDonGia"].Width = 400;
           

        }
    }
}