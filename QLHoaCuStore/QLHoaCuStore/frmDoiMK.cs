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
    public partial class frmDoiMK : DevExpress.XtraEditors.XtraForm
    {
        public bool bDangNhap = false;
        public static TaiKhoan_DTO TaiKhoan;
        public frmDoiMK()
        {
            InitializeComponent();
            txtTenTK.Text = frmMain.TaiKhoan.STen;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            string tentk = txtTenTK.Text;
            string matkhaucu = txtMkCu.Text;
            string matkhaumoi = txtMkMoi.Text;
            TaiKhoan = TaiKhoan_BUS.LayNguoiDung(tentk, matkhaucu);
            if ((this.txtTenTK.Text == "") || (this.txtMkCu.Text == "") || (this.txtMkMoi.Text == ""))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            else 
            if((this.txtMkMoi.Text == "")!= (this.txtXacNhanMK.Text == ""))
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp ! ");

            }    
            else
            {


                if (TaiKhoan != null)
                {
                    if (TaiKhoan_BUS.CapNhatNguoiDungBUS(tentk, matkhaumoi))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại");
                    }

                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!", "Thông báo");
                    bDangNhap = false;
                }
            }


           


            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {
           
        }
    }
    }