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
using QLHoaCuStore;

namespace GUI
{
    public partial class frmDoanhThu : DevExpress.XtraEditors.XtraForm
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            HienThiHoaDonLenDataGrid();
            KhoiTaoVungTimKiem();
            dtpDenNgay.Value = DateTime.Today;
            dtpTuNgay.Value = DateTime.Parse("1/" + DateTime.Today.Month + "/" + DateTime.Today.Year); 
        }
        private void HienThiHoaDonLenDataGrid()
        {
            List<HoaDon_DTO> lstHoaDon = HoaDon_BUS.LayHoaDon1();
            dgvDoanhThu.DataSource = lstHoaDon;
        }
        private void KhoiTaoVungTimKiem()
        {
            radChonNgay.Checked = false;
            dtpDenNgay.Enabled = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DateTime ngaybd = dtpTuNgay.Value;
            DateTime ngaykt = DateTime.Now;
            if (radChonNgay.Checked == true)
                ngaykt = dtpDenNgay.Value;

            if(ngaybd > ngaykt)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc.");
                return;
            }

            List<HoaDon_DTO> lstQT = HoaDon_BUS.LayHoaDonTheoNgay(ngaybd, ngaykt);
            dgvDoanhThu.DataSource = lstQT;

            long tong = 0;
            foreach(HoaDon_DTO hd in lstQT)
            {
                tong += hd.STongTien;
            }
            lbTongDoanhThu.Text = tong.ToString();
            lbSHD.Text = lstQT.Count.ToString();
        }

        private void radNgayHienTai_CheckedChanged(object sender, EventArgs e)
        {
            KhoiTaoVungTimKiem();
        }

        private void radChonNgay_CheckedChanged(object sender, EventArgs e)
        {
            dtpDenNgay.Enabled = true;
        }

        private void dgvDoanhThu_DoubleClick(object sender, EventArgs e)
        {
            var mahd = (sender as DataGridView).SelectedCells[0].Value;
            frmChiTiet f = new frmChiTiet(mahd.ToString());
            f.ShowDialog();
        }
    }
}