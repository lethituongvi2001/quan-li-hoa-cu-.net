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
    public partial class frmHoaDon : DevExpress.XtraEditors.XtraForm
    {
        HoaDon_DTO hoadon;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            


            // Kiểm tra dữ liệu có bị bỏ trống
            if (String.IsNullOrEmpty(txtMahd.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
                return;
            }

            // Kiểm tra mã nhân viên có bị trùng không
            if (HoaDon_BUS.TimHoaDonTheoMa(txtMahd.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại! Vui lòng chọn mã khác.");
                return;
            }
            groupHC.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.BackColor = Color.Red;
            txtMahd.ReadOnly = true;

            // Gán dữ liệu vào kiểu NhanVienDTO
            hoadon = new HoaDon_DTO();
            hoadon.SMahd = txtMahd.Text;
            hoadon.DtNgayBan = (DateTime)dtpNgayBan.EditValue;
            hoadon.STongTien = 0;

            hoadon.SManv = frmMain.TaiKhoan.NhanVien.SManv;
            hoadon.SMaKhach = (cboKhachhang.SelectedItem as KhachHang_DTO).SMaKhach;

           
            if (HoaDon_BUS.ThemHoaDon(hoadon) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            MessageBox.Show("Đã thêm hóa đơn.");
            lblTongtien.Text = 0 + "";
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            //load combobox
            //load cbb khach hang
            HienThiDSKHLenCombobox();
            HienThiDSSPLenCombobox();
            dtpNgayBan.EditValue = DateTime.Today;
            HienThiDSLenDatagrid();
        }
        private void HienThiDSLenDatagrid()
        {
            List<HoaDon_DTO> lstHoaDon = HoaDon_BUS.LayHoaDon1();
            dgvDSHD.DataSource = lstHoaDon;

        }
        //LOAD DNAH SACH SẢN PHÂMTR
        void LoadDSSP()
        {
            List<ChiTietDH_DTO> lstCTHD = ChiTietHD_BUS.LayChiTiet(txtMahd.Text);
            dgvCTHD.DataSource = lstCTHD;
            //sManv sHoTen dtNgaySinh sGioiTinh sDiaChi sDienThoai
            //Header
        }

        private void HienThiDSKHLenCombobox()
        {
            List<KhachHang_DTO> lstLoai = KhachHang_BUS.LayKhachHang();
            cboKhachhang.DataSource = lstLoai;
            cboKhachhang.DisplayMember = "SMaKhach";
            cboKhachhang.ValueMember = "SMaKhach";
        }

        private void HienThiDSSPLenCombobox()
        {
            List<Hang_DTO> lstLoai = Hang_BUS.LayHang();
            cboHoacu.DataSource = lstLoai;
            cboHoacu.DisplayMember = "STenhc";
            cboHoacu.ValueMember = "SMahc";
            lbTenNhanVIen.Text = frmMain.TaiKhoan.NhanVien.SHoTen;
            Hang_BUS.CapNhatSLHC((cboHoacu.SelectedItem as Hang_DTO).SMahc, Convert.ToInt32(lbSlton.Text) - numSL.Value);
            lbSlton.Text = (Convert.ToInt32(lbSlton.Text) - numSL.Value).ToString();

        }

        private void cboKhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == null)
                return;
            lbTenKH.Text = ((sender as System.Windows.Forms.ComboBox).SelectedItem as KhachHang_DTO).STenKhach;
        }

        private void cboHoacu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == null)
                return;
            lbDonGia.Text = ((sender as System.Windows.Forms.ComboBox).SelectedItem as Hang_DTO).SDonGia.ToString();
            lbSlton.Text = ((sender as System.Windows.Forms.ComboBox).SelectedItem as Hang_DTO).SSoLuong.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (cboHoacu.SelectedItem == null || String.IsNullOrEmpty(txtMahd.Text))
            {
                MessageBox.Show("Vui lòng chọn họa cụ và khuyến mãi");
                return;
            }

            //kiểm tra nếu chọn quá số lượng trong kho
            if(numSL.Value > Convert.ToInt32(lbSlton.Text))
            {
                MessageBox.Show("Không đủ số lượng trong kho");
                return;
            }

            // Kiểm tra sản phẩm đã có trong hóa đơn chưa
            if (ChiTietHD_BUS.KiemTraSanPham( (cboHoacu.SelectedItem as Hang_DTO).SMahc, hoadon.SMahd) ==  null)
            //nếu chưa
            {
                //theem hoaj cuj nayf vaof chitiet hd
                ChiTietDH_DTO cthd = new ChiTietDH_DTO()
                {
                    Mahd = hoadon.SMahd,
                    Mahc = (cboHoacu.SelectedItem as Hang_DTO).SMahc,
                    Soluong = Math.Abs((int)numSL.Value),
                    Dongia = Convert.ToInt32(lbDonGia.Text),
                    Khuyenmai = Convert.ToDouble(txtKhuyenMai.Text),
                    Thanhtien = Convert.ToInt64(lblThanhtien.Text)
                };

                if (ChiTietHD_BUS.ThemChiTietHD(cthd) == false)
                {
                    MessageBox.Show("Thêm thất bại");
                    return;
                }
                MessageBox.Show("Thêm thành công");
                HoaDon_BUS.CapNhatTongTien(Convert.ToInt64(lblThanhtien.Text), hoadon.SMahd);
                lblTongtien.Text = (Convert.ToInt64(lblTongtien.Text) + Convert.ToInt64(lblThanhtien.Text)).ToString();

                //trừ đi số lượng bên kho họa cụ
                Hang_BUS.CapNhatSLHC((cboHoacu.SelectedItem as Hang_DTO).SMahc, Convert.ToInt32(lbSlton.Text) - numSL.Value);
                lbSlton.Text = (Convert.ToInt32(lbSlton.Text) - numSL.Value).ToString();
                LoadChiTietHD();
                HienThiDSLenDatagrid();
            }
            //nếu rồi
            else
            {
                int slton = Convert.ToInt32(lbSlton.Text);
                ChiTietDH_DTO hc_trong_hd = ChiTietHD_BUS.KiemTraSanPham((cboHoacu.SelectedItem as Hang_DTO).SMahc, hoadon.SMahd);
                int conlai = (int)(hc_trong_hd.Soluong + numSL.Value);

                //nếu sl thêm > 0
                if(numSL.Value > 0)
                {
                    ChiTietHD_BUS.CapNhatSP((cboHoacu.SelectedItem as Hang_DTO).SMahc, hoadon.SMahd, conlai, (int)(hc_trong_hd.Thanhtien + Convert.ToInt32(lblThanhtien.Text)));
                    //cập nhật só lượng trong kho
                    Hang_BUS.CapNhatSLHC((cboHoacu.SelectedItem as Hang_DTO).SMahc, Convert.ToInt32(lbSlton.Text) - numSL.Value);
                    lbSlton.Text = (Convert.ToInt32(lbSlton.Text) - numSL.Value).ToString();

                    HoaDon_BUS.CapNhatTongTien(Convert.ToInt64(lblThanhtien.Text), hoadon.SMahd);
                    lblTongtien.Text = (Convert.ToInt64(lblTongtien.Text) + Convert.ToInt64(lblThanhtien.Text)).ToString();

                    LoadChiTietHD();
                    return;
                }


                //nếu số lượng âm hoặc lớn bằng sl tồn thì xóa
                if (conlai <= 0)
                {
                    //xóa cthd của sản phẩm đó
                    if(ChiTietHD_BUS.XoaSP((cboHoacu.SelectedItem as Hang_DTO).SMahc, hoadon.SMahd))
                    {
                        MessageBox.Show("Xóa thành công !");
                        //cập nhật só lượng trong kho
                        Hang_BUS.CapNhatSLHC((cboHoacu.SelectedItem as Hang_DTO).SMahc, Convert.ToInt32(lbSlton.Text) + hc_trong_hd.Soluong);
                        lbSlton.Text = (Convert.ToInt32(lbSlton.Text) - numSL.Value).ToString();

                        HoaDon_BUS.CapNhatTongTien(Convert.ToInt64(lblThanhtien.Text), hoadon.SMahd);
                        lblTongtien.Text = (Convert.ToInt64(lblTongtien.Text) + Convert.ToInt64(lblThanhtien.Text)).ToString();



                        LoadChiTietHD();
                        return;
                    }
                }
                //trừ bớt đi
                else
                {
                    if(ChiTietHD_BUS.CapNhatSP((cboHoacu.SelectedItem as Hang_DTO).SMahc, hoadon.SMahd, conlai, (int)(hc_trong_hd.Thanhtien + Convert.ToInt32(lblThanhtien.Text))))
                    {
                        MessageBox.Show("Xóa thành công !");
                        //cập nhật só lượng trong kho
                        Hang_BUS.CapNhatSLHC((cboHoacu.SelectedItem as Hang_DTO).SMahc, Convert.ToInt32(lbSlton.Text) - numSL.Value);
                        lbSlton.Text = (Convert.ToInt32(lbSlton.Text) - numSL.Value).ToString();

                        HoaDon_BUS.CapNhatTongTien(Convert.ToInt64(lblThanhtien.Text), hoadon.SMahd);
                        lblTongtien.Text = (Convert.ToInt64(lblTongtien.Text) + Convert.ToInt64(lblThanhtien.Text)).ToString();


                        LoadChiTietHD();
                        return;
                    }
                }
                
            }
        }

        private void txtKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double tt = (double)(Convert.ToDouble(numSL.Value)*Convert.ToDouble(lbDonGia.Text)) - (double)(Convert.ToDouble(numSL.Value) * Convert.ToDouble(lbDonGia.Text))*Convert.ToDouble(txtKhuyenMai.Text) / 100;
                lblThanhtien.Text = Math.Round(tt, 2).ToString();
            }
            catch { txtKhuyenMai.Text = 0 + ""; }
        }

        void LoadChiTietHD()
        {
            List<ChiTietDH_DTO> lstChiIetHD= ChiTietHD_BUS.LayChiTiet(hoadon.SMahd);
            dgvCTHD.DataSource = lstChiIetHD;
            //sManv sHoTen dtNgaySinh sGioiTinh sDiaChi sDienThoai
            //Header
        }

        void LoadHoaDon()
        {
            List<HoaDon_DTO> lstHoaDon = HoaDon_BUS.LayHoaDon(hoadon.SMahd);
            dgvDSHD.DataSource = lstHoaDon;
            //sManv sHoTen dtNgaySinh sGioiTinh sDiaChi sDienThoai
            //Header
        }

        private void numSL_ValueChanged(object sender, EventArgs e)
        {
            double tt = (double)(Convert.ToDouble(numSL.Value) * Convert.ToDouble(lbDonGia.Text)) - (double)(Convert.ToDouble(numSL.Value) * Convert.ToDouble(lbDonGia.Text)) * Convert.ToDouble(txtKhuyenMai.Text) / 100;
            lblThanhtien.Text = Math.Round(tt, 2).ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            groupHC.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.BackColor = Color.Black;
            txtMahd.ReadOnly = false;
            txtMahd.Text = "";                    
            LoadChiTietHD();

            HienThiDSSPLenCombobox();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            List<HoaDon_DTO> ds = HoaDon_BUS.LayHoaDon1();
            List<HoaDon_DTO> kq = (from hd in ds
                                  where hd.SMahd.Contains(txtTimkiem.Text)
                                  select hd).ToList();
            dgvDSHD.DataSource = kq;
        }

        private void dgvDSHD_DoubleClick(object sender, EventArgs e)
        {
            var mahd = (sender as DataGridView).SelectedCells[0].Value;
            frmChiTiet f = new frmChiTiet(mahd.ToString());
            f.ShowDialog();
        }

        /*
create table hdban
(
mahd nchar(20),
ngayban smalldatetime,
tongtien int,
manv nchar(20),--khoa ngoai
makhach nchar(20),	--khoa ngoai	
primary key (mahd),

----tạo khóa ngoại bảng hdban
foreign key (manv) references nhanvien(manv),
foreign key (makhach) references khachhang(makhach)
)

create table cthdban
(
id int identity(1,1) primary key,
mahd nchar(20),
mahc nchar(20),
soluong int,
dongia int,
khuyenmai int,
thanhtien int,	

--khoa ngoai
foreign key(mahd) references hdban(mahd),
foreign key(mahc) references hoacu(mahc)
)
go
*/
    }
}