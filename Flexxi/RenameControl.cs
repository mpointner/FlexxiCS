using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing.Imaging;

namespace Flexxi
{
    public partial class RenameControl : EditControlVorlage
    {
        public delegate void ActivateHandler(bool activ, object sender);
        public event ActivateHandler activate;

        public delegate Image GetImageHandler();
        public event GetImageHandler getImage;

        public delegate string GetNameHandler();
        public event GetNameHandler getName;

        public delegate void SetNameHandler(string name);
        public event SetNameHandler setName;

        public delegate string GetPathHandler();
        public event GetPathHandler getPath;

        public delegate void SetPathHandler(string path);
        public event SetPathHandler setPath;

        public delegate string GetExtensionHandler();
        public event GetExtensionHandler getExtension;

        public delegate void SetExtensionHandler(string extension);
        public event SetExtensionHandler setExtension;

        public delegate int GetIndexHandler();
        public event GetIndexHandler getIndex;

        public delegate void TestHandler();
        public event TestHandler test;

        public delegate void HideHandler();
        public event HideHandler hide;

        public delegate int WidthHandler();
        public event WidthHandler getWidth;

        public delegate int HeightHandler();
        public event HeightHandler getHeight;

        public RenameControl()
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
            init();

            if (getName == null) return;
            string name = getName();
            if (name == null) return;

            if (getPath == null) return;
            string path = getPath();
            if (path == null) return;

            if (getExtension == null) return;
            string extension = getExtension().ToLowerInvariant();
            if (extension == null) return;

            if (getImage == null) return;
            Image image = getImage();
            if (image == null) return;

            string newName = run(path, image);
            if (newName == null) return;
            setName(newName);
        }

        private int i = 0;

        public void init()
        {
            i = 0;
        }

        public void initSingle()
        {
            i = getIndex();
        }

        public bool modified = false;

        delegate string GetLeadingZerosCallback();

        public string getLeadingZeros()
        {
            if (DateLeadingZeros.InvokeRequired)
            {
                return (string) this.Invoke(new GetLeadingZerosCallback(getLeadingZeros)); 
            }
            else
            {
                return LeadingZeros.Text;
            }
        }

        delegate string RunCallback(string path, Image image);

        public string run(string path, Image image)
        {
            if (DateLeadingZeros.InvokeRequired)
            {
                return (string)this.Invoke(new RunCallback(run), new object[] { path, image });
            }
            else
            {
                modified = false;

                if (path == "") return String.Empty;

                string filter = NameField.Text;

                string name = Path.GetFileNameWithoutExtension(path);

                string vornullen = String.Empty;
                if (getLeadingZeros() == Data.translate("Yes"))
                {
                    for (int x = 0; x < (int)Length.Value; x++) vornullen += "0";
                }
                else
                {
                    vornullen = "0";
                }

                DateTime time;
                if (Date.Text == Data.translate("Acquisition"))
                {
                    time = GetDateTakenFromImage(image);
                    if (time.Ticks == 0)
                    {
                        time = DateTime.Now;
                    }
                }
                else
                {
                    time = DateTime.Now;
                }

                string zeros = "0";
                if (getLeadingZeros() == Data.translate("Yes"))
                {
                    zeros = "00";
                }
                
                long size = 0;
                try
                {
                    size = new FileInfo(path).Length;
                }
                catch(Exception ex)
                {
                    size = image.Size.Width * image.Size.Height * 3;
                }

                if (filter != "[OriginalName]")
                {
                    modified = true;
                }

                filter = filter.Replace("[OriginalName]", name);
                filter = filter.Replace("[Type]", Path.GetExtension(path).Replace(".", ""));
                filter = filter.Replace("[Countner]", String.Format("{0:" + vornullen + "}", (Start.Value + Step.Value * i)));

                filter = filter.Replace("[Width]", getWidth().ToString());
                filter = filter.Replace("[Height]", getHeight().ToString());

                filter = filter.Replace("[Year]", time.Year.ToString());
                filter = filter.Replace("[Month]", String.Format("{0:" + zeros + "}", time.Month));
                filter = filter.Replace("[Day]", String.Format("{0:" + zeros + "}", time.Day));
                filter = filter.Replace("[Hour]", String.Format("{0:" + zeros + "}", time.Hour));
                filter = filter.Replace("[Minute]", String.Format("{0:" + zeros + "}", time.Minute));
                filter = filter.Replace("[Second]", String.Format("{0:" + zeros + "}", time.Second));

                filter = filter.Replace("[Date]", String.Format("{0:" + zeros + "}", time.Day) + "" +
                                                  String.Format("{0:" + zeros + "}", time.Month) + "" +
                                                  time.Year.ToString());

                filter = filter.Replace("[Time]", String.Format("{0:" + zeros + "}", time.Hour) + "" +
                                                  String.Format("{0:" + zeros + "}", time.Minute) + "" +
                                                  String.Format("{0:" + zeros + "}", time.Second));

                filter = filter.Replace("[Size]", (size/1000).ToString() + "KB");
                i++;

                return filter;
            }
        }

        private void Insert(string text)
        {
            int nCursorPosition = NameField.SelectionStart;
            string textBoxMsg = NameField.Text;

            textBoxMsg = textBoxMsg.Insert(nCursorPosition, text);

            NameField.Text = textBoxMsg;
            NameField.SelectionStart = nCursorPosition + text.Length;
            NameField.Focus();
        }
        
        private static Regex r = new Regex(":");

        public static DateTime GetDateTakenFromImage(Image image)
        {
            try
            {
                PropertyItem propItem = image.GetPropertyItem(36867);
                //if (propItem == null) propItem = image.GetPropertyItem(306);
                string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                return DateTime.Parse(dateTaken);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Thrown:"+ex.ToString());
                return DateTime.Now;
            }
        }

        private void Type_Click(object sender, EventArgs e)
        {
            Insert("[Type]");
        }

        private void Counter_Click(object sender, EventArgs e)
        {
            Insert("[Countner]");
        }

        private void Size_Click(object sender, EventArgs e)
        {
            Insert("[Size]");
        }

        private void Width_Click(object sender, EventArgs e)
        {
            Insert("[Width]");
        }

        private void Height_Click(object sender, EventArgs e)
        {
            Insert("[Height]");
        }

        private void Year_Click(object sender, EventArgs e)
        {
            Insert("[Year]");
        }

        private void Month_Click(object sender, EventArgs e)
        {
            Insert("[Month]");
        }

        private void Day_Click(object sender, EventArgs e)
        {
            Insert("[Day]");
        }

        private void Hour_Click(object sender, EventArgs e)
        {
            Insert("[Hour]");
        }

        private void Minute_Click(object sender, EventArgs e)
        {
            Insert("[Minute]");
        }

        private void Second_Click(object sender, EventArgs e)
        {
            Insert("[Second]");
        }

        private void OriginalName_Click(object sender, EventArgs e)
        {
            Insert("[OriginalName]");
        }

        private void BDate_Click(object sender, EventArgs e)
        {
            Insert("[Date]");
        }

        private void BTime_Click(object sender, EventArgs e)
        {
            Insert("[Time]");
        }

        private void NameField_TextChanged(object sender, EventArgs e)
        {
            Change();
        }

        private void Change()
        {
            if (NameField.Text == "[OriginalName]")
            {
                activate(false, this);
            }
            else
            {
                activate(true, this);
            }

            TestAll();
        }

        private void FilterSettings_ValueChanged(object sender, EventArgs e)
        {
            if (NameField.Text != "[OriginalName]")
            {
                TestAll();
            }
        }

        private void RenameControl_SizeChanged(object sender, EventArgs e)
        {
            sizeChanged();
        }

        private void NameField_KeyUp(object sender, KeyEventArgs e)
        {
            //if (NameField.Text != "[OriginalName]")
            //{
                TestAll();
            //}
        }
    }
}
