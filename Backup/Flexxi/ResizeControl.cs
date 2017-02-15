using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ImageFrame
{
    public partial class ResizeControl : UserControl
    {
        public delegate void ActivateHandler(bool activ, object sender);
        public event ActivateHandler activate;

        public delegate Image GetImageHandler();
        public event GetImageHandler getImage;

        public delegate void SetImageHandler(Image image);
        public event SetImageHandler setImage;

        public delegate void TestHandler();
        public event TestHandler test;
        
        public delegate void HideHandler();
        public event HideHandler hide;

        public ResizeControl()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (hide != null)
            {
                hide();
            }
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            if (activate != null)
            {
                activate(true, this);
            }
            if (hide != null)
            {
                hide();
            }
        }

        private void ButtonTest_Click(object sender, EventArgs e)
        {
            TestAll();
        }

        private void TestAll()
        {
            if (test != null)
            {
                test();
            }
        }

        public void Test()
        {
            if (getImage == null) return;
            Image image = getImage();
            if (image == null) return;
            Image imageResized = run(image);
            if (imageResized == null) return;
            setImage(imageResized);
        }

        public bool modified = false;

        public Image run(Image image)
        {
            modified = false;

            if (image == null) return null;

            int maxWidth = 0;
            int maxHeight = 0;

            double factor = GetFactor(image);

            GetMaxSize(image, ref maxWidth, ref maxHeight);

            if (FlipSize.Checked && image.Height > image.Width)
            {
                int temp = maxHeight;
                maxHeight = maxWidth;
                maxWidth = temp;
                factor = 1.0 / factor;
            }

            Size newSize = CalculateSize(image, factor, maxWidth, maxHeight);

            if (newSize.Width == image.Width && newSize.Height == image.Height)
            {
                return image;
            }
            else
            {
                modified = true;
                return ResizeImage(image, newSize);
            }
        }

        private void GetMaxSize(Image image, ref int maxWidth, ref int maxHeight)
        {
            if (RadioSizeOriginal.Checked)
            {
                maxWidth = image.Width;
                maxHeight = image.Height;
            }
            if (Radio1024.Checked)
            {
                maxWidth = 1024;
                maxHeight = 768;
            }
            if (Radio640.Checked)
            {
                maxWidth = 640;
                maxHeight = 480;
            }
            if (Radio320.Checked)
            {
                maxWidth = 320;
                maxHeight = 240;
            }
            if (Radio160.Checked)
            {
                maxWidth = 160;
                maxHeight = 120;
            }
            if (RadioOther.Checked)
            {
                maxWidth = (int)ManualWidth.Value;
                maxHeight = (int)ManualHeight.Value;
            }
        }

        private double GetFactor(Image image)
        {
            int height = image.Height;
            int width = image.Width;
            double factor = 1;
            if (RadioPropOriginal.Checked)
            {
                if (width >= height)
                {
                    factor = ((double)width) / ((double)height);
                }
                else
                {
                    factor = ((double)height) / ((double)width);
                }
            }
            if (Radio43.Checked)
            {
                factor = 4.0 / 3.0;
            }
            if (Radio32.Checked)
            {
                factor = 3.0 / 2.0;
            }
            if (Radio169.Checked)
            {
                factor = 16.0 / 9.0;
            }
            if (RadioIgnore.Checked)
            {
                factor = -1;
            }
            return factor;
        }
        
        private Size CalculateSize(Image image, double factor, int maxWidth, int maxHeight)
        {
            int width, height;

            if (factor == -1)
            {
                return new Size(maxWidth, maxHeight);
            }

            // Links und rechts schwarzer Balken
            height = maxHeight;
            width = (int)(((double)height) * factor);

            // Oben und unten schwarzer Balken
            if (width > maxWidth)
            {
                width = maxWidth;
                height = (int)(((double)width) / factor);
            }

            return new Size(width, height);
        }

        private Image ResizeImage(Image imgToResize, Size size)
        {
            //PropertyItem[] properties = imgToResize.PropertyItems;
            Image newImage = (Image)(new Bitmap(imgToResize, size));
            return newImage;
        }

        private void RadioProp_Click(object sender, EventArgs e)
        {
            RadioPropChecked(sender);
        }

        private void RadioPropChecked(object sender)
        {
            if (((RadioButton)sender).Text == "Ignore")
            {
                Radio1024.Enabled = Radio640.Enabled = Radio320.Enabled = Radio160.Enabled = false;
                RadioOther.Checked = true;
            }
            else
            {
                Radio1024.Enabled = Radio640.Enabled = Radio320.Enabled = Radio160.Enabled = true;

                if (RadioOther.Checked)
                {
                    double factor = GetFactor(getImage());
                    ManualHeight.Value = (decimal)Math.Round(((double)ManualWidth.Value) / factor, 0);
                }
            }

            Change();
        }

        private void RadioSize_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void Change()
        {
            if (RadioPropOriginal.Checked && RadioSizeOriginal.Checked)
            {
                activate(false, this);
            }
            else
            {
                activate(true, this);
            }

            TestAll();
        }

        private void ManualSize_Click(object sender, EventArgs e)
        {
            RadioOther.Checked = true;
        }

        private void ManualSize_KeyUp(object sender, KeyEventArgs e)
        {
            ManualSizeChange(sender);
        }

        private void ManualSizeChange(object sender)
        {
            RadioOther.Checked = true;

            if (!RadioIgnore.Checked && getImage != null)
            {
                double factor = GetFactor(getImage());

                if (((NumericUpDown)sender).Equals(ManualWidth))
                {
                    ManualHeight.Value = (decimal)Math.Round(((double)ManualWidth.Value) / factor, 0);
                }
                if (((NumericUpDown)sender).Equals(ManualHeight))
                {
                    ManualWidth.Value = (decimal)Math.Round(((double)ManualHeight.Value) * factor, 0);
                }
            }

            Change();
        }
    }
}
