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
    public partial class frmPhanLoai : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanLoai()
        {
            InitializeComponent();
        }
        BindingSource LoaiList = new BindingSource();
        bool canInsert = false;
        private void frmPhanLoai_Load(object sender, EventArgs e)
        {
            List<Loai_DTO> lstLoai = Loai_BUS.LayLoai();
            dsvLoai.DataSource = LoaiList;
            HienThiDSLoaiLenDatagrid();
            BindingLoai();
            dsvLoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loadHD();
        }
        public void BindingLoai()
        {
            txtMaloai.DataBindings.Add(new Binding("Text", dsvLoai.DataSource, "SMaLoai", true, DataSourceUpdateMode.Never));
            txtTenloai.DataBindings.Add(new Binding("Text", dsvLoai.DataSource, "STenLoai", true, DataSourceUpdateMode.Never));

        }


        private void HienThiDSLoaiLenDatagrid()
        {
            List<Loai_DTO> lstLoai = Loai_BUS.LayLoai();
            LoaiList.DataSource = lstLoai;
            //sManv sHoTen dtNgaySinh sGioiTinh sDiaChi sDienThoai
            //Header

        }
        void loadHD()
        {
            dsvLoai.Columns["SMaLoai"].HeaderText = "Mã loại sản phẩm";
            dsvLoai.Columns["STenLoai"].HeaderText = "Tên loại sản phẩm";
            dsvLoai.Columns["SAn"].Visible = false;


            dsvLoai.Columns["SMaLoai"].Width = 400;
            dsvLoai.Columns["STenLoai"].Width = 400;
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!canInsert)
            {
                txtMaloai.ReadOnly = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                canInsert = true;
                return;
            }
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaloai.Text == "" || txtTenloai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                txtMaloai.ReadOnly = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                canInsert = false;
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không

            // Kiểm tra mã nhân viên có bị trùng không
            if (Loai_BUS.TimLoaiTheoMa(txtMaloai.Text) != null)
            {
                MessageBox.Show("Mã loaị đã tồn tại! Vui lòng chọn mã khác.");
                txtMaloai.ReadOnly = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                canInsert = false;
                return;
            }
            // Gán dữ liệu vào kiểu KhachHangDTO
            Loai_DTO lo = new Loai_DTO();
            lo.SMaLoai = txtMaloai.Text;
            lo.STenLoai = txtTenloai.Text;
           
            if (Loai_BUS.ThemLoai(lo) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            MessageBox.Show("Đã thêm loại.");
            HienThiDSLoaiLenDatagrid();
            txtMaloai.ReadOnly = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            canInsert = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (frmMain.TaiKhoan.IQuyen == 1)
            {
                string malo = txtMaloai.Text;
            if (dsvLoai.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (malo == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (Loai_BUS.XoaLoai(malo))
                {
                    MessageBox.Show("Xóa loại thành công");
                }
                else
                {
                    MessageBox.Show("Xóa loại thất bại");
                }

                HienThiDSLoaiLenDatagrid();
            }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xóa !");
            }

}

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaloai.Text == "" || txtTenloai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã khách hàng có tồn tại không
            if (Loai_BUS.TimLoaiTheoMa(txtMaloai.Text) == null)
            {
                MessageBox.Show("Mã loại không tồn tại!");
                return;
            }
            // Gán dữ liệu vào kiểu KhachHangDTO
            Loai_DTO lo = new Loai_DTO();
            lo.SMaLoai = txtMaloai.Text;
            lo.STenLoai = txtTenloai.Text;
            

            // Thực hiện cập nhật
            if (Loai_BUS.CapNhatLoai(lo) == false)
            {
                MessageBox.Show("Không cập nhật được.");
                return;
            }
            HienThiDSLoaiLenDatagrid();
            MessageBox.Show("Đã cập nhật khách hàng.");
            HienThiDSLoaiLenDatagrid();
        }
        /*create table loaisp
(
maloai nchar(20),
tenloai nvarchar(50),	
primary key (maloai)
) */
    }
}