using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SimpleContextMenu;
using System.Diagnostics;
using System.Security.Principal;
using System.Threading;
using System.Runtime.InteropServices;
using Flexxi;
using System.Timers;
using WshShell = IWshRuntimeLibrary.WshShell;
using IWShShortcut = IWshRuntimeLibrary.IWshShortcut;
using System.IO;
using Flexxi.Properties;
using System.Drawing;

namespace Flexxi
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");

        static bool canceled = false;

        static MainForm form;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //registerContextMenu(args);

            if (!Program.canceled)
            {
                initSettingsFolder();

                openSelectLanguage();

                Data.load();

                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                form = new MainForm(args);
                Application.Run(form);
            }
        }

        public static void reTranslate()
        {
            form.start(new string[] { });
        }

        public static bool SendArgs(IntPtr targetHWnd, string args)
        {
            Win32.CopyDataStruct cds = new Win32.CopyDataStruct();
            try
            {
                cds.cbData = (args.Length + 1) * 2;
                cds.lpData = Win32.LocalAlloc(0x40, cds.cbData);
                Marshal.Copy(args.ToCharArray(), 0, cds.lpData, args.Length);
                cds.dwData = (IntPtr)1;
                Win32.SendMessage(targetHWnd, Win32.WM_COPYDATA, IntPtr.Zero, ref cds);
            }
            finally
            {
                cds.Dispose();
            }

            return true;
        }

        /*
        private static String doYouWantToAddThisProgramToTheContextMenu = Data.translate("Do you want to add this program to the context menu?");
        private static String flexxiWindowText = Data.translate("Flexxi - The flexible Image Resizer");


        private static void registerContextMenu(string[] args)
        {
            if (args.Length == 0)
            {
                initFileTypes();

                if (!Program.registered()) // old: !FileShellExtension.Exists(FileType, KeyName)
                {

                    DialogResult result = MessageBox.Show(doYouWantToAddThisProgramToTheContextMenu, flexxiWindowText, MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Program.register();

                        /*
                        if (IsAdministrator() == false)
                        {
                            // Restart program and run as admin
                            var exeName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
                            ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
                            startInfo.Verb = "runas";
                            startInfo.Arguments = "-register";
                            System.Diagnostics.Process.Start(startInfo);
                            //Application.Current.Shutdown();
                            Program.canceled = true;
                            Application.Exit(new System.ComponentModel.CancelEventArgs(true));
                            return;
                        }
                        else
                        {
                            Program.register();
                        }
                        /
                    }
                }
                else
                {
                    string messageBoxText = "Do you want to remove this program from the context menu?";
                    string caption = "Flexxi - Der flexible Bildbearbeiter";

                    DialogResult result = MessageBox.Show(messageBoxText, caption, MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Program.unregister();

                        /*
                        if (IsAdministrator() == false)
                        {
                            // Restart program and run as admin
                            var exeName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
                            ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
                            startInfo.Verb = "runas";
                            startInfo.Arguments = "-unregister";
                            System.Diagnostics.Process.Start(startInfo);
                            //Application.Current.Shutdown();
                            Program.canceled = true;
                            Application.Exit(new System.ComponentModel.CancelEventArgs(true));
                            return;
                        }
                        else
                        {
                            Program.unregister();
                        }
                        /
                    }
                }
            }
        }

        static string FileType = "jpegfile";
        static List<string> FileTypes = null;
        static string KeyName = "Flexxi";
        static string MenuText = "Edit with Flexxi";

        private static void initFileTypes()
        {
            FileTypes = new List<string>();
            FileTypes.Add("jpegfile");
            FileTypes.Add("giffile");
            FileTypes.Add("pngfile");
        }
        
        */

        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Flexxi";
        private static string iconpath = path + @"\favicon.ico";
        private static string settingspath = path + @"\Settings.settings";

        public static void initSettingsFolder()
        {
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            
            if(!File.Exists(iconpath))
            {
                Icon ico = Resources.favicon;
                using (FileStream fs = new FileStream(iconpath, FileMode.Create))
                {
                    ico.Save(fs);
                }
            }
        }

        private static void openSelectLanguage()
        {
            Data.initLanguages();
            if (Settings.Default.FirstStart == true)
            {
                SelectLanguage form = new SelectLanguage();
                DialogResult result = form.ShowDialog();
            }
        }

        public static void register()
        {
            // full path to self, %L is placeholder for selected file
            /*
            string menuCommand = string.Format(
                    "\"{0}\" \"%L\"", Application.ExecutablePath);
            
            // register the context menu
            FileShellExtension.Register(Program.FileType,
                Program.KeyName, Program.MenuText,
                menuCommand);
            */

            WshShell theShell = new WshShell();
            IWShShortcut theLink = (IWShShortcut) theShell.CreateShortcut((Environment.GetFolderPath(Environment.SpecialFolder.SendTo) + "\\Flexxi.lnk"));
            theLink.TargetPath = Application.ExecutablePath;
            theLink.Description = "Flexxi - Der flexible Bildbearbeiter";
            theLink.IconLocation = iconpath;
            theLink.Save();

            //MessageBox.Show("Registered");
        }

        public static bool registered()
        {
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
            return File.Exists(dir + "\\Flexxi.lnk");
        }

        public static void unregister()
        {
            // unregister the context menu
            //FileShellExtension.Unregister(Program.FileType, Program.KeyName);

            if(File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.SendTo)+"\\Flexxi.lnk"))
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.SendTo) + "\\Flexxi.lnk");
            }

            //MessageBox.Show("Unregistered");
        }
        /*
        private static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        */
    }
}
