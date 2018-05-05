using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Xml.Serialization;

namespace Flexxi
{
    public partial class SaveControl : EditControlVorlage
    {
        public delegate void ActivateHandler(bool activ, object sender);
        public event ActivateHandler activate;

        public delegate void TestHandler();
        public event TestHandler test;
        
        public delegate void HideHandler();
        public event HideHandler hide;

        public delegate InputFile GetInputFileHandler();
        public event GetInputFileHandler getInputFile;

        public delegate int GetQualityHandler();
        public event GetQualityHandler getQuality;

        public delegate bool SkipErrorHandler();
        public event SkipErrorHandler skipErrorActivated;

        public delegate byte AlertHandler(string file, byte fehler);
        public event AlertHandler alert;

        private string customFolder = null;
        private bool overwrite = true;

        public SaveControl()
        {
            InitializeComponent();

            PanelSubfolder.Enabled = CreateSubfolder.Checked;
            PanelCustomFolder.Enabled = UseCustomFolder.Checked;
            CustomFolderPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\";

            SaveControl_SizeChanged(null, null);

            
        }

        private void save_Click(object sender, EventArgs e)
        {
            speichern(this);
        }

        private void speichern(SaveControl caller)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SaveControl));
                using (TextWriter writer = new StreamWriter(@"savecontrol.xml"))
                {
                    serializer.Serialize(writer, caller);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private string GetOutputOption(InputFile inputFile)
        {
            if (DontSave.Checked)
            {
                return null;
            }
            if (UseOriginalFolder.Checked)
            {
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

            //MessageBox.Show("Output:"+relativeDir+" "+outputDir);

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

            return (DirCopyActivated() ? path.Substring(root.Length, path.Length - root.Length - filename.Length) : "");
        }

        public void run(Image image, InputFile inputFile, string name, string extension, bool modified)
        {
            if (!modified && UseOriginalFolder.Checked)
            {
                if(alert(inputFile.path, Fehler.WarningOverwriteDestination) == Fehler.Yes) return;
            }

            string dir = GetOutputDir(inputFile);
            if (dir == null) return;

            string path = dir + name + "." + extension;

            if (File.Exists(path))
            {
                if (alert(inputFile.path, Fehler.WarningOverwriteDestination) == Fehler.No)
                {
                    int i_overwrite = 2;
                    while (File.Exists(path))
                    {
                        path = dir + name + "(" + i_overwrite + ")." + extension;
                        i_overwrite++;
                    }
                }
            }

            if (File.Exists(Path.GetDirectoryName(path)) == false)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }

            try
            {
                // Komprimierung:

                //Ein ImageCodecInfo-Objekt für den JPEG-Codec anlegen
                ImageCodecInfo jpegCodec = null;

                //Den Qualitätsarameter konfigurieren (Qualitätsfaktor in
                //Prozent angeben)
                EncoderParameter qualitaetsParameter = new EncoderParameter(
                            System.Drawing.Imaging.Encoder.Quality, (getQuality!=null ? getQuality() : 100));

                //Alle im System verfügbaren Codecs auflisten
                ImageCodecInfo[] alleCodecs = ImageCodecInfo.GetImageEncoders();

                EncoderParameters codecParameter = new EncoderParameters(1);
                codecParameter.Param[0] = qualitaetsParameter;

                //Den JPEG-Codec unter allen Codecs finden und dem
                //Codec-Info-Objekt zuweisen
                for (int i = 0; i < alleCodecs.Length; i++)
                {
                    if (alleCodecs[i].MimeType == "image/jpeg" &&
                        (extension.ToUpperInvariant().Equals("JPG") || extension.ToUpperInvariant().Equals("JPEG")))
                    {
                        jpegCodec = alleCodecs[i];
                        break;
                    }
                    if (alleCodecs[i].MimeType == "image/gif" && extension.ToUpperInvariant().Equals("GIF"))
                    {
                        jpegCodec = alleCodecs[i];
                        break;
                    }
                    if (alleCodecs[i].MimeType == "image/png" && extension.ToUpperInvariant().Equals("PNG"))
                    {
                        jpegCodec = alleCodecs[i];
                        break;
                    }
                }

                if (File.Exists(path) && overwrite == true)
                {
                    File.Delete(path);
                }

                image.Save(path, jpegCodec, codecParameter);
                
                /*
                //Old code:
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
                */
            }
            catch (Exception ex)
            {
                if (skipErrorActivated == null || skipErrorActivated() == false)
                {
                    MessageBox.Show(theImage+" "+ Path.GetFileName(inputFile.path) + " "+couldntBeWrittenTo+" " + path + ". "+
                        isThisFileOpenInAnotherProgram+" "+ theFileWillBeSkipped+".\n\nException:" + ex.ToString());
                }
            }

        }

        private String theImage = Data.translate("The Image");
        private String couldntBeWrittenTo = Data.translate("couldn't be written to");
        private String isThisFileOpenInAnotherProgram = Data.translate("Is this file open in another program?");
        private String theFileWillBeSkipped = Data.translate("The File will be skipped");
        private String selectFolderForModifiedImages = Data.translate("Select a Folder for the modified images");
        private String textboxCantBeEmpty = Data.translate("This textbox can't be empty");
        private String pathIsNotValid = Data.translate("Path is not valid");

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
            fbd.Description = selectFolderForModifiedImages+".";
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                customFolder = fbd.SelectedPath;
                CustomFolderPath.Text = fbd.SelectedPath;
            }
        }

        public bool OtherFilesCopyActivated()
        {
            return OtherFilesCopy.Checked;
        }

        public bool DirCopyActivated()
        {
            return DirectoriesCopy.Checked;
        }

        public bool IsDontSaveActiv()
        {
            return DontSave.Checked;
        }

        private void SubfolderTextBox_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                MessageBox.Show(textboxCantBeEmpty);
                ((TextBox)sender).Focus();
            }
        }

        private void PanelCustomFolder_Leave(object sender, EventArgs e)
        {
            if (CustomFolderPath.Text == "")
            {
                MessageBox.Show(textboxCantBeEmpty);
                CustomFolderPath.Focus();
            }
            else
            {
                if (!Directory.Exists(CustomFolderPath.Text))
                {
                    MessageBox.Show(pathIsNotValid);
                    CustomFolderPath.Focus();
                }
            }
        }

        private void SaveControl_SizeChanged(object sender, EventArgs e)
        {
            sizeChanged();
        }
    }
}
