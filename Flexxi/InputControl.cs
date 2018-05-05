using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Flexxi
{
    public partial class InputControl : UserControlVorlage
    {
        Image orgImage = null;

        public delegate void LoadImageHandler(InputFile inputFile);
        public event LoadImageHandler LoadImage;

        public delegate void StopNextHandler();
        public event StopNextHandler stopNext;

        public delegate void StopPreviousHandler();
        public event StopPreviousHandler stopPrevious;

        public delegate void PaintInitImageHandler();
        public event PaintInitImageHandler paintInitImage;

        public delegate void ActivateStartHandler(bool active);
        public event ActivateStartHandler activateStart;

        public static List<TreeNode> treeNodes = new List<TreeNode>();

        TreeNode selectedNode = null;

        public static bool loadedInitImage = false;

        public InputControl()
        {
            InitializeComponent();
        }

        public void LoadFiles(string[] files)
        {
            foreach (string file in files)
            {
                FileAttributes attr = File.GetAttributes(file);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    LoadFolder(file);
                    continue;
                }

                string name = Path.GetFileName(file);
                string root = Path.GetDirectoryName(file) + @"\";

                InputFile bild = new InputFile(file, root);
                /*
                if (orgImage == null && bild.IsImage && LoadImage != null)
                {
                    LoadImage(bild);
                }
                */
                TreeNode node = new TreeNode(name);
                node.Tag = bild;
                treeNodes.Add(node);
                TreeViewInput.Nodes.Add(node);
                Select(node);
            }
            
            activateStart(treeNodes.Count > 0 ? true : false);
        }

        public void LoadFolder(string dir)
        {
            string name = Path.GetFileName(dir);
            string root = Path.GetDirectoryName(dir) + @"\";

            InputFile bild = new InputFile(dir, root);

            TreeNode node = new TreeNode(name);
            node.Tag = bild;
            node = GetRecursiveTreeNodeChildren(node, root);
            treeNodes.Add(node);
            TreeViewInput.Nodes.Add(node);
            Select(node);

            activateStart(treeNodes.Count > 0 ? true : false);
        }

        public void LoadClipboardImage(Image image)
        {
            InputFile bild = new InputFile(image);

            TreeNode node = new TreeNode(bild.name);
            node.Tag = bild;
            treeNodes.Add(node);
            TreeViewInput.Nodes.Add(node);
            Select(node);
        }

        private TreeNode GetRecursiveTreeNodeChildren(TreeNode node, string root)
        {
            try
            {
                string path = ((InputFile)node.Tag).path;

                string[] files = Directory.GetFiles(path);
                string[] dirs = Directory.GetDirectories(path);

                foreach (string dir in dirs)
                {
                    string name = Path.GetFileName(dir);

                    InputFile bild = new InputFile(dir, root);

                    TreeNode childNode = new TreeNode(name);
                    childNode.Tag = bild;

                    FileAttributes attr = File.GetAttributes(dir);
                    if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        childNode = GetRecursiveTreeNodeChildren(childNode, root);
                    }

                    treeNodes.Add(childNode);
                    node.Nodes.Add(childNode);
                    Select(childNode);
                }

                foreach (string file in files)
                {
                    /*if (file.EndsWith("*.jpg") ||
                        file.EndsWith("*.jpeg") ||
                        file.EndsWith("*.jpe") ||
                        file.EndsWith("*.jfif") ||
                        file.EndsWith("*.png")
                      )
                    {*/
                    string name = Path.GetFileName(file);

                    InputFile bild = new InputFile(file, root);

                    // Just for testing
                    if (orgImage == null && name == "10394511_10152172498231701_5798889360425472090_n.jpg"  && LoadImage != null)
                    {
                        LoadImage(bild);
                    }

                    TreeNode childNode = new TreeNode(name);
                    childNode.Tag = bild;
                    treeNodes.Add(childNode);
                    node.Nodes.Add(childNode);
                    Select(childNode);
                }
            }
            catch (Exception ex)
            {

            }

            return node;
        }

        private void Select(TreeNode node)
        { 
            if(TreeViewInput.SelectedNode == null)
            {
                TreeViewInput.SelectedNode = node;
            }
        }

        private void TreeViewInput_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedNode = ((TreeView)sender).SelectedNode;

            InputFile bild = (InputFile)((TreeView)sender).SelectedNode.Tag;

            LoadImage(bild);
        }

        public void next()
        {
            if (selectedNode == null) return;
            int actualNodeIndex = treeNodes.IndexOf(selectedNode);
            if (actualNodeIndex > 0 && actualNodeIndex >= treeNodes.Count) return;

            TreeNode next = null;
            TreeNode secondNext = null;
            for (int i = actualNodeIndex + 1; i < treeNodes.Count; i++)
            {
                if (treeNodes.ElementAt(i).Tag != null)
                {
                    if (((InputFile)treeNodes.ElementAt(i).Tag).IsImage && next != null)
                    {
                        secondNext = treeNodes.ElementAt(i);
                        break;
                    }
                    if (((InputFile)treeNodes.ElementAt(i).Tag).IsImage && next == null)
                    {
                        next = treeNodes.ElementAt(i);
                    }
                }
            }

            if (next != null)
            {
                selectedNode = next;
                TreeViewInput.SelectedNode = next;
                TreeViewInput.Focus();
                /*
                InputFile bild = (InputFile)next.Tag;
                LoadImage(bild);
                */
            }
            if (secondNext == null && stopNext != null)
            {
                stopNext();
            }
        }

        public void previous()
        {
            if (selectedNode == null) return;
            int actualNodeIndex = treeNodes.IndexOf(selectedNode);
            if (actualNodeIndex > 0 && actualNodeIndex >= treeNodes.Count) return;

            TreeNode previous = null;
            TreeNode secondPrevious = null;
            for (int i = actualNodeIndex - 1; i >= 0; i--)
            {
                if (treeNodes.ElementAt(i).Tag != null)
                {
                    if (((InputFile)treeNodes.ElementAt(i).Tag).IsImage && previous != null)
                    {
                        secondPrevious = treeNodes.ElementAt(i);
                        break;
                    }
                    if (((InputFile)treeNodes.ElementAt(i).Tag).IsImage && previous == null)
                    {
                        previous = treeNodes.ElementAt(i);
                    }
                }
            }

            if (previous != null)
            {
                selectedNode = previous;
                TreeViewInput.SelectedNode = previous;
                TreeViewInput.Focus();

                InputFile bild = (InputFile)previous.Tag;
                LoadImage(bild);
            }
            if (secondPrevious == null && stopPrevious != null)
            {
                stopPrevious();
            }
        }

        public int GetIndex()
        {
            if (selectedNode == null) return -1;
            return treeNodes.IndexOf(selectedNode);
        }

        public List<InputFile> GetInputFilesList()
        {
            List<InputFile> list = new List<InputFile>();

            foreach (TreeNode node in treeNodes)
            {
                list.Add(((InputFile)node.Tag));
            }

            return list;
        }

        public void activateInput(bool activate)
        {
            InputMenu.Enabled = activate;
        }

        private void dateienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Image files (*.jpg, *.jpeg, *.gif, *.png) | *.jpg; *.jpeg; *.gif; *.png";
            d.Multiselect = true;
            d.Title = "Select Images to add";
            DialogResult rs = d.ShowDialog();

            if (rs == DialogResult.OK)
            {
                LoadFiles(d.FileNames);
            }
        }

        private void ordnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.Description = "Select Folder to add";
            DialogResult rs = f.ShowDialog();

            if (rs == DialogResult.OK)
            {
                LoadFolder(f.SelectedPath);
            }
        }

        bool sizeActivated = false;
        int sizeInitWidth = 0;
        Point sizeInitPos;

        private void PanelSize_MouseDown(object sender, MouseEventArgs e)
        {
            sizeActivated = true;
            sizeInitWidth = this.Width;
            sizeInitPos = Cursor.Position;
        }

        private void PanelSize_MouseMove(object sender, MouseEventArgs e)
        {
            if (sizeActivated)
            {
                int newWidth = sizeInitWidth + Cursor.Position.X - sizeInitPos.X;

                if (newWidth >= this.MinimumSize.Width && newWidth <= this.MaximumSize.Width)
                {
                    this.Width = newWidth;
                }
            }
        }

        private void PanelSize_MouseUp(object sender, MouseEventArgs e)
        {
            sizeActivated = false;
        }

        private void removeSelected_Click(object sender, EventArgs e)
        {
            if (TreeViewInput.SelectedNode != null)
            {
                treeNodes.Remove(TreeViewInput.SelectedNode);
                TreeViewInput.SelectedNode.Remove();

                if (TreeViewInput.Nodes.Count == 0)
                {
                    loadedInitImage = false;
                    paintInitImage();
                }
            }

            activateStart(treeNodes.Count > 0 ? true : false);
        }

        private void removeAll_Click(object sender, EventArgs e)
        {
            TreeViewInput.Nodes.Clear();
            treeNodes.Clear();
            loadedInitImage = false;
            paintInitImage();

            activateStart(treeNodes.Count > 0 ? true : false);
        }

        private String clipboardDoesntContainAnImage = Data.translate("Clipboard doesn't contain an image, make a screenshot to add a image to the clipboard");

        private void clipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Clipboard.ContainsImage())
            {
                LoadClipboardImage(System.Windows.Forms.Clipboard.GetImage());
            }
            else
            {
                MessageBox.Show(clipboardDoesntContainAnImage);
            }
        }
    }
}
