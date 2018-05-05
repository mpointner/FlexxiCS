using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Flexxi
{
    public partial class EditControl : UserControlVorlage
    {
        private Control activatedControl = null;

        public RotateControl rotateControl;
        public ResizeControl resizeControl;
        public RenameControl renameControl;
        public ConvertControl convertControl;
        public SaveControl saveControl;
        public SettingsControl settingsControl;

        public delegate void RepaintImageHandler();
        public event RepaintImageHandler RepaintImage;

        public delegate void ScaleModeHandler(string mode);
        public event ScaleModeHandler scaleMode;

        public delegate Image GetImageHandler();
        public event GetImageHandler getImage;

        public delegate void SetImageHandler(Image image);
        public event SetImageHandler setImage;

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

        public delegate void StartHandler();
        public event StartHandler start;

        public delegate void StopHandler();
        public event StopHandler stop;

        public delegate void CloseFormHandler();
        public event CloseFormHandler closeForm;

        public delegate void ActivateInputHandler(bool activate);
        public event ActivateInputHandler activateInput;

        public bool running = false;

        public bool closeFormWhenReady = false;

        public EditControl()
        {
            InitializeComponent();

            init();
        }

        private void init()
        {
            /*
            ScrollBar vScrollBar = new VScrollBar();
            vScrollBar.Dock = DockStyle.Right;
            vScrollBar.Scroll += (sender, e) => { SettingsPanel.VerticalScroll.Value = vScrollBar.Value; };
            SettingsPanel.Controls.Add(vScrollBar);
            */
            rotateControl = new RotateControl();
            rotateControl.hide += new RotateControl.HideHandler(hide);
            rotateControl.Visible = false;
            SettingsPanel.Controls.Add(rotateControl);
                
            resizeControl = new ResizeControl();
            resizeControl.hide += new ResizeControl.HideHandler(hide);
            resizeControl.Visible = false;
            SettingsPanel.Controls.Add(resizeControl);
                
            renameControl = new RenameControl();
            renameControl.hide += new RenameControl.HideHandler(hide);
            renameControl.getWidth += new RenameControl.WidthHandler(resizeControl.getWidth);
            renameControl.getHeight += new RenameControl.HeightHandler(resizeControl.getHeight);
            renameControl.Visible = false;
            SettingsPanel.Controls.Add(renameControl);
                
            convertControl = new ConvertControl();
            convertControl.hide += new ConvertControl.HideHandler(hide);
            convertControl.Visible = false;
            SettingsPanel.Controls.Add(convertControl);

            saveControl = new SaveControl();
            saveControl.hide += new SaveControl.HideHandler(hide);
            saveControl.Visible = false;
            SettingsPanel.Controls.Add(saveControl);

            settingsControl = new SettingsControl();
            settingsControl.hide += new SettingsControl.HideHandler(hide);
            settingsControl.Visible = false;
            SettingsPanel.Controls.Add(settingsControl);
            

            if (!saveControl.IsDontSaveActiv())
            {
                SetActivateStateChangeColor(true, this.ButtonSave);
            }
        }

        private void ChangeActivateState(Button sender)
        {
            if (sender.BackColor == Color.LightGreen)
            {
                sender.BackColor = SystemColors.Control;
            }
            else
            {
                sender.BackColor = Color.LightGreen;
            }
        }

        public void SetActivateState(bool activ, object sender)
        {
            if (sender.GetType().Equals(typeof(RotateControl)))
            {
                SetActivateStateChangeColor(activ, ButtonRotate);
            }
            if (sender.GetType().Equals(typeof(ResizeControl)))
            {
                SetActivateStateChangeColor(activ, ButtonResize);
            }
            if (sender.GetType().Equals(typeof(RenameControl)))
            {
                SetActivateStateChangeColor(activ, ButtonRename);
            }
            if (sender.GetType().Equals(typeof(ConvertControl)))
            {
                SetActivateStateChangeColor(activ, ButtonConvert);
            }
            if (sender.GetType().Equals(typeof(SaveControl)))
            {
                SetActivateStateChangeColor(activ, ButtonSave);
            }
        }

        private static void SetActivateStateChangeColor(bool activ, Button sender)
        {
            if (activ)
            {
                sender.BackColor = Color.LightGreen;
            }
            else
            {
                sender.BackColor = SystemColors.Control;
            }
        }

        private bool GetActivateState(object sender)
        {
            if (sender.GetType().Equals(typeof(RotateControl)))
            {
                return GetActivateStateChangeColor(ButtonRotate);
            }
            if (sender.GetType().Equals(typeof(ResizeControl)))
            {
                return GetActivateStateChangeColor(ButtonResize);
            }
            if (sender.GetType().Equals(typeof(RenameControl)))
            {
                return GetActivateStateChangeColor(ButtonRename);
            }
            if (sender.GetType().Equals(typeof(ConvertControl)))
            {
                return GetActivateStateChangeColor(ButtonConvert);
            }
            if (sender.GetType().Equals(typeof(SaveControl)))
            {
                return GetActivateStateChangeColor(ButtonSave);
            }
            return false;
        }

        public bool GetActivateStateForProcess(string name)
        {
            if (name.Equals("Rotate"))
            {
                return GetActivateStateChangeColor(ButtonRotate);
            }
            if (name.Equals("Resize"))
            {
                return GetActivateStateChangeColor(ButtonResize);
            }
            if (name.Equals("Rename"))
            {
                return GetActivateStateChangeColor(ButtonRename);
            }
            if (name.Equals("Convert"))
            {
                return GetActivateStateChangeColor(ButtonConvert);
            }
            if (name.Equals("Save"))
            {
                return GetActivateStateChangeColor(ButtonSave);
            }
            return false;
        }

        private static bool GetActivateStateChangeColor(Button sender)
        {
            if (sender.BackColor == Color.LightGreen)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ButtonRotate_Click(object sender, EventArgs e)
        {
            OpenSettings(rotateControl);
        }

        private void ButtonResize_Click(object sender, EventArgs e)
        {
            OpenSettings(resizeControl);
        }

        public void resize()
        {
            foreach (Control control in SettingsPanel.Controls)
            {
                control.Height = SettingsPanel.Height;
            }
        }

        public void hide()
        {
            SettingsPanel.Controls.Clear();
            activatedControl = null;
        }

        private void ButtonRename_Click(object sender, EventArgs e)
        {
            OpenSettings(renameControl);
        }

        private void ButtonConvert_Click(object sender, EventArgs e)
        {
            OpenSettings(convertControl);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            OpenSettings(saveControl);
        }

        public void OpenSettings(Control control)
        {
            if (activatedControl != control || SettingsPanel.Controls.Count == 0)
            {
                control.Visible = true;
                if (activatedControl != null)
                {
                    activatedControl.Visible = false;
                }
                control.Height = SettingsPanel.Height;
                activatedControl = control;
            }
            else
            {
                activatedControl.Visible = false;
                activatedControl = null;
            }

            if (RepaintImage != null)
            {
                RepaintImage();
            }
        }

        public void activateStart(bool active)
        {
            ButtonStartStop.Enabled = active;
        }

        public void Test()
        {
            if (getImage == null || setImage == null ||
                getName == null || setName == null ||
                getExtension == null || setExtension == null ||
                getPath == null || setPath == null)
            {
                return;
            }

            Image image = getImage();
            
            if (image == null)
            {
                return;
            }
            
            string name = getName();
            string extension = getExtension();
            string path = getPath();

            if (GetActivateState(rotateControl))
            {
                if (scaleMode != null && GetActivateState(resizeControl) == false)
                    scaleMode("Fit");

                rotateControl.testMode = true;
                image = rotateControl.run(image);
                rotateControl.testMode = false;
            }
            if (GetActivateState(renameControl))
            {
                renameControl.initSingle();
                name = renameControl.run(path, image);
            }
            if(GetActivateState(resizeControl))
            {
                /*
                if (scaleMode != null && resizeControl.setScaleToOriginal())
                    scaleMode("Original");
                */
                image = resizeControl.run(image);
            }
            if(GetActivateState(convertControl))
            {
                extension = convertControl.run(path);
            }

            setImage(image);
            setName(name);
            setExtension(extension);
        }

        public bool modified(string name)
        {
            if (name.Equals("Rotate"))
            {
                return rotateControl.modified;
            }
            if (name.Equals("Resize"))
            {
                return resizeControl.modified;
            }
            if (name.Equals("Rename"))
            {
                return renameControl.modified;
            }
            if (name.Equals("Convert"))
            {
                return convertControl.modified;
            }
            return false;
        }

        private void ButtonStartStop_Click(object sender, EventArgs e)
        {
            StartStop();
        }

        private void StartStop()
        {
            if (running == false)
            {
                startProcess();
            }
            else
            {
                stopProcess();
            }
        }

        private void startProcess()
        {
            if (activateInput != null)
            {
                EnableSettingsControls(false);
                activateInput(false);
                ButtonStartStop.Text = "Stop";
                running = true;
                start();
            }
        }

        delegate void StopProcessHandler();

        public void stopProcess()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new StopProcessHandler(stopProcess));
            }
            else
            {
                if (running == true && activateInput != null)
                {
                    EnableSettingsControls(true);
                    activateInput(true);
                    ButtonStartStop.Text = "Start";
                    running = false;
                    stop();
                }
            }
        }

        public void ready()
        {
            stopProcess();

            if (closeFormWhenReady && closeForm != null)
            {
                closeForm();
            }
        }

        private void EnableSettingsControls(bool activate)
        {
            resizeControl.Enabled = activate;
            rotateControl.Enabled = activate;
            renameControl.Enabled = activate;
            convertControl.Enabled = activate;
            saveControl.Enabled = activate;
            settingsControl.Enabled = activate;
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            OpenSettings(settingsControl);
        }
    }
}
