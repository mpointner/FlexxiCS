// Sample application that demonstrates a simple shell context menu.
// Ralph Arvesen (www.vertigo.com / www.lostsprings.com)

using System;
using System.Diagnostics;
using Microsoft.Win32;

namespace SimpleContextMenu
{
	/// <summary>
	/// Register and unregister simple shell context menus.
	/// </summary>
	static class FileShellExtension
	{
		/// <summary>
		/// Register a simple shell context menu.
		/// </summary>
		/// <param name="fileType">The file type to register.</param>
		/// <param name="shellKeyName">Name that appears in the registry.</param>
		/// <param name="menuText">Text that appears in the context menu.</param>
		/// <param name="menuCommand">Command line that is executed.</param>
		public static void Register(
			string fileType, string shellKeyName, 
			string menuText, string menuCommand)
		{
			Debug.Assert(!string.IsNullOrEmpty(fileType) &&
				!string.IsNullOrEmpty(shellKeyName) &&
				!string.IsNullOrEmpty(menuText) && 
				!string.IsNullOrEmpty(menuCommand));
			
			// create full path to registry location
			string regPath = string.Format(@"{0}\shell\{1}", fileType, shellKeyName);

			// add context menu to the registry
			using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(regPath))
			{
                key.SetValue(null, menuText);
                key.SetValue("Icon", @"C:\Users\Michael\Documents\Visual Studio 2008\Projects\Flexxi\Flexxi\images\favicon.ico");
            }
			
			// add command that is invoked to the registry
			using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(
				string.Format(@"{0}\command", regPath)))
			{				
				key.SetValue(null, menuCommand);
            }
		}

		/// <summary>
		/// Unregister a simple shell context menu.
		/// </summary>
		/// <param name="fileType">The file type to unregister.</param>
		/// <param name="shellKeyName">Name that was registered in the registry.</param>
		public static void Unregister(string fileType, string shellKeyName)
		{
			Debug.Assert(!string.IsNullOrEmpty(fileType) &&
				!string.IsNullOrEmpty(shellKeyName));

			// full path to the registry location			
			string regPath = string.Format(@"{0}\shell\{1}", fileType, shellKeyName);

			// remove context menu from the registry
			Registry.ClassesRoot.DeleteSubKeyTree(regPath);
        }

        /// <summary>
        /// Unregister a simple shell context menu.
        /// </summary>
        /// <param name="fileType">The file type to unregister.</param>
        /// <param name="shellKeyName">Name that was registered in the registry.</param>
        public static bool Exists(string fileType, string shellKeyName)
        {
            Debug.Assert(!string.IsNullOrEmpty(fileType) &&
                !string.IsNullOrEmpty(shellKeyName));

            // full path to the registry location			
            string regPath = string.Format(@"{0}\shell\{1}", fileType, shellKeyName);

            // remove context menu from the registry
            //Registry.ClassesRoot.DeleteSubKeyTree(regPath);
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(regPath);

            if (key != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Unregister a simple shell context menu.
        /// </summary>
        /// <param name="fileType">The file type to unregister.</param>
        /// <param name="shellKeyName">Name that was registered in the registry.</param>
        public static string getValues(string fileType, string shellKeyName)
        {
            Debug.Assert(!string.IsNullOrEmpty(fileType) &&
                !string.IsNullOrEmpty(shellKeyName));

            // full path to the registry location			
            string regPath = string.Format(@"{0}\shell\{1}", fileType, shellKeyName);

            // remove context menu from the registry
            //Registry.ClassesRoot.DeleteSubKeyTree(regPath);
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(regPath);

            string sum = String.Empty;
            foreach (string name in key.GetValueNames())
            {
                sum += name + Environment.NewLine;
            }

            return sum;
        }
	}

}
