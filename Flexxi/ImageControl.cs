using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Flexxi
{
    public partial class ImageControl : UserControlVorlage
    {
        private InputFile orgInputFile = null;
        public InputFile OrgInputFile
        {
            get
            {
                return orgInputFile;
            }
            set
            {
                orgInputFile = value;
            }
        }
        private Image orgImage = null;
        public Image OrgImage
        {
            get
            {
                return orgImage;
            }
            set
            {
                orgImage = value;
            }
        }
        private Image editImage = null;
        public Image EditImage
        {
            get
            {
                return editImage;
            }
            set
            {
                editImage = value;
            }
        }
        private Image scaledImage = null;
        public Image ScaledImage
        {
            get
            {
                return scaledImage;
            }
            set
            {
                scaledImage = value;
            }
        }
        private string orgImagePath = String.Empty;
        public string OrgImagePath
        {
            get
            {
                return orgImagePath;
            }
            set
            {
                orgImagePath = value;
                OrgImageName = Path.GetFileNameWithoutExtension(value);
                OrgImageExtension = Path.GetExtension(value).Replace(".", "");
            }
        }
        private string orgImageName = String.Empty;
        public string OrgImageName
        {
            get
            {
                return orgImageName;
            }
            set
            {
                orgImageName = value;
                if (orgImageName != "")
                {
                    NameLabel.Text = value + "." + OrgImageExtension;
                }
            }
        }
        private string orgImageExtension = String.Empty;
        public string OrgImageExtension
        {
            get
            {
                return orgImageExtension;
            }
            set
            {
                orgImageExtension = value;
                if (orgImageName != "")
                {
                    NameLabel.Text = OrgImageName + "." + value;
                }
            }
        }

        public delegate void NextHandler();
        public event NextHandler next;

        public delegate void PreviousHandler();
        public event PreviousHandler previous;

        public delegate void TestHandler();
        public event TestHandler test;

        private double scale = 1;

        public ImageControl()
        {
            InitializeComponent();

            pictureBox.Size = FlexxiPanel.Size;
        }

        private void checkBoxScaleProportional_CheckedChanged(object sender, EventArgs e)
        {
            RePaintImage();
        }

        public void LoadImage(InputFile inputFile)
        {
            try
            {
                Image image = (inputFile.image==null ? ImageControl.LoadImageFromFile(inputFile.path) : ((Image)inputFile.image.Clone()));

                if (image != null)
                {
                    OrgInputFile = inputFile;
                    OrgImage = image;
                    OrgImagePath = inputFile.path;
                    EditImage = null;

                    if (test != null)
                    {
                        test();
                    }
                    else
                    {
                        PaintImage(image);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("File is not a Image");
            }
        }

        public static Image LoadImageFromFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            Byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            fs.Close();
            MemoryStream memstream = new MemoryStream(buffer);
            return (Image) new Bitmap(memstream);
        }

        ScrollBar scrollBarVertical = new VScrollBar();
        ScrollBar scrollBarHorizontal = new HScrollBar();

        public void PaintEditImage(Image image)
        {
            EditImage = image;
            RePaintImage();
        }

        public void RePaintImage()
        {
            if (EditImage != null)
            {
                PaintImage(EditImage);
            }
            else
            {
                PaintImage(OrgImage);
            }
        }

        public void PaintImage(Image image)
        {
            if (image == null) return;

            int boxWidth, boxHeight;
            if (checkBoxScaleProportional.Checked)
            {
                if (scale < 0)
                {
                    boxWidth = (int)(image.Width * scale * (-1));
                    boxHeight = (int)(image.Height * scale * (-1));
                }
                else
                {
                    boxWidth = (int)(CalculateSize(image).Width * scale);
                    boxHeight = (int)(CalculateSize(image).Height * scale);
                }
            }
            else
            {
                if (scale < 0)
                {
                    boxWidth = (int)(image.Width * scale * (-1));
                    boxHeight = (int)(image.Height * scale * (-1));
                }
                else
                {
                    boxWidth = (int)(FlexxiPanel.Width * scale);
                    boxHeight = (int)(FlexxiPanel.Height * scale);
                }
            }
            pictureBox.Size = new Size((boxWidth > 0 ? boxWidth : 1), (boxHeight > 0 ? boxHeight : 1));
            scaledImage = ResizeImage(image, pictureBox.Size);

            if (FlexxiPanel.Width >= pictureBox.Width || FlexxiPanel.Height >= pictureBox.Height)
            {
                pictureBox.Left = (FlexxiPanel.Width - pictureBox.Width) / 2;
                pictureBox.Top = (FlexxiPanel.Height - pictureBox.Height) / 2;

                ScrollPanel.Controls.Remove(scrollBarHorizontal);
                scrollBarHorizontal = null;
                ScrollPanel.Controls.Remove(scrollBarVertical);
                scrollBarVertical = null;
            }
            else
            {
                pictureBox.Left = pictureBox.Top = 0;
                if (pictureBox.Width > FlexxiPanel.Width)
                {
                    if (scrollBarHorizontal == null)
                    {
                        scrollBarHorizontal = new HScrollBar();
                    }
                    scrollBarHorizontal.Dock = DockStyle.Bottom;
                    scrollBarHorizontal.Maximum = pictureBox.Width - FlexxiPanel.Width;
                    scrollBarHorizontal.Scroll += (sender, e) => { pictureBox.Left = -scrollBarHorizontal.Value; };
                    ScrollPanel.Controls.Add(scrollBarHorizontal);
                }
                else
                {
                    ScrollPanel.Controls.Remove(scrollBarHorizontal);
                }
                if (pictureBox.Height > FlexxiPanel.Height)
                {
                    if (scrollBarVertical == null)
                    {
                        scrollBarVertical = new VScrollBar();
                    }
                    scrollBarVertical.Dock = DockStyle.Right;
                    scrollBarVertical.Maximum = pictureBox.Height - FlexxiPanel.Height;
                    scrollBarVertical.Scroll += (sender, e) => { pictureBox.Top = -scrollBarVertical.Value; };
                    ScrollPanel.Controls.Add(scrollBarVertical);
                }
                else
                {
                    ScrollPanel.Controls.Remove(scrollBarVertical);
                }
            }

            pictureBox.Image = scaledImage;

            labelScale.Text = Math.Round(scale * 100, 0).ToString() + "%";

            pictureBox.Visible = true;
        }

        private Size CalculateSize(Image image)
        {
            int width, heigth;
            // Bild Hochformat (Bild nicht so breit wie Picturebox)
            if ((double)image.Height / (double)image.Width >= (double)FlexxiPanel.Height / (double)FlexxiPanel.Width)
            {
                heigth = FlexxiPanel.Height;
                width = (int)(((double)image.Width / (double)image.Height) * (double)FlexxiPanel.Height);
            }
            // Bild Breitformat (Bild nicht so hoch wie Picturebox)
            else
            {
                heigth = (int)(((double)image.Height / (double)image.Width) * (double)FlexxiPanel.Width);
                width = FlexxiPanel.Width;
            }
            return new Size(width, heigth);
        }

        private Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void SetScaleMode(object sender, EventArgs e)
        {
            string mode = ((string)((Button)sender).Tag);

            ScaleMode(mode);

            RePaintImage();
        }

        public void ScaleMode(string mode)
        {
            switch (mode)
            {
                case "Fit": scale = 1;
                    buttonSizeFit.BackColor = Color.LightGreen;
                    buttonSizeOriginal.BackColor = SystemColors.Control;
                    break;
                case "Original": scale = -1;
                    buttonSizeOriginal.BackColor = Color.LightGreen;
                    buttonSizeFit.BackColor = SystemColors.Control;
                    break;
                case "-25%": scale *= 0.75; break;
                case "+25%": scale /= 0.75; break;
            }
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            if (previous != null)
            {
                previous();
                ButtonNext.Enabled = true;
            }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (next != null)
            {
                next();
                ButtonPrevious.Enabled = true;
            }
        }

        public void stopPrevious()
        {
            ButtonPrevious.Enabled = false;
        }

        public void stopNext()
        {
            ButtonNext.Enabled = false;
        }

        public void writeNameLabel(string text)
        {
            NameLabel.Text = text;
        }
    }
}
