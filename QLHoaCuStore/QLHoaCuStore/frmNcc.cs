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
    public partial class frmNcc : DevExpress.XtraEditors.XtraForm
    {
        BindingSource NCCList = new BindingSource();
        bool canInsert = false;
        public frmNcc()
        {
            InitializeComponent();
        }

        private void frmNcc_Load(object sender, EventArgs e)
        {
            // List<NCC_DTO> lstNCC = NCC_BUS.LayNCC();

            dgvNcc.DataSource = NCCList;
            HienThiDSNCCLenDatagrid();
            BindingNCC();
           
            dgvNcc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


      
           
        public void BindingNCC()
        {
            txtMancc.DataBindings.Add(new Binding("Text", dgvNcc.DataSource, "SMaNCC", true, DataSourceUpdateMode.Never));
            txtTenncc.DataBindings.Add(new Binding("Text", dgvNcc.DataSource, "STenNCC", true, DataSourceUpdateMode.Never));
            txtDiachi.DataBindings.Add(new Binding("Text", dgvNcc.DataSource, "SDiaChi", true, DataSourceUpdateMode.Never));
            txtDienthoai.DataBindings.Add(new Binding("Text", dgvNcc.DataSource, "SDienThoai", true, DataSourceUpdateMode.Never));
            txtWeb.DataBindings.Add(new Binding("Text", dgvNcc.DataSource, "SWebsite", true, DataSourceUpdateMode.Never));
        }


        private void HienThiDSNCCLenDatagrid()
        {

            List<NCC_DTO> lstNCC = NCC_BUS.LayNCC();
            NCCList.DataSource = lstNCC;
           
            //Header
            dgvNcc.Columns["SMaNCC"].HeaderText = "Mã nhà cung cấp";
            dgvNcc.Columns["STenNCC"].HeaderText = "Tên nhà cung cấp ";

            dgvNcc.Columns["SDiaChi"].HeaderText = "Địa chỉ";
            dgvNcc.Columns["SDienThoai"].HeaderText = "Điện thoại";

           
            dgvNcc.Columns["SWebsite"].HeaderText = "Website";
            dgvNcc.Columns["SAn"].Visible = false;

             dgvNcc.Columns["STenNCC"].Width = 200;
             dgvNcc.Columns["SDiaChi"].Width = 150;

            //  dgvNcc.Columns["SDiaChi"].Width = 300;
            // dgvNcc.Columns["SDienThoai"].Width = 200;
        }

    
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!canInsert)
            {
                txtMancc.ReadOnly = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                canInsert = true;
                return;
            }
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMancc.Text == "" || txtTenncc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                txtMancc.ReadOnly = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                canInsert = false;
                return;
            }
            

            // Kiểm tra mã nhân viên có bị trùng không
            if (NCC_BUS.TimNCCTheoMa(txtMancc.Text) != null)
            {
                MessageBox.Show("Mã nhà cung cấp đã tồn tại! Vui lòng chọn mã khác.");
                txtMancc.ReadOnly = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                canInsert = false;
                
                return;
            }
            //gán dữ liệu
            NCC_DTO nc = new NCC_DTO();
            nc.SMaNCC = txtMancc.Text;
            nc.STenNCC = txtTenncc.Text;
            nc.SDiaChi = txtDiachi.Text;
            nc.SDienThoai = txtDienthoai.Text;
            
            nc.SWebsite = txtWeb.Text;
         
            if (NCC_BUS.ThemNCC(nc) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            MessageBox.Show("Đã thêm nhà cung cấp.");
            HienThiDSNCCLenDatagrid();
            txtMancc.ReadOnly = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            canInsert = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (frmMain.TaiKhoan.IQuyen == 1)
            {
                string manc = txtMancc.Text;
            if (dgvNcc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (manc == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (NCC_BUS.XoaNCC(manc))
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công");
                }
                else
                {
                    MessageBox.Show("Xóa nhà cung cấp  thất bại");
                }

                HienThiDSNCCLenDatagrid();
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
            if (txtMancc.Text == "" || txtTenncc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã khách hàng có tồn tại không
            if (NCC_BUS.TimNCCTheoMa(txtMancc.Text) == null)
            {
                MessageBox.Show("Mã nhà cung cấp không tồn tại!");
                return;
            }
            // Gán dữ liệu vào kiểu NCC_DTO
           
            NCC_DTO nc = new NCC_DTO();
            nc.SMaNCC = txtMancc.Text;
            nc.STenNCC = txtTenncc.Text;
            nc.SDiaChi = txtDiachi.Text;
            nc.SDienThoai = txtDienthoai.Text;
          
            nc.SWebsite = txtWeb.Text;

            // Thực hiện cập nhật

            if (NCC_BUS.CapNhatNCC(nc) == false)
            {
                MessageBox.Show("Không cập nhật được.");
                return;
            }
            
            MessageBox.Show("Đã cập nhật nhà cung cấp.");
            HienThiDSNCCLenDatagrid();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNcc_Click(object sender, EventArgs e)
        {
           
         
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu nhà cung cấp");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void txtTenncc_Click(object sender, EventArgs e)
        {
            txtTenncc.Text = "";
        }

        private void txtDiachi_Click(object sender, EventArgs e)
        {
            txtDiachi.Text = "";
        }

        private void txtDienthoai_Click(object sender, EventArgs e)
        {
            txtDienthoai.Text = "";
        }

        private void txtWeb_Click(object sender, EventArgs e)
        {
            txtWeb.Text = "";
        }
    }
}