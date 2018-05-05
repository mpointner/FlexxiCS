using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using Flexxi;
using System.Deployment.Application;
using System.Net.Mail;

namespace Flexxi
{
    public partial class SettingsControl : EditControlVorlage
    {
        public delegate void HideHandler();
        public event HideHandler hide;

        public delegate void DragNDropHandler(bool activate);
        public event DragNDropHandler dragNDrop;

        public SettingsControl()
        {
            InitializeComponent();

            SendToCheckBox.Checked = Program.registered();
            //DragNDropCheckBox.Checked = this.Parent.AllowDrop;
            fillLanguageComboBox();

            SettingsControl_SizeChanged(null, null);

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                labelVersion.Text = string.Format("Version {0}", ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4));
            }
            else
            {
                labelVersion.Dispose();
            }
            /*
            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            labelVersion.Text = "Version "+ version.Major + "." + version.Minor + "." + version.Build + "." + version.Revision;
            */
        }

        private void fillLanguageComboBox()
        {
            foreach(KeyValuePair<string, string> l in Data.languages)
            {
                ComboBoxLanguage.Items.Add(l.Value);

                if(l.Key == Data.language)
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
                Data.changingLanguage = true;
                Properties.Settings.Default.Language = language;
                Data.load();
                InputControl.treeNodes.Clear();
                Program.reTranslate();
            }
        }

        public bool skipErrorActivated()
        {
            return SkipError.Checked;
        }

        private void DragNDropCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dragNDrop != null)
            {
                dragNDrop(DragNDropCheckBox.Checked);
            }
        }

        private String sendToNotPossible = Data.translate("Setting \"send to\" is not possible on your system")+".";

        private void SendToCheckBox_Click(object sender, EventArgs e)
        {
            try
            {
                if (SendToCheckBox.Checked)
                {
                    Program.register();
                }
                else
                {
                    Program.unregister();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(sendToNotPossible);
                SendToCheckBox.Checked = false;
            }
        }

        private void SkipErrorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SkipErrorRead.Enabled = SkipErrorWrite.Enabled = SkipErrorExists.Enabled = SkipError.Checked;
            SkipErrorOverwrite.Enabled = SkipErrorChange.Enabled = SkipError.Checked ? SkipErrorExists.Checked : false;
        }

        private void SkipErrorExists_CheckedChanged(object sender, EventArgs e)
        {
            SkipErrorOverwrite.Enabled = SkipErrorChange.Enabled = SkipErrorExists.Checked;
        }

        private bool askedStandardRead = false;
        private bool askedStandardWrite = false;
        private bool askedStandardOverwrite = false;
        // Cause invoke needs its time, this prevents the dialog window to open again, until invoke is ready
        private bool askedStandardReadTempAllow = false;
        private bool askedStandardWriteTempAllow = false;
        private bool askedStandardOverwriteTempAllowYes = false;
        private bool askedStandardOverwriteTempAllowNo = false;

        public void init()
        {
            askedStandardRead = askedStandardWrite = askedStandardOverwrite = false;
        }

        private String fileTranslated = Data.translate("File");
        private String cantBeRead = Data.translate("can't be read");
        private String checkIfOpenInAnotherProgram = Data.translate("Check if the file is open in another program");
        private String fileCantBeRead = Data.translate("File can't be read");
        private String setActionAsStandard = Data.translate("Do you want to set this action as standard?");
        private String settingStandards = Data.translate("Setting standards");
        private String couldntBeWrittenTo = Data.translate("");
        private String cantBeWritten = Data.translate("can't be written");
        private String fileCantBeWritten = Data.translate("File can't be written");
        private String doesAlreadyExist = Data.translate("does already exist");
        private String doYouWantToOverwriteIt = Data.translate("Do you want to overwrite it?");
        private String overwriteWarning = Data.translate("Overwrite warning");
        private String thankTextReport = Data.translate("Thank you for your contribution to improve Flexxi");

        public byte alert(string file, byte fehler)
        {
            DialogResult result;
            switch (fehler)
            {
                case Fehler.ErrorCantReadFile:
                    if ((SkipError.Checked && SkipErrorRead.Checked) || askedStandardReadTempAllow) return Fehler.Skip;
                    result = MessageBox.Show(fileTranslated+" "+file+" "+cantBeRead+". "+checkIfOpenInAnotherProgram+".", fileCantBeRead, MessageBoxButtons.AbortRetryIgnore);
                    if (result == DialogResult.Abort) return Fehler.Abort;
                    if (!askedStandardRead && result == DialogResult.Ignore)
                    {
                        DialogResult resultStandard = MessageBox.Show(setActionAsStandard, settingStandards, MessageBoxButtons.YesNo);
                        if (resultStandard == DialogResult.Yes)
                        {
                            askedStandardReadTempAllow = true;
                            this.BeginInvoke((Action)(() =>
                            {
                                if (!SkipError.Checked) SkipErrorWrite.Checked = SkipErrorExists.Checked = false;
                                SkipError.Checked = SkipErrorRead.Checked = true;
                                askedStandardReadTempAllow = false;
                            }));
                        }
                        askedStandardWrite = true;
                    }
                    return result == DialogResult.Retry ? Fehler.Repeat : Fehler.Skip;
                case Fehler.ErrorCantWriteFile:
                    if ((SkipError.Checked && SkipErrorWrite.Checked) || askedStandardReadTempAllow) return Fehler.Skip;
                    result = MessageBox.Show(fileTranslated+" " + file + " "+cantBeWritten+". "+checkIfOpenInAnotherProgram+".", fileCantBeWritten, MessageBoxButtons.AbortRetryIgnore);
                    if (result == DialogResult.Abort) return Fehler.Abort;
                    if (!askedStandardWrite && result == DialogResult.Ignore)
                    {
                        DialogResult resultStandard = MessageBox.Show(setActionAsStandard, settingStandards, MessageBoxButtons.YesNo);
                        if (resultStandard == DialogResult.Yes)
                        {
                            askedStandardReadTempAllow = true;
                            this.BeginInvoke((Action)(() =>
                            {
                                if (!SkipError.Checked) SkipErrorRead.Checked = SkipErrorExists.Checked = false;
                                SkipError.Checked = SkipErrorWrite.Checked = true;
                                askedStandardReadTempAllow = false;
                            }));
                        }
                        askedStandardWrite = true;
                    }
                    return result == DialogResult.Retry ? Fehler.Repeat : Fehler.Skip;
                case Fehler.WarningOverwriteDestination:
                    if ((SkipError.Checked && SkipErrorExists.Checked) || askedStandardOverwriteTempAllowYes || askedStandardOverwriteTempAllowNo)
                    {
                        if (SkipErrorOverwrite.Checked || askedStandardOverwriteTempAllowYes) return Fehler.Yes;
                        if (SkipErrorChange.Checked || askedStandardOverwriteTempAllowNo) return Fehler.No;
                    }
                    result = MessageBox.Show(fileTranslated+" "+ file + " "+doesAlreadyExist+". "+ doYouWantToOverwriteIt, overwriteWarning, MessageBoxButtons.YesNo);
                    if (!askedStandardOverwrite)
                    {
                        DialogResult resultStandard = MessageBox.Show(setActionAsStandard, settingStandards, MessageBoxButtons.YesNo);
                        if(resultStandard == DialogResult.Yes)
                        {
                            askedStandardOverwriteTempAllowYes = result == DialogResult.Yes;
                            askedStandardOverwriteTempAllowNo = result == DialogResult.No;
                            this.BeginInvoke((Action)(() =>
                            {
                                if (!SkipError.Checked) SkipErrorRead.Checked = SkipErrorWrite.Checked = false;
                                SkipError.Checked = SkipErrorExists.Checked = true;
                                if (resultStandard == DialogResult.Yes)
                                {
                                    SkipErrorOverwrite.Checked = result == DialogResult.Yes;
                                    SkipErrorChange.Checked = result == DialogResult.No;
                                }
                                askedStandardOverwriteTempAllowYes = askedStandardOverwriteTempAllowNo = false;
                            })); 
                        }
                        askedStandardOverwrite = true;
                    }
                    return result == DialogResult.Yes ? Fehler.Yes : Fehler.No;
            }
            return Fehler.Ok;
        }

        private void SettingsControl_SizeChanged(object sender, EventArgs e)
        {
            sizeChanged();
        }

        private void buttonReportErrorSubmit_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage("flexxi@gmx.at", "flexxi@gmx.at");
            SmtpClient client = new SmtpClient("mail.gmx.net", 587);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("flexxi@gmx.at", "flexxi2510");
            mail.Subject = "Flexxi Bug Report";
            mail.Body = textBoxReportError.Text;
            client.Send(mail);

            textBoxReportError.Text = "";

            MessageBox.Show(thankTextReport);
        }

        private void textBoxReportError_TextChanged(object sender, EventArgs e)
        {
            if(textBoxReportError.TextLength > 0)
            {
                buttonReportErrorSubmit.Enabled = true;
            }
            else
            {
                buttonReportErrorSubmit.Enabled = false;
            }
        }
    }
}
