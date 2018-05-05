using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Flexxi
{
    public partial class ResizeControl : EditControlVorlage
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

        public delegate void ScaleModeHandler(string mode);
        public event ScaleModeHandler scaleMode;

        public ResizeControl()
        {
            InitializeComponent();

            sizeChanged();
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

        public int getWidth()
        {
            if (getImage == null) return 0;
            Image image = getImage();

            Size newSize = CalculateSize(image);
            return newSize.Width;
        }

        public int getHeight()
        {
            if (getImage == null) return 0;
            Image image = getImage();

            Size newSize = CalculateSize(image);
            return newSize.Height;
        }

        public Image run(Image image)
        {
            modified = false;
            
            Size newSize = CalculateSize(image);

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
            if (Radio120.Checked)
            {
                maxWidth = 120;
                maxHeight = 90;
            }
            if (RadioOther.Checked)
            {
                maxWidth = (int)(ManualWidth.Value != 0 ? ManualWidth.Value : 1);
                maxHeight = (int)(ManualHeight.Value != 0 ? ManualHeight.Value : 1);
            }
        }

        private double GetFactor(Image image)
        {
            if(image == null)
            {
                return 4.0 / 3.0;
            }
            int height = image.Height;
            int width = image.Width;
            double factor = 1;
            if (RadioPropOriginal.Checked)
            {
                factor = ((double)width) / ((double)height);
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
            if((Radio43.Checked || Radio32.Checked || Radio169.Checked) && ((double)width) / ((double)height) < 1.0)
            {
                factor = 1 / factor;
            }
            return factor;
        }

        int maxWidth = 0;
        int maxHeight = 0;
        
        private Size CalculateSize(Image image)
        {
            if (image == null) return new Size(0, 0);

            double factor = GetFactor(image);

            GetMaxSize(image, ref maxWidth, ref maxHeight);

            if (FlipSize.Checked && image.Height > image.Width)
            {
                int temp = maxHeight;
                maxHeight = maxWidth;
                maxWidth = temp;
            }

            int width, height;

            if (radioResizeModeSprain.Checked)
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

            return new Size((width > 0 ? width : 1), (height > 0 ? height : 1));
        }

        private Image ResizeImage(Image imgToResize, Size size)
        {
            if (radioResizeModeFill.Checked)
            {
                Bitmap tempImage = new Bitmap(maxWidth, maxHeight);
                Graphics g = Graphics.FromImage(tempImage);
                Color color = Color.FromArgb((((int)numericUpDownOpacity.Value)*255)/100, buttonChangeFillColor.BackColor);
                g.FillRectangle(new SolidBrush(color), 0, 0, maxWidth, maxHeight);
                int x = maxWidth==size.Width ? 0 : (maxWidth-size.Width)/2;
                int y = maxHeight==size.Height ? 0 : (maxHeight-size.Height)/2;
                g.DrawImage(imgToResize, new Rectangle(x, y, size.Width, size.Height));
                Image newImage = (Image)(tempImage);
                return newImage;
            }
            else
            {
                //PropertyItem[] properties = imgToResize.PropertyItems;
                Image newImage = (Image)(new Bitmap(imgToResize, size));
                return newImage;
            }
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
                    //double factor = GetFactor(getImage());
                    //ManualHeight.Value = (decimal)Math.Round(((double)ManualWidth.Value) / factor, 0);
                }
            }

            Change();
        }

        private void RadioSize_Click(object sender, EventArgs e)
        {
            scaleMode("Original");
            Change();
        }

        private void Change()
        {
            if (RadioPropOriginal.Checked && RadioSizeOriginal.Checked && (RadioMaximumQuality.Checked || numericQuality.Value == 100))
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

        private bool ManualSizeKeyPressed = false;

        private void ManualSize_KeyDown(object sender, KeyEventArgs e)
        {
            ManualSizeKeyPressed = true;
        }

        private void ManualSize_KeyUp(object sender, KeyEventArgs e)
        {
            ManualSizeChange(sender);
            ManualSizeKeyPressed = false;
        }

        private void ManualSizeChange(object sender)
        {
            Change();
        }

        private void ManualSize_ValueChanged(object sender, EventArgs e)
        {
            if (!ManualSizeKeyPressed)
            {
                ManualSizeChange(sender);
            }
        }

        public int getQuality()
        {
            if (RadioReduceQuality.Checked)
            {
                return (int)numericQuality.Value;
            }
            else
            {
                return 100;
            }
        }

        private void RadioQuality_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void numericQuality_ValueChanged(object sender, EventArgs e)
        {
            if (numericQuality.Value != 100)
            {
                RadioReduceQuality.Checked = true;
            }
            Change();
        }

        public bool setScaleToOriginal()
        {
            if (RadioSizeOriginal.Checked && RadioPropOriginal.Checked)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ResizeControl_SizeChanged(object sender, EventArgs e)
        {
            sizeChanged();
        }

        private void buttonChangeFillColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                buttonChangeFillColor.BackColor = colorDialog.Color;
                Change();
            }
        }

        private void radioResizeModeFit_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanelFillColor.Enabled = false;
            flowLayoutOpacity.Enabled = false;
            groupBoxPropotionality.Enabled = true;
            Change();
        }

        private void radioResizeModeSprain_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanelFillColor.Enabled = false;
            flowLayoutOpacity.Enabled = false;
            groupBoxPropotionality.Enabled = false;
            Change();
        }

        private void radioResizeModeFill_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanelFillColor.Enabled = true;
            flowLayoutOpacity.Enabled = true;
            groupBoxPropotionality.Enabled = true;
            Change();
        }

        private void numericUpDownOpacity_ValueChanged(object sender, EventArgs e)
        {
            Change();
        }

        private void FlipSize_CheckedChanged(object sender, EventArgs e)
        {
            Change();
        }
    }
}
