using System.Windows.Forms;

namespace Lab02_GiaoVien
{
    public partial class frmTBGiaoVien : Form
    {
        public frmTBGiaoVien()
        {
            InitializeComponent();
        }

        public void SetText(string str)
        {
            this.lblThongBao.Text = str;
        }
    }
}
