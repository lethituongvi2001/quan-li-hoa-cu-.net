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
using BUS;
using DTO;

namespace GUI
{
   

    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
      


        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            string tentk = txtTentk.Text;
            string matkhau = txtMatkhau.Text;
            frmMain.TaiKhoan = TaiKhoan_BUS.LayNguoiDung(tentk, matkhau);
            if ((this.txtTentk.Text == "") || (this.txtMatkhau.Text == ""))
                MessageBox.Show("Vui lòng nhập tên người dùng hoặc mật khẩu");
            else
            {

                if (frmMain.TaiKhoan != null)
                {
                    MessageBox.Show("Dang nhap thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain.bDangNhap = true;
                    frmMain.quyenQuantri = frmMain.TaiKhoan.IQuyen == 1 ? true : false;
                    frmMain f = new frmMain();
                    this.Hide();
                    f.ShowDialog();
                    
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Ten tai khoan hoac mat khau khong chinh xac!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain.bDangNhap = false;
                }
            }
            }
          



                /*   TaiKhoan = TaiKhoan_BUS.LayNguoiDung(tentk, matkhau);
                   if (TaiKhoan != null)
                       bDangNhap = true;

               else
               {
                   bDangNhap = false;
               }
                   bool login(string username, string password)
                   {

                       return TaiKhoanDAO.Instance.login(username, password);
                   }
                   string username = txtUsername.Text;
                   string password = txtPassword.Text;
                   if (login(username, password))
                   {
                       TaiKhoan loginacc = TaiKhoanDAO.Instance.GetAccByUsername(username);
                       fManager f = new fManager(loginacc);
                       this.Hide();
                       f.ShowDialog();
                       this.Show();
                   }
                   else
                       MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo");*/
            
        

       
        private void btnOutgame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}