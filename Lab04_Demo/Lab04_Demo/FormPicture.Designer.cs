namespace Lab04_Demo
{
    partial class frmPicture
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReload = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemReload,
            this.menuItemZoomOut,
            this.menuItemZoomIn,
            this.menuItemEdit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem1.Text = "Image";
            // 
            // menuItemReload
            // 
            this.menuItemReload.Name = "menuItemReload";
            this.menuItemReload.Size = new System.Drawing.Size(202, 22);
            this.menuItemReload.Text = "Reload";
            this.menuItemReload.Click += new System.EventHandler(this.menuItemReload_Click);
            // 
            // menuItemZoomOut
            // 
            this.menuItemZoomOut.Name = "menuItemZoomOut";
            this.menuItemZoomOut.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Up)));
            this.menuItemZoomOut.Size = new System.Drawing.Size(202, 22);
            this.menuItemZoomOut.Text = "Zoom +";
            this.menuItemZoomOut.Click += new System.EventHandler(this.menuItemZoomOut_Click);
            // 
            // menuItemZoomIn
            // 
            this.menuItemZoomIn.Name = "menuItemZoomIn";
            this.menuItemZoomIn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Down)));
            this.menuItemZoomIn.Size = new System.Drawing.Size(202, 22);
            this.menuItemZoomIn.Text = "Zoom -";
            this.menuItemZoomIn.Click += new System.EventHandler(this.menuItemZoomIn_Click);
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.Name = "menuItemEdit";
            this.menuItemEdit.Size = new System.Drawing.Size(202, 22);
            this.menuItemEdit.Text = "Edit";
            this.menuItemEdit.Click += new System.EventHandler(this.menuItemEdit_Click);
            // 
            // pbHinh
            // 
            this.pbHinh.Location = new System.Drawing.Point(0, 24);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(784, 537);
            this.pbHinh.TabIndex = 1;
            this.pbHinh.TabStop = false;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar.Location = new System.Drawing.Point(761, 24);
            this.vScrollBar.Maximum = 1000;
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(23, 537);
            this.vScrollBar.TabIndex = 2;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // hScrollBar
            // 
            this.hScrollBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hScrollBar.Location = new System.Drawing.Point(0, 515);
            this.hScrollBar.Maximum = 1000;
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(761, 24);
            this.hScrollBar.TabIndex = 3;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(761, 22);
            this.statusStrip1.TabIndex = 4;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel1.Text = "Status Strip";
            // 
            // frmPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.hScrollBar);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.pbHinh);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture 0";
            this.Load += new System.EventHandler(this.frmPicture_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem menuItemReload;
        public System.Windows.Forms.ToolStripMenuItem menuItemZoomOut;
        public System.Windows.Forms.ToolStripMenuItem menuItemZoomIn;
        public System.Windows.Forms.ToolStripMenuItem menuItemEdit;
        public System.Windows.Forms.PictureBox pbHinh;
        public System.Windows.Forms.VScrollBar vScrollBar;
        public System.Windows.Forms.HScrollBar hScrollBar;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

