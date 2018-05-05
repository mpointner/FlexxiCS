using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace Flexxi
{
    public class InputFile
    {
        // Input Values
        public readonly string path = "";
        public readonly string root = "";
        public readonly Image image = null;

        // Output Values
        public string name;

        public delegate void LoadImageHandler(InputFile inputFile);
        public static event LoadImageHandler LoadImage;


        private readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPE",  ".GIF", ".PNG" };
        public bool IsImage = false;

        public InputFile(string path, string root)
        {
            this.path = path;
            this.root = root;

            if (ImageExtensions.Contains(Path.GetExtension(path).ToUpperInvariant()))
            {
                IsImage = true;

                if(InputControl.loadedInitImage == false)
                {
                    LoadImage(this);
                    InputControl.loadedInitImage = true;
                }
            }
            else
            {
                IsImage = false;
            }
        }

        private static int clipboard_counter = 0;

        public InputFile(Image image)
        {
            this.image = image;
            this.root = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\";
            this.name = String.Format("{0:000}", clipboard_counter) + ".jpg";
            this.path = this.root + this.name;
            IsImage = true;
            clipboard_counter++;

            if (InputControl.loadedInitImage == false)
            {
                LoadImage(this);
                InputControl.loadedInitImage = true;
            }
        }
    }
}
