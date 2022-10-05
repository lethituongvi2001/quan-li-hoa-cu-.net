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
using System.Windows.Media.Imaging;
using System.IO;

namespace GUI
{
    public partial class frmHoaCu : DevExpress.XtraEditors.XtraForm
    {
        int rowIndex = -1;
        public frmHoaCu()
        {
            InitializeComponent();
        }
        BindingSource HangList = new BindingSource();
        bool canInsert = false;

        public void BindingHang()
        {

            txtMaso.DataBindings.Add(new Binding("Text", dgvDSHoacu1.DataSource, "SMahc", true, DataSourceUpdateMode.Never));
            txtTensp.DataBindings.Add(new Binding("Text", dgvDSHoacu1.DataSource, "STenhc", true, DataSourceUpdateMode.Never));

            numSL.DataBindings.Add(new Binding("Text", dgvDSHoacu1.DataSource, "SSoLuong", true, DataSourceUpdateMode.Never));
            txtDongia.DataBindings.Add(new Binding("Text", dgvDSHoacu1.DataSource, "SDonGia", true, DataSourceUpdateMode.Never));

            cboLoai.DataBindings.Add(new Binding("Text", dgvDSHoacu1.DataSource, "SMaLoai", true, DataSourceUpdateMode.Never));
            cboNcc.DataBindings.Add(new Binding("Text", dgvDSHoacu1.DataSource, "SMaNcc", true, DataSourceUpdateMode.Never));
            txtGhichu.DataBindings.Add(new Binding("Text", dgvDSHoacu1.DataSource, "SGhiChu", true, DataSourceUpdateMode.Never));
        }

        private void HienThiDSHangLenDatagrid()
        {
            List<Hang_DTO> lstHang = Hang_BUS.LayHang();
            HangList.DataSource = lstHang;
           

            //sMahc, sTenhc, sSoLuong, sDonGia, sMaLoai, sMaNcc, sGhiChu, sAnh
            dgvDSHoacu1.Columns["SMahc"].HeaderText = "Mã Họa Cụ";
            dgvDSHoacu1.Columns["STenhc"].HeaderText = "Tên Họa Cụ ";
            dgvDSHoacu1.Columns["SSoLuong"].HeaderText = "Số lượng";
            dgvDSHoacu1.Columns["SDonGia"].HeaderText = "Đơn Giá";
            dgvDSHoacu1.Columns["SGhiChu"].HeaderText = "Ghi chú";
            dgvDSHoacu1.Columns["SMaLoai"].HeaderText = "Loại";
            dgvDSHoacu1.Columns["SMaNcc"].HeaderText = "Nhà cung cấp";
            dgvDSHoacu1.Columns["SAn"].Visible = false;




        }

        private void HienThiNCCLenCombobox()
        {
              List<NCC_DTO> lstNCC = NCC_BUS.LayNCC();
              cboNcc.DataSource = lstNCC;
              cboNcc.DisplayMember = "STenNCC";
              cboNcc.ValueMember = "SMaNCC";
        }

        private void HienThiLoaiLenCombobox()
        {
            List<Loai_DTO> lstLoai = Loai_BUS.LayLoai();
            cboLoai.DataSource = lstLoai;
            cboLoai.DisplayMember = "STenLoai";
            cboLoai.ValueMember = "SMaLoai";
        }
        private void btnOpen_Click(object sender, EventArgs e)
      {
          /* OpenFileDialog openfiledialog = new OpenFileDialog();
           openfiledialog.Filter = "Chọn ảnh";
           openfiledialog.Filter = "Image Files(*.gif; *.jpg; *jpeg; *bmp; *.wmf; *.png)|*.gif; *.jpg; *jpeg; *bmp; *.wmf; *.png";
           if(openfiledialog.ShowDialog()== DialogResult.OK)
           {
              // openFile.FilterIndex = 1;
              // openFile.RestoreDirectory = true;
              // if (openFile.ShowDialog() == DialogResult.OK)
               //{
               //    textBox1.Text = openFile.FileName;
            //  }
               //picAnh.ImageLocation = openfiledialog.FileName;*/
            // open file dialog   
           // OpenFileDialog open = new OpenFileDialog();
            // image filters  
           // open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
           // if (open.ShowDialog() == DialogResult.OK)
           // {
                // display image in picture box  
               // picAnh.Image = new Bitmap(open.FileName);
                // image file path  
                // textBox1.Text = open.FileName;
           // }
        }

       
    

        private void frmHoaCu_Load(object sender, EventArgs e)
        {
            List<Hang_DTO> lstHang = Hang_BUS.LayHang();
            dgvDSHoacu1.DataSource = HangList;
            HienThiDSHangLenDatagrid();
            HienThiNCCLenCombobox();
            HienThiLoaiLenCombobox();
            BindingHang();
            dgvDSHoacu1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaso.Text == "" || txtTensp.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã khách hàng có tồn tại không
            if (Hang_BUS.TimHangTheoMa(txtMaso.Text) == null)
            {
                MessageBox.Show("Mã Hàng không tồn tại!");
                return;
            }
            // Gán dữ liệu vào kiểu KhachHangDTO
            Hang_DTO hc = new Hang_DTO();
            
            hc.SMahc = txtMaso.Text;
            hc.STenhc = txtTensp.Text;
            hc.SSoLuong = int.Parse(numSL.Text);
            hc.SDonGia = int.Parse(txtDongia.Text);
            hc.SGhiChu = txtGhichu.Text;
            hc.SMaLoai = cboLoai.SelectedValue.ToString();
            hc.SMaNcc = cboNcc.SelectedValue.ToString();


            // Thực hiện cập nhật
            if (Hang_BUS.CapNhatHang(hc) == false)
            {
                MessageBox.Show("Không cập nhật được.");
                return;
            }
            
            MessageBox.Show("Đã cập nhật hàng.");
            HienThiDSHangLenDatagrid();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!canInsert)
            {
                txtMaso.ReadOnly = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                canInsert = true;
                return;
            }
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaso.Text == "" || txtTensp.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                txtMaso.ReadOnly = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                canInsert = false;
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không

            // Kiểm tra mã nhân viên có bị trùng không
            if (Hang_BUS.TimHangTheoMa(txtMaso.Text) != null)
            {
                MessageBox.Show("Mã này đã tồn tại! Vui lòng chọn mã khác.");
                txtMaso.ReadOnly = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                canInsert = false;
                return;
            }
            //sMahc, sTenhc, sSoLuong, sDonGia, sGhiChu, sMaLoai, sMaNcc
            // Gán dữ liệu vào kiểu KhachHangDTO
            Hang_DTO ha = new Hang_DTO();
            ha.SMahc = txtMaso.Text;
            ha.STenhc = txtTensp.Text;                     
            ha.SSoLuong = int.Parse(numSL.Text);
            ha.SDonGia = int.Parse(txtDongia.Text);
            ha.SGhiChu = txtGhichu.Text;
            ha.SMaLoai = (cboLoai.SelectedItem as Loai_DTO).SMaLoai;
            ha.SMaNcc = (cboNcc.SelectedItem as NCC_DTO).SMaNCC;

            if (Hang_BUS.ThemHang(ha) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            
            MessageBox.Show("Đã thêm họa cụ.");
            Hang_BUS.TaoAnh(ha.SMahc);
            HienThiDSHangLenDatagrid();
            txtMaso.ReadOnly = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            canInsert = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (frmMain.TaiKhoan.IQuyen == 1)
            {
                string malo = txtMaso.Text;
            if (dgvDSHoacu1.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (malo == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (Hang_BUS.XoaHang(malo))
                {
                    MessageBox.Show("Xóa hàng thành công");
                }
                else
                {
                    MessageBox.Show("Xóa hàng thất bại");
                }

                HienThiDSHangLenDatagrid();
            }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xóa !");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            if(rowIndex < 0 || rowIndex >= dgvDSHoacu1.RowCount)
            {
                MessageBox.Show("Chưa chọn họa cụ kìa!");
                return;
            }
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = openfiledialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif";
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openfiledialog.SafeFileName;
                picAnh.Image = Image.FromFile(openfiledialog.FileName); //new BitmapImage(new Uri(openfiledialog.FileName));

                string ext = Path.GetExtension(openfiledialog.FileName);

                //cop[y anh vai folder Anh
                fileName = "\\Images\\" + openfiledialog.SafeFileName;

                string solutionPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
                
                try
                {
                    File.Copy(openfiledialog.FileName, solutionPath + fileName);
                }
                catch 
                {
                    fileName = "\\Images\\" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ext;
                    File.Copy(openfiledialog.FileName, solutionPath + fileName);
                }
                if (Hang_BUS.ThemAnh(fileName, txtMaso.Text))
                {
                    MessageBox.Show("Đã thêm ảnh cho họa cụ");
                    HienThiDSHangLenDatagrid();
                }
                
            }
        }

        private void dgvDSHoacu1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;

            DataGridViewRow dr = dgvDSHoacu1.Rows[rowIndex];

            string cellvalue = (sender as DataGridView).SelectedCells[0].Value.ToString();

            string fileAnh = Hang_BUS.LayAnh(cellvalue);

            if (String.IsNullOrEmpty(fileAnh))
            {
                picAnh.Image = null;
                return;
            }

            //get path
            string solutionPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));

            if(!File.Exists(solutionPath + fileAnh))
            {
                return;
            }
            //gan hinh do
            picAnh.Image = Image.FromFile(solutionPath + fileAnh); //new BitmapImage(new Uri(openfiledialog.FileName));
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            List<Hang_DTO> ds = Hang_BUS.LayHang();
            List<Hang_DTO> kq = (from hd in ds
                                     where hd.SMahc.Contains(txtTimKiem.Text)
                                     select hd).ToList();
            HangList.DataSource = kq;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu !");
        }

        private void txtGhichu_Click(object sender, EventArgs e)
        {
            txtGhichu.Text = "";
        }

        private void txtTensp_Click(object sender, EventArgs e)
        {
            txtTensp.Text = "";
        }

        private void txtDongia_Click(object sender, EventArgs e)
        {
            txtDongia.Text = "";
        }
    }
}