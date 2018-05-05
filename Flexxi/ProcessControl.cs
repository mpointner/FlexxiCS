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

namespace Flexxi
{
    public partial class ProcessControl : UserControlVorlage
    {
        public delegate List<InputFile> GetInputFilesListHandler();
        public event GetInputFilesListHandler getInputFilesList;

        public delegate bool GetActivateStateForProcessHandler(string name);
        public event GetActivateStateForProcessHandler getActivateStateForProcess;

        public delegate Image RunResizeControlHandler(Image image);
        public event RunResizeControlHandler runResize;

        public delegate Image RunRotateControlHandler(Image image);
        public event RunRotateControlHandler runRotate;

        public delegate void InitControlHandler();
        public event InitControlHandler init;

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

        public delegate bool SkipErrorHandler();
        public event SkipErrorHandler skipErrorActivated;

        public delegate bool OtherFilesCopyHandler();
        public event OtherFilesCopyHandler otherFilesCopyActivated;

        public delegate string GetDirForCopyHandler(InputFile inputFile);
        public event GetDirForCopyHandler getDirForCopy;

        public delegate bool DirCopyHandler();
        public event DirCopyHandler dirCopyActivated;

        public delegate byte AlertHandler(string file, byte fehler);
        public event AlertHandler alert;

        public delegate void SetWindowTextHandler(string text);
        public event SetWindowTextHandler setWindowText;

        public delegate void SetWindowInitTextHandler();
        public event SetWindowInitTextHandler setWindowInitText;

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

        private String hour = Data.translate("hour");
        private String hours = Data.translate("hours");
        private String minute = Data.translate("minute");
        private String minutes = Data.translate("minutes");
        private String second = Data.translate("second");
        private String seconds = Data.translate("seconds");
        private String remaining = Data.translate("remaining");
        private String started = Data.translate("started");
        private String readyWith = Data.translate("Ready with");
        private String files = Data.translate("files");
        private String duration = Data.translate("Duration");
        private String readyTranslated = Data.translate("Ready");

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

                setWindowText(percent.ToString()+"%");

                if (i > 0)
                {
                    DateTime time = DateTime.Now;
                    DateTime pos = new DateTime((long)(time.Ticks - startTime.Ticks));
                    DateTime restPos = new DateTime((long)((pos.Ticks / i) * (size - i)));

                    string restPosString = String.Empty;
                    if (restPos.Hour == 1) restPosString += "1 "+hour+" ";
                    if (restPos.Hour > 1) restPosString += restPos.Hour.ToString() + " "+hours+" ";
                    if (restPos.Minute == 1) restPosString += "1 "+minute+" ";
                    if (restPos.Minute > 1) restPosString += restPos.Minute.ToString() + " "+minutes+" ";
                    if (restPos.Second == 1) restPosString += "1 "+second+" ";
                    if (restPos.Second > 1) restPosString += restPos.Second.ToString() + " "+seconds+" ";
                    if (restPosString == String.Empty) restPosString += "0 "+seconds+" ";

                    RemainingTime.Text = restPosString + remaining;
                    StatusPercent.Text = percent.ToString() + "% (" + i.ToString() + "/" + size.ToString() + ")";
                }
                else
                {

                    RemainingTime.Text = started;
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
            setWindowInitText();
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

            init();

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

                Retry:

                try
                {
                    if (inputFile.IsImage && extension != "")
                    {
                        Image image = (inputFile.image == null ? ImageControl.LoadImageFromFile(inputFile.path) : ((Image)inputFile.image.Clone()));

                        if (getActivateStateForProcess("Rotate") && runRotate != null)
                        {
                            /*
                            if (scaleMode != null && getActivateStateForProcess("Resize") == false)
                                scaleMode("Fit");
                            */
                            image = runRotate(image);
                        }
                        if (getActivateStateForProcess("Rename") && runRename != null)
                        {
                            name = runRename(path, image);
                        }
                        if (getActivateStateForProcess("Resize") && runResize != null)
                        {
                            /*
                            if (scaleMode != null)
                                scaleMode("Original");
                            */
                            image = runResize(image);
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
                    else if (otherFilesCopyActivated() || dirCopyActivated())
                    {
                        string outputDir = getDirForCopy(inputFile);

                        FileAttributes attr = File.GetAttributes(path);
                        if ((attr & FileAttributes.Directory) == FileAttributes.Directory && dirCopyActivated())
                        {
                            if (Directory.Exists(outputDir + name) == false)
                            {
                                Directory.CreateDirectory(outputDir + name);
                            }
                        }
                        else if ((attr & FileAttributes.Directory) != FileAttributes.Directory && otherFilesCopyActivated())
                        {
                            if (!File.Exists(outputDir + name + (extension != "" ? "." : "") + extension))
                            {
                                File.Copy(path, outputDir + name + (extension != "" ? "." : "") + extension);
                            }
                        }
                    }
                }
                catch (FileNotFoundException ex)
                {
                    byte answer = alert(path, Fehler.ErrorCantReadFile);
                    if (answer == Fehler.Abort) break;
                    if (answer == Fehler.Repeat) goto Retry;
                    if (answer == Fehler.Skip) continue;
                }
                catch (IOException ex)
                {
                    byte answer = alert(path, Fehler.ErrorCantWriteFile);
                    if (answer == Fehler.Abort) break;
                    if (answer == Fehler.Repeat) goto Retry;
                    if (answer == Fehler.Skip) continue;
                }
                catch (Exception ex)
                {
                    /*
                    if (skipErrorActivated == null || skipErrorActivated() == false)
                    {
                        MessageBox.Show("The image " + Path.GetFileName(inputFile.path) + " couldn't be opened. Is it open in another program? The File will be skipped.\n\nException:" + ex.ToString());
                    }
                    */
                    MessageBox.Show("Unhandled Exception: " + ex.ToString());
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
                double absSec = time.Hour * 3600 + time.Minute * 60 + time.Second + ((double)time.Millisecond) / 1000;
                String successMessage = readyWith+" " + i.ToString() + " "+files+" ("+duration+": " +
                    String.Format("{0:00}", time.Hour) + ":" + 
                    String.Format("{0:00}", time.Minute) + ":" + 
                    String.Format("{0:00}", time.Second) + "." + 
                    String.Format("{0:000}", time.Millisecond) + " - " + Math.Round(((double)i*100) / absSec)/100 + " "+files+"/"+second+")";
                MessageBox.Show(successMessage, readyTranslated);
                ready();
                setWindowInitText();
            }
        }
    }
}
