
namespace GUI
{
    partial class frmDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoanhThu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.radChonNgay = new System.Windows.Forms.RadioButton();
            this.radNgayHienTai = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTongDoanhThu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSHD = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 114);
            this.panel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dtpDenNgay);
            this.groupControl1.Controls.Add(this.dtpTuNgay);
            this.groupControl1.Controls.Add(this.btnTim);
            this.groupControl1.Controls.Add(this.radChonNgay);
            this.groupControl1.Controls.Add(this.radNgayHienTai);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Location = new System.Drawing.Point(39, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(630, 87);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tra cứu";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(405, 36);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(116, 21);
            this.dtpDenNgay.TabIndex = 10;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(77, 37);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(118, 21);
            this.dtpTuNgay.TabIndex = 9;
            this.dtpTuNgay.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.ImageOptions.Image")));
            this.btnTim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTim.Location = new System.Drawing.Point(549, 26);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(76, 55);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "TÌM";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // radChonNgay
            // 
            this.radChonNgay.AutoSize = true;
            this.radChonNgay.Location = new System.Drawing.Point(302, 37);
            this.radChonNgay.Name = "radChonNgay";
            this.radChonNgay.Size = new System.Drawing.Size(97, 17);
            this.radChonNgay.TabIndex = 3;
            this.radChonNgay.TabStop = true;
            this.radChonNgay.Text = "Hoặc đến ngày";
            this.radChonNgay.UseVisualStyleBackColor = true;
            this.radChonNgay.CheckedChanged += new System.EventHandler(this.radChonNgay_CheckedChanged);
            // 
            // radNgayHienTai
            // 
            this.radNgayHienTai.AutoSize = true;
            this.radNgayHienTai.Location = new System.Drawing.Point(213, 37);
            this.radNgayHienTai.Name = "radNgayHienTai";
            this.radNgayHienTai.Size = new System.Drawing.Size(83, 17);
            this.radNgayHienTai.TabIndex = 2;
            this.radNgayHienTai.TabStop = true;
            this.radNgayHienTai.Text = "Đến hiện tại";
            this.radNgayHienTai.UseVisualStyleBackColor = true;
            this.radNgayHienTai.CheckedChanged += new System.EventHandler(this.radNgayHienTai_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Từ ngày :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvDoanhThu);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 114);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(717, 262);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Danh sách hóa đơn";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThu.Location = new System.Drawing.Point(2, 22);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhThu.Size = new System.Drawing.Size(713, 238);
            this.dgvDoanhThu.TabIndex = 0;
            this.dgvDoanhThu.DoubleClick += new System.EventHandler(this.dgvDoanhThu_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng thu :";
            // 
            // lbTongDoanhThu
            // 
            this.lbTongDoanhThu.AutoSize = true;
            this.lbTongDoanhThu.Location = new System.Drawing.Point(229, 394);
            this.lbTongDoanhThu.Name = "lbTongDoanhThu";
            this.lbTongDoanhThu.Size = new System.Drawing.Size(35, 13);
            this.lbTongDoanhThu.TabIndex = 3;
            this.lbTongDoanhThu.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng số hóa đơn :";
            // 
            // lbSHD
            // 
            this.lbSHD.AutoSize = true;
            this.lbSHD.Location = new System.Drawing.Point(407, 394);
            this.lbSHD.Name = "lbSHD";
            this.lbSHD.Size = new System.Drawing.Size(35, 13);
            this.lbSHD.TabIndex = 3;
            this.lbSHD.Text = "label2";
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 429);
            this.Controls.Add(this.lbSHD);
            this.Controls.Add(this.lbTongDoanhThu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDoanhThu";
            this.Text = "DOANH THU";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton radChonNgay;
        private System.Windows.Forms.RadioButton radNgayHienTai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTongDoanhThu;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSHD;
    }
}