using System.Windows.Forms;
using System.Drawing;
using System;

namespace Flexxi
{
    public partial class UserControlVorlage : UserControl
    {
        protected int editControlsWidthWithoutScrollBar = 170;
        protected int editControlsWidthWithScrollBar = 188;

        public UserControlVorlage()
        {
            InitializeComponent();
        }

        public void translate()
        {
            translateRecursive(this);
        }

        private void translateRecursive(object parentObj)
        {
            if (parentObj is MenuStrip)//System.Windows.Forms.MenuStrip)
            {
                MenuStrip parent = (MenuStrip)parentObj;
                ToolStripItemCollection items = parent.Items;
                foreach (ToolStripMenuItem child in items)
                {
                    if (child.Tag == null || !((string)child.Tag).Equals("NoTranslate"))
                    {
                        child.Text = Data.translate(child.Text, child.Name+" "+child.GetType());
                    }

                    translateRecursive(child);
                }
            }
            else if (parentObj is ToolStripMenuItem)
            {
                ToolStripMenuItem parent = (ToolStripMenuItem)parentObj;
                foreach (ToolStripDropDownItem child in ((ToolStripMenuItem)parent).DropDownItems)
                {
                    if (child.Tag == null || !((string)child.Tag).Equals("NoTranslate"))
                    {
                        child.Text = Data.translate(child.Text, child.Name + " " + child.GetType());
                    }
                }
            }
            else if (parentObj is ComboBox)
            {
                ComboBox parent = (ComboBox)parentObj;
                if (((ComboBox)parent).Tag == null || 
                    !((string)((ComboBox)parent).Tag).Equals("NoTranslate"))
                {
                    ComboBox.ObjectCollection items = ((ComboBox)parent).Items;
                    for (int i = 0; i < ((ComboBox)parent).Items.Count; i++)
                    {
                        ((ComboBox)parent).Items[i] = Data.translate(((ComboBox)parent).Items[i].ToString());
                    }
                }
            }
            else if (parentObj is System.Windows.Forms.NumericUpDown)
            {
                // Don't translate numbers
            }
            else if (parentObj is RadioButton)
            {
                RadioButton parent = (RadioButton) parentObj;
                if (parent.Tag == null || !((string)parent.Tag).Equals("NoTranslate"))
                {
                    string text = Data.translate(parent.Text, parent.Name + " " + parent.GetType());
                    string[] split = text.Split(' ');
                    text = "";
                    string line = "";

                    int lines = 1;
                    for (int i = 0; i < split.Length; i++)
                    {
                        Size size = TextRenderer.MeasureText(line+split[i], parent.Font);
                        if(size.Width - 20 > parent.Size.Width)
                        {
                            text += line + Environment.NewLine;
                            line = "";
                            lines++;
                            parent.Size = new Size(parent.Size.Width, (int)(size.Height * lines * 1.5));
                        }
                        line += split[i] + " ";
                    }
                    text += line;
                    parent.Text = text;
                }
            }
            else if (parentObj is RadioButton || parentObj is CheckBox || parentObj is Label)
            {
                Control parent = (Control)parentObj;
                if (parent.Tag == null || !((string)parent.Tag).Equals("NoTranslate"))
                {
                    int space = 0;
                    if (parentObj is RadioButton || parentObj is CheckBox)
                    {
                        space = 30;
                    }

                    if (parent.Tag == null || !((string)parent.Tag).Equals("NoTranslate"))
                    {
                        string text = Data.translate(parent.Text, parent.Name + " " + parent.GetType());
                        string[] split = text.Split(' ');
                        text = "";
                        string line = "";

                        int lines = 1;
                        for (int i = 0; i < split.Length; i++)
                        {
                            Size size = TextRenderer.MeasureText(line + split[i], parent.Font);
                            if (size.Width - space > parent.Size.Width)
                            {
                                text += line + Environment.NewLine;
                                line = "";
                                lines++;
                                parent.Size = new Size(parent.Size.Width, (int)(size.Height * lines * 2));
                            }
                            line += split[i] + " ";
                        }
                        text += line;
                        parent.Text = text;
                    }
                }
            }
            else
            {
                Control parent = (Control)parentObj;
                if (parent.Tag == null || !((string)parent.Tag).Equals("NoTranslate"))
                {
                    parent.Text = Data.translate(parent.Text, parent.Name + " " + parent.GetType());
                }
                ControlCollection children = ((Control)parent).Controls;
                foreach (Control child in children)
                {

                    translateRecursive(child);
                }
            }
        }

        private bool scrollbarVisible = false;

        public void sizeChanged()
        {
            if (scrollbarVisible && !this.VerticalScroll.Visible)
            {
                this.Size = new Size(editControlsWidthWithoutScrollBar, this.Size.Height);
                scrollbarVisible = false;
            }
            if (!scrollbarVisible && this.VerticalScroll.Visible)
            {
                this.Size = new Size(editControlsWidthWithScrollBar, this.Size.Height);
                scrollbarVisible = true;
            }
        }
    }
}
