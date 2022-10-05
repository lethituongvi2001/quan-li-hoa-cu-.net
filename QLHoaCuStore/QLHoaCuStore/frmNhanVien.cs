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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        BindingSource NhanVienList = new BindingSource();

        bool canInsert = false;
        public frmNhanVien()
        {
            InitializeComponent();

            dsgDSNhanVien.DataSource = NhanVienList;

            HienThiDSNhanVienLenDatagrid();

            BindingNhanVien();
        }


        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            

            

            
            
            dsgDSNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loadHD();
        }
        
        //sManv sHoTen sNgaySinh sGioiTinh sDiaChi sDienThoai
        public void BindingNhanVien()
        {
            txtManv.DataBindings.Add(new Binding("Text", dsgDSNhanVien.DataSource, "SManv", true, DataSourceUpdateMode.Never));
            txtHoten.DataBindings.Add(new Binding("Text", dsgDSNhanVien.DataSource, "SHoTen", true, DataSourceUpdateMode.Never));
            dtpNgaysinh.DataBindings.Add(new Binding("Text", dsgDSNhanVien.DataSource, "DtNgaySinh", true, DataSourceUpdateMode.Never));
            txtDiachi.DataBindings.Add(new Binding("Text", dsgDSNhanVien.DataSource, "SDiaChi", true, DataSourceUpdateMode.Never));
            txtDienthoai.DataBindings.Add(new Binding("Text", dsgDSNhanVien.DataSource, "SDienThoai", true, DataSourceUpdateMode.Never));
        }

       
        private void HienThiDSNhanVienLenDatagrid()
        {
            List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayNhanVien();
            NhanVienList.DataSource = lstNhanVien;
            //sManv sHoTen dtNgaySinh sGioiTinh sDiaChi sDienThoai
            //Header
            
        }
        void loadHD() {
            dsgDSNhanVien.Columns["SManv"].HeaderText = "Mã Nhân Viên";
            dsgDSNhanVien.Columns["SHoTen"].HeaderText = "Họ và Tên ";
            dsgDSNhanVien.Columns["DtNgaysinh"].HeaderText = "Ngày sinh";
            dsgDSNhanVien.Columns["SGioiTinh"].HeaderText = "Giới Tính";
            dsgDSNhanVien.Columns["SDiaChi"].HeaderText = "Địa chỉ";
            dsgDSNhanVien.Columns["SDienThoai"].HeaderText = "Điện thoại";
            dsgDSNhanVien.Columns["SAn"].Visible = false;
            
        } 
        private void dsgDSNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = this.dsgDSNhanVien.Rows[e.RowIndex];
                string gioitinh = dr.Cells[2].Value.ToString();
                if (gioitinh.Equals("Nam"))
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
            }
            catch { };

        }
        
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!canInsert)
            {
                txtManv.ReadOnly = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                canInsert = true;
                return;
            }
           
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtManv.Text == "" || txtHoten.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                txtManv.ReadOnly = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                canInsert = false;
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
          
            // Kiểm tra mã nhân viên có bị trùng không
            if (NhanVien_BUS.TimNhanVienTheoMa(txtManv.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại! Vui lòng chọn mã khác.");
                txtManv.ReadOnly = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                canInsert = false;
                return;
            }
            // Gán dữ liệu vào kiểu NhanVienDTO
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SManv = txtManv.Text;
            nv.SHoTen = txtHoten.Text;
            nv.DtNgaySinh = DateTime.Parse(dtpNgaysinh.Text);
            
            if (radNam.Checked == true)
            {
                nv.SGioiTinh = "Nam";
            }
            else
            {
                nv.SGioiTinh = "Nữ";
            }
            nv.SDiaChi = txtDiachi.Text;
            nv.SDienThoai = txtDienthoai.Text;
            if (NhanVien_BUS.ThemNhanVien(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            MessageBox.Show("Đã thêm nhân viên.");

            HienThiDSNhanVienLenDatagrid();
            
            txtManv.ReadOnly = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            canInsert = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtManv.Text == "" || txtHoten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã nhân viên có tồn tại không
            if (NhanVien_BUS.TimNhanVienTheoMa(txtManv.Text) == null)
            {
                MessageBox.Show("Mã nhân viên không tồn tại!");
                return;
            }
            // Gán dữ liệu vào kiểu NhanVienDTO
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SManv = txtManv.Text;
            nv.SHoTen = txtHoten.Text;
            nv.DtNgaySinh = DateTime.Parse(dtpNgaysinh.Text);

            if (radNam.Checked == true)
            {
                nv.SGioiTinh = "Nam";
            }
            else
            {
                nv.SGioiTinh = "Nữ";
            }
            nv.SDiaChi = txtDiachi.Text;
            nv.SDienThoai = txtDienthoai.Text;

           
            // Thực hiện cập nhật
            if (NhanVien_BUS.CapNhatNhanVien(nv) == true)
            {
                MessageBox.Show("Đã cập nhật nhân viên.");
                HienThiDSNhanVienLenDatagrid();
                
                loadHD();

                return;
            }

            
            
            MessageBox.Show("Không cập nhật được");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = txtManv.Text;
            if (dsgDSNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (manv == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
               
                if (NhanVien_BUS.XoaNhanVien(manv))
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                    TaiKhoan_BUS.XoaNguoiDungBUS(manv);
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại");
                }

                HienThiDSNhanVienLenDatagrid();
            }
            

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            List<NhanVien_DTO> ds = NhanVien_BUS.LayNhanVien();
            List<NhanVien_DTO> kq = (from hd in ds
                                   where hd.SManv.Contains(txtTimKiem.Text)
                                   select hd).ToList();
            NhanVienList.DataSource = kq;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu vào cơ sở dữ liệu");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
           // List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayNhanVien();
           // dsgDSNhanVien.DataSource = NhanVienList;
            HienThiDSNhanVienLenDatagrid();           
            dsgDSNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loadHD();
        }

        private void txtHoten_Click(object sender, EventArgs e)
        {
            txtHoten.Text = "";
        }

        private void txtDiachi_Click(object sender, EventArgs e)
        {
            txtDiachi.Text = "";
        }

        private void txtDienthoai_Click(object sender, EventArgs e)
        {
            txtDienthoai.Text = "";
        }
    }
}