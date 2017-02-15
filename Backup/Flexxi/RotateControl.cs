using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageFrame
{
    public partial class RotateControl : UserControl
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

        public RotateControl()
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
            Image imageRotated = run(image);
            if (imageRotated == null) return;
            setImage(imageRotated);
        }

        public bool modified = false;
        public bool testMode = false;

        public Image run(Image image)
        {
            if (image == null) return null;

            modified = false;

            Image tempImage;

            if (testMode)
            {
                tempImage = new Bitmap(image);
            }
            else
            {
                tempImage = image;
            }

            if (None.Checked)
            {
                return tempImage;
            }
            if (AutoDetect.Checked)
            {
                for (int i=0; i < image.PropertyItems.Length; i++)
                {
                    var prop = image.PropertyItems[i];

                    if ((prop.Id == 0x0112 || prop.Id == 5029 || prop.Id == 274))
                    {
                        var value = (int)prop.Value[0];
                        if (value == 1)
                        {
                            modified = false;
                        }
                        if (value == 6)
                        {
                            tempImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            if (!testMode)
                            {
                                prop.Value[0] = (byte) 1;
                                tempImage.SetPropertyItem(prop);
                            }
                            modified = true;
                            break;
                        }
                        else if (value == 8)
                        {
                            tempImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                            if (!testMode)
                            {
                                prop.Value[0] = (byte)1;
                                tempImage.SetPropertyItem(prop);
                            }
                            modified = true;
                            break;
                        }
                        else if (value == 3)
                        {
                            tempImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                            if (!testMode)
                            {
                                prop.Value[0] = (byte)1;
                                tempImage.SetPropertyItem(prop);
                            }
                            modified = true;
                            break;
                        }
                    }
                }
            }
            if (Manual90.Checked)
            {
                tempImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                modified = true;
            }
            if (Manual180.Checked)
            {
                tempImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                modified = true;
            }
            if (Manual270.Checked)
            {
                tempImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                modified = true;
            }

            return tempImage;
        }

        private void Radio_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void Change()
        {
            if (None.Checked)
            {
                activate(false, this);
            }
            else
            {
                activate(true, this);
            }

            TestAll();
        }
    }
}
