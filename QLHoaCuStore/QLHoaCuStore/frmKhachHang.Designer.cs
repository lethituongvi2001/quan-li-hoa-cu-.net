
namespace GUI
{
    partial class frmKhachHang
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
            this.TopLayout = new DevExpress.XtraLayout.LayoutControl();
            this.txtDienthoai = new DevExpress.XtraEditors.TextEdit();
            this.txtTenkhach = new System.Windows.Forms.TextBox();
            this.txtDiachi = new DevExpress.XtraEditors.TextEdit();
            this.txtMakhach = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblMakhach = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblDiachi = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblTenkhach = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblDienthoai = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dsgDSKhachHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TopLayout)).BeginInit();
            this.TopLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienthoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakhach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMakhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDiachi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTenkhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDienthoai)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsgDSKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // TopLayout
            // 
            this.TopLayout.Controls.Add(this.txtDienthoai);
            this.TopLayout.Controls.Add(this.txtTenkhach);
            this.TopLayout.Controls.Add(this.txtDiachi);
            this.TopLayout.Controls.Add(this.txtMakhach);
            this.TopLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopLayout.Location = new System.Drawing.Point(0, 0);
            this.TopLayout.Name = "TopLayout";
            this.TopLayout.Root = this.Root;
            this.TopLayout.Size = new System.Drawing.Size(1226, 80);
            this.TopLayout.TabIndex = 0;
            this.TopLayout.Text = "layoutControl1";
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(693, 36);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(521, 20);
            this.txtDienthoai.StyleController = this.TopLayout;
            this.txtDienthoai.TabIndex = 7;
            this.txtDienthoai.Click += new System.EventHandler(this.txtDienthoai_Click);
            // 
            // txtTenkhach
            // 
            this.txtTenkhach.Location = new System.Drawing.Point(693, 12);
            this.txtTenkhach.Name = "txtTenkhach";
            this.txtTenkhach.Size = new System.Drawing.Size(521, 20);
            this.txtTenkhach.TabIndex = 6;
            this.txtTenkhach.Click += new System.EventHandler(this.txtTenkhach_Click);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(91, 36);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(519, 20);
            this.txtDiachi.StyleController = this.TopLayout;
            this.txtDiachi.TabIndex = 5;
            this.txtDiachi.Click += new System.EventHandler(this.txtDiachi_Click);
            // 
            // txtMakhach
            // 
            this.txtMakhach.Location = new System.Drawing.Point(91, 12);
            this.txtMakhach.Name = "txtMakhach";
            this.txtMakhach.Properties.ReadOnly = true;
            this.txtMakhach.Size = new System.Drawing.Size(519, 20);
            this.txtMakhach.StyleController = this.TopLayout;
            this.txtMakhach.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblMakhach,
            this.emptySpaceItem1,
            this.lblDiachi,
            this.lblTenkhach,
            this.lblDienthoai});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1226, 80);
            this.Root.TextVisible = false;
            // 
            // lblMakhach
            // 
            this.lblMakhach.Control = this.txtMakhach;
            this.lblMakhach.Location = new System.Drawing.Point(0, 0);
            this.lblMakhach.Name = "lblMakhach";
            this.lblMakhach.Size = new System.Drawing.Size(602, 24);
            this.lblMakhach.Text = "Mã khách hàng";
            this.lblMakhach.TextSize = new System.Drawing.Size(76, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1206, 12);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblDiachi
            // 
            this.lblDiachi.Control = this.txtDiachi;
            this.lblDiachi.Location = new System.Drawing.Point(0, 24);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(602, 24);
            this.lblDiachi.Text = "Địa chỉ";
            this.lblDiachi.TextSize = new System.Drawing.Size(76, 13);
            // 
            // lblTenkhach
            // 
            this.lblTenkhach.Control = this.txtTenkhach;
            this.lblTenkhach.Location = new System.Drawing.Point(602, 0);
            this.lblTenkhach.Name = "lblTenkhach";
            this.lblTenkhach.Size = new System.Drawing.Size(604, 24);
            this.lblTenkhach.Text = "Tên khách hàng";
            this.lblTenkhach.TextSize = new System.Drawing.Size(76, 13);
            // 
            // lblDienthoai
            // 
            this.lblDienthoai.Control = this.txtDienthoai;
            this.lblDienthoai.Location = new System.Drawing.Point(602, 24);
            this.lblDienthoai.Name = "lblDienthoai";
            this.lblDienthoai.Size = new System.Drawing.Size(604, 24);
            this.lblDienthoai.Text = "Điện thoại";
            this.lblDienthoai.TextSize = new System.Drawing.Size(76, 13);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 108);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(333, 22);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 73);
            this.panel1.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.clear_32x32;
            this.btnXoa.Location = new System.Drawing.Point(211, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 55);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThoat.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.close_32x32;
            this.btnThoat.Location = new System.Drawing.Point(1101, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 55);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.export_32x32;
            this.btnLuu.Location = new System.Drawing.Point(594, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 55);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.ide_32x32;
            this.btnSua.Location = new System.Drawing.Point(400, 6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 55);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "SỬA";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = global::QLHoaCuStore.Properties.Resources.add_32x321;
            this.btnThem.Location = new System.Drawing.Point(12, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 55);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM MỚI";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dsgDSKhachHang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1226, 502);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // dsgDSKhachHang
            // 
            this.dsgDSKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsgDSKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsgDSKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.dsgDSKhachHang.Location = new System.Drawing.Point(3, 17);
            this.dsgDSKhachHang.Name = "dsgDSKhachHang";
            this.dsgDSKhachHang.ReadOnly = true;
            this.dsgDSKhachHang.Size = new System.Drawing.Size(1220, 300);
            this.dsgDSKhachHang.TabIndex = 0;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 676);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopLayout);
            this.Name = "frmKhachHang";
            this.Text = "KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopLayout)).EndInit();
            this.TopLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDienthoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakhach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMakhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDiachi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTenkhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDienthoai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsgDSKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl TopLayout;
        private DevExpress.XtraEditors.TextEdit txtDienthoai;
        private System.Windows.Forms.TextBox txtTenkhach;
        private DevExpress.XtraEditors.TextEdit txtDiachi;
        private DevExpress.XtraEditors.TextEdit txtMakhach;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lblMakhach;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lblDiachi;
        private DevExpress.XtraLayout.LayoutControlItem lblTenkhach;
        private DevExpress.XtraLayout.LayoutControlItem lblDienthoai;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dsgDSKhachHang;
    }
}