using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ImageFrame
{
    public partial class SaveControl : UserControl
    {
        public delegate void ActivateHandler(bool activ, object sender);
        public event ActivateHandler activate;

        public delegate void TestHandler();
        public event TestHandler test;
        
        public delegate void HideHandler();
        public event HideHandler hide;

        public delegate InputFile GetInputFileHandler();
        public event GetInputFileHandler getInputFile;

        private string customFolder = null;
        private bool overwrite = true;

        public SaveControl()
        {
            InitializeComponent();
        }

        private string GetOutputOption(InputFile inputFile)
        {
            overwrite = true;

            if (DontSave.Checked)
            {
                return null;
            }
            if (UseOriginalFolder.Checked)
            {
                if (CreateCopy.Checked)
                {
                    overwrite = false;
                }

                return inputFile.root;
            }
            if (CreateSubfolder.Checked)
            {
                string subFolder = SubfolderTextBox.Text;
                if (subFolder.Length <= 0)
                {
                    subFolder = "Resized";
                }
                string path = inputFile.root + subFolder + @"\";
                if (Directory.Exists(path) == false)
                {
                    Directory.CreateDirectory(path);
                }
                return path;
            }
            if (UseCustomFolder.Checked)
            {
                return CustomFolderPath.Text + @"\";
            }
            return null;
        }

        public string GetOutputDir(InputFile inputFile)
        {
            string relativeDir = GetRelativeDir(inputFile);
            string outputDir = GetOutputOption(inputFile);

            if (outputDir == null)
            {
                return null;
            }

            return outputDir + relativeDir;
        }

        private void ButtonPrompt_Click(object sender, EventArgs e)
        {
            if (getInputFile != null)
            {
                InputFile inputFile = getInputFile();

                string root = inputFile.root;
                string path = inputFile.path;
                string relativePath = GetRelativeDir(inputFile);
                
                MessageBox.Show("Root: " + root + Environment.NewLine +
                                "Path: " + path + Environment.NewLine +
                                "Relative: " + relativePath + Environment.NewLine);
            }
        }

        private string GetRelativeDir(InputFile inputFile)
        {
            string root = inputFile.root;
            string path = inputFile.path;
            string filename = Path.GetFileName(path);

            if (root.Substring(root.Length - 1) != "\\")
            {
                root += "\\";
            }

            return path.Substring(root.Length, path.Length - root.Length - filename.Length);
        }

        public void run(Image image, InputFile inputFile, string name, string extension, bool modified)
        {
            if (!modified && UseOriginalFolder.Checked && OverwriteOriginal.Checked)
            {
                return;
            }

            string dir = GetOutputDir(inputFile);
            if (dir == null) return;

            string path = dir + name + "." + extension;

            int i_overwrite = 2;
            while (File.Exists(path) && overwrite == false)
            {
                path = dir + name + "(" + i_overwrite + ")." + extension;
                i_overwrite++;
            }

            try
            {
                
                if (File.Exists(path) && overwrite == true)
                {
                    File.Delete(path);
                }
                
                if (extension.ToUpperInvariant().Equals("JPG") ||
                    extension.ToUpperInvariant().Equals("JPEG"))
                {
                    FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                    
                    image.Save(fs, ImageFormat.Jpeg);

                    fs.Close();
                }
                if (extension.ToUpperInvariant().Equals("GIF"))
                {
                    FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);

                    image.Save(fs, ImageFormat.Gif);

                    fs.Close();
                }
                if (extension.ToUpperInvariant().Equals("PNG"))
                {
                    FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);

                    image.Save(fs, ImageFormat.Png);

                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The image " + Path.GetFileName(inputFile.path) + " couldn't be written to " + path + ". Does this file exists and is open in another program? The File will be skipped. Exception:"+ex.ToString());
            }

        }

        private void SaveOption_Click(object sender, EventArgs e)
        {
            if (activate != null)
            {
                if (((RadioButton)sender) == DontSave)
                {
                    activate(false, this);
                }
                else
                {
                    activate(true, this);
                }
            }

            if (((RadioButton)sender) == UseOriginalFolder)
            {
                PanelUseOriginalFolder.Enabled = true;
            }
            else
            {
                PanelUseOriginalFolder.Enabled = false;
            }

            if (((RadioButton)sender) == CreateSubfolder)
            {
                PanelSubfolder.Enabled = true;
            }
            else
            {
                PanelSubfolder.Enabled = false;
            }

            if (((RadioButton)sender) == UseCustomFolder)
            {
                PanelCustomFolder.Enabled = true;
            }
            else
            {
                PanelCustomFolder.Enabled = false;
            }
        }

        private void CustomFolderBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select a Folder for the modified images.";
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                customFolder = fbd.SelectedPath;
                CustomFolderPath.Text = fbd.SelectedPath;
            }
        }
    }
}
