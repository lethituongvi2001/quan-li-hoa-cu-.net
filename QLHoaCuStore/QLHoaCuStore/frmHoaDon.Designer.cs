
namespace GUI
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTenNhanVIen = new System.Windows.Forms.Label();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.dtpNgayBan = new DevExpress.XtraEditors.DateEdit();
            this.cboKhachhang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMahd = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.groupHC = new DevExpress.XtraEditors.GroupControl();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbSlton = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lblThanhtien = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.cboHoacu = new System.Windows.Forms.ComboBox();
            this.txtKhuyenMai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayBan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMahd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupHC)).BeginInit();
            this.groupHC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.zoom_32x32;
            this.btnTim.Location = new System.Drawing.Point(256, 119);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(92, 38);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "TÌM";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.cancel_32x32;
            this.btnThoat.Location = new System.Drawing.Point(12, 107);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 50);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "THOÁT";
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(263, 35);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 50);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "THÊM HC";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnReset
            // 
            this.btnReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.ImageOptions.Image")));
            this.btnReset.Location = new System.Drawing.Point(138, 35);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 50);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "RESET";
            this.btnReset.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(12, 35);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 50);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "THÊM MỚI";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvDSHD);
            this.groupControl2.Location = new System.Drawing.Point(41, 235);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(564, 247);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Danh sách hóa đơn";
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHD.Location = new System.Drawing.Point(2, 22);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHD.Size = new System.Drawing.Size(560, 223);
            this.dgvDSHD.TabIndex = 0;
            this.dgvDSHD.DoubleClick += new System.EventHandler(this.dgvDSHD_DoubleClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbTenKH);
            this.groupControl1.Controls.Add(this.label12);
            this.groupControl1.Controls.Add(this.lbTenNhanVIen);
            this.groupControl1.Controls.Add(this.lblTongtien);
            this.groupControl1.Controls.Add(this.dtpNgayBan);
            this.groupControl1.Controls.Add(this.cboKhachhang);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtMahd);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(41, 9);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(459, 219);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Thông tin sản phẩm";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Location = new System.Drawing.Point(149, 125);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(23, 13);
            this.lbTenKH.TabIndex = 13;
            this.lbTenKH.Text = "ten";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Tên khách hàng:";
            // 
            // lbTenNhanVIen
            // 
            this.lbTenNhanVIen.AutoSize = true;
            this.lbTenNhanVIen.Location = new System.Drawing.Point(307, 94);
            this.lbTenNhanVIen.Name = "lbTenNhanVIen";
            this.lbTenNhanVIen.Size = new System.Drawing.Size(41, 13);
            this.lbTenNhanVIen.TabIndex = 11;
            this.lbTenNhanVIen.Text = "label11";
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Location = new System.Drawing.Point(149, 158);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(25, 13);
            this.lblTongtien.TabIndex = 10;
            this.lblTongtien.Text = "vnd";
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.EditValue = null;
            this.dtpNgayBan.Location = new System.Drawing.Point(322, 42);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayBan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayBan.Size = new System.Drawing.Size(121, 20);
            this.dtpNgayBan.TabIndex = 9;
            // 
            // cboKhachhang
            // 
            this.cboKhachhang.FormattingEnabled = true;
            this.cboKhachhang.Location = new System.Drawing.Point(83, 82);
            this.cboKhachhang.Name = "cboKhachhang";
            this.cboKhachhang.Size = new System.Drawing.Size(121, 21);
            this.cboKhachhang.TabIndex = 8;
            this.cboKhachhang.SelectedIndexChanged += new System.EventHandler(this.cboKhachhang_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhân viên lập :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày bán :";
            // 
            // txtMahd
            // 
            this.txtMahd.Location = new System.Drawing.Point(81, 42);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.Size = new System.Drawing.Size(121, 20);
            this.txtMahd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Khách hàng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn :";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtTimkiem);
            this.groupControl3.Controls.Add(this.btnThem);
            this.groupControl3.Controls.Add(this.btnReset);
            this.groupControl3.Controls.Add(this.btnTim);
            this.groupControl3.Controls.Add(this.btnThoat);
            this.groupControl3.Controls.Add(this.btnHuy);
            this.groupControl3.Location = new System.Drawing.Point(506, 10);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(360, 219);
            this.groupControl3.TabIndex = 7;
            this.groupControl3.Text = "Chức năng";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(12, 179);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(336, 21);
            this.txtTimkiem.TabIndex = 6;
            // 
            // groupHC
            // 
            this.groupHC.Controls.Add(this.label13);
            this.groupHC.Controls.Add(this.label11);
            this.groupHC.Controls.Add(this.lbSlton);
            this.groupHC.Controls.Add(this.lbDonGia);
            this.groupHC.Controls.Add(this.lblThanhtien);
            this.groupHC.Controls.Add(this.numSL);
            this.groupHC.Controls.Add(this.cboHoacu);
            this.groupHC.Controls.Add(this.txtKhuyenMai);
            this.groupHC.Controls.Add(this.label4);
            this.groupHC.Controls.Add(this.label7);
            this.groupHC.Controls.Add(this.label8);
            this.groupHC.Controls.Add(this.label9);
            this.groupHC.Controls.Add(this.label10);
            this.groupHC.Enabled = false;
            this.groupHC.Location = new System.Drawing.Point(872, 10);
            this.groupHC.Name = "groupHC";
            this.groupHC.Size = new System.Drawing.Size(466, 218);
            this.groupHC.TabIndex = 10;
            this.groupHC.Text = "Thông tin sản phẩm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(366, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "VND";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(166, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = " / ";
            // 
            // lbSlton
            // 
            this.lbSlton.AutoSize = true;
            this.lbSlton.Location = new System.Drawing.Point(181, 124);
            this.lbSlton.Name = "lbSlton";
            this.lbSlton.Size = new System.Drawing.Size(41, 13);
            this.lbSlton.TabIndex = 12;
            this.lbSlton.Text = "label11";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(310, 122);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(41, 13);
            this.lbDonGia.TabIndex = 11;
            this.lbDonGia.Text = "label11";
            // 
            // lblThanhtien
            // 
            this.lblThanhtien.AutoSize = true;
            this.lblThanhtien.Location = new System.Drawing.Point(326, 175);
            this.lblThanhtien.Name = "lblThanhtien";
            this.lblThanhtien.Size = new System.Drawing.Size(13, 13);
            this.lblThanhtien.TabIndex = 10;
            this.lblThanhtien.Text = "0";
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(99, 119);
            this.numSL.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numSL.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(61, 21);
            this.numSL.TabIndex = 9;
            this.numSL.ValueChanged += new System.EventHandler(this.numSL_ValueChanged);
            // 
            // cboHoacu
            // 
            this.cboHoacu.FormattingEnabled = true;
            this.cboHoacu.Location = new System.Drawing.Point(99, 60);
            this.cboHoacu.Name = "cboHoacu";
            this.cboHoacu.Size = new System.Drawing.Size(360, 21);
            this.cboHoacu.TabIndex = 8;
            this.cboHoacu.SelectedIndexChanged += new System.EventHandler(this.cboHoacu_SelectedIndexChanged);
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.Location = new System.Drawing.Point(99, 170);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.Size = new System.Drawing.Size(123, 21);
            this.txtKhuyenMai.TabIndex = 3;
            this.txtKhuyenMai.Text = "0";
            this.txtKhuyenMai.TextChanged += new System.EventHandler(this.txtKhuyenMai_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khuyến mãi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thành tiền :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Đơn giá :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Chọn sản phẩm :";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.dgvCTHD);
            this.groupControl5.Location = new System.Drawing.Point(611, 234);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(726, 246);
            this.groupControl5.TabIndex = 11;
            this.groupControl5.Text = "Danh sách hóa đơn";
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTHD.Location = new System.Drawing.Point(2, 22);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.Size = new System.Drawing.Size(722, 222);
            this.dgvCTHD.TabIndex = 0;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 496);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupHC);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "frmHoaDon";
            this.Text = "HÓA ĐƠN";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayBan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMahd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupHC)).EndInit();
            this.groupHC.ResumeLayout(false);
            this.groupHC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgvDSHD;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtMahd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.ComboBox cboKhachhang;
        private DevExpress.XtraEditors.DateEdit dtpNgayBan;
        private DevExpress.XtraEditors.GroupControl groupHC;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.ComboBox cboHoacu;
        private System.Windows.Forms.TextBox txtKhuyenMai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Label lblThanhtien;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTenNhanVIen;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbSlton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTimkiem;
    }
}