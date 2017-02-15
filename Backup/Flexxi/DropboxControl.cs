using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageFrame
{
    public partial class DropboxControl : UserControl
    {
        public delegate void ActivateHandler(bool activ, object sender);
        public event ActivateHandler activate;

        public delegate void HideHandler();
        public event HideHandler hide;

        public DropboxControl()
        {
            InitializeComponent();
        }
    }
}
