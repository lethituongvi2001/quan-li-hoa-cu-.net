
namespace GUI
{
    partial class frmHoaCu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaCu));
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvDSHoacu1 = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cboNcc = new System.Windows.Forms.ComboBox();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.btnOpen = new DevExpress.XtraEditors.SimpleButton();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.picAnh = new DevExpress.XtraEditors.PictureEdit();
            this.txtTensp = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDongia = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaso = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoacu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTensp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDongia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.zoom_32x32;
            this.btnTim.Location = new System.Drawing.Point(260, 112);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(92, 38);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "TÌM";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.cancel_32x32;
            this.btnThoat.Location = new System.Drawing.Point(144, 100);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 50);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(147, 31);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 50);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(25, 100);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 50);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(25, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 50);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "THÊM MỚI";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.wizard_32x32;
            this.btnSua.Location = new System.Drawing.Point(260, 31);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 50);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "SỬA";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvDSHoacu1);
            this.groupControl2.Location = new System.Drawing.Point(54, 252);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1122, 287);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Danh sách họa cụ";
            // 
            // dgvDSHoacu1
            // 
            this.dgvDSHoacu1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHoacu1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHoacu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHoacu1.Location = new System.Drawing.Point(2, 22);
            this.dgvDSHoacu1.Name = "dgvDSHoacu1";
            this.dgvDSHoacu1.ReadOnly = true;
            this.dgvDSHoacu1.Size = new System.Drawing.Size(1118, 263);
            this.dgvDSHoacu1.TabIndex = 0;
            this.dgvDSHoacu1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHoacu1_CellClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cboNcc);
            this.groupControl1.Controls.Add(this.cboLoai);
            this.groupControl1.Controls.Add(this.btnOpen);
            this.groupControl1.Controls.Add(this.numSL);
            this.groupControl1.Controls.Add(this.txtGhichu);
            this.groupControl1.Controls.Add(this.picAnh);
            this.groupControl1.Controls.Add(this.txtTensp);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtDongia);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtMaso);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(56, 27);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(684, 219);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông tin sản phẩm";
            // 
            // cboNcc
            // 
            this.cboNcc.FormattingEnabled = true;
            this.cboNcc.Location = new System.Drawing.Point(125, 115);
            this.cboNcc.Name = "cboNcc";
            this.cboNcc.Size = new System.Drawing.Size(121, 21);
            this.cboNcc.TabIndex = 8;
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(250, 31);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(121, 21);
            this.cboLoai.TabIndex = 7;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(377, 31);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(60, 21);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Chọn ảnh";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click_1);
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(388, 74);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(49, 21);
            this.numSL.TabIndex = 4;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(90, 154);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(347, 42);
            this.txtGhichu.TabIndex = 3;
            this.txtGhichu.Click += new System.EventHandler(this.txtGhichu_Click);
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(479, 31);
            this.picAnh.Name = "picAnh";
            this.picAnh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picAnh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picAnh.Size = new System.Drawing.Size(182, 163);
            this.picAnh.TabIndex = 2;
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new System.Drawing.Point(125, 75);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(181, 20);
            this.txtTensp.TabIndex = 1;
            this.txtTensp.Click += new System.EventHandler(this.txtTensp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhà cung cấp :";
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(326, 115);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(111, 20);
            this.txtDongia.TabIndex = 1;
            this.txtDongia.Click += new System.EventHandler(this.txtDongia_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Đơn giá :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ghi chú :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại :";
            // 
            // txtMaso
            // 
            this.txtMaso.Location = new System.Drawing.Point(90, 33);
            this.txtMaso.Name = "txtMaso";
            this.txtMaso.Properties.ReadOnly = true;
            this.txtMaso.Size = new System.Drawing.Size(100, 20);
            this.txtMaso.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên sản phẩm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số :";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtTimKiem);
            this.groupControl3.Controls.Add(this.btnThem);
            this.groupControl3.Controls.Add(this.btnTim);
            this.groupControl3.Controls.Add(this.btnLuu);
            this.groupControl3.Controls.Add(this.btnSua);
            this.groupControl3.Controls.Add(this.btnThoat);
            this.groupControl3.Controls.Add(this.btnXoa);
            this.groupControl3.Location = new System.Drawing.Point(765, 27);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(411, 219);
            this.groupControl3.TabIndex = 7;
            this.groupControl3.Text = "Chức năng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(25, 175);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(327, 20);
            this.txtTimKiem.TabIndex = 6;
            // 
            // frmHoaCu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 549);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.Name = "frmHoaCu";
            this.Text = "HỌA CỤ";
            this.Load += new System.EventHandler(this.frmHoaCu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoacu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTensp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDongia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cboNcc;
        private System.Windows.Forms.ComboBox cboLoai;
        private DevExpress.XtraEditors.SimpleButton btnOpen;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.TextBox txtGhichu;
        private DevExpress.XtraEditors.PictureEdit picAnh;
        private DevExpress.XtraEditors.TextEdit txtTensp;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtDongia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtMaso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSHoacu1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit txtTimKiem;
    }
}