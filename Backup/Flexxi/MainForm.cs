using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Flexxi;
using System.Runtime.InteropServices;
using Flexxi.Properties;

namespace ImageFrame
{
    public partial class MainForm : Form
    {
        bool dragAndDropEnabled = true;

        public MainForm(string[] args)
        {
            InitializeComponent();

            init();

            //InputControl.LoadFolder(@"C:\Users\Michael\Desktop");
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form_DragEnter);
            this.DragDrop += new DragEventHandler(Form_DragDrop);

            if (args.Length > 0)
            {
                if(args[0] == "-register" || args[0] == "-unregister")
                {
                    paintInitImage();
                }
                else
                {
                    InputControl.LoadFiles(args);
                }
            }
            else
            {
                paintInitImage();
            }

        }

        private void paintInitImage()
        {
            ImageControl.PaintEditImage(Resources.StartImage);
        }

        private void init()
        {
            InputControl.LoadImage += new InputControl.LoadImageHandler(ImageControl.LoadImage);
            InputControl.stopNext += new InputControl.StopNextHandler(ImageControl.stopNext);
            InputControl.stopPrevious += new InputControl.StopPreviousHandler(ImageControl.stopPrevious);

            ImageControl.next += new ImageControl.NextHandler(InputControl.next);
            ImageControl.previous +=    new ImageControl.PreviousHandler(InputControl.previous);
            ImageControl.test += new ImageControl.TestHandler(Event_Test);

            EditControl.RepaintImage += new EditControl.RepaintImageHandler(ImageControl.RePaintImage);
            EditControl.scaleMode += new EditControl.ScaleModeHandler(Event_ScaleMode);
            EditControl.getImage += new EditControl.GetImageHandler(Event_GetImage);
            EditControl.setImage += new EditControl.SetImageHandler(Event_SetImage);
            EditControl.getName += new EditControl.GetNameHandler(Event_GetName);
            EditControl.setName += new EditControl.SetNameHandler(Event_SetName);
            EditControl.getPath += new EditControl.GetPathHandler(Event_GetPath);
            EditControl.setPath += new EditControl.SetPathHandler(Event_SetPath);
            EditControl.getExtension += new EditControl.GetExtensionHandler(Event_GetExtension);
            EditControl.setExtension += new EditControl.SetExtensionHandler(Event_SetExtension);
            EditControl.start += new EditControl.StartHandler(Event_Start);
            EditControl.stop += new EditControl.StopHandler(Event_Stop);
            EditControl.closeForm += new EditControl.CloseFormHandler(Event_CloseForm);
            EditControl.activateInput += new EditControl.ActivateInputHandler(Event_ActivateInput);
            EditControl.dragNDrop += new EditControl.DragNDropHandler(Event_DragNDrop);

            EditControl.rotateControl.activate += new RotateControl.ActivateHandler(Event_Activate);
            EditControl.rotateControl.test += new RotateControl.TestHandler(Event_Test);
            EditControl.rotateControl.getImage += new RotateControl.GetImageHandler(Event_GetImage);
            EditControl.rotateControl.setImage += new RotateControl.SetImageHandler(Event_SetImage);

            EditControl.resizeControl.activate += new ResizeControl.ActivateHandler(Event_Activate);
            EditControl.resizeControl.test += new ResizeControl.TestHandler(Event_Test);
            EditControl.resizeControl.getImage += new ResizeControl.GetImageHandler(Event_GetImage);
            EditControl.resizeControl.setImage += new ResizeControl.SetImageHandler(Event_SetImage);

            EditControl.renameControl.activate += new RenameControl.ActivateHandler(Event_Activate);
            EditControl.renameControl.test += new RenameControl.TestHandler(Event_Test);
            EditControl.renameControl.getName += new RenameControl.GetNameHandler(Event_GetName);
            EditControl.renameControl.setName += new RenameControl.SetNameHandler(Event_SetName);
            EditControl.renameControl.getPath += new RenameControl.GetPathHandler(Event_GetPath);
            EditControl.renameControl.setPath += new RenameControl.SetPathHandler(Event_SetPath);
            EditControl.renameControl.getExtension += new RenameControl.GetExtensionHandler(Event_GetExtension);
            EditControl.renameControl.setExtension += new RenameControl.SetExtensionHandler(Event_SetExtension);
            EditControl.renameControl.getIndex += new RenameControl.GetIndexHandler(Event_GetIndex);
            EditControl.renameControl.getImage += new RenameControl.GetImageHandler(Event_GetImage);

            EditControl.convertControl.activate += new ConvertControl.ActivateHandler(Event_Activate);
            EditControl.convertControl.test += new ConvertControl.TestHandler(Event_Test);
            EditControl.convertControl.getExtension += new ConvertControl.GetExtensionHandler(Event_GetExtension);
            EditControl.convertControl.setExtension += new ConvertControl.SetExtensionHandler(Event_SetExtension);
            EditControl.convertControl.getPath += new ConvertControl.GetPathHandler(Event_GetPath);
            EditControl.convertControl.setPath += new ConvertControl.SetPathHandler(Event_SetPath);

            EditControl.saveControl.activate += new SaveControl.ActivateHandler(Event_Activate);
            EditControl.saveControl.test += new SaveControl.TestHandler(Event_Test);
            EditControl.saveControl.getInputFile += new SaveControl.GetInputFileHandler(Event_GetInputFile);

            ProcessControl.getInputFilesList += new ProcessControl.GetInputFilesListHandler(Event_GetInputFilesList);
            ProcessControl.getActivateStateForProcess += new ProcessControl.GetActivateStateForProcessHandler(Event_GetActivateStateForProcess);
            ProcessControl.runResize += new ProcessControl.RunResizeControlHandler(Event_RunResize);
            ProcessControl.runRotate += new ProcessControl.RunRotateControlHandler(Event_RunRotate);
            ProcessControl.initRename += new ProcessControl.InitRenameControlHandler(Event_InitRename);
            ProcessControl.runRename += new ProcessControl.RunRenameControlHandler(Event_RunRename);
            ProcessControl.runConvert += new ProcessControl.RunConvertControlHandler(Event_RunConvert);
            ProcessControl.runSave += new ProcessControl.RunSaveControlHandler(Event_RunSave);
            ProcessControl.scaleMode += new ProcessControl.ScaleModeHandler(Event_ScaleMode);
            ProcessControl.ready += new ProcessControl.ReadyHandler(Event_Ready);
            ProcessControl.paintImage += new ProcessControl.PaintImageHandler(Event_PaintImage);
            ProcessControl.writeNameField += new ProcessControl.WriteNameFieldHandler(Event_WriteNameField);
            ProcessControl.modified += new ProcessControl.ModifiedHandler(Event_Modified);

        }

        void Event_DragNDrop(bool activate)
        {
            this.AllowDrop = activate;
        }

        bool Event_Modified(string name)
        {
            return EditControl.modified(name);
        }

        void Event_ActivateInput(bool activate)
        {
            InputControl.activateInput(activate);
            dragAndDropEnabled = activate;
        }

        delegate void WriteNameFieldHandler(string text);

        void Event_WriteNameField(string text)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new WriteNameFieldHandler(Event_WriteNameField), new object[] { text });
            }
            else
            {
                ImageControl.writeNameLabel(text);
            }
        }

        delegate void PaintImageHandler(Image image);

        void Event_PaintImage(Image image)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new PaintImageHandler(Event_PaintImage), new object[] { image });
            }
            else
            {
                ImageControl.PaintImage(image);
            }
        }

        delegate void CloseFormHandler();

        void Event_CloseForm()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CloseFormHandler(Event_CloseForm));
            }
            else
            {
                this.Dispose();
                Application.Exit();
            }
        }

        void Event_Ready()
        {
            EditControl.ready();
        }

        void Event_Stop()
        {
            ProcessControl.stop();
        }

        void Event_Start()
        {
            ProcessControl.start();
        }

        void Event_RunSave(Image image, InputFile inputFile, string name, string extension, bool modified)
        {
            EditControl.saveControl.run(image, inputFile, name, extension, modified);
        }

        string Event_RunConvert(string path)
        {
            return EditControl.convertControl.run(path);
        }

        string Event_RunRename(string path, Image image)
        {
            return EditControl.renameControl.run(path, image);
        }

        void Event_InitRename()
        {
            EditControl.renameControl.init();
        }

        Image Event_RunRotate(Image image)
        {
            return EditControl.rotateControl.run(image);
        }

        Image Event_RunResize(Image image)
        {
            return EditControl.resizeControl.run(image);
        }

        bool Event_GetActivateStateForProcess(string name)
        {
            return EditControl.GetActivateStateForProcess(name);
        }

        List<InputFile> Event_GetInputFilesList()
        {
            return InputControl.GetInputFilesList();
        }

        int Event_GetIndex()
        {
            return InputControl.GetIndex();
        }

        InputFile Event_GetInputFile()
        {
            return ImageControl.OrgInputFile;
        }

        void Event_Test()
        {
            EditControl.Test();
        }

        void Event_SetExtension(string extension)
        {
            ImageControl.OrgImageExtension = extension;
        }

        string Event_GetExtension()
        {
            return ImageControl.OrgImageExtension;
        }

        private void Event_SetPath(string path)
        {
            ImageControl.OrgImagePath = path;
            ImageControl.OrgImageName = Path.GetFileName(path);
        }

        private string Event_GetPath()
        {
            return ImageControl.OrgImagePath;
        }

        private void Event_SetName(string name)
        {
            ImageControl.OrgImageName = name;
        }

        private string Event_GetName()
        {
            return ImageControl.OrgImageName;
        }

        private Image Event_GetImage()
        {
            return ImageControl.OrgImage;
        }

        private void Event_SetImage(Image image)
        {
            ImageControl.PaintEditImage(image);
        }

        private void Event_Activate(bool activ, object sender)
        {
            EditControl.SetActivateState(activ, sender);
        }

        private void Event_ScaleMode(string mode)
        {
            ImageControl.ScaleMode(mode);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            ImageControl.RePaintImage();
            EditControl.resize();
        }

        void Form_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form_DragDrop(object sender, DragEventArgs e)
        {
            if (dragAndDropEnabled)
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                InputControl.LoadFiles(files);
            }
            else
            {
                MessageBox.Show("No Drag´n Drop allowed while execution!");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EditControl.closeFormWhenReady == false && EditControl.running == true)
            {
                EditControl.closeFormWhenReady = true;
                EditControl.stopProcess();
                this.Visible = false;
                e.Cancel = true;
            }
            else
            {
                this.Dispose();
            }
        }
    }
}
