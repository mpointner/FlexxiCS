using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Flexxi
{
    public partial class SelectLanguage : Form
    {
        public SelectLanguage()
        {
            InitializeComponent();

            //this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            fillLanguageComboBox();
        }

        private void fillLanguageComboBox()
        {
            foreach (KeyValuePair<string, string> l in Data.languages)
            {
                ComboBoxLanguage.Items.Add(l.Value);

                if (l.Key == Data.language)
                {
                    ComboBoxLanguage.SelectedIndex = ComboBoxLanguage.Items.Count - 1;
                }
            }
        }

        private void ComboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string language = Data.languages.ElementAt(ComboBoxLanguage.SelectedIndex).Key;
            if (language != Data.language)
            {
                Data.language = language;
                Properties.Settings.Default.Language = language;
            }
        }
    }
}
