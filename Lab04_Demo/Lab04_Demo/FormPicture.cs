using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Lab04_Demo
{
    public partial class frmPicture : Form
    {
        Point p = new Point();
        bool ctrlKeyDown;

        public frmPicture()
        {
            InitializeComponent();
        }

        public frmPicture(string name) :  this()
        {
            pbHinh.ImageLocation = name;
            toolStripStatusLabel1.Text = name;
        }

        private void frmPicture_Load(object sender, EventArgs e)
        {
            p = pbHinh.Location;
            ctrlKeyDown = false;

            this.MouseWheel += FrmPicture_MouseWheel;
            this.KeyDown += FrmPicture_KeyDown;
            this.KeyUp += FrmPicture_KeyUp;

            pbHinh.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FrmPicture_KeyUp(object sender, KeyEventArgs e)
        {
            this.ctrlKeyDown = e.Control;
        }

        private void FrmPicture_KeyDown(object sender, KeyEventArgs e)
        {
            this.ctrlKeyDown = e.Control;
        }

        private void FrmPicture_MouseWheel(object sender, MouseEventArgs e)
        {
            bool isGoUp = e.Delta > 0 ? true : false;

            // Zoom the image
            if (ctrlKeyDown)
            {
                int hStep = (int)(this.pbHinh.Image.Width * 0.02);
                int vStep = (int)(this.pbHinh.Image.Height * 0.02);

                if (isGoUp)
                {
                    this.pbHinh.Width += hStep;
                    this.pbHinh.Height += vStep;
                }
                else
                {
                    this.pbHinh.Width -= hStep;
                    this.pbHinh.Height -= vStep;
                }
            }
            // Move up or down
            else
            {
                if (isGoUp && this.vScrollBar.Value > 5)
                {
                    this.vScrollBar.Value -= 5;
                }
                if (!isGoUp && this.vScrollBar.Value < this.vScrollBar.Maximum - 5)
                {
                    this.vScrollBar.Value += 5;
                }

                pbHinh.Location = new Point(p.X, p.Y - this.vScrollBar.Value);
            }
        }

        private void menuItemReload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Images File|*.jpg;*.png;*.jpeg|All Files|*.*";

            var isOK = openFile.ShowDialog();

            if (isOK == DialogResult.OK)
            {
                string title = openFile.FileName;
                pbHinh.Image = Image.FromFile(openFile.FileName);
                this.Text = openFile.FileName;
            }
        }

        public void menuItemZoomOut_Click(object sender, EventArgs e)
        {
            pbHinh.Width += 50;
            pbHinh.Height += 50;
        }

        public void menuItemZoomIn_Click(object sender, EventArgs e)
        {
            pbHinh.Width -= 50;
            pbHinh.Height -= 50;
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            pbHinh.Location = new Point(p.X, p.Y - e.NewValue);
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            pbHinh.Location = new Point(p.X - e.NewValue, p.Y);
        }

        public void menuItemEdit_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint", pbHinh.ImageLocation);
        }
    }
}
