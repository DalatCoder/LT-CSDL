using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.Windows.Forms;

namespace Lab04_Demo_File_Explorer
{
    public partial class frmExplorer : Form
    {
        public frmExplorer()
        {
            InitializeComponent();
        }

        private void frmExplorer_Load(object sender, EventArgs e)
        {
            TreeNode tnode = new TreeNode();
            tnode.Text = "Desktop";
            tnode.Tag = SpecialDirectories.Desktop;
            tnode.ImageKey = "Desktop";
            tnode.SelectedImageKey = "Desktop";

            treeViewFolder.Nodes.Add(tnode);
        }

        private string ImageKeyDriver(DriveInfo drive)
        {
            string type = "";

            switch (drive.DriveType)
            {
                case DriveType.Removable:
                    type = "Removable";
                    break;
                case DriveType.Fixed:
                    type = "HDD";
                    break;
                case DriveType.Network:
                    type = "Network";
                    break;
                case DriveType.CDRom:
                    type = "CD";
                    break;
                default:
                    type = "HDD";
                    break;
            }

            return type;
        }

        private void LoadDrive(TreeNode tn)
        {
            TreeNode tnode = new TreeNode();

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                tnode = new TreeNode();
                tnode.Text = drive.Name;
                tnode.Tag = drive.ToString();
                tnode.ImageKey = ImageKeyDriver(drive);
                tnode.SelectedImageKey = ImageKeyDriver(drive);
                tn.Nodes.Add(tnode);
            }
        }

        private void InsertFolder(TreeNode tnParent)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(tnParent.Tag.ToString());
                foreach (DirectoryInfo drive in dir.GetDirectories())
                {
                    TreeNode tnChild = new TreeNode();
                    tnChild.Text = drive.Name;
                    tnChild.ImageKey = "Folder";
                    tnChild.SelectedImageKey = "Folder";
                    tnChild.Tag = drive.FullName;
                    tnParent.Nodes.Add(tnChild);
                }
            }
            catch { }
        }

        private void InsertFileTreeView(TreeNode tnParent)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(tnParent.Tag.ToString());

                foreach (FileInfo file in dir.GetFiles())
                {
                    TreeNode tnChild = new TreeNode();
                    tnChild.Text = file.Name;
                    tnChild.ImageKey = "File";
                    tnChild.SelectedImageKey = "File";
                    tnParent.Nodes.Add(tnChild);
                }

            }
            catch { }
        }

        private void InsertFileListView(TreeNode tnParent)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(tnParent.Tag.ToString());

                listViewFile.Items.Clear();
                foreach (FileInfo file in dir.GetFiles())
                {
                    var item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.LastWriteTime.ToShortDateString());
                    item.SubItems.Add(file.Extension);
                    item.SubItems.Add((file.Length / 1024).ToString());

                    listViewFile.Items.Add(item);
                }

                toolStripStatusLabel1.Text = "Tong so Files: " + listViewFile.Items.Count;
            }
            catch { }
        }

        private void InsertChildParent(TreeNode tnParent)
        {
            if (tnParent == null) return;

            if (tnParent.Level == 0)
            {
                TreeNode tnMyDocuments = new TreeNode();
                tnMyDocuments.Text = "My Documents";
                tnMyDocuments.ImageKey = "My Documents";
                tnMyDocuments.SelectedImageKey = "My Documents";
                tnMyDocuments.Tag = SpecialDirectories.MyDocuments;

                TreeNode tnMyComputer = new TreeNode();
                tnMyDocuments.Text = "My Computer";
                tnMyComputer.ImageKey = "My Computer";
                tnMyComputer.SelectedImageKey = "My Computer";
                tnMyComputer.Tag = "My Computer";

                tnParent.Nodes.Insert(0, tnMyDocuments);
                tnParent.Nodes.Insert(1, tnMyComputer);
            }
            else
            {
                if (tnParent.Nodes.Count == 0)
                {
                    if (tnParent.Text == "My Computer")
                    {
                        LoadDrive(tnParent);
                        return;
                    }
                    InsertFolder(tnParent);
                }
                InsertFileTreeView(tnParent);
                InsertFileListView(tnParent);
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void treeViewFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tnParent = e.Node;
            InsertChildParent(tnParent);
        }
    }
}
