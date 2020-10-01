using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_GiaoVien
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            string lienhe = "http://it.dlu.edu.vn/e-learning/Default.aspx";
            this.linklbLienHe.Links.Add(0, lienhe.Length, lienhe);
            this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
        }
    }
}
