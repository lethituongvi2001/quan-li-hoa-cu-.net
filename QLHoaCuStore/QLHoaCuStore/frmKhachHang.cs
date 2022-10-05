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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        BindingSource KhachHangList = new BindingSource();
        bool canInsert = false;
        public frmKhachHang()
        {
            InitializeComponent();

        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            //  List<KhachHang_DTO> lstKhachHang = KhachHang_BUS.LayKhachHang();
            dsgDSKhachHang.DataSource = KhachHangList;
            HienThiDSKhachHangLenDatagrid();
            BindingKhachHang();

            dsgDSKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void BindingKhachHang()
        {
            txtMakhach.DataBindings.Add(new Binding("Text", dsgDSKhachHang.DataSource, "SMaKhach", true, DataSourceUpdateMode.Never));
            txtTenkhach.DataBindings.Add(new Binding("Text", dsgDSKhachHang.DataSource, "STenKhach", true, DataSourceUpdateMode.Never));

            txtDiachi.DataBindings.Add(new Binding("Text", dsgDSKhachHang.DataSource, "SDiaChi", true, DataSourceUpdateMode.Never));

            txtDienthoai.DataBindings.Add(new Binding("Text", dsgDSKhachHang.DataSource, "SDienThoai", true, DataSourceUpdateMode.Never));
        }


        private void HienThiDSKhachHangLenDatagrid()
        {

            List<KhachHang_DTO> lstKhachHang = KhachHang_BUS.LayKhachHang();
            KhachHangList.DataSource = lstKhachHang;
            ///sManv sHoTen dtNgaySinh sGioiTinh sDiaChi sDienThoai
            //Header
            dsgDSKhachHang.Columns["SMaKhach"].HeaderText = "Mã khách";
            dsgDSKhachHang.Columns["STenKhach"].HeaderText = "Họ và Tên ";

            dsgDSKhachHang.Columns["SDiaChi"].HeaderText = "Địa chỉ";
            dsgDSKhachHang.Columns["SDienThoai"].HeaderText = "Điện thoại";
            dsgDSKhachHang.Columns["SAn"].Visible = false;

            dsgDSKhachHang.Columns["SMaKhach"].Width = 200;
            dsgDSKhachHang.Columns["STenKhach"].Width = 200;

            dsgDSKhachHang.Columns["SDiaChi"].Width = 300;
            dsgDSKhachHang.Columns["SDienThoai"].Width = 200;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!canInsert)
            {
                txtMakhach.ReadOnly = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                canInsert = true;
                return;
            }

            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMakhach.Text == "" || txtTenkhach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                txtMakhach.ReadOnly = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                canInsert = false;

                return;
            }


            // Kiểm tra mã khách hàng có bị trùng không
            if (KhachHang_BUS.TimKhachHangTheoMa(txtMakhach.Text) != null)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại! Vui lòng chọn mã khác.");
                txtMakhach.ReadOnly = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                canInsert = false;
                return;
            }
            // Gán dữ liệu vào kiểu KhachHangDTO
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.SMaKhach = txtMakhach.Text;
            kh.STenKhach = txtTenkhach.Text;
            kh.SDiaChi = txtDiachi.Text;
            kh.SDienThoai = txtDienthoai.Text;
            if (KhachHang_BUS.ThemKhachHang(kh) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            MessageBox.Show("Đã thêm khách hàng.");
            HienThiDSKhachHangLenDatagrid();

            txtMakhach.ReadOnly = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            canInsert = false;



        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string makh = txtMakhach.Text;
            if (dsgDSKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (makh == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (KhachHang_BUS.XoaKhachHang(makh))
                {
                    MessageBox.Show("Xóa khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại");
                }

                HienThiDSKhachHangLenDatagrid();
            }

        } 

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMakhach.Text == "" || txtTenkhach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã khách hàng có tồn tại không
            if (KhachHang_BUS.TimKhachHangTheoMa(txtMakhach.Text) == null)
            {
                MessageBox.Show("Mã khách hàng không tồn tại!");
                return;
            }
            // Gán dữ liệu vào kiểu KhachHangDTO
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.SMaKhach = txtMakhach.Text;
            kh.STenKhach = txtTenkhach.Text;          
            kh.SDiaChi = txtDiachi.Text;
            kh.SDienThoai = txtDienthoai.Text;

            // Thực hiện cập nhật
            if (KhachHang_BUS.CapNhatKhachHang(kh) == false)
            {
                MessageBox.Show("Không cập nhật được.");
                return;
            }
            HienThiDSKhachHangLenDatagrid();
            MessageBox.Show("Đã cập nhật khách hàng.");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenkhach_Click(object sender, EventArgs e)
        {
            txtTenkhach.Text = "";
        }

        private void txtDiachi_Click(object sender, EventArgs e)
        {
            txtDiachi.Text = "";
        }

        private void txtDienthoai_Click(object sender, EventArgs e)
        {
            txtDienthoai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu ");
        }
    }
}