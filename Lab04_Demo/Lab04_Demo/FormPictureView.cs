using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Lab04_Demo
{
    public partial class frmPictureView : Form
    {
        int count = 0;

        public frmPictureView()
        {
            InitializeComponent();
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            var isOK = openFileDialog1.ShowDialog();
            if (isOK == DialogResult.OK)
            {
                frmPicture frm = new frmPicture(openFileDialog1.FileName);
                frm.MdiParent = this;
                this.menuStrip1.AllowMerge = false;
                count++;
                frm.Text = "Picture - " + count + " - " + openFileDialog1.FileName;
                frm.Show();
            }

            toolStripStatusLabel1.Text = "Tổng số Form con: " + count.ToString();
        }

        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            var isOK = saveFileDialog1.ShowDialog();
            if (isOK == DialogResult.OK)
            {
                frmPicture frm = this.ActiveMdiChild as frmPicture;

                try
                {
                    Image img = frm.pbHinh.Image;
                    img.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                }
                catch
                {
                    MessageBox.Show("Lỗi lưu file!");
                }
            }
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItemStatusStrip_Click(object sender, EventArgs e)
        {
            if (menuItemStatusStrip.Checked) statusStrip1.Visible = true;
            else statusStrip1.Visible = false;
        }

        private void menuItemToolStrip_Click(object sender, EventArgs e)
        {
            if (menuItemToolStrip.Checked) toolStrip1.Visible = true;
            else toolStrip1.Visible = false;
        }

        private void menuItemArrangeIcons_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void menuItemCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void menuItemArrangeVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuItemArrangeHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuItemMaximizeAll_Click(object sender, EventArgs e)
        {
            foreach (var form in MdiChildren)
            {
                form.WindowState = FormWindowState.Maximized;
            }
        }

        private void menuItemMinimize_Click(object sender, EventArgs e)
        {
            foreach (var form in MdiChildren)
            {
                form.WindowState = FormWindowState.Minimized;
            }
        }

        private void toolStripZoomIn_Click(object sender, EventArgs e)
        {
            var currentChildForm = ActiveMdiChild as frmPicture;
            currentChildForm.menuItemZoomOut.PerformClick();
        }

        private void toolStripZoomOut_Click(object sender, EventArgs e)
        {
            var currentChildForm = ActiveMdiChild as frmPicture;
            currentChildForm.menuItemZoomIn.PerformClick();
        }

        private void toolStripPaint_Click(object sender, EventArgs e)
        {
            var currentChildForm = ActiveMdiChild as frmPicture;
            currentChildForm.menuItemEdit.PerformClick();
        }
    }
}
