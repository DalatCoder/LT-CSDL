using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class frmTrungTam : Form
    {
        public frmTrungTam()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
        
        private void Reset()
        {
            this.cboMaHV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgayDangKy.Value = DateTime.Now;
            this.rdNam.Checked = true;
            this.chkTiengAnhA.Checked = false;
            this.chkTiengAnhB.Checked = false;
            this.chkTinHocA.Checked = false;
            this.chkTinHocB.Checked = false;
            this.txtTongTien.Text = "";
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (chkTinHocA.Checked)
                sum += int.Parse(this.lblTienTHA.Text.Split('.')[0]);
            if (chkTinHocB.Checked)
                sum += int.Parse(this.lblTienTHB.Text.Split('.')[0]);
            if (chkTiengAnhA.Checked)
                sum += int.Parse(this.lblTienTAA.Text.Split('.')[0]);
            if (chkTiengAnhB.Checked)
                sum += int.Parse(this.lblTienTAB.Text.Split('.')[0]);

            this.txtTongTien.Text = $"{sum}.000 đồng";
        }
    }
}
