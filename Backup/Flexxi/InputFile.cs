using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace ImageFrame
{
    public class InputFile
    {
        // Input Values
        public readonly string path;
        public readonly string root;

        // Output Values
        public string name;


        private readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPE",  ".GIF", ".PNG" };
        public bool IsImage = false;

        public InputFile(string path, string root)
        {
            this.path = path;
            this.root = root;

            if (ImageExtensions.Contains(Path.GetExtension(path).ToUpperInvariant()))
            {
                IsImage = true;
            }
            else
            {
                IsImage = false;
            }
        }
    }
}
