
namespace GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnDoimk = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barDoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoigiaodien = new DevExpress.XtraBars.BarButtonItem();
            this.barNcc = new DevExpress.XtraBars.BarButtonItem();
            this.barNhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.barKhachhang = new DevExpress.XtraBars.BarButtonItem();
            this.barHoacu = new DevExpress.XtraBars.BarButtonItem();
            this.barLoaihoacu = new DevExpress.XtraBars.BarButtonItem();
            this.barHoadon = new DevExpress.XtraBars.BarButtonItem();
            this.btnChitiethoadon = new DevExpress.XtraBars.BarButtonItem();
            this.btnTimkiemhd = new DevExpress.XtraBars.BarButtonItem();
            this.barDoanhthu = new DevExpress.XtraBars.BarButtonItem();
            this.barTonkho = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barAdmin = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.rbpHethong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpgSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpDanhmuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpHoadon = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sttTTTaiKhoan = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttTTThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnDoimk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDoimk
            // 
            this.btnDoimk.ExpandCollapseItem.Id = 0;
            this.btnDoimk.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnDoimk.ExpandCollapseItem,
            this.btnDoimk.SearchEditItem,
            this.barDoiMK,
            this.btnDangxuat,
            this.btnDoigiaodien,
            this.barNcc,
            this.barNhanvien,
            this.barKhachhang,
            this.barHoacu,
            this.barLoaihoacu,
            this.barHoadon,
            this.btnChitiethoadon,
            this.btnTimkiemhd,
            this.barDoanhthu,
            this.barTonkho,
            this.skinRibbonGalleryBarItem1,
            this.barAdmin,
            this.barButtonItem1});
            this.btnDoimk.Location = new System.Drawing.Point(0, 0);
            this.btnDoimk.MaxItemId = 23;
            this.btnDoimk.Name = "btnDoimk";
            this.btnDoimk.PageHeaderItemLinks.Add(this.barButtonItem1);
            this.btnDoimk.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpHethong,
            this.rbpDanhmuc,
            this.rbpHoadon,
            this.rbpBaoCao});
            this.btnDoimk.Size = new System.Drawing.Size(1026, 150);
            // 
            // barDoiMK
            // 
            this.barDoiMK.Caption = "Đổi mật khẩu";
            this.barDoiMK.Id = 1;
            this.barDoiMK.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.editname_16x16;
            this.barDoiMK.ImageOptions.LargeImage = global::QLHoaCuStore.Properties.Resources.editname_32x32;
            this.barDoiMK.Name = "barDoiMK";
            this.barDoiMK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Caption = "Đăng xuất";
            this.btnDangxuat.Id = 2;
            this.btnDangxuat.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.assignto_16x16;
            this.btnDangxuat.ImageOptions.LargeImage = global::QLHoaCuStore.Properties.Resources.assignto_32x32;
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangxuat_ItemClick);
            // 
            // btnDoigiaodien
            // 
            this.btnDoigiaodien.Caption = "Đổi giao diện =>";
            this.btnDoigiaodien.Id = 3;
            this.btnDoigiaodien.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.colors_16x161;
            this.btnDoigiaodien.ImageOptions.LargeImage = global::QLHoaCuStore.Properties.Resources.colors_32x321;
            this.btnDoigiaodien.Name = "btnDoigiaodien";
            // 
            // barNcc
            // 
            this.barNcc.Caption = "Nhà cung cấp";
            this.barNcc.Id = 4;
            this.barNcc.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.usergroup_16x16;
            this.barNcc.ImageOptions.LargeImage = global::QLHoaCuStore.Properties.Resources.usergroup_32x32;
            this.barNcc.Name = "barNcc";
            this.barNcc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNcc_ItemClick);
            // 
            // barNhanvien
            // 
            this.barNhanvien.Caption = "Nhân viên";
            this.barNhanvien.Id = 5;
            this.barNhanvien.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.user_16x16;
            this.barNhanvien.ImageOptions.LargeImage = global::QLHoaCuStore.Properties.Resources.user_32x32;
            this.barNhanvien.Name = "barNhanvien";
            this.barNhanvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanvien_ItemClick);
            // 
            // barKhachhang
            // 
            this.barKhachhang.Caption = "Khách hàng";
            this.barKhachhang.Id = 6;
            this.barKhachhang.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.employee_16x16;
            this.barKhachhang.ImageOptions.LargeImage = global::QLHoaCuStore.Properties.Resources.employee_32x32;
            this.barKhachhang.Name = "barKhachhang";
            this.barKhachhang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhachhang_ItemClick);
            // 
            // barHoacu
            // 
            this.barHoacu.Caption = "Họa Cụ";
            this.barHoacu.Id = 7;
            this.barHoacu.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.colormixer_16x16;
            this.barHoacu.ImageOptions.LargeImage = global::QLHoaCuStore.Properties.Resources.colormixer_32x32;
            this.barHoacu.Name = "barHoacu";
            this.barHoacu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoacu_ItemClick);
            // 
            // barLoaihoacu
            // 
            this.barLoaihoacu.Caption = "Loại họa cụ";
            this.barLoaihoacu.Id = 8;
            this.barLoaihoacu.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.palette_16x16;
            this.barLoaihoacu.ImageOptions.LargeImage = global::QLHoaCuStore.Properties.Resources.palette_32x32;
            this.barLoaihoacu.Name = "barLoaihoacu";
            this.barLoaihoacu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnLoaihoacu_ItemClick);
            // 
            // barHoadon
            // 
            this.barHoadon.Caption = "Hóa đơn bán";
            this.barHoadon.Id = 9;
            this.barHoadon.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.breaks_oddpage_16x16;
            this.barHoadon.ImageOptions.LargeImage = global::QLHoaCuStore.Properties.Resources.breaks_oddpage_32x32;
            this.barHoadon.Name = "barHoadon";
            this.barHoadon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoadon_ItemClick);
            // 
            // btnChitiethoadon
            // 
            this.btnChitiethoadon.Caption = "Chi tiết hóa đơn bán";
            this.btnChitiethoadon.Id = 10;
            this.btnChitiethoadon.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.pageorientation_16x16;
            this.btnChitiethoadon.ImageOptions.LargeImage = global::QLHoaCuStore.Properties.Resources.pageorientation_32x32;
            this.btnChitiethoadon.Name = "btnChitiethoadon";
            // 
            // btnTimkiemhd
            // 
            this.btnTimkiemhd.Caption = "Tìm kiếm hóa đơn";
            this.btnTimkiemhd.Id = 11;
            this.btnTimkiemhd.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.marqueezoom_16x16;
            this.btnTimkiemhd.ImageOptions.LargeImage = global::QLHoaCuStore.Properties.Resources.marqueezoom_32x32;
            this.btnTimkiemhd.Name = "btnTimkiemhd";
            // 
            // barDoanhthu
            // 
            this.barDoanhthu.Caption = "Doanh thu";
            this.barDoanhthu.Id = 12;
            this.barDoanhthu.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.bosale_16x16;
            this.barDoanhthu.ImageOptions.LargeImage = global::QLHoaCuStore.Properties.Resources.bosale_32x32;
            this.barDoanhthu.Name = "barDoanhthu";
            this.barDoanhthu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoanhthu_ItemClick);
            // 
            // barTonkho
            // 
            this.barTonkho.Caption = "Tồn kho";
            this.barTonkho.Id = 13;
            this.barTonkho.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.boproductgroup_16x16;
            this.barTonkho.ImageOptions.LargeImage = global::QLHoaCuStore.Properties.Resources.boproductgroup_32x32;
            this.barTonkho.Name = "barTonkho";
            this.barTonkho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTonkho_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 14;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // barAdmin
            // 
            this.barAdmin.Caption = "Quản trị";
            this.barAdmin.Id = 15;
            this.barAdmin.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.bouser_16x161;
            this.barAdmin.ImageOptions.LargeImage = global::QLHoaCuStore.Properties.Resources.bouser_32x321;
            this.barAdmin.Name = "barAdmin";
            this.barAdmin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barAdmin_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 22;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // rbpHethong
            // 
            this.rbpHethong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpgSystem});
            this.rbpHethong.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.operatingsystem_16x16;
            this.rbpHethong.Name = "rbpHethong";
            this.rbpHethong.Text = "Hệ Thống";
            // 
            // rbpgSystem
            // 
            this.rbpgSystem.ItemLinks.Add(this.barAdmin);
            this.rbpgSystem.ItemLinks.Add(this.barDoiMK);
            this.rbpgSystem.ItemLinks.Add(this.btnDangxuat);
            this.rbpgSystem.ItemLinks.Add(this.btnDoigiaodien);
            this.rbpgSystem.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.rbpgSystem.Name = "rbpgSystem";
            this.rbpgSystem.Text = "System";
            // 
            // rbpDanhmuc
            // 
            this.rbpDanhmuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbpDanhmuc.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.bar2_16x16;
            this.rbpDanhmuc.Name = "rbpDanhmuc";
            this.rbpDanhmuc.Text = "Danh Mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barNcc);
            this.ribbonPageGroup2.ItemLinks.Add(this.barNhanvien);
            this.ribbonPageGroup2.ItemLinks.Add(this.barKhachhang);
            this.ribbonPageGroup2.ItemLinks.Add(this.barHoacu);
            this.ribbonPageGroup2.ItemLinks.Add(this.barLoaihoacu);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh Mục";
            // 
            // rbpHoadon
            // 
            this.rbpHoadon.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbpHoadon.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.article_16x16;
            this.rbpHoadon.Name = "rbpHoadon";
            this.rbpHoadon.Text = "Hóa Đơn";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barHoadon);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Hóa Đơn";
            // 
            // rbpBaoCao
            // 
            this.rbpBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rbpBaoCao.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.boreport_16x16;
            this.rbpBaoCao.Name = "rbpBaoCao";
            this.rbpBaoCao.Text = "Báo Cáo";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barDoanhthu);
            this.ribbonPageGroup4.ItemLinks.Add(this.barTonkho);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Báo Cáo";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.btnDoimk;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttTTTaiKhoan,
            this.sttTTThoiGian});
            this.statusStrip1.Location = new System.Drawing.Point(0, 463);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1026, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sttTTTaiKhoan
            // 
            this.sttTTTaiKhoan.Name = "sttTTTaiKhoan";
            this.sttTTTaiKhoan.Size = new System.Drawing.Size(77, 17);
            this.sttTTTaiKhoan.Text = "Tên tài khoản";
            // 
            // sttTTThoiGian
            // 
            this.sttTTThoiGian.Name = "sttTTThoiGian";
            this.sttTTThoiGian.Size = new System.Drawing.Size(116, 17);
            this.sttTTThoiGian.Text = "Thời gian đăng nhập";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 485);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDoimk);
            this.IconOptions.Image = global::QLHoaCuStore.Properties.Resources.th;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.btnDoimk;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÍ CỬA HÀNG BÁN HỌA CỤ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDoimk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl btnDoimk;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpHethong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgSystem;
        private DevExpress.XtraBars.BarButtonItem barDoiMK;
        private DevExpress.XtraBars.BarButtonItem btnDangxuat;
        private DevExpress.XtraBars.BarButtonItem btnDoigiaodien;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpDanhmuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpHoadon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barNcc;
        private DevExpress.XtraBars.BarButtonItem barNhanvien;
        private DevExpress.XtraBars.BarButtonItem barKhachhang;
        private DevExpress.XtraBars.BarButtonItem barHoacu;
        private DevExpress.XtraBars.BarButtonItem barLoaihoacu;
        private DevExpress.XtraBars.BarButtonItem barHoadon;
        private DevExpress.XtraBars.BarButtonItem btnChitiethoadon;
        private DevExpress.XtraBars.BarButtonItem btnTimkiemhd;
        private DevExpress.XtraBars.BarButtonItem barDoanhthu;
        private DevExpress.XtraBars.BarButtonItem barTonkho;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem barAdmin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sttTTTaiKhoan;
        private System.Windows.Forms.ToolStripStatusLabel sttTTThoiGian;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}

