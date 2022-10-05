using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static bool bDangNhap = false;
        public static bool quyenQuantri = false; //1 la quan tri, 2 la nhanvien

        public static TaiKhoan_DTO TaiKhoan;


        public frmMain()
        {

            InitializeComponent();

        }





        public void GDMacDinh()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themmes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themmes.LookAndFeel.SkinName = "Valentine";//Nhập tên giao diện muốn hiển thị

        }
        void MoForm(Type typeForm)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            GDMacDinh();
            HienThiMenu();

        }

        private void btnNcc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MoForm(typeof(frmNcc));
        }

        private void btnNhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MoForm(typeof(frmNhanVien));
        }

        private void btnHoadon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MoForm(typeof(frmHoaDon));

        }

        private void btnKhachhang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MoForm(typeof(frmKhachHang));

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMK mk = new frmDoiMK();
            mk.Show();

        }

        private void btnDangxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất khỏi hệ thống ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            { 
                 
                this.Close();

            }
  
            
        }

        private void barAdmin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MoForm(typeof(frmAdmin));

        }

        private void btnHoacu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MoForm(typeof(frmHoaCu));
        }

        private void BtnLoaihoacu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MoForm(typeof(frmPhanLoai));
        }


        private void btnDoanhthu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MoForm(typeof(frmDoanhThu));
        }


        private void btnTonkho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MoForm(typeof(frmThongKe));
        }

        private void HienThiMenu()
        {
            barAdmin.Enabled = quyenQuantri;
            barNhanvien.Enabled = quyenQuantri;
            sttTTTaiKhoan.Text = "Xin chào  " + TaiKhoan.STen + "! ";
            sttTTThoiGian.Text = "Thời điểm đăng nhập: " + DateTime.Now;
            #region comment
            //    if (bDangNhap == true)
            //    {
            //            quyen = TaiKhoan.IQuyen;
            //            sttTTTaiKhoan.Text = "Xin chào  " + TaiKhoan.STen + "! ";
            //            sttTTThoiGian.Text = "Thời điểm đăng nhập: " + DateTime.Now;
            //        }
            //        switch (quyen) // hiển thị menu phù hợp với quyền 
            //        {
            //            case 1: // quản trị
            //                barAdmin.Enabled = true;
            //                barNhanvien.Enabled = true;
            //                barDoiMK.Enabled = true;
            //                barNcc.Enabled = true;
            //                barKhachhang.Enabled = true;
            //                barHoacu.Enabled = true;
            //                barLoaihoacu.Enabled = true;
            //                barHoadon.Enabled = true;
            //                barDoanhthu.Enabled = true;
            //                barTonkho.Enabled = true;
            //                break;
            //            case 2: // nhân viên
            //                barAdmin.Enabled = false;
            //                barNhanvien.Enabled = false;
            //                barDoiMK.Enabled = true;
            //                barNcc.Enabled = true;
            //                barKhachhang.Enabled = true;
            //                barHoacu.Enabled = true;
            //                barLoaihoacu.Enabled = true;
            //                barHoadon.Enabled = true;
            //                barDoanhthu.Enabled = true;
            //                barTonkho.Enabled = true;
            //                break;
            //            default:
            //                break;

            //        }
            //    }


            //    else
            //    {
            //        sttTTTaiKhoan.Text = "Chưa đăng nhập";
            //        sttTTThoiGian.Text = "";
            //    }

            //}
            #endregion
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Help.ShowHelp(this, "huongdansudung1.chm");
        }
    }
}   
    

