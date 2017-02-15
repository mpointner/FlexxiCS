using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ImageFrame
{
    public partial class ProcessControl : UserControl
    {
        public delegate List<InputFile> GetInputFilesListHandler();
        public event GetInputFilesListHandler getInputFilesList;

        public delegate bool GetActivateStateForProcessHandler(string name);
        public event GetActivateStateForProcessHandler getActivateStateForProcess;

        public delegate Image RunResizeControlHandler(Image image);
        public event RunResizeControlHandler runResize;

        public delegate Image RunRotateControlHandler(Image image);
        public event RunRotateControlHandler runRotate;

        public delegate void InitRenameControlHandler();
        public event InitRenameControlHandler initRename;

        public delegate string RunRenameControlHandler(string path, Image image);
        public event RunRenameControlHandler runRename;

        public delegate string RunConvertControlHandler(string path);
        public event RunConvertControlHandler runConvert;

        public delegate void RunSaveControlHandler(Image image, InputFile inputFile, string name, string extension, bool modified);
        public event RunSaveControlHandler runSave;

        public delegate void ScaleModeHandler(string mode);
        public event ScaleModeHandler scaleMode;

        public delegate void ReadyHandler();
        public event ReadyHandler ready;

        public delegate void PaintImageHandler(Image image);
        public event PaintImageHandler paintImage;

        public delegate void WriteNameFieldHandler(string name);
        public event WriteNameFieldHandler writeNameField;

        public delegate bool ModifiedHandler(string name);
        public event ModifiedHandler modified;

        private bool stopped = false;

        private Thread thread;

        DateTime startTime;

        public ProcessControl()
        {
            InitializeComponent();
        }

        private void startTimer()
        {
            startTime = DateTime.Now;
        }

        delegate void ProcessBarHandler(int i, int size);

        private void setProcessBar(int i, int size)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new ProcessBarHandler(setProcessBar), new object[] { i, size });
            }
            else
            {
                if (i < 0 || i > size || size == 0) return;
                if (ProcessBar == null) return;

                int percent = (int)Math.Round((((double)i) / ((double)size)) * 100, 0);
                ProcessBar.Value = percent;

                if (i > 0)
                {
                    DateTime time = DateTime.Now;
                    DateTime pos = new DateTime((long)(time.Ticks - startTime.Ticks));
                    DateTime restPos = new DateTime((long)((pos.Ticks / i) * (size - i)));

                    string restPosString = String.Empty;
                    if (restPos.Hour == 1) restPosString += "1 hour ";
                    if (restPos.Hour > 1) restPosString += restPos.Hour.ToString() + " hours ";
                    if (restPos.Minute == 1) restPosString += "1 minute ";
                    if (restPos.Minute > 1) restPosString += restPos.Minute.ToString() + " minutes ";
                    if (restPos.Second == 1) restPosString += "1 second ";
                    if (restPos.Second > 1) restPosString += restPos.Second.ToString() + " seconds ";
                    if (restPosString == String.Empty) restPosString += "0 seconds ";

                    RemainingTime.Text = restPosString + "remaining";
                    StatusPercent.Text = percent.ToString() + "% (" + i.ToString() + "/" + size.ToString() + ")";
                }
                else
                {

                    RemainingTime.Text = "started";
                    StatusPercent.Text = percent.ToString() + "% (" + i.ToString() + "/" + size.ToString() + ")";
                }
            }
        }

        public void start()
        {
            this.Visible = true;
            stopped = false;
            
            thread = new Thread(run);
            thread.Start();
        }

        public void stop()
        {
            this.Visible = false;
            stopped = true;
        }

        private void run()
        {
            if (getInputFilesList == null) return;

            List<InputFile> list = getInputFilesList();

            if (list.Count == 0 && ready != null)
            {
                ready();
                return;
            }

            if (getActivateStateForProcess("Resize") == true && scaleMode != null)
            {
                scaleMode("Original");
            }
            else
            {
                scaleMode("Fit");
            }

            setProcessBar(0, list.Count);

            startTimer();
            int i = 0;
            foreach (InputFile inputFile in list)
            {
                DateTime start = DateTime.Now;

                if (stopped) break;

                string path = inputFile.path;
                string root = inputFile.root;
                string extension = Path.GetExtension(path).Replace(".", ""); ;
                string name = Path.GetFileNameWithoutExtension(path);

                try
                {
                    if (inputFile.IsImage)
                    {
                        Image image = ImageControl.LoadImageFromFile(path);

                        if (getActivateStateForProcess("Rotate") && runRotate != null)
                        {
                            /*
                            if (scaleMode != null && getActivateStateForProcess("Resize") == false)
                                scaleMode("Fit");
                            */
                            image = runRotate(image);
                        }
                        if (getActivateStateForProcess("Resize") && runResize != null)
                        {
                            /*
                            if (scaleMode != null)
                                scaleMode("Original");
                            */
                            image = runResize(image);
                        }
                        if (getActivateStateForProcess("Rename") && runRename != null && initRename != null)
                        {
                            initRename();
                            name = runRename(path, image);
                        }
                        if (getActivateStateForProcess("Convert") && runConvert != null)
                        {
                            extension = runConvert(path);
                        }
                        if (getActivateStateForProcess("Save") && runSave != null)
                        {
                            if (modified("Rotate") || modified("Resize") || modified("Rename") || modified("Convert"))
                            {
                                runSave(image, inputFile, name, extension, true);
                            }
                            else
                            {
                                runSave(image, inputFile, name, extension, false);
                            }
                        }

                        if (DisplayModifiedImages.Checked && paintImage != null && writeNameField != null)
                        {
                            paintImage(image);
                            writeNameField(name + "." + extension);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The image " + Path.GetFileName(inputFile.path) + " couldn't be opened. Is it open in another program? The File will be skipped. Exception:"+ex.ToString());
                }

                i++;
                setProcessBar(i, list.Count);

                DateTime end = DateTime.Now;
                DateTime diff = new DateTime(end.Ticks - start.Ticks);
                //MessageBox.Show(name + " (" + modified("Rotate").ToString() + ") - " + diff.Second.ToString() + ":" + diff.Millisecond.ToString());
            }

            if (ready != null)
            {
                DateTime time = new DateTime(DateTime.Now.Ticks - startTime.Ticks);
                double absSec = time.Hour * 3600 + time.Minute * 60 + time.Second;
                MessageBox.Show("Ready with " + i.ToString() + " files (" +
                    String.Format("{0:00}", time.Hour) + ":" + String.Format("{0:00}", time.Minute) + ":" + String.Format("{0:00}", time.Second) + " - "+Math.Round(((double)i+1)/absSec, 1)+" files/sec)");
                ready();
            }
        }
    }
}
