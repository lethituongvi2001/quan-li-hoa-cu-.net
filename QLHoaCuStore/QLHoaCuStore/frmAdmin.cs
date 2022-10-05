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
using DTO;
using BUS;

namespace GUI
{
    public partial class frmAdmin : DevExpress.XtraEditors.XtraForm
    {
        public frmAdmin()
        {
            InitializeComponent();
            load();
        }
        BindingSource NguoiDungList = new BindingSource();
        //int rowIndex;
        private bool flag = true;

        void load()
        {
            dtgvNguoiDung.DataSource = NguoiDungList;
            HienThiNguoiDung();
            AddBinding();
            PhanQuyen();

            dtgvNguoiDung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void PhanQuyen()
        {
            if (flag == true)
            {
                flag = false;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
               
                btnDoiQuyen.Enabled = true;
                btnflag.Text = "+";
            }
        }

        public void HienThiNguoiDung()
        {
            List<TaiKhoan_DTO> lstNguoiDung = TaiKhoan_BUS.DanhSachNguoiDungBUS();
            NguoiDungList.DataSource = lstNguoiDung;

            //Header
            dtgvNguoiDung.Columns["STen"].HeaderText = "Username";
            dtgvNguoiDung.Columns["SMatKhau"].HeaderText = "Password";
            dtgvNguoiDung.Columns["IQuyen"].HeaderText = "Quyền";
            dtgvNguoiDung.Columns["SMatKhau"].Width = 126;
        }

        public void AddBinding()
        {
            txtUser.DataBindings.Add(new Binding("Text", dtgvNguoiDung.DataSource, "STen"));
            txtPassword.DataBindings.Add(new Binding("Text", dtgvNguoiDung.DataSource, "SMatKhau"));
            lblQuyen.DataBindings.Add(new Binding("Text", dtgvNguoiDung.DataSource, "IQuyen"));
        }
  
        

        private void btnflag_Click_1(object sender, EventArgs e)
        {
            if (flag == false)
            {
                flag = true;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
               
                btnDoiQuyen.Enabled = false;
                txtUser.Enabled = true;
                txtPassword.Enabled = true;
                lblQuyen.Enabled = true;
                txtManv.Enabled = true;
                btnflag.Text = "-";
            }
            else
            {
                flag = false;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                
                btnDoiQuyen.Enabled = true;
                txtUser.Enabled = false;
                txtPassword.Enabled = false;
                lblQuyen.Enabled = false;
                txtManv.Enabled = false;
                btnflag.Text = "+";
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string tennd = txtUser.Text;
            string matkhau = txtPassword.Text;
            string manvnd = txtManv.Text;
            int quyen = 2;
            List<TaiKhoan_DTO> NguoiDung = TaiKhoan_BUS.KiemTraID(tennd);
            if (NguoiDung != null)
            {
                MessageBox.Show("Tài khoản bị trùng");
            }
            else
            {
                if (TaiKhoan_BUS.ThemNguoiDungBUS(tennd, matkhau, quyen, manvnd))
                {
                    MessageBox.Show("Thêm người dùng thành công");
                    HienThiNguoiDung();
                }
                else
                {
                    MessageBox.Show("Thêm người dùng thất bại");
                }
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string ten = txtUser.Text;
            if (TaiKhoan_BUS.XoaNguoiDungBUS(ten))
            {
                MessageBox.Show("Xóa nhân viên thành công");
                HienThiNguoiDung();
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            string id = txtUser.Text;
            string manvnd = txtManv.Text;
            if (TaiKhoan_BUS.CapLaiMatKhauBUS(id, manvnd))
            {
                MessageBox.Show("Mật khẩu đã được cấp lại là 123");
            }
            else
            {
                MessageBox.Show("Cấp lại mật khẩu thất bại");
            }
        }

        private void btnDoiQuyen_Click_1(object sender, EventArgs e)
        {
            int quyen = int.Parse(lblQuyen.Text);
            string id = txtUser.Text;
            //Thay đổi giá trị quyền
            int thaydoi = 3 - quyen;
            if (TaiKhoan_BUS.ThayDoiQuyenND_DAO(id, thaydoi))
            {
                if (thaydoi == 1)
                {
                    MessageBox.Show("Đã được cấp làm quản trị viên");
                }
                else
                {
                    MessageBox.Show("Nang quyen that bai");
                }
            }
            HienThiNguoiDung();

        }

        private void dtgvNguoiDung_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int quyen = int.Parse(lblQuyen.Text);

            if (quyen == 1)
            {
                btnDoiQuyen.Text = "Hạ quyền";
            }
            else
            {
                btnDoiQuyen.Text = "Nâng quyền";
            }
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
        }

      

        private void txtManv_Click(object sender, EventArgs e)
        {
            txtManv.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }
    }
}