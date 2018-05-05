using System.Globalization;
using System.Windows.Forms;

namespace Flexxi
{
    public partial class FormVorlage : Form
    {
        public FormVorlage()
        {
            InitializeComponent();
        }

        
        protected void translate()
        {
            CultureInfo ci = CultureInfo.InstalledUICulture;

            if (Data.language != "en")
            {
                translateRecursive(this);
            }
        }

        private void translateRecursive(object parent)
        {
            System.Windows.Forms.Control.ControlCollection children = ((Control)parent).Controls;
            foreach(Control child in children)
            {
                if(child is UserControlVorlage)
                {
                    ((UserControlVorlage)child).translate();
                }
            }
        }


    }

}

