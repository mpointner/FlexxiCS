using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;

namespace ImageFrame
{
    public partial class ConvertControl : UserControl
    {
        public delegate void ActivateHandler(bool activ, object sender);
        public event ActivateHandler activate;

        public delegate string GetPathHandler();
        public event GetPathHandler getPath;

        public delegate void SetPathHandler(string path);
        public event SetPathHandler setPath;

        public delegate string GetExtensionHandler();
        public event GetExtensionHandler getExtension;

        public delegate void SetExtensionHandler(string extension);
        public event SetExtensionHandler setExtension;

        public delegate void TestHandler();
        public event TestHandler test;
        
        public delegate void HideHandler();
        public event HideHandler hide;

        private readonly List<string> ImageExtensions = new List<string> { "JPG", "JPEG", "GIF", "PNG", "TIFF" };

        public ConvertControl()
        {
            InitializeComponent();

            init();
        }

        public void init()
        {
            ConvertList.Items.Clear();

            ConvertList.Items.Add("Original");
            ConvertList.SelectedIndex = 0;

            foreach (string ImageExtension in ImageExtensions)
            {
                if (UpperCase.Checked)
                {
                    ConvertList.Items.Add(ImageExtension.ToUpperInvariant());
                }
                else
                {
                    ConvertList.Items.Add(ImageExtension.ToLowerInvariant());
                }
            }
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
            if (getPath == null) return;
            string path = getPath();
            string newExtension = run(path);
            if (newExtension == null) return;
            if (setExtension == null) return;
            setExtension(newExtension);
        }

        public bool modified = false;

        public string run(string path)
        {
            modified = false;
            if (ConvertList.SelectedItem == null) return null;
            if (ConvertList.SelectedItem.ToString() == "Original")
            {
                return Path.GetExtension(path).Replace(".", "");
            }
            if (ConvertList.SelectedItem.ToString() != Path.GetExtension(path).Replace(".", ""))
            {
                modified = true;
            }
            return ConvertList.SelectedItem.ToString();
        }

        private void UpperCase_CheckedChanged(object sender, EventArgs e)
        {
            int index = ConvertList.SelectedIndex;
            init();
            ConvertList.SelectedIndex = index;

            Change();
        }

        private void ConvertList_SelectedValueChanged(object sender, EventArgs e)
        {
            Change();
        }

        private void Change()
        {
            if (activate != null)
            {
                if (ConvertList.SelectedItem.ToString() == "Original")
                {
                    activate(false, this);
                }
                else
                {
                    activate(true, this);
                }
            }

            TestAll();
        }
    }
}
