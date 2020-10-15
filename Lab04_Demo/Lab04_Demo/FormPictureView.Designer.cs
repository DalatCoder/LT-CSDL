namespace Lab04_Demo
{
    partial class frmPictureView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPictureView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStatusStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemArrangeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemArrangeHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemArrangeVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMaximizeAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripPaint = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuView,
            this.menuLayout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew,
            this.menuItemSaveAs,
            this.menuItemExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.Size = new System.Drawing.Size(180, 22);
            this.menuItemNew.Text = "New";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // menuItemSaveAs
            // 
            this.menuItemSaveAs.Name = "menuItemSaveAs";
            this.menuItemSaveAs.Size = new System.Drawing.Size(180, 22);
            this.menuItemSaveAs.Text = "Save As";
            this.menuItemSaveAs.Click += new System.EventHandler(this.menuItemSaveAs_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(180, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemStatusStrip,
            this.menuItemToolStrip});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 20);
            this.menuView.Text = "View";
            // 
            // menuItemStatusStrip
            // 
            this.menuItemStatusStrip.Checked = true;
            this.menuItemStatusStrip.CheckOnClick = true;
            this.menuItemStatusStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemStatusStrip.Name = "menuItemStatusStrip";
            this.menuItemStatusStrip.Size = new System.Drawing.Size(180, 22);
            this.menuItemStatusStrip.Text = "StatusStrip";
            this.menuItemStatusStrip.Click += new System.EventHandler(this.menuItemStatusStrip_Click);
            // 
            // menuItemToolStrip
            // 
            this.menuItemToolStrip.Checked = true;
            this.menuItemToolStrip.CheckOnClick = true;
            this.menuItemToolStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemToolStrip.Name = "menuItemToolStrip";
            this.menuItemToolStrip.Size = new System.Drawing.Size(180, 22);
            this.menuItemToolStrip.Text = "ToolStrip";
            this.menuItemToolStrip.Click += new System.EventHandler(this.menuItemToolStrip_Click);
            // 
            // menuLayout
            // 
            this.menuLayout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemArrangeIcons,
            this.menuItemCascade,
            this.menuItemArrangeHorizontal,
            this.menuItemArrangeVertical,
            this.menuItemMaximizeAll,
            this.menuItemMinimize});
            this.menuLayout.Name = "menuLayout";
            this.menuLayout.Size = new System.Drawing.Size(55, 20);
            this.menuLayout.Text = "Layout";
            // 
            // menuItemArrangeIcons
            // 
            this.menuItemArrangeIcons.Name = "menuItemArrangeIcons";
            this.menuItemArrangeIcons.Size = new System.Drawing.Size(180, 22);
            this.menuItemArrangeIcons.Text = "Arrange&Icons";
            this.menuItemArrangeIcons.Click += new System.EventHandler(this.menuItemArrangeIcons_Click);
            // 
            // menuItemCascade
            // 
            this.menuItemCascade.Name = "menuItemCascade";
            this.menuItemCascade.Size = new System.Drawing.Size(180, 22);
            this.menuItemCascade.Text = "&Cascade";
            this.menuItemCascade.Click += new System.EventHandler(this.menuItemCascade_Click);
            // 
            // menuItemArrangeHorizontal
            // 
            this.menuItemArrangeHorizontal.Name = "menuItemArrangeHorizontal";
            this.menuItemArrangeHorizontal.Size = new System.Drawing.Size(180, 22);
            this.menuItemArrangeHorizontal.Text = "Arrange &Horizontal";
            this.menuItemArrangeHorizontal.Click += new System.EventHandler(this.menuItemArrangeHorizontal_Click);
            // 
            // menuItemArrangeVertical
            // 
            this.menuItemArrangeVertical.Name = "menuItemArrangeVertical";
            this.menuItemArrangeVertical.Size = new System.Drawing.Size(180, 22);
            this.menuItemArrangeVertical.Text = "Arrange &Vertical";
            this.menuItemArrangeVertical.Click += new System.EventHandler(this.menuItemArrangeVertical_Click);
            // 
            // menuItemMaximizeAll
            // 
            this.menuItemMaximizeAll.Name = "menuItemMaximizeAll";
            this.menuItemMaximizeAll.Size = new System.Drawing.Size(180, 22);
            this.menuItemMaximizeAll.Text = "Ma&ximize All";
            this.menuItemMaximizeAll.Click += new System.EventHandler(this.menuItemMaximizeAll_Click);
            // 
            // menuItemMinimize
            // 
            this.menuItemMinimize.Name = "menuItemMinimize";
            this.menuItemMinimize.Size = new System.Drawing.Size(180, 22);
            this.menuItemMinimize.Text = "Mi&nimize All";
            this.menuItemMinimize.Click += new System.EventHandler(this.menuItemMinimize_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripZoomIn,
            this.toolStripZoomOut,
            this.toolStripPaint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripZoomIn
            // 
            this.toolStripZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripZoomIn.Image")));
            this.toolStripZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripZoomIn.Name = "toolStripZoomIn";
            this.toolStripZoomIn.Size = new System.Drawing.Size(23, 22);
            this.toolStripZoomIn.Text = "toolStripButton1";
            this.toolStripZoomIn.Click += new System.EventHandler(this.toolStripZoomIn_Click);
            // 
            // toolStripZoomOut
            // 
            this.toolStripZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripZoomOut.Image")));
            this.toolStripZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripZoomOut.Name = "toolStripZoomOut";
            this.toolStripZoomOut.Size = new System.Drawing.Size(23, 22);
            this.toolStripZoomOut.Text = "toolStripButton2";
            this.toolStripZoomOut.Click += new System.EventHandler(this.toolStripZoomOut_Click);
            // 
            // toolStripPaint
            // 
            this.toolStripPaint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPaint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPaint.Image")));
            this.toolStripPaint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPaint.Name = "toolStripPaint";
            this.toolStripPaint.Size = new System.Drawing.Size(23, 22);
            this.toolStripPaint.Text = "toolStripButton3";
            this.toolStripPaint.Click += new System.EventHandler(this.toolStripPaint_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(113, 17);
            this.toolStripStatusLabel1.Text = "Tổng số form con: 0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image|*.bmp;*.jpg;*.jpeg;*.png";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Image|*.bmp;*.jpg;*.jpeg;*.png";
            // 
            // frmPictureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPictureView";
            this.Text = "FormPictureView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuItemStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemToolStrip;
        private System.Windows.Forms.ToolStripMenuItem menuLayout;
        private System.Windows.Forms.ToolStripMenuItem menuItemArrangeIcons;
        private System.Windows.Forms.ToolStripMenuItem menuItemCascade;
        private System.Windows.Forms.ToolStripMenuItem menuItemArrangeHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuItemArrangeVertical;
        private System.Windows.Forms.ToolStripMenuItem menuItemMaximizeAll;
        private System.Windows.Forms.ToolStripMenuItem menuItemMinimize;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripZoomIn;
        private System.Windows.Forms.ToolStripButton toolStripZoomOut;
        private System.Windows.Forms.ToolStripButton toolStripPaint;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}