using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHoaCuStore
{
    public partial class frmChiTiet : Form
    {
        public frmChiTiet(string mahd)
        {
            InitializeComponent();

            dtgvChiTiet.DataSource = ChiTietHD_BUS.LayChiTiet(mahd);
            this.Text = "Thông tin hóa đơn số " + mahd;
        }

        private void frmChiTiet_Load(object sender, EventArgs e)
        {

        }
    }
}
